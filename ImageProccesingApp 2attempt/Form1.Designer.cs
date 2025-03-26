namespace ImageProccesingApp_2attempt
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_zoom = new System.Windows.Forms.Button();
            this.btn_center = new System.Windows.Forms.Button();
            this.btn_autosize = new System.Windows.Forms.Button();
            this.btn_stretch = new System.Windows.Forms.Button();
            this.btn_normal = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Brightnes = new System.Windows.Forms.Label();
            this.trk_bright = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.trk_contrast = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trk_hue = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.txt_hight = new System.Windows.Forms.TextBox();
            this.txt_width = new System.Windows.Forms.TextBox();
            this.txt_imgpath = new System.Windows.Forms.TextBox();
            this.btn_f5 = new System.Windows.Forms.Button();
            this.btn_f4 = new System.Windows.Forms.Button();
            this.btn_f3 = new System.Windows.Forms.Button();
            this.btn_f2 = new System.Windows.Forms.Button();
            this.btn_f1 = new System.Windows.Forms.Button();
            this.btn_rotate = new System.Windows.Forms.Button();
            this.btn_reload = new System.Windows.Forms.Button();
            this.btn_resize = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_bright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_hue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 360);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(24, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(649, 323);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 366);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(934, 190);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(696, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 360);
            this.panel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(696, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 360);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btn_zoom);
            this.panel5.Controls.Add(this.btn_center);
            this.panel5.Controls.Add(this.btn_autosize);
            this.panel5.Controls.Add(this.btn_stretch);
            this.panel5.Controls.Add(this.btn_normal);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(697, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(241, 360);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(88, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Final Image";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_zoom
            // 
            this.btn_zoom.AutoSize = true;
            this.btn_zoom.FlatAppearance.BorderSize = 3;
            this.btn_zoom.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_zoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zoom.ForeColor = System.Drawing.Color.LightSalmon;
            this.btn_zoom.Location = new System.Drawing.Point(8, 298);
            this.btn_zoom.Name = "btn_zoom";
            this.btn_zoom.Size = new System.Drawing.Size(217, 38);
            this.btn_zoom.TabIndex = 5;
            this.btn_zoom.Text = "Zoom";
            this.btn_zoom.UseVisualStyleBackColor = true;
            // 
            // btn_center
            // 
            this.btn_center.AutoSize = true;
            this.btn_center.FlatAppearance.BorderSize = 3;
            this.btn_center.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_center.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_center.ForeColor = System.Drawing.Color.LightSalmon;
            this.btn_center.Location = new System.Drawing.Point(8, 254);
            this.btn_center.Name = "btn_center";
            this.btn_center.Size = new System.Drawing.Size(217, 38);
            this.btn_center.TabIndex = 4;
            this.btn_center.Text = "Center";
            this.btn_center.UseVisualStyleBackColor = true;
            // 
            // btn_autosize
            // 
            this.btn_autosize.AutoSize = true;
            this.btn_autosize.FlatAppearance.BorderSize = 3;
            this.btn_autosize.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_autosize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_autosize.ForeColor = System.Drawing.Color.LightSalmon;
            this.btn_autosize.Location = new System.Drawing.Point(8, 210);
            this.btn_autosize.Name = "btn_autosize";
            this.btn_autosize.Size = new System.Drawing.Size(217, 38);
            this.btn_autosize.TabIndex = 3;
            this.btn_autosize.Text = "Auto Size";
            this.btn_autosize.UseVisualStyleBackColor = true;
            // 
            // btn_stretch
            // 
            this.btn_stretch.AutoSize = true;
            this.btn_stretch.FlatAppearance.BorderSize = 3;
            this.btn_stretch.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_stretch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stretch.ForeColor = System.Drawing.Color.LightSalmon;
            this.btn_stretch.Location = new System.Drawing.Point(8, 166);
            this.btn_stretch.Name = "btn_stretch";
            this.btn_stretch.Size = new System.Drawing.Size(217, 38);
            this.btn_stretch.TabIndex = 2;
            this.btn_stretch.Text = "Stretch";
            this.btn_stretch.UseVisualStyleBackColor = true;
            // 
            // btn_normal
            // 
            this.btn_normal.AutoSize = true;
            this.btn_normal.FlatAppearance.BorderSize = 3;
            this.btn_normal.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_normal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_normal.ForeColor = System.Drawing.Color.LightSalmon;
            this.btn_normal.Location = new System.Drawing.Point(8, 122);
            this.btn_normal.Name = "btn_normal";
            this.btn_normal.Size = new System.Drawing.Size(217, 38);
            this.btn_normal.TabIndex = 1;
            this.btn_normal.Text = "Normal";
            this.btn_normal.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox2.Location = new System.Drawing.Point(8, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(221, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel6.Controls.Add(this.Brightnes);
            this.panel6.Controls.Add(this.trk_bright);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.trk_contrast);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.trk_hue);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.lbl_size);
            this.panel6.Controls.Add(this.txt_hight);
            this.panel6.Controls.Add(this.txt_width);
            this.panel6.Controls.Add(this.txt_imgpath);
            this.panel6.Controls.Add(this.btn_f5);
            this.panel6.Controls.Add(this.btn_f4);
            this.panel6.Controls.Add(this.btn_f3);
            this.panel6.Controls.Add(this.btn_f2);
            this.panel6.Controls.Add(this.btn_f1);
            this.panel6.Controls.Add(this.btn_rotate);
            this.panel6.Controls.Add(this.btn_reload);
            this.panel6.Controls.Add(this.btn_resize);
            this.panel6.Controls.Add(this.btn_save);
            this.panel6.Controls.Add(this.btn_open);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 370);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(934, 190);
            this.panel6.TabIndex = 2;
            // 
            // Brightnes
            // 
            this.Brightnes.AllowDrop = true;
            this.Brightnes.AutoEllipsis = true;
            this.Brightnes.AutoSize = true;
            this.Brightnes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Brightnes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Brightnes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Brightnes.Location = new System.Drawing.Point(635, 97);
            this.Brightnes.Name = "Brightnes";
            this.Brightnes.Size = new System.Drawing.Size(63, 16);
            this.Brightnes.TabIndex = 26;
            this.Brightnes.Text = "Brightnes";
            // 
            // trk_bright
            // 
            this.trk_bright.Location = new System.Drawing.Point(697, 94);
            this.trk_bright.Name = "trk_bright";
            this.trk_bright.Size = new System.Drawing.Size(140, 56);
            this.trk_bright.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(433, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Contrast";
            // 
            // trk_contrast
            // 
            this.trk_contrast.Location = new System.Drawing.Point(495, 94);
            this.trk_contrast.Name = "trk_contrast";
            this.trk_contrast.Size = new System.Drawing.Size(140, 56);
            this.trk_contrast.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(241, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Hue";
            // 
            // trk_hue
            // 
            this.trk_hue.Location = new System.Drawing.Point(285, 94);
            this.trk_hue.Name = "trk_hue";
            this.trk_hue.Size = new System.Drawing.Size(140, 56);
            this.trk_hue.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(150, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Hight";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(22, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Width";
            // 
            // lbl_size
            // 
            this.lbl_size.AllowDrop = true;
            this.lbl_size.AutoEllipsis = true;
            this.lbl_size.AutoSize = true;
            this.lbl_size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_size.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_size.Location = new System.Drawing.Point(95, 11);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(74, 16);
            this.lbl_size.TabIndex = 7;
            this.lbl_size.Text = "Image Size";
            // 
            // txt_hight
            // 
            this.txt_hight.Location = new System.Drawing.Point(120, 94);
            this.txt_hight.Name = "txt_hight";
            this.txt_hight.Size = new System.Drawing.Size(100, 22);
            this.txt_hight.TabIndex = 18;
            this.txt_hight.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_width
            // 
            this.txt_width.Location = new System.Drawing.Point(4, 94);
            this.txt_width.Name = "txt_width";
            this.txt_width.Size = new System.Drawing.Size(100, 22);
            this.txt_width.TabIndex = 17;
            // 
            // txt_imgpath
            // 
            this.txt_imgpath.Location = new System.Drawing.Point(3, 30);
            this.txt_imgpath.Multiline = true;
            this.txt_imgpath.Name = "txt_imgpath";
            this.txt_imgpath.Size = new System.Drawing.Size(422, 38);
            this.txt_imgpath.TabIndex = 16;
            // 
            // btn_f5
            // 
            this.btn_f5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_f5.FlatAppearance.BorderSize = 2;
            this.btn_f5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_f5.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_f5.Location = new System.Drawing.Point(835, 149);
            this.btn_f5.Name = "btn_f5";
            this.btn_f5.Size = new System.Drawing.Size(90, 38);
            this.btn_f5.TabIndex = 15;
            this.btn_f5.Text = "Filter-5";
            this.btn_f5.UseVisualStyleBackColor = true;
            // 
            // btn_f4
            // 
            this.btn_f4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_f4.FlatAppearance.BorderSize = 2;
            this.btn_f4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_f4.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_f4.Location = new System.Drawing.Point(722, 149);
            this.btn_f4.Name = "btn_f4";
            this.btn_f4.Size = new System.Drawing.Size(90, 38);
            this.btn_f4.TabIndex = 14;
            this.btn_f4.Text = "Filter-4";
            this.btn_f4.UseVisualStyleBackColor = true;
            // 
            // btn_f3
            // 
            this.btn_f3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_f3.FlatAppearance.BorderSize = 2;
            this.btn_f3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_f3.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_f3.Location = new System.Drawing.Point(599, 149);
            this.btn_f3.Name = "btn_f3";
            this.btn_f3.Size = new System.Drawing.Size(90, 38);
            this.btn_f3.TabIndex = 13;
            this.btn_f3.Text = "Filter-3";
            this.btn_f3.UseVisualStyleBackColor = true;
            // 
            // btn_f2
            // 
            this.btn_f2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_f2.FlatAppearance.BorderSize = 2;
            this.btn_f2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_f2.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_f2.Location = new System.Drawing.Point(477, 149);
            this.btn_f2.Name = "btn_f2";
            this.btn_f2.Size = new System.Drawing.Size(90, 38);
            this.btn_f2.TabIndex = 12;
            this.btn_f2.Text = "Filter-2";
            this.btn_f2.UseVisualStyleBackColor = true;
            // 
            // btn_f1
            // 
            this.btn_f1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_f1.FlatAppearance.BorderSize = 2;
            this.btn_f1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_f1.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_f1.Location = new System.Drawing.Point(356, 149);
            this.btn_f1.Name = "btn_f1";
            this.btn_f1.Size = new System.Drawing.Size(90, 38);
            this.btn_f1.TabIndex = 11;
            this.btn_f1.Text = "Filter-1";
            this.btn_f1.UseVisualStyleBackColor = true;
            // 
            // btn_rotate
            // 
            this.btn_rotate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_rotate.FlatAppearance.BorderSize = 2;
            this.btn_rotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rotate.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_rotate.Location = new System.Drawing.Point(238, 149);
            this.btn_rotate.Name = "btn_rotate";
            this.btn_rotate.Size = new System.Drawing.Size(90, 38);
            this.btn_rotate.TabIndex = 10;
            this.btn_rotate.Text = "Rotate";
            this.btn_rotate.UseVisualStyleBackColor = true;
            // 
            // btn_reload
            // 
            this.btn_reload.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_reload.FlatAppearance.BorderSize = 2;
            this.btn_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reload.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_reload.Location = new System.Drawing.Point(120, 149);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(90, 38);
            this.btn_reload.TabIndex = 9;
            this.btn_reload.Text = "Reset";
            this.btn_reload.UseVisualStyleBackColor = true;
            // 
            // btn_resize
            // 
            this.btn_resize.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_resize.FlatAppearance.BorderSize = 2;
            this.btn_resize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_resize.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_resize.Location = new System.Drawing.Point(3, 149);
            this.btn_resize.Name = "btn_resize";
            this.btn_resize.Size = new System.Drawing.Size(90, 38);
            this.btn_resize.TabIndex = 8;
            this.btn_resize.Text = "Set";
            this.btn_resize.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(92)))));
            this.btn_save.Location = new System.Drawing.Point(679, 30);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(240, 38);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_open
            // 
            this.btn_open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_open.Location = new System.Drawing.Point(431, 30);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(240, 38);
            this.btn_open.TabIndex = 6;
            this.btn_open.Text = "Select Image";
            this.btn_open.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 560);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_bright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_hue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_zoom;
        private System.Windows.Forms.Button btn_center;
        private System.Windows.Forms.Button btn_autosize;
        private System.Windows.Forms.Button btn_stretch;
        private System.Windows.Forms.Button btn_normal;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_f5;
        private System.Windows.Forms.Button btn_f4;
        private System.Windows.Forms.Button btn_f3;
        private System.Windows.Forms.Button btn_f2;
        private System.Windows.Forms.Button btn_f1;
        private System.Windows.Forms.Button btn_rotate;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Button btn_resize;
        private System.Windows.Forms.TextBox txt_imgpath;
        private System.Windows.Forms.TextBox txt_hight;
        private System.Windows.Forms.TextBox txt_width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trk_hue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trk_contrast;
        private System.Windows.Forms.Label Brightnes;
        private System.Windows.Forms.TrackBar trk_bright;
    }
}

