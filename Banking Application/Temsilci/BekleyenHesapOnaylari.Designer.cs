﻿
namespace CG_Bank.Temsilci
{
    partial class BekleyenHesapOnaylari
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
            this.ReddetButton = new System.Windows.Forms.Button();
            this.OnaylaButton = new System.Windows.Forms.Button();
            this.ListeleButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(265, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 48);
            this.label2.TabIndex = 17;
            this.label2.Text = "Bekleyen Hesap Onayları";
            // 
            // GeriButton
            // 
            this.GeriButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GeriButton.Location = new System.Drawing.Point(10, 11);
            this.GeriButton.Name = "GeriButton";
            this.GeriButton.Size = new System.Drawing.Size(191, 54);
            this.GeriButton.TabIndex = 16;
            this.GeriButton.Text = "Geri";
            this.GeriButton.UseVisualStyleBackColor = true;
            this.GeriButton.Click += new System.EventHandler(this.GeriButton_Click);
            // 
            // ReddetButton
            // 
            this.ReddetButton.Location = new System.Drawing.Point(697, 187);
            this.ReddetButton.Name = "ReddetButton";
            this.ReddetButton.Size = new System.Drawing.Size(209, 50);
            this.ReddetButton.TabIndex = 14;
            this.ReddetButton.Text = "Reddet";
            this.ReddetButton.UseVisualStyleBackColor = true;
            this.ReddetButton.Click += new System.EventHandler(this.ReddetButton_Click);
            // 
            // OnaylaButton
            // 
            this.OnaylaButton.Location = new System.Drawing.Point(42, 187);
            this.OnaylaButton.Name = "OnaylaButton";
            this.OnaylaButton.Size = new System.Drawing.Size(209, 50);
            this.OnaylaButton.TabIndex = 13;
            this.OnaylaButton.Text = "Onayla";
            this.OnaylaButton.UseVisualStyleBackColor = true;
            this.OnaylaButton.Click += new System.EventHandler(this.OnaylaButton_Click);
            // 
            // ListeleButton
            // 
            this.ListeleButton.Location = new System.Drawing.Point(368, 576);
            this.ListeleButton.Name = "ListeleButton";
            this.ListeleButton.Size = new System.Drawing.Size(209, 50);
            this.ListeleButton.TabIndex = 12;
            this.ListeleButton.Text = "Listele";
            this.ListeleButton.UseVisualStyleBackColor = true;
            this.ListeleButton.Click += new System.EventHandler(this.ListeleButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(864, 281);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BekleyenHesapOnaylari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(963, 651);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GeriButton);
            this.Controls.Add(this.ReddetButton);
            this.Controls.Add(this.OnaylaButton);
            this.Controls.Add(this.ListeleButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BekleyenHesapOnaylari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bekleyen Hesap Onayları";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GeriButton;
        private System.Windows.Forms.Button ReddetButton;
        private System.Windows.Forms.Button OnaylaButton;
        private System.Windows.Forms.Button ListeleButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}