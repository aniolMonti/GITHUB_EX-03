internal class Program
{

    //---------MENU---------
    private static void Main(string[] args)
    {
        Console.Out.NewLine = "\r\n\r\n";
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

    public static void DoGeography()
    {
        int points = 0, correct,key;
        try
        {
            

            Console.WriteLine("QUESTION 1");
            Console.WriteLine("How many continents are in the earth?");
            Console.WriteLine("1. Four");
            Console.WriteLine("2. Five");
            Console.WriteLine("3. Six");
            Console.WriteLine("4. Seven");


            Console.Write("YOUR AWNSER: ");
            key = Convert.ToInt32(Console.ReadLine());
            correct = 3;


            if (key == correct)
            {
                points++;
                Console.WriteLine("{0} IS CORRECT",key);
            }
            else { Console.WriteLine("{0} IS INCORRECT",key); }


            Console.WriteLine("PRES ANY KEY TO CONTINUE");
            Console.ReadKey();
            Console.Clear();





            Console.WriteLine("QUESTION 2");
            Console.WriteLine("Where is the 'rio tajo'?");
            Console.WriteLine("1. Ecuador");
            Console.WriteLine("2. Rusia");
            Console.WriteLine("3. España");
            Console.WriteLine("4. Deutschland");


            Console.Write("YOUR AWNSER: ");
            key = Convert.ToInt32(Console.ReadLine());
            correct = 3;


            if (key == correct)
            {
                points++;
                Console.WriteLine("{0} IS CORRECT", key);
            }
            else { Console.WriteLine("{0} IS INCORRECT", key); }


            Console.WriteLine("PRES ANY KEY TO CONTINUE");
            Console.ReadKey();
            Console.Clear();




            Console.WriteLine("QUESTION 3");
            Console.WriteLine("Where is Tibet");
            Console.WriteLine("1. Africa");
            Console.WriteLine("2. Asia");
            Console.WriteLine("3. Oceania");
            Console.WriteLine("4. España");


            Console.Write("YOUR AWNSER: ");
            key = Convert.ToInt32(Console.ReadLine());
            correct = 2;


            if (key == correct)
            {
                points++;
                Console.WriteLine("{0} IS CORRECT", key);
            }
            else { Console.WriteLine("{0} IS INCORRECT", key); }


            Console.WriteLine("PRES ANY KEY TO CONTINUE");
            Console.ReadKey();
            Console.Clear();




            Console.WriteLine("QUESTION 4");
            Console.WriteLine("What is the highest peak in europe?");
            Console.WriteLine("1. Elbrus");
            Console.WriteLine("2. Shkhara");
            Console.WriteLine("3. Dykh Tau");
            Console.WriteLine("4. Mont Blanc");


            Console.Write("YOUR AWNSER: ");
            key = Convert.ToInt32(Console.ReadLine());
            correct = 1;


            if (key == correct)
            {
                points++;
                Console.WriteLine("{0} IS CORRECT", key);
            }
            else { Console.WriteLine("{0} IS INCORRECT", key); }


            Console.WriteLine("PRES ANY KEY TO CONTINUE");
            Console.ReadKey();
            Console.Clear();



            Console.WriteLine("QUESTION 5");
            Console.WriteLine("What river passes through more countries?");
            Console.WriteLine("1. Amazonas");
            Console.WriteLine("2. Nilo");
            Console.WriteLine("3. Danubio");
            Console.WriteLine("4. Rio Tajo");


            Console.Write("YOUR AWNSER: ");
            key = Convert.ToInt32(Console.ReadLine());
            correct = 3;


            if (key == correct)
            {
                points++;
                Console.WriteLine("{0} IS CORRECT", key);
            }
            else { Console.WriteLine("{0} IS INCORRECT", key); }


            Console.WriteLine("PRES ANY KEY TO CONTINUE");
            Console.ReadKey();
            Console.Clear();



            Console.WriteLine($"YOU HAVE {points} POINTS");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
        }
    }

    //arnau


}