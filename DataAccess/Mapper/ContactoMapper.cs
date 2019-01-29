using System.Collections.Generic;
using DataAccess.Dao;
using DataAccess.Mapper;
using Entities_POJO;

namespace DataAcess.Crud
{
    public class ContactoMapper : EntityMapper, ISqlStaments, IObjectMapper
    {

        private const string DB_COL_ID_CONTACTO = "ID_CONTACTO";
        private const string DB_COL_NOMBRE = "NOMBRE";
        private const string DB_COL_TELEFONO = "TELEFONO";
        private const string DB_COL_CORREO_ELECTRONICO = "CORREO_ELECTRONICO";


        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_CLIENTE_PR" };

            var c = (Contacto)entity;
            operation.AddIntParam(DB_COL_ID_CONTACTO, c.identificacion);
            operation.AddStringParam(DB_COL_NOMBRE, c.nombre);
            operation.AddStringParam(DB_COL_TELEFONO, c.numeroTelefonico);
            operation.AddStringParam(DB_COL_CORREO_ELECTRONICO, c.correo);

            return operation;
        }
        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            throw new System.NotImplementedException();
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            throw new System.NotImplementedException();
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public SqlOperation GetRetriveAllStatement()
        {
            throw new System.NotImplementedException();
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            throw new System.NotImplementedException();
        }

        SqlOperation ISqlStaments.GetCreateStatement(BaseEntity entity)
        {
            throw new System.NotImplementedException();
        }

        SqlOperation ISqlStaments.GetRetriveStatement(BaseEntity entity)
        {
            throw new System.NotImplementedException();
        }

        SqlOperation ISqlStaments.GetRetriveAllStatement()
        {
            throw new System.NotImplementedException();
        }

        SqlOperation ISqlStaments.GetUpdateStatement(BaseEntity entity)
        {
            throw new System.NotImplementedException();
        }

        SqlOperation ISqlStaments.GetDeleteStatement(BaseEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}

//    public class CustomerMapper : EntityMapper, ISqlStaments, IObjectMapper