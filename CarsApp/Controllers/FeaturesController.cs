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
    public class FeaturesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public FeaturesController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureResource>> GetFeatures() 
        {
            var features = await _context.Features.ToListAsync();

            return _mapper.Map<List<Feature>, List<FeatureResource>>(features);
        }
    }
}