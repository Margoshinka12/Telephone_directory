using System;
using System.ComponentModel;
using System.Data.SqlClient;
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
                TreeNode lastAddedCity=null;
                TreeNode lastAddedCountry=null;
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
        {  if (treeView1.SelectedNode == null) { добавитьToolStripMenuItem.Enabled = true;
                удалитьToolStripMenuItem.Enabled = false;
                
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
                    добавитьГородToolStripMenuItem.Enabled = false;
                    добавитьToolStripMenuItem1.Enabled = false;
                    break;
                case 1:
                    удалитьToolStripMenuItem.Enabled = true;
                    insertTheAreaToolStripMenuItem.Enabled = false;
                    добавитьГородToolStripMenuItem.Enabled = true;
                    добавитьToolStripMenuItem.Enabled = false;
                    добавитьToolStripMenuItem1.Enabled = false;
                    break;
                case 2:
                    удалитьToolStripMenuItem.Enabled = true;
                    insertTheAreaToolStripMenuItem.Enabled = false;
                    добавитьГородToolStripMenuItem.Enabled = false;
                    добавитьToolStripMenuItem.Enabled = false;
                    добавитьToolStripMenuItem1.Enabled = true;
                    break;
                case 3:
                    удалитьToolStripMenuItem.Enabled = true;
                    insertTheAreaToolStripMenuItem.Enabled = false;
                    добавитьГородToolStripMenuItem.Enabled = false;
                    добавитьToolStripMenuItem.Enabled = false;
                    добавитьToolStripMenuItem1.Enabled = false;
                    break;
                default:
                    удалитьToolStripMenuItem.Enabled = false;
                    добавитьГородToolStripMenuItem.Enabled = false;
                    добавитьToolStripMenuItem.Enabled = false;
                    добавитьToolStripMenuItem1.Enabled = false;
                    insertTheAreaToolStripMenuItem.Enabled = false;
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



                var sql = @"INSERT INTO Area VALUES  (@name, @okrug, @autocod, @capital, @iso, @id)";
                var cmd = new SqlCommand(sql, cn);
                if (area == null) return;
                cmd.Parameters.AddWithValue("@name", area.AreaName);
                cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);
                cmd.Parameters.AddWithValue("@okrug", area.Okrug);
                cmd.Parameters.AddWithValue("@autocod", area.Autocod);
                cmd.Parameters.AddWithValue("@capital", area.Capital);
                cmd.Parameters.AddWithValue("@iso", area.Iso);
                cmd.ExecuteNonQuery();
                sql = @"SELECT id_area FROM Area WHERE area = @name";
                cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@name", area.AreaName);
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
                
               
                
                var sql = @"INSERT INTO City VALUES  (@name, @num, @tz, @lat, @long,  @id, @telcod, @level, @iso, @vid, @post)";
                var cmd = new SqlCommand(sql, cn);
                if (city == null) return;
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
                cmd.ExecuteNonQuery();
                sql = @"SELECT id_city FROM City WHERE city = @name";
                cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@name", city.CityName);
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
                var sql = @"INSERT INTO Country VALUES  (@name, @location, @iso, @telcode, @capital)";
                var cmd = new SqlCommand(sql, cn);
                if (country == null) return;
                cmd.Parameters.AddWithValue("@name", country.CountryName);
                cmd.Parameters.AddWithValue("@location", country.Location);
               
                cmd.Parameters.AddWithValue("@iso", country.Iso);
                cmd.Parameters.AddWithValue("@telcode", country.Telcod);
                cmd.Parameters.AddWithValue("@capital", country.Capital);

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
        private void UpdateDistrict()
        {
            var form = new Form4();
            using (SqlConnection cn = new SqlConnection(Cs))
            {
                cn.Open();
                var sql = @"SELECT district  FROM District WHERE id_district = @id";
                var cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);
                cmd.ExecuteNonQuery();
                var dr = cmd.ExecuteReader();
                dr.Read();
                form.D = new District()
                {
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



                var sql = @"UPDATE District
                            SET district = @name
                            WHERE id_district = @id";
                var cmd = new SqlCommand(sql, cn);
                if (district == null) return;
                cmd.Parameters.AddWithValue("@name", district.DistrictName);
                cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);

                cmd.ExecuteNonQuery();


                treeView1.SelectedNode.Text = district.DistrictName;
            }
        }
        private void UpdateCity()
        {
            var form = new Form3();

            using (SqlConnection cn = new SqlConnection(Cs))
            {
                cn.Open();
                var sql = @"SELECT city , number_of_districts, time_zone, latitude, longitude, telcod, level, iso, vid, post FROM City WHERE id_city = @id";
                var cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);
                cmd.ExecuteNonQuery();
                var dr = cmd.ExecuteReader();
                dr.Read();
                form.C = new City()
                {
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



                var sql = @"Update City SET city =  @name ,number_of_districts =   @num, time_zone = @tz, latitude = @lat,longitude =  @long, telcod = @telcod, level=@level, iso=@iso, vid = @vid, post = @post WHERE id_city = @id";
                var cmd = new SqlCommand(sql, cn);
                if (city == null) return;
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
                var sql = @"SELECT area , okrug, autocod, capital, iso FROM Area WHERE id_area = @id";
                var cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);
                cmd.ExecuteNonQuery();
                var dr = cmd.ExecuteReader();
                dr.Read();
                form.Ar = new Area()
                {
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
        private void UpdateCountry()
        {
            var form = new Form2();
            using (SqlConnection cn = new SqlConnection(Cs))
            {
                cn.Open();
                var sql = @"SELECT country , location,  iso, telcod, capital FROM Country WHERE id_country = @id";
                var cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@id", treeView1.SelectedNode.Tag);
                cmd.ExecuteNonQuery();
                var dr = cmd.ExecuteReader();
                dr.Read();
                form.Cnt = new Country()
                {
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
                var sql = @"Update Country SET country =  @name , location =  @location, iso= @iso, telcod = @telcod, capital = @capital WHERE id_country = @id";
                var cmd = new SqlCommand(sql, cn);
                if (country == null) return;
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
        {
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowContextMenuStripChanged(object sender, DataGridViewRowEventArgs e)
        {

        }
    }
}
    