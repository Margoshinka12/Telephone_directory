using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private const string Cs = @"Data Source = LAPTOP-SETO9IMR\SQLEXPRESS; Initial Catalog = World; Integrated Security = true;";

        public MainForm()
        {
            InitializeComponent();


        }
        public void OpenLoginForm()
        {
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
            if (lf.DialogResult == DialogResult.Cancel)
            {
                Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "worldDataSet.Oper". При необходимости она может быть перемещена или удалена.
            this.operTableAdapter.Fill(this.worldDataSet.Oper);



        }

        private void DownloadFromDb()
        {
            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();
                const string sql = @"SELECT Country.country,Area.area, City.city, District.district,
                                         Country.id_country , Area.id_area, City.id_city, District.id_district
                                         FROM (Country LEFT JOIN Area ON Area.id_country = Country.id_country
                                          LEFT JOIN City ON City.id_area = Area.id_area LEFT JOIN District ON District.id_city = City.id_city)
                                         ORDER BY Country.country, Country.id_country, Area.area, Area.id_area,City.city,City.id_city, District.district, District.id_district";

                var cmd = new SqlCommand(sql, cn);
                if (cmd == null) return;

                var dr = cmd.ExecuteReader();
                // while (dr.Read())
                // {
                //     TreeNode n = new TreeNode(dr["country"].ToString(),0,0);
                //     treeView1.Nodes.Add(n);
                //     LoadCities((int)dr["id_country"], n);
                // }
                var lastIdCountry = -1;
                var lastIdCity = -1;
                var lastIdArea = -1;
                var lastIdDistrict = -1;
                TreeNode lastAddedCity = null;
                TreeNode lastAddedCountry = null;
                TreeNode lastAddedArea = null;
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
                    if (dr["area"] is DBNull) continue;
                    var areaName = (string)dr["area"];
                    var idArea = (int)dr["id_area"];

                    if (idArea != lastIdArea)
                    {
                        lastAddedArea = new TreeNode(areaName, 1, 1);
                        lastAddedCountry?.Nodes.Add(lastAddedArea);
                        lastIdArea = idArea;
                        lastAddedArea.Tag = dr["id_area"];
                    }
                    if (dr["city"] is DBNull) continue;
                    var cityName = (string)dr["city"];
                    var idCity = (int)dr["id_city"];

                    if (idCity != lastIdCity)
                    {
                        lastAddedCity = new TreeNode(cityName, 2, 2);
                        lastAddedArea?.Nodes.Add(lastAddedCity);
                        lastIdCity = idCity;
                        lastAddedCity.Tag = dr["id_city"];
                    }

                    if (dr["district"] is DBNull) continue;
                    var districtName = (string)dr["district"];
                    var idDistrict = (int)dr["id_district"];
                    if (idDistrict == lastIdDistrict) continue;
                    var lastAddedDistrict = new TreeNode(districtName, 3, 3);
                    lastAddedCity?.Nodes.Add(lastAddedDistrict);
                    lastIdDistrict = idDistrict;
                    lastAddedDistrict.Tag = dr["id_district"];

                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
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
                case 3:
                    DeleteDistrict();
                    break;
                case 2:
                    DeleteCity();
                    break;
                case 1:
                    DeleteArea();
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
        private void DeleteArea()
        {
            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();
                const string sql = @"delete from Area where id_area = @id";
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
        {   if (LoginForm.Adminka == 0)
            {
                добавитьToolStripMenuItem.Enabled = false;
                удалитьToolStripMenuItem.Enabled = false;
                updateToolStripMenuItem.Enabled = false;
                insertTheAreaToolStripMenuItem.Enabled = false;
                добавитьГородToolStripMenuItem.Enabled = false;
                добавитьToolStripMenuItem1.Enabled = false;

            }
            else
            {
                if (treeView1.SelectedNode == null)
                {
                    добавитьToolStripMenuItem.Enabled = true;
                    удалитьToolStripMenuItem.Enabled = false;
                    updateToolStripMenuItem.Enabled = false;
                    insertTheAreaToolStripMenuItem.Enabled = false;
                    добавитьГородToolStripMenuItem.Enabled = false;
                    добавитьToolStripMenuItem1.Enabled = false;
                }
                else
                    switch (treeView1.SelectedNode.Level)
                    {
                        case 0:
                            удалитьToolStripMenuItem.Enabled = true;
                            добавитьToolStripMenuItem.Enabled = true;
                            insertTheAreaToolStripMenuItem.Enabled = true;
                            updateToolStripMenuItem.Enabled = true;
                            добавитьГородToolStripMenuItem.Enabled = false;
                            добавитьToolStripMenuItem1.Enabled = false;
                            break;
                        case 1:
                            удалитьToolStripMenuItem.Enabled = true;
                            insertTheAreaToolStripMenuItem.Enabled = false;
                            добавитьГородToolStripMenuItem.Enabled = true;
                            updateToolStripMenuItem.Enabled = true;
                            добавитьToolStripMenuItem.Enabled = false;
                            добавитьToolStripMenuItem1.Enabled = false;
                            break;
                        case 2:
                            удалитьToolStripMenuItem.Enabled = true;
                            insertTheAreaToolStripMenuItem.Enabled = false;
                            добавитьГородToolStripMenuItem.Enabled = false;
                            updateToolStripMenuItem.Enabled = true;
                            добавитьToolStripMenuItem.Enabled = false;
                            добавитьToolStripMenuItem1.Enabled = true;
                            break;
                        case 3:
                            удалитьToolStripMenuItem.Enabled = true;
                            insertTheAreaToolStripMenuItem.Enabled = false;
                            updateToolStripMenuItem.Enabled = true;
                            добавитьГородToolStripMenuItem.Enabled = false;
                            добавитьToolStripMenuItem.Enabled = false;
                            добавитьToolStripMenuItem1.Enabled = false;
                            break;
                        default:
                            удалитьToolStripMenuItem.Enabled = false;
                            добавитьГородToolStripMenuItem.Enabled = false;
                            добавитьToolStripMenuItem.Enabled = false;
                            updateToolStripMenuItem.Enabled = false;
                            добавитьToolStripMenuItem1.Enabled = false;
                            insertTheAreaToolStripMenuItem.Enabled = false;
                            break;
                    }
            }
        }





        private void InsertDistrict()
        {
            var form = new DistrictForm();
            form.ShowDialog();
            District district = null;
            if (form.DialogResult == DialogResult.OK)
            {
                district = form.D;
            }

            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();

                if (district == null) return;
                if(district.DistrictName == "")
                {
                    MessageBox.Show("Вы заполнили не все поля"); return;
                }

                var sql = @"INSERT INTO District OUTPUT INSERTED.id_district VALUES  (@name, @id)";
                var cmd = new SqlCommand(sql, cn);
                
                cmd.Parameters.AddWithValue("@name", district.DistrictName);
                cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);

               
                var dr = cmd.ExecuteReader();
                dr.Read();
                var districtId = (int)dr["id_district"];
                dr.Close();
                var newDistrict = new TreeNode(district.DistrictName, 3, 3)
                {
                    Tag = districtId
                };
                treeView1.SelectedNode.Nodes.Add(newDistrict);
            }
        }
        private void InsertArea()
        {
            var form = new AreaForm();
            form.ShowDialog();
            Area area = null;
            if (form.DialogResult == DialogResult.OK)
            {
                area = form.Ar;
            }

            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();
                if (area == null) return;
                if (area.AreaName == "" || area.Okrug=="" ||  area.Autocod =="" || area.Capital == "")
                {
                    MessageBox.Show("Вы заполнили не все поля"); return;
                }


                var sql = @"INSERT INTO Area OUTPUT INSERTED.id_area VALUES  (@name, @okrug, @autocod, @capital, @iso, @id)";
                var cmd = new SqlCommand(sql, cn);
                
                cmd.Parameters.AddWithValue("@name", area.AreaName);
                cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);
                cmd.Parameters.AddWithValue("@okrug", area.Okrug);
                cmd.Parameters.AddWithValue("@autocod", area.Autocod);
                cmd.Parameters.AddWithValue("@capital", area.Capital);
                cmd.Parameters.AddWithValue("@iso", area.Iso);
                
                var dr = cmd.ExecuteReader();
                dr.Read();

                var areaId = (int)dr["id_area"];
                dr.Close();
                var newCity = new TreeNode(area.AreaName, 1, 1)
                {
                    Tag = areaId
                };

                treeView1.SelectedNode.Nodes.Add(newCity);
            }
        }
        private void InsertCity()
        {
            var form = new CityForm();
            form.ShowDialog();
            City city = null;
            if (form.DialogResult == DialogResult.OK)
            {
                city = form.C;
            }

            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();
                if (city == null) return;
                if (city.CityName == "" || city.Telcod =="" || city.Post == "")
                {
                    MessageBox.Show("Вы заполнили не все поля"); return;
                }


                var sql = @"INSERT INTO City OUTPUT INSERTED.id_city VALUES  (@name, @num, @tz, @lat, @long,  @id, @telcod, @level, @iso, @vid, @post)";
                var cmd = new SqlCommand(sql, cn);
                
                cmd.Parameters.AddWithValue("@name", city.CityName);
                cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);
                cmd.Parameters.AddWithValue("@num", city.NumberOfDistricts);
                cmd.Parameters.AddWithValue("@tz", city.TimeZone);
                cmd.Parameters.AddWithValue("@lat", city.Latitude);
                cmd.Parameters.AddWithValue("@long", city.Longitude);
                cmd.Parameters.AddWithValue("@telcod", city.Telcod);
                cmd.Parameters.AddWithValue("@level", city.Level);
                cmd.Parameters.AddWithValue("@iso", city.Iso);
                cmd.Parameters.AddWithValue("@vid", city.Vid);
                cmd.Parameters.AddWithValue("@post", city.Post);
               
                var dr = cmd.ExecuteReader();
                dr.Read();

                var cityId = (int)dr["id_city"];
                dr.Close();
                var newCity = new TreeNode(city.CityName, 2, 2)
                {
                    Tag = cityId
                };

                treeView1.SelectedNode.Nodes.Add(newCity);
            }
        }
        private void InsertCountry()
        {
            var form = new Form2();
            form.ShowDialog();
            Country country = null;
            if (form.DialogResult == DialogResult.OK)
            {
                country = form.Cnt;
            }
            using (SqlConnection cn = new SqlConnection(Cs))
            {
                cn.Open();
                if (country == null) return;
                if (country.CountryName == "" || country.Location== "")

                {
                    MessageBox.Show("Вы заполнили не все поля"); return;
                }
                var sql = @"INSERT INTO Country OUTPUT INSERTED.id_country VALUES  (@name, @location, @iso, @telcode, @capital)";
                var cmd = new SqlCommand(sql, cn);
                
                cmd.Parameters.AddWithValue("@name", country.CountryName);
                cmd.Parameters.AddWithValue("@location", country.Location);

                cmd.Parameters.AddWithValue("@iso", country.Iso);
                cmd.Parameters.AddWithValue("@telcode", country.Telcod);
                cmd.Parameters.AddWithValue("@capital", country.Capital);

                
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
        {
            InsertCountry();

        }

        private void InsertTheCity(object sender, EventArgs e)
        {
            InsertCity();
        }

        private void InsertTheDistrict(object sender, EventArgs e)
        {
            InsertDistrict();
        }
        private void UpdateDistrict()
        {
            var form = new DistrictForm();
            using (SqlConnection cn = new SqlConnection(Cs))
            {
                cn.Open();
                var sql = @"SELECT id_district, district  FROM District WHERE id_district = @id";
                var cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);
                cmd.ExecuteNonQuery();
                var dr = cmd.ExecuteReader();
                dr.Read();
                form.D = new District()
                {  Id = (int)dr["id_district"],
                    DistrictName = (string)dr["district"]

                };
                dr.Close();
                form.WriteInForm();

            }
            form.ShowDialog();
            District district = null;
            if (form.DialogResult == DialogResult.OK)
            {
                district = form.D;
            }

            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();
                if (district == null) return;
                if (district.DistrictName == "")
                {
                    MessageBox.Show("Вы заполнили не все поля"); return;
                }

                var sql = @"UPDATE District
                            SET district = @name
                            WHERE id_district = @id";
                var cmd = new SqlCommand(sql, cn);
                
                cmd.Parameters.AddWithValue("@name", district.DistrictName);
                cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);

                cmd.ExecuteNonQuery();


                treeView1.SelectedNode.Text = district.DistrictName;
            }
        }
        private void UpdateCity()
        {
            var form = new CityForm();

            using (SqlConnection cn = new SqlConnection(Cs))
            {
                cn.Open();
                var sql = @"SELECT id_city, city , number_of_districts, time_zone, latitude, longitude, telcod, level, iso, vid, post FROM City WHERE id_city = @id";
                var cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);
                cmd.ExecuteNonQuery();
                var dr = cmd.ExecuteReader();
                dr.Read();
                form.C = new City()
                {  Id = (int)dr["id_city"],
                    CityName = (string)dr["city"],
                    NumberOfDistricts = (int)dr["number_of_districts"],
                    TimeZone = (int)dr["time_zone"],
                    Latitude = (float)dr["latitude"],
                    Longitude = (float)dr["longitude"],
                    Telcod = (string)dr["telcod"],
                    Level = (int)dr["level"],
                    Iso = (int)dr["iso"],
                    Vid = (int)dr["vid"],
                    Post = (string)dr["post"]

                };
                dr.Close();
                form.WriteInForm();

            }
            form.ShowDialog();
            City city = null;
            if (form.DialogResult == DialogResult.OK)
            {
                city = form.C;
            }

            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();
                if (city == null) return;
                if (city.CityName == "" || city.Telcod == "" || city.Post == "")
                {
                    MessageBox.Show("Вы заполнили не все поля"); return;
                }


                var sql = @"Update City SET city =  @name ,number_of_districts =   @num, time_zone = @tz, latitude = @lat,longitude =  @long, telcod = @telcod, level=@level, iso=@iso, vid = @vid, post = @post WHERE id_city = @id";
                var cmd = new SqlCommand(sql, cn);
                
                cmd.Parameters.AddWithValue("@name", city.CityName);

                cmd.Parameters.AddWithValue("@num", city.NumberOfDistricts);
                cmd.Parameters.AddWithValue("@tz", city.TimeZone);
                cmd.Parameters.AddWithValue("@lat", city.Latitude);
                cmd.Parameters.AddWithValue("@long", city.Longitude);
                cmd.Parameters.AddWithValue("@telcod", city.Telcod);
                cmd.Parameters.AddWithValue("@level", city.Level);
                cmd.Parameters.AddWithValue("@iso", city.Iso);
                cmd.Parameters.AddWithValue("@vid", city.Vid);
                cmd.Parameters.AddWithValue("@post", city.Post);
                cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);

                cmd.ExecuteNonQuery();






                treeView1.SelectedNode.Text = city.CityName;
            }
        }
        private void UpdateArea()
        {
            var form = new AreaForm();

            using (SqlConnection cn = new SqlConnection(Cs))
            {
                cn.Open();
                var sql = @"SELECT id_area, area , okrug, autocod, capital, iso FROM Area WHERE id_area = @id";
                var cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);
                cmd.ExecuteNonQuery();
                var dr = cmd.ExecuteReader();
                dr.Read();
                form.Ar = new Area()
                { Id = (int)dr["id_area"],
                    AreaName = (string)dr["area"],
                    Okrug = (string)dr["okrug"],
                    Autocod = (string)dr["autocod"],
                    Capital = (string)dr["capital"],
                    Iso = (int)dr["iso"]

                };
                dr.Close();
                form.WriteInForm();

            }
            form.ShowDialog();
            Area area = null;
            if (form.DialogResult == DialogResult.OK)
            {
                area = form.Ar;
            }

            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();

                if (area == null) return;
                if (area.AreaName == "" || area.Okrug == "" || area.Autocod == "" || area.Capital == "")
                {
                    MessageBox.Show("Вы заполнили не все поля"); return;
                }

                var sql = @"Update Area SET area =  @name ,okrug =   @okrug, autocod = @autocod, capital = @capital,iso =  @iso WHERE id_area = @id";
                var cmd = new SqlCommand(sql, cn);
                if (area == null) return;
                cmd.Parameters.AddWithValue("@name", area.AreaName);

                cmd.Parameters.AddWithValue("@okrug", area.Okrug);
                cmd.Parameters.AddWithValue("@autocod", area.Autocod);
                cmd.Parameters.AddWithValue("@capital", area.Capital);
                cmd.Parameters.AddWithValue("@iso", area.Iso);
                cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);

                cmd.ExecuteNonQuery();






                treeView1.SelectedNode.Text = area.AreaName;
            }
        }
        public string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        private void UpdateCountry()
        {
            var form = new Form2();
            using (SqlConnection cn = new SqlConnection(Cs))
            {
                cn.Open();
                var sql = @"SELECT id_country, country , location,  iso, telcod, capital FROM Country WHERE id_country = @id";
                var cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);
                cmd.ExecuteNonQuery();
                var dr = cmd.ExecuteReader();
                dr.Read();
                form.Cnt = new Country()
                {   Id = (int)dr["id_country"],
                    CountryName = (string)dr["country"],
                    Location = (string)dr["location"],

                    Iso = (int)dr["iso"],
                    Telcod = (int)dr["telcod"],
                    Capital = (string)dr["capital"]

                };
                dr.Close();
                form.WriteInForm();

            }

            form.ShowDialog();
            Country country = null;
            if (form.DialogResult == DialogResult.OK)
            {
                country = form.Cnt;
            }
            using (SqlConnection cn = new SqlConnection(Cs))
            {
                cn.Open();
                if (country == null) return;
                if (country.CountryName == "" || country.Location == "")

                {
                    MessageBox.Show("Вы заполнили не все поля"); return;
                }
                    var sql = @"Update Country SET country =  @name , location =  @location, iso= @iso, telcod = @telcod, capital = @capital WHERE id_country = @id";
                var cmd = new SqlCommand(sql, cn);
                
                cmd.Parameters.AddWithValue("@name", country.CountryName);
                cmd.Parameters.AddWithValue("@location", country.Location);

                cmd.Parameters.AddWithValue("@iso", country.Iso);
                cmd.Parameters.AddWithValue("@telcod", country.Telcod);
                cmd.Parameters.AddWithValue("@capital", country.Capital);

                cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);
                cmd.ExecuteNonQuery();


                treeView1.SelectedNode.Text = country.CountryName;
            }
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        { if (treeView1.SelectedNode == null) return;
        else 
            if (treeView1.SelectedNode.Level == 3)
            {
                UpdateDistrict();
            }
            else if (treeView1.SelectedNode.Level == 2)
            {
                UpdateCity();
            }
            else if (treeView1.SelectedNode.Level == 1)
            {
                UpdateArea();
            }
            else UpdateCountry();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void insertTheAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertArea();
        }

       
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            OperLoad();
        }
        private void OperLoad() {
            listView1.Items.Clear();
            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();
                const string sql = @"SELECT  name, mobile, mvno, mnc, brand, url, id_country, id_oper
                                         FROM Oper
                                          
                                         ORDER BY  name, mobile, mvno, mnc, brand, url, id_country, id_oper";

                var cmd = new SqlCommand(sql, cn);
                if (cmd == null) return;

                var dr = cmd.ExecuteReader();
                listView1.View = View.Details;


                string[] items = new string[8];



                while (dr.Read())
                {
                    items[0] = ((int)dr["id_oper"]).ToString();
                   
                    items[1] = (string)dr["name"];

                    items[2] = ((int)dr["mobile"]).ToString();
                    items[3] = ((int)dr["mvno"]).ToString();
                    items[4] = ((int)dr["id_country"]).ToString();
                    items[5] = ((int)dr["mnc"]).ToString();
                    items[6] = (string)dr["brand"];
                    items[7] = (string)dr["url"];

                    var item = new ListViewItem(items);
                    item.Tag = (int)dr["id_oper"];
                    listView1.Items.Add(item);

                }
            }


        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            var form = new OperForm();
            form.ShowDialog();
            Oper oper = null;
            if (form.DialogResult == DialogResult.OK)
            {
                oper = form.Op;
            }
            using (SqlConnection cn = new SqlConnection(Cs))
            {
                cn.Open();
                if (oper == null) return;
                if (oper.OperName == "" || oper.Brand == "" || oper.Url == "")
                {
                    MessageBox.Show("Вы заполнили не все поля"); return;
                }
                var sql = @"INSERT INTO Oper OUTPUT INSERTED.id_oper VALUES  (@name, @mobile, @mvno, @id_country, @mnc, @brand, @url)";
                var cmd = new SqlCommand(sql, cn);
                
                cmd.Parameters.AddWithValue("@name", oper.OperName);
                cmd.Parameters.AddWithValue("@mobile", oper.Mobile);

                cmd.Parameters.AddWithValue("@mvno", oper.Mvno);
                cmd.Parameters.AddWithValue("@id_country", oper.CountryId);
                cmd.Parameters.AddWithValue("@mnc", oper.Mnc);
                cmd.Parameters.AddWithValue("@brand", oper.Brand);
                cmd.Parameters.AddWithValue("@url", oper.Url);
                var dr = cmd.ExecuteReader();
                try
                {
                   
                    dr.Read();
                }
                catch 
                {
                    MessageBox.Show("Такой страны нет");
                    return;
                }


                string[] items = new string[8];
                items[0] = ((int)dr["id_oper"]).ToString();
                items[1] = oper.OperName;
                items[2] = oper.Mobile.ToString();
                items[3] = oper.Mvno.ToString();
                items[4] = oper.CountryId.ToString();
                items[5] = oper.Mnc.ToString();
                items[6] = oper.Brand;
                items[7] = oper.Url;

                var item = new ListViewItem(items);
                item.Tag = (int)dr["id_oper"];
                listView1.Items.Add(item);

                
            }

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {if (LoginForm.Adminka == 0)
            {
                изменитьToolStripMenuItem.Enabled = false;
                добавитьToolStripMenuItem2.Enabled = false;
                удалитьToolStripMenuItem1.Enabled = false;
            }
            else
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    изменитьToolStripMenuItem.Enabled = false;
                    добавитьToolStripMenuItem2.Enabled = true;
                    удалитьToolStripMenuItem1.Enabled = false;
                }
                else
                {
                    изменитьToolStripMenuItem.Enabled = true;
                    добавитьToolStripMenuItem2.Enabled = true;
                    удалитьToolStripMenuItem1.Enabled = true;
                }
            }
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();
                const string sql = @"delete from Oper where id_oper = @id";
                var cmd = new SqlCommand(sql, cn);
                ListViewItem lw = new ListViewItem();
               

                cmd.Parameters.AddWithValue("@id", listView1.SelectedItems[0].Tag);
                cmd.ExecuteNonQuery();
                listView1.SelectedItems[0].Remove();
            }
        }
        

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new OperForm();
            using (SqlConnection cn = new SqlConnection(Cs))
            {
                cn.Open();
                var sql = @"SELECT id_oper, name,  mobile, mvno, id_country, mnc, brand, url FROM Oper WHERE id_oper = @id";
                var cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@id", listView1.SelectedItems[0].Tag);
                cmd.ExecuteNonQuery();
                var dr = cmd.ExecuteReader();
                dr.Read();
                form.Op = new Oper()
                { OperId = (int)dr["id_oper"],
                    OperName = (string)dr["name"],
                    Mobile = (int)dr["mobile"],
                    Mvno = (int)dr["mvno"],
                    CountryId = (int)dr["id_country"],
                    Mnc = (int)dr["mnc"],
                    Brand = (string)dr["brand"],
                    Url = (string)dr["url"]
                    

                };
                dr.Close();
                form.WriteInForm();

            }
            form.ShowDialog();
            Oper oper = null;
            if (form.DialogResult == DialogResult.OK)
            {
                oper = form.Op;
            }

            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();

                if (oper == null) return;
                if (oper.OperName == "" || oper.Brand == "" || oper.Url == "" )
                {
                    MessageBox.Show("Вы заполнили не все поля"); return;
                }

                var sql = @"UPDATE Oper
                            SET name = @opname, mobile = @mobile, mvno = @mvno, id_country = @idcntr, mnc = @mnc, brand= @brand, url = @url
                            WHERE id_oper = @id";
                var cmd = new SqlCommand(sql, cn);
                
                cmd.Parameters.AddWithValue("@opname", oper.OperName);
                cmd.Parameters.AddWithValue("@mobile", oper.Mobile);
                cmd.Parameters.AddWithValue("@mvno", oper.Mvno);
                cmd.Parameters.AddWithValue("@idcntr", oper.CountryId);
                cmd.Parameters.AddWithValue("@mnc", oper.Mnc);
                cmd.Parameters.AddWithValue("@brand", oper.Brand);
                cmd.Parameters.AddWithValue("@url", oper.Url);

                cmd.Parameters.AddWithValue("@id", listView1.SelectedItems[0].Tag);
                try
                {
                    cmd.ExecuteNonQuery();
                } catch
                {
                    MessageBox.Show("Такой страны нет");
                    return;
                }
                string[] items = new string[8];
                items[0] = (oper.OperId).ToString();
                items[1] = oper.OperName;
                items[2] = oper.Mobile.ToString();
                items[3] = oper.Mvno.ToString();
                items[4] = oper.CountryId.ToString();
                items[5] = oper.Mnc.ToString();
                items[6] = oper.Brand;
                items[7] = oper.Url;
                var item = new ListViewItem(items);
                item.Tag = oper.OperId;
                listView1.SelectedItems[0].ListView.Items.Add( item);
                listView1.SelectedItems[0].Remove();
            }
        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {
            if (LoginForm.Adminka == 0)
            {
                изменитьToolStripMenuItem1.Enabled = false;
                добавитьToolStripMenuItem3.Enabled = false;
                удалитьToolStripMenuItem2.Enabled = false;
            }
            else
            {
                if (listView2.SelectedItems.Count == 0)
                {
                    изменитьToolStripMenuItem1.Enabled = false;
                    добавитьToolStripMenuItem3.Enabled = true;
                    удалитьToolStripMenuItem2.Enabled = false;
                }
                else
                {
                    изменитьToolStripMenuItem1.Enabled = true;
                    добавитьToolStripMenuItem3.Enabled = true;
                    удалитьToolStripMenuItem2.Enabled = true;
                }
            }
        }

        private void добавитьToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            listView2.View = View.Details;
            var form = new PhoneForm();
            form.ShowDialog();
            Phone phone = null;
            if (form.DialogResult == DialogResult.OK)
            {
                phone = form.P;
            }
            using (SqlConnection cn = new SqlConnection(Cs))
            {
                cn.Open();
                if (phone == null) return;
                if (phone.PhoneNumber=="")
                {
                    MessageBox.Show("Вы заполнили не все поля"); return;
                }
                var sql = @"INSERT INTO Phone  VALUES  (@phone, @id_oper,@id_city)";
                var cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@phone", phone.PhoneNumber);
                cmd.Parameters.AddWithValue("@id_oper", phone.OperId);

                cmd.Parameters.AddWithValue("@id_city", phone.CityId);
               
                
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Такого оператора или города нет, либо номер уже есть в базе");
                    return;
                }


               
                string[] items = new string[3];
                items[0] = (phone.PhoneNumber).ToString();
                items[1] = (phone.OperId).ToString();
                items[2] = (phone.CityId).ToString();

                var item = new ListViewItem(items);
                item.Tag = phone.PhoneNumber;
                listView2.Items.Add(item);


            }
        }

        private void изменитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new PhoneForm();
            using (SqlConnection cn = new SqlConnection(Cs))
            {
                cn.Open();
               
                var sql = @"SELECT  id_oper, id_city FROM Phone WHERE phone = @phone";
                var cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@phone", listView2.SelectedItems[0].Tag);
                cmd.ExecuteNonQuery();
                var dr = cmd.ExecuteReader();
                dr.Read();
                form.P = new Phone()
                {
                    OperId = (int)dr["id_oper"],
                    PhoneNumber = (string)listView2.SelectedItems[0].Tag,
                    CityId = (int)dr["id_city"]


                };
                dr.Close();
                form.WriteInForm();

            }
            form.ShowDialog();
            Phone phone = null;
            if (form.DialogResult == DialogResult.OK)
            {
                phone = form.P;
            }

            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();
                
                if (phone == null) return;
                if (phone.PhoneNumber == "")
                {
                    MessageBox.Show("Вы заполнили не все поля"); return;
                }

                var sql = @"UPDATE Phone
                            SET phone = @phone, id_oper = @operId, id_city = @cityId
                            WHERE phone = @id";
                var cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@phone", phone.PhoneNumber);
                cmd.Parameters.AddWithValue("@operId", phone.OperId);
                cmd.Parameters.AddWithValue("@cityId", phone.CityId);
                

                cmd.Parameters.AddWithValue("@id", listView2.SelectedItems[0].Tag);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Такого оператора или города нет, либо номер уже есть в базе"); return;
                }
                string[] items = new string[3];
                items[0] = (phone.PhoneNumber).ToString();
                items[1] = (phone.OperId).ToString();
                items[2] = (phone.CityId).ToString();
               
                var item = new ListViewItem(items);
                item.Tag = phone.PhoneNumber;
                listView2.SelectedItems[0].ListView.Items.Add(item);
                listView2.SelectedItems[0].Remove();
            }
        }

        private void удалитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();
                
                const string sql = @"delete from Phone where phone = @phone";
                var cmd = new SqlCommand(sql, cn);
                ListViewItem lw = new ListViewItem();


                cmd.Parameters.AddWithValue("@phone", listView2.SelectedItems[0].Tag);
                cmd.ExecuteNonQuery();
                listView2.SelectedItems[0].Remove();
            }
        }
        private void PhoneLoad()
        {
            listView2.Items.Clear();
            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();
                
                const string sql = @"SELECT  phone, id_oper, id_city FROM Phone
                                          
                                         ORDER BY  phone, id_oper, id_city";

                var cmd = new SqlCommand(sql, cn);
                if (cmd == null) return;

                var dr = cmd.ExecuteReader();
                listView2.View = View.Details;


                string[] items = new string[3];



                while (dr.Read())
                {
                    items[0] = ((string)dr["phone"]).ToString();

                    items[1] = ((int)dr["id_oper"]).ToString();

                    items[2] = ((int)dr["id_city"]).ToString();
                    

                    var item = new ListViewItem(items);
                    item.Tag = (string)dr["phone"];
                    listView2.Items.Add(item);

                }
            }


        }
        private void button3_Click(object sender, EventArgs e)
        {
            PhoneLoad();
        }
        private void TelcodLoad()
        {
            listView3.Items.Clear();
            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();

                const string sql = @"SELECT  id_city, id_oper, deffrom, defto FROM Telcod
                                          
                                         ORDER BY  id_city, id_oper, deffrom, defto";

                var cmd = new SqlCommand(sql, cn);
                if (cmd == null) return;

                var dr = cmd.ExecuteReader();
                listView3.View = View.Details;


                string[] items = new string[4];



                while (dr.Read())
                {
                    items[0] = ((int)dr["id_city"]).ToString();

                    items[1] = ((int)dr["id_oper"]).ToString();

                    items[2] = (string)dr["deffrom"];
                    items[3] = (string)dr["defto"];


                    var item = new ListViewItem(items);
                    
                    listView3.Items.Add(item);

                }
            }


        }
        private void button4_Click(object sender, EventArgs e)
        {
            TelcodLoad();
        }

        private void добавитьToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            listView3.View = View.Details;
            var form = new TelcodForm();
            form.ShowDialog();
            Telcod telcod = null;
            if (form.DialogResult == DialogResult.OK)
            {
                telcod = form.T;
            }
            using (SqlConnection cn = new SqlConnection(Cs))
            {
                cn.Open();
                if (telcod == null) return;
                if (telcod.Deffrom  == "" || telcod.Defto == "")
                {
                    MessageBox.Show("Вы заполнили не все поля"); return;
                }
                var sql = @"INSERT INTO Telcod  VALUES  (@id_city, @id_oper,@deffrom, @defto)";
                var cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@id_city", telcod.CityId);
                cmd.Parameters.AddWithValue("@id_oper", telcod.OperId);

                cmd.Parameters.AddWithValue("@deffrom", telcod.Deffrom);
                cmd.Parameters.AddWithValue("@defto", telcod.Defto);


                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Такого оператора или города нет или для данного города и оператора уже есть телефонный код");
                    return;
                }



                string[] items = new string[4];
                items[0] = (telcod.CityId).ToString();
                items[1] = (telcod.OperId).ToString();
                items[2] = telcod.Deffrom;
                items[3] = telcod.Defto;
                var item = new ListViewItem(items);
               
                listView3.Items.Add(item);


            }
        }

        private void изменитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new TelcodForm();
            using (SqlConnection cn = new SqlConnection(Cs))
            {
                cn.Open();

                var sql = @"SELECT  id_city, id_oper, deffrom, defto FROM Telcod WHERE id_city = @cityId AND id_oper = @operId";
                var cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@cityId", listView3.SelectedItems[0].SubItems[0].Text);
                cmd.Parameters.AddWithValue("@operId", listView3.SelectedItems[0].SubItems[1].Text);
                cmd.ExecuteNonQuery();
                var dr = cmd.ExecuteReader();
                dr.Read();
                form.T = new Telcod()
                {
                    OperId = (int)dr["id_oper"],
                    Deffrom = (string)dr["deffrom"],
                    CityId = (int)dr["id_city"],
                    Defto = (string)dr["defto"]


                };
                dr.Close();
                form.WriteInForm();

            }
            form.ShowDialog();
            Telcod telcod = null;
            if (form.DialogResult == DialogResult.OK)
            {
                telcod = form.T;
            }

            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();

                if (telcod == null) return;
                if (telcod.Deffrom == "" || telcod.Defto == "")
                {
                    MessageBox.Show("Вы заполнили не все поля"); return;
                }

                var sql = @"UPDATE Telcod
                            SET id_city = @cityId, id_oper = @operId, deffrom = @deffrom, defto= @defto
                            WHERE id_city = @id1 and id_oper = @id2";
                var cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@deffrom", telcod.Deffrom);
                cmd.Parameters.AddWithValue("@operId", telcod.OperId);
                cmd.Parameters.AddWithValue("@cityId", telcod.CityId);
                cmd.Parameters.AddWithValue("@defto", telcod.Defto);
                
                cmd.Parameters.AddWithValue("@id1", listView3.SelectedItems[0].SubItems[0].Text);
                cmd.Parameters.AddWithValue("@id2", listView3.SelectedItems[0].SubItems[1].Text);
               
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Такого оператора или города нет или для данного города и оператора уже есть телефонный код"); return;
                }
                string[] items = new string[4];
                items[0] = (telcod.CityId).ToString();
                items[1] = (telcod.OperId).ToString();
                items[2] = telcod.Deffrom;
                items[3] = telcod.Defto;

                var item = new ListViewItem(items);
                
                listView3.SelectedItems[0].ListView.Items.Add(item);
                listView3.SelectedItems[0].Remove();
            }
        }

        private void удалитьToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();

                const string sql = @"delete from Telcod where id_city = @cityId and id_oper = @operId";
                var cmd = new SqlCommand(sql, cn);
                ListViewItem lw = new ListViewItem();


                cmd.Parameters.AddWithValue("@cityId", listView3.SelectedItems[0].SubItems[0].Text);
                cmd.Parameters.AddWithValue("@operId", listView3.SelectedItems[0].SubItems[1].Text);
                cmd.ExecuteNonQuery();
                listView3.SelectedItems[0].Remove();
            }
        }

        private void contextMenuStrip4_Opening(object sender, CancelEventArgs e)
        {
            if (LoginForm.Adminka == 0)
            {
                изменитьToolStripMenuItem2.Enabled = false;
                добавитьToolStripMenuItem4.Enabled = false;
                удалитьToolStripMenuItem3.Enabled = false;

            }
            else
            {
                if (listView3.SelectedItems.Count == 0)
                {
                    изменитьToolStripMenuItem2.Enabled = false;
                    добавитьToolStripMenuItem4.Enabled = true;
                    удалитьToolStripMenuItem3.Enabled = false;
                }
                else
                {
                    изменитьToolStripMenuItem2.Enabled = true;
                    добавитьToolStripMenuItem4.Enabled = true;
                    удалитьToolStripMenuItem3.Enabled = true;
                }
            }
        }
        private void UsersLoad()
        {
            listView4.Items.Clear();
            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();

                const string sql = @"SELECT  login, password, adminka, salt FROM Users
                                          
                                         ORDER BY  login, password, adminka, salt";

                var cmd = new SqlCommand(sql, cn);
                if (cmd == null) return;

                var dr = cmd.ExecuteReader();
                listView4.View = View.Details;


                string[] items = new string[4];



                while (dr.Read())
                {
                    items[0] = (string)dr["login"];

                    items[1] = (string)dr["password"];

                    items[2] = ((int)dr["adminka"]).ToString();
                    items[3] = (string)dr["salt"];


                    var item = new ListViewItem(items);

                    listView4.Items.Add(item);

                }
            }


        }

        private void contextMenuStrip5_Opening(object sender, CancelEventArgs e)
        {
            if (LoginForm.Adminka == 0)
            {
                сделатьАдминомToolStripMenuItem.Enabled = false;
                toolStripMenuItem3.Enabled = false;

            }
            else
            {
                if (listView4.SelectedItems.Count == 0)
                {
                    сделатьАдминомToolStripMenuItem.Enabled = false;
                    toolStripMenuItem3.Enabled = false;

                }
                else
                {
                    if (listView4.SelectedItems[0].SubItems[2].Text == "1")
                    {
                        сделатьАдминомToolStripMenuItem.Enabled = false;
                    }
                    else сделатьАдминомToolStripMenuItem.Enabled = true;
                    toolStripMenuItem3.Enabled = true;
                }
            }
        }

        

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();

                const string sql = @"delete from Users where login = @login";
                var cmd = new SqlCommand(sql, cn);
                ListViewItem lw = new ListViewItem();


                cmd.Parameters.AddWithValue("@login", listView4.SelectedItems[0].SubItems[0].Text);
               
                cmd.ExecuteNonQuery();
                listView4.SelectedItems[0].Remove();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UsersLoad();
        }

        private void сделатьАдминомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var cn = new SqlConnection(Cs))
            {
                cn.Open();



                var sql = @"UPDATE Users
                            SET adminka = 1
                            WHERE login = @login";
                var cmd = new SqlCommand(sql, cn);

                

                cmd.Parameters.AddWithValue("@login", listView4.SelectedItems[0].SubItems[0].Text);

                cmd.ExecuteNonQuery();

                string[] items = new string[4];
                items[0] = listView4.SelectedItems[0].SubItems[0].Text;
                items[1] = listView4.SelectedItems[0].SubItems[1].Text;
                items[2] = "1";
                items[3] = listView4.SelectedItems[0].SubItems[3].Text;

                var item = new ListViewItem(items);

                listView4.SelectedItems[0].ListView.Items.Add(item);
                listView4.SelectedItems[0].Remove();
            }
        }
    }

}
    