using System;
using System.Collections.Generic;
using System.Text;
using Sedc.OOP.Class7.Enumerations.App.Enums;
namespace Sedc.OOP.Class7.Enumerations.App.Models
{
    public class Administrator
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Roles Role { get; set; } //mu davash status spored status number prevzemen od Enums

        public Administrator(string name)
        {
            Id = 1;
            Name = name;
            Role = Roles.Admin;
        }
    }
}
