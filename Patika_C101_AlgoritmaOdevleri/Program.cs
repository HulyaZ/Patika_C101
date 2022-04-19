// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
// Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
// Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
using System;

namespace algoritmaOdevleri
{
    class Program
    {
        public static void Main()
        {
            MenuOptions();
            Console.WriteLine();
            MainMenu();
        }
      
        public static void MainMenu()
        {            
            int selection = InputValidation();

            switch (selection)
            {
                case 1:
                    EvenNumbers();
                    break;
                case 2:
                    Divisibility();
                    break;
                case 3:
                    ArrangeInReverse();
                    break;
                case 4:
                    FindCount();
                    break;

                default:
                    Console.WriteLine("Lütfen geçerli bir giriş yapınız:");
                    Console.WriteLine();
                    MainMenu();
                    break;
            }            
        }

        public static void MenuOptions()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemin numarasını yazınız:");
            Console.WriteLine();
            Console.WriteLine("1_ İşlem yapmak istediğiniz sayılardan çift olanları bulmak.");
            Console.WriteLine("2_ İşlem yapmak istediğiniz sayıların, m sayısına bölünebilenlerini bulmak.");
            Console.WriteLine("3_ Kelimeleri tersten sıralamak.");
            Console.WriteLine("4_ Yazılan bir cümledeki kelime ve harf sayısını bulmak");
        }
        public static void EvenNumbers()
        {        
            Console.WriteLine();
            Console.WriteLine("Lütfen işlem yapmak istediğiniz sayı adedini giriniz:");
            
            int numAmount = InputValidation();
            int[] arrNums = new int[numAmount];

            Console.WriteLine("Lütfen işlem yapmak istediğiniz sayıları giriniz:");
            for (int i = 0; i < numAmount; i++)
            {
                arrNums[i] = InputValidation();
            }

            Console.WriteLine();
            Console.WriteLine("Girdiğiniz sayılar");

            foreach (int num in arrNums)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Girdiğiniz sayılardan çift sayı olanlar:");

            for (int i = 0; i < arrNums.Length; i++)
            {
                if (arrNums[i] % 2 == 0)
                {                    
                    Console.Write(arrNums[i] + " ");
                }
            }

            ReturnToMainMenu();
        }

        public static void Divisibility()
        {
           
            Console.WriteLine();
            Console.WriteLine("Lütfen bölme işlemi için ilki bölünen ve ikincisi bölen olmak üzere iki pozitif tam sayı giriniz:");

            int divAmount = InputValidation();
            int divider = InputValidation();

            int[] dividingNums = new int[divAmount];

            Console.WriteLine("Lütfen bölme işlemi yapmak istediğiniz tam sayıları giriniz:");
            for (int i = 0; i < divAmount; i++)
            {
                dividingNums[i] = InputValidation();
            }

            Console.WriteLine();
            Console.WriteLine("Girdiğiniz sayılar:");

            foreach (int num in dividingNums)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Girdiğiniz sayılardan " + divider + " ile bölünebilenler:" );
            
            foreach (int num in dividingNums)
            {
                if(num %divider == 0 || num == divider)
                {
                    Console.Write(num + " ");
                }
            }

            ReturnToMainMenu();
        }

        public static void ArrangeInReverse()
        {
            Console.WriteLine();
            Console.WriteLine("Lütfen gireceğiniz kelime adedini giriniz: ");

            int wordCount = InputValidation();

            Console.WriteLine("Lütfen sıralamak istediğiniz kelimeleri giriniz: ");
            string[] inputWords = new string[wordCount];

            for (int i = 0; i < wordCount; i++)
            {
                inputWords[i] = Console.ReadLine().Replace(" ", "");
            }

            foreach (string sent in inputWords.Reverse())
            {
                Console.Write(sent + " ");              
            }

            ReturnToMainMenu();
        }

        public static void FindCount()
        {
            Console.WriteLine("Lütfen bir cümle giriniz: ");
            string inputSent = Console.ReadLine();

           
            char[] delimiters = new char[] { '+', ',', ';', '*', '-', '.', '_', ' ' };
            string[] inputWords = inputSent.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
           
            if (inputWords.Length == 0)
            {
                FindCount();
            }

            int wordCount = 0;
            foreach (string s in inputWords)
            {
                wordCount++;
            }
            Console.WriteLine();
            Console.WriteLine("Girdiğiniz cümledeki kelime sayısı: " + wordCount);
            Console.WriteLine();

            int charCount = 0;
            foreach (string c in inputWords)
            {
                for (int i = 0; i < c.Length; i++)
                {
                    charCount++;
                }
            }
            Console.WriteLine("Girdiğiniz cümledeki harf sayısı: " + charCount);

            ReturnToMainMenu();
        }

        public static int InputValidation()
        {
            string userInput = Console.ReadLine();           
            try
            {
               int input = Convert.ToInt32(userInput);   
               return input;             
            }
            catch
            {
                Console.WriteLine("Lütfen geçerli bir giriş yapınız:");
                Console.WriteLine();
                return InputValidation();
            }
        }


        public static void ReturnToMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("İşlem tamamlanmıştır.");
            Console.WriteLine("Ana menuye dönmek için Enter tuşuna basınız.");
            Console.WriteLine("Uygulamadan çıkmak için ESC'e basınız.");
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.Enter)
            {
                Main();
            }
        } 
    }
}