using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Customer: ILoyaltyCardHolder
    {
        private int totalPoints;
        public int TotalPoints { get; }     

        // Explicit interface:
        int ILoyaltyCardHolder.AddPoints(decimal transactionValue)
        {
            int points = Decimal.ToInt32(transactionValue);
            totalPoints += points;
            return totalPoints;
        }

        public void ResetPoints()
        {
            throw new NotImplementedException();
        }
    }
}
