using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    class Prob001
    {
        public void Run()
        {
            Random rand = new Random();
            int targetNum = rand.Next(1, 50);

            while (true)
            {

                Console.WriteLine("1~50 사이의 값 중 하나를 입력하세요");

                string strSelectNum = Console.ReadLine();
                int intSelectNum = Convert.ToInt32(strSelectNum);

                if (intSelectNum < targetNum)
                {
                    Console.WriteLine("틀렸습니다. UP!");
                    continue;
                }
                else if (intSelectNum > targetNum)
                {
                    Console.WriteLine("틀렸습니다. DOWN!");
                    continue;
                }
                else
                    break;
            }
            Console.WriteLine("정답입니다!!");
        }
    }
}
