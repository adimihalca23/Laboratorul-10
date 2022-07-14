using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorul_10.Product
{
    class Phone : IProduct
    {
        //Nu pot sa pun set as private..
        public int Id { get;  set; }
        public string Name { get;  set; }
        public int Price { get;  set; }

        public Phone(int id, string name, int price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
    }
}
