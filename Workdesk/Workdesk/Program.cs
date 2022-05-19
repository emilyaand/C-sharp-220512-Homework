using System;

namespace Emilya
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 9 };

            Console.WriteLine("Enter Age ");
            string ageStr = Console.ReadLine();
            int age = int.Parse(ageStr);

            bool flag = false;

            foreach (int element in arr)
            {

                if (element == age)
                {
                    flag = true;
                    break;
                }
            }
            Console.WriteLine(flag);

        }
    }
}