using System.Dynamic;
using PP;
using PP.Presentation;
using PP.DataStorage;
using PP.Models;
namespace PP.Controllers;


public  static class UserController
{

    private static IUserStorage _userData= new JsonUserStorage(); //Instantiating the object of JsonStorage class to take care of the data layer from controller layer.

    public static void CreateUser(string userName)
    {
        UserModel newUser = new UserModel(userName); //Creating the user

        JsonUserStorage.StoreUser(newUser);

        _userData.CreateUser(newUser); //storing the User Info in the DataStorage.
    }

    public static bool UserExists(string userName)
    {
       // Check if user Exists in datastorage
        // if (_userData.UserExists(userName)!=null)
        // {
        //     return true;
        // }
        return false;
      
    }


}

