internal class Program
{

    //---------MENU---------
    private static void Main(string[] args)
    {
        Console.Out.NewLine = "\r\n\r\n";
        ConsoleKeyInfo key;
        do
        {
            Console.Clear();
            ShowOptions();
            key = Console.ReadKey();
            Console.Clear();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    DoEntertainment();
                    break;
                case ConsoleKey.D2:
                    DoScience();
                    break;
                //case ConsoleKey.D3:
                //    DoHistory();
                //    break;
                //case ConsoleKey.D4:
                //    DoGeography();
                //    break;
                //case ConsoleKey.D5:
                //    DoArt();
                //    break;
                //case ConsoleKey.D6:
                //    DoSport();
                //    break;
                case ConsoleKey.D0:
                    MsgNextScreen("PRESS ANY KEY TO EXIT");
                    break;
                default:
                    MsgNextScreen("Error. Press any key to return to main menu...");
                    break;
            }

        } while (key.Key != ConsoleKey.D0);
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

    //----------------------------ENTERTAINMENT----------------------------
    public static void DoEntertainment()
    {
        int points = 0;
        int correct = 0;
        int key;

        try
        {
            Console.WriteLine("QUESTION 1");
            Console.WriteLine("What is the name of the protagonist of the Indiana Jones saga?");
            Console.WriteLine("1. Chris Pratt");
            Console.WriteLine("2. Michael Fox");
            Console.WriteLine("3. Harrison Ford");
            Console.WriteLine("4. Robin Williams");

            Console.Write("YOUR ANSWER: ");
            key = Convert.ToInt32(Console.ReadLine());
            correct = 3;

            if (key == correct)
            {
                Console.WriteLine($"{key} IS CORRECT");
                points++;
            }
            else Console.WriteLine($"{key} IS INCORRECT");

            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("QUESTION 2");
            Console.WriteLine("What animal is Jasmine's pet in Aladdin?");
            Console.WriteLine("1. Elephant");
            Console.WriteLine("2. Tiger");
            Console.WriteLine("3. Monkey");
            Console.WriteLine("4. Snake");

            Console.Write("YOUR ANSWER: ");
            key = Convert.ToInt32(Console.ReadLine());
            correct = 2;

            if (key == correct)
            {
                Console.WriteLine($"{key} IS CORRECT");
                points++;
            }
            else Console.WriteLine($"{key} IS INCORRECT");

            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("QUESTION 3");
            Console.WriteLine("Who is considered the King of Pop?");
            Console.WriteLine("1. Justin Bieber");
            Console.WriteLine("2. Michael Jackson");
            Console.WriteLine("3. Zyan Malik");
            Console.WriteLine("4. Elvis Presley");

            Console.Write("YOUR ANSWER: ");
            key = Convert.ToInt32(Console.ReadLine());
            correct = 2;

            if (key == correct)
            {
                Console.WriteLine($"{key} IS CORRECT");
                points++;
            }
            else Console.WriteLine($"{key} IS INCORRECT");

            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("QUESTION 4");
            Console.WriteLine("Which Mortal Kombat video game character has ice powers?");
            Console.WriteLine("1. Sub-Zero");
            Console.WriteLine("2. Scorpion");
            Console.WriteLine("3. Reptile");
            Console.WriteLine("4. Motaro");

            Console.Write("YOUR ANSWER: ");
            key = Convert.ToInt32(Console.ReadLine());
            correct = 1;

            if (key == correct)
            {
                Console.WriteLine($"{key} IS CORRECT");
                points++;
            }
            else Console.WriteLine($"{key} IS INCORRECT");

            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("QUESTION 5");
            Console.WriteLine("Which day is Valentine's Day?");
            Console.WriteLine("1. March 14th");
            Console.WriteLine("2. February 15th");
            Console.WriteLine("3. February 14th");
            Console.WriteLine("4. March 15th");

            Console.Write("YOUR ANSWER: ");
            key = Convert.ToInt32(Console.ReadLine());
            correct = 3;

            if (key == correct)
            {
                Console.WriteLine($"{key} IS CORRECT");
                points++;
            }
            else Console.WriteLine($"{key} IS INCORRECT");

            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
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
    //----------------------------SCIENCE----------------------------
    public static void DoScience()
    {
        int points = 0;
        int correct = 0;
        int key;

        try
        {
            Console.WriteLine("QUESTION 1");
            Console.WriteLine("Where does saccharin come from?");
            Console.WriteLine("1. Sunflower oil");
            Console.WriteLine("2. Of sugar");
            Console.WriteLine("3. Of sulfur");
            Console.WriteLine("4. Of coal");

            Console.Write("YOUR ANSWER: ");
            key = Convert.ToInt32(Console.ReadLine());
            correct = 4;

            if (key == correct)
            {
                Console.WriteLine($"{key} IS CORRECT");
                points++;
            }
            else Console.WriteLine($"{key} IS INCORRECT");

            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("QUESTION 2");
            Console.WriteLine("How many faces does an icosahedron have?");
            Console.WriteLine("1. 20");
            Console.WriteLine("2. 16");
            Console.WriteLine("3. 8");
            Console.WriteLine("4. 24");

            Console.Write("YOUR ANSWER: ");
            key = Convert.ToInt32(Console.ReadLine());
            correct = 1;

            if (key == correct)
            {
                Console.WriteLine($"{key} IS CORRECT");
                points++;
            }
            else Console.WriteLine($"{key} IS INCORRECT");

            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("QUESTION 3");
            Console.WriteLine("What is the chemical formula of water?");
            Console.WriteLine("1. HO");
            Console.WriteLine("2. H02");
            Console.WriteLine("3. H20");
            Console.WriteLine("4. Wtr");

            Console.Write("YOUR ANSWER: ");
            key = Convert.ToInt32(Console.ReadLine());
            correct = 3;

            if (key == correct)
            {
                Console.WriteLine($"{key} IS CORRECT");
                points++;
            }
            else Console.WriteLine($"{key} IS INCORRECT");

            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("QUESTION 4");
            Console.WriteLine("What is hemophobia?");
            Console.WriteLine("1. Fear of heights");
            Console.WriteLine("2. Fear of blood");
            Console.WriteLine("3. Afraid of water");
            Console.WriteLine("4. None is correct");

            Console.Write("YOUR ANSWER: ");
            key = Convert.ToInt32(Console.ReadLine());
            correct = 2;

            if (key == correct)
            {
                Console.WriteLine($"{key} IS CORRECT");
                points++;
            }
            else Console.WriteLine($"{key} IS INCORRECT");

            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("QUESTION 5");
            Console.WriteLine("What liquid do cacti store?");
            Console.WriteLine("1. Sap");
            Console.WriteLine("2. Water");
            Console.WriteLine("3. Wine");
            Console.WriteLine("4. Nectar");

            Console.Write("YOUR ANSWER: ");
            key = Convert.ToInt32(Console.ReadLine());
            correct = 2;

            if (key == correct)
            {
                Console.WriteLine($"{key} IS CORRECT");
                points++;
            }
            else Console.WriteLine($"{key} IS INCORRECT");

            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
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

    //aniol


    //arnau

    //arnau


}