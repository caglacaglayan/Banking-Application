
namespace CG_Bank.Mudur
{
    partial class MudurGiris
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
            this.GirisButton = new System.Windows.Forms.Button();
            this.AnasayfaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TCBox = new System.Windows.Forms.TextBox();
            this.SifreBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GirisButton
            // 
            this.GirisButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GirisButton.Location = new System.Drawing.Point(258, 346);
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Size = new System.Drawing.Size(278, 74);
            this.GirisButton.TabIndex = 0;
            this.GirisButton.Text = "Giriş";
            this.GirisButton.UseVisualStyleBackColor = true;
            this.GirisButton.Click += new System.EventHandler(this.GirisButton_Click);
            // 
            // AnasayfaButton
            // 
            this.AnasayfaButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AnasayfaButton.Location = new System.Drawing.Point(12, 12);
            this.AnasayfaButton.Name = "AnasayfaButton";
            this.AnasayfaButton.Size = new System.Drawing.Size(182, 48);
            this.AnasayfaButton.TabIndex = 1;
            this.AnasayfaButton.Text = "Anasayfa";
            this.AnasayfaButton.UseVisualStyleBackColor = true;
            this.AnasayfaButton.Click += new System.EventHandler(this.AnasayfaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(190, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(190, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // TCBox
            // 
            this.TCBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TCBox.Location = new System.Drawing.Point(324, 163);
            this.TCBox.Name = "TCBox";
            this.TCBox.PlaceholderText = "TC No";
            this.TCBox.Size = new System.Drawing.Size(256, 45);
            this.TCBox.TabIndex = 5;
            // 
            // SifreBox
            // 
            this.SifreBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SifreBox.Location = new System.Drawing.Point(324, 229);
            this.SifreBox.Name = "SifreBox";
            this.SifreBox.PasswordChar = '*';
            this.SifreBox.PlaceholderText = "Şifre";
            this.SifreBox.Size = new System.Drawing.Size(256, 45);
            this.SifreBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(278, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 48);
            this.label3.TabIndex = 7;
            this.label3.Text = "Müdür Girişi";
            // 
            // MudurGiris
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
            this.Name = "MudurGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müdür Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GirisButton;
        private System.Windows.Forms.Button AnasayfaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TCBox;
        private System.Windows.Forms.TextBox SifreBox;
        private System.Windows.Forms.Label label3;
    }
}