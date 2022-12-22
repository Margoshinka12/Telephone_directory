using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class OperForm : Form
    {
        public OperForm()
        {
            InitializeComponent();
        }
        public Oper Op = null;


        public void WriteInForm()
        {
            textBox1.Text = Op.OperName;
            comboBox1.Text = Op.Mobile.ToString();

            comboBox2.Text = Op.Mvno.ToString();
            textBox4.Text = Op.CountryId.ToString();
            textBox3.Text = Op.Mnc.ToString();
            textBox6.Text = Op.Brand;
            textBox8.Text = Op.Url;
            textBox7.Text = Op.OperId.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Op = new Oper
                {
                    OperName = textBox1.Text,
                    Mobile = int.Parse(comboBox1.Text),
                    Mvno = int.Parse(comboBox2.Text),
                    CountryId = int.Parse(textBox4.Text),
                    Mnc = int.Parse(textBox3.Text),
                    Brand = textBox6.Text,
                    Url = textBox8.Text,
                    OperId = int.Parse(textBox7.Text)

                };
                Close();
            }
            catch
            {
                MessageBox.Show("Вы заполнили не все поля");
                Close();

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class Oper
    {
        public string OperName;
        public int Mobile;

        public int Mvno;
        public int CountryId;
        public int Mnc;
        public string Brand;
        public string Url;
        public int OperId;
        public Oper(string operName,
            int mobile,

         int mvno,
         int countryId, int mnc,
         string brand, string url, int operId
            )

        {
            this.OperName = operName;
            this.Mobile = mobile;
            this.Mvno = mvno;
            this.CountryId = countryId;
            this.Mnc = mnc;
            this.Brand = brand;
            this.Url = url;
            this.OperId = operId;

        }

        public Oper()
        {
            this.OperName = "";
            this.Mobile = 0;
            this.Mvno = 0;
            this.CountryId = 0;
            this.Mnc = 0;
            this.Brand = "";
            this.Url = "";
            this.OperId = 0;
        }
    }
}
