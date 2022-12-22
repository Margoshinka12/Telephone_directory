using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{  
    public partial class CityForm : Form
    {
        public CityForm()
        {
            InitializeComponent();
        }
        public City C;
        
       

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                C = new City
                {
                    CityName = textBox1.Text,
                    NumberOfDistricts = int.Parse(textBox2.Text),
                    TimeZone = int.Parse(textBox3.Text),
                    Latitude = float.Parse(textBox5.Text),
                    Longitude = float.Parse(textBox4.Text),
                    Telcod = textBox6.Text,
                    Level = int.Parse(textBox7.Text),
                    Iso = int.Parse(textBox8.Text),
                    Vid = int.Parse(textBox9.Text),
                    Post = textBox10.Text,
                    Id = int.Parse(textBox11.Text)

                };
                Close();
            }
            catch { MessageBox.Show("Вы заполнили не все поля"); Close(); }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;
                        
            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
             var number = e.KeyChar;
                                    
                                    if (!char.IsDigit(number) && number != 8)
                                    {
                                        e.Handled = true;
                                    }
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
        public void WriteInForm()
        {
            textBox1.Text = C.CityName;
            textBox2.Text = C.NumberOfDistricts.ToString();
            textBox3.Text = C.TimeZone.ToString();
            textBox5.Text = C.Latitude.ToString();
            textBox4.Text = C.Longitude.ToString();
            textBox6.Text = C.Telcod.ToString();
            textBox7.Text = C.Level.ToString();
            textBox8.Text = C.Iso.ToString();
            textBox9.Text = C.Vid.ToString();
            textBox10.Text = C.Post.ToString();
            textBox11.Text = C.Id.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
            
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
    public class City
    {
        public string CityName;

        public int NumberOfDistricts;
        public int TimeZone;
        public float Latitude;
        public float Longitude;
        public string Telcod;
        public int Level;
        public int Iso;
        public int Vid;
        public string Post;
        public int Id;

        public City(string cityName,
           
            int numberOfDistricts,
            int timeZone,
            float latitude,
            float longitude,
            string telcod,
        int level,
         int iso,
        int vid,
        string post,
        int id

            )
        {
            this.CityName = cityName;

            this.Id = id;
            this.NumberOfDistricts = numberOfDistricts;
            this.TimeZone = timeZone;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Telcod = telcod;
            this.Level = level;
            this.Iso = iso;
            this.Vid = vid; 
            this.Post = post;   

        }

        public City()
        {
            this.CityName = "";

            this.Id = 0;
            this.NumberOfDistricts = 0;
            this.TimeZone = 0;
            this.Latitude = 0;
            this.Longitude = 0;
            this.Telcod = "";
            this.Level = 0;
            this.Iso = 0;
            this.Vid = 0;
            this.Post = "";
        }
    }
}