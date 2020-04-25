﻿using System;
using System.Collections;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex004
    {
        public void Run()
        {
            Queue que = new Queue();

            for(int idx = 1; idx < 11; idx++)
            {
                que.Enqueue(String.Format("{0}번 승객", idx));
            }

            Console.WriteLine("*정류장 승객 현황");
            foreach(object obj in que)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine("===========================");
            Console.WriteLine("버스가 도착했습니다. (6명 승차 가능)");

            for(int idx = 0; idx < 6; idx++)
            {
                que.Dequeue();
            }
            Console.WriteLine("버스가 출발했습니다.");
            Console.WriteLine("===========================");

            Console.WriteLine("새로운 승객이 줄을 섭니다.");
            que.Enqueue("새로운 승객");

            Console.WriteLine("*정류장 승객 현황");
            foreach(object obj in que)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine("=============================");
        }
    }
}
