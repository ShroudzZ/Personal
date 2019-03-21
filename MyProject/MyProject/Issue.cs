using System;
using System.Collections.Generic;
using System.Data;
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
        public int Max { get; set; } = 20;
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
                    Thread.Sleep(20);
                    num = new Random().Next(Min, Max);
                    index = new Random().Next(0, _type.Count);
                    result += _type[index] + num;
                    _type.RemoveAt(index);

                    if (j.Equals(3))
                    {
                        result = result.Substring(1, result.Length - 1);
                        //result = Divisible(result);
                        result = DelNegative(result);
                        var s = new Subject(result, i + 1);
                        SubjectList.Add(s);
                    }
                }
                _type = new List<string> { "-", "+", "/", "*" };
                result = "";
            }
        }



        private string DelNegative(string r)
        {
            string result = r;

            var dt = new DataTable();
            var len = r.Length;
            int index = r.IndexOf('-');
            if (index.Equals(-1)) return result;
            var right = r.Substring(index + 1, len - index - 1);
            var left = r.Replace("-" + right, "");
            var Rresult = dt.Compute(right, "");
            var Lresult = dt.Compute(left, "");
            if (Convert.ToDouble(Lresult) < Convert.ToDouble(Rresult))
            {
                result = right + "-" + left;
            }
            return result;
        }

        private string Divisible(string r)
        {
            var result = r;
            var len = r.Length;
            int index = r.IndexOf('/');
            if (index.Equals(-1)) return result;
            var right = r.Substring(index + 1, 1);
            var left = r.Substring(index - 1, 1);


            if (int.Parse(left) % int.Parse(right) != 0)
            {
                int y = 0;
                string newleft = string.Empty;
                var newL = string.Empty;
                if (int.Parse(left) / int.Parse(right) != 0)
                {
                    y = int.Parse(left) % int.Parse(right);
                    newleft = (int.Parse(right) + y).ToString();
                    newL = left + "/" + newleft;
                }
                else
                {
                    y = int.Parse(right) - int.Parse(left);
                    newleft = (int.Parse(left) + y).ToString();
                    newL = newleft + "/" + right;
                }

                
                result = r.Replace(left + "/" + right, newL); ;
            }
            return result;
        }

    }
}
