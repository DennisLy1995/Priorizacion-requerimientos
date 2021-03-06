﻿using System;
using System.Collections.Generic;
using Entities_POJO;
using DataAccess.Mapper;
using DataAccess.Dao;

namespace DataAccess.Crud
{
    public class CasoDeUsoCrudFactory : CrudFactory
    {
        CasoDeUsoMapper mapper;

        public CasoDeUsoCrudFactory() : base()
        {
            mapper = new CasoDeUsoMapper();
            dao = SqlDao.GetInstance();
        }

        public override void Create(BaseEntity entity)
        {
            var caso = (CasoDeUso)entity;
            var sqlOperation = mapper.GetCreateStatement(caso);

            dao.ExecuteProcedure(sqlOperation);
        }

        public override T Retrieve<T>(BaseEntity entity)
        {
            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveStatement(entity));
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                dic = lstResult[0];
                var objs = mapper.BuildObject(dic);
                return (T)Convert.ChangeType(objs, typeof(T));
            }

            return default(T);
        }

        public override List<T> RetrieveAll<T>()
        {
            var lstCasos = new List<T>();

            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveAllStatement());
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                var objs = mapper.BuildObjects(lstResult);
                foreach (var c in objs)
                {
                    lstCasos.Add((T)Convert.ChangeType(c, typeof(T)));
                }
            }

            return lstCasos;
        }

        public override void Update(BaseEntity entity)
        {
            var caso = (CasoDeUso)entity;
            dao.ExecuteProcedure(mapper.GetUpdateStatement(caso));
        }

        public override void Delete(BaseEntity entity)
        {
            var caso = (CasoDeUso)entity;
            dao.ExecuteProcedure(mapper.GetDeleteStatement(caso));
        }
    }
}
