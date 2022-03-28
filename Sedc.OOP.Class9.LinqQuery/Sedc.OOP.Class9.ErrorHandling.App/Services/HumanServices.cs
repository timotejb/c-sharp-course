using Sedc.OOP.Class9.ErrorHandling.App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.OOP.Class9.ErrorHandling.App.Services
{
    public class HumanServices
    {
        public List<Human> Humans { get; set; }

        public HumanServices()
        {
            List<Human> Humans = new List<Human>()
            {
                new Human() { Name = "Timotej"},
                new Human() { Name = "Timotej2", SkillList = new List<Skill> { new Skill() {Points = 5,Name = "Skill.1" } } }
            };
        
        }

        public void PrintHUmanSkills(Human Human)
        {
            try
            {
                foreach(Skill skill in Human.SkillList)
                {
                    Console.WriteLine(skill.Name);
                }
            }
            catch(NullReferenceException ex)
            {
                throw ex;
            }
        }
    }
}
