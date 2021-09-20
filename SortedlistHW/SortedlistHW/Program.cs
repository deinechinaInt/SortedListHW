using System;
using System.Collections.Generic;

namespace SortedlistHW
{
    class Program
    {
        static void Main(string[] args)
        {           
           // Initial list            
            var students = new List<Student>()
            {
                new Student { Age = 20, LastName = "Ivanov",  FirstName = "Ivan" },
                new Student { Age = 21, LastName = "Ivanov",  FirstName = "Petr" },
                new Student { Age = 20, LastName = "Petrov",  FirstName = "Ivan" },
                new Student { Age = 23, LastName = "Sidorov",  FirstName = "Oleg" },
                new Student { Age = 25, LastName = "Fedorov",  FirstName = "Oleg" }
            };

            Console.WriteLine("Unsorted list:");

            foreach (var student in students)
            {
                Console.WriteLine("{0} {1} Age: {2}", student.FirstName, student.LastName, student.Age);
            }

            // Sort by Age
            var sortedListByAge = new SortedList<Student, string>(new StudentComparerByAge());

            foreach ( var student in students)
            {
                sortedListByAge.Add(student, student.LastName);
            }
            Console.WriteLine();
            Console.WriteLine("By age:");
            PrintSortedList(sortedListByAge);


            // Sort by FirstName
            var sortedListByFirstName = new SortedList<Student, string>(new StudentComparerByFirstName());
            foreach (var student in students)
            {
                sortedListByFirstName.Add(student, student.LastName);
            }
            Console.WriteLine();
            Console.WriteLine("By first name:");
            PrintSortedList(sortedListByFirstName);

            // Sort by LastName
            var sortedListByLastName = new SortedList<Student, string>(new StudentComparerByLastName());
            foreach (var student in students)
            {
                sortedListByLastName.Add(student, student.LastName);
            }
            Console.WriteLine();
            Console.WriteLine("By last name:");
            PrintSortedList(sortedListByLastName);

           
            Console.ReadLine();                     
        }

        private static void PrintSortedList(SortedList<Student, string> students)
        {
            foreach (var sortedStudent in students)
            {
                Console.WriteLine("{0} {1} Age: {2}", sortedStudent.Key.FirstName, sortedStudent.Key.LastName, sortedStudent.Key.Age);
            }
        }
    }
}
