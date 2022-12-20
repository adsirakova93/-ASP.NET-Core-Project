using System.ComponentModel.DataAnnotations;
using static SuperDoc.Data.DataConstants.MedicalCenterType;

namespace SuperDoc.Areas.Admin.Models.MedicalCenterTypes
{
    public class TypeFormModel
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; init; }
    }
}
