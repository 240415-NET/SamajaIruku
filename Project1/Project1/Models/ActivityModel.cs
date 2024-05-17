using System;
using System.Collections;
using System.Linq;
//using  Project1.Controllers;;
//using Project1.Presentation;


namespace Project1.Models;

public  class ActivityModel
{
     Guid activityId {get; set;}
     string activityName {get; set;}
     Guid userid {get; set;}
     DateOnly date {get; set;}
     TimeOnly time {get; set;}
     bool recurring {get; set;}
     string notes {get; set;}
     int fees {get; set;}
    string driverToActivity {get; set;}


    //Constructor
    public ActivityModel() {}
    public  ActivityModel(Guid _activityId, string _activityName,Guid _userId, 
    DateOnly _date, TimeOnly _time, bool _recurring, 
    string _notes, int _fees, string _driverToActivity)
    {
        activityId= Guid.NewGuid();
        activityName = _activityName;
        userid = _userId;
        date= _date;
        time = _time;
        recurring = true;
        notes = "This can be blank";
        fees = _fees;
        driverToActivity = "Mom will drive";

    }

public override string ToString()
    {
        return $"Activity: {activityName}\nDate: {date}\nTime: {time}\nHow do you get there: {driverToActivity}";
    }

}