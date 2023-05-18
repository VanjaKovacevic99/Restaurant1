using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.dto
{
    class OrderDto
    {
        public int Id { set; get; }
        public int TableNumber { set; get;}
        public decimal Price { set; get; }
        public int Quantity { set; get; }
        public string Name { set; get; }

        public override bool Equals(object obj)
        {
            return obj is OrderDto orderDto && Id == orderDto.Id;
        }

        public override int GetHashCode()
        {
            return -1255590651 + Id.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
