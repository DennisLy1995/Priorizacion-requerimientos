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
    public class CasoDeUsoController : ApiController
    {

        ApiResponse apiResp = new ApiResponse();

        // GET api/caso
        public IHttpActionResult Get()
        {

            apiResp = new ApiResponse();
            var mng = new CasoDeUsoManager();
            apiResp.Data = mng.RetrieveAll();

            return Ok(apiResp);
        }

        // GET api/caso/buscar
        public IHttpActionResult Get(string code)
        {
            try
            {
                var mng = new CasoDeUsoManager();
                var caso = new CasoDeUso
                {
                    CODIGO = code
                };

                caso = mng.RetrieveById(caso);
                apiResp = new ApiResponse();
                apiResp.Data = caso;
                return Ok(apiResp);
            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionId + "-" + bex.AppMessage.Message));
            }
        }

        // POST 
        public IHttpActionResult Post(CasoDeUso caso)
         {

            try
            {
                var mng = new CasoDeUsoManager();
                String response = mng.Create(caso);

                apiResp = new ApiResponse();
                apiResp.Message = response;

                return Ok(apiResp);
            }
            catch (BusinessException bex)
            {
                return Content(HttpStatusCode.BadRequest, bex);




            }
        }

        // PUT
        public IHttpActionResult Put(CasoDeUso caso)
        {
            try
            {
                var mng = new CasoDeUsoManager();
                String response = mng.Update(caso);

                apiResp = new ApiResponse();
                apiResp.Message = response;

                return Ok(apiResp);
            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionId + "-" + bex.AppMessage.Message));
            }
        }

        // DELETE 
        public IHttpActionResult Delete(CasoDeUso caso)
        {
            try
            {
                var mng = new CasoDeUsoManager();
                mng.Delete(caso);

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
