using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorul_10.Payments
{
    interface IContactLessPay
    {
        void TouchTheSensor();
        void Pay(int sum, double total);
    }
}
