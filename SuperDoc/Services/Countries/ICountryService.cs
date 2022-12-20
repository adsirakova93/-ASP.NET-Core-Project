using SuperDoc.Services.MedicalCenters.Models;
using System.Collections.Generic;

namespace SuperDoc.Services.Coutries
{
    public interface ICountryService
    {
        IEnumerable<CountryServiceModel> GetCountries();

        IEnumerable<string> AllCountries();

        void Add(string name, string alpha3Code);

        bool IsExisting(string name);
    }
}
