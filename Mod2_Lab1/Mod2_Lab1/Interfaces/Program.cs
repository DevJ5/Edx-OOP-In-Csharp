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
            Customer customer = new Customer();
            try
            {
                Console.WriteLine(((ILoyaltyCardHolder)customer).AddPoints(20));
                Console.WriteLine(customer.TotalPoints);
            }
            catch(Exception e)
            {
                Console.WriteLine("An exception" + e);
            }
        }


    }
}
