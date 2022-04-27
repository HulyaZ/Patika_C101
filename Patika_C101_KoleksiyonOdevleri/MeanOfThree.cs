using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Patika_C101_KoleksiyonOdevleri
{
    public class MeanOfThree
    {
        public static void Mean()
        {
            ArrayList inputNumsList = new ArrayList();
            ArrayList maxThreeList = new ArrayList();
            ArrayList minThreeList = new ArrayList();


            int inputNum;
            int totalEntries = 7;
            int numberOfEntries = 0;
            int numOfElements = 3; 
           
            Console.WriteLine("Lütfen {0} tane pozitif tam sayı giriniz:", totalEntries);

            for (int i = 0; i < totalEntries; i++)
            {
                inputNum = InputValidation();
                inputNumsList.Add(inputNum);
            }

            inputNumsList.Sort();
            
            for (int i = 0; i < 3; i++)
            {
                minThreeList.Add(inputNumsList[i]);
            }

            inputNumsList.Reverse();

            for (int i = 0; i < 3; i++)
            {
                maxThreeList.Add(inputNumsList[i]);
            }


            PrintFormat(("Dizideki en küçük " + numOfElements + " sayı: "), minThreeList);
            Console.WriteLine();

            PrintFormat(("Dizideki en büyük " + numOfElements + " sayı: "), maxThreeList);
            Console.WriteLine();

            int totalMean = MeanOfList(minThreeList) + MeanOfList(maxThreeList);
            Console.WriteLine("Ortalama toplamları= " + totalMean);    
 
        }

        public static int InputValidation()
        {
            string userInput = Console.ReadLine();
            try
            {
                int input = Convert.ToInt32(userInput);
                if (input! <= 0)
                {
                    Console.WriteLine("Girdiğiniz sayı 0'dan büyük olmalı.");
                    return InputValidation();
                }
                return input;
            }
            catch
            {
                Console.WriteLine("Lütfen geçerli bir giriş yapınız:");
                Console.WriteLine();
                return InputValidation();
            }
        }

        public static void PrintLists(ArrayList name)
        {
            foreach (int i in name)
            {
                Console.Write(i + " ");
            }
        }

        public static int MeanOfList(ArrayList name)
        {
            int mean = 0;
            int total = 0;
            foreach (int i in name)
            {
                total += i;
            }

            mean = total / name.Count;

            return mean;
        }

        public static void PrintFormat(string str, ArrayList array)
        {
            Console.Write(str);
            PrintLists(array);
            Console.WriteLine();
            Console.WriteLine("Elemanların ortalaması " + MeanOfList(array));
            Console.WriteLine();
        }
    }
}
