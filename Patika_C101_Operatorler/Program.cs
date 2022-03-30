using System;

namespace Operators
{    class Program
    {
        static void Main(string[] args)
        {

            int x = 3;
            int y = 3;

            y = y + 2;
            Console.WriteLine(y);

            y += 2;
            Console.WriteLine(y);

            y /= 1;
            Console.WriteLine(y);

            x++;
            Console.WriteLine(x + y);


            //Logic Operators
            // ||  && !

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted) // works for true - true
            {
                Console.WriteLine("Perfect!");
            }

            if (isSuccess || isCompleted) // works if either one is true
            {
                Console.WriteLine("Great!");
            }

            if (isSuccess && !isCompleted) // works for true - false
            {
                Console.WriteLine("Fine");
            }

            //Relational Operators
            // < > <= >= == !=

            int a = 3;
            int b = 4;
            bool result = a < b;
            Console.WriteLine("result for a < b " + result);
            result = a > b;
            Console.WriteLine("result for a > b " + result);
            result = a >= b;
            Console.WriteLine("result for a >= b " + result);
            result = a <= b;
            Console.WriteLine("result for a <= b " + result);
            result = a == b;
            Console.WriteLine("result for a == b " + result);
            result = a != b;
            Console.WriteLine("result for a != b " + result);


            //Arithmetic operators
            // + - * /

            int num01 = 10;
            int num02 = 5;

            int result01 = num01 + num02;
            Console.WriteLine(num01 + " + " + num02 + " = " + result01);

            result01 = num01 - num02;
            Console.WriteLine(num01 + " + " + num02 + " = " + result01);

            result01 = num01 / num02;
            Console.WriteLine(num01 + " + " + num02 + " = " + result01);

            result01 = num01 * num02;
            Console.WriteLine(num01 + " + " + num02 + " = " + result01);

            num01++;
            Console.WriteLine(num01);

            // Mod %
            int res02 = 20 % 3;
            Console.WriteLine(" 20(mod3) = " + res02);
        }
    }
}