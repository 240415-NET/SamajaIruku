
using Project1.Presentation;

namespace Project1.Models;


public   class UserModel
{
   public Guid userId {get; set;}
   public string userName {get; set;}

    //Constructor
    public UserModel() {}
    public  UserModel(string _userName)
    {
        userId= Guid.NewGuid();
        userName = _userName;
    }


}
