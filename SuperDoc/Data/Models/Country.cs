using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static SuperDoc.Data.DataConstants.County;

namespace SuperDoc.Data.Models
{
    public class Country
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; init; }

        [Required]
        [MaxLength(Alpha3CodeMaxLength)]
        public string Alpha3Code { get; init; }

        public IEnumerable<City> Cities { get; init; } = new List<City>();

        public IEnumerable<MedicalCenter> MedicalCenters { get; init; } = new List<MedicalCenter>();
    }
}
