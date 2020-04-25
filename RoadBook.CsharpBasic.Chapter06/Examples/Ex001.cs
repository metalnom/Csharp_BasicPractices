using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex001
    {
        public void Run()
        {
            int[][] gradeOfStudent =
            {
                new int[] {100, 96, 94},
                new int[] {95, 98, 89},
                new int[] {90, 99, 97},
                new int[] {93, 100, 93}
            };

            for (int idx_i = 0; idx_i < gradeOfStudent.Length; idx_i++)
            {
                for (int idx_j = 0; idx_j < gradeOfStudent[idx_i].Length; idx_j++)
                {
                    Console.WriteLine("{0}번째 학생의 {1}번째 과목 성적: {2}",
                        idx_i + 1, idx_j + 1, gradeOfStudent[idx_i][idx_j]);
                }
            }

        }
    }
}
