using System.ComponentModel.DataAnnotations;

namespace ApiFundamentals.API.Model
{
    public class PointOfInterestUpdateDto
    {
        [Required(ErrorMessage = "Field required")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Description { get; set; }
    }
}
