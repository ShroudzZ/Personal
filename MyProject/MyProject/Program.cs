using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Issue i = new Issue(10);
            DataTable dt = new DataTable();
            for (var j = 0; j < i.Subject.Count; j++)
            {

                Console.WriteLine(j + 1 + "、 " + i.Subject[j] + " = {0}", dt.Compute(i.Subject[j], ""));
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
