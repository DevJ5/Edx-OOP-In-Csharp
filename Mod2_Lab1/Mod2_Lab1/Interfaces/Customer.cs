using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Customer: ILoyaltyCardHolder
    {
        public int TotalPoints { get; set; }     

        int ILoyaltyCardHolder.AddPoints(decimal transactionValue)
        {
            int points = Decimal.ToInt32(transactionValue);
            TotalPoints += points;
            return TotalPoints;
        }

        public void ResetPoints()
        {
            throw new NotImplementedException();
        }
    }
}
