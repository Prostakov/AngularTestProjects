using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CarsApp.Data;
using CarsApp.Models;
using CarsApp.ResourceModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarsApp.Controllers
{
    public class ManufacturersController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ManufacturersController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("/api/manufacturers")]
        public async Task<IEnumerable<ManufacturerResource>> GetManufacturers()
        {
            var manufacturers = await _context.Manufacturers.Include(m => m.Models).ToListAsync();
            
            return _mapper.Map<List<Manufacturer>, List<ManufacturerResource>>(manufacturers);
        }
    }
}