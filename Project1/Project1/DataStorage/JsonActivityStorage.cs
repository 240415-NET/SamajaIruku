using System;
using System.Collections;
using System.Text.Json;

//using Linq;
using Project1.Models;
using Project1.Presentation;
//using Project1.Controllers;

namespace Project1.DataStorage;


    public class JsonActivityStorage : IActivityStorage
{
    public static string filePath = "./DataStorage/ActivityFile.json"; //file path to save the data

    public  void StoreItem(ActivityModel  activityName)
    {
        if (!File.Exists(filePath))
        {
            List<ActivityModel>initialActivityList = new List<ActivityModel>();
            initialActivityList.Add(activityName);
            string jsonUsersString = JsonSerializer.Serialize(initialActivityList);
            File.WriteAllText(filePath, jsonUsersString);
        }
        else if (File.Exists(filePath))
        {
            string existingActivityJson = File.ReadAllText(filePath);
            List<ActivityModel> existingActivityList = JsonSerializer.Deserialize<List<ActivityModel>>(existingActivityJson);

            existingActivityList.Add(activityName);
            string jsonUserString = JsonSerializer.Serialize (existingActivityJson);
            File.WriteAllText(filePath, jsonUserString);

        }
    }

    public  ActivityModel FindActivity(string activityNameToFind)
    {
        ActivityModel foundActivity = new ActivityModel(); //Initiating the user object

        try{

            string existingActivityJson = File.ReadAllText(filePath);
            List<ActivityModel> existingActivityList = JsonSerializer.Deserialize<List<ActivityModel>>(existingActivityJson);

            activityNameToFind = existingActivityList.FirstOrDefault(ActivityModel=>ActivityModel.activityName==activityNameToFind);


        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
        return foundUser;

    }

   
}
