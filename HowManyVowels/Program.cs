using System;

namespace HowManyVowels
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program p = new Program(); //creating object of the class Program
            p.CountVowels("Mujeera"); //calling method
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inpstr"></param>
        /// <returns></returns>
        public int CountVowels(string str1)
        {
            int vowel_count = 0;
            int consonent_count = 0;
            
            for (int i = 0; i < str1.Length; i++)
            {
                if(str1[i] == 'a' || str1[i] == 'e' || str1[i] == 'i' || str1[i] == 'o' || str1[i] == 'u')
                {
                    vowel_count++;
                }
                else
                {
                    consonent_count++;
                }
            }

            Console.WriteLine("Vowel count is : {0}" , vowel_count);
            Console.WriteLine("Consonent count is : {0}", consonent_count);
            Console.ReadLine();
            return 1;
        }
    }
}
