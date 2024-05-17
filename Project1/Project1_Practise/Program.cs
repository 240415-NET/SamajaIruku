using PP.Presentation;

namespace PP;

class Program
{
    static void Main(string[] args)
    {
       string location = System.IO.Directory.GetCurrentDirectory();
            Console.WriteLine(location);
        UserLoginMenu.ShowMenu();
    }
}
