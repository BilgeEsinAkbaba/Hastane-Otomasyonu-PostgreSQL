
namespace veritabaniproje
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guncelleButton = new System.Windows.Forms.Button();
            this.tcLBguncelle = new System.Windows.Forms.Label();
            this.adSoyadLBguncelle = new System.Windows.Forms.Label();
            this.sehirCBguncelle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTBguncelle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "TckNo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 341);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şehir:";
            // 
            // guncelleButton
            // 
            this.guncelleButton.BackColor = System.Drawing.Color.SteelBlue;
            this.guncelleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guncelleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guncelleButton.Location = new System.Drawing.Point(181, 411);
            this.guncelleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(145, 47);
            this.guncelleButton.TabIndex = 5;
            this.guncelleButton.Text = "Güncelle";
            this.guncelleButton.UseVisualStyleBackColor = false;
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // tcLBguncelle
            // 
            this.tcLBguncelle.AutoSize = true;
            this.tcLBguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcLBguncelle.Location = new System.Drawing.Point(175, 214);
            this.tcLBguncelle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tcLBguncelle.Name = "tcLBguncelle";
            this.tcLBguncelle.Size = new System.Drawing.Size(33, 29);
            this.tcLBguncelle.TabIndex = 6;
            this.tcLBguncelle.Text = "tc";
            // 
            // adSoyadLBguncelle
            // 
            this.adSoyadLBguncelle.AutoSize = true;
            this.adSoyadLBguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adSoyadLBguncelle.Location = new System.Drawing.Point(175, 155);
            this.adSoyadLBguncelle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adSoyadLBguncelle.Name = "adSoyadLBguncelle";
            this.adSoyadLBguncelle.Size = new System.Drawing.Size(98, 29);
            this.adSoyadLBguncelle.TabIndex = 7;
            this.adSoyadLBguncelle.Text = "anonim";
            // 
            // sehirCBguncelle
            // 
            this.sehirCBguncelle.FormattingEnabled = true;
            this.sehirCBguncelle.Location = new System.Drawing.Point(181, 341);
            this.sehirCBguncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sehirCBguncelle.Name = "sehirCBguncelle";
            this.sehirCBguncelle.Size = new System.Drawing.Size(160, 24);
            this.sehirCBguncelle.TabIndex = 8;
            this.sehirCBguncelle.SelectedIndexChanged += new System.EventHandler(this.sehirCBguncelle_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 282);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password:";
            // 
            // passwordTBguncelle
            // 
            this.passwordTBguncelle.Location = new System.Drawing.Point(180, 289);
            this.passwordTBguncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTBguncelle.Name = "passwordTBguncelle";
            this.passwordTBguncelle.Size = new System.Drawing.Size(161, 22);
            this.passwordTBguncelle.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(181, 490);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::veritabaniproje.Properties.Resources.personicon;
            this.pictureBox1.Location = new System.Drawing.Point(140, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(452, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordTBguncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sehirCBguncelle);
            this.Controls.Add(this.adSoyadLBguncelle);
            this.Controls.Add(this.tcLBguncelle);
            this.Controls.Add(this.guncelleButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button guncelleButton;
        private System.Windows.Forms.Label tcLBguncelle;
        private System.Windows.Forms.Label adSoyadLBguncelle;
        private System.Windows.Forms.ComboBox sehirCBguncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTBguncelle;
        private System.Windows.Forms.Button button1;
    }
}