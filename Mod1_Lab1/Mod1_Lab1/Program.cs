using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinksMachine myMachine = new DrinksMachine(19, "Make-Atoshi", "Model-S");
            Console.WriteLine(myMachine.Age);
            Console.WriteLine(myMachine.Make);
            myMachine.Model = "the value keyword is in the setter.";
            Console.WriteLine(myMachine.Model);

            // Using a static class:
            Console.WriteLine(Math.Pow(2, 3)); 
        }
    }
}
