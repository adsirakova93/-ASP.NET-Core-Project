using System.ComponentModel.DataAnnotations;
using static BeautyZone.Data.DataConstants.County;

namespace BeautyZone.Areas.Admin.Models.Countries
{
    public class CountryFormModel
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; init; }

        [Required]
        [StringLength(Alpha3CodeMaxLength, MinimumLength = Alpha3CodeMinLength)]
        [Display(Name = "Alpha-3 Code")]
        public string Alpha3Code { get; init; }
    }
}
