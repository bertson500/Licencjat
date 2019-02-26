using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemSprzedazyInternetowej.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string PhoneNumber { get; set; }
        public string AdressEmail { get; set; }
        public string Comment { get; set; }
        public DateTime OrderDateAdd { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal ValueOrder { get; set; }

        public List<OrderPossition> OrderPossition { get; set; }
    }

    public enum OrderStatus
    {
        New,
        Realized
    }
}