using ApiFundamentals.API.Model;

namespace ApiFundamentals.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        //public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Lleida",
                    Description = "The one with farms",
                    PointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Point of interest 1",
                            Description = "Description Point of interest 1"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Point of interest 2",
                            Description = "Description Point of interest 2"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Tarragona",
                    Description = "The one with beaches",
                    PointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Point of interest 3",
                            Description = "Description Point of interest 3"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Point of interest 4",
                            Description = "Description Point of interest 4"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Girona",
                    Description = "The one with mountains",
                    PointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Point of interest 5",
                            Description = "Description Point of interest 5"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "Point of interest 6",
                            Description = "Description Point of interest 6"
                        }
                    }
                }
            };
        }
    }
}
