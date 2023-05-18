using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.models
{
    class Table
    {
        public int Id { get; set; }
        public int TableNumber { get; set; }
        public int NumberOfSeats { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Table table && Id == table.Id;
        }

        public override int GetHashCode()
        {
            return -1255590651 + Id.GetHashCode();
        }

        public override string ToString()
        {
            return TableNumber + ",Broj mjesta: " + NumberOfSeats;
        }

    }
}
