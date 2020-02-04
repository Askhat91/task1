using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a=new int[100];
            for(int i = 0; i < 100; i++)
            {
                a[i] = i+1;
                if (a[i] % 5 == 0)
                {
                    if (a[i] % 3 == 0)
                    {
                        a[i] = 35;
                    }
                    else
                    {
                        a[i] = 5;
                    }
                }else if (a[i] % 3 == 0)
                {
                    a[i] = 3;
                }
                Console.Write($"{a[i]}\t");
            }
            
            Console.WriteLine();
        }
    }
}
