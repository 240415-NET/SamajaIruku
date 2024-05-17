using PP;
using PP.Presentation;
using PP.Controllers;
using PP.DataStorage;

namespace PP.Models;

public interface IUserStorage
{
//creating the storage methods

public void CreateUser(UserModel user);
public void UserExists (UserModel UserNameToFind);

}