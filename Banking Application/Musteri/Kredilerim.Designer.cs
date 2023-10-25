
namespace CG_Bank.Musteri
{
    partial class Kredilerim
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
            this.GeriButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TumunuOdeButton = new System.Windows.Forms.Button();
            this.EkleButton = new System.Windows.Forms.Button();
            this.ListeleButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GeriButton
            // 
            this.GeriButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GeriButton.Location = new System.Drawing.Point(12, 12);
            this.GeriButton.Name = "GeriButton";
            this.GeriButton.Size = new System.Drawing.Size(176, 54);
            this.GeriButton.TabIndex = 10;
            this.GeriButton.Text = "Geri";
            this.GeriButton.UseVisualStyleBackColor = true;
            this.GeriButton.Click += new System.EventHandler(this.GeriButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(376, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 48);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kredilerim";
            // 
            // TumunuOdeButton
            // 
            this.TumunuOdeButton.Location = new System.Drawing.Point(695, 189);
            this.TumunuOdeButton.Name = "TumunuOdeButton";
            this.TumunuOdeButton.Size = new System.Drawing.Size(209, 50);
            this.TumunuOdeButton.TabIndex = 14;
            this.TumunuOdeButton.Text = "Tüm Borcu Öde";
            this.TumunuOdeButton.UseVisualStyleBackColor = true;
            this.TumunuOdeButton.Click += new System.EventHandler(this.TumunuOdeButton_Click);
            // 
            // EkleButton
            // 
            this.EkleButton.Location = new System.Drawing.Point(40, 189);
            this.EkleButton.Name = "EkleButton";
            this.EkleButton.Size = new System.Drawing.Size(209, 50);
            this.EkleButton.TabIndex = 13;
            this.EkleButton.Text = "Yeni Kredi";
            this.EkleButton.UseVisualStyleBackColor = true;
            this.EkleButton.Click += new System.EventHandler(this.EkleButton_Click);
            // 
            // ListeleButton
            // 
            this.ListeleButton.Location = new System.Drawing.Point(366, 578);
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
            this.dataGridView1.Location = new System.Drawing.Point(40, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(864, 281);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Kredilerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(963, 651);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TumunuOdeButton);
            this.Controls.Add(this.EkleButton);
            this.Controls.Add(this.ListeleButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GeriButton);
            this.Name = "Kredilerim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kredilerim";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GeriButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TumunuOdeButton;
        private System.Windows.Forms.Button EkleButton;
        private System.Windows.Forms.Button ListeleButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}