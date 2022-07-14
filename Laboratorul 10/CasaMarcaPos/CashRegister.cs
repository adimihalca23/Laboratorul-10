using Laboratorul_10.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorul_10.CasaMarcaPos
{
    class CashRegister
    {
        private Pos pos;
        private int total = 0;

        public CashRegister(Pos pos)
        {
            this.pos = pos;
        }
        public void Scan(IProduct product, int quantity)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            else
            {
                total += product.Price * quantity;
            }
        }

        public void Pay(int sum)
        {
            if (sum < total)
            {
                Console.WriteLine("Suma este prea mica pentru a achita produsele.");
            }
            else
            {
                Console.WriteLine($"Ati achitat {sum} lei, rest {sum - total} lei.");
                total = 0;
            }
        }

        public Pos GetPos { get { return pos; } }

        public int Total { get { return this.total; } }
    }
}
