using System.ComponentModel.DataAnnotations;
using static BeautyZone.Data.DataConstants.MedicalCenterType;

namespace BeautyZone.Areas.Admin.Models.MedicalCenterTypes
{
    public class TypeFormModel
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; init; }
    }
}
