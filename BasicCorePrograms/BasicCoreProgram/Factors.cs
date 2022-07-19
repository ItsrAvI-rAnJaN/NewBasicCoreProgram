using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class Factors
    {
        public void PrimeFactorization()
        {
            Console.Write("Enter a Number to Find Prime Factors : ");
            int Num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Prime Factors of {0} = ", Num);

            //Taking While Loop for The Number is Divisible by 2 We are Dividing it..
            while (Num % 2 == 0)
            {
                Console.Write(2 + " ");
                Num /= 2;
            }

            //This  is For All The Odd Numbers Greater Than 2...
            for (int i = 3; i <= Math.Sqrt(Num); i += 2)
            {
                while (Num % i == 0)
                {
                    Console.Write(i + " ");
                    Num /= i;
                }
            }
            if (Num > 2)
            {
                Console.Write(Num);
            }

        }
    }
}
