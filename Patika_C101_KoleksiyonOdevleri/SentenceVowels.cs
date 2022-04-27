using System;
using System.Collections.Generic;
using System.Collections;

namespace Patika_C101_KoleksiyonOdevleri
{
    public class SentenceVowels
    {
        public static void Vowels()
        {
            ArrayList vowelsArray = new ArrayList();



            Console.WriteLine("İşlem yapmak istediğiniz cümleyi giriniz:");
            string inputSentence = Console.ReadLine();
            string vowels = "aeıioöuü";


            for(int i = 0; i < inputSentence.Length; i++)
            {
                if(vowels.Contains(inputSentence[i]))
                {
                    vowelsArray.Add(inputSentence[i]);
                }
            }

            vowelsArray.Sort();

            foreach (char vowel in vowelsArray)
            {
                Console.Write(vowel + " ");
            }

        }

    }
}
