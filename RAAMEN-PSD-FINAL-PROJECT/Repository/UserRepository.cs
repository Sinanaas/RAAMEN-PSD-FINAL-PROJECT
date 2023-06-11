using RAAMEN_PSD_FINAL_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Repository
{
    public class UserRepository
    {
        static DatabaseEntities db = new DatabaseEntities();
        public static void userRegister(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public static User userLogin(string username, string password)
        {
            User user = (from x in db.Users where x.Username.Equals(username) && x.Password.Equals(password) select x).FirstOrDefault();
            return user;
        }

        public static User userSearch(int id)
        {
            User user = db.Users.Find(id);
            return user;
        }

        public static void userUpdate(int id, string username, string email, string gender, string password)
        {
            User user = userSearch(id);
            user.Username = username;
            user.Email = email;
            user.Gender = gender;
            user.Password = password;
            db.SaveChanges();
        }

        public static List<User> getAllCustomer()
        {
            List<User> users = (from x in db.Users where x.Role_Id.Equals(2) select x).ToList();
            return users;
        }

        public static List<User> getAllStaff()
        {
            List<User> users = (from x in db.Users where x.Role_Id.Equals(3) select x).ToList();
            return users;
        }

        public static int getLatestUserIdWithRoleId2()
        {
            int latestUserId = db.Users.Where(u => u.Role_Id == 2).OrderByDescending(u => u.User_Id).Select(u => u.User_Id).FirstOrDefault();
            return latestUserId;
        }
    }
}