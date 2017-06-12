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
            CustomList<int> list = new CustomList<int>();
            list.Add(0);
            list.Add(3);
            list.Add(6);
            list.Add(7);
            list.Add(9);
            list.Remove(6);

        }
    }
}
