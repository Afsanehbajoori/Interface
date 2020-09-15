using Interface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Model
{
    public class Student : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Field { get; set; }
        public string Role { get ; set ; }

        public bool AskForCourse(Course course)
        {
            if (course.StudentCount<100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintRole()
        {
            Console.WriteLine($"I am a {Role}") ;
            
        }
    }
}
