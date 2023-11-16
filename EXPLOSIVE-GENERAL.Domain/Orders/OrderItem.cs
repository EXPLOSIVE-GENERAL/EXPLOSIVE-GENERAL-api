using System.Linq;
using System.Collections.Generic;
using Explosive.General.Domain.Catalog;

namespace Explosive.General.Domain.Orders
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal Price => Item.Price * Quantity;
    }
}
