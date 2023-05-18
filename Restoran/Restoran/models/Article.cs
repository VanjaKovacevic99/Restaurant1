using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.models
{
    class Article
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public int Quantity { set; get; }
        public decimal SalePrice { set; get; }
        public bool IsItForSale { set; get; }
        public bool IsItToOrder { set; get; }
        public  decimal PurchasePrice { set; get; }

        public decimal Kilograms { set; get; }

        public override bool Equals(object obj)
        {
            return obj is Article article && Id== article.Id;
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
