using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class CityForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CityForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название города";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(252, 241);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress_1);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(249, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество районов";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(31, 242);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 22);
            this.textBox3.TabIndex = 5;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(30, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 47);
            this.label3.TabIndex = 4;
            this.label3.Text = "Временная зона, \r\nотклонение времени\r\nот GMT(UTC)";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(252, 141);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(168, 22);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(251, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Долгота";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(252, 65);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(168, 22);
            this.textBox5.TabIndex = 7;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(251, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Широта";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(252, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(479, 65);
            this.textBox6.MaxLength = 4;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(168, 22);
            this.textBox6.TabIndex = 12;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(478, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Телефонный код города";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(481, 300);
            this.textBox7.MaxLength = 1;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(168, 22);
            this.textBox7.TabIndex = 14;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(476, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 187);
            this.label7.TabIndex = 13;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(252, 334);
            this.textBox8.MaxLength = 3;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(191, 22);
            this.textBox8.TabIndex = 16;
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8_KeyPress);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(251, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Iso";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(31, 334);
            this.textBox9.MaxLength = 1;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(168, 22);
            this.textBox9.TabIndex = 18;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox9_KeyPress);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(30, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 55);
            this.label9.TabIndex = 17;
            this.label9.Text = "1-город, 2-поселок,\r\n 3-село, 4-деревня,\r\n 5-станица, 6-хутор";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(479, 378);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(222, 22);
            this.textBox10.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(478, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Почтовый код (Индекс)";
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(29, 65);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(168, 22);
            this.textBox11.TabIndex = 22;
            this.textBox11.Text = "0";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(28, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(212, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "Id";
            // 
            // CityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 441);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "CityForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label11;
    }
}