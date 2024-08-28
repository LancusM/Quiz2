using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompts user to enter item price, sales tax, and promotion discount
            Console.WriteLine("Item Cost Calculator (Enter a decimal for percentage. 0.05 as 5%)");
            Console.WriteLine("Enter the item's price: ");
            float item = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the sales tax: ");
            float tax = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the discount: ");
            float discount = float.Parse(Console.ReadLine());
            
            float discount2 = item * discount;
            //Calculates the item's cost
            float cost = item - discount2 + tax;
            //displays answer of total cost
            Console.WriteLine("The item's total cost is: " + cost + " dollars.");
            Console.Read();
        }
    }
}