using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                CountryName = textBox1.Text,
               
                Iso = int.Parse(textBox5.Text),
                Telcod = int.Parse(textBox4.Text),
                Capital = textBox3.Text
                };
                Close();
            
            }
        public void WriteInForm()
        {
            textBox1.Text = Cnt.CountryName;
            textBox2.Text = Cnt.Location;
            
            textBox5.Text = Cnt.Iso.ToString();
            textBox4.Text = Cnt.Telcod.ToString();
            textBox3.Text = Cnt.Capital;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class Country
    {
        public string CountryName;
        public string Location;
       
        public int Iso;
        public int Telcod;
        public string Capital;

        public Country(string countryName,
            string location,
          
         int iso,
         int telcod,
         string capital
            )

        {
            this.Location = location;
            this.CountryName = countryName;
            
            this.Iso = iso;
            this.Telcod = telcod;
            this.Capital = capital;

        }

        public Country()
        {
            this.Location = "";
            this.CountryName = "";
            this.Iso = 0;
            this.Telcod = 0;
            this.Capital = "";
        }
    }

}