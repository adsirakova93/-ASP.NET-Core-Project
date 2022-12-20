using BeautyZone.Data;
using BeautyZone.Data.Models;
using BeautyZone.Services.MedicalCenters.Models;
using System.Collections.Generic;
using System.Linq;

namespace BeautyZone.Services.Coutries
{
    public class CountryService : ICountryService
    {
        private readonly BeautyZoneDbContext data;

        public CountryService(BeautyZoneDbContext data)
        {
            this.data = data;
        }

        public IEnumerable<CountryServiceModel> GetCountries()
            => this.data
                .Countries
                .Select(c => new CountryServiceModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToList();

        public IEnumerable<string> AllCountries()
            => this.data
                .Countries
                .Select(ps => ps.Name)
                .Distinct()
                .OrderBy(name => name)
                .ToList();

        public void Add(string name, string alpha3Code)
        {
            var country = new Country
            {
                Name = name,
                Alpha3Code = alpha3Code
            };

            this.data.Countries.Add(country);
            this.data.SaveChanges();
        }

        public bool IsExisting(string name)
            => this.data
                .Countries
                .Any(c => c.Name == name);
    }
}
