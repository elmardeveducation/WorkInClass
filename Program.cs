using System;

namespace ClassInheritance
{
    
        class Person
        {
            private string name;
            private string lastName;
            private int age;
            private bool gender;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }
            public int Age
            {
                get { return age; }
                set
                {
                    if (value > 0)
                    {
                        age = value;
                    }
                }
            }
            public bool Gender
            {
                get { return gender; }
                set { gender = value; }
            }

            public Person(string name, string lastName, int age, bool gender)
            {
                Name = name;
                LastName = lastName;
                Age = age;
                Gender = gender;
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Name - { Name }\nLastname - { LastName }\nAge - { Age }\nGender - { Gender }");
            }
        }
        class Client : Person
        {
            public string diagnoz;
            public bool insurance;

            public Client(string diagnoz, bool insurance, string name, string lastName, int age, bool gender)
                : base(name, lastName, age, gender)
            {
                this.diagnoz = diagnoz;
                this.insurance = insurance;
            }

            public sealed override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Diagnoz - { diagnoz }\nInsurance - { insurance }");
            }
        }
        class Staff : Client
        {
            public string department;
            public string spec;

            public Staff(string department, string spec, string diagnoz, bool insurance, string name, string lastName, int age, bool gender)
                : base(diagnoz, insurance, name, lastName, age, gender)
            {
                this.department = department;
                this.spec = spec;
            }

            public new void DisplayInfo()
            {
                Console.WriteLine($"Department - { department }\nSpecialization - { spec }");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("hello Ali");
                Staff drAli = new Staff("Cerrahiye", "Gulax Cerrahi", "Qulaqda problem", true, "Ali", "Capayev", 101, true);
                drAli.DisplayInfo();
                Client xeste = (Client)drAli;
                xeste.DisplayInfo();
                Console.WriteLine("\n\n\n\n\n");
                Person mauqli = new Staff("1", "2", "problem", true, "Fas", "Saf", 202, true);
                mauqli.DisplayInfo();
                Console.WriteLine("\n\n\n\n");
                Staff mauqli2 = (Staff)mauqli;
                mauqli2.DisplayInfo();
                Console.ReadKey();
            }
        }
    }


