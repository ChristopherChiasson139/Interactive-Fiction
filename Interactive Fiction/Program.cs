using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Fiction
{
    internal class Program
    {
        static public string[,] story;
        static bool gamerun;
        static public int a = 1;
        static public int b = 1;
        static void Main(string[] args)
        {
            story = new string[10, 10];
            story[1, 1] = "1";
            story[1, 2] = "2";
            story[1, 3] = "3";
            story[1, 4] = "4";

            gamerun = true;
            while (gamerun)
            {
                ConsoleKeyInfo input;
                input = Console.ReadKey(true);

                switch (story[a, b])
                {
                    case "4":
                        gamerun = false;
                        break;
                }

                Console.WriteLine(story[a, b]);
                if (input.KeyChar == 'a')
                {
                    a = a + 1;
                }
                if (input.KeyChar == 'b')
                {
                    b = b + 1;
                }

                
            }


            Console.WriteLine("did");
            Console.ReadKey(true);
        }
        
    }
}
