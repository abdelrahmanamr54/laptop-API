using Api_Laptop_Task.Data;
using Api_Laptop_Task.DTO;
using Api_Laptop_Task.I_Repository;
using Api_Laptop_Task.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace Api_Laptop_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaptopController : ControllerBase
    {

        I_LaptopRepository laptopRepository = new LaptopRepository();
        private readonly ApplicationDbContext context;
       
        public LaptopController(ApplicationDbContext context)
        {
            this.context = context;
           
        }

        [HttpGet]
        public IActionResult Read()
        {
           
            var laptops = laptopRepository.getAllAlotops();
         



            return Ok(laptops);


        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {

            var selectedlap = laptopRepository.GetLapTopById(id);
          
            

            return Ok(selectedlap);
        }
        [HttpGet]
        [Route("api/laptops/search")]
        //[Route("{name}")]
        public IActionResult getbysearch(string name)
        {

           

            var laptops = laptopRepository.getbysearch(name);
         

            return Ok(laptops);


        }
        [HttpGet]
        [Route("api/laptops/price")]
        public async Task<IActionResult> GetByPrice(double min, double max)
        {

            var laptops = laptopRepository.GetByPrice(min, max);
            

            return Ok(laptops);
        }
        [HttpGet]
        [Route("api/laptops/brand")]
        public async Task<IActionResult> GetBybrand(int id)
        {

            var laptops = laptopRepository.GetBybrand(id);
          

            return Ok(laptops);
        }
        [HttpGet]
        [Route("api/laptops/filter")]
        public IActionResult FilterLaptops(int id, double? minPrice, double? maxPrice, int? minRating, int? maxRating)
        {
            var laptops = laptopRepository.FilterLaptops(id, minPrice, maxPrice, minRating, maxRating);
              
            return Ok(laptops);
        }
        [HttpPost]
        [Route("api/laptops/contact")]
        public IActionResult ContactUs(ContactUsDTO contactUsDTO)

        {

            
            laptopRepository.ContactUs(contactUsDTO);
           
            return Ok();
        }


    }
}
