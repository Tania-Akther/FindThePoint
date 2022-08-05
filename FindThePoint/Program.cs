using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FindThePoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = findPoint(1, 1, 2, 2);
            Console.WriteLine(result.Aggregate<int, string>(" ", (a, b) => a + " " + b));
        }
        public static List<int> findPoint(int px, int py, int qx, int qy)
        {
            List<int> list = new List<int>();
            var rx = qx + (qx - px);
            list.Add(rx);
            var ry = qy + (qy - py);
            list.Add(ry);
            return list;
        }
    }
}
