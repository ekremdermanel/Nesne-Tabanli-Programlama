namespace Takimlar
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
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnGs = new System.Windows.Forms.Button();
            this.btnFb = new System.Windows.Forms.Button();
            this.btnBjk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMesaj
            // 
            this.lblMesaj.BackColor = System.Drawing.Color.Silver;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.Location = new System.Drawing.Point(123, 246);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(425, 147);
            this.lblMesaj.TabIndex = 0;
            this.lblMesaj.Text = "Takım Seç";
            this.lblMesaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMesaj.Click += new System.EventHandler(this.LblMesaj_Click);
            // 
            // btnGs
            // 
            this.btnGs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGs.ForeColor = System.Drawing.Color.Yellow;
            this.btnGs.Location = new System.Drawing.Point(128, 163);
            this.btnGs.Name = "btnGs";
            this.btnGs.Size = new System.Drawing.Size(135, 41);
            this.btnGs.TabIndex = 1;
            this.btnGs.Text = "Galatasaray";
            this.btnGs.UseVisualStyleBackColor = false;
            this.btnGs.Click += new System.EventHandler(this.BtnGs_Click);
            // 
            // btnFb
            // 
            this.btnFb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnFb.ForeColor = System.Drawing.Color.Yellow;
            this.btnFb.Location = new System.Drawing.Point(272, 163);
            this.btnFb.Name = "btnFb";
            this.btnFb.Size = new System.Drawing.Size(135, 41);
            this.btnFb.TabIndex = 2;
            this.btnFb.Text = "Fenerbahçe";
            this.btnFb.UseVisualStyleBackColor = false;
            // 
            // btnBjk
            // 
            this.btnBjk.BackColor = System.Drawing.Color.Black;
            this.btnBjk.ForeColor = System.Drawing.Color.White;
            this.btnBjk.Location = new System.Drawing.Point(413, 163);
            this.btnBjk.Name = "btnBjk";
            this.btnBjk.Size = new System.Drawing.Size(135, 41);
            this.btnBjk.TabIndex = 3;
            this.btnBjk.Text = "Beşiktaş";
            this.btnBjk.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(676, 486);
            this.Controls.Add(this.btnBjk);
            this.Controls.Add(this.btnFb);
            this.Controls.Add(this.btnGs);
            this.Controls.Add(this.lblMesaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnGs;
        private System.Windows.Forms.Button btnFb;
        private System.Windows.Forms.Button btnBjk;
    }
}

