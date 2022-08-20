
namespace StationeryStore
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFiyatKitap = new System.Windows.Forms.Label();
            this.checkKitap = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.checkDefter = new System.Windows.Forms.CheckBox();
            this.labelFiyatDefter = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.checkSilgi = new System.Windows.Forms.CheckBox();
            this.labelFiyatSilgi = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.checkKarton = new System.Windows.Forms.CheckBox();
            this.labelFiyatKarton = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.checkBoya = new System.Windows.Forms.CheckBox();
            this.labelFiyatBoya = new System.Windows.Forms.Label();
            this.labelToplam = new System.Windows.Forms.Label();
            this.labelToplamFiyat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(93, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürünler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(361, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adedi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(247, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat";
            // 
            // labelFiyatKitap
            // 
            this.labelFiyatKitap.AutoSize = true;
            this.labelFiyatKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiyatKitap.Location = new System.Drawing.Point(249, 109);
            this.labelFiyatKitap.Name = "labelFiyatKitap";
            this.labelFiyatKitap.Size = new System.Drawing.Size(49, 20);
            this.labelFiyatKitap.TabIndex = 4;
            this.labelFiyatKitap.Text = "10,90";
            // 
            // checkKitap
            // 
            this.checkKitap.AutoSize = true;
            this.checkKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkKitap.Location = new System.Drawing.Point(98, 108);
            this.checkKitap.Name = "checkKitap";
            this.checkKitap.Size = new System.Drawing.Size(69, 24);
            this.checkKitap.TabIndex = 6;
            this.checkKitap.Text = "Kitap";
            this.checkKitap.UseVisualStyleBackColor = true;
            this.checkKitap.CheckedChanged += new System.EventHandler(this.checkKitap_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(210, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sepete Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(665, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(288, 284);
            this.listBox1.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown1.Location = new System.Drawing.Point(366, 106);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown1.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown2.Location = new System.Drawing.Point(366, 175);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown2.TabIndex = 11;
            // 
            // checkDefter
            // 
            this.checkDefter.AutoSize = true;
            this.checkDefter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkDefter.Location = new System.Drawing.Point(98, 177);
            this.checkDefter.Name = "checkDefter";
            this.checkDefter.Size = new System.Drawing.Size(78, 24);
            this.checkDefter.TabIndex = 12;
            this.checkDefter.Text = "Defter";
            this.checkDefter.UseVisualStyleBackColor = true;
            // 
            // labelFiyatDefter
            // 
            this.labelFiyatDefter.AutoSize = true;
            this.labelFiyatDefter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiyatDefter.Location = new System.Drawing.Point(249, 178);
            this.labelFiyatDefter.Name = "labelFiyatDefter";
            this.labelFiyatDefter.Size = new System.Drawing.Size(49, 20);
            this.labelFiyatDefter.TabIndex = 10;
            this.labelFiyatDefter.Text = "39,90";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown3.Location = new System.Drawing.Point(365, 240);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown3.TabIndex = 14;
            // 
            // checkSilgi
            // 
            this.checkSilgi.AutoSize = true;
            this.checkSilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkSilgi.Location = new System.Drawing.Point(97, 242);
            this.checkSilgi.Name = "checkSilgi";
            this.checkSilgi.Size = new System.Drawing.Size(63, 24);
            this.checkSilgi.TabIndex = 15;
            this.checkSilgi.Text = "Silgi";
            this.checkSilgi.UseVisualStyleBackColor = true;
            // 
            // labelFiyatSilgi
            // 
            this.labelFiyatSilgi.AutoSize = true;
            this.labelFiyatSilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiyatSilgi.Location = new System.Drawing.Point(248, 243);
            this.labelFiyatSilgi.Name = "labelFiyatSilgi";
            this.labelFiyatSilgi.Size = new System.Drawing.Size(40, 20);
            this.labelFiyatSilgi.TabIndex = 13;
            this.labelFiyatSilgi.Text = "3,50";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown4.Location = new System.Drawing.Point(365, 302);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown4.TabIndex = 17;
            // 
            // checkKarton
            // 
            this.checkKarton.AutoSize = true;
            this.checkKarton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkKarton.Location = new System.Drawing.Point(97, 304);
            this.checkKarton.Name = "checkKarton";
            this.checkKarton.Size = new System.Drawing.Size(80, 24);
            this.checkKarton.TabIndex = 18;
            this.checkKarton.Text = "Karton";
            this.checkKarton.UseVisualStyleBackColor = true;
            // 
            // labelFiyatKarton
            // 
            this.labelFiyatKarton.AutoSize = true;
            this.labelFiyatKarton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiyatKarton.Location = new System.Drawing.Point(248, 305);
            this.labelFiyatKarton.Name = "labelFiyatKarton";
            this.labelFiyatKarton.Size = new System.Drawing.Size(18, 20);
            this.labelFiyatKarton.TabIndex = 16;
            this.labelFiyatKarton.Text = "8";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown5.Location = new System.Drawing.Point(366, 354);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown5.TabIndex = 20;
            // 
            // checkBoya
            // 
            this.checkBoya.AutoSize = true;
            this.checkBoya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoya.Location = new System.Drawing.Point(98, 356);
            this.checkBoya.Name = "checkBoya";
            this.checkBoya.Size = new System.Drawing.Size(69, 24);
            this.checkBoya.TabIndex = 21;
            this.checkBoya.Text = "Boya";
            this.checkBoya.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkBoya.UseVisualStyleBackColor = true;
            // 
            // labelFiyatBoya
            // 
            this.labelFiyatBoya.AutoSize = true;
            this.labelFiyatBoya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiyatBoya.Location = new System.Drawing.Point(249, 357);
            this.labelFiyatBoya.Name = "labelFiyatBoya";
            this.labelFiyatBoya.Size = new System.Drawing.Size(27, 20);
            this.labelFiyatBoya.TabIndex = 19;
            this.labelFiyatBoya.Text = "15";
            // 
            // labelToplam
            // 
            this.labelToplam.AutoSize = true;
            this.labelToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplam.Location = new System.Drawing.Point(665, 411);
            this.labelToplam.Name = "labelToplam";
            this.labelToplam.Size = new System.Drawing.Size(133, 20);
            this.labelToplam.TabIndex = 22;
            this.labelToplam.Text = "TOPLAM FİYAT:";
            // 
            // labelToplamFiyat
            // 
            this.labelToplamFiyat.AutoSize = true;
            this.labelToplamFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplamFiyat.Location = new System.Drawing.Point(804, 411);
            this.labelToplamFiyat.Name = "labelToplamFiyat";
            this.labelToplamFiyat.Size = new System.Drawing.Size(43, 20);
            this.labelToplamFiyat.TabIndex = 23;
            this.labelToplamFiyat.Text = "0 TL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1060, 585);
            this.Controls.Add(this.labelToplamFiyat);
            this.Controls.Add(this.labelToplam);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.checkBoya);
            this.Controls.Add(this.labelFiyatBoya);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.checkKarton);
            this.Controls.Add(this.labelFiyatKarton);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.checkSilgi);
            this.Controls.Add(this.labelFiyatSilgi);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.checkDefter);
            this.Controls.Add(this.labelFiyatDefter);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkKitap);
            this.Controls.Add(this.labelFiyatKitap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kırtasiye Ürün Satış";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFiyatKitap;
        private System.Windows.Forms.CheckBox checkKitap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.CheckBox checkDefter;
        private System.Windows.Forms.Label labelFiyatDefter;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.CheckBox checkSilgi;
        private System.Windows.Forms.Label labelFiyatSilgi;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.CheckBox checkKarton;
        private System.Windows.Forms.Label labelFiyatKarton;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.CheckBox checkBoya;
        private System.Windows.Forms.Label labelFiyatBoya;
        private System.Windows.Forms.Label labelToplam;
        private System.Windows.Forms.Label labelToplamFiyat;
    }
}

