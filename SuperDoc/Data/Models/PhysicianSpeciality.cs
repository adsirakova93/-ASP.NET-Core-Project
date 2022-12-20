using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static SuperDoc.Data.DataConstants.Speciality;

namespace SuperDoc.Data.Models
{
    public class PhysicianSpeciality
    {
        public int Id { get; init; }

        [Required]
        [StringLength(NameMaxLength)]
        public string Name { get; init; }

        public IEnumerable<Physician> Physicians { get; init; } = new List<Physician>();
    }
}
