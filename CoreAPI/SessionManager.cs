using DataAccess.Crud;
using Entities_POJO;
using Exceptions;
using System;

namespace CoreAPI
{
    public class SessionManager
    {
        private static User FinalUser;
        private static SessionManager Instance;

        private SessionManager()
        {
            FinalUser = new User();
        }

        public static SessionManager GetInstance()
        {
            if (Instance == null)
                Instance = new SessionManager();
            return Instance;
        }

        public void LogIn(string userName, string password)
        {
            try
            {
                var userFactory = new UserCrudFactory();
                var currentUser = new User() { UserName = userName };
                currentUser = userFactory.RetrieveByUser<User>(currentUser);

                if (currentUser == null)
                    throw new BusinessException(4);
                else if (currentUser.Password.Equals(password))
                    FinalUser = currentUser;
                else
                    throw new BusinessException(7);
            }
            catch (Exception error)
            {
                ExceptionManager.GetInstance().Process(error);
            }
        }

        public void LogOut()
        {
            FinalUser = null;
        }

        public User GetFinalUser()
        {
            return FinalUser;
        }
    }
}
