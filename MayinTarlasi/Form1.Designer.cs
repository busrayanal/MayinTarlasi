namespace MayinTarlasi
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
            this.rbZor = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbKolay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMayinYakin = new System.Windows.Forms.Label();
            this.lblZaman = new System.Windows.Forms.Label();
            this.panelOyun = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtIsim = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnKaydet = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnYardim = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSkorlar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnYukari = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.btnSag = new System.Windows.Forms.Button();
            this.btnAsagi = new System.Windows.Forms.Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnalt = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnkap = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbZor
            // 
            this.rbZor.AutoSize = true;
            this.rbZor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.rbZor.ForeColor = System.Drawing.Color.Red;
            this.rbZor.Location = new System.Drawing.Point(23, 144);
            this.rbZor.Name = "rbZor";
            this.rbZor.Size = new System.Drawing.Size(64, 32);
            this.rbZor.TabIndex = 2;
            this.rbZor.Text = "Zor";
            this.rbZor.UseVisualStyleBackColor = true;
            this.rbZor.CheckedChanged += new System.EventHandler(this.rbZor_CheckedChanged);
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.rbOrta.ForeColor = System.Drawing.Color.Orange;
            this.rbOrta.Location = new System.Drawing.Point(23, 103);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(73, 32);
            this.rbOrta.TabIndex = 1;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            this.rbOrta.CheckedChanged += new System.EventHandler(this.rbOrta_CheckedChanged);
            // 
            // rbKolay
            // 
            this.rbKolay.AutoSize = true;
            this.rbKolay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.rbKolay.ForeColor = System.Drawing.Color.Green;
            this.rbKolay.Location = new System.Drawing.Point(23, 59);
            this.rbKolay.Name = "rbKolay";
            this.rbKolay.Size = new System.Drawing.Size(82, 32);
            this.rbKolay.TabIndex = 0;
            this.rbKolay.Text = "Kolay";
            this.rbKolay.UseVisualStyleBackColor = true;
            this.rbKolay.CheckedChanged += new System.EventHandler(this.rbKolay_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen İsminizi \r\nGiriniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMayinYakin
            // 
            this.lblMayinYakin.AutoSize = true;
            this.lblMayinYakin.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblMayinYakin.Location = new System.Drawing.Point(611, 59);
            this.lblMayinYakin.Name = "lblMayinYakin";
            this.lblMayinYakin.Size = new System.Drawing.Size(189, 28);
            this.lblMayinYakin.TabIndex = 4;
            this.lblMayinYakin.Text = "Mayınlara Yakın 0";
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblZaman.Location = new System.Drawing.Point(874, 59);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(139, 28);
            this.lblZaman.TabIndex = 5;
            this.lblZaman.Text = "Zaman 00:00";
            // 
            // panelOyun
            // 
            this.panelOyun.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelOyun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOyun.Location = new System.Drawing.Point(570, 95);
            this.panelOyun.Name = "panelOyun";
            this.panelOyun.Size = new System.Drawing.Size(400, 400);
            this.panelOyun.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtIsim
            // 
            this.txtIsim.BackColor = System.Drawing.Color.Transparent;
            this.txtIsim.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtIsim.BorderRadius = 10;
            this.txtIsim.BorderThickness = 2;
            this.txtIsim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIsim.DefaultText = "";
            this.txtIsim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIsim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIsim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIsim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIsim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIsim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIsim.ForeColor = System.Drawing.Color.Black;
            this.txtIsim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIsim.Location = new System.Drawing.Point(73, 363);
            this.txtIsim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.PlaceholderText = "";
            this.txtIsim.SelectedText = "";
            this.txtIsim.Size = new System.Drawing.Size(180, 34);
            this.txtIsim.TabIndex = 13;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnKaydet.BorderRadius = 20;
            this.btnKaydet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKaydet.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKaydet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKaydet.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnKaydet.FillColor2 = System.Drawing.Color.DarkSlateBlue;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(73, 415);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(180, 45);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYardim
            // 
            this.btnYardim.BackColor = System.Drawing.Color.Transparent;
            this.btnYardim.BorderRadius = 20;
            this.btnYardim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYardim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYardim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYardim.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYardim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYardim.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnYardim.FillColor2 = System.Drawing.Color.DarkSlateBlue;
            this.btnYardim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYardim.ForeColor = System.Drawing.Color.White;
            this.btnYardim.Location = new System.Drawing.Point(113, 557);
            this.btnYardim.Name = "btnYardim";
            this.btnYardim.Size = new System.Drawing.Size(99, 42);
            this.btnYardim.TabIndex = 17;
            this.btnYardim.Text = "Yardım";
            this.btnYardim.Click += new System.EventHandler(this.btnYardim_Click_1);
            // 
            // btnSkorlar
            // 
            this.btnSkorlar.BackColor = System.Drawing.Color.Transparent;
            this.btnSkorlar.BorderRadius = 20;
            this.btnSkorlar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSkorlar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSkorlar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSkorlar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSkorlar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSkorlar.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSkorlar.FillColor2 = System.Drawing.Color.DarkSlateBlue;
            this.btnSkorlar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSkorlar.ForeColor = System.Drawing.Color.White;
            this.btnSkorlar.Location = new System.Drawing.Point(79, 509);
            this.btnSkorlar.Name = "btnSkorlar";
            this.btnSkorlar.Size = new System.Drawing.Size(174, 42);
            this.btnSkorlar.TabIndex = 18;
            this.btnSkorlar.Text = "Skorları Görüntüle";
            this.btnSkorlar.Click += new System.EventHandler(this.btnSkorlar_Click_1);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.btnYukari);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnSol);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnSag);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnAsagi);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.SkyBlue;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.LightSkyBlue;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.CornflowerBlue;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.SteelBlue;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(651, 520);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(244, 127);
            this.guna2CustomGradientPanel1.TabIndex = 19;
            // 
            // btnYukari
            // 
            this.btnYukari.BackgroundImage = global::MayinTarlasi.Properties.Resources.yukari;
            this.btnYukari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYukari.Location = new System.Drawing.Point(97, 3);
            this.btnYukari.Name = "btnYukari";
            this.btnYukari.Size = new System.Drawing.Size(50, 50);
            this.btnYukari.TabIndex = 7;
            this.btnYukari.UseVisualStyleBackColor = true;
            this.btnYukari.Click += new System.EventHandler(this.btnYukari_Click);
            // 
            // btnSol
            // 
            this.btnSol.BackgroundImage = global::MayinTarlasi.Properties.Resources.sol;
            this.btnSol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSol.Location = new System.Drawing.Point(42, 36);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(50, 50);
            this.btnSol.TabIndex = 8;
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // btnSag
            // 
            this.btnSag.BackgroundImage = global::MayinTarlasi.Properties.Resources.sag;
            this.btnSag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSag.Location = new System.Drawing.Point(153, 36);
            this.btnSag.Name = "btnSag";
            this.btnSag.Size = new System.Drawing.Size(50, 50);
            this.btnSag.TabIndex = 9;
            this.btnSag.UseVisualStyleBackColor = true;
            this.btnSag.Click += new System.EventHandler(this.btnSag_Click);
            // 
            // btnAsagi
            // 
            this.btnAsagi.BackgroundImage = global::MayinTarlasi.Properties.Resources.asagi;
            this.btnAsagi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsagi.Location = new System.Drawing.Point(97, 74);
            this.btnAsagi.Name = "btnAsagi";
            this.btnAsagi.Size = new System.Drawing.Size(50, 50);
            this.btnAsagi.TabIndex = 10;
            this.btnAsagi.UseVisualStyleBackColor = true;
            this.btnAsagi.Click += new System.EventHandler(this.btnAsagi_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 50;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yardımToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(125, 28);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::MayinTarlasi.Properties.Resources.ChatGPT_Image_Dec_20__2025__01_32_43_PM__1_;
            this.pictureBox3.Location = new System.Drawing.Point(328, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(208, 667);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MayinTarlasi.Properties.Resources.iconmayin;
            this.pictureBox2.Location = new System.Drawing.Point(570, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MayinTarlasi.Properties.Resources.wired_flat_45_clock_time;
            this.pictureBox1.Location = new System.Drawing.Point(833, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.guna2GroupBox1);
            this.guna2GradientPanel1.Controls.Add(this.btnSkorlar);
            this.guna2GradientPanel1.Controls.Add(this.btnYardim);
            this.guna2GradientPanel1.Controls.Add(this.pictureBox3);
            this.guna2GradientPanel1.Controls.Add(this.txtIsim);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.btnKaydet);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.SkyBlue;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.SteelBlue;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-4, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(536, 667);
            this.guna2GradientPanel1.TabIndex = 3;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.rbZor);
            this.guna2GroupBox1.Controls.Add(this.rbKolay);
            this.guna2GroupBox1.Controls.Add(this.rbOrta);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.guna2GroupBox1.Location = new System.Drawing.Point(73, 59);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(180, 198);
            this.guna2GroupBox1.TabIndex = 26;
            this.guna2GroupBox1.Text = "Seviye Seçiniz";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnalt
            // 
            this.btnalt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnalt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnalt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnalt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnalt.FillColor = System.Drawing.Color.Orange;
            this.btnalt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnalt.ForeColor = System.Drawing.Color.White;
            this.btnalt.Location = new System.Drawing.Point(996, 14);
            this.btnalt.Name = "btnalt";
            this.btnalt.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnalt.Size = new System.Drawing.Size(20, 20);
            this.btnalt.TabIndex = 26;
            this.btnalt.Click += new System.EventHandler(this.btnalt_Click);
            // 
            // btnkap
            // 
            this.btnkap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnkap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnkap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnkap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnkap.FillColor = System.Drawing.Color.Red;
            this.btnkap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnkap.ForeColor = System.Drawing.Color.White;
            this.btnkap.Location = new System.Drawing.Point(1022, 14);
            this.btnkap.Name = "btnkap";
            this.btnkap.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnkap.Size = new System.Drawing.Size(20, 20);
            this.btnkap.TabIndex = 27;
            this.btnkap.Click += new System.EventHandler(this.btnkap_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 668);
            this.Controls.Add(this.btnkap);
            this.Controls.Add(this.btnalt);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.panelOyun);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.lblMayinYakin);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mayın Tarlası";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbZor;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbKolay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMayinYakin;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Panel panelOyun;
        private System.Windows.Forms.Button btnYukari;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.Button btnSag;
        private System.Windows.Forms.Button btnAsagi;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2TextBox txtIsim;
        private Guna.UI2.WinForms.Guna2GradientButton btnKaydet;
        private Guna.UI2.WinForms.Guna2GradientButton btnYardim;
        private Guna.UI2.WinForms.Guna2GradientButton btnSkorlar;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2CircleButton btnalt;
        private Guna.UI2.WinForms.Guna2CircleButton btnkap;
    }
}

