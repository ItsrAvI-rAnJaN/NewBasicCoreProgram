using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class SwapTwoNumber
    {

        public void SwapNumber()
        {
            // Taking input Two Number From User 
            Console.Write("Enter First Number : ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nBefore Swapping \nFirst Number = {0} & Second Number= {1} ", Num1, Num2);

            //Defining Logic for Swapping..
            int Swap = Num1;
            Num1 = Num2;
            Num2 = Swap;

            // Print After Swaping...
            Console.WriteLine("\nAfter Swapping\nFirst Number = {0} & Second Number = {1}", Num1, Num2);
        }
    }
}
