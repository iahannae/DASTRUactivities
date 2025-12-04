using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabalatan_ControlStructures
{
    internal class Program
    {
        static void Main(string[] args)
 {
     double number1;
     char repeat;

     do
     {
         Console.Clear(); // console for a fresh display
         Console.WriteLine("This program will determine the type of number and display its range.");

         Console.Write("Please enter a number: ");

         if (double.TryParse(Console.ReadLine(), out number1))
         {
             if (number1 % 2 == 0)// Checks the number is even
             {
                 Console.WriteLine($"{number1} is an even number.\n");
                 Console.WriteLine("The range of even numbers from the entered number down to 2 is:");

                 for (double i = number1; i >= 2; i -= 2)// Loops from num1 to 2, decrementing by 2 to display even numbers
                 {
                     Console.Write(i + " ");
                 }
                 Console.WriteLine(); // New line after the range output
             }
             else
             {
                 // Informs the user that the entered number is not even
                 Console.WriteLine("Sorry, I cannot provide the range of even numbers for the number you entered.");
             }
         }
         else
         {
             // Handles invalid input
             Console.WriteLine("Invalid input, please enter a valid number.");
         }

         Console.Write("Do you want to try again (y/n)?");
         repeat = Console.ReadKey().KeyChar; // Waits for a key press to decide if repeating
         Console.WriteLine();
     } while (char.ToLower(repeat) == 'y'); // Continues loop if user presses 'y'
     Console.WriteLine("Thank You for using this program");



     Console.ReadKey();

        }
    }
}
