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

            Console.WriteLine("start");

            //--------------------------------------//
            while (reset == true)
            {

                //--------------------------------------//
                page[0] = "eee";
                page[1] = "aaa";
                page[2] = "sss";
                page[3] = "rrr";
                //--------------------------------------//

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
                //if (input.KeyChar == )
                {
                    //Console.WriteLine("not an option");
                    
                }
                
                //--------------------------------------//

                if (input.KeyChar == 'a')
                {
                    //reset = false;
                    Console.WriteLine(page[1]);
                }

                //--------------------------------------//

                if (input.KeyChar == 's')
                {
                    //reset = false;
                    Console.WriteLine(page[2]);
                }

                //--------------------------------------//

                if (input.KeyChar == 'r')
                {
                    //reset = false;
                    Console.WriteLine(page[3]);
                }

                //--------------------------------------//
            }

        }
    }
}
