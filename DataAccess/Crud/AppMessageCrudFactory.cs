using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Dao;
using DataAccess.Mapper;
using Entities_POJO;

namespace DataAccess.Crud
{
    public class AppMessageCrudFactory : CrudFactory
    {
        AppMessageMapper Mapper;

        public AppMessageCrudFactory()
        {
            Mapper = new AppMessageMapper();
            dao = SqlDao.GetInstance();
        }

        public override void Create(BaseEntity pEntity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(BaseEntity pEntity)
        {
            throw new NotImplementedException();
        }

        public override T Retrieve<T>(BaseEntity pEntity)
        {
            throw new NotImplementedException();
        }

        public override List<T> RetrieveAll<T>()
        {
            var lstAppMessage = new List<T>();

            var lstResult = dao.ExecuteQueryProcedure(Mapper.GetRetriveAllStatement());
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                var objs = Mapper.BuildObjects(lstResult);
                foreach (var c in objs)
                {
                    lstAppMessage.Add((T)Convert.ChangeType(c, typeof(T)));
                }
            }

            return lstAppMessage;
        }

        public override void Update(BaseEntity pEntity)
        {
            throw new NotImplementedException();
        }
    }
}
