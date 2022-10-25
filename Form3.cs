using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{   public class City
    {   public string CityName;
        
        public int NumberOfDistricts;
        public  int TimeZone;
        public int Latitude;
        public int Longitude;

        public City(string cityName,
            string countryName,
            int numberOfDistricts,
            int timeZone,
            int latitude,
            int longitude)
        {
            this.CityName = cityName;

            
            this.NumberOfDistricts = numberOfDistricts;
            this.TimeZone = timeZone;
            this.Latitude = latitude;
            this.Longitude= longitude;
        }

        public City()
        {
            this.CityName = "";

           
            this.NumberOfDistricts = -1;
            this.TimeZone = -1;
            this.Latitude = 0;
            this.Longitude= 0;
        }
    }
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public City C;
        
       

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            C = new City
            {
              CityName = textBox1.Text,
                  NumberOfDistricts = int.Parse(textBox2.Text),
                  TimeZone = int.Parse(textBox3.Text),
                  Latitude = int.Parse(textBox5.Text),
                  Longitude = int.Parse(textBox4.Text),
            };
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;
                        
            if (!char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
             var number = e.KeyChar;
                                    
                                    if (!char.IsDigit(number))
                                    {
                                        e.Handled = true;
                                    }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;
                        
            if (!char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;
                        
            if (!char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}