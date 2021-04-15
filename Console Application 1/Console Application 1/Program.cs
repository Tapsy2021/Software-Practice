using System;

namespace Console_Application_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //IDE => Integrated Development Environment
            Console.WriteLine("Hello, My name is Taps and I am ready totake the first steps");
            Console.WriteLine("\nPlease tell me you age:\n");


            //Data Types

            //Integer (Can hold whole numbers)
            int age = 0;

            //char (Can hold characters)
            char firstLetter = 'G';

            //string (Can hold a word or sentence or paragraphs)
            string tooOldMessage = "You are a senior citizen";

            //float (Can old small decimal numbers)
            float myWeight = 4.6F;

            //double (Can hold big decimal numbers)
            double massOfThePlanet = 123.2398498034879037934;


            age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("You are too young to drink");
            }
            else if ((age > 18) && (age < 30))
            {
                Console.WriteLine("You are almost ready to get married");
            }
            else if ((age > 30) && (age < 60))
            {
                Console.WriteLine("If you are still single, you will probably die alone");
            }
            else if (age > 60) 
            {
                Console.WriteLine(tooOldMessage);
            }

            //Task
            /*
                Write a program that takes in mass of luggage from the console and then produce the corresponding prices
                Luggage will be free if the mass is less than 50Kg's
                After 50 Kg's each 10Kg increase in mass will result in an increase of R3 per Kg

                For instance:   56Kg's will be R3/Kilo
                                59Kg's will be R3/Kilo
                                60Kg's will be R6/Kilo
                                63Kg's will be R6/Kilo  
             */
        }
    }
}
