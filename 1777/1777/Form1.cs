using System;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace _1777
{
    public partial class Form1 : Form
    {
        private const string ApiUrl = "https://www.disify.com/api/email/your@example.com";

        public Form1()
        {
            InitializeComponent();
        }
       
        
        private async void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter an email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool isValid = await ValidateEmailAsync(email);

                if (isValid)
                {
                    MessageBox.Show("Email address is valid.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Email address is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<bool> ValidateEmailAsync(string email)
        {
            using (HttpClient client = new HttpClient())
            {
                var requestData = new { email = email };

                HttpResponseMessage response = await client.PostAsJsonAsync(ApiUrl, requestData);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<ValidationResult>();
                    return result.IsValid;
                }
                else
                {
                    throw new Exception($"Failed to validate email. Status code: {response.StatusCode}");
                }
            }
        }

        private class ValidationResult
        {
            public bool IsValid { get; set; }
            public string Message { get; set; } = "";
        }
    }
}
