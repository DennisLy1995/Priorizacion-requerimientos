using DataAccess.Crud;
using Entities_POJO;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAPI
{
    public class ProyectoManager : BaseManager
    {
        private ProyectoCrudFactory crudProyecto;

        public ProyectoManager()
        {
            crudProyecto = new ProyectoCrudFactory();
        }

        public String Create(Proyecto proyecto)
        {
            try
            {
                var pro = crudProyecto.Retrieve<Proyecto>(proyecto);

                if (pro != null)
                {
                    throw new BusinessException(0);
                }
                else
                {
                    crudProyecto.Create(proyecto);
                    return "El proyecto se ha registrado con éxito";
                }

            }
            catch (Exception ex)
            {
                ExceptionManager.GetInstance().Process(ex);
                return "Ya existe un proyecto con el id especificado";
            }
        }

        public List<Proyecto> RetrieveAll()
        {
            return crudProyecto.RetrieveAll<Proyecto>();
        }

        public List<Proyecto> RetrieveAllProyectosUsuario(string identificacion)
        {
            return crudProyecto.RetrieveAllProyectosUsuario<Proyecto>(identificacion);
        }

        public Proyecto RetrieveById(Proyecto proyecto)
        {
            Proyecto pro = null;
            try
            {
                pro = crudProyecto.Retrieve<Proyecto>(proyecto);
                if (pro == null)
                {
                    throw new BusinessException(0);
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.GetInstance().Process(ex);
            }

            return pro;
        }

        public void Update(Proyecto proyecto)
        {
            crudProyecto.Update(proyecto);
        }

        public void Delete(Proyecto proyecto)
        {
            crudProyecto.Delete(proyecto);
        }
    }
}
