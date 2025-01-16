using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WorldSOAP.entities;
using WorldSOAP.db;

namespace WorldSOAP
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        
        [WebMethod]
        public List<City> getAllCities()
        {
            CityRepository cityRepository = new CityRepository();
            return cityRepository.getAllCities();
        }

        [WebMethod]
        public List<Country> getAllCountries()
        {
            CountryRepository countryRepository = new CountryRepository();
            return countryRepository.getAllCountries();
        }

        [WebMethod]
        public Country getCountryByCode(string code)
        {
            CountryRepository countryRepository = new CountryRepository();
            return countryRepository.getCountryByCode(code);
        }

        [WebMethod]
        public List<City> getCityByName(string name)
        {
            CityRepository cityRepository = new CityRepository();
            return cityRepository.getCityByName(name);
        }

        [WebMethod]
        public List<City> getCitiesByCountryCode(string name)
        {
            CityRepository cityRepository = new CityRepository();
            return cityRepository.getCitiesByCountryCode(name);
        }
    }
}
