using System;
using System.Collections;
using System.Text.Json;

//using Linq;
using Project1.Models;
using Project1.Presentation;
//using Project1.Controllers;

namespace Project1.DataStorage;


    public class JsonUserStorage : IUserStorage
{
    public static string filePath = "./DataStorage/UserFile.json"; //file path to save the data

    public  void SaveNewUser(UserModel  UserName)
    {
        if (!File.Exists(filePath))
        {
            List<UserModel> initialUserList = new List<UserModel>();
            initialUserList.Add(UserName);
            string jsonUsersString = JsonSerializer.Serialize(initialUserList);
            File.WriteAllText(filePath, jsonUsersString);
        }
        else if (File.Exists(filePath))
        {
            string existingUserJson = File.ReadAllText(filePath);
            List<UserModel> existingUserList = JsonSerializer.Deserialize<List<UserModel>>(existingUserJson);

            existingUserList.Add(UserName);
            string jsonUserString = JsonSerializer.Serialize (existingUserList);
            File.WriteAllText(filePath, jsonUserString);

        }
    }

    public  UserModel FindUser(string userNameToFind)
    {
        UserModel foundUser = new UserModel(); //Initiating the user object

        try{

            string existingUserJson = File.ReadAllText(filePath);
            List<UserModel> existingUsersList = JsonSerializer.Deserialize<List<UserModel>>(existingUserJson);

            foundUser = existingUsersList.FirstOrDefault(UserModel=>UserModel.userName==userNameToFind);


        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
        return foundUser;

    }

}
