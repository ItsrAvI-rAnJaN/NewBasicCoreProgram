using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class Powerof2
    {
        public void TableofPower2()
        {
            Console.Write("Enter Limit N(N is Greater than 0 & Less than 31 : ");
            int N=Convert.ToInt32(Console.ReadLine());
            int Power = 1;
            Console.WriteLine("Power of 2");

            for (int i = 0; i < N; i++)
            {
                if (i == 0)
                {
                    Power=1;
                }
                else
                {
                    Power=Power*2;
                }
                Console.WriteLine("2^{0}= "+Power,i);
            }
        }
    }
}
