using System;

namespace mathgame
{
    class Menu
    {
        public static int Choices(params string[] Options)
        {
            const int StartX = 10;
            const int StartY = 5;
            
            int CurrentSelection = 0;

            ConsoleKey Key;

            Console.CursorVisible = false;

            do
            {
                Console.Clear();

                for(int i = 0; i < Options.Length; i++)
                {
                    Console.SetCursorPosition(StartX,StartY + i);
                    
                    if(i == CurrentSelection)
                        Console.ForegroundColor = ConsoleColor.Red;
                    
                    Console.Write(Options[i]);

                    Console.ResetColor();
                }

                Key = Console.ReadKey(true).Key;

                switch(Key)
                {
                    case ConsoleKey.UpArrow:
                        if(CurrentSelection > 0)
                            CurrentSelection--;
                        break;
                    case ConsoleKey.DownArrow:
                        if(CurrentSelection < Options.Length-1)
                            CurrentSelection++;
                        break;
                    case ConsoleKey.Escape:
                        return -1;
                }

            }while(Key != ConsoleKey.Enter);

            Console.CursorVisible = true;

            return CurrentSelection;
        }
    }
}