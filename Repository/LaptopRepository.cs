using Api_Laptop_Task.Data;
using Api_Laptop_Task.DTO;
using Api_Laptop_Task.I_Repository;
using Api_Laptop_Task.Model;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Api_Laptop_Task.Repository
{
    public class LaptopRepository : I_LaptopRepository
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IQueryable<LaptopDTO> getAllAlotops()
        {
            
            var laptops = context.laptops.Select(laptop => new LaptopDTO
            {
                Id = laptop.Id,
                Title = laptop.Title,
            
                Price = laptop.price,
                OldPrice = laptop.Oldprice,
                ImageUrl = laptop.ImageUrl,
            
                Rating = laptop.Rating
               
            });
       



            return laptops;


        }

        
        public IQueryable<LaptopDTO> GetLapTopById(int id)
        {

            var selectedlap = context.laptops.Where(e => e.Id == id).Select(laptop => new LaptopDTO
            {
                Id = laptop.Id,
                Title = laptop.Title,
                Description = laptop.Description,
                Price = laptop.price,
                OldPrice = laptop.Oldprice,
                ImageUrl = laptop.ImageUrl,
                Model = laptop.Model,

                BrandName = context.brands.FirstOrDefault(b => b.Id == laptop.BrandId).Name
            });


            return selectedlap;
        }
        public IQueryable<LaptopDTO> getbysearch(string name)
        {

            var laptops = context.laptops.Where(e => e.Title.Contains(name)).Select(laptop => new LaptopDTO
        {
            Id = laptop.Id,
            Title = laptop.Title,
            Description = laptop.Description,
            Price = laptop.price,
            OldPrice = laptop.Oldprice,
            ImageUrl = laptop.ImageUrl,
            Model = laptop.Model,

            BrandName = context.brands.FirstOrDefault(b => b.Id == laptop.BrandId).Name
        });

           

            return laptops;


    }
   
    public IQueryable<LaptopDTO> GetByPrice(double min, double max)
    {

        var laptops = context.laptops.Where(l => l.price >= min && l.price <= max).Select(laptop => new LaptopDTO
        {
            Id = laptop.Id,
            Title = laptop.Title,

            Price = laptop.price,
            OldPrice = laptop.Oldprice,
            ImageUrl = laptop.ImageUrl,
         
            Rating = laptop.Rating
        });

        return laptops;
    }
    
    public IQueryable<LaptopDTO> GetBybrand(int id)
    {

        var laptops = context.laptops.Where(l => l.BrandId == id).Select(laptop => new LaptopDTO
        {
            Id = laptop.Id,
            Title = laptop.Title,
       
            Price = laptop.price,
            OldPrice = laptop.Oldprice,
            ImageUrl = laptop.ImageUrl,
        
            Rating = laptop.Rating
        }); ;

        return laptops;
    }
        public IQueryable<LaptopDTO> FilterLaptops(int id, double? minPrice, double? maxPrice, int? minRating, int? maxRating)
        {
            var laptops = context.laptops
                .Where(l => l.BrandId == id
                    && (l.price >= minPrice)
                    && (l.price <= maxPrice)
                    && (l.Rating >= minRating)
                    && (l.Rating <= maxRating))
                .Select(laptop => new LaptopDTO
                {
                    Id = laptop.Id,
                    Title = laptop.Title,
                    Description = laptop.Description,
                    Price = laptop.price,
                    OldPrice = laptop.Oldprice,
                    ImageUrl = laptop.ImageUrl,
                    BrandId = laptop.BrandId,
                    Model = laptop.Model,

                    BrandName = context.brands.FirstOrDefault(b => b.Id == laptop.BrandId).Name
                }); ;

          
            return   laptops;
        }
      
        public void ContactUs(ContactUsDTO contactUsDTO)

        {

            var contact = context.contactUs.Add(new Model.ContactUs
            {
                Name = contactUsDTO.Name,
                Email = contactUsDTO.Email,
                Message = contactUsDTO.Message,
                Subject = contactUsDTO.Subject
            }
           );
            context.SaveChanges();

         //   return  contact;
        }
    }
}
