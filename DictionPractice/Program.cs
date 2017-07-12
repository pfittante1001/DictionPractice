using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> favCandy = new Dictionary<string, string>()//instansiaite and 
            {
                {"A1", "twix" },
                {"A2", "Reeses" },
                {"A3", "M&M" }
            };

            foreach (KeyValuePair<string,string>  candy in favCandy){

                Console.WriteLine(candy);
            }

            Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            drinkMachine.Add(10, "ginger ale");
            drinkMachine.Add(11, "pepsi");
            drinkMachine.Add(9, "dr. pepper");

            drinkMachine.Count();// tells how many items in the dictionary

            foreach (KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Key);
                Console.WriteLine(drink.Value);
            }
        }   

            

    }
}
