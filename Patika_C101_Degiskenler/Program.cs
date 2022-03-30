using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            byte byte01 = 5;        // 01 Byte
            sbyte sbyte01 = 5;      // 01 Byte

            short short01 = 5;      // 01 Byte
            ushort ushort01 = 5;    // 01 Byte

            //Integers

            Int16 nt16 = 2;         // 02 Byte
            Int32 nt32 = 2;         // 04 Byte
            Int64 nt64 = 2;         // 08 Byte  
            int i = 2;              // 04 Byte

            uint uint01 = 2;         // 04 Byte
            long long01 = 4;         // 08 Byte
            ulong ulong01 = 4;       // 08 Byte


            //Real Nums
            float float01 = 5;        // 04 Byte
            double double01 = 5;      // 08 Byte
            decimal decimal01 = 5;    // 016 Byte


            //

            char char01 = 'H';
            string string01 = "Hello,";

            string name = "James";
            string surname = "Black";
            string fullName = name + " " + surname;

            object obj01 = null;

            bool bool01 = true;

            //Conversions

            string str02 = "20";
            int int02 = 20;

            string newValue = str02 + " " + int02.ToString();
            Console.WriteLine(newValue);

            int int03 = int02 + int.Parse(str02);

            //Time & Date Time

            DateTime dt = DateTime.Now;
            string datetime = DateTime.Now.ToString("dd,MM,yy");
            Console.WriteLine(datetime);

        }
    }
}

