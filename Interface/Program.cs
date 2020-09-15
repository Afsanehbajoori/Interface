using Interface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Model
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IPerson> people = new List<IPerson>();

            Teacher t1 = new Teacher();
            t1.Name = "John";
            t1.Age = 45;
            t1.Experience = 12;
            t1.Role = "Teacher";

            Teacher t2 = new Teacher();
            t2.Name = "Allan";
            t2.Age = 35;
            t2.Experience = 8;
            t2.Role = "Teacher";

            Student s1 = new Student();
            s1.Name = "David";
            s1.Age = 20;
            s1.Role = "Student";
            s1.Field = "math";


            Student s2 = new Student();
            s2.Name = "Adrian";
            s2.Age = 21;
            s2.Role = "Student";
            s2.Field = "programming";

            people.Add(t1);
            people.Add(t2);
            people.Add(s1);
            people.Add(s2);


            Course m1 = new Course();
            m1.Name = "math";
            m1.Credit = 3;
            m1.Teacher = t1;
            m1.StudentCount = 0;


            Course m2 = new Course();
            m2.Name = "programming";
            m2.Credit = 5;
            m2.Teacher = t2;
            m2.StudentCount = 0;

           
            Console.WriteLine($"My name is {t1.Name }, I am a {t1.Role} and has a salary :{t1.GetSalary()}");
            Console.WriteLine($"My name is {t2.Name }, I am a {t2.Role} and  has a salary :{t2.GetSalary()}");

            if (s1.AskForCourse(m1))
            {
                m1.AddStudent(s1);
                Console.WriteLine($"{s1.Name} is added successful in the {m1.Name} course.");
            }

            if (s2.AskForCourse(m2))
            {
                m2.AddStudent(s2);
                Console.WriteLine($"{s2.Name} is added successful in the {m2.Name} course.");
            }

            foreach (var item in people)
            {
                item.PrintRole();
                
                
            }

            Console.ReadKey();
        }

        
        
    }
}
