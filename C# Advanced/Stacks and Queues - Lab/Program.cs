using System;
using System.Collections.Generic;


namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> supermarket = new Queue<string>();
            
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                else if (input =="Paid")
                {
                    while (supermarket.Count>0)
                    {
                        Console.WriteLine(supermarket.Dequeue());
                    }
                }
                else
                {
                    supermarket.Enqueue(input);
                }
            }

            Console.WriteLine($"{supermarket.Count} people remaining.");
        }
    }
}
