using System.Collections.Generic;
using DataAccess.Dao;
using Entities_POJO;

namespace DataAccess.Mapper
{
    public class UserMapper : EntityMapper, ISqlStatements, IObjectMapper
    {
        public const string DB_COL_IDENTIFICACION = "IDENTIFICACION_USUARIO";
        public const string DB_COL_NOMBRE = "NOMBRE";
        public const string DB_COL_APELLIDO = "APELLIDO";
        public const string DB_COL_NOMBRE_USUARIO = "NOMBRE_USUARIO";
        public const string DB_COL_PASSWORD = "PASSWORD";
        public const string DB_COL_CORREO_ELECTRONICO = "CORREO_ELECTRONICO";

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_USER_PR" };
            var nObj = (User)entity;

            operation.AddStringParam(DB_COL_IDENTIFICACION, nObj.Id);
            operation.AddStringParam(DB_COL_NOMBRE, nObj.Name);
            operation.AddStringParam(DB_COL_APELLIDO, nObj.LastName);
            operation.AddStringParam(DB_COL_NOMBRE_USUARIO, nObj.UserName);
            operation.AddStringParam(DB_COL_PASSWORD, nObj.Password);
            operation.AddStringParam(DB_COL_CORREO_ELECTRONICO, nObj.Email);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_USER_PR" };
            var nObj = (User)entity;

            operation.AddStringParam(DB_COL_NOMBRE_USUARIO, nObj.UserName);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_USER_PR" };
            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_USER_PR" };
            var nObj = (User)entity;

            operation.AddStringParam(DB_COL_IDENTIFICACION, nObj.Id);

            return operation;
        }

        public SqlOperation GetRetriveStatementByUser(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_USER_USER_NAME_PR" };
            var nObj = (User)entity;
            operation.AddStringParam(DB_COL_NOMBRE_USUARIO, nObj.UserName);
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_USER_PR" };
            var nObj = (User)entity;

            operation.AddStringParam(DB_COL_IDENTIFICACION, nObj.Id);
            operation.AddStringParam(DB_COL_NOMBRE, nObj.Name);
            operation.AddStringParam(DB_COL_APELLIDO, nObj.LastName);
            operation.AddStringParam(DB_COL_PASSWORD, nObj.Password);
            operation.AddStringParam(DB_COL_CORREO_ELECTRONICO, nObj.Email);

            return operation;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var nObj = new User()
            {
                Id = GetStringValue(row, DB_COL_IDENTIFICACION),
                Name = GetStringValue(row, DB_COL_NOMBRE),
                LastName = GetStringValue(row, DB_COL_APELLIDO),
                UserName = GetStringValue(row, DB_COL_NOMBRE_USUARIO),
                Password = GetStringValue(row, DB_COL_PASSWORD),
                Email = GetStringValue(row, DB_COL_CORREO_ELECTRONICO)
            };

            return nObj;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> rows)
        {
            var list = new List<BaseEntity>();

            foreach (var varFila in rows)
            {
                var nuevoCliente = BuildObject(varFila);
                list.Add(nuevoCliente);
            }

            return list;
        }
    }
}
