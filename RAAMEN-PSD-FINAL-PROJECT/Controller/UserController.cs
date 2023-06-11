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
            if (string.IsNullOrEmpty(username))
            {
                return "Username is required";
            }
            else if (username.Length < 5 || username.Length >= 15 || NoSpaces(username))
            {
                return "Username is not valid";
            }
            else if (string.IsNullOrEmpty(email))
            {
                return "Email is required";
            }
            else if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return "Email is not valid";
            }
            else if (string.IsNullOrEmpty(gender))
            {
                return "Gender is required";
            }
            else if (string.IsNullOrEmpty(password))
            {
                return "Password is required";
            }
            else if (password != confirm_password)
            {
                return "Password doesn't match";
            }
            else
            {
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

        public static string userUpdate(int id, string username, string email, string gender, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                return "Username is required";
            }
            else if (username.Length < 5 || username.Length >= 15 || NoSpaces(username))
            {
                return "Username is not valid";
            }
            else if (string.IsNullOrEmpty(email))
            {
                return "Email is required";
            }
            else if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return "Email is not valid";
            }
            else if (string.IsNullOrEmpty(gender))
            {
                return "Gender is required";
            }
            else if (string.IsNullOrEmpty(password))
            {
                return "Password is required";
            }
            else
            {
                UserHandler.userUpdate(id, username, email, gender, password);
                return "Update Success";
            }
        }

    }
}