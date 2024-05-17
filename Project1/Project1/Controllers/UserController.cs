using System;
using System.Collections;
using Project1.DataStorage;

//using Linq;
using Project1.Models;
using Project1.Presentation;

namespace Project1.Controllers;

public static class UserController 
{
       //Data access object of class to implement the interface
        private static IUserStorage _userInfo = new JsonUserStorage();

        //method to save new user .
        public static  void SaveNewUser(string userName)
        {
            UserModel newUser  = new UserModel(userName); //create a new user model
            _userInfo.SaveNewUser(newUser); //Calls the method from the repository
        }

        //method to return true or false if User exists.
        public static bool UserExists(string userName)
        {
                if (_userInfo.FindUser(userName)!= null)
                {
                        return true;
                }
                        return false;
        }
        
        //Method to return user information from the data layer.
        public static UserModel ReturnUser (string userName)

    {
        UserModel existingUser = _userInfo.FindUser(userName);
        return existingUser;
    }
}

