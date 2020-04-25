using System;
using System.Collections;
using System.Text;

namespace RoadBook.CsharpBasic.Chapter06.Examples
{
    class Ex003
    {
        public void Run()
        {
            ArrayList aList = new ArrayList();
            for(int idx = 0; idx < 10; idx++)
            {
                aList.Add(idx);
            }
            for(int idx = 0; idx < 15; idx++)
            {
                aList.Add(idx.ToString());
            }

            aList.Insert(5, "100");
            aList.RemoveAt(3);

            for(int idx = 0; idx < aList.Count; idx++)
            {
                Console.WriteLine("Value: {0} / Type: {1}", aList[idx], aList[idx].GetType());
            }
        }
    }
}
