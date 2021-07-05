
namespace VitaminDeposu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.KatiButonu = new System.Windows.Forms.Button();
            this.kSikButonu = new System.Windows.Forms.Button();
            this.Katılistbox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Resimler = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SayacLabeli = new System.Windows.Forms.Label();
            this.SureLabeli = new System.Windows.Forms.Label();
            this.YeniOyunButonu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ToplamSiviLabeli = new System.Windows.Forms.Label();
            this.ToplamPureLabeli = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ToplamVitaminaLabeli = new System.Windows.Forms.Label();
            this.ToplamVitamincLabeli = new System.Windows.Forms.Label();
            this.nSikButonu = new System.Windows.Forms.Button();
            this.NarenciyeButonu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Narenciyelistbox = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resimler)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(270, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIKICILAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KatiButonu
            // 
            this.KatiButonu.Location = new System.Drawing.Point(18, 13);
            this.KatiButonu.Name = "KatiButonu";
            this.KatiButonu.Size = new System.Drawing.Size(103, 23);
            this.KatiButonu.TabIndex = 2;
            this.KatiButonu.Text = "Katı Püre Sıkıcağı";
            this.KatiButonu.UseVisualStyleBackColor = true;
            this.KatiButonu.Click += new System.EventHandler(this.KatiButonu_Click);
            // 
            // kSikButonu
            // 
            this.kSikButonu.Location = new System.Drawing.Point(18, 201);
            this.kSikButonu.Name = "kSikButonu";
            this.kSikButonu.Size = new System.Drawing.Size(103, 29);
            this.kSikButonu.TabIndex = 4;
            this.kSikButonu.Text = "Sık";
            this.kSikButonu.UseVisualStyleBackColor = true;
            this.kSikButonu.Click += new System.EventHandler(this.kSikButonu_Click);
            // 
            // Katılistbox
            // 
            this.Katılistbox.FormattingEnabled = true;
            this.Katılistbox.Location = new System.Drawing.Point(18, 42);
            this.Katılistbox.Name = "Katılistbox";
            this.Katılistbox.Size = new System.Drawing.Size(103, 134);
            this.Katılistbox.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.KatiButonu);
            this.panel2.Controls.Add(this.kSikButonu);
            this.panel2.Controls.Add(this.Katılistbox);
            this.panel2.Location = new System.Drawing.Point(421, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 244);
            this.panel2.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.Resimler);
            this.panel5.Location = new System.Drawing.Point(12, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 166);
            this.panel5.TabIndex = 19;
            // 
            // Resimler
            // 
            this.Resimler.BackColor = System.Drawing.Color.Silver;
            this.Resimler.Location = new System.Drawing.Point(14, 16);
            this.Resimler.Name = "Resimler";
            this.Resimler.Size = new System.Drawing.Size(219, 136);
            this.Resimler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Resimler.TabIndex = 0;
            this.Resimler.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Controls.Add(this.ExitButton);
            this.panel6.Controls.Add(this.SayacLabeli);
            this.panel6.Controls.Add(this.SureLabeli);
            this.panel6.Controls.Add(this.YeniOyunButonu);
            this.panel6.Location = new System.Drawing.Point(12, 204);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(248, 340);
            this.panel6.TabIndex = 20;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(43, 284);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(156, 41);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "ÇIKIŞ";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SayacLabeli
            // 
            this.SayacLabeli.BackColor = System.Drawing.Color.White;
            this.SayacLabeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SayacLabeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SayacLabeli.ForeColor = System.Drawing.Color.Teal;
            this.SayacLabeli.Location = new System.Drawing.Point(22, 185);
            this.SayacLabeli.Name = "SayacLabeli";
            this.SayacLabeli.Size = new System.Drawing.Size(201, 57);
            this.SayacLabeli.TabIndex = 2;
            this.SayacLabeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SureLabeli
            // 
            this.SureLabeli.BackColor = System.Drawing.Color.MidnightBlue;
            this.SureLabeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SureLabeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SureLabeli.ForeColor = System.Drawing.Color.White;
            this.SureLabeli.Location = new System.Drawing.Point(22, 161);
            this.SureLabeli.Name = "SureLabeli";
            this.SureLabeli.Size = new System.Drawing.Size(201, 25);
            this.SureLabeli.TabIndex = 1;
            this.SureLabeli.Text = "SÜRE";
            this.SureLabeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YeniOyunButonu
            // 
            this.YeniOyunButonu.BackColor = System.Drawing.Color.MidnightBlue;
            this.YeniOyunButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YeniOyunButonu.ForeColor = System.Drawing.Color.White;
            this.YeniOyunButonu.Location = new System.Drawing.Point(22, 14);
            this.YeniOyunButonu.Name = "YeniOyunButonu";
            this.YeniOyunButonu.Size = new System.Drawing.Size(201, 62);
            this.YeniOyunButonu.TabIndex = 0;
            this.YeniOyunButonu.Text = "YENİ OYUN";
            this.YeniOyunButonu.UseVisualStyleBackColor = false;
            this.YeniOyunButonu.Click += new System.EventHandler(this.YeniOyunButonu_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(266, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "TOPLAM SIVI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(424, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "TOPLAM PÜRE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToplamSiviLabeli
            // 
            this.ToplamSiviLabeli.BackColor = System.Drawing.Color.White;
            this.ToplamSiviLabeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToplamSiviLabeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToplamSiviLabeli.ForeColor = System.Drawing.Color.Teal;
            this.ToplamSiviLabeli.Location = new System.Drawing.Point(266, 362);
            this.ToplamSiviLabeli.Name = "ToplamSiviLabeli";
            this.ToplamSiviLabeli.Size = new System.Drawing.Size(150, 57);
            this.ToplamSiviLabeli.TabIndex = 23;
            this.ToplamSiviLabeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToplamPureLabeli
            // 
            this.ToplamPureLabeli.BackColor = System.Drawing.Color.White;
            this.ToplamPureLabeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToplamPureLabeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToplamPureLabeli.ForeColor = System.Drawing.Color.Teal;
            this.ToplamPureLabeli.Location = new System.Drawing.Point(424, 362);
            this.ToplamPureLabeli.Name = "ToplamPureLabeli";
            this.ToplamPureLabeli.Size = new System.Drawing.Size(150, 57);
            this.ToplamPureLabeli.TabIndex = 24;
            this.ToplamPureLabeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MidnightBlue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(266, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 30);
            this.label6.TabIndex = 25;
            this.label6.Text = "VİTAMİN A";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.MidnightBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(424, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 30);
            this.label7.TabIndex = 26;
            this.label7.Text = "VİTAMİN C";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToplamVitaminaLabeli
            // 
            this.ToplamVitaminaLabeli.BackColor = System.Drawing.Color.White;
            this.ToplamVitaminaLabeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToplamVitaminaLabeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToplamVitaminaLabeli.ForeColor = System.Drawing.Color.Teal;
            this.ToplamVitaminaLabeli.Location = new System.Drawing.Point(266, 479);
            this.ToplamVitaminaLabeli.Name = "ToplamVitaminaLabeli";
            this.ToplamVitaminaLabeli.Size = new System.Drawing.Size(150, 57);
            this.ToplamVitaminaLabeli.TabIndex = 27;
            this.ToplamVitaminaLabeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToplamVitamincLabeli
            // 
            this.ToplamVitamincLabeli.BackColor = System.Drawing.Color.White;
            this.ToplamVitamincLabeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToplamVitamincLabeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToplamVitamincLabeli.ForeColor = System.Drawing.Color.Teal;
            this.ToplamVitamincLabeli.Location = new System.Drawing.Point(424, 479);
            this.ToplamVitamincLabeli.Name = "ToplamVitamincLabeli";
            this.ToplamVitamincLabeli.Size = new System.Drawing.Size(150, 57);
            this.ToplamVitamincLabeli.TabIndex = 28;
            this.ToplamVitamincLabeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nSikButonu
            // 
            this.nSikButonu.Location = new System.Drawing.Point(21, 201);
            this.nSikButonu.Name = "nSikButonu";
            this.nSikButonu.Size = new System.Drawing.Size(103, 29);
            this.nSikButonu.TabIndex = 3;
            this.nSikButonu.Text = "Sık";
            this.nSikButonu.UseVisualStyleBackColor = true;
            this.nSikButonu.Click += new System.EventHandler(this.nSikButonu_Click);
            // 
            // NarenciyeButonu
            // 
            this.NarenciyeButonu.Location = new System.Drawing.Point(21, 13);
            this.NarenciyeButonu.Name = "NarenciyeButonu";
            this.NarenciyeButonu.Size = new System.Drawing.Size(103, 23);
            this.NarenciyeButonu.TabIndex = 1;
            this.NarenciyeButonu.Text = "Narenciye Sıkacağı";
            this.NarenciyeButonu.UseVisualStyleBackColor = true;
            this.NarenciyeButonu.Click += new System.EventHandler(this.NarenciyeButonu_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.NarenciyeButonu);
            this.panel1.Controls.Add(this.nSikButonu);
            this.panel1.Controls.Add(this.Narenciyelistbox);
            this.panel1.Location = new System.Drawing.Point(269, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 244);
            this.panel1.TabIndex = 13;
            // 
            // Narenciyelistbox
            // 
            this.Narenciyelistbox.FormattingEnabled = true;
            this.Narenciyelistbox.Location = new System.Drawing.Point(21, 42);
            this.Narenciyelistbox.Name = "Narenciyelistbox";
            this.Narenciyelistbox.Size = new System.Drawing.Size(103, 134);
            this.Narenciyelistbox.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(596, 117);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(516, 293);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "Gelen resime göre önce işlem yapacağınız sıkacağı seçip\n  ardından Sık\'a basarak " +
    "işlem yapabilirsiniz.\n\nNarenciyeler\n- Portakal\n- Mandalina\n- Greyfurt\n\nKatı\n- El" +
    "ma\n- Armut\n- Çilek\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1120, 558);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ToplamVitamincLabeli);
            this.Controls.Add(this.ToplamVitaminaLabeli);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ToplamPureLabeli);
            this.Controls.Add(this.ToplamSiviLabeli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VİTAMİN DEPOSU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Resimler)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button KatiButonu;
        private System.Windows.Forms.Button kSikButonu;
        private System.Windows.Forms.ListBox Katılistbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button YeniOyunButonu;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label SayacLabeli;
        private System.Windows.Forms.Label SureLabeli;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Resimler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ToplamSiviLabeli;
        private System.Windows.Forms.Label ToplamPureLabeli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ToplamVitaminaLabeli;
        private System.Windows.Forms.Label ToplamVitamincLabeli;
        private System.Windows.Forms.Button nSikButonu;
        private System.Windows.Forms.Button NarenciyeButonu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox Narenciyelistbox;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

