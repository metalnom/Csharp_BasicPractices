﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    class Ex010
    {
        int globalValue = 20;

        public void Run()
        {
            int localValue = 10;
            Sum();
            Multiple();

            Console.WriteLine("local: {0} / global: {1}", localValue, globalValue);
        }

        private void Sum()
        {
            globalValue = globalValue + 10;
        }

        private void Multiple()
        {
            globalValue = globalValue * 2;
        }
    }
}
