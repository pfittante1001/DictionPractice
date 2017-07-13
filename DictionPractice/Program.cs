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



            bool exitProgram = false;
            bool enterAnother = false;
            bool removeAnother = false;
            int tempMin = 1;
            int tempMax;
            List<string> tempKeyLowLST = new List<string>();
            List<string> tempKeyHighLST = new List<string>();
            Dictionary<string, int> aminmalCount = new Dictionary<string, int>();

            aminmalCount.Add("SNAKE", 9);
            aminmalCount.Add("PARROT", 1);
            aminmalCount.Add("WOLF", 3);
            aminmalCount.Add("MONKEY", 4);
            aminmalCount.Add("GIRAFFE", 1);
            aminmalCount.Add("BEAR", 8);
            aminmalCount.Add("SPIDER", 7);
            aminmalCount.Add("DEER", 8);
            aminmalCount.Add("BULL", 5);
            aminmalCount.Add("LLAMA", 3);


            //Console.Write("            List of animals before removal:\n\n");
            //foreach (KeyValuePair<string, int> count in aminmalCount)
            //{
            //    Console.Write("{0} ", count.Key);
            //}
            Console.WriteLine("\n\n\n");
            //This foreach loop finds the min and max values. The values are saved in two variables, and the keys
            //are saved in to lists
            while (exitProgram == false)
            {
                Console.Clear();
                Console.WriteLine("      If you would like to enter a new animal, please enter the name first");
                Console.WriteLine("             then the total number of the animal you entered\n\n\n\n\n");
                while (enterAnother == false)
                {
                    Console.Write("\n\nPlease enter the animal name or quit to exit: ");
                    string keyInputStr = Console.ReadLine().ToUpper();
                    ExitProgram(keyInputStr);

                    Console.Write("\n\nPlease enter the amount of the animal or quit to exit: ");
                    string valueInputStr = Console.ReadLine().ToUpper();
                    ExitProgram(valueInputStr);
                    int valueInput = int.Parse(valueInputStr);

                    aminmalCount.Add(keyInputStr, valueInput);
                    Console.Clear();
                    Console.Write("\n\n\nSelect enter to add another animal or quit to continue: ");
                    string enterAnotherStr = Console.ReadLine().ToUpper();
                    if(enterAnotherStr == "QUIT")
                    {
                        enterAnother = true;
                    }
                }

                Console.Clear();
                Console.WriteLine("      Select enter to remove an animal name or quit to continue:");
                while (removeAnother == false)
                {
                    string removeAnotherStr = Console.ReadLine().ToUpper();
                    if (removeAnotherStr == "QUIT")
                    {
                        removeAnother = true;
                        break;
                    }
                    Console.Write("\n\nPlease enter the animal name to remove or quit to exit: ");
                    string keyInputStr = Console.ReadLine().ToUpper();
                    ExitProgram(keyInputStr);

                    aminmalCount.Remove(keyInputStr);
                    Console.Clear();
                    Console.Write("\n\n\nSelect enter to remove another animal or quit to continue: ");
                    removeAnotherStr = Console.ReadLine().ToUpper();
                    if (removeAnotherStr == "QUIT")
                    {
                        removeAnother = true;
                    }
                }

                

                tempMax = aminmalCount.Values.Max();
                foreach (KeyValuePair<string, int> count in aminmalCount)
                {
                    if (count.Value <= tempMin)
                    {
                        tempMin = count.Value;
                        tempKeyLowLST.Add(count.Key);
                    }

                    if (tempMax == count.Value && tempKeyHighLST.Contains(count.Key)==false)
                    {
                        tempKeyHighLST.Add(count.Key);
                    }

                }

                //These nested loops compare the keys in the tempKeyLowLST and the animalCount dict. If the keys match
                // the entry is removed from animalCount
                for (int i = 0; i < tempKeyLowLST.Count; i++)
                {
                    foreach (KeyValuePair<string, int> count in aminmalCount)
                    {
                        if (tempKeyLowLST[i] == count.Key)
                        {
                            aminmalCount.Remove(count.Key);
                            break;
                        }
                    }
                }

                Console.Clear();
                Console.Write("\n\n\nThe animals with the most numbers each are: ");
                for (int i = 0; i < tempKeyHighLST.Count; i++)
                {
                    Console.Write("{0} ", tempKeyHighLST[i]);

                }

                Console.Write(" \n\n\n\n\n           List of animals after removal:\n\n");
                foreach (KeyValuePair<string, int> count in aminmalCount)
                {
                    Console.Write("{0} ", count.Key);
                }

                Console.Write("\n\n\n\nWould you like to enter another animal enter to continue or quit to exit: ");
                string exitProgramStr = Console.ReadLine().ToUpper();
                if (exitProgramStr == "QUIT")
                {
                    exitProgram = true;

                }else
                {
                    enterAnother = false;
                    removeAnother = false;
                }
            }
        }

        public static void ExitProgram(string exitProgram) 
        {
            if(exitProgram == "QUIT")
            {
                System.Environment.Exit(1);
            }
        }
       
    }
}
    