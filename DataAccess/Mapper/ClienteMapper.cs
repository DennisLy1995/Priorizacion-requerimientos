using System.Collections.Generic;
using DataAccess.Dao;
using DataAccess.Mapper;
using Entities_POJO;

namespace DataAcess.Crud
{
    public class ClienteMapper : EntityMapper, ISqlStaments, IObjectMapper
    {

        private const string DB_COL_IDENTIFICACION_CLIENTE = "IDENTIFICACION_CLIENTE";
        private const string DB_COL_NOMBRE = "NOMBRE";
        private const string DB_COL_DIRECCION = "DIRECCION";


        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_CLIENTE_PR" };

            var c = (Cliente)entity;
            operation.AddStringParam(DB_COL_IDENTIFICACION_CLIENTE, c.identificacion);
            operation.AddStringParam(DB_COL_NOMBRE, c.nombre);
            operation.AddStringParam(DB_COL_DIRECCION, c.direccion);

            return operation;
        }
        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var cliente = new Cliente
            {
                nombre = GetStringValue(row, DB_COL_NOMBRE),
                identificacion = GetStringValue(row, DB_COL_IDENTIFICACION_CLIENTE),
                direccion = GetStringValue(row, DB_COL_DIRECCION),
            };

            return cliente;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var cliente = BuildObject(row);
                lstResults.Add(cliente);
            }

            return lstResults;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_CASO_PR" };

            var c = (Cliente)entity;
            operation.AddStringParam(DB_COL_IDENTIFICACION_CLIENTE, c.identificacion);
            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_CLIENTES" };
            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {

            var operation = new SqlOperation { ProcedureName = "RET_CLIENTE_PR" };

            var c = (Cliente)entity;
            operation.AddStringParam(DB_COL_IDENTIFICACION_CLIENTE, c.identificacion);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_CLIENTE_PR" };

            var c = (Cliente)entity;
            operation.AddStringParam(DB_COL_IDENTIFICACION_CLIENTE, c.identificacion);
            operation.AddStringParam(DB_COL_NOMBRE, c.nombre);
            operation.AddStringParam(DB_COL_DIRECCION, c.direccion);

            return operation;
        }
    }
}