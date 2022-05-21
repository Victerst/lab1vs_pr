using System.Linq;

namespace lab1vs_pr
{
    public class HW1
    {
        public static long QueueTime(int[] customers, int n)
        {
            int[] time_customers = new int[n];
            int k, time = 0, i;

            for (k = 0; k < n; k++) 
                time_customers[k] = customers[k];
            
            while (k < n || time_customers.Any(c => c > 0))
            {
                for (i = 0; i < n; i++)
                {
                    time_customers[i] -= 1;

                    if (time_customers[i] == 0 && k < customers.Length)
                        time_customers[i] = customers[k++];
                }
                time++;
            }
            return time;
        }
    }
}