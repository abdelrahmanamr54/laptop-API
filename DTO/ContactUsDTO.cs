using System.ComponentModel.DataAnnotations;

namespace Api_Laptop_Task.DTO
{
    public class ContactUsDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public bool Status { get; set; } = false;
    }
}
