using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 30;
            int[] a = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int n = a.Length;
            int l = 0;
            int r = n - 1;
            int mid;

            while (l <= r)
            {
                mid = (l + r) / 2;

                if (x == a[mid])
                {
                    Console.WriteLine(mid);
                    return;
                }
                else if (x < a[mid])
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }

            Console.WriteLine(-1);
        }
    }
}
    
