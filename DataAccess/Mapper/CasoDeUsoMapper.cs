using DataAccess.Dao;
using Entities_POJO;
using System.Collections.Generic;

namespace DataAccess.Mapper
{
    public class CasoDeUsoMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const string DB_COL_ID = "ID_CODIGO";
        private const string DB_COL_CODIGO = "CODIGO";
        private const string DB_COL_ID_PROYECTO = "ID_PROYECTO";
        private const string DB_COL_PRIORIDAD = "PRIORIDAD";
        private const string DB_COL_NOMBRE = "NOMBRE";
        private const string DB_COL_DESCRIPCION = "DESCRIPCION";


        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CREATE_CASO_PR" };

            var c = (CasoDeUso)entity;
            operation.AddStringParam(DB_COL_CODIGO, c.CODIGO);
            operation.AddIntParam(DB_COL_ID_PROYECTO, c.ID_PROYECTO);
            operation.AddFloatParam(DB_COL_PRIORIDAD, c.PRIORIDAD);
            operation.AddStringParam(DB_COL_NOMBRE, c.NOMBRE);
            operation.AddStringParam(DB_COL_DESCRIPCION, c.DESCRIPCION);


            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_CASO_PR" };

            var c = (CasoDeUso)entity;
            operation.AddStringParam(DB_COL_CODIGO, c.CODIGO);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_CASOS" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_CASO_PR" };

            var c = (CasoDeUso)entity;
            operation.AddStringParam(DB_COL_CODIGO, c.CODIGO);
            operation.AddStringParam(DB_COL_NOMBRE, c.NOMBRE);
            operation.AddStringParam(DB_COL_DESCRIPCION, c.DESCRIPCION);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_CASO_PR" };

            var c = (CasoDeUso)entity;
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
            var caso = new CasoDeUso
            {
                CODIGO = GetStringValue(row, DB_COL_CODIGO),
                ID_PROYECTO = GetIntValue(row, DB_COL_ID_PROYECTO),
                PRIORIDAD = GetIntValue(row, DB_COL_PRIORIDAD),
                NOMBRE = GetStringValue(row, DB_COL_NOMBRE),
                DESCRIPCION = GetStringValue(row, DB_COL_DESCRIPCION)
            };

            return caso;
        }

    }
}
