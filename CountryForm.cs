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
            try
            {
                Cnt = new Country
                {
                    Id = int.Parse(textBox6.Text),
                    Location = textBox2.Text,
                    CountryName = textBox1.Text,

                    Iso = int.Parse(textBox5.Text),
                    Telcod = int.Parse(textBox4.Text),
                    Capital = textBox3.Text
                };
                Close();
            }
            catch
            {
                MessageBox.Show("Вы заполнили не все поля");
                Close();

            }
        }
        public void WriteInForm()
        {
            textBox1.Text = Cnt.CountryName;
            textBox2.Text = Cnt.Location;
            textBox6.Text = Cnt.Id.ToString();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    public class Country
    {
        public string CountryName;
        public string Location;
        public int Id;
        public int Iso;
        public int Telcod;
        public string Capital;

        public Country(string countryName,
            string location,
          int id,
         int iso,
         int telcod,
         string capital
            )

        {
            this.Location = location;
            this.CountryName = countryName;
            this.Id = id;
            this.Iso = iso;
            this.Telcod = telcod;
            this.Capital = capital;

        }

        public Country()
        {
            this.Id = 0;
            this.Location = "";
            this.CountryName = "";
            this.Iso = 0;
            this.Telcod = 0;
            this.Capital = "";
        }
    }

}