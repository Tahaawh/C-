using System;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStudents = 10;
            int[] students = new int[numStudents];

            for (int i = 0; i < numStudents; i++)
            {
                students[i] = i + 1;
            }

            int groupCount = numStudents / 2;

            for (int i = 0; i < groupCount; i++)
            {
                Console.WriteLine($"Group {i + 1}: {students[i]} - {students[numStudents - 1 - i]}");
            }

            Console.ReadLine();
        }
    }
}