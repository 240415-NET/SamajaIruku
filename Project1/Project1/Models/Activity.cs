namespace Project1.Models;

public class Activity
{
    Guid activityId {get; set;}
    string activityName {get; set;}

    Guid userid {get; set;};
    DateOnly date {get; set;};
    TimeOnly time {get; set;};
    bool recurring {get; set;};
    string notes {get; set;};
    int fees {get; set;};
    string driverToActivity {get; set;};


    //Constructor
    public Activity() {}


}