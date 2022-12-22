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
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id_оператора = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Оператор = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Мобильный_оператор = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Виртуальный_оператор = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_cтраны = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Код_мобильной_сети = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Бренд_оператора = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Сайт_оператора = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.Номера = new System.Windows.Forms.TabPage();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Телефонные_коды = new System.Windows.Forms.TabPage();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Пользователи = new System.Windows.Forms.TabPage();
            this.contextMenuStrip5 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.operBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldDataSet = new WindowsFormsApp1.WorldDataSet();
            this.operTableAdapter = new WindowsFormsApp1.WorldDataSetTableAdapters.OperTableAdapter();
            this.сделатьАдминомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Иерархия_населенных_пунктов.SuspendLayout();
            this.Операторы.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.Номера.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.Телефонные_коды.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
            this.Пользователи.SuspendLayout();
            this.contextMenuStrip5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldDataSet)).BeginInit();
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(205, 148);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить страну";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.InsertTheCountry);
            // 
            // insertTheAreaToolStripMenuItem
            // 
            this.insertTheAreaToolStripMenuItem.Name = "insertTheAreaToolStripMenuItem";
            this.insertTheAreaToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.insertTheAreaToolStripMenuItem.Text = "Добавить область";
            this.insertTheAreaToolStripMenuItem.Click += new System.EventHandler(this.insertTheAreaToolStripMenuItem_Click);
            // 
            // добавитьГородToolStripMenuItem
            // 
            this.добавитьГородToolStripMenuItem.Name = "добавитьГородToolStripMenuItem";
            this.добавитьГородToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.добавитьГородToolStripMenuItem.Text = "Добавить город";
            this.добавитьГородToolStripMenuItem.Click += new System.EventHandler(this.InsertTheCity);
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(204, 24);
            this.добавитьToolStripMenuItem1.Text = "Добавить район";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.InsertTheDistrict);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.updateToolStripMenuItem.Text = "Изменить";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
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
            this.tabControl1.Controls.Add(this.Пользователи);
            this.tabControl1.Location = new System.Drawing.Point(1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 450);
            this.tabControl1.TabIndex = 3;
            // 
            // Иерархия_населенных_пунктов
            // 
            this.Иерархия_населенных_пунктов.ContextMenuStrip = this.contextMenuStrip1;
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
            this.Операторы.ContextMenuStrip = this.contextMenuStrip2;
            this.Операторы.Controls.Add(this.listView1);
            this.Операторы.Controls.Add(this.button2);
            this.Операторы.Location = new System.Drawing.Point(4, 25);
            this.Операторы.Name = "Операторы";
            this.Операторы.Padding = new System.Windows.Forms.Padding(3);
            this.Операторы.Size = new System.Drawing.Size(790, 421);
            this.Операторы.TabIndex = 1;
            this.Операторы.Text = "Операторы";
            this.Операторы.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem2,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(148, 76);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // добавитьToolStripMenuItem2
            // 
            this.добавитьToolStripMenuItem2.Name = "добавитьToolStripMenuItem2";
            this.добавитьToolStripMenuItem2.Size = new System.Drawing.Size(147, 24);
            this.добавитьToolStripMenuItem2.Text = "Добавить";
            this.добавитьToolStripMenuItem2.Click += new System.EventHandler(this.добавитьToolStripMenuItem2_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(147, 24);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_оператора,
            this.Оператор,
            this.Мобильный_оператор,
            this.Виртуальный_оператор,
            this.id_cтраны,
            this.Код_мобильной_сети,
            this.Бренд_оператора,
            this.Сайт_оператора});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(794, 371);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // id_оператора
            // 
            this.id_оператора.Text = "id оператора";
            // 
            // Оператор
            // 
            this.Оператор.Text = "Оператор";
            this.Оператор.Width = 100;
            // 
            // Мобильный_оператор
            // 
            this.Мобильный_оператор.Text = "Мобильный оператор";
            this.Мобильный_оператор.Width = 150;
            // 
            // Виртуальный_оператор
            // 
            this.Виртуальный_оператор.Text = "Виртуальный оператор";
            this.Виртуальный_оператор.Width = 150;
            // 
            // id_cтраны
            // 
            this.id_cтраны.Text = "id cтраны";
            this.id_cтраны.Width = 100;
            // 
            // Код_мобильной_сети
            // 
            this.Код_мобильной_сети.Text = "Код мобильной сети";
            this.Код_мобильной_сети.Width = 150;
            // 
            // Бренд_оператора
            // 
            this.Бренд_оператора.Text = "Бренд оператора";
            this.Бренд_оператора.Width = 100;
            // 
            // Сайт_оператора
            // 
            this.Сайт_оператора.Text = "Сайт оператора";
            this.Сайт_оператора.Width = 100;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(585, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 36);
            this.button2.TabIndex = 0;
            this.button2.Text = "Загрузить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Номера
            // 
            this.Номера.ContextMenuStrip = this.contextMenuStrip3;
            this.Номера.Controls.Add(this.button3);
            this.Номера.Controls.Add(this.listView2);
            this.Номера.Location = new System.Drawing.Point(4, 25);
            this.Номера.Name = "Номера";
            this.Номера.Size = new System.Drawing.Size(790, 421);
            this.Номера.TabIndex = 2;
            this.Номера.Text = "Номера";
            this.Номера.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem3,
            this.изменитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem2});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(148, 76);
            this.contextMenuStrip3.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip3_Opening);
            // 
            // добавитьToolStripMenuItem3
            // 
            this.добавитьToolStripMenuItem3.Name = "добавитьToolStripMenuItem3";
            this.добавитьToolStripMenuItem3.Size = new System.Drawing.Size(147, 24);
            this.добавитьToolStripMenuItem3.Text = "Добавить";
            this.добавитьToolStripMenuItem3.Click += new System.EventHandler(this.добавитьToolStripMenuItem3_Click);
            // 
            // изменитьToolStripMenuItem1
            // 
            this.изменитьToolStripMenuItem1.Name = "изменитьToolStripMenuItem1";
            this.изменитьToolStripMenuItem1.Size = new System.Drawing.Size(147, 24);
            this.изменитьToolStripMenuItem1.Text = "Изменить";
            this.изменитьToolStripMenuItem1.Click += new System.EventHandler(this.изменитьToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem2
            // 
            this.удалитьToolStripMenuItem2.Name = "удалитьToolStripMenuItem2";
            this.удалитьToolStripMenuItem2.Size = new System.Drawing.Size(147, 24);
            this.удалитьToolStripMenuItem2.Text = "Удалить";
            this.удалитьToolStripMenuItem2.Click += new System.EventHandler(this.удалитьToolStripMenuItem2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(549, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Загрузить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(-4, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(794, 371);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Номер телефона";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "id оператора";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "id города";
            this.columnHeader3.Width = 100;
            // 
            // Телефонные_коды
            // 
            this.Телефонные_коды.ContextMenuStrip = this.contextMenuStrip4;
            this.Телефонные_коды.Controls.Add(this.button4);
            this.Телефонные_коды.Controls.Add(this.listView3);
            this.Телефонные_коды.Location = new System.Drawing.Point(4, 25);
            this.Телефонные_коды.Name = "Телефонные_коды";
            this.Телефонные_коды.Size = new System.Drawing.Size(790, 421);
            this.Телефонные_коды.TabIndex = 3;
            this.Телефонные_коды.Text = "Телефонные коды";
            this.Телефонные_коды.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem4,
            this.изменитьToolStripMenuItem2,
            this.удалитьToolStripMenuItem3});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(148, 76);
            this.contextMenuStrip4.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip4_Opening);
            // 
            // добавитьToolStripMenuItem4
            // 
            this.добавитьToolStripMenuItem4.Name = "добавитьToolStripMenuItem4";
            this.добавитьToolStripMenuItem4.Size = new System.Drawing.Size(147, 24);
            this.добавитьToolStripMenuItem4.Text = "Добавить";
            this.добавитьToolStripMenuItem4.Click += new System.EventHandler(this.добавитьToolStripMenuItem4_Click);
            // 
            // изменитьToolStripMenuItem2
            // 
            this.изменитьToolStripMenuItem2.Name = "изменитьToolStripMenuItem2";
            this.изменитьToolStripMenuItem2.Size = new System.Drawing.Size(147, 24);
            this.изменитьToolStripMenuItem2.Text = "Изменить";
            this.изменитьToolStripMenuItem2.Click += new System.EventHandler(this.изменитьToolStripMenuItem2_Click);
            // 
            // удалитьToolStripMenuItem3
            // 
            this.удалитьToolStripMenuItem3.Name = "удалитьToolStripMenuItem3";
            this.удалитьToolStripMenuItem3.Size = new System.Drawing.Size(147, 24);
            this.удалитьToolStripMenuItem3.Text = "Удалить";
            this.удалитьToolStripMenuItem3.Click += new System.EventHandler(this.удалитьToolStripMenuItem3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(538, 377);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "Загрузить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader10});
            this.listView3.FullRowSelect = true;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(-4, 0);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(794, 371);
            this.listView3.TabIndex = 3;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "id города";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "id оператора";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Начало диапазона";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Конец диапазона";
            this.columnHeader10.Width = 150;
            // 
            // Пользователи
            // 
            this.Пользователи.ContextMenuStrip = this.contextMenuStrip5;
            this.Пользователи.Controls.Add(this.button5);
            this.Пользователи.Controls.Add(this.listView4);
            this.Пользователи.Location = new System.Drawing.Point(4, 25);
            this.Пользователи.Name = "Пользователи";
            this.Пользователи.Size = new System.Drawing.Size(790, 421);
            this.Пользователи.TabIndex = 5;
            this.Пользователи.Text = "Пользователи";
            this.Пользователи.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip5
            // 
            this.contextMenuStrip5.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.сделатьАдминомToolStripMenuItem});
            this.contextMenuStrip5.Name = "contextMenuStrip4";
            this.contextMenuStrip5.Size = new System.Drawing.Size(211, 80);
            this.contextMenuStrip5.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip5_Opening);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem3.Text = "Удалить";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(579, 377);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 36);
            this.button5.TabIndex = 5;
            this.button5.Text = "Загрузить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader11});
            this.listView4.FullRowSelect = true;
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(-4, 0);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(794, 371);
            this.listView4.TabIndex = 4;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Логин";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Пароль";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Админка";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Соль";
            // 
            // operBindingSource
            // 
            this.operBindingSource.DataMember = "Oper";
            this.operBindingSource.DataSource = this.worldDataSet;
            // 
            // worldDataSet
            // 
            this.worldDataSet.DataSetName = "WorldDataSet";
            this.worldDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operTableAdapter
            // 
            this.operTableAdapter.ClearBeforeFill = true;
            // 
            // сделатьАдминомToolStripMenuItem
            // 
            this.сделатьАдминомToolStripMenuItem.Name = "сделатьАдминомToolStripMenuItem";
            this.сделатьАдминомToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.сделатьАдминомToolStripMenuItem.Text = "Сделать админом";
            this.сделатьАдминомToolStripMenuItem.Click += new System.EventHandler(this.сделатьАдминомToolStripMenuItem_Click);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Иерархия_населенных_пунктов.ResumeLayout(false);
            this.Операторы.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.Номера.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.Телефонные_коды.ResumeLayout(false);
            this.contextMenuStrip4.ResumeLayout(false);
            this.Пользователи.ResumeLayout(false);
            this.contextMenuStrip5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.operBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldDataSet)).EndInit();
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
        private System.Windows.Forms.TabPage Номера;
        private System.Windows.Forms.TabPage Телефонные_коды;
        private System.Windows.Forms.TabPage Пользователи;
        private WorldDataSet worldDataSet;
        private System.Windows.Forms.BindingSource operBindingSource;
        private WorldDataSetTableAdapters.OperTableAdapter operTableAdapter;
        private System.Windows.Forms.TabPage Операторы;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id_cтраны;
        private System.Windows.Forms.ColumnHeader Оператор;
        private System.Windows.Forms.ColumnHeader Мобильный_оператор;
        private System.Windows.Forms.ColumnHeader Виртуальный_оператор;
        private System.Windows.Forms.ColumnHeader Бренд_оператора;
        private System.Windows.Forms.ColumnHeader Сайт_оператора;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ColumnHeader id_оператора;
        private System.Windows.Forms.ColumnHeader Код_мобильной_сети;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ToolStripMenuItem сделатьАдминомToolStripMenuItem;
    }
}