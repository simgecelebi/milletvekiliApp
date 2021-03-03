namespace milletvekiliApp
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
            this.secimbölgebilgi = new System.Windows.Forms.GroupBox();
            this.ilnufustextBox = new System.Windows.Forms.TextBox();
            this.lblilnufusu = new System.Windows.Forms.Label();
            this.comboBoxil = new System.Windows.Forms.ComboBox();
            this.lblil = new System.Windows.Forms.Label();
            this.partibilgigroupBox = new System.Windows.Forms.GroupBox();
            this.buttonmilletvekilihesapla = new System.Windows.Forms.Button();
            this.textBoxmilletvekilisayi = new System.Windows.Forms.TextBox();
            this.textBoxCpartioy = new System.Windows.Forms.TextBox();
            this.textBoxBpartioy = new System.Windows.Forms.TextBox();
            this.textBoxApartioy = new System.Windows.Forms.TextBox();
            this.labelmilletvekilisayı = new System.Windows.Forms.Label();
            this.labelCpartioy = new System.Windows.Forms.Label();
            this.labelBpartioy = new System.Windows.Forms.Label();
            this.labelApartioy = new System.Windows.Forms.Label();
            this.secimistatistikgroupBox = new System.Windows.Forms.GroupBox();
            this.buttonoyoranihesapla = new System.Windows.Forms.Button();
            this.textBoxCpartioyorani = new System.Windows.Forms.TextBox();
            this.textBoxBpartioyorani = new System.Windows.Forms.TextBox();
            this.textBoxApartioyorani = new System.Windows.Forms.TextBox();
            this.labelCpartioyorani = new System.Windows.Forms.Label();
            this.labelBpartioyorani = new System.Windows.Forms.Label();
            this.labelApartioyorani = new System.Windows.Forms.Label();
            this.msgroupBox = new System.Windows.Forms.GroupBox();
            this.textBoxCmilletvekilisayisi = new System.Windows.Forms.TextBox();
            this.textBoxBmilletvekilisayisi = new System.Windows.Forms.TextBox();
            this.textBoxAmilletvekilisayisi = new System.Windows.Forms.TextBox();
            this.labelCmilletvekilisayisi = new System.Windows.Forms.Label();
            this.labelBmilletvekilisayisi = new System.Windows.Forms.Label();
            this.labelAmilletvekilisayisi = new System.Windows.Forms.Label();
            this.secimbölgebilgi.SuspendLayout();
            this.partibilgigroupBox.SuspendLayout();
            this.secimistatistikgroupBox.SuspendLayout();
            this.msgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // secimbölgebilgi
            // 
            this.secimbölgebilgi.Controls.Add(this.ilnufustextBox);
            this.secimbölgebilgi.Controls.Add(this.lblilnufusu);
            this.secimbölgebilgi.Controls.Add(this.comboBoxil);
            this.secimbölgebilgi.Controls.Add(this.lblil);
            this.secimbölgebilgi.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimbölgebilgi.Location = new System.Drawing.Point(190, 10);
            this.secimbölgebilgi.Margin = new System.Windows.Forms.Padding(2);
            this.secimbölgebilgi.Name = "secimbölgebilgi";
            this.secimbölgebilgi.Padding = new System.Windows.Forms.Padding(2);
            this.secimbölgebilgi.Size = new System.Drawing.Size(352, 121);
            this.secimbölgebilgi.TabIndex = 0;
            this.secimbölgebilgi.TabStop = false;
            this.secimbölgebilgi.Text = "Seçim Bölgesi Bilgileri";
            // 
            // ilnufustextBox
            // 
            this.ilnufustextBox.Enabled = false;
            this.ilnufustextBox.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilnufustextBox.Location = new System.Drawing.Point(200, 72);
            this.ilnufustextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ilnufustextBox.Name = "ilnufustextBox";
            this.ilnufustextBox.Size = new System.Drawing.Size(126, 24);
            this.ilnufustextBox.TabIndex = 3;
            // 
            // lblilnufusu
            // 
            this.lblilnufusu.AutoSize = true;
            this.lblilnufusu.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblilnufusu.Location = new System.Drawing.Point(50, 78);
            this.lblilnufusu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblilnufusu.Name = "lblilnufusu";
            this.lblilnufusu.Size = new System.Drawing.Size(117, 17);
            this.lblilnufusu.TabIndex = 2;
            this.lblilnufusu.Text = "Seçilen İlin Nüfusu";
            // 
            // comboBoxil
            // 
            this.comboBoxil.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxil.FormattingEnabled = true;
            this.comboBoxil.Location = new System.Drawing.Point(200, 34);
            this.comboBoxil.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxil.Name = "comboBoxil";
            this.comboBoxil.Size = new System.Drawing.Size(126, 25);
            this.comboBoxil.TabIndex = 1;
            this.comboBoxil.SelectedIndexChanged += new System.EventHandler(this.comboBoxil_SelectedIndexChanged);
            // 
            // lblil
            // 
            this.lblil.AutoSize = true;
            this.lblil.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblil.Location = new System.Drawing.Point(50, 41);
            this.lblil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblil.Name = "lblil";
            this.lblil.Size = new System.Drawing.Size(63, 17);
            this.lblil.TabIndex = 0;
            this.lblil.Text = "İl Seçiniz";
            // 
            // partibilgigroupBox
            // 
            this.partibilgigroupBox.Controls.Add(this.buttonmilletvekilihesapla);
            this.partibilgigroupBox.Controls.Add(this.textBoxmilletvekilisayi);
            this.partibilgigroupBox.Controls.Add(this.textBoxCpartioy);
            this.partibilgigroupBox.Controls.Add(this.textBoxBpartioy);
            this.partibilgigroupBox.Controls.Add(this.textBoxApartioy);
            this.partibilgigroupBox.Controls.Add(this.labelmilletvekilisayı);
            this.partibilgigroupBox.Controls.Add(this.labelCpartioy);
            this.partibilgigroupBox.Controls.Add(this.labelBpartioy);
            this.partibilgigroupBox.Controls.Add(this.labelApartioy);
            this.partibilgigroupBox.Enabled = false;
            this.partibilgigroupBox.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.partibilgigroupBox.Location = new System.Drawing.Point(18, 155);
            this.partibilgigroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.partibilgigroupBox.Name = "partibilgigroupBox";
            this.partibilgigroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.partibilgigroupBox.Size = new System.Drawing.Size(348, 241);
            this.partibilgigroupBox.TabIndex = 1;
            this.partibilgigroupBox.TabStop = false;
            this.partibilgigroupBox.Text = "Parti Bilgileri";
            // 
            // buttonmilletvekilihesapla
            // 
            this.buttonmilletvekilihesapla.Location = new System.Drawing.Point(38, 197);
            this.buttonmilletvekilihesapla.Margin = new System.Windows.Forms.Padding(2);
            this.buttonmilletvekilihesapla.Name = "buttonmilletvekilihesapla";
            this.buttonmilletvekilihesapla.Size = new System.Drawing.Size(266, 28);
            this.buttonmilletvekilihesapla.TabIndex = 8;
            this.buttonmilletvekilihesapla.Text = "Milletvekili Sayısını Hesapla";
            this.buttonmilletvekilihesapla.UseVisualStyleBackColor = true;
            this.buttonmilletvekilihesapla.Click += new System.EventHandler(this.buttonmilletvekilihesapla_Click);
            // 
            // textBoxmilletvekilisayi
            // 
            this.textBoxmilletvekilisayi.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxmilletvekilisayi.Location = new System.Drawing.Point(172, 145);
            this.textBoxmilletvekilisayi.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxmilletvekilisayi.Name = "textBoxmilletvekilisayi";
            this.textBoxmilletvekilisayi.Size = new System.Drawing.Size(133, 24);
            this.textBoxmilletvekilisayi.TabIndex = 7;
            // 
            // textBoxCpartioy
            // 
            this.textBoxCpartioy.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxCpartioy.Location = new System.Drawing.Point(172, 102);
            this.textBoxCpartioy.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCpartioy.Name = "textBoxCpartioy";
            this.textBoxCpartioy.Size = new System.Drawing.Size(133, 24);
            this.textBoxCpartioy.TabIndex = 6;
            // 
            // textBoxBpartioy
            // 
            this.textBoxBpartioy.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxBpartioy.Location = new System.Drawing.Point(172, 63);
            this.textBoxBpartioy.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBpartioy.Name = "textBoxBpartioy";
            this.textBoxBpartioy.Size = new System.Drawing.Size(133, 24);
            this.textBoxBpartioy.TabIndex = 5;
            // 
            // textBoxApartioy
            // 
            this.textBoxApartioy.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxApartioy.Location = new System.Drawing.Point(172, 27);
            this.textBoxApartioy.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxApartioy.Name = "textBoxApartioy";
            this.textBoxApartioy.Size = new System.Drawing.Size(133, 24);
            this.textBoxApartioy.TabIndex = 4;
            // 
            // labelmilletvekilisayı
            // 
            this.labelmilletvekilisayı.AutoSize = true;
            this.labelmilletvekilisayı.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelmilletvekilisayı.Location = new System.Drawing.Point(34, 147);
            this.labelmilletvekilisayı.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelmilletvekilisayı.Name = "labelmilletvekilisayı";
            this.labelmilletvekilisayı.Size = new System.Drawing.Size(125, 17);
            this.labelmilletvekilisayı.TabIndex = 3;
            this.labelmilletvekilisayı.Text = "İl Milletvekili Sayısı";
            // 
            // labelCpartioy
            // 
            this.labelCpartioy.AutoSize = true;
            this.labelCpartioy.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCpartioy.Location = new System.Drawing.Point(34, 110);
            this.labelCpartioy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCpartioy.Name = "labelCpartioy";
            this.labelCpartioy.Size = new System.Drawing.Size(115, 17);
            this.labelCpartioy.TabIndex = 2;
            this.labelCpartioy.Text = "C Partisi Oy Sayısı";
            // 
            // labelBpartioy
            // 
            this.labelBpartioy.AutoSize = true;
            this.labelBpartioy.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBpartioy.Location = new System.Drawing.Point(34, 72);
            this.labelBpartioy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBpartioy.Name = "labelBpartioy";
            this.labelBpartioy.Size = new System.Drawing.Size(116, 17);
            this.labelBpartioy.TabIndex = 1;
            this.labelBpartioy.Text = "B Partisi Oy Sayısı";
            // 
            // labelApartioy
            // 
            this.labelApartioy.AutoSize = true;
            this.labelApartioy.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelApartioy.Location = new System.Drawing.Point(34, 36);
            this.labelApartioy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelApartioy.Name = "labelApartioy";
            this.labelApartioy.Size = new System.Drawing.Size(116, 17);
            this.labelApartioy.TabIndex = 0;
            this.labelApartioy.Text = "A Partisi Oy Sayısı";
            // 
            // secimistatistikgroupBox
            // 
            this.secimistatistikgroupBox.Controls.Add(this.buttonoyoranihesapla);
            this.secimistatistikgroupBox.Controls.Add(this.textBoxCpartioyorani);
            this.secimistatistikgroupBox.Controls.Add(this.textBoxBpartioyorani);
            this.secimistatistikgroupBox.Controls.Add(this.textBoxApartioyorani);
            this.secimistatistikgroupBox.Controls.Add(this.labelCpartioyorani);
            this.secimistatistikgroupBox.Controls.Add(this.labelBpartioyorani);
            this.secimistatistikgroupBox.Controls.Add(this.labelApartioyorani);
            this.secimistatistikgroupBox.Enabled = false;
            this.secimistatistikgroupBox.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimistatistikgroupBox.Location = new System.Drawing.Point(390, 155);
            this.secimistatistikgroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.secimistatistikgroupBox.Name = "secimistatistikgroupBox";
            this.secimistatistikgroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.secimistatistikgroupBox.Size = new System.Drawing.Size(348, 241);
            this.secimistatistikgroupBox.TabIndex = 2;
            this.secimistatistikgroupBox.TabStop = false;
            this.secimistatistikgroupBox.Text = "Seçim İstatistikleri";
            // 
            // buttonoyoranihesapla
            // 
            this.buttonoyoranihesapla.Location = new System.Drawing.Point(44, 197);
            this.buttonoyoranihesapla.Margin = new System.Windows.Forms.Padding(2);
            this.buttonoyoranihesapla.Name = "buttonoyoranihesapla";
            this.buttonoyoranihesapla.Size = new System.Drawing.Size(259, 28);
            this.buttonoyoranihesapla.TabIndex = 6;
            this.buttonoyoranihesapla.Text = "Oy Oranı Hesapla";
            this.buttonoyoranihesapla.UseVisualStyleBackColor = true;
            this.buttonoyoranihesapla.Click += new System.EventHandler(this.buttonoyoranihesapla_Click);
            // 
            // textBoxCpartioyorani
            // 
            this.textBoxCpartioyorani.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxCpartioyorani.Location = new System.Drawing.Point(170, 108);
            this.textBoxCpartioyorani.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCpartioyorani.Name = "textBoxCpartioyorani";
            this.textBoxCpartioyorani.Size = new System.Drawing.Size(133, 24);
            this.textBoxCpartioyorani.TabIndex = 5;
            // 
            // textBoxBpartioyorani
            // 
            this.textBoxBpartioyorani.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxBpartioyorani.Location = new System.Drawing.Point(170, 70);
            this.textBoxBpartioyorani.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBpartioyorani.Name = "textBoxBpartioyorani";
            this.textBoxBpartioyorani.Size = new System.Drawing.Size(133, 24);
            this.textBoxBpartioyorani.TabIndex = 4;
            // 
            // textBoxApartioyorani
            // 
            this.textBoxApartioyorani.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxApartioyorani.Location = new System.Drawing.Point(170, 33);
            this.textBoxApartioyorani.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxApartioyorani.Name = "textBoxApartioyorani";
            this.textBoxApartioyorani.Size = new System.Drawing.Size(133, 24);
            this.textBoxApartioyorani.TabIndex = 3;
            // 
            // labelCpartioyorani
            // 
            this.labelCpartioyorani.AutoSize = true;
            this.labelCpartioyorani.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCpartioyorani.Location = new System.Drawing.Point(40, 110);
            this.labelCpartioyorani.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCpartioyorani.Name = "labelCpartioyorani";
            this.labelCpartioyorani.Size = new System.Drawing.Size(113, 17);
            this.labelCpartioyorani.TabIndex = 2;
            this.labelCpartioyorani.Text = "C Partisi Oy Oranı";
            // 
            // labelBpartioyorani
            // 
            this.labelBpartioyorani.AutoSize = true;
            this.labelBpartioyorani.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBpartioyorani.Location = new System.Drawing.Point(40, 72);
            this.labelBpartioyorani.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBpartioyorani.Name = "labelBpartioyorani";
            this.labelBpartioyorani.Size = new System.Drawing.Size(114, 17);
            this.labelBpartioyorani.TabIndex = 1;
            this.labelBpartioyorani.Text = "B Partisi Oy Oranı";
            // 
            // labelApartioyorani
            // 
            this.labelApartioyorani.AutoSize = true;
            this.labelApartioyorani.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelApartioyorani.Location = new System.Drawing.Point(40, 36);
            this.labelApartioyorani.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelApartioyorani.Name = "labelApartioyorani";
            this.labelApartioyorani.Size = new System.Drawing.Size(114, 17);
            this.labelApartioyorani.TabIndex = 0;
            this.labelApartioyorani.Text = "A Partisi Oy Oranı";
            // 
            // msgroupBox
            // 
            this.msgroupBox.Controls.Add(this.textBoxCmilletvekilisayisi);
            this.msgroupBox.Controls.Add(this.textBoxBmilletvekilisayisi);
            this.msgroupBox.Controls.Add(this.textBoxAmilletvekilisayisi);
            this.msgroupBox.Controls.Add(this.labelCmilletvekilisayisi);
            this.msgroupBox.Controls.Add(this.labelBmilletvekilisayisi);
            this.msgroupBox.Controls.Add(this.labelAmilletvekilisayisi);
            this.msgroupBox.Enabled = false;
            this.msgroupBox.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msgroupBox.Location = new System.Drawing.Point(18, 431);
            this.msgroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.msgroupBox.Name = "msgroupBox";
            this.msgroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.msgroupBox.Size = new System.Drawing.Size(720, 115);
            this.msgroupBox.TabIndex = 3;
            this.msgroupBox.TabStop = false;
            this.msgroupBox.Text = "Milletvekili Sayısı";
            // 
            // textBoxCmilletvekilisayisi
            // 
            this.textBoxCmilletvekilisayisi.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxCmilletvekilisayisi.Location = new System.Drawing.Point(661, 47);
            this.textBoxCmilletvekilisayisi.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCmilletvekilisayisi.Name = "textBoxCmilletvekilisayisi";
            this.textBoxCmilletvekilisayisi.Size = new System.Drawing.Size(48, 24);
            this.textBoxCmilletvekilisayisi.TabIndex = 5;
            // 
            // textBoxBmilletvekilisayisi
            // 
            this.textBoxBmilletvekilisayisi.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxBmilletvekilisayisi.Location = new System.Drawing.Point(415, 44);
            this.textBoxBmilletvekilisayisi.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBmilletvekilisayisi.Name = "textBoxBmilletvekilisayisi";
            this.textBoxBmilletvekilisayisi.Size = new System.Drawing.Size(49, 24);
            this.textBoxBmilletvekilisayisi.TabIndex = 4;
            // 
            // textBoxAmilletvekilisayisi
            // 
            this.textBoxAmilletvekilisayisi.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAmilletvekilisayisi.Location = new System.Drawing.Point(172, 48);
            this.textBoxAmilletvekilisayisi.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAmilletvekilisayisi.Name = "textBoxAmilletvekilisayisi";
            this.textBoxAmilletvekilisayisi.Size = new System.Drawing.Size(49, 24);
            this.textBoxAmilletvekilisayisi.TabIndex = 3;
            // 
            // labelCmilletvekilisayisi
            // 
            this.labelCmilletvekilisayisi.AutoSize = true;
            this.labelCmilletvekilisayisi.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCmilletvekilisayisi.Location = new System.Drawing.Point(494, 51);
            this.labelCmilletvekilisayisi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCmilletvekilisayisi.Name = "labelCmilletvekilisayisi";
            this.labelCmilletvekilisayisi.Size = new System.Drawing.Size(163, 17);
            this.labelCmilletvekilisayisi.TabIndex = 2;
            this.labelCmilletvekilisayisi.Text = "C Partisi Milletvekili Sayısı";
            // 
            // labelBmilletvekilisayisi
            // 
            this.labelBmilletvekilisayisi.AutoSize = true;
            this.labelBmilletvekilisayisi.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBmilletvekilisayisi.Location = new System.Drawing.Point(248, 51);
            this.labelBmilletvekilisayisi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBmilletvekilisayisi.Name = "labelBmilletvekilisayisi";
            this.labelBmilletvekilisayisi.Size = new System.Drawing.Size(164, 17);
            this.labelBmilletvekilisayisi.TabIndex = 1;
            this.labelBmilletvekilisayisi.Text = "B Partisi Milletvekili Sayısı";
            // 
            // labelAmilletvekilisayisi
            // 
            this.labelAmilletvekilisayisi.AutoSize = true;
            this.labelAmilletvekilisayisi.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAmilletvekilisayisi.Location = new System.Drawing.Point(4, 51);
            this.labelAmilletvekilisayisi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmilletvekilisayisi.Name = "labelAmilletvekilisayisi";
            this.labelAmilletvekilisayisi.Size = new System.Drawing.Size(164, 17);
            this.labelAmilletvekilisayisi.TabIndex = 0;
            this.labelAmilletvekilisayisi.Text = "A Partisi Milletvekili Sayısı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 563);
            this.Controls.Add(this.msgroupBox);
            this.Controls.Add(this.secimistatistikgroupBox);
            this.Controls.Add(this.partibilgigroupBox);
            this.Controls.Add(this.secimbölgebilgi);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.secimbölgebilgi.ResumeLayout(false);
            this.secimbölgebilgi.PerformLayout();
            this.partibilgigroupBox.ResumeLayout(false);
            this.partibilgigroupBox.PerformLayout();
            this.secimistatistikgroupBox.ResumeLayout(false);
            this.secimistatistikgroupBox.PerformLayout();
            this.msgroupBox.ResumeLayout(false);
            this.msgroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox secimbölgebilgi;
        private System.Windows.Forms.TextBox ilnufustextBox;
        private System.Windows.Forms.Label lblilnufusu;
        private System.Windows.Forms.ComboBox comboBoxil;
        private System.Windows.Forms.Label lblil;
        private System.Windows.Forms.GroupBox partibilgigroupBox;
        private System.Windows.Forms.Button buttonmilletvekilihesapla;
        private System.Windows.Forms.TextBox textBoxmilletvekilisayi;
        private System.Windows.Forms.TextBox textBoxCpartioy;
        private System.Windows.Forms.TextBox textBoxBpartioy;
        private System.Windows.Forms.TextBox textBoxApartioy;
        private System.Windows.Forms.Label labelmilletvekilisayı;
        private System.Windows.Forms.Label labelCpartioy;
        private System.Windows.Forms.Label labelBpartioy;
        private System.Windows.Forms.Label labelApartioy;
        private System.Windows.Forms.GroupBox secimistatistikgroupBox;
        private System.Windows.Forms.Button buttonoyoranihesapla;
        private System.Windows.Forms.TextBox textBoxCpartioyorani;
        private System.Windows.Forms.TextBox textBoxBpartioyorani;
        private System.Windows.Forms.TextBox textBoxApartioyorani;
        private System.Windows.Forms.Label labelCpartioyorani;
        private System.Windows.Forms.Label labelBpartioyorani;
        private System.Windows.Forms.Label labelApartioyorani;
        private System.Windows.Forms.GroupBox msgroupBox;
        private System.Windows.Forms.TextBox textBoxCmilletvekilisayisi;
        private System.Windows.Forms.TextBox textBoxBmilletvekilisayisi;
        private System.Windows.Forms.TextBox textBoxAmilletvekilisayisi;
        private System.Windows.Forms.Label labelCmilletvekilisayisi;
        private System.Windows.Forms.Label labelBmilletvekilisayisi;
        private System.Windows.Forms.Label labelAmilletvekilisayisi;
    }
}

