using System;

namespace BasicCoreProgram
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t#################################################");
            Console.WriteLine("\t\t\t\t\tWELCOME TO BASIC CORE PROGRAMS");
            Console.WriteLine("\t\t\t\t#################################################");
            Console.WriteLine("0.Exit");
            Console.WriteLine("1.FlipCoin & print Percentage of Heads vs Tails");
            Console.WriteLine("2.Program to check Leap Year");
            Console.Write("Enter The Choice of Question: ");
            int Choice=Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                     FlipCoin objFlipcoin=new FlipCoin();
                     objFlipcoin.CheckHeadTail();
                     break;
                case 2:
                    LeapYear objLeapYear =new LeapYear();
                    objLeapYear.CheckLeap();
                    break;
                default:
                    Console.WriteLine("Enter Valid Question Number");
                    break;
            }
            
            Console.ReadKey();
        }
    }
}