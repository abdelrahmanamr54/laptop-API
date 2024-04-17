using Api_Laptop_Task.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Api_Laptop_Task.I_Repository
{
    public interface I_LaptopRepository
    {
         IQueryable<LaptopDTO> getAllAlotops();


       
         IQueryable<LaptopDTO> GetLapTopById(int id);
        IQueryable<LaptopDTO> getbysearch(string name);
       
          


        

    IQueryable<LaptopDTO> GetByPrice(double min, double max);
        IQueryable<LaptopDTO> GetBybrand(int id);
      IQueryable<LaptopDTO> FilterLaptops(int id, double? minPrice, double? maxPrice, int? minRating, int? maxRating);


        //if (laptops == null || laptops.Count == 0)
        //{
        //    return NotFound("No laptops found for the specified criteria.");
        //}

        //var laptopDTOs = _mapper.Map<List<LaptopDTO>>(laptops);



      void ContactUs(ContactUsDTO contactUsDTO);
    }
}
