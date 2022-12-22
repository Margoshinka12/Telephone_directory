using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class PhoneForm : Form
    {
        public PhoneForm()
        {
            InitializeComponent();
        }
        public Phone P = null;
        public void WriteInForm()
        {
           
            textBox4.Text = P.PhoneNumber.ToString();
            textBox3.Text = P.OperId.ToString();
          
            textBox8.Text = P.CityId.ToString();
            
        }
        private void PhoneForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                P = new Phone
                {

                    PhoneNumber = textBox4.Text,
                    OperId = int.Parse(textBox3.Text),


                    CityId = int.Parse(textBox8.Text)

                };
                Close();
            }
            catch
            {
                MessageBox.Show("Вы заполнили не все поля"); Close();
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
    public class Phone
    {
        public string PhoneNumber;
        public int OperId;

        public int CityId;
        
        public Phone(

         string phoneNumber,
         int operId, int cityId
         
            )

        {
            this.PhoneNumber = phoneNumber;
            this.OperId = operId;
            this.CityId = cityId;
            

        }

        public Phone()
        {
            this.PhoneNumber = "";
            this.OperId = 0;
            this.CityId = 0;
            
        }
    }
}
