﻿using System;
using System.Collections;
using System.Text;
using RoadBook.CsharpBasic.Chapter06.Examples.Model;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex008
    {
        public void Run()
        {
            ArrayList arrStudent = new ArrayList();

            Student student = new Student();
            student.Id = "S001";
            student.Name = "홍길동";
            student.Department = "컴퓨터공학과";
            student.Grade = 1;
            student.Age = 21;

            arrStudent.Add(student);

            for (int idx = 0; idx < arrStudent.Count; idx++)
            {
                Console.WriteLine(((Student)arrStudent[idx]).Id);
                Console.WriteLine(((Student)arrStudent[idx]).Name);
                Console.WriteLine(((Student)arrStudent[idx]).Department);
                Console.WriteLine(((Student)arrStudent[idx]).Grade);
                Console.WriteLine(((Student)arrStudent[idx]).Age);
            }
        }
    }
}
