using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DistrictForm : Form
    {
        public District D;
        public DistrictForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            D = new District()
            {
                DistrictName = textBox1.Text,
                Id = int.Parse(textBox2.Text)
            };
        }
        public void WriteInForm()
        {
            textBox1.Text = D.DistrictName;
            textBox2.Text = D.Id.ToString();
        }
    }
    public class District
    {
        public string DistrictName;
        public int Id;


        public District(string districtName, int id
            )
        {
            this.DistrictName = districtName;
            this.Id = id;

        }

        public District()
        {
            this.DistrictName = "";
            this.Id = 0;        }
    }
}