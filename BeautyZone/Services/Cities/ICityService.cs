using BeautyZone.Services.MedicalCenters.Models;
using System.Collections.Generic;

namespace BeautyZone.Services.Cities
{
    public interface ICityService
    {
        IEnumerable<CityServiceModel> GetCities();

        bool IsCityInCountry(int countryId, int cityId);

        IEnumerable<string> AllCities();

        void Add(string name, int countryId);

        bool IsExisting(string name);
    }
}
