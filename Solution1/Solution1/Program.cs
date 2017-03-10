using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution1
{
    class Program
    {
        public static void func(){
            string s = Console.ReadLine();
            string[] p = s.Split();
            int[] arr = new int[p.Length];
            int sum=0;
            for (int i = 0; i < p.Length; i++)
            {
                arr[i] = int.Parse(p[i]);
                sum += arr[i];
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            func();
        }
    }
}
