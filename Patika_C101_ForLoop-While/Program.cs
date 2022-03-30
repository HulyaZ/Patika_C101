using System;

class Program
{
    static void Main (String[] args)
    {
        #region //For Loop

        /*
        Console.WriteLine("Please insert a number; ");
        int count = int.Parse(Console.ReadLine());

        for(int i = 1; i < count; i++)
        {
            if(i%2 == 1)
            {
                Console.WriteLine(i);
            }
        }

        int oddTotal = 0;
        int evenTotal = 0;

        for (int i = 1; i < 1000; i++)
        {
            if (i % 2 == 0)   
                evenTotal += i;
            else
                oddTotal += i;
        }
        Console.WriteLine("even total = " + evenTotal);
        Console.WriteLine("odd total = " + oddTotal);
       

        for (int i = 1; i < 10; i++)
        {
            if( i == 6)
            {
                break;
            }
            Console.WriteLine(i);
        }

        for (int i = 1; i < 10; i++)
        {
            if (i == 6)
            {
                continue;
            }
            Console.WriteLine(i);
        }
        */
        #endregion

        #region//While - Foreach

        int num = int.Parse(Console.ReadLine());
        int count = 1;
        int sum = 0;
        while ( count < num)
        {
            sum += count;
            count++;
        }
        Console.WriteLine(sum/num);


        char char0 = 'a';

        while (char0 < 'z')
        {
            Console.Write(char0);
            char0++;
        }


        string[] cars = { "BMW", "Ford", "Kia" };
        {
            foreach (string c in cars)
            {
                Console.Write(c + " ");
            }


        }
        #endregion

    }


}