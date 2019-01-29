using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Dao;
using DataAcess.Crud;
using Entities_POJO;

namespace DataAccess.Crud
{
    public class ContactoCrudFactory : CrudFactory
    {
        private ContactoMapper mapper;

        public ContactoCrudFactory() : base()
        {
            mapper = new ContactoMapper();
            dao = SqlDao.GetInstance();
        }

        public override void Create(BaseEntity entity)
        {
            var contacto = (Contacto)entity;
            var sqlOperation = mapper.GetCreateStatement(contacto);
            dao.ExecuteProcedure(sqlOperation);
        }

        public override void Delete(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override T Retrieve<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override List<T> RetrieveAll<T>()
        {
            throw new NotImplementedException();
        }

        public override void Update(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
