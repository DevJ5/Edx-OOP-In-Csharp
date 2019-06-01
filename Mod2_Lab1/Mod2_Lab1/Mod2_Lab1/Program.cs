using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Anonymous Class
            // Anonymous class
            var anAnonymousClass = new { Name = "Alex", Age = 65 };
            Console.WriteLine("The name: {0}", anAnonymousClass.Name);
            // Because the names, types, order and number of fields are the same, 
            // they are both instances of the same class.
            var anotherAnonymousClass = new { Name = "Bert", Age = 34 };

            #endregion

            Manager BillTheManager = new Manager();
            BillTheManager.FirstName = "Bill";
            BillTheManager.Lastname = "The managerio";

            Console.WriteLine(BillTheManager);

            BillTheManager.EatLunch();
            BillTheManager.Login();
        }
    }
}
