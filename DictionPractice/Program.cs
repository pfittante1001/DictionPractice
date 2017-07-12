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
            //Dictionary<string, string> favCandy = new Dictionary<string, string>()//instansiaite and 
            //{
            //    {"A1", "twix" },
            //    {"A2", "Reeses" },
            //    {"A3", "M&M" }
            //};

            //foreach (KeyValuePair<string,string>  candy in favCandy){

            //    Console.WriteLine(candy);
            //}

            //Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            //drinkMachine.Add(10, "ginger ale");
            //drinkMachine.Add(11, "pepsi");
            //drinkMachine.Add(9, "dr. pepper");

            //drinkMachine.Count();// tells how many items in the dictionary

            //foreach (KeyValuePair<int, string> drink in drinkMachine)
            //{
            //    Console.WriteLine(drink.Key);
            //    Console.WriteLine(drink.Value);
            //}

            //Dictionary<int, String> coatCheck = new Dictionary<int, string>();

            //coatCheck.Add(1, "leather");
            //coatCheck.Add(2, "suade");
            //coatCheck.Add(3, "biker leather");
            //coatCheck.Add(4, "stripper coat");
            //coatCheck.Add(5, "winter coat");

            //foreach(KeyValuePair<int, string> coat in coatCheck)
            //{
            //    Console.WriteLine(coat);
            //}

            Dictionary<string, int> aminmalCount = new Dictionary<string, int>();

            aminmalCount.Add("snake", 1);
            aminmalCount.Add("parrot", 2);
            aminmalCount.Add("wolf", 3);
            aminmalCount.Add("monkey", 4);
            aminmalCount.Add("giraffe", 5);
            aminmalCount.Add("bear", 6);
            aminmalCount.Add("spider", 7);
            aminmalCount.Add("deer", 8);

            int tempHigh = 1;
            int tempLow = 1;
            string tempKeylow = "";
            string tempKeyhigh = " ";

            foreach (KeyValuePair<string, int> count in aminmalCount)
            {
                if (count.Value <= tempLow)
                {

                    tempKeylow = count.Key;
                    tempLow = count.Value;

                }
                if (count.Value > tempLow)
                {
                    tempKeyhigh = count.Key;
                    tempHigh = count.Value;



                }

            }
            Console.WriteLine(tempKeylow);
            Console.WriteLine(tempKeyhigh);

            foreach (KeyValuePair<string, int> count in aminmalCount)
            {
                if (tempKeylow == count.Key)
                {


                    aminmalCount.Remove(count.Key);
                    break;
                }

            }

            foreach (KeyValuePair<string, int> count in aminmalCount)
            {
                Console.WriteLine(count);

            }

        }
    }
}
    