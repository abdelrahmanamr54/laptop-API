namespace Api_Laptop_Task.Model
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Laptop> laptops { get; set; }
    }
}
