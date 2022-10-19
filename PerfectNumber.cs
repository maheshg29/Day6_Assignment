using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalprograming
{
    internal class PerfectNumber
    {
        public static void Pnum()
        {
            int number, sum = 0, temp;
            Console.WriteLine("Enter the Number");
            number = Convert.ToInt32(Console.ReadLine());
           temp = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == temp)
                Console.WriteLine(temp +" is a perfect number");
                
            else
            Console.WriteLine(temp + " is not a perfect number");
                
            
        }
    
    }
}
