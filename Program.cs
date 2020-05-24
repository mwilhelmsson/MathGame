using System;

namespace mathgame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = false;
            while(!run)
            {
                int method = Menu.Choices("Addition", "Subtraktion", "Multiplikation", "Division");
                if(method == -1)
                    return;
                
            }
        }
    }
}
