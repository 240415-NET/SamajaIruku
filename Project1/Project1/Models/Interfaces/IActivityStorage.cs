using System.Configuration.Assemblies;

namespace Project1.Models;

public  interface IActivityStorage
{
    public ActivityModel StoreItem(ActivityModel  newActivity);

    public void FindActivity(string activityNametoFind);
}
