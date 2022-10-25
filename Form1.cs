using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string Cs = @"Data Source = LAPTOP-SETO9IMR\SQLEXPRESS; Initial Catalog = World; Integrated Security = true;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void DownloadFromDb()
        {
            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();
                const string sql = @"SELECT Country.country, City.city, District.district,
                                         Country.id_country , City.id_city, District.id_district
                                         FROM (Country LEFT OUTER JOIN City ON Country.id_country = City.id_country)
                                         LEFT OUTER JOIN District  ON District.id_city= City.id_city
                                         ORDER BY Country.country, Country.id_country, City.city,City.id_city, District.district, District.id_district";
                var cmd = new SqlCommand(sql, cn);

                var dr = cmd.ExecuteReader();
                // while (dr.Read())
                // {
                //     TreeNode n = new TreeNode(dr["country"].ToString(),0,0);
                //     treeView1.Nodes.Add(n);
                //     LoadCities((int)dr["id_country"], n);
                // }
                var lastIdCountry = -1;
                var lastIdCity = -1;
                var lastIdDistrict = -1;
                TreeNode lastAddedCity=null;
                TreeNode lastAddedCountry=null;
                while (dr.Read())
                {
                    var countryName = (string)dr["country"];
                    var idCountry = (int)dr["id_country"];
                    if (idCountry != lastIdCountry)
                    {
                        lastAddedCountry = new TreeNode(countryName, 0, 0);
                            treeView1.Nodes.Add(lastAddedCountry);
                        lastIdCountry = idCountry;
                        lastAddedCountry.Tag = dr["id_country"];
                    }

                    if (dr["city"] is DBNull) continue;
                    var cityName = (string)dr["city"];
                    var idCity = (int)dr["id_city"];

                    if (idCity != lastIdCity)
                    {
                        lastAddedCity = new TreeNode(cityName, 1, 1);
                        lastAddedCountry?.Nodes.Add(lastAddedCity);
                        lastIdCity = idCity;
                        lastAddedCity.Tag = dr["id_city"];
                    }

                    if (dr["district"] is DBNull) continue;
                    var districtName = (string)dr["district"];
                    var idDistrict = (int)dr["id_district"];
                    if (idDistrict == lastIdDistrict) continue;
                    var lastAddedDistrict = new TreeNode(districtName, 2, 2);
                    lastAddedCity?.Nodes.Add(lastAddedDistrict);
                    lastIdDistrict = idDistrict;
                    lastAddedDistrict.Tag = dr["id_district"];

                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {   treeView1.Nodes.Clear();
            DownloadFromDb();

        }

        // void LoadCities(int id_country, TreeNode parent)
        // {
        //     using (SqlConnection cn = new SqlConnection(cs))
        //     {
        //         cn.Open();
        //         var sql = @"SELECT city FROM City WHERE id_Country = @id_country"; 
        //         var cmd = new SqlCommand(sql, cn);
        //         cmd.Parameters.AddWithValue("id_Country", id_country);
        //         var dr = cmd.ExecuteReader();
        //         while (dr.Read())
        //         {
        //             TreeNode n = new TreeNode(dr["city"].ToString(),1,1);
        //             parent.Nodes.Add(n);
        //         }
        //     }
        // }

       

        private void Delete(object sender, EventArgs e)
        {
            switch (treeView1.SelectedNode.Level)
            {
                case 2:
                    DeleteDistrict();
                    break;
                case 1:
                    DeleteCity();
                    break;
                default:
                    DeleteCountry();
                    break;
            }
        }

        private void DeleteDistrict()
        {
            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();
                const string sql = @"delete from District where id_district = @id";
                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);
                cmd.ExecuteNonQuery();
                treeView1.SelectedNode.Remove();
            }
        }
        private void DeleteCity()
        {
            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();
                const string sql = @"delete from City where id_city = @id";
                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);
                cmd.ExecuteNonQuery();
                treeView1.SelectedNode.Remove();
            }
        }
        private void DeleteCountry()
        {
            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();
                const string sql = @"delete from Country where id_country = @id";
                var cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);
                cmd.ExecuteNonQuery();
                treeView1.SelectedNode.Remove();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            switch (treeView1.SelectedNode.Level)
            {
                case 0:
                    удалитьToolStripMenuItem.Enabled = true;
                    добавитьToolStripMenuItem.Enabled = true;
                    добавитьГородToolStripMenuItem.Enabled = true;
                    добавитьToolStripMenuItem1.Enabled = false;
                    break;
                case 1:
                    удалитьToolStripMenuItem.Enabled = true;
                    добавитьГородToolStripMenuItem.Enabled = false;
                    добавитьToolStripMenuItem.Enabled = false;
                    добавитьToolStripMenuItem1.Enabled = true;
                    break;
                case 2:
                    удалитьToolStripMenuItem.Enabled = true;
                    добавитьГородToolStripMenuItem.Enabled = false;
                    добавитьToolStripMenuItem.Enabled = false;
                    добавитьToolStripMenuItem1.Enabled = false;
                    break;
                default:
                    удалитьToolStripMenuItem.Enabled = false;
                    добавитьГородToolStripMenuItem.Enabled = false;
                    добавитьToolStripMenuItem.Enabled = false;
                    добавитьToolStripMenuItem1.Enabled = false;
                    break;
            }
        }
        



