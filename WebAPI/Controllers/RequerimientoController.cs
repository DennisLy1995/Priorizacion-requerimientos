using CoreAPI;
using Entities_POJO;
using Exceptions;
using Newtonsoft.Json;
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
    [RoutePrefix("api/Requerimiento")]
    public class RequerimientoController : ApiController
    {

        ApiResponse apiResp = new ApiResponse();

        // GET api/caso
        [HttpGet]
        public IHttpActionResult Get()
        {

            apiResp = new ApiResponse();
            var mng = new RequerimientoManager();
            apiResp.Data = mng.RetrieveAll();

            return Ok(apiResp);
        }

        // GET api/caso/buscar
        [HttpGet]
        [Route("GetByCodigo/{Codigo}")]
        public IHttpActionResult GetByCodigo(String Codigo)
        {
            try
            {
                var mng = new RequerimientoManager();
                var requerimiento = new Requerimientos
                {
                    CODIGO = Codigo
                };

                requerimiento = mng.RetrieveById(requerimiento);
                apiResp = new ApiResponse();
                apiResp.Data = requerimiento;
                return Ok(apiResp);
            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionId + "-" + bex.AppMessage.Message));
            }
        }

        
        [HttpGet]
        [Route("GetByID_Proyecto/{id_Proyecto}")]
        public IHttpActionResult GetByID_Proyecto(int id_Proyecto)
        {
            try
            {
                var mng = new RequerimientoManager();
                Object cantidad = 0;
                cantidad = mng.RetrieveRequerimentsRegistered(id_Proyecto);
                apiResp = new ApiResponse();
                apiResp.Data = cantidad;
                return Ok(cantidad);
            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionId + "-" + bex.AppMessage.Message));
            }
            
        }

        // POST 
        [HttpPost]
        public IHttpActionResult Post(Requerimientos requerimiento)
        {
            try
            {
                var mng = new RequerimientoManager();
                String response = mng.Create(requerimiento);

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
        [HttpPut]
        public IHttpActionResult Put(Requerimientos requerimiento)
        {
            try
            {
                var mng = new RequerimientoManager();
                mng.Update(requerimiento);

                apiResp = new ApiResponse();
                apiResp.Message = "Action was executed.";

                return Ok(apiResp);
            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionId + "-" + bex.AppMessage.Message));
            }
        }


        [HttpPut]
        [Route("PutPrioridad")]
        public IHttpActionResult PutPrioridad(Requerimientos requerimiento)
        {
            try
            {
                var mng = new RequerimientoManager();
                mng.UpdatePriority(requerimiento);

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
        public IHttpActionResult Delete(Requerimientos requerimiento)
        {
            try
            {
                var mng = new RequerimientoManager();
                mng.Delete(requerimiento);

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
