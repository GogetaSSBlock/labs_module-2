using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _144
{
    public partial class Form1 : Form
    {
        private List<Country> countries = new List<Country>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Налаштовуємо властивості ListView
            listView.View = View.Details;
            listView.FullRowSelect = true;

            // Додаємо колонки
            listView.Columns.Add("Країна", 150);
            listView.Columns.Add("Столиця", 150);

            // Заповнюємо список країн
            countries.Add(new Country("Україна", "Київ"));
            countries.Add(new Country("США", "Вашингтон"));
            countries.Add(new Country("Франція", "Париж"));

            // Відображаємо країни у ListView
            RefreshListView();
        }

        private void RefreshListView()
        {
            
            listView.Items.Clear();

            
            var filteredCountries = countries.Where(c =>
                c.Name.ToLower().Contains(filterTextBox.Text.ToLower()) ||
                c.Capital.ToLower().Contains(filterTextBox.Text.ToLower()));

            
            foreach (var country in filteredCountries)
            {
                var item = new ListViewItem(new[] { country.Name, country.Capital });
                listView.Items.Add(item);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            var countryName = countryTextBox.Text;
            var capitalName = capitalTextBox.Text;
            countries.Add(new Country(countryName, capitalName));

            
            RefreshListView();

            
            countryTextBox.Clear();
            capitalTextBox.Clear();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            
            if (listView.SelectedItems.Count > 0)
            {
                var selectedCountry = listView.SelectedItems[0].Text;
                var countryToRemove = countries.FirstOrDefault(c => c.Name == selectedCountry);
                if (countryToRemove != null)
                {
                    countries.Remove(countryToRemove);
                    RefreshListView();
                }
            }
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            
            RefreshListView();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void countryTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void capitalTextBox_TextChanged(Object sender, EventArgs e)
        {

        }
    }


    public class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }

        public Country(string name, string capital)
        {
            Name = name;
            Capital = capital;
        }
    }
}
