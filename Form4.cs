using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{public class District
    {   public string DistrictName;
        
       

        public District(string districtName
            )
        {
            this.DistrictName = districtName;

            
            
        }

        public District()
        {
            this.DistrictName = "";
        }
    }
    public partial class Form4 : Form
    {
        public District D;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            D = new District()
            {
                DistrictName = textBox1.Text
            };
        }
    }
}