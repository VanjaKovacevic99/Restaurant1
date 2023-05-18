using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.models
{
    class OrderArticle
    {
        public int Order_Id { get; set; }
        public int Article_Id { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public OrderArticle(int Order_Id, int Article_Id, decimal Prace, int Quantity) {
            this.Order_Id = Order_Id;
            this.Article_Id = Article_Id;
            this.Price = Price;
            this.Quantity = Quantity;
        }

    }
}
