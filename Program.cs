using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string__
{
    class Program
    {
        static string[] page = new string[100];
        static string[] art = new string[100];
        static bool reset = true;


        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the adventure you choose");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("");
            Console.WriteLine("[Press enter]");
            Console.ReadKey(true);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"You wake up with a bump on her head and a stick up your ass. 
You see a path and a river.  Which do you choose to travel?");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("");
            Console.WriteLine("[Press e for river]");
            Console.WriteLine("[Press a for path]");
            Console.ForegroundColor = ConsoleColor.White;

            //--------------------------------------//
            while (reset == true)
            {
                //--------------------------------------//

                art[0] = @"

                                                @@@@
                                             @@@@@@@@@
                                           @@@@@jf@@ ```\
                                           @@@@@@@       \
                                          @@@@@@@         \
                                            @@@   )        \
                                                  /         \
                                                 /           \
                                                /             \
                                               /               \
                                    _ _       /                 \
                                   ( ^ )     /                   \
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'";

                art[3] = @"
                     .
                    / V\
                  / `  /
                 <<   |
                 /    |
               /      |
             /        |
           /    \  \ /
          (      ) | |
  ________|   _/_  | |
<__________\______)\__)" + @"
                        |\---/|
                       /  , , |
                  __.-'|  / \ /
         __ ___.-'        ._O|
      .-'  '        :      _/
     / ,    .        .     |
    :  ;    :        :   _/
    |  |   .'     __:   /
    |  :   /'----'| \  |
    \  |\  |      | /| |
     '.'| /       || \ |
     | /|.'       '.l \\_
     || ||             '-'
     '-''-'" + @"
      /^\      /^\
      |  \    /  |
      ||\ \../ /||
      )'        `(
     ,;`w,    ,w';,
     ;,  ) __ (  ,;
      ;  \(\/)/  ;;
     ;|  |vwwv|    ``-...
      ;  `lwwl'   ;      ```''-.
     ;| ; `""' ; ;              `.
      ;         ,   ,          , |
      '  ;      ;   l    .     | |
      ;    ,  ,    |,-,._|      \;
       ;  ; `' ;   '    \ `\     \;
       |  |    |  |     |   |    |;
       |  ;    ;  |      \   \   (;
       | |      | l       | | \  |
       | |      | |       | |  ) |
       | |      | ;       | |  | |
       ; ,      : ,      ,_.'  | |
      :__'      | |           ,_.'
               `--'";

                art[4] = @"
┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘
┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌
┌┘┌┘┌┘┌┘┌┘┌███┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘
┘┌┘┌┘┌┘┌┘┌█████┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌
┌┘┌┘┌┘┌┘┌██┘┌┘█┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘███┘┌┘┌┘
┘┌┘┌┘┌┘┌██┘┌┘┌█┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌█████┌┘┌┘┌
┌┘┌┘┌┘┌┘█┘┌┘┌┘██┌┘┌┘┌┘┌┘┌┘┌┘┌██┘┌┘██┌┘┌┘
┘┌┘┌┘┌┘┌█┌┘┌┘┌██┘┌┘┌┘┌┘┌┘┌┘┌┘█┘┌┘┌┘█┘┌┘┌
┌┘┌┘┌┘┌██┘┌┘┌┘██┌┘┌┘┌┘┌┘┌┘┌┘██┌┘┌┘┌█┌┘┌┘
┘┌┘┌┘┌┘██┌┘┌┘┌██┘┌┘┌┘┌┘┌┘┌┘┌█┌┘┌┘┌██┘┌┘┌
┌┘┌┘┌┘┌┘█┘┌┘┌██┘┌┘┌┘┌┘┌┘┌┘┌┘█┘┌┘┌┘██┌┘┌┘
┘┌┘┌┘┌┘┌██┘┌███┌┘┌┘┌┘┌┘┌┘┌┘┌██┘┌┘┌█┌┘┌┘┌
┌┘┌┘┌┘┌┘┌█████┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌██┘███┘┌┘┌┘
┘┌┘┌┘┌┘┌████┘┌┘┌┘┌┘┌┘┌┘███████████┘┌┘┌┘┌
┌┘┌┘┌┘┌██████┘┌┘┌┘┌██████████████┘┌┘┌┘┌┘
┘┌┘┌┘████┌███┌┘┌┘███████┘┌┘██████┌┘┌┘┌┘┌
┌┘┌┘████┌┘███┘┌┘████┌┘┌┘┌┘┌┘┌█████┌┘┌┘┌┘
┘┌┘████┌┘┌████┘███┘┌┘┌┘┌┘┌┘┌███┌███┌┘┌┘┌
┌┘███┘┌┘┌████████┘┌┘┌┘┌┘┌┘┌┘██┌┘┌███┌┘┌┘
┘┌███┌┘┌┘██┌████┘┌┘┌┘┌┘┌┘┌┘┌██┘┌┘┌██┘┌┘┌
┌┘┌███┌┘┌██┘┌██┘┌┘┌┘┌┘┌┘┌┘┌███┌┘┌┘███┘┌┘
┘┌┘┌██┘┌┘██┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌███┌┘┌┘┌┘███┘┌
┌┘┌┘███┘┌██┘┌┘┌┘┌┘┌┘┌┘┌┘┌█████┌┘┌┘┌┘██┌┘
┘┌┘┌┘██┌┘██┌┘┌┘┌┘┌┘┌┘┌┘┌██████┘┌┘┌┘┌┘┌┘┌
┌┘┌┘┌┘┌┘┌███┌┘┌┘┌┘┌┘┌┘████┌┘██┌┘┌┘┌┘┌┘┌┘
┘┌┘┌┘┌┘┌┘████┌┘┌┘┌┘┌┘███┘┌┘┌███┌┘┌┘┌┘┌┘┌
┌┘┌┘┌┘┌┘┌█████┌┘┌┘┌┘███┘┌┘┌┘┌██┘┌┘┌┘┌┘┌┘
┘┌┘┌┘┌┘┌┘██┌███┌┘┌█████┌┘┌┘┌┘██┌┘┌┘┌┘┌┘┌
┌┘┌┘┌┘┌┘┌┘██┌██┘┌┘██████████┌┘██┌┘┌┘┌┘┌┘
┘┌┘┌┘┌┘┌┘┌█████┌┘┌┘┌┘┌██████████┘┌┘┌┘┌┘┌
┌┘┌┘┌┘┌┘┌┘████┌┘┌┘┌┘┌┘███┘┌██████┘┌┘┌┘┌┘
┘┌┘┌┘┌┘┌┘████┌┘┌┘┌┘┌┘┌███┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌
┌┘┌┘┌┘┌█████┌┘┌┘┌┘┌┘┌████┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘
┘┌┘┌┘┌┘█████┘┌┘┌┘┌┘┌██████┘┌┘┌┘┌┘┌┘┌┘┌┘┌
┌┘┌┘┌┘┌██┘██┌┘┌┘┌┘┌┘██┌┘███┘┌┘┌┘┌┘┌┘┌┘┌┘
┘┌┘┌┘┌┘██┌██┘┌┘┌┘█████┘┌┘██┌┘┌┘┌┘┌┘┌┘┌┘┌
┌┘┌┘┌┘┌██┘██┌┘┌┘┌┘███┘┌┘┌┘██┌┘┌┘┌┘┌┘┌┘┌┘
┘┌┘┌┘┌┘┌┘┌███┌┘┌┘┌┘┌┘┌┘┌┘███┘┌┘┌┘┌┘┌┘┌┘┌
┌┘┌┘┌┘┌┘┌┘┌███┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘
┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌┘┌
";
                art[6] = @"
                                   /\
                              /\  //\\
                       /\    //\\///\\\        /\
                      //\\  ///\////\\\\  /\  //\\
         /\          /  ^ \/^ ^/^  ^  ^ \/^ \/  ^ \
        / ^\    /\  / ^   /  ^/ ^ ^ ^   ^\ ^/  ^^  \
       /^   \  / ^\/ ^ ^   ^ / ^  ^    ^  \/ ^   ^  \       *
      /  ^ ^ \/^  ^\ ^ ^ ^   ^  ^   ^   ____  ^   ^  \     /|\
     / ^ ^  ^ \ ^  _\___________________|  |_____^ ^  \   /||o\
    / ^^  ^ ^ ^\  /______________________________\ ^ ^ \ /|o|||\
   /  ^  ^^ ^ ^  /________________________________\  ^  /|||||o|\
  /^ ^  ^ ^^  ^    ||___|___||||||||||||___|__|||      /||o||||||\       |
 / ^   ^   ^    ^  ||___|___||||||||||||___|__|||          | |           |
/ ^ ^ ^  ^  ^  ^   ||||||||||||||||||||||||||||||oooooooooo| |ooooooo  |
ooooooooooooooooooooooooooooooooooooooooooooooooooooooooo";

                art[8] = @"
                                                                              ░░▓▓▓▓  
                                                                            ▓▓▓▓████▓▓
                                                                          ▓▓▓▓████    
                                                                      ▓▓▓▓▓▓████      
                                                        ▒▒▓▓▓▓▓▓    ▒▒▓▓▓▓████        
                                                        ▓▓████▓▓  ▓▓▓▓▓▓████          
                                                        ▓▓██████▓▓▓▓▓▓████            
                                                        ▓▓  ▓▓██▓▓▓▓████              
                                                          ▓▓▓▓██▓▓████                
                                                        ▓▓▓▓▓▓▓▓████                  
                                                      ██▓▓▓▓████                      
                                                  ░░▓▓████████▓▓                      
                                                ▓▓▓▓████▓▓▓▓▓▓██▓▓                    
                                          ▓▓▓▓▓▓████▓▓▓▓      ████▓▓                  
                                        ░░▓▓▓▓████▓▓          ██████                  
                                ▒▒  ▒▒▓▓▓▓▓▓████                ████                  
                                ▓▓▓▓▓▓▓▓▓▓██▓▓                                        
                              ▓▓▓▓▓▓▓▓▓▓████                                          
                          ▓▓▓▓▓▓▓▓▓▓▓▓████                                            
                            ▓▓▓▓██▓▓████                                              
                        ▓▓▓▓▓▓▓▓██████                                                
        ████████    ▓▓▓▓▓▓▓▓██████                                                    
        ████████████▓▓▓▓██████  ██████                                                
        ▓▓  ▓▓████▓▓██████                                                            
          ░░▓▓████████                                                                
      ░░▓▓▓▓████▓▓                                                                    
    ░░▓▓▓▓██▓▓▓▓                                                                      
  ▒▒▓▓██████                                                                          
▒▒▓▓████                                                                              
";

                art[9] = @"
----------------------//\\
---------------------// ¤ \\
---------------------\\ ¤ //
---------------------- \\//
-------------------- (___)
---------------------(___)
---------------------(___)
---------------------(___)_________
--------\_____/\__/----\__/\_____/
------------\ _°_[------------]_ _° /
----------------\_°_¤ ---- ¤_°_/
--------------------\ __°__ /
---------------------|\_°_/|
---------------------[|\_/|]
---------------------[|[¤]|]
---------------------[|;¤;|]
---------------------[;;¤;;]
--------------------;;;;¤]|]\
-------------------;;;;;¤]|]-\
------------------;;;;;[¤]|]--\
-----------------;;;;;|[¤]|]---\
----------------;;;;;[|[¤]|]|---|
---------------;;;;;[|[¤]|]|---|
----------------;;;;[|[¤]|/---/
-----------------;;;[|[¤]/---/
------------------;;[|[¤/---/
-------------------;[|[/---/
--------------------[|/---/
---------------------/---/
--------------------/---/|]
-------------------/---/]|];
------------------/---/¤]|];;
-----------------|---|[¤]|];;;
-----------------|---|[¤]|];;;
------------------\--|[¤]|];;
-------------------\-|[¤]|];
---------------------\|[¤]|]
----------------------\\¤//
-----------------------\|/
------------------------V
";

                art[10] = @"
                           ,--.
                          {    }
                          K,   }
                         /  `Y`
                    _   /   /
                   {_'-K.__/
                     `/-.__L._
                     /  ' /`\_}
                    /  ' /     
            ____   /  ' /
     ,-'~~~~    ~~/  ' /_
   ,'             ``~~~%%',
  (                     %  Y
 {                      %% I
{      -                 %  `.
|       ',                %  )
|        |   ,..__      __. Y
|    .,_./  Y ' / ^Y   J   )|
\           |' /   |   |   ||
 \          L_/    . _ (_,.'(
  \,   ,      ^^""' / |      )
    \_  \          /,L]     /
      '-_`-,       ` `   ./`
         `-(_            )
             ^^\..___,.--`";


                //--------------------------------------//
                //page[0] = @"f
                // t
                // 3";
                

                page[0] = @"You try to swim across the river. Unfortunately, you cannot swim, you die.";

                page[1] = "You walk down the path and a strange man offers you a drink. Do you drink? ";

                page[2] = @"You take the drink and feel refreshed. You then pass out.
You wake up in a cabin. 
You decide to leave. 
Do you go left or right down the path?";

                page[3] = @"You were attacked by a bunch of wolves.
Unfortunately, your stick is not a powerful enough weapon.
The wolves kill you.";

                page[4] = @"You find a home.
The family inside welcomes you in.
You spend the next 40 years enjoying life to the fullest and marrying his daughter.";

                page[5] = @"You politely declined the offer. You find a mountain path and a forest. 
Where do you go?";

                page[6] = @"You climb the steep road of the mountain. You find an abandoned farmhouse.
You decide to make this your home. You have lived peacefully on the mountain top for 60 years. ";

                page[7] = @"You trek through the forest. You encounter a hollow king. What will you do?";

                page[8] = @"You give the hollow king your stick and tell him to guess where this has been.
The king does not hesitate to drive his sword through your heart. ";

                page[9] = @"You rushed the king and pushed him over.
You quickly grab his sword and plunge it through his heart or what's left of it.
Black fog emanates from the forest and income is you. You emerged with a newfound power.
You live for 1000 years.";

                page[10] = @"You attempt to trick the king. You tell the king that you are his son.
The king says with a raspy voice, I am a virgin. The king then decapitates you.";
                //--------------------------------------//

                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                ConsoleKeyInfo input;
                input = Console.ReadKey(true);

                

                if (input.KeyChar == 'e')
                {
                    Console.WriteLine("");
                    Console.WriteLine(page[0]);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(art[0]);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("");
                    Console.WriteLine("[Press enter]");
                    Console.ReadKey(true);
                    reset = false;
                }
                //if (input.KeyChar == )
                {
                    //Console.WriteLine("not an option");
                    
                }
                
                //--------------------------------------//

                if (input.KeyChar == 'a')
                {
                    //reset = false;
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(page[1]);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("");
                    Console.WriteLine("[Press s for yes]");
                    Console.WriteLine("[Press r for no]");
                    
                }

                //--------------------------------------//

                if (input.KeyChar == 's')
                {
                    //reset = false;
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(page[2]);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("");
                    Console.WriteLine("[Press k for Left]");
                    Console.WriteLine("[Press y for Right]");

                }

                //--------------------------------------//

                if (input.KeyChar == 'k')
                {
                    //reset = false;
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(page[3]);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(art[3]);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("");
                    Console.WriteLine("[Press enter]");
                    Console.ReadKey(true);
                    reset = false;

                }

                //--------------------------------------//

                if (input.KeyChar == 'y')
                {
                    //reset = false;
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(page[4]);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(art[4]);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("");
                    Console.WriteLine("[Press enter]");
                    Console.ReadKey(true);
                    reset = false;

                }

                //--------------------------------------//

                if (input.KeyChar == 'r')
                {
                    //reset = false;
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(page[5]);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("");
                    Console.WriteLine("[Press v for mountain]");
                    Console.WriteLine("[Press g for forest]");

                }

                //--------------------------------------//

                if (input.KeyChar == 'v')
                {
                    //reset = false;
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(page[6]);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(art[6]);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("");
                    Console.WriteLine("[Press enter]");
                    Console.ReadKey(true);
                    reset = false;

                }

                //--------------------------------------//

                if (input.KeyChar == 'g')
                {
                    //reset = false;
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(page[7]);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("");
                    Console.WriteLine("[Press t for Give him your stick]");
                    Console.WriteLine("[Press f for Charge the king]");
                    Console.WriteLine("[Press u for Outsmart the king]");

                }

                //--------------------------------------//

                if (input.KeyChar == 't')
                {
                    //reset = false;
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(page[8]);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(art[8]);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("");
                    Console.WriteLine("[Press enter]");
                    Console.ReadKey(true);
                    reset = false;

                }

                //--------------------------------------//

                if (input.KeyChar == 'f')
                {
                    //reset = false;
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(page[9]);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(art[9]);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("");
                    Console.WriteLine("[Press enter]");
                    Console.ReadKey(true);
                    reset = false;

                }

                //--------------------------------------//

                if (input.KeyChar == 'u')
                {
                    //reset = false;
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(page[10]);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(art[10]);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("");
                    Console.WriteLine("[Press enter]");
                    Console.ReadKey(true);
                    reset = false;

                }

                //--------------------------------------//
            }

        }
    }
}
