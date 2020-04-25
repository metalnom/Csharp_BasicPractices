using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    class Ex001
    {
        public void Run()
        {
            sbyte shortByteNumber = 127;
            byte byteNumber = 0;
            short shortNumber = 32767;
            int intNumber = 20000;
            long longNumber = 50000;

            float floatNumber = 3.14f;
            double doubleNumber = 1.5;
            decimal decimalNumber = 5.5m;

            Console.WriteLine("정수 : {0}, {1}, {2}, {3}, {4}",
                shortByteNumber,
                byteNumber,
                shortNumber,
                intNumber,
                longNumber
                );

            Console.WriteLine("실수 : {0}, {1}, {2}",
                floatNumber,
                doubleNumber,
                decimalNumber
                );
        }
    }
}
