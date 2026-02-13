using ManagmentApplication.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ManagmentApplication.Helper
{
    public class OrderProcessingManager
    {
        private readonly ConcurrentDictionary<int, Order> _orders = new ConcurrentDictionary<int, Order>();
        private readonly object _lockObject = new object();
        private static OrderProcessingManager _instance;

        public static OrderProcessingManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OrderProcessingManager();
                }
                return _instance;
            }
        }

        private readonly Mutex _mutex = new Mutex();

        public void AddOrder(Order order)
        {
            _orders[order.OrderID] = order;

            
            Thread orderThread = new Thread(() =>
            {
                while (true)
                {
                    _mutex.WaitOne(); 
                    try
                    {
                        order.WaitingTime++; 
                        order.PriorityScore = CalculatePriority(order);
                    }
                    finally
                    {
                        _mutex.ReleaseMutex(); 
                    }

                    Thread.Sleep(1000); 
                }
            });

            
            orderThread.IsBackground = true;
            orderThread.Start(); 
        }



        public int CalculatePriority(Order order)
        {
            int baseScore = order.CustomerType == "Premium" ? 15 : 10;
            return baseScore + (int)(order.WaitingTime * 0.5);
        }

        public Order GetNextOrder()
        {
            lock (_lockObject)
            {
                return _orders.Values.OrderByDescending(o => o.PriorityScore).FirstOrDefault();
            }
        }

        public void RemoveOrder(int orderId)
        {
            _orders.TryRemove(orderId, out _);
        }

        public IEnumerable<Order> GetOrders()
        {
            lock (_lockObject)
            {
                return _orders.Values.ToList();
            }
        }

    }
}
