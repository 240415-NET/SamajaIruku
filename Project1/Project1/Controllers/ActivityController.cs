using Project1.Presentation;
using Project1.Models;
using Project1.DataStorage;

namespace Project1.Contorollers;

public static class ActivityController
{
    private static IActivityStorage _activityInfo = new JsonActivityStorage();


}
