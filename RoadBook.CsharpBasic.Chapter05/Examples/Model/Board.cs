using System;
using System.Collections.Generic;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter05.Examples.Model
{
    class Board
    {
        public int Number { get; set; }
        public string Title { get; set; }   
        public string Contents { get; set; }
        public string Writer { get; set; }  
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }    

    }
}
