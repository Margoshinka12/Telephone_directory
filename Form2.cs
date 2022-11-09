using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        public Country Cnt = null;

            private void button1_Click(object sender, EventArgs e)
            {
                Cnt = new Country
                {
                    Location = textBox2.Text,
                    CountryName = textBox1.Text
                };
                Close();
            
            }
        public void WriteInForm()
        {
            textBox1.Text = Cnt.CountryName;
            textBox2.Text = Cnt.Location;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class Country
    {
        public string CountryName;
        public string Location;

        public Country(string countryName,
            string location)

        {
            this.Location = location;
            this.CountryName = countryName;
        }

        public Country()
        {
            this.Location = "";
            this.CountryName = "";
        }
    }

}