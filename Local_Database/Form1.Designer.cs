namespace Local_Database
{
    partial class Giris_Form
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
            this.KAd_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sifre_txtbox = new System.Windows.Forms.TextBox();
            this.giris_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adınızı Giriniz :";
            // 
            // KAd_txtbox
            // 
            this.KAd_txtbox.Location = new System.Drawing.Point(134, 21);
            this.KAd_txtbox.Name = "KAd_txtbox";
            this.KAd_txtbox.Size = new System.Drawing.Size(100, 20);
            this.KAd_txtbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifrenizi Giriniz :";
            // 
            // sifre_txtbox
            // 
            this.sifre_txtbox.Location = new System.Drawing.Point(134, 52);
            this.sifre_txtbox.Name = "sifre_txtbox";
            this.sifre_txtbox.Size = new System.Drawing.Size(100, 20);
            this.sifre_txtbox.TabIndex = 4;
            // 
            // giris_btn
            // 
            this.giris_btn.Location = new System.Drawing.Point(134, 86);
            this.giris_btn.Name = "giris_btn";
            this.giris_btn.Size = new System.Drawing.Size(100, 23);
            this.giris_btn.TabIndex = 5;
            this.giris_btn.Text = "Giriş";
            this.giris_btn.UseVisualStyleBackColor = true;
            this.giris_btn.Click += new System.EventHandler(this.giris_btn_Click);
            // 
            // Giris_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 121);
            this.Controls.Add(this.giris_btn);
            this.Controls.Add(this.sifre_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KAd_txtbox);
            this.Controls.Add(this.label1);
            this.Name = "Giris_Form";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Giris_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KAd_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifre_txtbox;
        private System.Windows.Forms.Button giris_btn;
    }
}

