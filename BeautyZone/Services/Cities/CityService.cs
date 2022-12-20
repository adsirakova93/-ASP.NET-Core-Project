﻿using BeautyZone.Data;
using BeautyZone.Data.Models;
using BeautyZone.Services.MedicalCenters.Models;
using System.Collections.Generic;
using System.Linq;

namespace BeautyZone.Services.Cities
{
    public class CityService : ICityService
    {
        private readonly BeautyZoneDbContext data;

        public CityService(BeautyZoneDbContext data)
        {
            this.data = data;
        }

        public IEnumerable<CityServiceModel> GetCities()
            => this.data
                .Cities
                .Select(c => new CityServiceModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    CountryId = c.CountryId
                })
                .ToList();

        public bool IsCityInCountry(int countryId, int cityId)
            => this.data
                .Cities
                .Any(c => c.Id == cityId && c.CountryId == countryId);

        public IEnumerable<string> AllCities()
            => this.data
                .Cities
                .Select(ps => ps.Name)
                .Distinct()
                .OrderBy(name => name)
                .ToList();

        public void Add(string name, int countryId)
        {
            var city = new City
            {
                Name = name,
                CountryId = countryId
            };

            this.data.Cities.Add(city);
            this.data.SaveChanges();
        }

        public bool IsExisting(string name)
            => this.data
                .Cities
                .Any(c => c.Name == name);
    }
}
