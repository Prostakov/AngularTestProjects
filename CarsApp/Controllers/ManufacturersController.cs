using System.Collections.Generic;
using System.Threading.Tasks;
using CarsApp.Data;
using CarsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarsApp.Controllers
{
    public class ManufacturersController : Controller
    {
        private readonly AppDbContext _context;

        public ManufacturersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("/api/manufacturers")]
        public async Task<IEnumerable<Manufacturer>> GetManufacturers()
        {
            return await _context.Manufacturers.Include(m => m.Models).ToListAsync();
        }
    }
}