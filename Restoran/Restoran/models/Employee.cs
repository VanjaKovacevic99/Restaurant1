using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Restoran.models
{
    class Employee
    {
        public int Id { get; set; }
        public string JMB { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public DateTime DateOfBirth { get; set; }

        public DateTime DateOfEmployment { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string Type { get; set; }
        public string Address { get; set; }
        public string BanckAccaunt { get; set; }
        public decimal Pay { get; set; }
        public string Phone { get; set; }

        
       

        public override bool Equals(object obj)
        {
            return obj is Employee employed && JMB == employed.JMB;
        }

        public override int GetHashCode()
        {
            return -1255590651 + JMB.GetHashCode();
        }

        public override string ToString()
        {
            return Surename + ", " + Name;
        }
    }
}
