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
            var i = new Issue(10);
            var sub = string.Empty;
            var res = string.Empty;
            int count = i.SubjectList.Count;
            for (var j = 0; j < count; j++)
            {

                sub += i.SubjectList[j].Index + "、 " + i.SubjectList[j].SubjectName + "=" + "\n";
                res += i.SubjectList[j].Index + "、 " + i.SubjectList[j].Result + "\n";
                Console.WriteLine(i.SubjectList[j].Index + "、 " + i.SubjectList[j].SubjectName + " = {0}", i.SubjectList[j].Result);
                Console.WriteLine();
            }
            TxtHelp.WriteCreateSubjectorAnswer(sub, TxtHelp.Type.WriteSubject);
            TxtHelp.WriteCreateSubjectorAnswer(res, TxtHelp.Type.WriteAnswer);
            Console.ReadKey();
        }
    }
}
