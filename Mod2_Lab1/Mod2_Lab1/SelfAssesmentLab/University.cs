using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesmentLab
{
    class University
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        private List<UProgram> _programs = new List<UProgram>();

        public University(string name, string address, string postalCode, string city)
        {
            Name = name;
            Address = address;
            PostalCode = PostalCode;
            City = city;
        }

        public void AddProgram(UProgram program)
        {
            _programs.Add(program);
        }

        public string GetFullAddress()
        {
            return $"{Address}, {PostalCode} {City}"; 
        }

        public void PrintAllPrograms()
        {
            foreach (var program in _programs)
            {
                Console.WriteLine(program);
            }
        }
    }
}
