using System;
using System.Collections.Generic;
using System.Collections;


namespace Patika_C101_KoleksiyonOdevleri
{

    public class ProgramPrimeNumbers
    {
        public static void PrimeNumber()
        {
            ArrayList inputNums = new ArrayList();
            ArrayList primeNumsList = new ArrayList();
            ArrayList nonprimeNumsList = new ArrayList();


            int inputNum;
            int totalEntries = 5;
            int numberOfEntries = 0;
            bool prime = false;
            Console.WriteLine("Lütfen {0} tane pozitif tam sayı giriniz:", totalEntries);

            for (int i = 0; i < totalEntries; i++)
            {
                inputNum = InputValidation();
                inputNums.Add(inputNum);
            }

            inputNums.Sort();

            foreach (int i in inputNums)
            {
                if (i == 0 || i == 1)
                {
                    nonprimeNumsList.Add(i);
                }
                else
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            prime = false;
                            break;
                        }
                        else
                            prime = true;
                    }

                    if (prime)
                    {
                        primeNumsList.Add(i);
                    }
                    else if (!prime)
                    {
                        nonprimeNumsList.Add(i);
                    }
                }
            }

            PrintFormat("Asal sayılar listesi: ", primeNumsList);
            PrintFormat("Asal olmayan sayılar listesi: " , nonprimeNumsList);
               
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

        public static void MeanOfList(ArrayList name)
        {
            int mean = 0;
            int total = 0;
            foreach (int i in name)
            {
                total += i;
            }
            
            mean = total / name.Count;
            Console.WriteLine("Elemanların ortalaması " + mean);       
        }

        public static void PrintFormat(string str, ArrayList array)
            {
            Console.Write(str);
            PrintLists(array);
            Console.WriteLine();
            Console.WriteLine("Eleman sayısı: " + array.Count);
            MeanOfList(array);
            Console.WriteLine();
        }
    }


}
