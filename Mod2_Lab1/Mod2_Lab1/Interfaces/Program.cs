using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customerA = new Customer();
            // Implicit conversion because a customer always has the members of the interface.
            ILoyaltyCardHolder customerB = customerA;
            // Explicit conversion with cast, because Customer may include members that are not in the interface.
            Customer customerC = (Customer)customerB;

            try
            {
                Console.WriteLine(((ILoyaltyCardHolder)customerA).AddPoints(20));
                // This will print 0 points, because it is read only.
                Console.WriteLine($"{customerA.TotalPoints} points");
            }
            catch(Exception e)
            {
                Console.WriteLine("An exception" + e);
            }
        }


    }
}
