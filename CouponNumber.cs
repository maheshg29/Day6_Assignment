using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalprograming
{
    internal class CouponNumber
    {
        public static void checkCoupon()
        {
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
            int max = 100000000;
            Random rand= new Random ();
         
            int num = rand.Next(max);

            StringBuffer sb = new StringBuffer();

            while (num > 0)
            {
                sb.append(chars[num % chars.Length]);
                num /= chars.Length;
            }

            String couponCode = sb.ToString();
          Console.WriteLine("Coupon Code: " + couponCode);
        }
    }
}
