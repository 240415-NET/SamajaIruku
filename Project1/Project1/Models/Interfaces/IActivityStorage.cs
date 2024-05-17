using System.Configuration.Assemblies;

namespace Project1.Models;

public  interface IActivityStorage
{
    public ActivityModel FindActivity(string activityNameToFind);
     public  void StoreItem(ActivityModel  ActivityName);

    
}
