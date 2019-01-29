
using DataAccess.Crud;
using Entities_POJO;
using Exceptions;
using System;
using System.Collections.Generic;
 

namespace CoreAPI
{
    public class CasoDeUsoManager : BaseManager
    {
        private CasoDeUsoCrudFactory crudCaso;

        public CasoDeUsoManager()
        {
            crudCaso = new CasoDeUsoCrudFactory();
        }

        public String Create(CasoDeUso caso)
        {
            try
            {
                var c = crudCaso.Retrieve<CasoDeUso>(caso);

                if (c != null)
                {
                    return "Ya existe un caso de uso con el código especificado";
                }
                else
                {
                    crudCaso.Create(caso);
                    return "Registro un caso de uso con éxito";
                }

            }
            catch (Exception ex)
            {
                ExceptionManager.GetInstance().Process(ex);
                return "Ocurrió un error inesperado: "+ ex.Message;
             }
        }

        public List<CasoDeUso> RetrieveAll()
        {
            return crudCaso.RetrieveAll<CasoDeUso>();
        }

        public CasoDeUso RetrieveById(CasoDeUso caso)
        {
            CasoDeUso c = null;
            try
            {
                c = crudCaso.Retrieve<CasoDeUso>(caso);
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

        public String Update(CasoDeUso caso)
        {
            CasoDeUso c = null;
            c = crudCaso.Retrieve<CasoDeUso>(caso);
            if (c == null)
            {
                return "No existe un caso de uso con este código";
            }
            else
            {
                crudCaso.Update(caso);
                return "Caso de uso actualizado con éxito";
            }
         
        }

        public void Delete(CasoDeUso caso)
        {
            crudCaso.Delete(caso);
        }
    }
}
