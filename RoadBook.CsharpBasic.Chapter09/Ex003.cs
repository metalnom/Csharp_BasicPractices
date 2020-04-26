using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RoadBook.CsharpBasic.Chapter09
{
    class Ex003
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

            var resultList = from s in students where s.Grade == 1 || s.Grade == 3 select s;

            foreach (var result in resultList)
            {
                Console.WriteLine("{0} : {1}", result.Name, result.Major);
            }

            resultList = from s in students where s.Grade >= 3 select s;
            Console.WriteLine(resultList.Count());

            resultList = from s in students orderby s.Grade select s;
            foreach(var result in resultList)
            {
                Console.WriteLine("{0} : {1}", result.Grade, result.Name);
            }

            var groups = from s in students
                         group s by s.Major into grp
                         select new { Major = grp.Key, Count = grp.Count() };
            foreach(var group in groups)
            {
                Console.WriteLine("{0} : {1}", group.Major, group.Count);
            }
        }
    }
}
