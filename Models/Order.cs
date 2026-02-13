using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentApplication.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string CustomerType { get; set; }
        public int Quantity { get; set; } 
        public string ProductName { get; set; } // Ürün ismi (Products tablosundan alınacak)
        public decimal TotalPrice { get; set; }
        public int WaitingTime { get; set; } = 0; // Saniye cinsinden
        public int PriorityScore { get; set; } = 0;
    }
}

