using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cupsx = 5;
            int amount = 0;

            string[] line = new string[4];

            line[0] = "milk";
            line[1] = "sugar";
            line[2] = "chocolate";
            line[3] = "cookies";

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(line[i] + amount);
                if (line[i] == "milk")
                {
                    amount = 5;
                    Console.WriteLine(line[i] + amount + "oz");

                }
                else if (line[i] == "sugar")
                {
                    amount = 2;
                    Console.WriteLine(line[i] + amount + "oz");

                }


                Console.WriteLine(line[1]);

                Console.ReadLine();
            }


        }
    }
}
