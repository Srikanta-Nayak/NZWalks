using System.ComponentModel.DataAnnotations;

namespace NZWalksAPI.Models.DTO
{
    public class AddRegionRequestDto
    {
        [Required]
        [MinLength(3,ErrorMessage ="Code has to be a minimun 3 characters")]
        [MaxLength(3, ErrorMessage = "Code has to be a maximum 3 characters")]
        public string Code { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Name has to be a maximum 100 characters")]
        public string Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
