using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RoadBook.CsharpBasic.Chapter09
{
    class Ex002
    {
        public void Run()
        {
            List<Model.Student> students = new List<Model.Student>()
            {
                new Model.Student {Id = "S001", Name = "Dexter", Grade = 3, Major = "Software"},
                new Model.Student {Id = "S002", Name = "Ellin", Grade = 3, Major = "Design"},
                new Model.Student {Id = "S003", Name = "Jeffrey", Grade = 4, Major = "Software"},
                new Model.Student {Id = "S004", Name = "Sienna", Grade = 4, Major = "Design"},
                new Model.Student {Id = "S005", Name = "Pil", Grade = 4, Major = "Software"},
                new Model.Student {Id = "S006", Name = "Clint", Grade = 3, Major = "Software"},
                new Model.Student {Id = "S007", Name = "Khan", Grade = 2, Major = "Software"},
                new Model.Student {Id = "S008", Name = "Mike", Grade = 2, Major = "Advertisement"},
                new Model.Student {Id = "S009", Name = "Sven", Grade = 2, Major = "Software"},
                new Model.Student {Id = "S010", Name = "Peter", Grade = 1, Major = "Theater"},
            };

            Console.WriteLine(students.Where(s => s.Grade >= 3).Count());

            students.OrderBy(s => s.Grade).ToList().ForEach(
                s => Console.WriteLine("{0} : {1}", s.Grade, s.Name));

            students.GroupBy(s => s.Major, (key, g) => new { Major = key, Count = g.Count() }).ToList().
                ForEach(s => Console.WriteLine("{0} : {1}", s.Major, s.Count));

            Console.WriteLine("SUM : {0}", students.Select(s => s.Grade).Sum());
            Console.WriteLine("Max : {0}", students.Select(s => s.Grade).Max());
            Console.WriteLine("Min : {0}", students.Select(s => s.Grade).Min());
            Console.WriteLine("Avg : {0}", students.Select(s => s.Grade).Average());
        }
    }
}
