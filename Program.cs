
using logicalprograming;
using System;
using System.Diagnostics;


public class logicalProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Logical Program");
        //logic.reverse();
        //FibonacciSeries.fiboseries();
        //PerfectNumber.Pnum();
        // prime.prmnum();
        //CouponNumber.checkCoupon();
        // Stopwatch.SimulateStopwatch();
        //----*****----*****----*****----*****----*****//
        /*Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep(10000);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime); */
            CouponNumber.checkCoupon();
    }
}