using System;

namespace arrays
{
    class Program
    {
        static void Main (string[] args)
        {
            /*
            string[] colors = new string[5];
            colors[0] = "Blue";


            int[] arr;
            arr = new int[5];
            arr[3] = 10;
            
            Console.WriteLine(colors[0]);
            Console.WriteLine(arr[3]);
            

            Console.WriteLine("Dizinin eleman sayısı?");
            int arrLength = int.Parse(Console.ReadLine());
            int[] arrNum = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.Write("Lütfen {0} sayıyı giriniz: ", i+1);
                arrNum[i] = int.Parse(Console.ReadLine());  
            }

            int sum = 0;
            foreach (int i in arrNum)
            {
                sum += i;
            }

            Console.WriteLine("Dizinin elemanlarının ortalaması: " + (sum/arrLength));

            */

            int[] arrNums = { 23, 12, 4, 86, 72, 3, 11, 17 };

           
            //Sort
            Array.Sort(arrNums);
            foreach (int num in arrNums)
            {
                Console.WriteLine(num);
            }
                     
 
            //Reverse
            Array.Reverse(arrNums);
            foreach (int num in arrNums)
            {
                Console.WriteLine(num);
            }
         
            //Index Of
            Console.WriteLine(Array.IndexOf(arrNums, 23));

            //Resize
            Array.Resize<int>(ref arrNums, 9);
            arrNums[8] = 99;
            foreach (int num in arrNums)
            {
                Console.WriteLine(num);
            }

            //Clear
            Array.Clear(arrNums, 2, 1); // resets one element starting from the nth to 0  
            foreach (int num in arrNums)
            {
                Console.WriteLine(num);
            }
        
        }

    }
         

}