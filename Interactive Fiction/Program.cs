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
        
        static void Main(string[] args)
        {

             
            story = new string[5, 5];
            story[1, 1] = "You are a gnome and the great Kingdom of Underhill and you've been chosen to have a peace talk with the dwarves.\r\nTo help you make your way to the dwarves you brew a teleportation potion unfortunately the potion went Wong.\r\nYou try to make your way to the dwarves anyway.\r\n\r\nA = try to cross the river nearby\r\nB = search to see if anything got teleported with you\r\n";
            story[1, 2] = "You search around finding a bag of something and a wild horse\r\n\r\nA = get on the horse\r\nB = open the bag\r\n";
            story[1, 3] = "You're too distracted while looking in the bag to realize a snake is approaching. \r\nThe snake bites you on the leg and you die.\r\n";
            story[2, 1] = "You get about halfway through the river when you start to get tired you're unable to swim to the shore and drown\r\n";
            story[2, 2] = "You start riding down the road and it splits into two paths\r\n\r\nA = go left\r\nB = go right\r\n";
            story[3, 2] = "You ride down the road for a couple of days you're tired and hungry but you eventually make it to the dwarves";
            story[2, 3] = "You start riding down the road and your horse trips on a rock breaking its leg.\r\n\r\nA = open the bag\r\nB = start walking down the road\r\n";
            story[3, 3] = "You find a Rubik's Cube and Skíðblaðnir in the bag.\r\n\r\nA = Use Rubik's Cube\r\nB = Use Skíðblaðnir\r\n";
            story[2, 4] = "You start walking down the road when a merchant happens to be traveling on the road with you. \r\nThe merchant lets you hop on his cart on the way to the dwarves. \r\nIn a few hours you make it to the dwarves.\r\n";
            story[4, 3] = "You fixate on the Rubik's Cube and play with it for hours. \r\nYou eventually starve to death due to your extreme fixation on the Rubik's Cube.\r\n";
            story[3, 4] = "You unfold Skíðblaðnir and ride the boat down the river. \r\nYou eventually make it safely down the river to the home of the dwarves\r\n";

            int a = 1;
            int b = 1;

            
            Console.WriteLine("Gnome Quest Adventure\r\nPress any button to start");
            Console.ReadKey(true);

            Console.Clear();
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine(story[a, b]);
            Console.WriteLine("Q = Quit");

            gamerun = true;
            while (gamerun)
            {

                
                ConsoleKeyInfo input;
                input = Console.ReadKey(true);

                

                if (input.KeyChar == 'a')
                {
       
                    a = a + 1;
                    

                }
                else if(input.KeyChar == 'b')
                {

                    b = b + 1;
                    
                }
                if (input.KeyChar == 'q')
                {
                    Environment.Exit(0);
                }
                Console.Clear();
                Console.WriteLine("a=" + a);
                Console.WriteLine("b=" + b);
                Console.WriteLine(story[a, b]);

            }


            //Console.WriteLine("Game over");
            //Console.ReadKey(true);
        }
        
    }
}
