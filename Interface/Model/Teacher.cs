using Interface.Interface;
using Interface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Model
{
    public class Teacher : IPerson
    {


        public string Name { get; set; }
        public int Age { get; set; }
        public Course Course { get; set; }
        public int Experience { get; set; }
        public string Role { get ; set; }

        public double GetSalary()
        {
            return SalaryInfo.SalaryBase + (Experience * SalaryInfo.ExprinceBonus);  // we can use class name and its varible becuse they are static
        }

        public void PrintRole()
        {
            Console.WriteLine($"I am a {Role}");
            Console.WriteLine($"My salary is {GetSalary()}");
        }
    }
}
