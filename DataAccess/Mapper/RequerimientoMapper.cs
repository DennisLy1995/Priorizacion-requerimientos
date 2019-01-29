using DataAccess.Dao;
using Entities_POJO;
using System.Collections.Generic;

namespace DataAccess.Mapper
{
    public class RequerimientoMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const string DB_COL_ID_REQUERIMIENTO = "ID_REQUERIMIENTO";
        private const string DB_COL_CODIGO = "CODIGO";
        private const string DB_COL_PRIORIDAD = "PRIORIDAD";
        private const string DB_COL_DESCRIPCION = "DESCRIPCION";
        private const string DB_COL_ID_PROYECTO = "ID_PROYECTO";
        private const string DB_COL_ESTADO = "ESTADO";

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CREATE_REQUERIMIENTO_PR" };

            var c = (Requerimientos)entity;
            //operation.AddIntParam(DB_COL_ID_REQUERIMIENTO, c.ID_REQUERIMIENTO);
            operation.AddStringParam(DB_COL_CODIGO, c.CODIGO);
            operation.AddDoubleParam(DB_COL_PRIORIDAD, c.PRIORIDAD);
            operation.AddStringParam(DB_COL_DESCRIPCION, c.DESCRIPCION);
            operation.AddIntParam(DB_COL_ID_PROYECTO, c.ID_PROYECTO);
            operation.AddBooleanParam(DB_COL_ESTADO, c.ESTADO);

            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_REQUERIMIENTO_PR" };

            var c = (Requerimientos)entity;
            operation.AddStringParam(DB_COL_CODIGO, c.CODIGO);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_REQUERIMIENTOS" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_REQUERIMIENTO_PR" };

            var c = (Requerimientos)entity;
            //operation.AddIntParam(DB_COL_ID_REQUERIMIENTO, c.ID_REQUERIMIENTO);
            operation.AddStringParam(DB_COL_CODIGO, c.CODIGO);
            //operation.AddDoubleParam(DB_COL_PRIORIDAD, c.PRIORIDAD);
            //operation.AddStringParam(DB_COL_DESCRIPCION, c.DESCRIPCION);
            //operation.AddIntParam(DB_COL_ID_PROYECTO, c.ID_PROYECTO);
            //operation.AddBooleanParam(DB_COL_ESTADO, c.ESTADO);

            return operation;
        }

        public SqlOperation GetPriorityUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_REQUERIMIENTO_PR" };

            var c = (Requerimientos)entity;
            //operation.AddIntParam(DB_COL_ID_REQUERIMIENTO, c.ID_REQUERIMIENTO);
            //operation.AddStringParam(DB_COL_CODIGO, c.CODIGO);
            operation.AddDoubleParam(DB_COL_PRIORIDAD, c.PRIORIDAD);
            operation.AddStringParam(DB_COL_DESCRIPCION, c.DESCRIPCION);
            //operation.AddIntParam(DB_COL_ID_PROYECTO, c.ID_PROYECTO);
            //operation.AddBooleanParam(DB_COL_ESTADO, c.ESTADO);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_REQUERIMIENTO_PR" };

            var c = (Requerimientos)entity;
            operation.AddStringParam(DB_COL_CODIGO, c.CODIGO);
            return operation;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var caso = BuildObject(row);
                lstResults.Add(caso);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var requerimiento = new Requerimientos
            {
                ID_REQUERIMIENTO = GetIntValue(row, DB_COL_ID_REQUERIMIENTO),
                CODIGO = GetStringValue(row, DB_COL_CODIGO),
                PRIORIDAD = GetDoubleValue(row, DB_COL_PRIORIDAD),
                DESCRIPCION = GetStringValue(row, DB_COL_DESCRIPCION),
                ID_PROYECTO = GetIntValue(row, DB_COL_ID_PROYECTO),
                ESTADO = GetBooleanValue(row, DB_COL_ESTADO) 
            };

            return requerimiento;
        }

        public SqlOperation GetCountStatement(int id_Proyecto)
        {
            var operation = new SqlOperation { ProcedureName = "COUNT_REQUERIMIENTO_PR" };
            operation.AddIntParam(DB_COL_ID_PROYECTO, id_Proyecto);
            return operation;
        }

    }
}

