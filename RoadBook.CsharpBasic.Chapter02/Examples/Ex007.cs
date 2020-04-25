using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    class Ex007
    {
        public void Calc()
        {
            int kor = 100;
            int eng = 100;
            int math = 98;
            int ath = 97;
            int sum = 0;

            sum = kor + eng + math + ath;

            Console.WriteLine("합계 : {0}, 평균 : {1}", sum, (float)sum/4);
            
        }
    }
}
