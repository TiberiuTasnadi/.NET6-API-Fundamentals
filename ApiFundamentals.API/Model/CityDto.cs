namespace ApiFundamentals.API.Model
{
    /// <summary>
    /// Dto
    /// </summary>
    public class CityDto
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// decription
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// number of points of interest
        /// </summary>

        public int NumberOfPointsOfInterest
        {
            get
            {
                return PointOfInterest.Count;
            }
        }

        /// <summary>
        /// list of points of interest
        /// </summary>
        public ICollection<PointOfInterestDto> PointOfInterest { get; set; }
            = new List<PointOfInterestDto>();
    }
}
