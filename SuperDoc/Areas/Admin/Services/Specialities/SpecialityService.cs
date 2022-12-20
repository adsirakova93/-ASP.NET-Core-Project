using SuperDoc.Data;
using SuperDoc.Data.Models;
using System.Linq;

namespace SuperDoc.Areas.Admin.Services.Specialities
{
    public class SpecialityService : ISpecialityService
    {
        private readonly SuperDocDbContext data;

        public SpecialityService(SuperDocDbContext data)
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
