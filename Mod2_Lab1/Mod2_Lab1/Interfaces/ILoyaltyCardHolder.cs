using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ILoyaltyCardHolder
    {
        int TotalPoints { get; set; }
        int AddPoints(decimal points);
        void ResetPoints();
    }
}
