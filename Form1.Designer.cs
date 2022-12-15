namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertTheAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьГородToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Иерархия_населенных_пунктов = new System.Windows.Forms.TabPage();
            this.Операторы = new System.Windows.Forms.TabPage();
            this.Номера = new System.Windows.Forms.TabPage();
            this.Телефонные_коды = new System.Windows.Forms.TabPage();
            this.Синонимы = new System.Windows.Forms.TabPage();
            this.Пользователи = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.worldDataSet = new WindowsFormsApp1.WorldDataSet();
            this.operBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operTableAdapter = new WindowsFormsApp1.WorldDataSetTableAdapters.OperTableAdapter();
            this.idoperDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mvnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Иерархия_населенных_пунктов.SuspendLayout();
            this.Операторы.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 6);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(783, 354);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.insertTheAreaToolStripMenuItem,
            this.добавитьГородToolStripMenuItem,
            this.добавитьToolStripMenuItem1,
            this.updateToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(193, 148);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.добавитьToolStripMenuItem.Text = "Insert the country";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.InsertTheCountry);
            // 
            // insertTheAreaToolStripMenuItem
            // 
            this.insertTheAreaToolStripMenuItem.Name = "insertTheAreaToolStripMenuItem";
            this.insertTheAreaToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.insertTheAreaToolStripMenuItem.Text = "Insert the area";
            this.insertTheAreaToolStripMenuItem.Click += new System.EventHandler(this.insertTheAreaToolStripMenuItem_Click);
            // 
            // добавитьГородToolStripMenuItem
            // 
            this.добавитьГородToolStripMenuItem.Name = "добавитьГородToolStripMenuItem";
            this.добавитьГородToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.добавитьГородToolStripMenuItem.Text = "Insert the city";
            this.добавитьГородToolStripMenuItem.Click += new System.EventHandler(this.InsertTheCity);
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(192, 24);
            this.добавитьToolStripMenuItem1.Text = "Insert the district";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.InsertTheDistrict);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.удалитьToolStripMenuItem.Text = "Delete";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.Delete);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-arrows-16.png");
            this.imageList1.Images.SetKeyName(1, "icons8-circle-16.png");
            this.imageList1.Images.SetKeyName(2, "icons8-треугольник-16.png");
            this.imageList1.Images.SetKeyName(3, "icons8-квадрат-заливка-16.png");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Загрузить\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Иерархия_населенных_пунктов);
            this.tabControl1.Controls.Add(this.Операторы);
            this.tabControl1.Controls.Add(this.Номера);
            this.tabControl1.Controls.Add(this.Телефонные_коды);
            this.tabControl1.Controls.Add(this.Синонимы);
            this.tabControl1.Controls.Add(this.Пользователи);
            this.tabControl1.Location = new System.Drawing.Point(1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 450);
            this.tabControl1.TabIndex = 3;
            // 
            // Иерархия_населенных_пунктов
            // 
            this.Иерархия_населенных_пунктов.Controls.Add(this.button1);
            this.Иерархия_населенных_пунктов.Controls.Add(this.treeView1);
            this.Иерархия_населенных_пунктов.Location = new System.Drawing.Point(4, 25);
            this.Иерархия_населенных_пунктов.Name = "Иерархия_населенных_пунктов";
            this.Иерархия_населенных_пунктов.Padding = new System.Windows.Forms.Padding(3);
            this.Иерархия_населенных_пунктов.Size = new System.Drawing.Size(790, 421);
            this.Иерархия_населенных_пунктов.TabIndex = 0;
            this.Иерархия_населенных_пунктов.Text = "Иерархия населенных пунктов";
            this.Иерархия_населенных_пунктов.UseVisualStyleBackColor = true;
            // 
            // Операторы
            // 
            this.Операторы.Controls.Add(this.dataGridView1);
            this.Операторы.Location = new System.Drawing.Point(4, 25);
            this.Операторы.Name = "Операторы";
            this.Операторы.Padding = new System.Windows.Forms.Padding(3);
            this.Операторы.Size = new System.Drawing.Size(790, 421);
            this.Операторы.TabIndex = 1;
            this.Операторы.Text = "Операторы";
            this.Операторы.UseVisualStyleBackColor = true;
            // 
            // Номера
            // 
            this.Номера.Location = new System.Drawing.Point(4, 25);
            this.Номера.Name = "Номера";
            this.Номера.Size = new System.Drawing.Size(790, 421);
            this.Номера.TabIndex = 2;
            this.Номера.Text = "Номера";
            this.Номера.UseVisualStyleBackColor = true;
            // 
            // Телефонные_коды
            // 
            this.Телефонные_коды.Location = new System.Drawing.Point(4, 25);
            this.Телефонные_коды.Name = "Телефонные_коды";
            this.Телефонные_коды.Size = new System.Drawing.Size(790, 421);
            this.Телефонные_коды.TabIndex = 3;
            this.Телефонные_коды.Text = "Телефонные коды";
            this.Телефонные_коды.UseVisualStyleBackColor = true;
            // 
            // Синонимы
            // 
            this.Синонимы.Location = new System.Drawing.Point(4, 25);
            this.Синонимы.Name = "Синонимы";
            this.Синонимы.Size = new System.Drawing.Size(790, 421);
            this.Синонимы.TabIndex = 4;
            this.Синонимы.Text = "Синонимы";
            this.Синонимы.UseVisualStyleBackColor = true;
            // 
            // Пользователи
            // 
            this.Пользователи.Location = new System.Drawing.Point(4, 25);
            this.Пользователи.Name = "Пользователи";
            this.Пользователи.Size = new System.Drawing.Size(790, 421);
            this.Пользователи.TabIndex = 5;
            this.Пользователи.Text = "Пользователи";
            this.Пользователи.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idoperDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.mvnoDataGridViewTextBoxColumn,
            this.idcountryDataGridViewTextBoxColumn,
            this.mncDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.operBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(790, 421);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.RowContextMenuStripChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_RowContextMenuStripChanged);
            // 
            // worldDataSet
            // 
            this.worldDataSet.DataSetName = "WorldDataSet";
            this.worldDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operBindingSource
            // 
            this.operBindingSource.DataMember = "Oper";
            this.operBindingSource.DataSource = this.worldDataSet;
            // 
            // operTableAdapter
            // 
            this.operTableAdapter.ClearBeforeFill = true;
            // 
            // idoperDataGridViewTextBoxColumn
            // 
            this.idoperDataGridViewTextBoxColumn.DataPropertyName = "id_oper";
            this.idoperDataGridViewTextBoxColumn.HeaderText = "id_oper";
            this.idoperDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idoperDataGridViewTextBoxColumn.Name = "idoperDataGridViewTextBoxColumn";
            this.idoperDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "mobile";
            this.mobileDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.Width = 125;
            // 
            // mvnoDataGridViewTextBoxColumn
            // 
            this.mvnoDataGridViewTextBoxColumn.DataPropertyName = "mvno";
            this.mvnoDataGridViewTextBoxColumn.HeaderText = "mvno";
            this.mvnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mvnoDataGridViewTextBoxColumn.Name = "mvnoDataGridViewTextBoxColumn";
            this.mvnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idcountryDataGridViewTextBoxColumn
            // 
            this.idcountryDataGridViewTextBoxColumn.DataPropertyName = "id_country";
            this.idcountryDataGridViewTextBoxColumn.HeaderText = "id_country";
            this.idcountryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcountryDataGridViewTextBoxColumn.Name = "idcountryDataGridViewTextBoxColumn";
            this.idcountryDataGridViewTextBoxColumn.Width = 125;
            // 
            // mncDataGridViewTextBoxColumn
            // 
            this.mncDataGridViewTextBoxColumn.DataPropertyName = "mnc";
            this.mncDataGridViewTextBoxColumn.HeaderText = "mnc";
            this.mncDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mncDataGridViewTextBoxColumn.Name = "mncDataGridViewTextBoxColumn";
            this.mncDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "url";
            this.urlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.tabControl1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Телефонный справочник";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Иерархия_населенных_пунктов.ResumeLayout(false);
            this.Операторы.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem добавитьГородToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;

        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

        private System.Windows.Forms.ImageList imageList1;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TreeView treeView1;

        #endregion

        private System.Windows.Forms.ToolStripMenuItem insertTheAreaToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Иерархия_населенных_пунктов;
        private System.Windows.Forms.TabPage Операторы;
        private System.Windows.Forms.TabPage Номера;
        private System.Windows.Forms.TabPage Телефонные_коды;
        private System.Windows.Forms.TabPage Синонимы;
        private System.Windows.Forms.TabPage Пользователи;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WorldDataSet worldDataSet;
        private System.Windows.Forms.BindingSource operBindingSource;
        private WorldDataSetTableAdapters.OperTableAdapter operTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idoperDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mvnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
    }
}