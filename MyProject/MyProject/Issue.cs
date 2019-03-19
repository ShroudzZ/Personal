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
        public List<string> Subject { get; set; }
        public int Min { get; set; } = 1;
        public int Max { get; set; } = 9;
        private List<string> _type = new List<string> { "-", "+", "/", "*" };
        public Issue(int count)
        {
            Count = count;
            CreateSubject();
        }

        private void CreateSubject()
        {
            string result = "";
            Subject = new List<string>();
            for (var i = 0; i < Count; i++)
            {
                for (var j = 0; j < 4 ; j++)
                {
                    Thread.Sleep(20);
                    int num = new Random().Next(Min, Max);
                    int index = new Random().Next(0, _type.Count);
                    result += _type[index] + num;
                    _type.RemoveAt(index);
                    
                    if (j == 3)
                    {
                        result = result.Substring(1, result.Length-1);
                        Subject.Add(result);
                    }
                }
                _type = new List<string> { "-", "+", "/", "*" };
                result = "";
            }

        }
    }
}
