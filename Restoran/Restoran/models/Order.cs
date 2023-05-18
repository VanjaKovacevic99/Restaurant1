using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.models
{
    class Order
    {
        public int Id { set; get; }
        public bool CarriedAway { set; get; }
        public string Employee_JMB { set; get; }
        public int Table_Id { get; set; }
    }
}
