
namespace CG_Bank.Musteri
{
    partial class HesapEkle
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
            this.KaydetButton = new System.Windows.Forms.Button();
            this.GeriButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BakiyeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KaydetButton
            // 
            this.KaydetButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.KaydetButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KaydetButton.Location = new System.Drawing.Point(338, 510);
            this.KaydetButton.Name = "KaydetButton";
            this.KaydetButton.Size = new System.Drawing.Size(291, 54);
            this.KaydetButton.TabIndex = 38;
            this.KaydetButton.Text = "Ekle";
            this.KaydetButton.UseVisualStyleBackColor = false;
            this.KaydetButton.Click += new System.EventHandler(this.KaydetButton_Click);
            // 
            // GeriButton
            // 
            this.GeriButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GeriButton.Location = new System.Drawing.Point(8, 13);
            this.GeriButton.Name = "GeriButton";
            this.GeriButton.Size = new System.Drawing.Size(176, 54);
            this.GeriButton.TabIndex = 37;
            this.GeriButton.Text = "Geri";
            this.GeriButton.UseVisualStyleBackColor = true;
            this.GeriButton.Click += new System.EventHandler(this.GeriButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(342, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 54);
            this.label1.TabIndex = 28;
            this.label1.Text = "Hesap Ekleme";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(342, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(391, 53);
            this.comboBox1.TabIndex = 50;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(209, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 45);
            this.label8.TabIndex = 49;
            this.label8.Text = "Doviz:";
            // 
            // BakiyeBox
            // 
            this.BakiyeBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BakiyeBox.Location = new System.Drawing.Point(342, 272);
            this.BakiyeBox.Name = "BakiyeBox";
            this.BakiyeBox.PlaceholderText = "Bakiye";
            this.BakiyeBox.Size = new System.Drawing.Size(392, 50);
            this.BakiyeBox.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(196, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 45);
            this.label7.TabIndex = 47;
            this.label7.Text = "Bakiye:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(931, 45);
            this.label2.TabIndex = 51;
            this.label2.Text = "Talebinizin onaylanması durumunda hesabınız oluşturulacaktır.";
            // 
            // HesapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(963, 651);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BakiyeBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.KaydetButton);
            this.Controls.Add(this.GeriButton);
            this.Controls.Add(this.label1);
            this.Name = "HesapEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button KaydetButton;
        private System.Windows.Forms.Button GeriButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BakiyeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}