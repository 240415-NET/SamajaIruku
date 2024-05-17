using System;
using System.Text;
using System.Collections;
using System.Dynamic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http.Headers;
using Project1.Models;
using Project1.Controllers;


namespace Project1.Presentation;

public static class UserLoginMenu
{
        public static void ShowMenu()
        {
                int userInput = 0;
                Console.WriteLine("Welcome! Please enter a number of your choice from below");
                Console.WriteLine("********************************************************");
                Console.WriteLine("1 - New User-Create a login\n2 - Existing User Login\n3 - Exit");
        }

        public static async void UserLoginSelection()
        {

                bool validInput = true;
                int userInput = 0;
                do
                {
                        try
                        {
                                ShowMenu();
                                userInput = Convert.ToInt32(Console.ReadLine());

                                switch (userInput)
                                {
                                        case 1:

                                                UserLoginMenu.CreateNewUser();
                                                break;
                                        case 2:
                                                UserLoginMenu.ExistingUserLogin();
                                                break;
                                        case 3:
                                                Console.WriteLine("Good Bye!");
                                                return;
                                        default:
                                                Console.WriteLine("Please enter a valid value between 1 and 3");
                                                validInput = false;

                                                break;
                                }

                        }
                        catch (Exception e)
                        {
                                Console.WriteLine($"{e.Message} Please Enter a number between 1 and 3");
                                //Console.Clear();

                                UserLoginSelection();

                        }
                } while (!validInput);

        }



        public static void CreateNewUser()
        {
                bool valid = true;
                //bool Q=true;
                List<string> UserDetails = new List<string>();
                string firstName;
                string lastName;
                string userName;
                string email;

                do
                {
                        try
                        {

                                Console.WriteLine("Please enter your First name, or Enter Q to exit");
                                firstName = Console.ReadLine().Trim();
                                if (firstName.ToLower()=="q")
                                {
                                        valid= true;
                                                                }
                                else if (String.IsNullOrWhiteSpace(firstName))
                                {
                                        Console.WriteLine("First Name cannot be empty or blank.  Please enter a valid name");
                                        valid = false;
                                }
                                else if (UserController.UserExists(firstName))

                                {
                                        Console.WriteLine("User Name exists");
                                        valid = false;

                                }
                                else
                                {
                                        UserController.SaveNewUser(firstName);
                                        Console.WriteLine("User Profile Created!");
                                        valid = true;
                                        AppMenu.DisplayAppMenu();
                                }
                                // Console.WriteLine ("Please enter your Last name");
                                // lastName = Console.ReadLine().Trim();
                                //  if (String.IsNullOrWhiteSpace(lastName))
                                // {
                                //         Console.WriteLine("Last Name cannot be empty or blank.  Please enter a valid name");
                                // }
                                // Console.WriteLine ("Please enter your User name");
                                // userName = Console.ReadLine().Trim();
                                //  if (String.IsNullOrWhiteSpace(userName))
                                // {
                                //         Console.WriteLine("User Name cannot be empty or blank.  Please enter a valid name");
                                // }
                                // Console.WriteLine ("Please enter your Email");
                                // email = Console.ReadLine().Trim();
                                //  if (String.IsNullOrWhiteSpace(email))
                                // {
                                //         Console.WriteLine("Email cannot be empty or blank.  Please enter a valid name");
                                // }





                        }

                        catch (Exception e)
                        {
                                Console.WriteLine($"{e.Message} Please enter a valid input");
                                valid = false;
                        }
                } while (!valid);

        }



        public static void ExistingUserLogin()
        {
                bool valid = true;
                //List<string> UserDetails = new List<string>();
                string userName;

                do
                {
                        try
                        {

                                Console.WriteLine("Please enter your User name, or press Q to exit");
                                userName = Console.ReadLine().Trim();
                                
                                if (userName.ToLower()=="q")
                                {
                                        valid= true;
                                 }
                                else if (String.IsNullOrWhiteSpace(userName))
                                {
                                        Console.WriteLine("User Name cannot be empty or blank.  Please enter a valid User Name");
                                        valid = false;
                                }

                                if (!UserController.UserExists(userName))

                                {
                                        Console.WriteLine("User Name Dosent exist");
                                        valid = false;

                                }
                                else
                                {

                                }
                                UserController.ReturnUser(userName);
                                Console.WriteLine($"Welcome back {userName}, you are logged in!");
                                valid = true;
                                AppMenu.DisplayAppMenu();



                        }

                        catch (Exception e)
                        {
                                Console.WriteLine($"{e.Message} Please enter a valid input");
                                valid = false;
                        }
                } while (!valid);

        }
}



