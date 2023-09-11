using AutoMapper;

namespace ApiFundamentals.API.Profiles
{
    public class PointOfInterestProfile : Profile
    {
        public PointOfInterestProfile()
        {
            CreateMap<Entities.PointOfInterest, Model.PointOfInterestDto>();
            CreateMap<Model.PointOfInterestCreateDto, Entities.PointOfInterest>();
            CreateMap<Model.PointOfInterestUpdateDto, Entities.PointOfInterest>();
            CreateMap<Entities.PointOfInterest, Model.PointOfInterestUpdateDto>();
        }
    }
}
