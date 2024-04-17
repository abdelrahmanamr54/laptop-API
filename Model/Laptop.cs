namespace Api_Laptop_Task.Model
{
    public class Laptop
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double price { get; set; }
        public double Oldprice { get; set; }
        public string ImageUrl { get; set; }
        public string Model { get; set; }
        public Brand brand { get; set; }
        public int BrandId { get; set; }
       // public Rating rating{ get; set; }
        public int Rating { get; set; }
    
        
    }
}
