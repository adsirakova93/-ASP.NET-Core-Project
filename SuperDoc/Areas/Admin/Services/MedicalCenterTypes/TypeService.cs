using SuperDoc.Data;
using SuperDoc.Data.Models;
using System.Linq;

namespace SuperDoc.Areas.Admin.Services.MedicalCenterTypes
{
    public class TypeService : ITypeService
    {
        private readonly SuperDocDbContext data;

        public TypeService(SuperDocDbContext data)
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
