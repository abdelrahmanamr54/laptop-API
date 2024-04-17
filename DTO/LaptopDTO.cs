namespace Api_Laptop_Task.DTO

{
    public class LaptopDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double OldPrice { get; set; }
        public string ImageUrl { get; set; }
        public string Model { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }

        public int Rating { get; set; }
    }
}
