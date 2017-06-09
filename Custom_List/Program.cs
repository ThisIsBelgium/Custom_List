using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TestObject> list = new List<TestObject>();
            list.Add(new TestObject());
            list.RemoveAt(0);

        }
    }
}
