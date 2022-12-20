using System.ComponentModel.DataAnnotations;
using static BeautyZone.Data.DataConstants.Speciality;

namespace BeautyZone.Areas.Admin.Models.Specialities
{
    public class SpecialityFormModel
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; init; }
    }
}
