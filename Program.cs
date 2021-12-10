using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Welcometotheadventureyouchoose
{
    class Program
    {

        static string[] art = new string[100];
        static bool gamePlay = false;
        static string[] pageContents = new string[6];
        static public int currentPage = 0;
        static bool mainMenu = true;
        static bool gameRun = true;


        static void Main(string[] args)
        {


            //--------------------------------------//

            art[1] = @"

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
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

";

            art[4] = @"
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
               `--'

";

            art[5] = @"
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
            art[7] = @"
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
ooooooooooooooooooooooooooooooooooooooooooooooooooooooooo

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
             ^^\..___,.--`

";

            art[11] = @"
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

            art[12] = @"
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





            //--------------------------------------//
            while (gameRun)
            {
                //Story file error checking//
                if (File.Exists("story.txt"))
                {

                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"Story file location error detected");
                    Console.ReadKey(true);
                    Environment.Exit(0);
                }

                //Story file reading//
                string[] story;
                story = System.IO.File.ReadAllLines("story.txt");

                while (mainMenu)
                {
                    //mainMenu Formatting//
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(art[7]);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@"Welcome to the adventure you choose You");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"
a = new game
b = load save");
                    Console.WriteLine(@"q = quit");

                    //key reader//
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                    ConsoleKeyInfo input;
                    input = Console.ReadKey(true);

                    //new game//
                    if (input.KeyChar == 'a')
                    {
                        currentPage = 0;
                        Console.Beep(750, 250);
                        mainMenu = false;
                        gamePlay = true;
                    }

                    //load save//
                    else if (input.KeyChar == 'b')
                    {
                        Console.Beep(750, 250);
                        if (File.Exists("savegame.txt"))
                        {
                            if (System.IO.File.ReadAllText("savegame.txt") == "")
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(@"There is no save
Press any key");
                                Console.ReadKey(true);

                            }
                            else
                            {
                                if (currentPage >= 14)
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(@"savegame is more the max page error detected");
                                    Console.ReadKey(true);
                                    Environment.Exit(0);
                                }
                                if (currentPage <= 13)
                                {
                                    currentPage = int.Parse(System.IO.File.ReadAllText("savegame.txt"));
                                    mainMenu = false;
                                    gamePlay = true;
                                }

                            }

                        }

                        //savegame file error checking//
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(@"There is no save
Press any key");
                            Console.ReadKey(true);


                        }

                    }

                    //quit game//
                    else if (input.KeyChar == 'q')
                    {
                        Console.Beep(750, 250);
                        Environment.Exit(0);
                    }

                    //Wrong key press//
                    else
                    {
                        Console.Beep(340, 250);
                        Console.WriteLine("Not an option forehead");
                        Console.ReadKey(true);
                    }
                }

                while (gamePlay)
                {

                    //Death page back to menu//
                    if (currentPage == 13)
                    {
                        Console.Clear();
                        Console.Beep(340, 250);
                        gamePlay = false;
                        mainMenu = true;
                    }

                    //Story manipulation error checking//
                    if (currentPage >= 14)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@"Story manipulation error detected");
                        Console.ReadKey(true);
                        Environment.Exit(0);
                    }

                    if (new FileInfo("story.txt").Length == 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@"FileInfo error detected");
                        Console.ReadKey(true);
                        Environment.Exit(0);
                    }

                    pageContents = story[currentPage].Split(';');

                    if (String.IsNullOrWhiteSpace(pageContents[0]))
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@"error detected 0");
                        Console.ReadKey(true);
                        Environment.Exit(0);
                    }

                    if (pageContents.Length < 5)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@"Page elements error detected");
                        Console.ReadKey(true);
                        Environment.Exit(0);
                    }

                    if (pageContents.Length > 5)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@"Page elements error detected");
                        Console.ReadKey(true);
                        Environment.Exit(0);
                    }

                    else
                    {
                        //Story file reader//
                        Console.Clear();
                        pageContents = story[currentPage].Split(';');

                        //Story Formatting//
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(pageContents[0] + art[currentPage]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("a = " + pageContents[1]);
                        Console.WriteLine("b = " + pageContents[2]);
                        Console.WriteLine("s = save");
                        Console.WriteLine("m = meun");
                    }

                    //key reader//
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                    ConsoleKeyInfo input;
                    input = Console.ReadKey(true);

                    //Option A//
                    if (input.KeyChar == 'a')
                    {
                        Console.Beep(750, 250);
                        currentPage = int.Parse(pageContents[3]);
                    }

                    //Option B//
                    else if (input.KeyChar == 'b')
                    {
                        Console.Beep(750, 250);
                        currentPage = int.Parse(pageContents[4]);
                    }

                    //back to mainMenu// 
                    else if (input.KeyChar == 'm')
                    {
                        Console.Beep(750, 250);
                        gamePlay = false;
                        mainMenu = true;
                    }

                    //save game//
                    else if (input.KeyChar == 's')
                    {
                        Console.Beep(750, 250);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("saved");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("pass enter");
                        File.WriteAllText("savegame.txt", currentPage.ToString());
                        Console.ReadKey(true);

                    }

                    //Wrong key press//
                    else
                    {
                        Console.Beep(340, 250);
                        Console.WriteLine("Not an option forehead");
                        Console.ReadKey(true);
                    }



                }
            }
        }
    }
}