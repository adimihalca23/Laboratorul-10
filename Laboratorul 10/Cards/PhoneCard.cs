using Laboratorul_10.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorul_10.Cards
{
    internal class PhoneCard : IContactLessPay
    {
        public void Pay(int sum, double total)
        {
            if (sum < total)
            {
                Console.WriteLine("Suma este prea mica pentru a achita produsele.");
            }
            else
            {
                Console.WriteLine($"Ati achitat {sum} lei, rest {total - sum} lei.");
            }
        }

        public void TouchTheSensor()
        {
            Console.WriteLine("Apropiati telefonul");
        }
    }
}
