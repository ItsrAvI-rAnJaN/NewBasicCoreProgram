using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class LargestNumber
    {
        public void CheckLargestNo()
        {
            string LargestWord = "The Largest Number You Entered : ";
            Console.Write("Enter The First Number = ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number = ");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number = ");
            int Num3 = Convert.ToInt32(Console.ReadLine());

            // Defining Logic Among 3 No. Whose is Larget or  All are Equal
            if (Num1 > Num2 && Num1 > Num3)
            {
                Console.WriteLine(LargestWord + Num1);
            }
            else if (Num2 > Num1 && Num2 > Num3)
            {
                Console.WriteLine(LargestWord + Num2);
            }
            else if (Num3 > Num1 && Num3 > Num2)
            {
                Console.WriteLine(LargestWord + Num3);
            }
            else
            {
                Console.WriteLine("The Number You Entered All are Equal");
            }
        }
    }
}
