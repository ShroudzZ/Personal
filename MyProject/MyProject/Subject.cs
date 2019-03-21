using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Subject
    {
        public int Index { get; set; }
        public string SubjectName { get; set; }
        public double Result { get; set; }

        public Subject(string n, int i)
        {
            SubjectName = n;
            Index = i;
            Result = Calculation();
        }
        private double Calculation()
        {

            var dt = new DataTable();
            double result = Convert.ToDouble(dt.Compute(SubjectName, ""));
            return result;
        }
    }
}
