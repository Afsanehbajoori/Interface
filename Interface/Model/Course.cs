using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Model
{
    public class Course : ICourse
    {
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public int Credit { get; set; }
        public int StudentCount { get; set; }

        public List<Student> students = new List<Student>();

        public void AddStudent(Student st) // first have to make a list, after that can we add student to the list
        {
            students.Add(st);
            StudentCount++;
        }


    }
}
