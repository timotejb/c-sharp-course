using System;
using Sedc.OOP.Class6.Excercises.App.NumberStats;
using Sedc.OOP.Class6.Excercises.App.Task2_StudentClasses;

namespace Sedc.OOP.Class6.Excercises.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student()
                {
                    Id = 1,
                    Username = "Timotej",
                    Password = "Timotej",
                    Messages = {}
                },

                new Student()
                {
                    Id = 2,
                    Username = "Trajan",
                    Password = "Trajan",
                    Messages = {}
                },

                new Student()
                {
                    Id = 3,
                    Username = "Igor",
                    Password = "Igor",
                    Messages = {}
                },

                new Student()
                {
                    Id = 4,
                    Username = "Kristijan",
                    Password = "Kristijan",
                    Messages = {}
                }
            };

            Console.WriteLine("Log in / Register");
            string input2 = Console.ReadLine();

            string username = string.Empty;
            string password = string.Empty;
            string id = string.Empty;
            if (input2 == "Log in")
            {
                Login login = new Login();
                login.LoginFunction(username, password);
                
                for (int i = 0; i <= students.Length-1; i++)
                {
                    foreach (Student student in students)
                    {
                        if (login.Username == students[i].Username && login.Password == students[i].Password)
                        {
                            Console.WriteLine($"Succesfull log in {login.Username}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Username or password is incorrect");
                            break;
                        }
                    }
                }
            }
            else if (input2 == "Register")
            {
                Register register = new Register();
                register.RegisterFunction();
                for( int i = 0; i<= students.Length-1; i++)
                {
                    foreach(Student student in students)
                    {
                        if (register.Username == students[i].Username)
                        {
                            Console.WriteLine("Username taken");
                            break;
                        }
                    }
                }
                 new Student()
                {
                    Id = register.Id,
                    Username = register.Username,
                    Password = register.Password
                };
            }

            //Console.WriteLine("Type in your number");
            //string input = Console.ReadLine();
            //int number = int.Parse(input);

            //NumberStats(number);
        }
  

        public static void NumberStats (int n)
        {
            Console.WriteLine($"Stats for number {n}");
            if(IsDecimal.isNumberDecimal(n))
            {
                Console.WriteLine("Number is decimal");
            }
            else
                Console.WriteLine("Number isn't decimal");
            if (IsOdd.IsNumberOdd(n))
            {
                Console.WriteLine("Number is odd");
            }
            else
                Console.WriteLine("Number is even");
            if (IsPositive.IsNumberPositive(n))
            {
                Console.WriteLine("Number is positive");
            }
            else
                Console.WriteLine("Number is negative");
        }
    }
}
