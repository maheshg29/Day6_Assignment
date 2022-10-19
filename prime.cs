using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalprograming
{
    internal class prime
    {
        public static void prmnum()
        {
            int n, i, m = 0, flag = 0;
            Console.WriteLine("Enter the Number to check Prime: ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(n+ "  is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write(n+ "  is Prime.");
        }

    }


   
    
}
