namespace SystemSprzedazyInternetowej.Models
{
    public class OrderPossition
    {
        public int OrderPossitionId { get; set; }
        public int OrderId { get; set; }
        public int ClothId { get; set; }
        public int Quantity { get; set; }
        public decimal PriceOrderFinal { get; set; }

        public virtual Cloth Cloth { get; set; }
        public virtual Order Order { get; set; }
         


    }
}