using System;
using System.Collections.Generic;
using System.IO;


namespace classes
{
    #region Sınıf Nedir? Inst, Field, Prop / Erişim Belirleyiciler

    class Program
    {
        /*
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
    
    */

        #endregion

        #region Encapsulation



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



            #endregion

        }
    }
}


