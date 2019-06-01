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
        private List<Degree> DegreeList = new List<Degree>();

        public UProgram(string name)
        {
            Name = name;
        }

        public void AddDegree(Degree degree)
        {
            DegreeList.Add(degree);
        }
    }
}
