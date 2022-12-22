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
    public partial class TelcodForm : Form
    {
        public TelcodForm()
        {
            InitializeComponent();
        }
        public Telcod T = null;
        public void WriteInForm()
        {
            textBox1.Text = T.Defto.ToString();

            textBox4.Text = T.Deffrom.ToString();
            textBox3.Text = T.OperId.ToString();

            textBox8.Text = T.CityId.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                T = new Telcod
                {
                    Defto = textBox1.Text,

                    Deffrom = textBox4.Text,
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
    public class Telcod
    {
        public string Deffrom;
        public string Defto;
        public int OperId;

        public int CityId;

        public Telcod(

         string deffrom,string defto,
         int operId, int cityId

            )

        {
            this.Deffrom = deffrom;
            this.Defto = defto;
            this.CityId = cityId;
            this.OperId = operId;


        }

        public Telcod()
        {
            this.Deffrom = "";
            this.Defto = "";
            this.OperId = 0;
            this.CityId = 0;

        }
    }
}
