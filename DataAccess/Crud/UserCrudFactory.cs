using System;
using System.Collections.Generic;
using DataAccess.Dao;
using DataAccess.Mapper;
using Entities_POJO;

namespace DataAccess.Crud
{
    public class UserCrudFactory : CrudFactory
    {
        public UserMapper Mapper;

        public UserCrudFactory()
        {
            Mapper = new UserMapper();
            dao = SqlDao.GetInstance();
        }

        public override void Create(BaseEntity pEntity)
        {
            var nObj = (User)pEntity;
            var sqlOperation = Mapper.GetCreateStatement(nObj);
            dao.ExecuteProcedure(sqlOperation);
        }

        public override void Delete(BaseEntity pEntity)
        {
            var nObj = (User)pEntity;
            var sqlOperation = Mapper.GetDeleteStatement(nObj);
            dao.ExecuteProcedure(sqlOperation);
        }

        public override T Retrieve<T>(BaseEntity pEntity)
        {
            var nObj = (User)pEntity;
            var sqlOperation = Mapper.GetRetriveStatement(nObj);
            var results = dao.ExecuteQueryProcedure(sqlOperation);
            var dic = new Dictionary<string, object>();

            if (results.Count > 0)
            {
                dic = results[0];
                var objs = Mapper.BuildObject(dic);
                return (T)Convert.ChangeType(objs, typeof(T));
            }

            return default(T);
        }

        public T RetrieveByUser<T>(BaseEntity pEntity)
        {
            var nObj = (User)pEntity;
            var sqlOperation = Mapper.GetRetriveStatementByUser(nObj);
            var results = dao.ExecuteQueryProcedure(sqlOperation);
            var dic = new Dictionary<string, object>();

            if (results.Count > 0)
            {
                dic = results[0];
                var objs = Mapper.BuildObject(dic);
                return (T)Convert.ChangeType(objs, typeof(T));
            }

            return default(T);
        }

        public override List<T> RetrieveAll<T>()
        {
            var lstObj = new List<T>();
            var lstResult = dao.ExecuteQueryProcedure(Mapper.GetRetriveAllStatement());
            var dic = new Dictionary<string, object>();

            if (lstResult.Count > 0)
            {
                var objs = Mapper.BuildObjects(lstResult);
                foreach (var c in objs)
                {
                    lstObj.Add((T)Convert.ChangeType(c, typeof(T)));
                }
            }

            return lstObj;
        }

        public override void Update(BaseEntity pEntity)
        {
            var nObj = (User)pEntity;
            var sqlOperation = Mapper.GetUpdateStatement(nObj);
            dao.ExecuteProcedure(sqlOperation);
        }
    }
}
