using System;

namespace YourNamespace
{
    public class YourClass
    {
        public static void Main(string[] args)
        {
            string numstr;
            // When the console reeds anything -> string
            int numberAsInt;

            Console.WriteLine("Enter a number to not it's table:");
            numstr = Console.ReadLine();

            // Convert "num" str to int
            numberAsInt = Convert.ToInt32(numstr);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numstr + " x " + i + " = " + (numberAsInt * i));
            }
        }
    }
}
