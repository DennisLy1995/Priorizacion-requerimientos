using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Dao;
using Entities_POJO;

namespace DataAccess.Mapper
{
    public class ProyectoMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const string DB_COL_ID_PROYECTO = "ID_PROYECTO";
        private const string DB_COL_IDENTIFICACION_USUARIO = "IDENTIFICACION_USUARIO";
        private const string DB_COL_ID_CLIENTE = "ID_CLIENTE";
        private const string DB_COL_NOMBRE = "NOMBRE";
        private const string DB_COL_INDUSTRIA = "INDUSTRIA";
        private const string DB_COL_DESCRIPCION = "DESCRIPCION";
        private const string DB_COL_FECHA_INICIO = "FECHA_INICIO";
        private const string DB_COL_FECHA_FINAL = "FECHA_FINAL";
        private const string DB_COL_ESTADO = "ESTADO";

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var proyecto = new Proyecto
            {
                IdProyecto = GetIntValue(row, DB_COL_ID_PROYECTO),
                IdUsuario = GetStringValue(row, DB_COL_IDENTIFICACION_USUARIO),
                IdCliente = GetStringValue(row, DB_COL_ID_CLIENTE),
                Nombre = GetStringValue(row, DB_COL_NOMBRE),
                Industria = GetStringValue(row, DB_COL_INDUSTRIA),
                Descripcion = GetStringValue(row, DB_COL_DESCRIPCION),
                FechaInicio = GetStringValue(row, DB_COL_FECHA_INICIO),
                FechaFinal = GetStringValue(row, DB_COL_FECHA_FINAL),
            };

            return proyecto;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var proyecto = BuildObject(row);
                lstResults.Add(proyecto);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_PROYECTO_PR" };

            var pro = (Proyecto)entity;
            operation.AddStringParam(DB_COL_IDENTIFICACION_USUARIO, pro.IdUsuario);
            operation.AddStringParam(DB_COL_ID_CLIENTE, pro.IdCliente);
            operation.AddStringParam(DB_COL_NOMBRE, pro.Nombre);
            operation.AddStringParam(DB_COL_INDUSTRIA, pro.Industria);
            operation.AddStringParam(DB_COL_DESCRIPCION, pro.Descripcion);
            operation.AddStringParam(DB_COL_FECHA_INICIO, pro.FechaInicio);
            operation.AddStringParam(DB_COL_FECHA_FINAL, pro.FechaFinal);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_PROYECTO_PR" };

            var pro = (Proyecto)entity;
            operation.AddIntParam(DB_COL_ID_PROYECTO, pro.IdProyecto);
            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_PROYECTOS_PR" };
            return operation;
        }

        public SqlOperation GetRetriveAllProyectosUsuarioStatement(string identificacion)
        {
            var operation = new SqlOperation { ProcedureName = "RET_PROYECTOS_USUARIO_PR" };
            operation.AddStringParam(DB_COL_IDENTIFICACION_USUARIO, identificacion);
            return operation;
        }
        

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_PROYECTO_PR" };

            var pro = (Proyecto)entity;
            operation.AddStringParam(DB_COL_IDENTIFICACION_USUARIO, pro.IdUsuario);
            operation.AddStringParam(DB_COL_NOMBRE, pro.Nombre);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_PROYECTO_PR" };

            var pro = (Proyecto)entity;
            operation.AddIntParam(DB_COL_ID_PROYECTO, pro.IdProyecto);
            operation.AddStringParam(DB_COL_NOMBRE, pro.Nombre);
            operation.AddStringParam(DB_COL_INDUSTRIA, pro.Industria);
            operation.AddStringParam(DB_COL_DESCRIPCION, pro.Descripcion);
            operation.AddStringParam(DB_COL_FECHA_FINAL, pro.FechaFinal);

            return operation;
        }
    }
}
