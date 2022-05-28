using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_queues
{
    internal class Order
    {
        public static int OrderId { get; set; }
        public static int OrderQuantity { get; set; }

        public Order (int orderId, int orderQuantity)
        {
            OrderId = orderId;
            OrderQuantity = orderQuantity;
        }

        public void ProcessOrder()
        {
            Console.WriteLine($"Order {OrderId} was processed.");
        }
    }
}
