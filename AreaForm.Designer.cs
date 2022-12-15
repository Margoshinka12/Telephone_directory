namespace WindowsFormsApp1
{
    partial class AreaForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(257, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 31);
            this.button1.TabIndex = 21;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(257, 149);
            this.textBox4.MaxLength = 3;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(168, 22);
            this.textBox4.TabIndex = 20;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(256, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Enter the iso";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(257, 73);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(168, 22);
            this.textBox5.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(256, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Enter the capital";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(36, 233);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 22);
            this.textBox3.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(35, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Enter the autocod";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(36, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 22);
            this.textBox2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(35, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter the okrug name\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter the area name\r\n";
            // 
            // AreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 311);
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
            this.Name = "AreaForm";
            this.Text = "Area";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}