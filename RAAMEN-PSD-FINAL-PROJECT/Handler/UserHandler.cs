using RAAMEN_PSD_FINAL_PROJECT.Factory;
using RAAMEN_PSD_FINAL_PROJECT.Model;
using RAAMEN_PSD_FINAL_PROJECT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Handler
{
    public class UserHandler
    {
        public static void userRegister(int role_id, string username, string email, string gender, string password)
        {
            User user = UserFactory.createUser(role_id, username, email, gender, password);
            UserRepository.userRegister(user);
        }

        public static User userLogin(string username, string password)
        {
            User user = UserRepository.userLogin(username, password);
            return user;
        }

        public static void userUpdate(int id, string username, string email, string gender, string password)
        {
            UserRepository.userUpdate(id, username, email, gender, password);
        }
    }
}