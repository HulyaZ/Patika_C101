using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{

    #region Generic List
    /* 
    class Program
    {
       
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();
            numList.Add(23);
            numList.Add(10); 
            numList.Add(4); 
            numList.Add(5);
            numList.Add(92);
            numList.Add(34);
            
            List<string> colorList = new List<string>();
            colorList.Add("Red");
            colorList.Add("Blue");
            colorList.Add("Orange");
            colorList.Add("Yellow");
            colorList.Add("Green");

            //Count

            Console.WriteLine(colorList.Count);
            Console.WriteLine(numList.Count);

           // foreach (int i in numList)
               // Console.WriteLine(i);
            numList.ForEach(i => Console.WriteLine(i));

            //foreach (string t in colorList)
            // Console.WriteLine(t);   
            colorList.ForEach(i => Console.WriteLine(i));

            // Listeden çıkarma
            numList.Remove(92);
            numList.RemoveAt(4);

            // Liste içerisinde arama
            if(numList.Contains (23))
                Console.WriteLine("The list contains num 23.");

            // Eleman ile indexe erişme
            Console.WriteLine(colorList.BinarySearch("Yellow"));
            Console.WriteLine(colorList.BinarySearch("Purple"));

            // Diziyi listeye çevirme
            string[] animals = { "dog", "cat", "cow", "bird" };
            List<string> animalsList = new List<string>(animals);
            //animalsList.ForEach(i => Console.WriteLine(i));

            animalsList.Clear();
            List<Users> usersList = new List<Users>();
            Users user1 = new Users();
            user1.Name = "John";
            user1.Surname = "Doe";
            user1.Age = 26;

            Users user2 = new Users();
            user2.Name = "James";
            user2.Surname = "Black";
            user2.Age = 22;

            usersList.Add(user1);
            usersList.Add(user2);
   
            List<Users> usersList2 = new List<Users>();
            usersList2.Add(new Users()
            {
                Name = "Deniz",
                Surname = "Arda",
                Age = 24,
            });

            foreach (Users user in usersList)
            {
                Console.WriteLine("User Name: " + user.Name);
                Console.WriteLine("User Surname: " + user.Surname);
                Console.WriteLine("User Age: " + user.Age);
            }
              
        }
    }

    public class Users
    {
        string name;
        string surname;
        int age;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
    }
      */
    #endregion

    #region ArrayList
    /*
    class Program
    {
        static void Main(string[] args)
        { 
            ArrayList list = new ArrayList();

            list.Add("Sean");
            list.Add(2);
            list.Add(true);
            list.Add('A');

            //Console.WriteLine(list[1]);

            foreach (var i in list)
                Console.WriteLine(i);

            //AddRange
            Console.WriteLine("***Add Range***");
            string[] colors = { "red", "green", "yellow" };
            List<int> nums = new List<int>() { 1,2,3,7,92,5};
            list.AddRange(nums);
            list.AddRange(colors);

            ArrayList list2 = new ArrayList();
            List<int> nums2 = new List<int>() { 1, 2, 45, 7, 92, 5 };
            list2.AddRange(nums2);

            //Sort
            list2.Sort();
            foreach (var i in list2)
                Console.WriteLine(i);

            //Binary Search
            Console.WriteLine();
            Console.WriteLine(list2.BinarySearch(7));

            //Reverse
            list2.Reverse();
            foreach (var i in list2)
                Console.WriteLine(i);

            //Clear
            list2.Clear();

        }
    }
    */
    #endregion

    #region Dictionary
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> usersD = new Dictionary<int, string>();

            usersD.Add(10, "Ayse Yılmaz");
            usersD.Add(12, "Ahmet Yılmaz");
            usersD.Add(28, "Deniz Arda");
            usersD.Add(20, "Ozcan Cosar");

            Console.WriteLine(usersD[12]);

            foreach (var user in usersD)    
                Console.WriteLine(user);

            //Count
            Console.WriteLine(usersD.Count);

            //Contains
            Console.WriteLine(usersD.ContainsKey(12));
            Console.WriteLine(usersD.ContainsValue("Mehmet Urkmez"));

            //Remove 
            usersD.Remove(12);
            foreach (var user in usersD)
                Console.WriteLine(user.Value);

            foreach (var user in usersD.Keys)
                Console.WriteLine(user);

            foreach (var user in usersD.Values)
                Console.WriteLine(user);


        }
    }

    #endregion

}
