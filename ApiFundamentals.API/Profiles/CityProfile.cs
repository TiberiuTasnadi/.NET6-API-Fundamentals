using AutoMapper;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ApiFundamentals.API.Profiles
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<Entities.City, Model.CityWithoutPointsOfInterestDto>();
        }
    }
}
