using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prakt_16_4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            List<Country> countries = new List<Country>();
            string[] lines = File.ReadAllLines("count.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');
                string name = parts[0];
                string populationString = string.Join("", parts.Skip(1));
                long population = long.Parse(populationString.Replace(" ", ""));

                countries.Add(new Country { NameValue = name, PopulationValue = population });
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите минимальную численость населения: ");
            }
            else
            {
                if (int.TryParse(textBox1.Text, out int minPopulation))
                {
                    if (minPopulation >= 1)
                    {
                        listBox1.Items.Clear();
                        var sortedCountries = countries
                            .Where(c => c.PopulationValue > minPopulation)
                            .OrderBy(c => c.NameValue)
                            .OrderBy(c => c.NameValue.Length);
                        foreach (var country in sortedCountries)
                        {
                            listBox1.Items.Add(Convert.ToString(country.NameValue + " " + country.PopulationValue));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите число больше 0");
                    }
                }
                else
                {
                    MessageBox.Show("Вы ввели не число");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
