using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string__
{
    class Program
    {
        static string[] page = new string[5];
        static bool reset = true;


        static void Main(string[] args)
        {

            while (reset == true)
            {

                page[0] = "eee";
                page[1] = "aaa";
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                ConsoleKeyInfo input;
                input = Console.ReadKey(true);


                if (input.KeyChar == 'e')
                {
                    //reset = false;
                    Console.WriteLine(page[0]);
                }
                else
                {
                    Console.WriteLine("not an option");
                    
                }

                

                //--------------------------------------//
                
                
                


                if (input.KeyChar == 'a')
                {
                    //reset = false;
                    Console.WriteLine(page[1]);
                }

                

                //--------------------------------------//


            }

        }
    }
}