private void InsertDistrict()
{
    var form = new Form4();
    form.ShowDialog();
    District district = null;
    if (form.DialogResult == DialogResult.OK)
    {
        district = form.D;
    }

    using (var cn = new SqlConnection(Cs))
    {
        cn.Open();



        var sql = @"INSERT INTO District VALUES  (@name, @id)";
        var cmd = new SqlCommand(sql, cn);
        if (district == null) return;
        cmd.Parameters.AddWithValue("@name", district.DistrictName);
        cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);

        cmd.ExecuteNonQuery();
        sql = @"SELECT id_district FROM District WHERE district = @name";
        cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@name", district.DistrictName);
        var dr = cmd.ExecuteReader();
        dr.Read();
        var districtId = (int)dr["id_district"];
        dr.Close();
        var newDistrict = new TreeNode(district.DistrictName, 2, 2)
        {
            Tag = districtId
        };
        treeView1.SelectedNode.Nodes.Add(newDistrict);
    }
}

private void InsertCity()
        {   var form = new Form3();
            form.ShowDialog();
            City city = null;
            if (form.DialogResult == DialogResult.OK)
            {
                city = form.C;
            }

            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();
                
               
                
                var sql = @"INSERT INTO City VALUES  (@name, @id, @num, @tz, @lat, @long)";
                var cmd = new SqlCommand(sql, cn);
                if (city == null) return;
                cmd.Parameters.AddWithValue("@name", city.CityName);
                cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);
                cmd.Parameters.AddWithValue("@num", city.NumberOfDistricts);
                cmd.Parameters.AddWithValue("@tz", city.TimeZone);
                cmd.Parameters.AddWithValue("@lat", city.Latitude);
                cmd.Parameters.AddWithValue("@long", city.Longitude);
                cmd.ExecuteNonQuery();
                sql = @"SELECT id_city FROM City WHERE city = @name";
                cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@name", city.CityName);
                var dr = cmd.ExecuteReader();
                dr.Read();
                
                var cityId = (int)dr["id_city"];
                dr.Close();
                var newCity = new TreeNode(city.CityName, 1, 1)
                {
                    Tag = cityId
                };

                treeView1.SelectedNode.Nodes.Add(newCity);
            }
        }
        private void InsertCountry()
        { var form = new Form2();
            form.ShowDialog();
            Country country = null;
            if (form.DialogResult == DialogResult.OK)
            {
                country = form.Cnt;
            }
            using (SqlConnection cn = new SqlConnection(Cs))
            {
                cn.Open();
                var sql = @"INSERT INTO Country VALUES  (@name, @location)";
                var cmd = new SqlCommand(sql, cn);
                if (country == null) return;
                cmd.Parameters.AddWithValue("@name", country.CountryName);
                cmd.Parameters.AddWithValue("@location", country.Location);
                cmd.ExecuteNonQuery();
                
                sql = @"SELECT id_country FROM Country WHERE country = @name";
                cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@name", country.CountryName);
                var dr = cmd.ExecuteReader();
                dr.Read();
                var countryId = (int)dr["id_country"];
                dr.Close();
                var newCountry = new TreeNode(country.CountryName, 0, 0)
                {
                    Tag = countryId
                };
                treeView1.Nodes.Add(newCountry);
            }
        }

        private void InsertTheCountry(object sender, EventArgs e)
        {    InsertCountry();
            
        }

        private void InsertTheCity(object sender, EventArgs e)
        {
            InsertCity();
        }

        private void InsertTheDistrict(object sender, EventArgs e)
        {
            InsertDistrict();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }
    }
}
    