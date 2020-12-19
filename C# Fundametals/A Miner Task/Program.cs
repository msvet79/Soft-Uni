using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> mines = new Dictionary<string, double>();
            int counter = 0;
            string lastinput="";

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                counter++;
                

                if (counter % 2 == 0)
                {
                    mines[lastinput] = mines[lastinput]+ double.Parse(input);
                }
                else
                {
                    if (!mines.ContainsKey(input))
                    {
                        mines.Add(input, 0);
                        
                    }
                    lastinput = input;
                }
                
            }

            foreach (KeyValuePair<string,double> item in mines)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
