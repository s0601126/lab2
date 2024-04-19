namespace lab021
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.picCloudy = new System.Windows.Forms.PictureBox();
            this.picRainy = new System.Windows.Forms.PictureBox();
            this.picSnowy = new System.Windows.Forms.PictureBox();
            this.picSunny = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloudy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRainy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnowy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSunny)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your name here:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(620, 73);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.textBox1.Location = new System.Drawing.Point(201, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(28, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 219);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 183);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(53, 16);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Sunny";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 16);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cloudy";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 128);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(55, 16);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Snowy";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 83);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 16);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Rainy";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // picCloudy
            // 
            this.picCloudy.Image = ((System.Drawing.Image)(resources.GetObject("picCloudy.Image")));
            this.picCloudy.Location = new System.Drawing.Point(276, 84);
            this.picCloudy.Name = "picCloudy";
            this.picCloudy.Size = new System.Drawing.Size(96, 99);
            this.picCloudy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCloudy.TabIndex = 4;
            this.picCloudy.TabStop = false;
            this.picCloudy.Click += new System.EventHandler(this.picCloudy_Click);
            // 
            // picRainy
            // 
            this.picRainy.Image = ((System.Drawing.Image)(resources.GetObject("picRainy.Image")));
            this.picRainy.Location = new System.Drawing.Point(378, 84);
            this.picRainy.Name = "picRainy";
            this.picRainy.Size = new System.Drawing.Size(96, 99);
            this.picRainy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picRainy.TabIndex = 5;
            this.picRainy.TabStop = false;
            this.picRainy.Click += new System.EventHandler(this.picRainy_Click);
            // 
            // picSnowy
            // 
            this.picSnowy.Image = ((System.Drawing.Image)(resources.GetObject("picSnowy.Image")));
            this.picSnowy.Location = new System.Drawing.Point(276, 189);
            this.picSnowy.Name = "picSnowy";
            this.picSnowy.Size = new System.Drawing.Size(96, 99);
            this.picSnowy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSnowy.TabIndex = 6;
            this.picSnowy.TabStop = false;
            this.picSnowy.Click += new System.EventHandler(this.picSnowy_Click);
            // 
            // picSunny
            // 
            this.picSunny.Image = ((System.Drawing.Image)(resources.GetObject("picSunny.Image")));
            this.picSunny.Location = new System.Drawing.Point(378, 189);
            this.picSunny.Name = "picSunny";
            this.picSunny.Size = new System.Drawing.Size(96, 99);
            this.picSunny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSunny.TabIndex = 7;
            this.picSunny.TabStop = false;
            this.picSunny.Click += new System.EventHandler(this.picSunny_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.picSunny);
            this.Controls.Add(this.picSnowy);
            this.Controls.Add(this.picRainy);
            this.Controls.Add(this.picCloudy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloudy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRainy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnowy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSunny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.PictureBox picCloudy;
        private System.Windows.Forms.PictureBox picRainy;
        private System.Windows.Forms.PictureBox picSnowy;
        private System.Windows.Forms.PictureBox picSunny;
    }
}