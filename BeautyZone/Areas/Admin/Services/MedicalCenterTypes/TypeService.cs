using BeautyZone.Data;
using BeautyZone.Data.Models;
using System.Linq;

namespace BeautyZone.Areas.Admin.Services.MedicalCenterTypes
{
    public class TypeService : ITypeService
    {
        private readonly BeautyZoneDbContext data;

        public TypeService(BeautyZoneDbContext data)
        {
            this.data = data;
        }

        public void Add(string name)
        {
            var type = new MedicalCenterType
            {
                Name = name
            };

            this.data.MedicalCenterTypes.Add(type);
            this.data.SaveChanges();
        }

        public bool IsExisting(string name)
            => this.data
                .MedicalCenterTypes
                .Any(s => s.Name == name);
    }
}
