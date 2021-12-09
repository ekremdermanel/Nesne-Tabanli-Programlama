namespace GizleGoster2
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
            this.btnGizleGoster = new System.Windows.Forms.Button();
            this.pbResim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGizleGoster
            // 
            this.btnGizleGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGizleGoster.Location = new System.Drawing.Point(125, 62);
            this.btnGizleGoster.Name = "btnGizleGoster";
            this.btnGizleGoster.Size = new System.Drawing.Size(245, 52);
            this.btnGizleGoster.TabIndex = 0;
            this.btnGizleGoster.Text = "Gizle";
            this.btnGizleGoster.UseVisualStyleBackColor = true;
            this.btnGizleGoster.Click += new System.EventHandler(this.BtnGizleGoster_Click);
            // 
            // pbResim
            // 
            this.pbResim.Image = global::GizleGoster2.Properties.Resources.resim;
            this.pbResim.Location = new System.Drawing.Point(125, 142);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(245, 148);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 1;
            this.pbResim.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 399);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.btnGizleGoster);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGizleGoster;
        private System.Windows.Forms.PictureBox pbResim;
    }
}

