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
        static int ocount, scount, min, max;

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Initialization();
                }
                catch
                {
                    Console.WriteLine("输入有误，请重试");
                    Initialization();
                }
                Generating(ocount,scount,min,max);
            }
        }

        static void Initialization()
        {
            Console.WriteLine("请选择语言英文或者中文 1.英文 2.中文");
            int Language = int.Parse(Console.ReadLine());
            if (Language.Equals(1))
            {
                Console.WriteLine("Please enter the number of topics");
                scount = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the number of operators");
                ocount = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the minimum value of the number.");
                min = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the maximum number");
                max = int.Parse(Console.ReadLine());
            }
            else if (Language.Equals(2))
            {
                Console.WriteLine("请输入题目数量");
                scount = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入运算符个数");
                ocount = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入数字的最小值");
                min = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入数字的最大值");
                max = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("输入有误，请重试");
                Initialization();
            }


        }

        static void Generating(int ocount, int scount, int min, int max)
        {
            var i = new Issue(scount, ocount, min, max);
            var sub = string.Empty;
            var res = string.Empty;
            int count = i.SubjectList.Count;
            for (var j = 0; j < count; j++)
            {

                sub += i.SubjectList[j].Index + "、 " + i.SubjectList[j].SubjectName + "=" + "\n";
                res += i.SubjectList[j].Index + "、 " + i.SubjectList[j].Result + "\n";
                Console.WriteLine(i.SubjectList[j].Index + "、 " + i.SubjectList[j].SubjectName + " = {0}", i.SubjectList[j].Result.ToString("F2"));
                Console.WriteLine();
            }
            TxtHelp.WriteCreateSubjectorAnswer(sub, TxtHelp.Type.WriteSubject);
            TxtHelp.WriteCreateSubjectorAnswer(res, TxtHelp.Type.WriteAnswer);
        }

    }
}
