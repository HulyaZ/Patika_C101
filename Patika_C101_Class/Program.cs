using System;
using System.Collections.Generic;
using System.IO;


namespace classes
{
    #region Sınıf Nedir? Inst, Field, Prop / Erişim Belirleyiciler
    /*class Program
   {   
    static void Main(string[] args)
       {
           //class ClassName
           //{
           //    [erişim belirleyic] [veri tipi] OzellikAdı
           //    [erişim belirleyic] [geri dönüşüm tipi] metotAdı([Parametre Listesi])
           //    {
           //        //Metot Komutları
           //    }
           //}

           //Erişim Belirleyiciler
           //    Public      Private     Internal    Protected



           Employees employee1 = new Employees();
           employee1.Name = "John";
           employee1.Surname = "Doe";
           employee1.Number = 00001;
           employee1.Department = "HR";
           employee1.EmployeeInfo();

           Employees employee2 = new Employees();
           employee2.Name = "James";
           employee2.Surname = "Back";
           employee2.Number = 00002;
           employee2.Department = "Design";
           employee2.EmployeeInfo();

           Employees employee3 = new Employees("Ayse", "Kara", 00003, "Architecture");
           employee3.EmployeeInfo();


           Employees employee4 = new Employees("Fatma", "Bara");
           employee4.EmployeeInfo();
       }
   }

   class Employees
   {
       public string Name;
       public string Surname;
       public int Number;
       public string Department;

       public Employees(string name, string surname, int number, string department)
       {
           this.Name = name;
           this.Surname = surname;
           this.Number = number; 
           this.Department = department;
       }

       public Employees(string name, string surname)
       {
           this.Name = name;
           this.Surname = surname;    
       }

       public Employees()
       {

       }

       public void EmployeeInfo()
       {
           Console.WriteLine("Çalışan Adı: {0}", Name);
           Console.WriteLine("Çalışan Adı: {0}", Surname);
           Console.WriteLine("Çalışan Adı: {0}", Number);
           Console.WriteLine("Çalışan Adı: {0}", Department);
       }   
       }   
   */
    #endregion

    #region Encapsulation
    /*
    class Student
    {
        private string name;
        private string surname;
        private int stdNo;
        private int stdclass;

        public string Name { get => name; set => name = value; }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public int Stdclass
        {
            get => stdclass;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir.");
                    stdclass = 1;
                }
                else 
                    stdclass = value;
            }
        }

        public int StdNo { get => stdNo; set => stdNo = value; }

        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "John";
            student1.Surname = "Doe";
            student1.StdNo = 293;
            student1.Stdclass = 3;
            student1.printStudentInfo();

            student1.ClassUpgrade();
            student1.printStudentInfo();

            Student student2 = new Student("Johnny", "Dow", 292,1 );         
            student2.printStudentInfo();

            student2.ClassDowngrade();
            student2.printStudentInfo();
        }

        public Student(string name, string surname, int stdNo, int stdclass)
        {
            Name = name;
            Surname = surname;
            Stdclass = stdclass;
            StdNo = stdNo;
        }

        public Student() { }

        public void printStudentInfo()
        {
            Console.WriteLine("Student name:{0} ", this.Name);
            Console.WriteLine("Student surname:{0} ", this.Surname);
            Console.WriteLine("Student number:{0} ", this.StdNo);
            Console.WriteLine("Student class:{0} ", this.Stdclass);
        }

        public void ClassUpgrade()
        {
            this.Stdclass = this.Stdclass + 1;
        }

        public void ClassDowngrade()
        {
            this.Stdclass = this.Stdclass - 1;
        } 
    }
      */
    #endregion

    #region static sınıf ve uyeler
    /*
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calışan sayısı: {0}", Employee.EmployeeCount);

            Employee employee = new Employee("Ayse", "Yılmaz", "IK");

            Employee employee1 = new Employee("Deniz", "Arda", "IK");
            Employee employee2 = new Employee("Zikriye", "Urkmez", "IK");

            Console.WriteLine("Calışan sayısı: {0}", Employee.EmployeeCount);

            Console.WriteLine("Toplama işleminin sonucu: {0}", Operations.Sum(100,200));
            Console.WriteLine("Toplama işleminin sonucu: {0}", Operations.Subtraction(400, 200));
        }

    }

    class Employee
    {
        private static int employeeCount;

        public static int EmployeeCount { get => employeeCount;}

        private string Name;
        private string Surname;
        private string Department;

        static Employee()
        {
            employeeCount = 0;
        }

        public Employee(string name, string surname, string department)
        {
            this.Name = name;
            this.Surname = surname;
            this.Department = department;
            employeeCount++;
        }
    }

    static class Operations
    {
        public static long Sum (int num1, int num2)
        {
            return num1 + num2;
        }
        public static long Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }    
    }
    */
    #endregion

    #region Struct
    /*
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.ShortEdge = 3;
            rect.LongEdge = 4;
            Console.WriteLine("Class alan hesabı: {0}", rect.AreaCalc());
            
            //Rectangle_Struc rectangle_Struc = new Rectangle_Struc();
            Rectangle_Struc rectangle_Struc;
            rectangle_Struc.ShortEdge = 3;
            rectangle_Struc.LongEdge = 4;
            Console.WriteLine("Struct alan hesabı: {0}", rectangle_Struc.AreaCalc());

            Rectangle_Struc rectangle_Struc2 = new Rectangle_Struc(4, 5);
            Console.WriteLine("Struct alan hesabı: {0}", rectangle_Struc2.AreaCalc());
        }
    }

    class Rectangle
    {
        public int ShortEdge;
        public int LongEdge;

        public long AreaCalc()
        {
            return this.ShortEdge * this.LongEdge;
        }
    }

    struct Rectangle_Struc
    {
        public int ShortEdge;
        public int LongEdge;

        public Rectangle_Struc(int shortEdge, int longEdge)
        {
            ShortEdge = shortEdge;
            LongEdge = longEdge;    
        }
        public long AreaCalc()
        {
            return this.ShortEdge * this.LongEdge;
        }
    }
    */
    #endregion

    #region Enum
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Thursday);
            Console.WriteLine((int)Days.Thursday);
            Console.WriteLine((int)Days.Saturday);

            int temp = 32;
            
            if(temp <= (int)WeatherTemps.Cold)
            {
                Console.WriteLine("Hava dışarı çıkmak için henüz çok soğuk");
            }
            else if (temp >= (int)WeatherTemps.Hot)
            {
                Console.WriteLine("Hava dışarı çıkmak için çok sıcak");
            }
            else if (temp == (int)WeatherTemps.Normal)
            {
                Console.WriteLine("Hava dışarı çıkmak için ideal");
            }

        }

        enum Days
        {
            Monday, // to change index => Monday =1;
            Tuesday,
            Wednesday,
            Thursday,
            Friday = 23,
            Saturday,
            Sunday,
        }

        enum WeatherTemps
        {
          Cold = 5,
          Normal = 25,
          Hot = 30,
        }
    }


    #endregion

}


