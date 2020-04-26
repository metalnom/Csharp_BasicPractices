using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter07
{
    class Ex001
    {
        public void Run()
        {
            Console.WriteLine("숫자를 입력하세요: ");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("입력된 숫자는 {0}", number);
            }
            catch(Exception e)
            {
                Console.WriteLine("예외 상황 발생, 관리자에게 문의하세요");
                Console.WriteLine("에러 코드 : {0}", e.HResult);
                Console.WriteLine("에러 코드 : {0}", e.Message);
            }

        }
    }
}
