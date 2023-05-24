using System;

namespace Loop
{
    class DoWhileLoop
    {
        public static void Main(string[] args)
        {
            int i = 0;

            do
            {
                
                Console.WriteLine("number is {0}",i);
                i++;
            } while (i < 100);
        }
    }
}