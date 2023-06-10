using RAAMEN_PSD_FINAL_PROJECT.Handler;
using RAAMEN_PSD_FINAL_PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace RAAMEN_PSD_FINAL_PROJECT.Controller
{
    public class UserController
    {
        public static string userRegister(int role_id, string username, string email, string gender, string password, string confirm_password)
        {
            if (username.Length < 5 || username.Length >= 15 || NoSpaces(username))
            {
                // Handle the case when the username is invalid
                return "Username is not valid";
            }
            else if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                // Handle the case when the email is invalid
                return "Email is not valid";
            }
            else if (string.IsNullOrEmpty(gender))
            {
                // Handle the case when the gender is not chosen
                return "Gender is not valid";
            }
            else if (password != confirm_password)
            {
                // Handle the case when the password and confirm password do not match
                return "Password doesn't match";
            }
            else
            {
                // All fields are valid, proceed with user insertion
                UserHandler.userRegister(role_id, username, email, gender, password);
                return "Register Success";
            }

        }
        public static bool NoSpaces(string username)
        {
            // Length must be between 5 and 15 and should only contain alphabets and spaces
            Regex regex = new Regex("^[a-zA-Z ]{5,15}$");
            return regex.IsMatch(username);
        }

        public static User userLogin(string username, string password)
        {
            User user = UserHandler.userLogin(username, password);
            return user;
        }

        public static void userUpdate(int id, string username, string email, string gender, string password)
        {
            UserHandler.userUpdate(id, username, email, gender, password);
        }
    }
}