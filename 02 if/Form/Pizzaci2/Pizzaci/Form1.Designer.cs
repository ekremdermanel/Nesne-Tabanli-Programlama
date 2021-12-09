namespace Pizzaci
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.pbPizzaSecim = new System.Windows.Forms.PictureBox();
            this.lblPizza = new System.Windows.Forms.Label();
            this.lblKenar = new System.Windows.Forms.Label();
            this.pbKenarSecim = new System.Windows.Forms.PictureBox();
            this.pbKetcap = new System.Windows.Forms.PictureBox();
            this.pbMayonez = new System.Windows.Forms.PictureBox();
            this.pbHardal = new System.Windows.Forms.PictureBox();
            this.pbAciSos = new System.Windows.Forms.PictureBox();
            this.pbToplam = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPizzaSecim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKenarSecim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKetcap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMayonez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHardal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAciSos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbToplam)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPizza);
            this.groupBox1.Controls.Add(this.pbPizzaSecim);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza Seçimi";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Peynirli Pizza (50 TL)",
            "Mantarlı Pizza (60 TL)",
            "Karışık Pizza (80 TL)"});
            this.comboBox1.Location = new System.Drawing.Point(25, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 117);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblKenar);
            this.groupBox2.Controls.Add(this.pbKenarSecim);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(257, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kenar Seçimi";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(27, 111);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(203, 28);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Peynirli Kenar (10TL)";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(27, 77);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(124, 28);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Kalın Kenar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(119, 28);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "İnce Kenar";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pbAciSos);
            this.groupBox3.Controls.Add(this.pbHardal);
            this.groupBox3.Controls.Add(this.pbMayonez);
            this.groupBox3.Controls.Add(this.pbKetcap);
            this.groupBox3.Controls.Add(this.btnHesapla);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(502, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 284);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sos Seçimi";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(133, 233);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(128, 35);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Her biri 3 TL";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(146, 78);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(93, 28);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Acı Sos";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(146, 42);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(84, 28);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Hardal";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(20, 76);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(106, 28);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Mayonez";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 28);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Ketçap";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(104, 352);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(151, 25);
            this.lblToplam.TabIndex = 4;
            this.lblToplam.Text = "Toplam Tutar";
            this.lblToplam.Visible = false;
            // 
            // pbPizzaSecim
            // 
            this.pbPizzaSecim.Image = global::Pizzaci.Properties.Resources.hayir;
            this.pbPizzaSecim.Location = new System.Drawing.Point(25, 212);
            this.pbPizzaSecim.Name = "pbPizzaSecim";
            this.pbPizzaSecim.Size = new System.Drawing.Size(43, 36);
            this.pbPizzaSecim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPizzaSecim.TabIndex = 1;
            this.pbPizzaSecim.TabStop = false;
            // 
            // lblPizza
            // 
            this.lblPizza.AutoSize = true;
            this.lblPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPizza.Location = new System.Drawing.Point(74, 219);
            this.lblPizza.Name = "lblPizza";
            this.lblPizza.Size = new System.Drawing.Size(119, 20);
            this.lblPizza.TabIndex = 2;
            this.lblPizza.Text = "Pizza Seçilmedi";
            // 
            // lblKenar
            // 
            this.lblKenar.AutoSize = true;
            this.lblKenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKenar.Location = new System.Drawing.Point(76, 219);
            this.lblKenar.Name = "lblKenar";
            this.lblKenar.Size = new System.Drawing.Size(123, 20);
            this.lblKenar.TabIndex = 4;
            this.lblKenar.Text = "Kenar Seçilmedi";
            // 
            // pbKenarSecim
            // 
            this.pbKenarSecim.Image = global::Pizzaci.Properties.Resources.hayir;
            this.pbKenarSecim.Location = new System.Drawing.Point(27, 212);
            this.pbKenarSecim.Name = "pbKenarSecim";
            this.pbKenarSecim.Size = new System.Drawing.Size(43, 36);
            this.pbKenarSecim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKenarSecim.TabIndex = 3;
            this.pbKenarSecim.TabStop = false;
            // 
            // pbKetcap
            // 
            this.pbKetcap.Image = global::Pizzaci.Properties.Resources.ketcap;
            this.pbKetcap.Location = new System.Drawing.Point(20, 167);
            this.pbKetcap.Name = "pbKetcap";
            this.pbKetcap.Size = new System.Drawing.Size(43, 53);
            this.pbKetcap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKetcap.TabIndex = 6;
            this.pbKetcap.TabStop = false;
            this.pbKetcap.Visible = false;
            // 
            // pbMayonez
            // 
            this.pbMayonez.Image = global::Pizzaci.Properties.Resources.mayonez;
            this.pbMayonez.Location = new System.Drawing.Point(69, 167);
            this.pbMayonez.Name = "pbMayonez";
            this.pbMayonez.Size = new System.Drawing.Size(43, 53);
            this.pbMayonez.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMayonez.TabIndex = 7;
            this.pbMayonez.TabStop = false;
            this.pbMayonez.Visible = false;
            // 
            // pbHardal
            // 
            this.pbHardal.Image = global::Pizzaci.Properties.Resources.hardal;
            this.pbHardal.Location = new System.Drawing.Point(118, 167);
            this.pbHardal.Name = "pbHardal";
            this.pbHardal.Size = new System.Drawing.Size(43, 53);
            this.pbHardal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHardal.TabIndex = 8;
            this.pbHardal.TabStop = false;
            this.pbHardal.Visible = false;
            // 
            // pbAciSos
            // 
            this.pbAciSos.Image = global::Pizzaci.Properties.Resources.acisos;
            this.pbAciSos.Location = new System.Drawing.Point(167, 167);
            this.pbAciSos.Name = "pbAciSos";
            this.pbAciSos.Size = new System.Drawing.Size(43, 53);
            this.pbAciSos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAciSos.TabIndex = 9;
            this.pbAciSos.TabStop = false;
            this.pbAciSos.Visible = false;
            // 
            // pbToplam
            // 
            this.pbToplam.Image = global::Pizzaci.Properties.Resources.pizza;
            this.pbToplam.Location = new System.Drawing.Point(13, 352);
            this.pbToplam.Name = "pbToplam";
            this.pbToplam.Size = new System.Drawing.Size(85, 77);
            this.pbToplam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbToplam.TabIndex = 5;
            this.pbToplam.TabStop = false;
            this.pbToplam.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.pbToplam);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Pizzacı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPizzaSecim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKenarSecim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKetcap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMayonez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHardal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAciSos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbToplam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblPizza;
        private System.Windows.Forms.PictureBox pbPizzaSecim;
        private System.Windows.Forms.Label lblKenar;
        private System.Windows.Forms.PictureBox pbKenarSecim;
        private System.Windows.Forms.PictureBox pbAciSos;
        private System.Windows.Forms.PictureBox pbHardal;
        private System.Windows.Forms.PictureBox pbMayonez;
        private System.Windows.Forms.PictureBox pbKetcap;
        private System.Windows.Forms.PictureBox pbToplam;
    }
}

