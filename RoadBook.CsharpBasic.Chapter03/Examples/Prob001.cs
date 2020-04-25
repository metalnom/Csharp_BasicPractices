using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    class Prob001
    {
        public void Run()
        {
            Random rand = new Random();
            int num1 = rand.Next(1, 100);
            int num2 = rand.Next(1, 100);

            Console.WriteLine("다음 문제를 푸세요");
            Console.WriteLine(" {0} + {1} = ", num1, num2);
            string sum = Console.ReadLine();

            if (Convert.ToInt32(sum) == (num1 + num2))
                Console.WriteLine("정답입니다.");

            else
                Console.WriteLine("오답입니다.");
        }
    }
}
