using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorul_10.Payments
{
    interface IContactFullPay
    {
        void InsertCard();
        void ExtractCard();
        void Pay(int sum, double total);
    }
}
