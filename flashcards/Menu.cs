using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flashcards
{
    internal class Menu
    {

        internal void StartMenu()
        {

            bool isOptionselected = false;

            do
            {
                Console.WriteLine("Hi! Welcome to your flashcards!");
                Console.WriteLine(@"Please select an option:
e - Exit
c - Create
v - View
s - Study");
                var selectedOption = Console.ReadLine();

                switch (selectedOption.ToUpper().Trim())
                {
                    case "E":
                        Environment.Exit(0);
                        break;
                    case "C":
                        Console.WriteLine("c");
                        isOptionselected = true;
                        break;
                    case "V":
                        Console.WriteLine("v");
                        isOptionselected = true;
                        break;
                    case "S":
                        Console.WriteLine("s");
                        isOptionselected = true;
                        break;
                    default:
                        Console.WriteLine("Please enter in a valid letter");
                        break;
                }
                }while (!isOptionselected);

        }

    }
}
