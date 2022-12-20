using BeautyZone.Data;
using BeautyZone.Data.Models;
using System.Linq;

namespace BeautyZone.Areas.Admin.Services.Specialities
{
    public class SpecialityService : ISpecialityService
    {
        private readonly BeautyZoneDbContext data;

        public SpecialityService(BeautyZoneDbContext data)
        {
            this.data = data;
        }

        public void Add(string name)
        {
            var speciality = new PhysicianSpeciality
            {
                Name = name
            };

            this.data.PhysicianSpecialities.Add(speciality);
            this.data.SaveChanges();
        }

        public bool IsExisting(string name)
            => this.data
                .PhysicianSpecialities
                .Any(s => s.Name == name);
    }
}
