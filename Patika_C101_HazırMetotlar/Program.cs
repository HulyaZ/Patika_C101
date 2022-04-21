using System;

namespace hazir_metotlar
{
    class Program
    {
        #region String Methods
        /*
        static void Main(string[] args)
        {
            string sent = "Dersimiz CSharp, Hoşgeldiniz!";
            string sent3 = "dersimiz cSharp, hoşgeldiniz!";
            string sent2 = "Dersimiz";

            //Length;
            Console.WriteLine(sent.Length);

            //ToUpper ToLower
            Console.WriteLine(sent.ToLower());
            Console.WriteLine(sent.ToUpper());

            //Concat
            Console.WriteLine(String.Concat(sent2, " Merhaba!"));

            //Compare, CompareTo
            Console.WriteLine(sent.CompareTo(sent2));
            Console.WriteLine(String.Compare(sent, sent3, true));
            Console.WriteLine(String.Compare(sent, sent3, false));

            //Contains
            Console.WriteLine(sent.Contains(sent2));
            Console.WriteLine(sent.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(sent.StartsWith("Dersimiz"));

            //IndexOf
            Console.WriteLine(sent.IndexOf("CS"));
            Console.WriteLine(sent.IndexOf("Saat"));
            Console.WriteLine(sent.LastIndexOf("i"));

            //Insert
            Console.WriteLine(sent.Insert(0,"Merhaba! "));

            //Padding
            Console.WriteLine(sent + sent3.PadLeft(30));
            Console.WriteLine(sent + sent3.PadLeft(40, '*'));
            Console.WriteLine(sent.PadRight(50) + sent3);

            //Remove
            Console.WriteLine(sent.Remove(10));
            Console.WriteLine(sent.Remove(5,3));

            //Replace
            Console.WriteLine(sent.Replace("CSharp", "C#"));
            Console.WriteLine(sent.Replace(" ", "**"));

            //Split
            Console.WriteLine(sent.Split(' ')[1]);

            //Substring
            Console.WriteLine(sent.Substring(4));
            Console.WriteLine(sent.Substring(3,5));

        }
        */
        #endregion

        #region Date-Time Methods
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Year);
            
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));

            //Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));

            //Math
            Console.WriteLine(Math.Abs(-25));
            Console.WriteLine(Math.Sin(30));
            Console.WriteLine(Math.Cos(90));

            Console.WriteLine(Math.Ceiling(22.3));
            Console.WriteLine(Math.Round(22.3));
            Console.WriteLine(Math.Round(22.7));
            Console.WriteLine(Math.Floor(22.7));

            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));
            
            Console.WriteLine(Math.Pow(2,4));
            Console.WriteLine(Math.Sqrt(4));
            Console.WriteLine(Math.Log(9)); // 9'un e tabanındaki logaritmik karşılığı
            Console.WriteLine(Math.Exp(3)); // e üzeri 3
            Console.WriteLine(Math.Log10(10)); // 10 sayısının log 10 tabanındaki karşılığı


        }
        
        #endregion
    }

}