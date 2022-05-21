using System;

namespace lab1vs_pr
{
    public class Programm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Тест №1: [5,3,4], 1: ");
            Console.WriteLine(HW1.QueueTime(new int[] { 5, 3, 4 }, 1));

            Console.WriteLine("\nТест №2: [10,2,3,3], 2: ");
            Console.WriteLine(HW1.QueueTime(new int[] { 10, 2, 3, 3 }, 2));

            Console.WriteLine("\nТест №3: [2,3,10], 2: ");
            Console.WriteLine(HW1.QueueTime(new int[] { 2, 3, 10 }, 2));

            /*Это так
            Console.WriteLine("Сколько всего касс? ");
            int kas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сколько всего покупателей? ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nВведите время каждого человека, которое они проводят за кассой ");

            int[] time_customers = new int[n];
            for (int k = 0; k < n; k++)
            {
                time_customers[k] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(HW1.QueueTime(time_customers, kas));
            */
        }
    }
}
