using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class HarmonicNumber
    {
        public void harmonicVal()
        {
            // Taking Input Form User  
            Console.Write("Enter the value of N to calculate Nth Harmonic Value : ");
            int N = Convert.ToInt32(Console.ReadLine()); //Store the value input from User 
            float HarmonicNumber = 0;
            if (N > 0)
            {
                //Harmonic Number logic
                for (float i = 1; i <= N; i++)
                {
                    HarmonicNumber += 1 / i;
                }
                Console.WriteLine("{0}th Harmonic Number is : {1}", N, HarmonicNumber);
            }
            else
            {
                Console.WriteLine("please Enter The Positive Number");
            }

        }

    }
}
