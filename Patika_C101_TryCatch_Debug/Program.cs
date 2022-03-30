using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
             /*
            try
            { 
                Console.WriteLine("Please insert a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("number = " + num);
            }            
           
            catch(Exception ex) //when error occurs
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }
            
           
            finally // regardless of condition
            {
                Console.WriteLine("Completed.");

            }
            */

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-123456789123456789");

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("null value: ");
                Console.WriteLine(ex);
            }

            catch (FormatException ex)
            {
                Console.WriteLine("invalid type: ");
                Console.WriteLine(ex);
            }

            catch (OverflowException ex)
            {
                Console.WriteLine("out of bounds: ");
                Console.WriteLine(ex);
            }

        }
        }

}