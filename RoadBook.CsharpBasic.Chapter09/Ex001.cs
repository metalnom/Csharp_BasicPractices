using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter09
{
    class Ex001
    {
        public void Run()
        {
            List<Model.Student> student = new List<Model.Student>()
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

            for (int idx = 0; idx < student.Count; idx++)
            {
                if (student[idx].Grade == 1 || student[idx].Grade == 3)
                {
                    Console.WriteLine(student[idx].Name);
                }
            }
        }
    }
}
