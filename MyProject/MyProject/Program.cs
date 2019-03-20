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
            //var  i = new Issue(1000);
            //int count= i.SubjectList.Count;
            //for (var j = 0; j < count; j++)
            //{
            //    Console.WriteLine(i.SubjectList[j] .Index+ "、 " + i.SubjectList[j].SubjectName + " = {0}", i.SubjectList[j].Result);
            //    Console.WriteLine(); 
            //}
            var dt = new DataTable();
            var n = "8-4*(3+2)";
            var s = new Subject(n,1);
            var len = n.Length;
            int index = n.IndexOf('-');
            var right = n.Substring(index+1, len-index-1);
            var left = n.Replace("-"+right, "");


            var Rresult=dt.Compute(right,"");
            var Lresult = dt.Compute(left, "");


            Console.ReadKey();
        }
    }
}
