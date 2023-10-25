
namespace CG_Bank.Musteri
{
    partial class ParaGonder
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
            this.GonderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TutarBox = new System.Windows.Forms.TextBox();
            this.GondericiBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AliciBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(364, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 48);
            this.label2.TabIndex = 19;
            this.label2.Text = "Para Gönder";
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
            // GonderButton
            // 
            this.GonderButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.GonderButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GonderButton.Location = new System.Drawing.Point(332, 538);
            this.GonderButton.Name = "GonderButton";
            this.GonderButton.Size = new System.Drawing.Size(291, 54);
            this.GonderButton.TabIndex = 62;
            this.GonderButton.Text = "Gönder";
            this.GonderButton.UseVisualStyleBackColor = false;
            this.GonderButton.Click += new System.EventHandler(this.GonderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(278, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 45);
            this.label1.TabIndex = 61;
            this.label1.Text = "Tutar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(123, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(272, 45);
            this.label8.TabIndex = 60;
            this.label8.Text = "Gönderen Hesap:";
            // 
            // TutarBox
            // 
            this.TutarBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TutarBox.Location = new System.Drawing.Point(417, 376);
            this.TutarBox.Name = "TutarBox";
            this.TutarBox.PlaceholderText = "Tutar";
            this.TutarBox.Size = new System.Drawing.Size(402, 50);
            this.TutarBox.TabIndex = 59;
            // 
            // GondericiBox
            // 
            this.GondericiBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GondericiBox.FormattingEnabled = true;
            this.GondericiBox.Location = new System.Drawing.Point(417, 181);
            this.GondericiBox.Name = "GondericiBox";
            this.GondericiBox.Size = new System.Drawing.Size(402, 53);
            this.GondericiBox.TabIndex = 58;
            this.GondericiBox.SelectedIndexChanged += new System.EventHandler(this.GondericiBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(207, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 45);
            this.label3.TabIndex = 64;
            this.label3.Text = "Alıcı Hesap:";
            // 
            // AliciBox
            // 
            this.AliciBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AliciBox.FormattingEnabled = true;
            this.AliciBox.Location = new System.Drawing.Point(417, 276);
            this.AliciBox.Name = "AliciBox";
            this.AliciBox.Size = new System.Drawing.Size(402, 53);
            this.AliciBox.TabIndex = 63;
            this.AliciBox.SelectedIndexChanged += new System.EventHandler(this.AliciBox_SelectedIndexChanged);
            // 
            // ParaGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(963, 651);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AliciBox);
            this.Controls.Add(this.GonderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TutarBox);
            this.Controls.Add(this.GondericiBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GeriButton);
            this.Name = "ParaGonder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para Gönder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GeriButton;
        private System.Windows.Forms.Button GonderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TutarBox;
        private System.Windows.Forms.ComboBox GondericiBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AliciBox;
    }
}