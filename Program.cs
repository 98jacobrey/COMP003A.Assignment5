using System;
/*
 * Author:  Jacob Autrey
 * Course:  COMP - 003A - L01
 * Purpose: ASsigment 5
 */
namespace COMP003A.Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSeparator("triangle");

            Console.WriteLine("Please Input a Single Character");
            char symbol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please Input a Positive Integer");
            int integer = Convert.ToInt32(Console.ReadLine());

            IsoscelesTriangleBuilder(symbol,integer);

            PrintSeparator("Favorite Characters");

            CharacterInfo("Sonic" , 1991);
            CharacterInfo("solid snake" , 1998);
            CharacterInfo("Harrier Du Bois", 1978);
            CharacterInfo("2b", 1980);
            CharacterInfo("Hollow Knight" , 2015);
        }

        static void PrintSeparator()
        {
            Console.WriteLine("**********************************************************");
        }

        /// <summary>
        /// Prints a string with asterisks above and below to create a title with a border, calls the PrintSparator method
        /// </summary>
        /// <param name="separator"></param>
        static void PrintSeparator(string separator)
        {
            PrintSeparator();
            Console.WriteLine($"{separator}");
            PrintSeparator();
        }
        
        /// <summary>
        /// Creates a triangle with the given symbol and amount
        /// </summary>
        /// <param name="inputCharacter"></param>
        /// <param name="size"></param>
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            string symbol = Convert.ToString(inputCharacter);
            string symbol2 = symbol;
            for (int i = 1; i <size; i++)
            {
                Console.WriteLine(symbol);
                symbol = symbol + symbol2;
                
            }

            for (int i = size; i >= 1; i--)
            {

                Console.WriteLine(symbol);
                symbol = symbol.Remove(i - 1);
               
            }
        }
       
        /// <summary>
        /// Calculates the age of something based on inputed value
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        static int AgeCalculator(int year)
        {
            return 2024 - year;
        }
        
        /// <summary>
        /// Creates a short summary of a character with their age, calls the AgeClaculator method
        /// </summary>
        /// <param name="name"></param>
        /// <param name="birthYear"></param>
        static void CharacterInfo(string name, int birthYear)
        {
            int calc = AgeCalculator(birthYear);
            Console.WriteLine($"{name} turns {calc} this year");
        }
    }
}
