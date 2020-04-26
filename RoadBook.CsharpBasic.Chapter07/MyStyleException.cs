using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter07
{
    class MyStyleException: Exception
    {
        public MyStyleException() { }
        public MyStyleException(string message) : base(message) { }
    }
}
