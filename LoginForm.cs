using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public string Login
        {
            get { return textBox1.Text; }

        }

        public string Password
        {
            get { return textBox2.Text; }

        }
        static bool Adminka = false;
        static bool Result = false;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
          
                if (!Regex.IsMatch(textBox2.Text, "^[a-zA-Z0-9]*$") || textBox2.Text.Length <8)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;

                    
                }
            else { 
                button1.Enabled = true;
                button2.Enabled = true;
                label3.Visible = false;
            }
        }
       

       

       
        private void button1_Click(object sender, EventArgs e)
        {
           

            

          
                // frm = new LoginForm();
                
                    Result = LogIn(Login, Password);
                    MessageBox.Show(Result ?
                    "Успешно" : "Неуспешно");
            if (Result)
            {
                this.Visible = false;
                var f2 = new MainForm();
                f2.ShowDialog();
                this.Visible = true;
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox1.Text, "^[a-zA-Z0-9]*$") || textBox2.Text.Length < 8)
            {
                button1.Enabled = false;
                button2.Enabled = false;


            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
                label3.Visible = false;
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }
        private static bool LogIn(string login, string password)
        {
            var hash = GetHash(password);

            using (var cn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {



                cn.Open();

                var cmd = new SqlCommand(@"select password, adminka, salt from Users 
                    where login=@Login", cn);

                cmd.Parameters.AddWithValue("@Login", login);
                string pwd, salt;


                var result = cmd.ExecuteScalar();
                if (result == null) return false;
                else 
                {
                    var dr = cmd.ExecuteReader();
                    dr.Read();
                    Adminka = (bool)dr["adminka"];
                     pwd = (string)dr["password"];
                     salt = (string)dr["salt"];
                    dr.Close();
                }
                return pwd ==GetHash(password+salt); }

        }
        private static bool Registration(string login, string password)
        {
            var salt = GenerateSalt();
            var hash = GetHash(password+salt);

            using (var cn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {



                cn.Open();

                var cmd = new SqlCommand(@"select count(*) from Users 
                    where login=@Login", cn);

                cmd.Parameters.AddWithValue("@Login", login);
                
                var result = (int)cmd.ExecuteScalar();
                if (result ==1) return false;
                cmd = new SqlCommand(@"INSERT INTO Users VALUES (@Login, @Password, @Adminka, @Date, @Salt)", cn);
                cmd.Parameters.AddWithValue("@Login", login);
                cmd.Parameters.AddWithValue("@Password", hash);
                cmd.Parameters.AddWithValue("@Adminka", 0);
                cmd.Parameters.AddWithValue("@Date", DateTime.Today);
                cmd.Parameters.AddWithValue("@Salt", salt);
                cmd.ExecuteNonQuery();

                return true;
            }

        }

        private static string GetHash(string password)
        {
            var sha1 = new SHA1Managed();
            var hash = BitConverter.ToString(sha1.ComputeHash
                (Encoding.UTF8.GetBytes(password))).Replace("-", "");
            return hash;
        }
        static string GenerateSalt()
        {
            int saltSize = 20;
            var rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[saltSize];
            rng.GetBytes(buff);
            return BitConverter.ToString(buff).Replace("-", "");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            


            // frm = new LoginForm();

            Result = Registrated(Login, Password);
            MessageBox.Show(Result ?
            "Успешно" : "Неуспешно");
            
            //if (Result) Close();

        }
    }
}
