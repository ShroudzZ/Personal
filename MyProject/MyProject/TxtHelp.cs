using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class TxtHelp
    {
        //\n
        public enum Type
        {
            WriteSubject,
            WriteAnswer
        }
        public static void WriteCreateSubjectorAnswer(string str, Type t)
        {
            string name = "";
            switch (t)
            {
                case Type.WriteSubject: name = "Exercise.txt"; break;
                case Type.WriteAnswer: name = "Answer.txt"; break;
            }
            FileStream fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + name, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
