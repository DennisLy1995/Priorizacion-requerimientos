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
    public class ClienteController : ApiController
    {

        ApiResponse apiResp = new ApiResponse();

        // GET api/cliente
        public IHttpActionResult Get()
        {

            apiResp = new ApiResponse();
            var mng = new ClienteManager();
            apiResp.Data = mng.RetrieveAll();

            return Ok(apiResp);
        }

        // GET api/cliente/buscar
        public IHttpActionResult Get(string code)
        {
            try
            {
                var mng = new ClienteManager();
                var cliente = new Cliente
                {
                    identificacion = code
                };

                cliente = mng.RetrieveById(cliente);
                apiResp = new ApiResponse();
                apiResp.Data = cliente;
                return Ok(apiResp);
            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionId + "-" + bex.AppMessage.Message));
            }
        }

        // POST 
        public IHttpActionResult Post(Cliente cliente)
         {

            try
            {
                var mng = new ClienteManager();
                String response = mng.Create(cliente);

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
        public IHttpActionResult Put(Cliente cliente)
        {
            try
            {
                var mng = new ClienteManager();
                String response = mng.Update(cliente);

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
        public IHttpActionResult Delete(Cliente cliente)
        {
            try
            {
                var mng = new ClienteManager();
                mng.Delete(cliente);

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
