
using DataAccess.Crud;
using Entities_POJO;
using Exceptions;
using System;
using System.Collections.Generic;


namespace CoreAPI
{
    public class RequerimientoManager : BaseManager
    {
        private RequerimientoCrudFactory crudRequerimiento;

        public RequerimientoManager()
        {
            crudRequerimiento = new RequerimientoCrudFactory();
        }

        public String Create(Requerimientos requerimiento)
        {
            try
            {
                var c = crudRequerimiento.Retrieve<Requerimientos>(requerimiento);

                if (c != null)
                {
                    throw new BusinessException(100);
                }
                else
                {
                    crudRequerimiento.Create(requerimiento);
                    return "Registro un caso de uso con éxito";
                }

            }
            catch (Exception ex)
            {
                ExceptionManager.GetInstance().Process(ex);
                return "Ya existe un caso de uso con el código especificado";
            }
        }

        public List<Requerimientos> RetrieveAll()
        {
            return crudRequerimiento.RetrieveAll<Requerimientos>();
        }

        public Requerimientos RetrieveById(Requerimientos requerimiento)
        {
            Requerimientos c = null;
            try
            {
                c = crudRequerimiento.Retrieve<Requerimientos>(requerimiento);
                if (c == null)
                {
                    throw new BusinessException(0);
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.GetInstance().Process(ex);
            }

            return c;
        }

        public void Update(Requerimientos requerimiento)
        {
            crudRequerimiento.Update(requerimiento);
        }

        public void Delete(Requerimientos requerimiento)
        {
            crudRequerimiento.Delete(requerimiento);
        }


        //Prueba
        public object RetrieveRequerimentsRegistered(int id_Requerimiento)
        {
            Object c = null;
            try
            {
                c = crudRequerimiento.RetrieveRequerimentsRegistered(id_Requerimiento);
                if (c == null)
                {
                    throw new BusinessException(0);
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.GetInstance().Process(ex);
            }

            return c;
        }

        public void UpdatePriority(Requerimientos requerimiento)
        {
            crudRequerimiento.UpdatePriority(requerimiento);
        }


    }
}
