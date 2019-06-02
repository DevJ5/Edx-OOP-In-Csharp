using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesmentLab
{
    class UProgram
    {
        public string Name { get; set; }
        private static int _numberOfPrograms = 0;
        private int _id;
        private List<Degree> _degrees = new List<Degree>();

        public UProgram(string name)
        {
            Name = name;
            _id = _numberOfPrograms + 1;
            _numberOfPrograms++;
        }

        public void AddDegree(Degree degree)
        {
            _degrees.Add(degree);
        }

        public override string ToString()
        {
            return _id + " " + Name;
        }

        public void PrintAllDegrees()
        {
            foreach (var degree in _degrees)
            {
                degree.ToString();
            }
        }


    }
}
