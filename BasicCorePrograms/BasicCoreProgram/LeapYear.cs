using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class LeapYear
    {
        
        
       public void CheckLeap()
        {
            Console.Write("Enter The Four Digit Number of Years: ");
           int year = Convert.ToInt32(Console.ReadLine());

            if (year>999 && year < 9999)
            {
                if(year%400==0&& year%100==0 || year % 4 == 0)
                {
                    Console.WriteLine("The Entered Year is a leap Year");
                }
                else
                {
                    Console.WriteLine("The Entered Year is not Leap year");
                }
            }
            else
            {
                Console.WriteLine("Please Enter Valid Input");
            }
        }
    }
}
