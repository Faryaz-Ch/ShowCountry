using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Paractical1
{
    /// <summary>  
    /// C# a program that that asks the user to guess the country name based on a displayed capital city. 
    /// The user has the choice to enter up to three country names, in one line separated by a comma.
    /// Display a warning if user has typed more than three names. 
    /// for re-entry until exactly three names are received
    /// If user input is not one of the four specified letters, your program must prompt for re-entry until
    /// a valid input is received.
    /// Author: Faryaz
    /// </summary>

    class MainClass
    {
        public static void Main(string[] args)
        {
            ShowCountry();

        }
        static void ShowCountry()
        {
            string[] country = new string[]
            {"Greece","Germany","Thailand"," Netherlands","China", "Turkey"};
            string[] capital = new string[]
            {"Athens","Berlin","Bangkok","Amsterdam","Beijing","Ankara"};
            Random rnd = new Random();
            int rand = rnd.Next(0, 5);
            string capitalNames = capital[rand];
            WriteLine($"Which country has the capital city {capitalNames}: ");
            WriteLine("Enter up to 3 names, comma separated: ");
            string countryNames = ReadLine();
            string[] countryNameAsString = countryNames.Split(',');

            if (countryNameAsString.Length < 3)
            {
                ShowCountry();
            }
            else if (countryNameAsString.Length > 3)
            {
                WriteLine($"You can enter only up-to 3 names: ");
                WriteLine($"Program finished.");
            }
            else
            {
                int idx = Array.IndexOf(countryNameAsString, country[rand]);
                if (idx > -1)
                {
                    WriteLine($"The country is {country[rand]}: ");
                    WriteLine($"The answer is correct.");

                }
                else
                {
                    WriteLine($"The country is {country[rand]}: ");
                    WriteLine($"Your answer is incorrect.");
                }
            }

        }
    }
}