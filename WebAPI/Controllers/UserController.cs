using CoreAPI;
using Entities_POJO;
using Exceptions;
using System;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ExceptionFilter]
    public class UserController : ApiController
    {
        ApiResponse apiResp = new ApiResponse();

        public IHttpActionResult Get()
        {
            apiResp = new ApiResponse();
            var mng = new UserManager();
            apiResp.Data = mng.RetrieveAll();

            return Ok(apiResp);
        }

        [Route("api/user/RetrieveById")]
        [HttpGet]
        public IHttpActionResult RetrieveById(string id)
        {
            try
            {
                var mng = new UserManager();
                var nObj = new User { Id = id };
                nObj = mng.RetrieveByID(nObj);
                apiResp = new ApiResponse() { Data = nObj };

                return Ok(apiResp);
            }

            catch (BusinessException error)
            {
                return InternalServerError(new Exception(error.ExceptionId + "-" + error.AppMessage.Message));
            }
        }

        [Route("api/user/RetrieveByUser")]
        [HttpGet]
        public IHttpActionResult RetrieveByUser(string pUserName)
        {
            try
            {
                var mng = new UserManager();
                var nObj = new User { UserName = pUserName };
                nObj = mng.RetrieveByUser(nObj);
                apiResp = new ApiResponse() { Data = nObj };

                return Ok(apiResp);
            }

            catch (BusinessException error)
            {
                return InternalServerError(new Exception(error.ExceptionId + "-" + error.AppMessage.Message));
            }
        }

        public IHttpActionResult Post(User nObj)
        {
            try
            {
                var mng = new UserManager();
                mng.Create(nObj);

                apiResp = new ApiResponse { Message = "El usuario " + nObj.UserName + " se registró exitosamente." };
                return Ok(apiResp);
            }
            catch (BusinessException error)
            {
                return InternalServerError(new Exception(error.ExceptionId + "-" + error.AppMessage.Message));

            }
        }

        public IHttpActionResult Put(User nObj)
        {
            try
            {
                var mng = new UserManager();
                mng.Update(nObj);

                apiResp = new ApiResponse { Message = "El usuario se actualizó exitosamente" };
                return Ok(apiResp);
            }
            catch (BusinessException error)
            {
                return InternalServerError(new Exception(error.ExceptionId + "-" + error.AppMessage.Message));
            }
        }

        public IHttpActionResult Delete(User pObj)
        {
            try
            {
                var mng = new UserManager();
                mng.Delete(pObj);
                apiResp = new ApiResponse { Message = "El usuario " + pObj.UserName + " se eliminó exitosamente" };
                return Ok(apiResp);
            }
            catch (BusinessException error)
            {
                return InternalServerError(new Exception(error.ExceptionId + "-" + error.AppMessage.Message));
            }
        }
    }
}
