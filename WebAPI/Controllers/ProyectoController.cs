using CoreAPI;
using Entities_POJO;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ExceptionFilter]
    public class ProyectoController : ApiController
    {
        ApiResponse apiResp = new ApiResponse();

        //// GET api/proyecto
        public IHttpActionResult Get()
        {

            apiResp = new ApiResponse();
            var mng = new ProyectoManager();
            apiResp.Data = mng.RetrieveAll();

            return Ok(apiResp);
        }


        //// GET api/proyecto
        [HttpGet]
        [Route("api/Proyecto/GetProyectosUsuario/{identificacion}")]
        public IHttpActionResult GetProyectosUsuario(string identificacion)
        {

            apiResp = new ApiResponse();
            var mng = new ProyectoManager();
            apiResp.Data = mng.RetrieveAllProyectosUsuario(identificacion);

            return Ok(apiResp);
        }


        // GET api/proyecto/buscar
        [HttpGet]
        public IHttpActionResult Get(string idUsuario, string nombre)
        {
            try
            {
                var mng = new ProyectoManager();
                var proyecto = new Proyecto
                {
                    IdUsuario = idUsuario,
                    Nombre = nombre
                };

                proyecto = mng.RetrieveById(proyecto);
                apiResp = new ApiResponse();
                apiResp.Data = proyecto;
                return Ok(apiResp);
            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionId + "-" + bex.AppMessage.Message));
            }
        }

        // POST 
        public IHttpActionResult Post(Proyecto proyecto)
        {
            try
            {
                var mng = new ProyectoManager();
                String response = mng.Create(proyecto);

                apiResp = new ApiResponse();
                apiResp.Message = "Action was executed.";

                return Ok(apiResp);
            }
            catch (BusinessException bex)
            {
                return Content(HttpStatusCode.BadRequest, bex);
            }
        }

        // PUT
        public IHttpActionResult Put(Proyecto proyecto)
        {
            try
            {
                var mng = new ProyectoManager();
                mng.Update(proyecto);

                apiResp = new ApiResponse();
                apiResp.Message = "Action was executed.";

                return Ok(apiResp);
            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionId + "-" + bex.AppMessage.Message));
            }
        }

        // DELETE 
        [HttpDelete]
        public IHttpActionResult Delete(int idProyecto)
        {
            try
            {
                var mng = new ProyectoManager();
                var proyecto = new Proyecto
                {
                    IdProyecto = idProyecto
                };
                mng.Delete(proyecto);

                apiResp = new ApiResponse();
                apiResp.Message = "Action was executed.";

                return Ok(apiResp);
            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionId + "-" + bex.AppMessage.Message));
            }
        }
    }
}
