using Laboratorul_10.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorul_10.CasaMarcaPos
{
    class Pos
    {
        public void Pay(int sum, double total, IContactFullPay contactFullPay)
        {
            contactFullPay.InsertCard();
            contactFullPay.Pay(sum, total);
            contactFullPay.ExtractCard();
        }
        public void Pay(int sum, double total, IContactLessPay contactLessPay)
        {
            contactLessPay.TouchTheSensor();
            contactLessPay.Pay(sum, total);
        }
    }
}
