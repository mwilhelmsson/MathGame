using System;

namespace mathgame
{
    class Game
    {
        public static bool Run()
        {
            bool retVal = true;
            int method = Menu.Methods();
            switch (method)
            {
                case -1:
                    retVal = false;
                    break;
                case 0:
                    Add();                    
                    break;
                case 1:
                    Subtract();
                    break;
                case 2:
                    Multiply();
                    break;
                case 3:
                    Divide();
                    break;
                default:
                    retVal = false;
                    break;
                    
            }
            return retVal;
        }

        private static void score()
        {
            
        }

        private static void Add()
        {
           int max = Menu.Number(); 
           Random rand = new Random();
           int first = rand.Next(max);
           int second = rand.Next(max);
           int result = first+second;
           Console.WriteLine($"{first}+{second}=?");
           var reply = Console.ReadLine();
           int answer = Convert.ToInt32(reply);
           if(answer == result)
           {
               Console.WriteLine("Bra, det var rätt!");
           }
           else
           {
               Console.WriteLine($"Tyvärr, {answer} var fel. Rätt svar var {result}.");
           }
           Console.Read();
        }

        private static void Subtract()
        {

        }

        private static void Multiply()
        {

        }

        private static void Divide()
        {

        }

    }
}