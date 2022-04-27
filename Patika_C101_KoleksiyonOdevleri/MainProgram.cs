using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_C101_KoleksiyonOdevleri
{
    public class MainProgram
    {
        public static void Main()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemin numarasını giriniz:");
            Console.WriteLine("1. Asal sayıları bulmak.");
            Console.WriteLine("2. Dizideki en büyük ve en küçük 3 sayının ortalamasını bulup toplamak.");
            Console.WriteLine("3. Girilen bir cümledeki sesli harfleri diziye aktarmak.");
            Console.WriteLine();
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (userInput)
            {
                case 1:
                    ProgramPrimeNumbers.PrimeNumber();
                    break;
                case 2:
                    MeanOfThree.Mean();
                    break;
                case 3:
                    SentenceVowels.Vowels();
                    break;
                default:                 
                    Console.WriteLine();
                    Main();
                    break;
            }
         
        }
    }
}
