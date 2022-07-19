using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class QuotientRemainder
    {
        public void ComputQutnRemdr()

        {


            // Taking Output From User..
            Console.Write("Enter The Dividend Number to Calculate The Quotient and Remainder : ");
            int Dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Divisor Number to Calculate The Quotient and Remainder : ");
            int Divisor = Convert.ToInt32(Console.ReadLine());
            if (Divisor != 0)
            {
                // Defing Logic for Quotient..
                int Quotient = Dividend / Divisor;

                //Defining  logic for Remainder..
                int Remainder = Dividend % Divisor;

                Console.WriteLine("Quotient of {0}/{1} = {2}", Dividend, Divisor, Quotient);
                Console.WriteLine("Remainder 0f {0}/{1} = {2}", Dividend, Divisor, Remainder);
            }
            else
            {
                Console.WriteLine(" Please enter Divisor Greater than 0");
            }




        }

    }
}
