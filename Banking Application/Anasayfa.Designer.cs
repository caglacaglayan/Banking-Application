
namespace CG_Bank
{
    partial class Anasayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.toMusteriGiris = new System.Windows.Forms.Button();
            this.toTemsilciGiris = new System.Windows.Forms.Button();
            this.toMudurGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toMusteriGiris
            // 
            resources.ApplyResources(this.toMusteriGiris, "toMusteriGiris");
            this.toMusteriGiris.Name = "toMusteriGiris";
            this.toMusteriGiris.UseVisualStyleBackColor = true;
            this.toMusteriGiris.Click += new System.EventHandler(this.toMusteriGiris_Click);
            // 
            // toTemsilciGiris
            // 
            resources.ApplyResources(this.toTemsilciGiris, "toTemsilciGiris");
            this.toTemsilciGiris.Name = "toTemsilciGiris";
            this.toTemsilciGiris.UseVisualStyleBackColor = true;
            this.toTemsilciGiris.Click += new System.EventHandler(this.toTemsilciGiris_Click);
            // 
            // toMudurGiris
            // 
            resources.ApplyResources(this.toMudurGiris, "toMudurGiris");
            this.toMudurGiris.Name = "toMudurGiris";
            this.toMudurGiris.UseVisualStyleBackColor = true;
            this.toMudurGiris.Click += new System.EventHandler(this.toMudurGiris_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Anasayfa
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toMudurGiris);
            this.Controls.Add(this.toTemsilciGiris);
            this.Controls.Add(this.toMusteriGiris);
            this.Name = "Anasayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button toMusteriGiris;
        public System.Windows.Forms.Button toTemsilciGiris;
        public System.Windows.Forms.Button toMudurGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

