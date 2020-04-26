using System;
using System.Collections.Generic;
using System.Text;
using RoadBook.CsharpBasic.Chapter06.Examples.Model;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex009
    {
        public void Run()
        {
            List<Student> arrStudent = new List<Student>();

            Student student = new Student();
            student.Id = "S001";
            student.Name = "홍길동";
            student.Department = "컴퓨터공학과";
            student.Grade = 1;
            student.Age = 21;

            arrStudent.Add(student);

            for (int idx = 0; idx < arrStudent.Count; idx++)
            {
                Console.WriteLine(arrStudent[idx].Id);
                Console.WriteLine(arrStudent[idx].Name);
                Console.WriteLine(arrStudent[idx].Department);
                Console.WriteLine(arrStudent[idx].Grade);
                Console.WriteLine(arrStudent[idx].Age);
            }
        }
    }
}
