namespace Project1.Models;

public  interface IUserStorage
{
    public void SaveNewUser(UserModel userName);
    public UserModel FindUser(string userNameToFind);

    //public ActivityModel StoreItem(ActivityModel  newActivity);
}

 