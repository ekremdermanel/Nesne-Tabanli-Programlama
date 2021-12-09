namespace Boyutlandirma
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
            this.btnKucuk = new System.Windows.Forms.Button();
            this.btnOrta = new System.Windows.Forms.Button();
            this.btnBuyuk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYukari = new System.Windows.Forms.Button();
            this.btnAsagi = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.btnSag = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.btnSagUst = new System.Windows.Forms.Button();
            this.btnSolUst = new System.Windows.Forms.Button();
            this.btnSolAlt = new System.Windows.Forms.Button();
            this.btnSagAlt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKucuk
            // 
            this.btnKucuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKucuk.Location = new System.Drawing.Point(63, 38);
            this.btnKucuk.Name = "btnKucuk";
            this.btnKucuk.Size = new System.Drawing.Size(128, 46);
            this.btnKucuk.TabIndex = 0;
            this.btnKucuk.Text = "Küçük";
            this.btnKucuk.UseVisualStyleBackColor = true;
            this.btnKucuk.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnOrta
            // 
            this.btnOrta.Enabled = false;
            this.btnOrta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrta.Location = new System.Drawing.Point(228, 38);
            this.btnOrta.Name = "btnOrta";
            this.btnOrta.Size = new System.Drawing.Size(128, 46);
            this.btnOrta.TabIndex = 1;
            this.btnOrta.Text = "Orta";
            this.btnOrta.UseVisualStyleBackColor = true;
            this.btnOrta.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnBuyuk
            // 
            this.btnBuyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuyuk.Location = new System.Drawing.Point(401, 38);
            this.btnBuyuk.Name = "btnBuyuk";
            this.btnBuyuk.Size = new System.Drawing.Size(128, 46);
            this.btnBuyuk.TabIndex = 2;
            this.btnBuyuk.Text = "Büyük";
            this.btnBuyuk.UseVisualStyleBackColor = true;
            this.btnBuyuk.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(200, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 70);
            this.label1.TabIndex = 3;
            this.label1.Text = "Merhaba";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYukari
            // 
            this.btnYukari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYukari.Location = new System.Drawing.Point(228, 300);
            this.btnYukari.Name = "btnYukari";
            this.btnYukari.Size = new System.Drawing.Size(128, 53);
            this.btnYukari.TabIndex = 4;
            this.btnYukari.Text = "Yukarı";
            this.btnYukari.UseVisualStyleBackColor = true;
            this.btnYukari.Click += new System.EventHandler(this.BtnYukari_Click);
            // 
            // btnAsagi
            // 
            this.btnAsagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAsagi.Location = new System.Drawing.Point(228, 420);
            this.btnAsagi.Name = "btnAsagi";
            this.btnAsagi.Size = new System.Drawing.Size(128, 53);
            this.btnAsagi.TabIndex = 5;
            this.btnAsagi.Text = "Aşağı";
            this.btnAsagi.UseVisualStyleBackColor = true;
            this.btnAsagi.Click += new System.EventHandler(this.BtnAsagi_Click);
            // 
            // btnSol
            // 
            this.btnSol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSol.Location = new System.Drawing.Point(94, 361);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(128, 53);
            this.btnSol.TabIndex = 6;
            this.btnSol.Text = "Sol";
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.BtnSol_Click);
            // 
            // btnSag
            // 
            this.btnSag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSag.Location = new System.Drawing.Point(362, 361);
            this.btnSag.Name = "btnSag";
            this.btnSag.Size = new System.Drawing.Size(128, 53);
            this.btnSag.TabIndex = 7;
            this.btnSag.Text = "Sağ";
            this.btnSag.UseVisualStyleBackColor = true;
            this.btnSag.Click += new System.EventHandler(this.BtnSag_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifirla.Location = new System.Drawing.Point(228, 361);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(128, 53);
            this.btnSifirla.TabIndex = 8;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.BtnSifirla_Click_1);
            // 
            // btnSagUst
            // 
            this.btnSagUst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSagUst.Location = new System.Drawing.Point(362, 300);
            this.btnSagUst.Name = "btnSagUst";
            this.btnSagUst.Size = new System.Drawing.Size(128, 53);
            this.btnSagUst.TabIndex = 9;
            this.btnSagUst.Text = "Sağ Üst";
            this.btnSagUst.UseVisualStyleBackColor = true;
            this.btnSagUst.Click += new System.EventHandler(this.BtnSagUst_Click);
            // 
            // btnSolUst
            // 
            this.btnSolUst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSolUst.Location = new System.Drawing.Point(94, 300);
            this.btnSolUst.Name = "btnSolUst";
            this.btnSolUst.Size = new System.Drawing.Size(128, 53);
            this.btnSolUst.TabIndex = 10;
            this.btnSolUst.Text = "Sol Üst";
            this.btnSolUst.UseVisualStyleBackColor = true;
            // 
            // btnSolAlt
            // 
            this.btnSolAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSolAlt.Location = new System.Drawing.Point(94, 420);
            this.btnSolAlt.Name = "btnSolAlt";
            this.btnSolAlt.Size = new System.Drawing.Size(128, 53);
            this.btnSolAlt.TabIndex = 11;
            this.btnSolAlt.Text = "Sol Alt";
            this.btnSolAlt.UseVisualStyleBackColor = true;
            // 
            // btnSagAlt
            // 
            this.btnSagAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSagAlt.Location = new System.Drawing.Point(362, 420);
            this.btnSagAlt.Name = "btnSagAlt";
            this.btnSagAlt.Size = new System.Drawing.Size(128, 53);
            this.btnSagAlt.TabIndex = 12;
            this.btnSagAlt.Text = "Sağ Alt";
            this.btnSagAlt.UseVisualStyleBackColor = true;
            this.btnSagAlt.Click += new System.EventHandler(this.BtnSagAlt_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(228, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "KAPAT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 607);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSagAlt);
            this.Controls.Add(this.btnSolAlt);
            this.Controls.Add(this.btnSolUst);
            this.Controls.Add(this.btnSagUst);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnSag);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.btnAsagi);
            this.Controls.Add(this.btnYukari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuyuk);
            this.Controls.Add(this.btnOrta);
            this.Controls.Add(this.btnKucuk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKucuk;
        private System.Windows.Forms.Button btnOrta;
        private System.Windows.Forms.Button btnBuyuk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYukari;
        private System.Windows.Forms.Button btnAsagi;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.Button btnSag;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.Button btnSagUst;
        private System.Windows.Forms.Button btnSolUst;
        private System.Windows.Forms.Button btnSolAlt;
        private System.Windows.Forms.Button btnSagAlt;
        private System.Windows.Forms.Button button1;
    }
}

