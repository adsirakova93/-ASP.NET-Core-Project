using BeautyZone.Services.MedicalCenters.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static BeautyZone.Data.DataConstants.City;

namespace BeautyZone.Areas.Admin.Models.Cities
{
    public class CityFormModel
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; init; }

        [Display(Name = "Country")]
        public int CountryId { get; init; }

        public IEnumerable<CountryServiceModel> Countries;
    }
}
