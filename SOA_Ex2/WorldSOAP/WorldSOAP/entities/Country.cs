using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldSOAP.entities
{
    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public string Region { get; set; }
        public decimal SurfaceArea { get; set; }
        public short? IndepYear { get; set; }
        public int Population { get; set; }
        public decimal? LifeExpectancy { get; set; }
        public decimal? GNP { get; set; }
        public decimal? GNPOld { get; set; }
        public string LocalName { get; set; }
        public string GovernmentForm { get; set; }
        public string HeadOfState { get; set; }
        public int? Capital { get; set; }
        public string Code2 { get; set; }

        public Country() { }

        public Country(string code, string name, string continent, string region, decimal surfaceArea, short? indepYear, int population,
                       decimal? lifeExpectancy, decimal? gnp, decimal? gnpOld, string localName, string governmentForm, string headOfState,
                       int? capital, string code2)
        {
            Code = code;
            Name = name;
            Continent = continent;
            Region = region;
            SurfaceArea = surfaceArea;
            IndepYear = indepYear;
            Population = population;
            LifeExpectancy = lifeExpectancy;
            GNP = gnp;
            GNPOld = gnpOld;
            LocalName = localName;
            GovernmentForm = governmentForm;
            HeadOfState = headOfState;
            Capital = capital;
            Code2 = code2;
        }

        public override string ToString()
        {
            return $"{Name} ({Code})";
        }
    }
}