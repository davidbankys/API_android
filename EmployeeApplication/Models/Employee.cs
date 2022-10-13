using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
namespace EmployeeApplication.Models
{
    public class Employee
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Image { get; set; }

        public Employee(string name, string email, string image)
        {
            Name = name;
            Email = email;
            Image = image;


        }

    }
}

