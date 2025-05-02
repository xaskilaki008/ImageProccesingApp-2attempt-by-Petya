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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file_tsmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filters_tsmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.filters_binaris = new System.Windows.Forms.ToolStripMenuItem();
            this.filters_shadesofgrey = new System.Windows.Forms.ToolStripMenuItem();
            this.filters_negative = new System.Windows.Forms.ToolStripMenuItem();
            this.цветподробноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нормальныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.растянутыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЦентруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.весьЭкранF11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Rotate = new System.Windows.Forms.ToolStripMenuItem();
            this.построитьУбратьГистограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_zoom = new System.Windows.Forms.Button();
            this.btn_center = new System.Windows.Forms.Button();
            this.btn_stretch = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Color_Picker_Panel = new System.Windows.Forms.Panel();
            this.change_parammetrs_button = new System.Windows.Forms.Button();
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
            this.btn_reload = new System.Windows.Forms.Button();
            this.btn_resize = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            this.Color_Picker_Panel.SuspendLayout();
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
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 359);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(444, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 23);
            this.button2.TabIndex = 8;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(408, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 7;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.back_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(11, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 321);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 366);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(933, 190);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(696, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 359);
            this.panel4.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(696, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 359);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_tsmenu,
            this.filters_tsmenu,
            this.видToolStripMenuItem,
            this.изображениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(355, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(355, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // file_tsmenu
            // 
            this.file_tsmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.file_tsmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.openToolStripMenuItem,
            this.закрытьToolStripMenuItem,
            this.save_ToolStripMenuItem});
            this.file_tsmenu.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.file_tsmenu.ForeColor = System.Drawing.Color.Sienna;
            this.file_tsmenu.Name = "file_tsmenu";
            this.file_tsmenu.Size = new System.Drawing.Size(58, 24);
            this.file_tsmenu.Text = "Файл";
            this.file_tsmenu.Click += new System.EventHandler(this.file_ToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.copyToolStripMenuItem.ForeColor = System.Drawing.Color.Sienna;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pasteToolStripMenuItem.ForeColor = System.Drawing.Color.Sienna;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.Sienna;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.закрытьToolStripMenuItem.ForeColor = System.Drawing.Color.Sienna;
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // save_ToolStripMenuItem
            // 
            this.save_ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save_ToolStripMenuItem.ForeColor = System.Drawing.Color.Sienna;
            this.save_ToolStripMenuItem.Name = "save_ToolStripMenuItem";
            this.save_ToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.save_ToolStripMenuItem.Text = "Соханить [ctrl+S]";
            this.save_ToolStripMenuItem.Click += new System.EventHandler(this.СоханитьctrlSToolStripMenuItem_Click);
            // 
            // filters_tsmenu
            // 
            this.filters_tsmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.filters_tsmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filters_binaris,
            this.filters_shadesofgrey,
            this.filters_negative,
            this.цветподробноToolStripMenuItem});
            this.filters_tsmenu.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.filters_tsmenu.ForeColor = System.Drawing.Color.Sienna;
            this.filters_tsmenu.Name = "filters_tsmenu";
            this.filters_tsmenu.Size = new System.Drawing.Size(83, 24);
            this.filters_tsmenu.Text = "Фильтры";
            this.filters_tsmenu.Click += new System.EventHandler(this.filters_ToolStripMenuItem_Click);
            // 
            // filters_binaris
            // 
            this.filters_binaris.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.filters_binaris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.filters_binaris.Name = "filters_binaris";
            this.filters_binaris.Size = new System.Drawing.Size(204, 26);
            this.filters_binaris.Text = "Бинаризация";
            this.filters_binaris.Click += new System.EventHandler(this.filters_binaris_Click_1);
            // 
            // filters_shadesofgrey
            // 
            this.filters_shadesofgrey.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filters_shadesofgrey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.filters_shadesofgrey.Name = "filters_shadesofgrey";
            this.filters_shadesofgrey.Size = new System.Drawing.Size(204, 26);
            this.filters_shadesofgrey.Text = "Оттенки серого";
            this.filters_shadesofgrey.Click += new System.EventHandler(this.filters_shadesofgrey_Click);
            // 
            // filters_negative
            // 
            this.filters_negative.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.filters_negative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.filters_negative.Name = "filters_negative";
            this.filters_negative.Size = new System.Drawing.Size(204, 26);
            this.filters_negative.Text = "Негатив";
            this.filters_negative.Click += new System.EventHandler(this.filters_negative_Click);
            // 
            // цветподробноToolStripMenuItem
            // 
            this.цветподробноToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.цветподробноToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.цветподробноToolStripMenuItem.Name = "цветподробноToolStripMenuItem";
            this.цветподробноToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.цветподробноToolStripMenuItem.Text = "Цвет (подробно)";
            this.цветподробноToolStripMenuItem.Click += new System.EventHandler(this.цветподробноToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.нормальныйToolStripMenuItem,
            this.растянутыйToolStripMenuItem,
            this.поЦентруToolStripMenuItem,
            this.увеличитьToolStripMenuItem,
            this.весьЭкранF11ToolStripMenuItem});
            this.видToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.видToolStripMenuItem.ForeColor = System.Drawing.Color.Sienna;
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.видToolStripMenuItem.Text = "Вид";
            this.видToolStripMenuItem.Click += new System.EventHandler(this.view_ToolStripMenuItem_Click);
            // 
            // нормальныйToolStripMenuItem
            // 
            this.нормальныйToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.нормальныйToolStripMenuItem.ForeColor = System.Drawing.Color.Sienna;
            this.нормальныйToolStripMenuItem.Name = "нормальныйToolStripMenuItem";
            this.нормальныйToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.нормальныйToolStripMenuItem.Text = "Нормальный";
            // 
            // растянутыйToolStripMenuItem
            // 
            this.растянутыйToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.растянутыйToolStripMenuItem.ForeColor = System.Drawing.Color.Sienna;
            this.растянутыйToolStripMenuItem.Name = "растянутыйToolStripMenuItem";
            this.растянутыйToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.растянутыйToolStripMenuItem.Text = "Растянутый";
            // 
            // поЦентруToolStripMenuItem
            // 
            this.поЦентруToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.поЦентруToolStripMenuItem.ForeColor = System.Drawing.Color.Sienna;
            this.поЦентруToolStripMenuItem.Name = "поЦентруToolStripMenuItem";
            this.поЦентруToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.поЦентруToolStripMenuItem.Text = "По центру";
            this.поЦентруToolStripMenuItem.Click += new System.EventHandler(this.поЦентруToolStripMenuItem_Click);
            // 
            // увеличитьToolStripMenuItem
            // 
            this.увеличитьToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.увеличитьToolStripMenuItem.ForeColor = System.Drawing.Color.Sienna;
            this.увеличитьToolStripMenuItem.Name = "увеличитьToolStripMenuItem";
            this.увеличитьToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.увеличитьToolStripMenuItem.Text = "Увеличить";
            // 
            // весьЭкранF11ToolStripMenuItem
            // 
            this.весьЭкранF11ToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.весьЭкранF11ToolStripMenuItem.ForeColor = System.Drawing.Color.Sienna;
            this.весьЭкранF11ToolStripMenuItem.Name = "весьЭкранF11ToolStripMenuItem";
            this.весьЭкранF11ToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.весьЭкранF11ToolStripMenuItem.Text = "Весь экран [F11]";
            // 
            // изображениеToolStripMenuItem
            // 
            this.изображениеToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.изображениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Rotate,
            this.построитьУбратьГистограммыToolStripMenuItem});
            this.изображениеToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.изображениеToolStripMenuItem.ForeColor = System.Drawing.Color.Sienna;
            this.изображениеToolStripMenuItem.Name = "изображениеToolStripMenuItem";
            this.изображениеToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.изображениеToolStripMenuItem.Text = "Изображение";
            this.изображениеToolStripMenuItem.Click += new System.EventHandler(this.picture_ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_Rotate
            // 
            this.ToolStripMenuItem_Rotate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ToolStripMenuItem_Rotate.ForeColor = System.Drawing.Color.Sienna;
            this.ToolStripMenuItem_Rotate.Name = "ToolStripMenuItem_Rotate";
            this.ToolStripMenuItem_Rotate.Size = new System.Drawing.Size(372, 26);
            this.ToolStripMenuItem_Rotate.Text = "Повернуть 90°";
            // 
            // построитьУбратьГистограммыToolStripMenuItem
            // 
            this.построитьУбратьГистограммыToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.построитьУбратьГистограммыToolStripMenuItem.ForeColor = System.Drawing.Color.Sienna;
            this.построитьУбратьГистограммыToolStripMenuItem.Name = "построитьУбратьГистограммыToolStripMenuItem";
            this.построитьУбратьГистограммыToolStripMenuItem.Size = new System.Drawing.Size(372, 26);
            this.построитьУбратьГистограммыToolStripMenuItem.Text = "Построить гистограммы в новом окне";
            this.построитьУбратьГистограммыToolStripMenuItem.Click += new System.EventHandler(this.построитьУбратьГистограммыToolStripMenuItem_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btn_zoom);
            this.panel5.Controls.Add(this.btn_center);
            this.panel5.Controls.Add(this.btn_stretch);
            this.panel5.Location = new System.Drawing.Point(628, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(355, 359);
            this.panel5.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureBox2.Location = new System.Drawing.Point(80, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(127, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start Image";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_zoom
            // 
            this.btn_zoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_zoom.AutoSize = true;
            this.btn_zoom.FlatAppearance.BorderSize = 3;
            this.btn_zoom.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_zoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zoom.ForeColor = System.Drawing.Color.LightSalmon;
            this.btn_zoom.Location = new System.Drawing.Point(252, 82);
            this.btn_zoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_zoom.Name = "btn_zoom";
            this.btn_zoom.Size = new System.Drawing.Size(100, 39);
            this.btn_zoom.TabIndex = 5;
            this.btn_zoom.Text = "Zoom";
            this.btn_zoom.UseVisualStyleBackColor = true;
            this.btn_zoom.Click += new System.EventHandler(this.btn_zoom_Click);
            // 
            // btn_center
            // 
            this.btn_center.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_center.AutoSize = true;
            this.btn_center.FlatAppearance.BorderSize = 3;
            this.btn_center.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_center.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_center.ForeColor = System.Drawing.Color.LightSalmon;
            this.btn_center.Location = new System.Drawing.Point(252, 46);
            this.btn_center.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_center.Name = "btn_center";
            this.btn_center.Size = new System.Drawing.Size(100, 39);
            this.btn_center.TabIndex = 4;
            this.btn_center.Text = "Center";
            this.btn_center.UseVisualStyleBackColor = true;
            this.btn_center.Click += new System.EventHandler(this.btn_center_Click);
            // 
            // btn_stretch
            // 
            this.btn_stretch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_stretch.AutoSize = true;
            this.btn_stretch.FlatAppearance.BorderSize = 3;
            this.btn_stretch.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_stretch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stretch.ForeColor = System.Drawing.Color.LightSalmon;
            this.btn_stretch.Location = new System.Drawing.Point(252, 9);
            this.btn_stretch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_stretch.Name = "btn_stretch";
            this.btn_stretch.Size = new System.Drawing.Size(100, 39);
            this.btn_stretch.TabIndex = 2;
            this.btn_stretch.Text = "Stretch";
            this.btn_stretch.UseVisualStyleBackColor = true;
            this.btn_stretch.Click += new System.EventHandler(this.btn_stretch_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.AutoSize = true;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.Color_Picker_Panel);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.lbl_size);
            this.panel6.Controls.Add(this.txt_hight);
            this.panel6.Controls.Add(this.txt_width);
            this.panel6.Controls.Add(this.txt_imgpath);
            this.panel6.Controls.Add(this.btn_reload);
            this.panel6.Controls.Add(this.btn_resize);
            this.panel6.Controls.Add(this.btn_save);
            this.panel6.Location = new System.Drawing.Point(0, 355);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(983, 205);
            this.panel6.TabIndex = 2;
            // 
            // Color_Picker_Panel
            // 
            this.Color_Picker_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Color_Picker_Panel.Controls.Add(this.change_parammetrs_button);
            this.Color_Picker_Panel.Controls.Add(this.Brightnes);
            this.Color_Picker_Panel.Controls.Add(this.trk_bright);
            this.Color_Picker_Panel.Controls.Add(this.label6);
            this.Color_Picker_Panel.Controls.Add(this.trk_contrast);
            this.Color_Picker_Panel.Controls.Add(this.label4);
            this.Color_Picker_Panel.Controls.Add(this.trk_hue);
            this.Color_Picker_Panel.Location = new System.Drawing.Point(264, 94);
            this.Color_Picker_Panel.Name = "Color_Picker_Panel";
            this.Color_Picker_Panel.Size = new System.Drawing.Size(628, 99);
            this.Color_Picker_Panel.TabIndex = 27;
            // 
            // change_parammetrs_button
            // 
            this.change_parammetrs_button.AutoSize = true;
            this.change_parammetrs_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.change_parammetrs_button.BackColor = System.Drawing.Color.DimGray;
            this.change_parammetrs_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_parammetrs_button.Location = new System.Drawing.Point(41, 61);
            this.change_parammetrs_button.Name = "change_parammetrs_button";
            this.change_parammetrs_button.Size = new System.Drawing.Size(92, 28);
            this.change_parammetrs_button.TabIndex = 29;
            this.change_parammetrs_button.Text = "Применить";
            this.change_parammetrs_button.UseVisualStyleBackColor = false;
            this.change_parammetrs_button.Click += new System.EventHandler(this.change_parammetrs_button_Click);
            // 
            // Brightnes
            // 
            this.Brightnes.AllowDrop = true;
            this.Brightnes.AutoEllipsis = true;
            this.Brightnes.AutoSize = true;
            this.Brightnes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Brightnes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Brightnes.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brightnes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Brightnes.Location = new System.Drawing.Point(390, 5);
            this.Brightnes.Name = "Brightnes";
            this.Brightnes.Size = new System.Drawing.Size(63, 17);
            this.Brightnes.TabIndex = 28;
            this.Brightnes.Text = "Brightnes";
            // 
            // trk_bright
            // 
            this.trk_bright.AutoSize = false;
            this.trk_bright.Location = new System.Drawing.Point(459, 0);
            this.trk_bright.Margin = new System.Windows.Forms.Padding(1);
            this.trk_bright.Name = "trk_bright";
            this.trk_bright.Size = new System.Drawing.Size(140, 36);
            this.trk_bright.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(193, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Contrast";
            // 
            // trk_contrast
            // 
            this.trk_contrast.AutoSize = false;
            this.trk_contrast.Location = new System.Drawing.Point(255, 0);
            this.trk_contrast.Margin = new System.Windows.Forms.Padding(1);
            this.trk_contrast.Name = "trk_contrast";
            this.trk_contrast.Size = new System.Drawing.Size(140, 36);
            this.trk_contrast.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(11, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Hue";
            // 
            // trk_hue
            // 
            this.trk_hue.AutoSize = false;
            this.trk_hue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.trk_hue.Location = new System.Drawing.Point(47, 0);
            this.trk_hue.Margin = new System.Windows.Forms.Padding(1);
            this.trk_hue.Name = "trk_hue";
            this.trk_hue.Size = new System.Drawing.Size(140, 36);
            this.trk_hue.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(149, 75);
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
            this.label3.Location = new System.Drawing.Point(21, 75);
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
            this.txt_hight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_hight.Name = "txt_hight";
            this.txt_hight.Size = new System.Drawing.Size(100, 22);
            this.txt_hight.TabIndex = 18;
            this.txt_hight.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_width
            // 
            this.txt_width.Location = new System.Drawing.Point(4, 94);
            this.txt_width.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_width.Name = "txt_width";
            this.txt_width.Size = new System.Drawing.Size(100, 22);
            this.txt_width.TabIndex = 17;
            // 
            // txt_imgpath
            // 
            this.txt_imgpath.Location = new System.Drawing.Point(3, 30);
            this.txt_imgpath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_imgpath.Multiline = true;
            this.txt_imgpath.Name = "txt_imgpath";
            this.txt_imgpath.Size = new System.Drawing.Size(423, 38);
            this.txt_imgpath.TabIndex = 16;
            // 
            // btn_reload
            // 
            this.btn_reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_reload.FlatAppearance.BorderSize = 2;
            this.btn_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_reload.Location = new System.Drawing.Point(120, 164);
            this.btn_reload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(91, 38);
            this.btn_reload.TabIndex = 9;
            this.btn_reload.Text = "Reset";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_resize
            // 
            this.btn_resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_resize.FlatAppearance.BorderSize = 2;
            this.btn_resize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_resize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_resize.Location = new System.Drawing.Point(3, 164);
            this.btn_resize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_resize.Name = "btn_resize";
            this.btn_resize.Size = new System.Drawing.Size(91, 38);
            this.btn_resize.TabIndex = 8;
            this.btn_resize.Text = "Resize";
            this.btn_resize.UseVisualStyleBackColor = true;
            this.btn_resize.Click += new System.EventHandler(this.btn_resize_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_save.Location = new System.Drawing.Point(729, 30);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(240, 38);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Сохранить изображение";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 560);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.Color_Picker_Panel.ResumeLayout(false);
            this.Color_Picker_Panel.PerformLayout();
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
        private System.Windows.Forms.Button btn_zoom;
        private System.Windows.Forms.Button btn_center;
        private System.Windows.Forms.Button btn_stretch;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Button btn_resize;
        private System.Windows.Forms.TextBox txt_imgpath;
        private System.Windows.Forms.TextBox txt_hight;
        private System.Windows.Forms.TextBox txt_width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file_tsmenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filters_tsmenu;
        private System.Windows.Forms.ToolStripMenuItem filters_binaris;
        private System.Windows.Forms.ToolStripMenuItem filters_shadesofgrey;
        private System.Windows.Forms.ToolStripMenuItem filters_negative;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нормальныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem растянутыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЦентруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem весьЭкранF11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Rotate;
        private System.Windows.Forms.ToolStripMenuItem построитьУбратьГистограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem save_ToolStripMenuItem;
        private System.Windows.Forms.Panel Color_Picker_Panel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trk_contrast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trk_hue;
        private System.Windows.Forms.Label Brightnes;
        private System.Windows.Forms.TrackBar trk_bright;
        private System.Windows.Forms.Button change_parammetrs_button;
        private System.Windows.Forms.ToolStripMenuItem цветподробноToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

