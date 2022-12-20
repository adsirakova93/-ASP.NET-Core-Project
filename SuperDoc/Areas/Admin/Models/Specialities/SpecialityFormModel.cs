using System.ComponentModel.DataAnnotations;
using static SuperDoc.Data.DataConstants.Speciality;

namespace SuperDoc.Areas.Admin.Models.Specialities
{
    public class SpecialityFormModel
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; init; }
    }
}
