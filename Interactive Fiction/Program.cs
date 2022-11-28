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
        static bool game;
        static void Main(string[] args)
        {
            //story
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

            //start
            Console.WriteLine("Gnome Quest Adventure\r\nPress any button to start");
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            //Console.WriteLine("a=" + a);
            //Console.WriteLine("b=" + b);
            Console.WriteLine(story[a, b]);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("r = restart");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Q = Quit");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("e = endings");
            gamerun = true;
            game = true;
            while (game)
            {
                while (gamerun)
                {
                    //input
                    ConsoleKeyInfo input;
                    input = Console.ReadKey(true);
                    if (input.KeyChar == 'r')
                    {
                        a = 1;
                        b = 1;
                    }
                    if (input.KeyChar == 'a')
                    {
                        a = a + 1;
                    }
                    else if (input.KeyChar == 'b')
                    {
                        b = b + 1;
                    }
                    if (input.KeyChar == 'q')
                    {
                        Environment.Exit(0);
                    }
                    if (input.KeyChar == 'g')
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Ending 7");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("G");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("o");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("m");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("e");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("d");
                        Console.ReadKey(true);
                        Environment.Exit(0);
                    }
                    if (input.KeyChar == 'e')
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("1 = Poor judgment");
                        Console.WriteLine("2 = Oblivious");
                        Console.WriteLine("3 = Slow and steady");
                        Console.WriteLine("4 = A little help");
                        Console.WriteLine("5 = WTF");
                        Console.WriteLine("6 = Mythical success");
                        Console.WriteLine("G = Gnomed");
                        Console.ReadKey(true);
                    }
                    //TX
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    //Console.WriteLine("a=" + a);
                    //Console.WriteLine("b=" + b);
                    Console.WriteLine(story[a, b]);


                    //game end
                    if (a == 2 & b == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Ending 1");
                        gamerun = false;
                    }
                    if (a == 1 & b == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Ending 2");
                        gamerun = false;
                    }
                    if (a == 3 & b == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Ending 3");
                        gamerun = false;
                    }
                    if (a == 2 & b == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Ending 4");
                        gamerun = false;
                    }
                    if (a == 4 & b == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Ending 5");
                        gamerun = false;
                    }
                    if (a == 3 & b == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Ending 6");
                        gamerun = false;
                    }
                    //more input
                    if (gamerun == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("r = restart");
                    }
                    if (gamerun == true)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Q = Quit");
                    }
                    if (gamerun == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("e = endings");
                    }


                }

                //Game over
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ");
                Console.WriteLine("Game over");
                Console.WriteLine("Press spacebar");
                a = 1;
                b = 1;
                gamerun = true;
            }

        }

    }
}
