using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using ConvertTempClient.localhost;

namespace ConvertTempClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFtoC_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.TemperatureService service = new localhost.TemperatureService();
                if (!double.TryParse(txtInput.Text, out double fahrenheit))
                {
                    MessageBox.Show("Please enter a valid number!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double celsius = service.FahrenheitToCelsius(fahrenheit);
                txtResult.Text = $"{fahrenheit}°F = {celsius:F2}°C";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCtoF_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.TemperatureService service = new localhost.TemperatureService();
                if (!double.TryParse(txtInput.Text, out double celsius))
                {
                    MessageBox.Show("Please enter a valid number!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double fahrenheit = service.CelsiusToFahrenheit(celsius);
                txtResult.Text = $"{celsius}°C = {fahrenheit:F2}°F";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
