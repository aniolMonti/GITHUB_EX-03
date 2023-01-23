internal class Program
{

    //---------MENU---------
    private static void Main(string[] args)
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            ShowOptions();
            tecla = Console.ReadKey();
            Console.Clear();

            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    DoEntertainment();
                    break;
                case ConsoleKey.D2:
                    DoScience();
                    break;
                case ConsoleKey.D3:
                    DoHistory();
                    break;
                case ConsoleKey.D4:
                    DoGeography();
                    break;
                case ConsoleKey.D5:
                    DoArt();
                    break;
                case ConsoleKey.D6:
                    DoSport();
                    break;
                case ConsoleKey.D0:
                    MsgNextScreen("PRESS ANY KEY TO EXIT");
                    break;
                default:
                    MsgNextScreen("Error. Press any key to return to main menu...");
                    break;
            }

        } while (tecla.Key != ConsoleKey.D0);
    }
    //----------------------------------SHOW OPTIONS----------------------------------
    public static void ShowOptions()
    {
        Console.Clear();
        Console.WriteLine("1 - ENTERTAINMENT");
        Console.WriteLine("2 - SCIENCE");
        Console.WriteLine("3 - HISTORY");
        Console.WriteLine("4 - GEOGRAPHY");
        Console.WriteLine("5 - ART");
        Console.WriteLine("6 - SPORT");
        Console.WriteLine("0 - EXIT");
    }
    //----------------------------MISSATGE DESPRÉS DE LA OPCIÓ----------------------------
    public static void MsgNextScreen(string msg)
    {
        Console.WriteLine(msg);
        Console.ReadKey();
    }
    //aniol

    //aniol


    //arnau

    //arnau


}