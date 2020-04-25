using System;
using System.Collections;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex005
    {
        public void Run()
        {
            Stack stack = new Stack();

            Console.WriteLine("* 시작점");
            for(int idx = 1; idx < 11; idx++)
            {
                Console.WriteLine("{0}번 선수 도착", idx);
                stack.Push(String.Format("{0}번 선수", idx));
            }
            Console.WriteLine("======");
            Console.WriteLine("5~10등 선수는 탈락합니다.");
            for(int idx = 0; idx < 6; idx++)
            {
                stack.Pop();
            }
            Console.WriteLine("======");
            Console.WriteLine("* 올림픽 대표선수 명단");
            foreach(object obj in stack)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}
