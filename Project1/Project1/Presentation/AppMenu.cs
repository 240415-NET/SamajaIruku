using Project1.Models;
using Project1.Controllers;
using System.ComponentModel.DataAnnotations;


namespace Project1.Presentation;

public  class AppMenu
{

    public static void DisplayAppMenu()
    {
        int AppMenuSelect=0;
       
        Console.WriteLine("Please select from the below options:\n 1) View Activities \n 2) Update Activites \n 3) Search by name\n 4) Logoff");
        AppMenuSelect = Convert.ToInt32(Console.ReadLine());
        
        bool validInput = true;
       
                do
                {
                        try
                        {
                                

                                switch (AppMenuSelect)
                                {
                                        case 1:

                                                ViewActivitiesSubmenu();//View Activities SubMenu for activities by week or Month
                                                break;
                                        case 2:
                                                //Update Activities
                                                break;
                                        case 3:
                                                //Search by Name
                                                return;
                                        default:
                                                Console.WriteLine("Please enter a valid value between 1 and 3");
                                                validInput = false;

                                                break;
                                }

                        }
                        catch (Exception e)
                        {
                                Console.WriteLine($"{e.Message} Please Enter a number between 1 and 4");
                                //Console.Clear();

                                //UserLoginSelection();

                        }
                } while (!validInput);

        }


public static void ViewActivitiesSubmenu()
{
    Console.WriteLine("Do you want to view the activity by \n1) Week 2) Month");
    int ViewActivitySubMenuSelect = Convert.ToInt32(Console.ReadLine());
        
        bool validInput = true;
       
                do
                {
                        try
                        {
                                

                                switch (ViewActivitySubMenuSelect)
                                {
                                        case 1:

                                                //ActivityController.ViewActivity();//View Activities SubMenu for activities by week or Month
                                                break;
                                        case 2:
                                                //Update Activities
                                                break;
                                        default:
                                                Console.WriteLine("Please enter a valid value between 1 and 2");
                                                validInput = false;

                                                break;
                                }

                        }
                        catch (Exception e)
                        {
                                Console.WriteLine($"{e.Message} Please Enter a number between 1 and 4");
                                //Console.Clear();

                                //UserLoginSelection();

                        }
                } while (!validInput);

}
}