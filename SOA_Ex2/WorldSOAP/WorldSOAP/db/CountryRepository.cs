using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WorldSOAP.entities;

namespace WorldSOAP.db
{
    public class CountryRepository
    {
        private SqlConnection connection;

        public CountryRepository()
        {
            connection = ConnectDB.getInstance();
        }

        public List<Country> getAllCountries()
        {
            connection.Open();
            string sql = "SELECT * FROM country";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader rdr = cmd.ExecuteReader();

            List<Country> countries = new List<Country>();
            while (rdr.Read())
            {
                Country country = new Country(
                    rdr["Code"].ToString(),
                    rdr["Name"].ToString(),
                    rdr["Continent"].ToString(),
                    rdr["Region"].ToString(),
                    decimal.Parse(rdr["SurfaceArea"].ToString()),
                    rdr["IndepYear"] as short?,
                    int.Parse(rdr["Population"].ToString()),
                    rdr["LifeExpectancy"] as decimal?,
                    rdr["GNP"] as decimal?,
                    rdr["GNPOld"] as decimal?,
                    rdr["LocalName"].ToString(),
                    rdr["GovernmentForm"].ToString(),
                    rdr["HeadOfState"]?.ToString(),
                    rdr["Capital"] as int?,
                    rdr["Code2"].ToString()
                );
                countries.Add(country);
            }

            rdr.Close();
            connection.Close();
            return countries;
        }
        public Country getCountryByCode(string code)
        {
            Country country = null;

            try
            {
                connection.Open();
                string sql = "SELECT * FROM country WHERE Code = @Code";
                SqlCommand cmd = new SqlCommand(sql, connection);

                // Thêm tham số @Code với giá trị truyền vào
                cmd.Parameters.AddWithValue("@Code", code);

                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read()) // Kiểm tra nếu có bản ghi trả về
                {
                    country = new Country(
                        rdr["Code"].ToString(),
                        rdr["Name"].ToString(),
                        rdr["Continent"].ToString(),
                        rdr["Region"].ToString(),
                        decimal.Parse(rdr["SurfaceArea"].ToString()),
                        rdr["IndepYear"] != DBNull.Value ? (short?)Convert.ToInt16(rdr["IndepYear"]) : null,
                        int.Parse(rdr["Population"].ToString()),
                        rdr["LifeExpectancy"] != DBNull.Value ? (decimal?)Convert.ToDecimal(rdr["LifeExpectancy"]) : null,
                        rdr["GNP"] != DBNull.Value ? (decimal?)Convert.ToDecimal(rdr["GNP"]) : null,
                        rdr["GNPOld"] != DBNull.Value ? (decimal?)Convert.ToDecimal(rdr["GNPOld"]) : null,
                        rdr["LocalName"].ToString(),
                        rdr["GovernmentForm"].ToString(),
                        rdr["HeadOfState"]?.ToString(),
                        rdr["Capital"] != DBNull.Value ? (int?)Convert.ToInt32(rdr["Capital"]) : null,
                        rdr["Code2"].ToString()
                    );
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                // Log lỗi (nếu cần)
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return country; // Nếu không tìm thấy, country sẽ là null
        }
    }
}