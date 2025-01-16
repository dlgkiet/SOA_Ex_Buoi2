using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WorldSOAP.entities;

namespace WorldSOAP.db
{
    public class CityRepository
    {
        private SqlConnection connection;

        public CityRepository()
        {
            connection = ConnectDB.getInstance();
        }

        public List<City> getAllCities()
        {
            connection.Open();
            string sql = "SELECT * FROM City";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader rdr = cmd.ExecuteReader();

            List<City> cities = new List<City>();
            while (rdr.Read())
            {
                City city = new City(
                    int.Parse(rdr["Id"].ToString()),
                    rdr["Name"].ToString(),
                    rdr["CountryCode"].ToString(),
                    rdr["District"].ToString(),
                    int.Parse(rdr["Population"].ToString())
                );
                cities.Add(city);
            }

            rdr.Close();
            connection.Close();
            return cities;
        }

        public List<City> getCityByName(string name)
        {
            List<City> cities = new List<City>();

            try
            {
                connection.Open();
                string sql = "SELECT * FROM city WHERE Name = @Name";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@Name", name);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    City city = new City(
                        int.Parse(rdr["Id"].ToString()),
                        rdr["Name"].ToString(),
                        rdr["CountryCode"].ToString(),
                        rdr["District"].ToString(),
                        int.Parse(rdr["Population"].ToString())
                    );
                    cities.Add(city);
                }
                rdr.Close();
            }
            finally
            {
                connection.Close();
            }

            return cities;
        }

        public List<City> getCitiesByCountryCode(string countryCode)
        {
            List<City> cities = new List<City>();

            try
            {
                connection.Open();
                string sql = "SELECT * FROM city WHERE CountryCode = @CountryCode";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@CountryCode", countryCode);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    City city = new City(
                        int.Parse(rdr["Id"].ToString()),
                        rdr["Name"].ToString(),
                        rdr["CountryCode"].ToString(),
                        rdr["District"].ToString(),
                        int.Parse(rdr["Population"].ToString())
                    );
                    cities.Add(city);
                }
                rdr.Close();
            }
            finally
            {
                connection.Close();
            }

            return cities;
        }
    }
}