using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine("Hop");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}