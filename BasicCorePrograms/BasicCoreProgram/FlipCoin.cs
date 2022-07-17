using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class FlipCoin
    {
        int NoofHead = 0;
        int NoofTail=0;
        Random random = new Random();
        public void CheckHeadTail()
        {
            Console.Write("Enter Number of Times to Flip Coin :");
            int Number=Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < Number; i++)
            {
                float NoofHeadTail = random.Next(0, 2);
                if (NoofHeadTail==1)
                {
                    NoofTail++;
                }
                else
                {
                    NoofHead++;
                }
                

            }
            Console.WriteLine("Number of Heads: {0}",NoofHead);
            Console.WriteLine("Number of Tails: "+NoofTail);
            float perofHeadsvsTails =(float) NoofHead / (float) NoofTail * 100;
            Console.WriteLine("Percentage of Head VS Tails: "+perofHeadsvsTails);
        }
    }
}
