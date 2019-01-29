
using DataAccess.Crud;
using Entities_POJO;
using Exceptions;
using System;
using System.Collections.Generic;
 

namespace CoreAPI
{
    public class ClienteManager : BaseManager
    {
        private ClienteCrudFactory crudCliente;

        public ClienteManager()
        {
            crudCliente = new ClienteCrudFactory();
        }

        public String Create(Cliente cliente)
        {
            try
            {
                var c = crudCliente.Retrieve<Cliente>(cliente);

                if (c != null)
                {
                    return "Ya existe un cliente con esa identificacion registrado en el sistema";
                }
                else
                {
                    crudCliente.Create(cliente);
                    return "Registro al cliente con exito";
                }

            }
            catch (Exception ex)
            {
                ExceptionManager.GetInstance().Process(ex);
                return "Ocurrió un error inesperado: "+ ex.Message;
             }
        }

        public List<Cliente> RetrieveAll()
        {
            return crudCliente.RetrieveAll<Cliente>();
        }

        public Cliente RetrieveById(Cliente cliente)
        {
            Cliente c = null;
            try
            {
                c = crudCliente.Retrieve<Cliente>(cliente);
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

        public String Update(Cliente cliente)
        {
            Cliente c = null;
            c = crudCliente.Retrieve<Cliente>(cliente);
            if (c == null)
            {
                return "No existe un cliente con esa cedula";
            }
            else
            {
                crudCliente.Update(cliente);
                return "Cliente actualizado con éxito";
            }
         
        }

        public void Delete(Cliente cliente)
        {
            crudCliente.Delete(cliente);
        }
    }
}
