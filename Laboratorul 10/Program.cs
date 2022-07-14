

using Laboratorul_10.Cards;
using Laboratorul_10.CasaMarcaPos;
using Laboratorul_10.Product;
using System;

namespace Laboratorul_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1();
        }
        static void Ex1()
        {
            Phone phone1 = new Phone(654, "Nokia", 365);
            Phone phone2 = new Phone(321, "Samsung", 897);
            Phone phone3 = new Phone(012, "Motorola", 512);

            Pos pos = new Pos();
            CashRegister cashRegister = new CashRegister(pos);

            ClasicCard clasicCard = new ClasicCard();
            ContactLessCard contactLessCard = new ContactLessCard();
            PhoneCard phoneCard = new PhoneCard();

            cashRegister.Scan(phone1, 2);
            cashRegister.Scan(phone1, 1);
            cashRegister.Scan(phone1, 3);

            //cashRegister.Pay(3000);

            //pos.Pay(3000, cashRegister.Total, clasicCard);

            //pos.Pay(3000, cashRegister.Total, contactLessCard);

            pos.Pay(3000, cashRegister.Total, phoneCard);
        }
    }
}
