using PP;
using PP.Presentation;
using PP.Controllers;
using PP.Models;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Text.Json;

namespace PP.DataStorage;

public class JsonUserStorage : IUserStorage
{
        public static void StoreUser(UserModel user)
        {
            string filePath = "./DataStorage/JsonUsersFile.json";
            

            if (File.Exists(filePath))
            {
                   //we need to read the file before deserializing it:

                   string existingUserJson = File.ReadAllText(filePath);
                   
                    //we need to deserialize it to a new object
                    List<UserModel> existingUsersList = JsonSerializer.Deserialize<List<UserModel>>(existingUserJson);
                    //After you deserializer it, you will have to add the user details.
                    existingUsersList.Add(user);

                    //After adding user, then we serialize the file
                    string jsonExistingUsersListString = JsonSerializer.Serialize(existingUsersList);

                    //Now store the jsonExistingUserList to the file
                    File.WriteAllText(filePath, jsonExistingUsersListString);
            }
            else if(!File.Exists(filePath))// This would be the first time that the program runs, so we create the file.
            {
                List<UserModel> InitialusersList = new List<UserModel>();
                InitialusersList.Add(user);  //Add the user to the list

                string jsonUserString = JsonSerializer.Serialize(InitialusersList);//Serialize the list of users, into a JSON string.

                //now we will store the jsonUsersstring to the file
                File.WriteAllText(filePath,jsonUserString) ;

            }
        }


}
