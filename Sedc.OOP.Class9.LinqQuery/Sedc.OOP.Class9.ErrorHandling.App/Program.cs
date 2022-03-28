using System;
using System.Linq;
using Sedc.OOP.Class9.ErrorHandling.App.Models;
using Sedc.OOP.Class9.ErrorHandling.App.Services;
namespace Sedc.OOP.Class9.ErrorHandling.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("numberexample");
            Console.WriteLine("Enter a number: ");

            try
            {
                string str = Console.ReadLine();
                int number = int.Parse(str);
                Console.WriteLine(number);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("we are in a format exception");
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("we are in a Argument null exception");
                Console.WriteLine( ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //finally
            //{
            //    Console.WriteLine("I will always be executed");
            //}
            Console.WriteLine("write a or b");
            try
            {
                string input2 = Console.ReadLine();
                if (input2 == "a" || input2 == "b")
                {
                    Console.WriteLine("Congratulations you entered a or b");
                }
                else
                    throw new Exception("That is not a or b! sorry!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException.Message);
            }


            HumanServiceMainMethod();
            Console.ReadLine();

        }
        public static void HumanServiceMainMethod()
        {
            HumanServices service = new HumanServices();

            foreach(Human human in service.Humans)
            {
                try
                {
                    service.PrintHUmanSkills(human);
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }
        public Skill GetFirstHumanSkill(Human human)
        {
            try
            {
               return human.SkillList.First();
            }
            catch(InvalidOperationException)
            {
                throw new Exception("There is no skills in this human");
            }
            catch (Exception)
            {
                throw new Exception("Something wrong has happened. Dont panic!");
            }
        }
    }
}
