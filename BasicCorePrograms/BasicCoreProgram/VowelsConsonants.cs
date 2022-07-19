using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class VowelsConsonants
    {
        public void CheckVowelConsonant()
        {
            //Declaring Array Which Contain Vowels
            char[] Vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            Console.Write("Enter an Alphabet : ");
            char Alphabet = Convert.ToChar(Console.ReadLine());


            //Defining Logic to Check Vowels
            if (Vowels.Contains(Alphabet))
            {
                Console.WriteLine("You Entered Vowel Alphabet : {0}", Alphabet);
            }

            //Defining Logic to Check Consonant
            else if (Char.IsLetter(Alphabet) && !Vowels.Contains(Alphabet))
            {
                Console.WriteLine("You Entered Consonant Alphabet : {0}", Alphabet);
            }

            else
            {
                Console.WriteLine("The Alphabet You Entered is neither Vowel nor Consonant");
            }

        }
    }
}
