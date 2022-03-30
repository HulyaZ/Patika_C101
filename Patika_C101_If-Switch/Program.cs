using System;

namespace conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            // If

            int time = DateTime.Now.Hour;

            if (time > 6 && time < 11)
            {
                Console.WriteLine("Günaydın!");
            }
            else if (time <= 18)
            {
                Console.WriteLine("Iyi günler!");
            }
            else
            {
                Console.WriteLine("Iyi geceler!");
            }

            string result = time < 18 ? "Second Statement" : "Last Statement";
            result = time >= 6 && time < 11 ? "First Statement" : time < 18 ? "Second Statement" : "Last Statement";
            Console.WriteLine(result);

            // Switch

            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                default:
                    Console.WriteLine("Non-existing");
                    break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter season");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring season");
                    break;
                default :
                    break;  

            }
        }
    }
}