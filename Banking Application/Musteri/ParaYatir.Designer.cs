
namespace CG_Bank.Musteri
{
    partial class ParaYatir
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
            this.label2 = new System.Windows.Forms.Label();
            this.GeriButton = new System.Windows.Forms.Button();
            this.ParaYatirButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TutarBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(365, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 48);
            this.label2.TabIndex = 19;
            this.label2.Text = "Para Yatır";
            // 
            // GeriButton
            // 
            this.GeriButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GeriButton.Location = new System.Drawing.Point(12, 12);
            this.GeriButton.Name = "GeriButton";
            this.GeriButton.Size = new System.Drawing.Size(191, 54);
            this.GeriButton.TabIndex = 18;
            this.GeriButton.Text = "Geri";
            this.GeriButton.UseVisualStyleBackColor = true;
            this.GeriButton.Click += new System.EventHandler(this.GeriButton_Click);
            // 
            // ParaYatirButton
            // 
            this.ParaYatirButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ParaYatirButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ParaYatirButton.Location = new System.Drawing.Point(324, 498);
            this.ParaYatirButton.Name = "ParaYatirButton";
            this.ParaYatirButton.Size = new System.Drawing.Size(291, 54);
            this.ParaYatirButton.TabIndex = 57;
            this.ParaYatirButton.Text = "Yatır";
            this.ParaYatirButton.UseVisualStyleBackColor = false;
            this.ParaYatirButton.Click += new System.EventHandler(this.ParaYatirButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(185, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 45);
            this.label1.TabIndex = 56;
            this.label1.Text = "Tutar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(185, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 45);
            this.label8.TabIndex = 55;
            this.label8.Text = "Hesap:";
            // 
            // TutarBox
            // 
            this.TutarBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TutarBox.Location = new System.Drawing.Point(324, 308);
            this.TutarBox.Name = "TutarBox";
            this.TutarBox.Size = new System.Drawing.Size(402, 50);
            this.TutarBox.TabIndex = 54;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(324, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(402, 53);
            this.comboBox1.TabIndex = 53;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ParaYatir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(963, 651);
            this.Controls.Add(this.ParaYatirButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TutarBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GeriButton);
            this.Name = "ParaYatir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para Yatır";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GeriButton;
        private System.Windows.Forms.Button ParaYatirButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TutarBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}