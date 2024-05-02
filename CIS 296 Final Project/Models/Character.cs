using System.ComponentModel.DataAnnotations;

namespace CIS_296_Final_Project.Models
{
    public class Character
    {
        public int CharacterId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1991, 2024, ErrorMessage = "Year must be after 1991, but not after the current year.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter an origin.")]
        public string? Origin { get; set; }

        [Required(ErrorMessage = "Please enter an origin type.")]
        public string? OgTypeId { get; set; }
        public OgType? OgType { get; set; }

        public string Slug => Name?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();
    }
}
