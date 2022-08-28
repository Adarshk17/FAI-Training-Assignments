using System;


namespace week1_Assignment
{
    class Assignment5
    {
        static void Main(string[] args)
        {
            int principal = Util.GetNumber("Enter the principal amount");
            int time = Util.GetNumber("Enter the time ");
            int rate = Util.GetNumber("Enter the rate");
            Double simpleInterest = findInterest(principal, time, rate);
            Console.WriteLine("Simple interest is "+simpleInterest);
        }

        private static Double findInterest(int principal, int time, int rate)
        {
           return (principal*rate*time)/100;
        }
    }
}
