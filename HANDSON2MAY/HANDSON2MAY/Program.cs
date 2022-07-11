using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANDSON2MAY
{
    internal class Program
    {
        class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }

            public static List<Student> GetStudents()
            {
                List<Student> studlist = new List<Student>();
                Student a1 = new Student { ID = 101, Name = "Anjali", Email = "anjali@gmail.com" };
                Student a2 = new Student { ID = 102, Name = "Aarati", Email = "aarati@outlook.com" };
                Student a3 = new Student { ID = 103, Name = "Ramya", Email = "ramya@gmail.com" };
                Student a4 = new Student { ID = 104, Name = "RaviShankar", Email = "ravi@hotmail.com" };
                studlist.Add(a1);
                studlist.Add(a2);
                studlist.Add(a3);
                studlist.Add(a4);
                //  studlist.Add(new Student { ID = 105, Name = "Roshan", Email = "roshan@gmail.com" });
                return studlist;
            }
        }
        class QueryExpressions
        {
            static void Main()
            {
                int[] intval = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //array 

                //query expressions to find all odd nos from the array
                IEnumerable<int> Oddvalues = from val in intval
                                             where (val % 3) != 0
                                             select val;

                //query expressions to find all even nos from the array
                var evennos = from e in intval
                              where (e % 3) == 0
                              select e;

                //IQueryable<int> queryoutput = (IQueryable<int>)(from n in intval
                //                              where (n % 3) == 0
                //                              select n);

                //iterate the fetched results of odd nos.
                foreach (int v in Oddvalues)
                {
                    Console.WriteLine(v);
                }
                Console.WriteLine("-----------");
                //iterate the fetched results of even nos.
                foreach (var v in evennos)
                {
                    Console.WriteLine(v);
                }
                //Console.WriteLine("----------");
                ////iterate the fetched results of nos. divisible by 3
                //foreach (int v in queryoutput)
                //{
                //    Console.WriteLine(v);
                //}

                //working with list objects in query expressions
                //query the list collection and find out all students whose names start with S/R

                IEnumerable<string> studnames = from stud in Student.GetStudents()
                                                where stud.Name.Contains("A")
                                                select stud.Name;

                IEnumerable<Student> st = from a  in Student.GetStudents()
                                          where a.ID == 104
                                          select a;

                foreach (var v in studnames)
                {
                    Console.WriteLine(v);
                }

                foreach (Student a in st)
                {
                    Console.WriteLine($"The Id :{a.ID}, Name : {a.Name} and Email :{a.Email}");
                }
                Console.Read();
            }
        }
    }
}