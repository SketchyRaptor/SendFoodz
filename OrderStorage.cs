using System;
using System.Collections.Generic;

namespace LogIn1
{
    public static class OrderStorage
    {
        public static List<Order> AllOrders { get; set; } = new List<Order>();
        public static event Action OrderAdded;   // <-- new event

        public static void AddOrder(Order order)
        {
            AllOrders.Add(order);
            OrderAdded?.Invoke();   // notify subscribers
        }
    }

    public class Order
    {
        private static int nextId = 1;
        public int OrderId { get; private set; }
        public string CustomerName { get; set; }
        public string MerchantName { get; set; }
        public List<string> ItemsSummary { get; set; } = new List<string>();
        public decimal Total { get; set; }
        public string Status { get; set; }
        public string Rider { get; set; }
        public string Stage { get; set; }  // "Pending", "Preparing", "On the Way", "Delivered"
        public List<string> HistoryLog { get; set; } = new List<string>();

        public Order()
        {
            OrderId = nextId++;
        }
    }
}