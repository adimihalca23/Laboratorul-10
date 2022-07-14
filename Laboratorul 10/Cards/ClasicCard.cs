using Laboratorul_10.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorul_10.Cards
{
    class ClasicCard : IContactFullPay
    {
        public void ExtractCard()
        {
            Console.WriteLine("Retrageti cardul");
        }

        public void InsertCard()
        {
            Console.WriteLine("Introduceti cardul");
        }

        //Ii ok sa aiba cardul o metoda de plata?
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
    }
}
