using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class EvenOrOdd
    {
        public void CheckEvenorOdd()
        {
            Console.Write("Enter The Number to Check Even or Odd : ");
            int Number = Convert.ToInt32(Console.ReadLine());

            // Defining Logic to Check Even or Odd
            if (Number % 2 == 0)
            {
                Console.WriteLine("The Number You Enter is an Even Number");
            }
            else
            {
                Console.WriteLine("The Number You Enter is an Odd Number");
            }
        }
    }
}
