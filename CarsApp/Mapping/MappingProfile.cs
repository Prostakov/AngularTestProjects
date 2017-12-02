using AutoMapper;
using CarsApp.Models;
using CarsApp.ResourceModels;

namespace CarsApp.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Manufacturer, ManufacturerResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();            
        }
    }
}