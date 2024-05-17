using System.Security.Cryptography.X509Certificates;
using PP.Controllers;
using PP.DataStorage;
using PP.Presentation;

namespace PP.Models;

public  class UserModel 
{
     public Guid userId {get; set;}
     public string userInput {get; set;}

    //Constructors:
    public UserModel() {}

    //Constructor taking multiple arguments:

     public UserModel (string _userInput)
    {
        userId = Guid.NewGuid();
        userInput = _userInput;
    }
}