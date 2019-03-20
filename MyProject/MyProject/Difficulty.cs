using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public enum Grades
    {
        One,
        Two,
        Three,
        Four
    }

    public class Difficulty
    {
        public Grades Grades { get; set; }

        public Difficulty(Grades g)
        {
            switch (g)
            {
                case Grades.One: break;
                case Grades.Two: break;
                case Grades.Three: break;
                case Grades.Four: break;
            }

        }
    }
}
