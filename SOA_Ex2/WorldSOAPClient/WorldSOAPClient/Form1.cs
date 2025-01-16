using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldSOAPClient.localhost;

namespace WorldSOAPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetAllCountries_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.WebService1 service = new localhost.WebService1();
                var contries = service.getAllCities();
                dataGridView1.DataSource = contries;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetCountryByCode_Click(object sender, EventArgs e)
        {
            try
            {
                string countryCode = txtCountryCode.Text.Trim();

                if (string.IsNullOrEmpty(countryCode))
                {
                    MessageBox.Show("Please enter a country code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                localhost.WebService1 service = new localhost.WebService1();
                var country = service.getCountryByCode(countryCode);

                if (country != null)
                {
                    dataGridView1.DataSource = new List<Country> { country };
                }
                else
                {
                    MessageBox.Show("Country not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetCityByName_Click(object sender, EventArgs e)
        {
            try
            {
                string cityName = txtCityName.Text.Trim(); // Lấy tên thành phố từ textbox

                if (string.IsNullOrEmpty(cityName))
                {
                    MessageBox.Show("Please enter a city name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                localhost.WebService1 service = new localhost.WebService1();
                var city = service.getCityByName(cityName); // Gọi WebService để lấy thông tin thành phố theo tên

                if (city != null)
                {
                    dataGridView1.DataSource = city; // Hiển thị thông tin thành phố trong DataGridView
                }
                else
                {
                    MessageBox.Show("City not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetCitiesByCountry_Click(object sender, EventArgs e)
        {
            try
            {
                string countryCode = txtCountryCodeForCities.Text.Trim();

                if (string.IsNullOrEmpty(countryCode))
                {
                    MessageBox.Show("Please enter a country code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                localhost.WebService1 service = new localhost.WebService1(); // Khởi tạo Web Service
                var cities = service.getCitiesByCountryCode(countryCode); // Gọi phương thức GetCitiesByCountry

                if (cities != null && cities.Count() > 0)
                {
                    dataGridView1.DataSource = cities; // Hiển thị danh sách thành phố trong DataGridView
                }
                else
                {
                    MessageBox.Show("No cities found for this country.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetAllCities_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.WebService1 service = new localhost.WebService1();
                var cities = service.getAllCities(); // Gọi WebService lấy tất cả các thành phố

                if (cities != null)
                {
                    dataGridView1.DataSource = cities; // Hiển thị danh sách thành phố trong DataGridView
                }
                else
                {
                    MessageBox.Show("No cities found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
