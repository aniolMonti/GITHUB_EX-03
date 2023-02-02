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
    //----------------------------HISTORY----------------------------
    public static void DoHistory()
    {
        int points = 0;
        int correct = 0;
        int key;

        try
        {
            Console.WriteLine("QUESTION 1");
            Console.WriteLine("What is celebrated on March 8?");
            Console.WriteLine("1. Labor day");
            Console.WriteLine("2. Environment day");
            Console.WriteLine("3. Women's day");
            Console.WriteLine("4. Children's day");

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
            Console.WriteLine("What did Jehovah's Witnesses call God?");
            Console.WriteLine("1. Mutant");
            Console.WriteLine("2. Jehovah");
            Console.WriteLine("3. Buddha");
            Console.WriteLine("4. Jesus");

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
            Console.WriteLine("In which country was Protestantism born?");
            Console.WriteLine("1. Germany");
            Console.WriteLine("2. Italy");
            Console.WriteLine("3. France");
            Console.WriteLine("4. Poland");

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


            Console.WriteLine("QUESTION 4");
            Console.WriteLine("What empire came to conquer almost all of Europe?");
            Console.WriteLine("1. Carthage");
            Console.WriteLine("2. Roman");
            Console.WriteLine("3. Spartan");
            Console.WriteLine("4. Viking");

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
            Console.WriteLine("How many colors does the Spanish flag have?");
            Console.WriteLine("1. Three");
            Console.WriteLine("2. Four");
            Console.WriteLine("3. Two");
            Console.WriteLine("4. One");

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

    //aniol


    //arnau

    //************GEOGRAPHY****************//

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



    //************ART****************//
    public static void DoArt()
    {
        int points = 0, correct, key;
        try
        {


            Console.WriteLine("QUESTION 1");
            Console.WriteLine("Who painted the 'Mona Lisa'?");
            Console.WriteLine("1. Pablo Picasso");
            Console.WriteLine("2. Vincent van Gogh");
            Console.WriteLine("3. Leonardo da Vinci");
            Console.WriteLine("4. Michelangelo");

            Console.Write("YOUR ANSWER: ");
            key = Convert.ToInt32(Console.ReadLine());
            correct = 3;

            if (key == correct)
            {
                points++;
                Console.WriteLine("{0} IS CORRECT", key);
            }
            else { Console.WriteLine("{0} IS INCORRECT", key); }

            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadKey();
            Console.Clear();





            Console.WriteLine("QUESTION 2");
            Console.WriteLine("Who painted the famous artwork 'The Starry Night'?");
            Console.WriteLine("1. Pablo Picasso");
            Console.WriteLine("2. Vincent van Gogh");
            Console.WriteLine("3. Claude Monet");
            Console.WriteLine("4. Frida Kahlo");

            Console.Write("YOUR ANSWER: ");
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




            Console.WriteLine("QUESTION 3");
            Console.WriteLine("Which Egyptian queen was depicted as having a cat's head?");
            Console.WriteLine("1. Cleopatra");
            Console.WriteLine("2. Nefertiti");
            Console.WriteLine("3. Bastet");
            Console.WriteLine("4. Hatshepsut");

            Console.Write("YOUR ANSWER: ");
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




            Console.WriteLine("QUESTION 4");
            Console.WriteLine("What is the most famous sculpture in the world?");
            Console.WriteLine("1. The Thinker");
            Console.WriteLine("2. The David");
            Console.WriteLine("3. The Pieta");
            Console.WriteLine("4. The Venus de Milo");

            Console.Write("YOUR ANSWER: ");
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



            Console.WriteLine("QUESTION 5");
            Console.WriteLine("Which museum is home to the painting 'The Persistence of Memory'?");
            Console.WriteLine("1. The Louvre");
            Console.WriteLine("2. The Museum of Modern Art");
            Console.WriteLine("3. The British Museum");
            Console.WriteLine("4. The National Gallery");


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

    public static void DoSport()
    {
        int points = 0, correct, key;
        try
        {


            Console.WriteLine("QUESTION 1");
            Console.WriteLine("What is the most watched sport in the world?");
            Console.WriteLine("1. Soccer");
            Console.WriteLine("2. Basketball");
            Console.WriteLine("3. American Football");
            Console.WriteLine("4. Cricket");

            Console.Write("YOUR ANSWER: ");
            key = Convert.ToInt32(Console.ReadLine());
            correct = 1;

            if (key == correct)
            {
                points++;
                Console.WriteLine("{0} IS CORRECT", key);
            }
            else { Console.WriteLine("{0} IS INCORRECT", key); }

            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadKey();
            Console.Clear();





            Console.WriteLine("QUESTION 2");
            Console.WriteLine("Which country has won the most World Cups in soccer?");
            Console.WriteLine("1. Brazil");
            Console.WriteLine("2. Germany");
            Console.WriteLine("3. Italy");
            Console.WriteLine("4. Argentina");

            Console.Write("YOUR ANSWER: ");
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




            Console.WriteLine("QUESTION 3");
            Console.WriteLine("Who is the fastest man in the world?");
            Console.WriteLine("1. Usain Bolt");
            Console.WriteLine("2. Justin Gatlin");
            Console.WriteLine("3. Tyson Gay");
            Console.WriteLine("4. Asafa Powell");

            Console.Write("YOUR ANSWER: ");
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




            Console.WriteLine("QUESTION 4");
            Console.WriteLine("What is the most played sport in the United States?");
            Console.WriteLine("1. Soccer");
            Console.WriteLine("2. Basketball");
            Console.WriteLine("3. American Football");
            Console.WriteLine("4. Baseball");

            Console.Write("YOUR ANSWER: ");
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



            Console.WriteLine("QUESTION 5");
            Console.WriteLine("Who is the all-time leading scorer in NBA history?");
            Console.WriteLine("1. Michael Jordan");
            Console.WriteLine("2. Kobe Bryant");
            Console.WriteLine("3. LeBron James");
            Console.WriteLine("4. Kareem Abdul-Jabbar");


            Console.Write("YOUR AWNSER: ");
            key = Convert.ToInt32(Console.ReadLine());
            correct = 4;


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