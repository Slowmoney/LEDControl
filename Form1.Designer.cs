namespace LEDControl
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.m0 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m44 = new System.Windows.Forms.RadioButton();
            this.m43 = new System.Windows.Forms.RadioButton();
            this.m42 = new System.Windows.Forms.RadioButton();
            this.m41 = new System.Windows.Forms.RadioButton();
            this.m40 = new System.Windows.Forms.RadioButton();
            this.m39 = new System.Windows.Forms.RadioButton();
            this.m38 = new System.Windows.Forms.RadioButton();
            this.m37 = new System.Windows.Forms.RadioButton();
            this.m36 = new System.Windows.Forms.RadioButton();
            this.m35 = new System.Windows.Forms.RadioButton();
            this.m34 = new System.Windows.Forms.RadioButton();
            this.m33 = new System.Windows.Forms.RadioButton();
            this.m32 = new System.Windows.Forms.RadioButton();
            this.m31 = new System.Windows.Forms.RadioButton();
            this.m30 = new System.Windows.Forms.RadioButton();
            this.m29 = new System.Windows.Forms.RadioButton();
            this.m28 = new System.Windows.Forms.RadioButton();
            this.m27 = new System.Windows.Forms.RadioButton();
            this.m26 = new System.Windows.Forms.RadioButton();
            this.m25 = new System.Windows.Forms.RadioButton();
            this.m24 = new System.Windows.Forms.RadioButton();
            this.m23 = new System.Windows.Forms.RadioButton();
            this.m21 = new System.Windows.Forms.RadioButton();
            this.m20 = new System.Windows.Forms.RadioButton();
            this.m19 = new System.Windows.Forms.RadioButton();
            this.m16 = new System.Windows.Forms.RadioButton();
            this.m15 = new System.Windows.Forms.RadioButton();
            this.m14 = new System.Windows.Forms.RadioButton();
            this.m13 = new System.Windows.Forms.RadioButton();
            this.m12 = new System.Windows.Forms.RadioButton();
            this.m11 = new System.Windows.Forms.RadioButton();
            this.m10 = new System.Windows.Forms.RadioButton();
            this.m9 = new System.Windows.Forms.RadioButton();
            this.m8 = new System.Windows.Forms.RadioButton();
            this.m7 = new System.Windows.Forms.RadioButton();
            this.m6 = new System.Windows.Forms.RadioButton();
            this.m5 = new System.Windows.Forms.RadioButton();
            this.m4 = new System.Windows.Forms.RadioButton();
            this.m3 = new System.Windows.Forms.RadioButton();
            this.m2 = new System.Windows.Forms.RadioButton();
            this.m1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(2, 29);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar1.Size = new System.Drawing.Size(144, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            this.trackBar1.MouseCaptureChanged += new System.EventHandler(this.TrackBar1_MouseCaptureChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.ComboBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600"});
            this.comboBox2.Location = new System.Drawing.Point(210, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // m0
            // 
            this.m0.AutoSize = true;
            this.m0.Location = new System.Drawing.Point(3, 3);
            this.m0.Name = "m0";
            this.m0.Size = new System.Drawing.Size(67, 17);
            this.m0.TabIndex = 5;
            this.m0.TabStop = true;
            this.m0.Text = "ALL OFF";
            this.m0.UseVisualStyleBackColor = true;
            this.m0.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m44);
            this.panel1.Controls.Add(this.m43);
            this.panel1.Controls.Add(this.m42);
            this.panel1.Controls.Add(this.m41);
            this.panel1.Controls.Add(this.m40);
            this.panel1.Controls.Add(this.m39);
            this.panel1.Controls.Add(this.m38);
            this.panel1.Controls.Add(this.m37);
            this.panel1.Controls.Add(this.m36);
            this.panel1.Controls.Add(this.m35);
            this.panel1.Controls.Add(this.m34);
            this.panel1.Controls.Add(this.m33);
            this.panel1.Controls.Add(this.m32);
            this.panel1.Controls.Add(this.m31);
            this.panel1.Controls.Add(this.m30);
            this.panel1.Controls.Add(this.m29);
            this.panel1.Controls.Add(this.m28);
            this.panel1.Controls.Add(this.m27);
            this.panel1.Controls.Add(this.m26);
            this.panel1.Controls.Add(this.m25);
            this.panel1.Controls.Add(this.m24);
            this.panel1.Controls.Add(this.m23);
            this.panel1.Controls.Add(this.m21);
            this.panel1.Controls.Add(this.m20);
            this.panel1.Controls.Add(this.m19);
            this.panel1.Controls.Add(this.m16);
            this.panel1.Controls.Add(this.m15);
            this.panel1.Controls.Add(this.m14);
            this.panel1.Controls.Add(this.m13);
            this.panel1.Controls.Add(this.m12);
            this.panel1.Controls.Add(this.m11);
            this.panel1.Controls.Add(this.m10);
            this.panel1.Controls.Add(this.m9);
            this.panel1.Controls.Add(this.m8);
            this.panel1.Controls.Add(this.m7);
            this.panel1.Controls.Add(this.m6);
            this.panel1.Controls.Add(this.m5);
            this.panel1.Controls.Add(this.m4);
            this.panel1.Controls.Add(this.m3);
            this.panel1.Controls.Add(this.m2);
            this.panel1.Controls.Add(this.m1);
            this.panel1.Controls.Add(this.m0);
            this.panel1.Location = new System.Drawing.Point(15, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 424);
            this.panel1.TabIndex = 6;
          
            // 
            // m44
            // 
            this.m44.AutoSize = true;
            this.m44.Location = new System.Drawing.Point(383, 296);
            this.m44.Name = "m44";
            this.m44.Size = new System.Drawing.Size(56, 17);
            this.m44.TabIndex = 44;
            this.m44.TabStop = true;
            this.m44.Text = "Strobe";
            this.m44.UseVisualStyleBackColor = true;
            this.m44.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m43
            // 
            this.m43.AutoSize = true;
            this.m43.Location = new System.Drawing.Point(383, 273);
            this.m43.Name = "m43";
            this.m43.Size = new System.Drawing.Size(130, 17);
            this.m43.TabIndex = 45;
            this.m43.TabStop = true;
            this.m43.Text = "theaterChaseRainbow";
            this.m43.UseVisualStyleBackColor = true;
            this.m43.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m42
            // 
            this.m42.AutoSize = true;
            this.m42.Location = new System.Drawing.Point(383, 250);
            this.m42.Name = "m42";
            this.m42.Size = new System.Drawing.Size(88, 17);
            this.m42.TabIndex = 42;
            this.m42.TabStop = true;
            this.m42.Text = "theaterChase";
            this.m42.UseVisualStyleBackColor = true;
            this.m42.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m41
            // 
            this.m41.AutoSize = true;
            this.m41.Location = new System.Drawing.Point(383, 229);
            this.m41.Name = "m41";
            this.m41.Size = new System.Drawing.Size(88, 17);
            this.m41.TabIndex = 43;
            this.m41.TabStop = true;
            this.m41.Text = "SnowSparkle";
            this.m41.UseVisualStyleBackColor = true;
            this.m41.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m40
            // 
            this.m40.AutoSize = true;
            this.m40.Location = new System.Drawing.Point(383, 206);
            this.m40.Name = "m40";
            this.m40.Size = new System.Drawing.Size(61, 17);
            this.m40.TabIndex = 40;
            this.m40.TabStop = true;
            this.m40.Text = "Sparkle";
            this.m40.UseVisualStyleBackColor = true;
            this.m40.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m39
            // 
            this.m39.AutoSize = true;
            this.m39.Location = new System.Drawing.Point(383, 183);
            this.m39.Name = "m39";
            this.m39.Size = new System.Drawing.Size(93, 17);
            this.m39.TabIndex = 41;
            this.m39.TabStop = true;
            this.m39.Text = "RunningLights";
            this.m39.UseVisualStyleBackColor = true;
            this.m39.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m38
            // 
            this.m38.AutoSize = true;
            this.m38.Location = new System.Drawing.Point(383, 158);
            this.m38.Name = "m38";
            this.m38.Size = new System.Drawing.Size(99, 17);
            this.m38.TabIndex = 38;
            this.m38.TabStop = true;
            this.m38.Text = "rainbowTwinkle";
            this.m38.UseVisualStyleBackColor = true;
            this.m38.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m37
            // 
            this.m37.AutoSize = true;
            this.m37.Location = new System.Drawing.Point(383, 137);
            this.m37.Name = "m37";
            this.m37.Size = new System.Drawing.Size(88, 17);
            this.m37.TabIndex = 39;
            this.m37.TabStop = true;
            this.m37.Text = "rainbowCycle";
            this.m37.UseVisualStyleBackColor = true;
            this.m37.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m36
            // 
            this.m36.AutoSize = true;
            this.m36.Location = new System.Drawing.Point(383, 116);
            this.m36.Name = "m36";
            this.m36.Size = new System.Drawing.Size(71, 17);
            this.m36.TabIndex = 36;
            this.m36.TabStop = true;
            this.m36.Text = "NewKITT";
            this.m36.UseVisualStyleBackColor = true;
            this.m36.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m35
            // 
            this.m35.AutoSize = true;
            this.m35.Location = new System.Drawing.Point(383, 93);
            this.m35.Name = "m35";
            this.m35.Size = new System.Drawing.Size(42, 17);
            this.m35.TabIndex = 37;
            this.m35.TabStop = true;
            this.m35.Text = "Fire";
            this.m35.UseVisualStyleBackColor = true;
            this.m35.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m34
            // 
            this.m34.AutoSize = true;
            this.m34.Location = new System.Drawing.Point(383, 70);
            this.m34.Name = "m34";
            this.m34.Size = new System.Drawing.Size(88, 17);
            this.m34.TabIndex = 34;
            this.m34.TabStop = true;
            this.m34.Text = "CylonBounce";
            this.m34.UseVisualStyleBackColor = true;
            this.m34.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m33
            // 
            this.m33.AutoSize = true;
            this.m33.Location = new System.Drawing.Point(383, 49);
            this.m33.Name = "m33";
            this.m33.Size = new System.Drawing.Size(73, 17);
            this.m33.TabIndex = 35;
            this.m33.TabStop = true;
            this.m33.Text = "colorWipe";
            this.m33.UseVisualStyleBackColor = true;
            this.m33.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m32
            // 
            this.m32.AutoSize = true;
            this.m32.Location = new System.Drawing.Point(383, 26);
            this.m32.Name = "m32";
            this.m32.Size = new System.Drawing.Size(157, 17);
            this.m32.TabIndex = 32;
            this.m32.TabStop = true;
            this.m32.Text = "MARCH STRIP NOW CCW";
            this.m32.UseVisualStyleBackColor = true;
            this.m32.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m31
            // 
            this.m31.AutoSize = true;
            this.m31.Location = new System.Drawing.Point(383, 5);
            this.m31.Name = "m31";
            this.m31.Size = new System.Drawing.Size(157, 17);
            this.m31.TabIndex = 33;
            this.m31.TabStop = true;
            this.m31.Text = "MARCH STRIP NOW CCW";
            this.m31.UseVisualStyleBackColor = true;
            this.m31.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m30
            // 
            this.m30.AutoSize = true;
            this.m30.Location = new System.Drawing.Point(181, 294);
            this.m30.Name = "m30";
            this.m30.Size = new System.Drawing.Size(138, 17);
            this.m30.TabIndex = 30;
            this.m30.TabStop = true;
            this.m30.Text = "NEW RAINBOW LOOP";
            this.m30.UseVisualStyleBackColor = true;
            this.m30.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m29
            // 
            this.m29.AutoSize = true;
            this.m29.Location = new System.Drawing.Point(181, 271);
            this.m29.Name = "m29";
            this.m29.Size = new System.Drawing.Size(95, 17);
            this.m29.TabIndex = 31;
            this.m29.TabStop = true;
            this.m29.Text = "MATRIX RAIN";
            this.m29.UseVisualStyleBackColor = true;
            this.m29.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m28
            // 
            this.m28.AutoSize = true;
            this.m28.Location = new System.Drawing.Point(181, 248);
            this.m28.Name = "m28";
            this.m28.Size = new System.Drawing.Size(49, 17);
            this.m28.TabIndex = 28;
            this.m28.TabStop = true;
            this.m28.Text = "KITT";
            this.m28.UseVisualStyleBackColor = true;
            this.m28.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m27
            // 
            this.m27.AutoSize = true;
            this.m27.Location = new System.Drawing.Point(181, 227);
            this.m27.Name = "m27";
            this.m27.Size = new System.Drawing.Size(115, 17);
            this.m27.TabIndex = 29;
            this.m27.TabStop = true;
            this.m27.Text = "RGB PROPELLER";
            this.m27.UseVisualStyleBackColor = true;
            this.m27.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m26
            // 
            this.m26.AutoSize = true;
            this.m26.Location = new System.Drawing.Point(181, 204);
            this.m26.Name = "m26";
            this.m26.Size = new System.Drawing.Size(140, 17);
            this.m26.TabIndex = 26;
            this.m26.TabStop = true;
            this.m26.Text = "EMERGECNY STROBE";
            this.m26.UseVisualStyleBackColor = true;
            this.m26.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m25
            // 
            this.m25.AutoSize = true;
            this.m25.Location = new System.Drawing.Point(181, 183);
            this.m25.Name = "m25";
            this.m25.Size = new System.Drawing.Size(138, 17);
            this.m25.TabIndex = 27;
            this.m25.TabStop = true;
            this.m25.Text = "RANDOM COLOR POP";
            this.m25.UseVisualStyleBackColor = true;
            this.m25.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m24
            // 
            this.m24.AutoSize = true;
            this.m24.Location = new System.Drawing.Point(181, 160);
            this.m24.Name = "m24";
            this.m24.Size = new System.Drawing.Size(70, 17);
            this.m24.TabIndex = 24;
            this.m24.TabStop = true;
            this.m24.Text = "PACMAN";
            this.m24.UseVisualStyleBackColor = true;
            this.m24.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m23
            // 
            this.m23.AutoSize = true;
            this.m23.Location = new System.Drawing.Point(181, 137);
            this.m23.Name = "m23";
            this.m23.Size = new System.Drawing.Size(132, 17);
            this.m23.TabIndex = 25;
            this.m23.TabStop = true;
            this.m23.Text = "VERITCAL RAINBOW";
            this.m23.UseVisualStyleBackColor = true;
            this.m23.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m21
            // 
            this.m21.AutoSize = true;
            this.m21.Location = new System.Drawing.Point(181, 114);
            this.m21.Name = "m21";
            this.m21.Size = new System.Drawing.Size(201, 17);
            this.m21.TabIndex = 22;
            this.m21.TabStop = true;
            this.m21.Text = "QUADRATIC BRIGHTNESS CURVE";
            this.m21.UseVisualStyleBackColor = true;
            this.m21.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m20
            // 
            this.m20.AutoSize = true;
            this.m20.Location = new System.Drawing.Point(181, 93);
            this.m20.Name = "m20";
            this.m20.Size = new System.Drawing.Size(115, 17);
            this.m20.TabIndex = 23;
            this.m20.TabStop = true;
            this.m20.Text = "POP LEFT/RIGHT";
            this.m20.UseVisualStyleBackColor = true;
            this.m20.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m19
            // 
            this.m19.AutoSize = true;
            this.m19.Location = new System.Drawing.Point(181, 70);
            this.m19.Name = "m19";
            this.m19.Size = new System.Drawing.Size(151, 17);
            this.m19.TabIndex = 20;
            this.m19.TabStop = true;
            this.m19.Text = "SIN WAVE BRIGHTNESS";
            this.m19.UseVisualStyleBackColor = true;
            this.m19.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m16
            // 
            this.m16.AutoSize = true;
            this.m16.Location = new System.Drawing.Point(181, 49);
            this.m16.Name = "m16";
            this.m16.Size = new System.Drawing.Size(131, 17);
            this.m16.TabIndex = 21;
            this.m16.TabStop = true;
            this.m16.Text = "RADIATION SYMBOL";
            this.m16.UseVisualStyleBackColor = true;
            this.m16.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m15
            // 
            this.m15.AutoSize = true;
            this.m15.Location = new System.Drawing.Point(181, 26);
            this.m15.Name = "m15";
            this.m15.Size = new System.Drawing.Size(140, 17);
            this.m15.TabIndex = 18;
            this.m15.TabStop = true;
            this.m15.Text = "MARCH RWB COLORS";
            this.m15.UseVisualStyleBackColor = true;
            this.m15.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m14
            // 
            this.m14.AutoSize = true;
            this.m14.Location = new System.Drawing.Point(181, 3);
            this.m14.Name = "m14";
            this.m14.Size = new System.Drawing.Size(162, 17);
            this.m14.TabIndex = 19;
            this.m14.TabStop = true;
            this.m14.Text = "MARCH RANDOM COLORS";
            this.m14.UseVisualStyleBackColor = true;
            this.m14.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m13
            // 
            this.m13.AutoSize = true;
            this.m13.Location = new System.Drawing.Point(3, 292);
            this.m13.Name = "m13";
            this.m13.Size = new System.Drawing.Size(169, 17);
            this.m13.TabIndex = 16;
            this.m13.TabStop = true;
            this.m13.Text = "CELL AUTO - RULE 30 (RED)";
            this.m13.UseVisualStyleBackColor = true;
            this.m13.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m12
            // 
            this.m12.AutoSize = true;
            this.m12.Location = new System.Drawing.Point(3, 271);
            this.m12.Name = "m12";
            this.m12.Size = new System.Drawing.Size(145, 17);
            this.m12.TabIndex = 17;
            this.m12.TabStop = true;
            this.m12.Text = "VERTICAL SOMETHING";
            this.m12.UseVisualStyleBackColor = true;
            this.m12.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m11
            // 
            this.m11.AutoSize = true;
            this.m11.Location = new System.Drawing.Point(3, 248);
            this.m11.Name = "m11";
            this.m11.Size = new System.Drawing.Size(173, 17);
            this.m11.TabIndex = 14;
            this.m11.TabStop = true;
            this.m11.Text = "PULSE COLOR SATURATION";
            this.m11.UseVisualStyleBackColor = true;
            this.m11.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m10
            // 
            this.m10.AutoSize = true;
            this.m10.Location = new System.Drawing.Point(3, 227);
            this.m10.Name = "m10";
            this.m10.Size = new System.Drawing.Size(173, 17);
            this.m10.TabIndex = 15;
            this.m10.TabStop = true;
            this.m10.Text = "PULSE COLOR BRIGHTNESS";
            this.m10.UseVisualStyleBackColor = true;
            this.m10.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m9
            // 
            this.m9.AutoSize = true;
            this.m9.Location = new System.Drawing.Point(3, 204);
            this.m9.Name = "m9";
            this.m9.Size = new System.Drawing.Size(104, 17);
            this.m9.TabIndex = 12;
            this.m9.TabStop = true;
            this.m9.Text = "STRIP FLICKER";
            this.m9.UseVisualStyleBackColor = true;
            this.m9.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m8
            // 
            this.m8.AutoSize = true;
            this.m8.Location = new System.Drawing.Point(3, 181);
            this.m8.Name = "m8";
            this.m8.Size = new System.Drawing.Size(140, 17);
            this.m8.TabIndex = 13;
            this.m8.TabStop = true;
            this.m8.Text = "POLICE LIGHTS SOLID";
            this.m8.UseVisualStyleBackColor = true;
            this.m8.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m7
            // 
            this.m7.AutoSize = true;
            this.m7.Location = new System.Drawing.Point(3, 158);
            this.m7.Name = "m7";
            this.m7.Size = new System.Drawing.Size(147, 17);
            this.m7.TabIndex = 10;
            this.m7.TabStop = true;
            this.m7.Text = "POLICE LIGHTS SINGLE";
            this.m7.UseVisualStyleBackColor = true;
            this.m7.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m6
            // 
            this.m6.AutoSize = true;
            this.m6.Location = new System.Drawing.Point(3, 137);
            this.m6.Name = "m6";
            this.m6.Size = new System.Drawing.Size(76, 17);
            this.m6.TabIndex = 11;
            this.m6.TabStop = true;
            this.m6.Text = "CYLON v2";
            this.m6.UseVisualStyleBackColor = true;
            this.m6.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m5
            // 
            this.m5.AutoSize = true;
            this.m5.Location = new System.Drawing.Point(3, 114);
            this.m5.Name = "m5";
            this.m5.Size = new System.Drawing.Size(76, 17);
            this.m5.TabIndex = 8;
            this.m5.TabStop = true;
            this.m5.Text = "CYLON v1";
            this.m5.UseVisualStyleBackColor = true;
            this.m5.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m4
            // 
            this.m4.AutoSize = true;
            this.m4.Location = new System.Drawing.Point(3, 93);
            this.m4.Name = "m4";
            this.m4.Size = new System.Drawing.Size(113, 17);
            this.m4.TabIndex = 9;
            this.m4.TabStop = true;
            this.m4.Text = "RANDOM BURST";
            this.m4.UseVisualStyleBackColor = true;
            this.m4.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m3
            // 
            this.m3.AutoSize = true;
            this.m3.Location = new System.Drawing.Point(3, 70);
            this.m3.Name = "m3";
            this.m3.Size = new System.Drawing.Size(109, 17);
            this.m3.TabIndex = 6;
            this.m3.TabStop = true;
            this.m3.Text = "RAINBOW LOOP";
            this.m3.UseVisualStyleBackColor = true;
            this.m3.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m2
            // 
            this.m2.AutoSize = true;
            this.m2.Location = new System.Drawing.Point(3, 47);
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(143, 17);
            this.m2.TabIndex = 7;
            this.m2.TabStop = true;
            this.m2.Text = "STRIP RAINBOW FADE";
            this.m2.UseVisualStyleBackColor = true;
            this.m2.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // m1
            // 
            this.m1.AutoSize = true;
            this.m1.Location = new System.Drawing.Point(3, 24);
            this.m1.Name = "m1";
            this.m1.Size = new System.Drawing.Size(63, 17);
            this.m1.TabIndex = 0;
            this.m1.TabStop = true;
            this.m1.Text = "ALL ON";
            this.m1.UseVisualStyleBackColor = true;
            this.m1.CheckedChanged += new System.EventHandler(this.Select_Mode);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 572);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton m0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton m1;
        private System.Windows.Forms.RadioButton m5;
        private System.Windows.Forms.RadioButton m4;
        private System.Windows.Forms.RadioButton m3;
        private System.Windows.Forms.RadioButton m2;
        private System.Windows.Forms.RadioButton m38;
        private System.Windows.Forms.RadioButton m37;
        private System.Windows.Forms.RadioButton m36;
        private System.Windows.Forms.RadioButton m35;
        private System.Windows.Forms.RadioButton m34;
        private System.Windows.Forms.RadioButton m33;
        private System.Windows.Forms.RadioButton m32;
        private System.Windows.Forms.RadioButton m31;
        private System.Windows.Forms.RadioButton m30;
        private System.Windows.Forms.RadioButton m29;
        private System.Windows.Forms.RadioButton m28;
        private System.Windows.Forms.RadioButton m27;
        private System.Windows.Forms.RadioButton m26;
        private System.Windows.Forms.RadioButton m25;
        private System.Windows.Forms.RadioButton m24;
        private System.Windows.Forms.RadioButton m23;
        private System.Windows.Forms.RadioButton m21;
        private System.Windows.Forms.RadioButton m20;
        private System.Windows.Forms.RadioButton m19;
        private System.Windows.Forms.RadioButton m16;
        private System.Windows.Forms.RadioButton m15;
        private System.Windows.Forms.RadioButton m14;
        private System.Windows.Forms.RadioButton m13;
        private System.Windows.Forms.RadioButton m12;
        private System.Windows.Forms.RadioButton m11;
        private System.Windows.Forms.RadioButton m10;
        private System.Windows.Forms.RadioButton m9;
        private System.Windows.Forms.RadioButton m8;
        private System.Windows.Forms.RadioButton m7;
        private System.Windows.Forms.RadioButton m6;
        private System.Windows.Forms.RadioButton m44;
        private System.Windows.Forms.RadioButton m43;
        private System.Windows.Forms.RadioButton m42;
        private System.Windows.Forms.RadioButton m41;
        private System.Windows.Forms.RadioButton m40;
        private System.Windows.Forms.RadioButton m39;
        private System.Windows.Forms.Label label2;
    }
}

