using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class AreaForm : Form
    {
        public AreaForm()
        {
            InitializeComponent();
        }
        public Area Ar = null;

       
        public void WriteInForm()
        {
            textBox1.Text = Ar.AreaName;
            textBox2.Text = Ar.Okrug;
            
            textBox5.Text = Ar.Capital;
            textBox4.Text = Ar.Iso.ToString();
            textBox3.Text = Ar.Autocod;
            textBox6.Text = Ar.Id.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Ar = new Area
            {
                Okrug = textBox2.Text,
                AreaName = textBox1.Text,

                Capital = textBox5.Text,
                Iso = int.Parse(textBox4.Text),
                Autocod = textBox3.Text,
                Id = int.Parse(textBox6.Text)
            };
            Close();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            var number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }


        }
    }
    public class Area
    {
        public string AreaName;
        public string Okrug;
        public string Autocod;
        public string Capital;
        public int Iso;
        public int Id;

        public Area(string areaName,
            string okrug,
           string autocod,
         string capital,
         int iso,
            int id
        
            )

        {
            this.AreaName = areaName;
            this.Okrug = okrug;
            this.Autocod = autocod;
            this.Capital = capital;
            this.Iso = iso;
            this.Id = id;
            

        }

        public Area()
        {
            this.AreaName = "";
            this.Okrug = "";
            this.Autocod = "";
            this.Capital = "";
            this.Iso =0;
            this.Id = 0;
        }
    }
}
