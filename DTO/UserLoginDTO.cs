﻿using System.ComponentModel.DataAnnotations;

namespace Api_Laptop_Task.DTO
{
    public class UserLoginDTO
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}


