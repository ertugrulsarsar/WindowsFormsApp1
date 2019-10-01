namespace WindowsFormsApp1
{
    partial class Form1
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
            this.textBoxEkle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.listBoxKullanicilar = new System.Windows.Forms.ListBox();
            this.textBoxSelectedName = new System.Windows.Forms.TextBox();
            this.buttonRandomSelect = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEkle
            // 
            this.textBoxEkle.Location = new System.Drawing.Point(126, 24);
            this.textBoxEkle.Name = "textBoxEkle";
            this.textBoxEkle.Size = new System.Drawing.Size(100, 22);
            this.textBoxEkle.TabIndex = 0;
            this.textBoxEkle.TextChanged += new System.EventHandler(this.TextBoxEkle_TextChanged);
            this.textBoxEkle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxEkle_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim";
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(241, 23);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonEkle.TabIndex = 2;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.ButtonEkle_Click);
            // 
            // listBoxKullanicilar
            // 
            this.listBoxKullanicilar.FormattingEnabled = true;
            this.listBoxKullanicilar.ItemHeight = 16;
            this.listBoxKullanicilar.Location = new System.Drawing.Point(126, 76);
            this.listBoxKullanicilar.Name = "listBoxKullanicilar";
            this.listBoxKullanicilar.Size = new System.Drawing.Size(161, 260);
            this.listBoxKullanicilar.TabIndex = 3;
            // 
            // textBoxSelectedName
            // 
            this.textBoxSelectedName.Location = new System.Drawing.Point(337, 76);
            this.textBoxSelectedName.Name = "textBoxSelectedName";
            this.textBoxSelectedName.ReadOnly = true;
            this.textBoxSelectedName.Size = new System.Drawing.Size(100, 22);
            this.textBoxSelectedName.TabIndex = 4;
            // 
            // buttonRandomSelect
            // 
            this.buttonRandomSelect.Location = new System.Drawing.Point(350, 23);
            this.buttonRandomSelect.Name = "buttonRandomSelect";
            this.buttonRandomSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonRandomSelect.TabIndex = 5;
            this.buttonRandomSelect.Text = "Seç";
            this.buttonRandomSelect.UseVisualStyleBackColor = true;
            this.buttonRandomSelect.Click += new System.EventHandler(this.ButtonRandomSelect_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(467, 23);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "Sil";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonRandomSelect);
            this.Controls.Add(this.textBoxSelectedName);
            this.Controls.Add(this.listBoxKullanicilar);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEkle);
            this.Name = "Form1";
            this.Text = "İdeal Kilo-Boy Hesaplama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.ListBox listBoxKullanicilar;
        private System.Windows.Forms.TextBox textBoxSelectedName;
        private System.Windows.Forms.Button buttonRandomSelect;
        private System.Windows.Forms.Button buttonRemove;
    }
}

