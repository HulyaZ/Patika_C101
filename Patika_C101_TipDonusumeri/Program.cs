using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main (string[] args)
        {
            // Implicit Conversion
            Console.WriteLine("____Implicit Conversion____" + Environment.NewLine);

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;

            Console.WriteLine("d = " + d);
     
            long e = d;
            Console.WriteLine("e= " + e);

            float f = e; 
            Console.WriteLine("f= " + f);

            string g = "name";
            char h = 'k';
            object i = g + h + d;
            Console.WriteLine("i= " + i);


            //Explicit Conversion

            Console.WriteLine("____Explicit Conversion____" + Environment.NewLine);


            int j = 4;
            byte k = (byte)j;

            Console.WriteLine("int j = " + j);
            Console.WriteLine("byte k= " + k);

            float l = 10.3f; 
            byte m = (byte)l;
            Console.WriteLine("byte m= " + m);

            // ToString
            int n = 6;
            string nn = n.ToString();
            Console.WriteLine("string nn= " + nn);

            string nnn = 12.5f.ToString();
            Console.WriteLine("string nnn= " + nnn);

            //System.Convert
            string o = "10", oo = "28";
            int num01, num02;
            int sum;

            num01 = Convert.ToInt32(o);
            num02 = Convert.ToInt32(oo);
            sum = num01 + num02;
            Console.WriteLine("sum = " + sum);

            //Parse 
            ParseMethod();           

        }

        public static void ParseMethod()
        {
            string text = "10", text0= "10.25";
            int num03;
            double double01;

            int ii = 9;
            long something = ii;
            something += something;
            Console.WriteLine("something = " + something);

            num03 = Int32.Parse(text);
            double01 = Double.Parse(text0);
            Console.WriteLine(text + " + " + text0 + "= " + (num03 + double01));
        }
    }
}