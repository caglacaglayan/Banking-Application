
namespace CG_Bank.Temsilci
{
    partial class TemsilciGiris
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
            this.label3 = new System.Windows.Forms.Label();
            this.SifreBox = new System.Windows.Forms.TextBox();
            this.TCBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AnasayfaButton = new System.Windows.Forms.Button();
            this.GirisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(286, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 48);
            this.label3.TabIndex = 21;
            this.label3.Text = "Temsilci Girişi";
            // 
            // SifreBox
            // 
            this.SifreBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SifreBox.Location = new System.Drawing.Point(332, 231);
            this.SifreBox.Name = "SifreBox";
            this.SifreBox.PasswordChar = '*';
            this.SifreBox.PlaceholderText = "Şifre";
            this.SifreBox.Size = new System.Drawing.Size(256, 45);
            this.SifreBox.TabIndex = 20;
            // 
            // TCBox
            // 
            this.TCBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TCBox.Location = new System.Drawing.Point(332, 165);
            this.TCBox.Name = "TCBox";
            this.TCBox.PlaceholderText = "TC No";
            this.TCBox.Size = new System.Drawing.Size(256, 45);
            this.TCBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(198, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 38);
            this.label2.TabIndex = 18;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(198, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "TC No:";
            // 
            // AnasayfaButton
            // 
            this.AnasayfaButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AnasayfaButton.Location = new System.Drawing.Point(20, 14);
            this.AnasayfaButton.Name = "AnasayfaButton";
            this.AnasayfaButton.Size = new System.Drawing.Size(182, 48);
            this.AnasayfaButton.TabIndex = 16;
            this.AnasayfaButton.Text = "Anasayfa";
            this.AnasayfaButton.UseVisualStyleBackColor = true;
            this.AnasayfaButton.Click += new System.EventHandler(this.AnasayfaButton_Click);
            // 
            // GirisButton
            // 
            this.GirisButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GirisButton.Location = new System.Drawing.Point(266, 348);
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Size = new System.Drawing.Size(278, 74);
            this.GirisButton.TabIndex = 15;
            this.GirisButton.Text = "Giriş";
            this.GirisButton.UseVisualStyleBackColor = true;
            this.GirisButton.Click += new System.EventHandler(this.GirisButton_Click);
            // 
            // TemsilciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SifreBox);
            this.Controls.Add(this.TCBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnasayfaButton);
            this.Controls.Add(this.GirisButton);
            this.Name = "TemsilciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temsilci Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SifreBox;
        private System.Windows.Forms.TextBox TCBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AnasayfaButton;
        private System.Windows.Forms.Button GirisButton;
    }
}