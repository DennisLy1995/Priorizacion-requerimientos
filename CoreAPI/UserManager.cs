using DataAccess.Crud;
using Entities_POJO;
using Exceptions;
using System;
using System.Collections.Generic;

namespace CoreAPI
{
    public class UserManager : BaseManager
    {
        private UserCrudFactory crudUser;

        public UserManager()
        {
            crudUser = new UserCrudFactory();
        }

        public void Create(BaseEntity entity)
        {
            try
            {
                var nObj = (User)entity;
                var resultId = crudUser.Retrieve<User>(nObj);
                var resultUser = crudUser.RetrieveByUser<User>(nObj);

                if (resultId == null && resultUser == null)
                    crudUser.Create(nObj);
                else if (resultUser != null && nObj.UserName.Equals(resultUser.UserName))
                    throw new BusinessException(5);
                else if (resultId != null && nObj.Id.Equals(resultId.Id))
                    throw new BusinessException(6);
                else
                    throw new BusinessException(3);
            }
            catch (Exception error)
            {
                ExceptionManager.GetInstance().Process(error);
            }
        }

        public User RetrieveByID(User entity)
        {
            User nClient = null;

            try
            {
                nClient = crudUser.Retrieve<User>(entity);

                if (nClient == null)
                    throw new BusinessException(4);
            }
            catch (Exception error)
            {
                ExceptionManager.GetInstance().Process(error);
            }

            return nClient;
        }

        public User RetrieveByUser(User entity)
        {
            User nClient = null;

            try
            {
                nClient = crudUser.RetrieveByUser<User>(entity);

                if (nClient == null)
                    throw new BusinessException(4);
            }
            catch (Exception error)
            {
                ExceptionManager.GetInstance().Process(error);
            }

            return nClient;
        }

        public List<User> RetrieveAll()
        {
            return crudUser.RetrieveAll<User>();
        }

        public void Update(BaseEntity entity)
        {
            crudUser.Update(entity);
        }

        public void Delete(BaseEntity entity)
        {
            crudUser.Delete(entity);
        }
    }
}
