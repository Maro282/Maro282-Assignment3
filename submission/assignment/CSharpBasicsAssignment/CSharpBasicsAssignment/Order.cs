using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace CSharpBasicsAssignment
{
    internal class Order
    {

        public int OrderId;
        public string CustomerName;
        public int Quantity;
        public decimal UnitPrice;
        public decimal TotalPrice;
        public bool IsPaid;
        public double DiscountPercent;
        public string ShippingCity;
        //('H', 'M', 'L')
        public char Priority;
        public long ItemCode;

        public void CalculateTotal()
        {
            this.TotalPrice = Quantity * UnitPrice * Convert.ToDecimal(1 - DiscountPercent / 100);
        }

        public void PrintSummary()
        {
            Console.WriteLine("OrderId : " + OrderId);
            Console.WriteLine("Customer Name : " + CustomerName);
            Console.WriteLine("Total Price : " + TotalPrice);
            Console.WriteLine("IsPaid : " + IsPaid);
        }
    }
}
