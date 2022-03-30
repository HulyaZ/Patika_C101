using System;

namespace methods

{
    class Program
    {
        #region // Methods
        /*

     static void Main(string[] args)
    {
            int a = 2;
            int b = 3;

            int res = Sum(a,b); 

            Methods example = new Methods();
            example.Print("Sum " + Convert.ToString(res));

            int res01 = example.IncAndSum(a,b);
            example.Print("IncAndSum " + Convert.ToString(res01));

        }

        static int Sum (int val, int val2)
        {
            return val + val2;
        }
    }

    class Methods
    {
       public void Print(string data)
        {
            Console.WriteLine(data);
        }

        public int IncAndSum (int val, int val2)
        {
            val += 1;
            val2 +=1;

            int sum = val + val2;

            return sum;
        }
    }
    */
        #endregion

        #region //Overloading
        /*
        static void Main2(string[] args)
        {
            string num = "999";
            int outNum;

            bool res = int.TryParse(num, out outNum);

            if (res)
            {
                Console.WriteLine(outNum);
            }
            else
            {
                Console.WriteLine("Task Failed");
            }

            Methods instance = new Methods();
            instance.Sum(4, 5, out int result);
            Console.WriteLine(result);

            int val = 999;
            instance.Print(Convert.ToString(val));
            instance.Print("Izmir", "Ankara");
            instance.Print(val);
        }
        class Methods
        {
            public void Sum(int a, int b, out int total)
            {
                total = a + b;
            }

            public void Print(string data)
            {
                Console.WriteLine(data);
            }
            public void Print(int data)
            {
                Console.WriteLine(data);
            }

            public void Print(string data, string data2)
            {
                Console.WriteLine(data + data2);
            }

        }
   
    */
        #endregion

        #region
        public static void Main(string[] args)
        {
            int result = 1;
       
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;

            }
            Console.WriteLine(result);

            //Operations instance = new();
            //Console.WriteLine(instance.Expo(3,4));

            string data = "Birds of a feather";

            bool res0 = data.CheckSpaces();
            Console.WriteLine(res0);
            Console.WriteLine(data.MakeUpperCase());

            int[] arr = { 1, 8, 3, 2, 5, 9, 7 };
            arr.SortArray();
        } 

      /*  public class Operations
        {
            public int Expo (int num, int power)
            {
                if(power <2)
                    return num;
                return Expo(num, power--)* num;
            }                      
        }*/
       
    }   
    public static class Extentions
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string MakeUpperCase (this string param)
        {
            return param.ToUpper();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
    }
} 



    #endregion
