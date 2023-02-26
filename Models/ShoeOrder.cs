namespace Nevada.Models
{
    public class ShoeOrder
    {
        public Guid Id { get; set; }

        public Guid ShoesModelId { get; set; }
        public string ShoeName { get; set; }
        public float Price { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public bool Delivered { get; set; } 
    }
}
