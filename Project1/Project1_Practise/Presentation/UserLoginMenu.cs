using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using PP;
using PP.Controllers;
using PP.Models;

namespace PP.Presentation;

public static class UserLoginMenu
{
    public static void ShowMenu()//Primary starting point
    {
        int userInput = 0;
        bool validChoice = true;

        Console.WriteLine("Please select from the below options:");
        Console.WriteLine("********************************************************");
        Console.WriteLine("1 - New User-Create a login\n2 - Existing User Login\n3 - Exit");




        do
        {
            try
            {
                userInput = Convert.ToInt32(Console.ReadLine());
                validChoice = true;
                switch (userInput)
                {
                    case 1:
                        NewUser();//calls inclass method to create new user in the database
                        break;
                    case 2:
                        ExistingUser(); //Existing user login wiht userName
                        break;

                    case 3:
                        Console.WriteLine("Goodbye!");
                        validChoice = false;
                        return;

                    default:
                        Console.WriteLine("Please enter a number between 1 and 3");
                        validChoice = false;
                        break;
                }

            }
            catch (Exception e)
            {
                validChoice = false;
                Console.WriteLine($"{e.Message}  \nPlease enter a number between 1 and 3"); //Input validation
                

            }
        } while (!validChoice);//flag to check for  if condition is not true..then will exit program.
    }




    public static void NewUser()

    //This method takes the input from the User, checks for Null or Empty. 
    //If not empty then will call the Controller to do its logic for the New User 
    //(check db for existing userName, if it dosen't exist let user know)
    //IF UserName exists then user enters the application.
    {
        string userInput = "";
        Console.WriteLine("Please Enter your UserName");
        userInput = Console.ReadLine();
        if (string.IsNullOrEmpty(userInput))
        {
            Console.WriteLine("Please do not enter a blank User Name.");
            return;
        }
        else if (UserController.UserExists(userInput))
        {
            Console.WriteLine("User Name exists, pleaes choose another");
        }
        else
        {
            UserController.CreateUser(userInput);
            Console.WriteLine($"Profile created for {userInput}");
        }
        
    }

    public static void ExistingUser()

    //THis method takes input from user and check for Null or empty
    //If not null or empty then checks if User allready exists in the database
    //IF dosen't exist, will confirm that username coudln't be found.
    //If exists then will let the user enter the system.
    {
        string userInput = "";
        Console.WriteLine("Please Enter your UserName");
        userInput = Console.ReadLine();
        userInput = userInput.Trim();
        if (string.IsNullOrEmpty(userInput))
        {
            Console.WriteLine("Please do not enter a blank User Name.");
            return;
        }
        else if (!UserController.UserExists(userInput))
        {
            Console.WriteLine("User Name could not be found");
        }
        else
        {
            //
        }
        return;
    }


}