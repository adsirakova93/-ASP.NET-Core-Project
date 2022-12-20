using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static BeautyZone.Data.DataConstants.Speciality;

namespace BeautyZone.Data.Models
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
