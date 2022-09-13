using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string weiter = "Nein";
            Random myObject = new Random();
            int Random = myObject.Next(56, 60);
            int guess = 0;

            Console.WriteLine("Zahl zwischen 1 und 100");




            do
            {

                while (guess != Random)
                {
                    try
                    {



                        guess = Convert.ToInt32(Console.ReadLine());


                        if (guess < Random)
                        {


                            Console.ForegroundColor = ConsoleColor.White;

                            Console.BackgroundColor = ConsoleColor.Red;

                            Console.WriteLine("Zahl ist grösser");

                            Console.ResetColor();

                        }


                        else if (guess > Random)
                        {
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.BackgroundColor = ConsoleColor.Red;

                            Console.WriteLine("Zahl ist kleiner");

                            Console.ResetColor();

                        }
                        else if (guess == Random)
                        {
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.BackgroundColor = ConsoleColor.Green;

                            Console.WriteLine("Die Zahl ist richtig");
                            Console.ResetColor();




                        }

                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("Gib eine Zahl zwischen 1 und 100 ein");
                    }





                }



            } while (weiter == "Nein");
            Console.ReadLine();
        }
    }
}




