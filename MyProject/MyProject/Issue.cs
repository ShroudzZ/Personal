using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyProject
{
    public class Issue
    {
        public int Count { get; set; }
        public List<Subject> SubjectList { get; set; }
        public int Min { get; set; } = 2;
        public int Max { get; set; } = 1000;
        private List<string> _type = new List<string> { "-", "+", "/", "*" };
        public Issue(int count)
        {
            Count = count;
            CreateSubject();
        }

        private void CreateSubject()
        {
            string result = "";
            int num = 0;
            int index = 0;
            SubjectList = new List<Subject>();
            for (var i = 0; i < Count; i++)
            {
                for (var j = 0; j < 4; j++)
                {

                    num = new Random().Next(Min, Max);
                    Thread.Sleep(2);
                    index = new Random().Next(0, _type.Count);
                    result += _type[index] + num;
                    _type.RemoveAt(index);

                    if (j.Equals(3))
                    {
                        result = result.Substring(1, result.Length - 1);
                        var s = new Subject(result, i + 1);
                        SubjectList.Add(s);
                    }
                }
                _type = new List<string> { "-", "+", "/", "*" };
                result = "";
            }

        }
    }
}
