using System.Windows.Forms;

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
            this.App_menuStrip = new System.Windows.Forms.MenuStrip();
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
            this.view_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.весьЭкранF11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.image_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Rotate = new System.Windows.Forms.ToolStripMenuItem();
            this.построитьУбратьГистограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highlighting_toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Kirsha_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplas_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методРобертсаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.App_menuStrip.SuspendLayout();
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
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.App_menuStrip);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 384);
            this.panel1.TabIndex = 1;
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
            this.pictureBox1.Size = new System.Drawing.Size(610, 336);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 366);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(933, 190);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(696, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 359);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(696, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 359);
            this.panel2.TabIndex = 0;
            // 
            // App_menuStrip
            // 
            this.App_menuStrip.BackColor = System.Drawing.Color.Gray;
            this.App_menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.App_menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.App_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_tsmenu,
            this.filters_tsmenu,
            this.view_ToolStripMenuItem,
            this.image_ToolStripMenuItem,
            this.highlighting_toolStripMenuItem2});
            this.App_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.App_menuStrip.MinimumSize = new System.Drawing.Size(150, 24);
            this.App_menuStrip.Name = "App_menuStrip";
            this.App_menuStrip.Padding = new System.Windows.Forms.Padding(0);
            this.App_menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.App_menuStrip.ShowItemToolTips = true;
            this.App_menuStrip.Size = new System.Drawing.Size(634, 24);
            this.App_menuStrip.TabIndex = 3;
            this.App_menuStrip.Text = "menuStrip1";
            this.App_menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
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
            this.openToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.Sienna;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
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
            // 
            // filters_binaris
            // 
            this.filters_binaris.BackColor = System.Drawing.SystemColors.Control;
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
            this.filters_negative.BackColor = System.Drawing.SystemColors.Control;
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
            // view_ToolStripMenuItem
            // 
            this.view_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.view_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.весьЭкранF11ToolStripMenuItem});
            this.view_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.view_ToolStripMenuItem.ForeColor = System.Drawing.Color.Sienna;
            this.view_ToolStripMenuItem.Name = "view_ToolStripMenuItem";
            this.view_ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.view_ToolStripMenuItem.Text = "Вид";
            // 
            // весьЭкранF11ToolStripMenuItem
            // 
            this.весьЭкранF11ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.весьЭкранF11ToolStripMenuItem.ForeColor = System.Drawing.Color.Sienna;
            this.весьЭкранF11ToolStripMenuItem.Name = "весьЭкранF11ToolStripMenuItem";
            this.весьЭкранF11ToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.весьЭкранF11ToolStripMenuItem.Text = "Весь экран [F11]";
            // 
            // image_ToolStripMenuItem
            // 
            this.image_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.image_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Rotate,
            this.построитьУбратьГистограммыToolStripMenuItem});
            this.image_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.image_ToolStripMenuItem.ForeColor = System.Drawing.Color.Sienna;
            this.image_ToolStripMenuItem.Name = "image_ToolStripMenuItem";
            this.image_ToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.image_ToolStripMenuItem.Text = "Изображение";
            // 
            // ToolStripMenuItem_Rotate
            // 
            this.ToolStripMenuItem_Rotate.BackColor = System.Drawing.SystemColors.Control;
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
            // highlighting_toolStripMenuItem2
            // 
            this.highlighting_toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.highlighting_toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Kirsha_toolStripMenuItem,
            this.laplas_ToolStripMenuItem,
            this.методРобертсаToolStripMenuItem});
            this.highlighting_toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.highlighting_toolStripMenuItem2.ForeColor = System.Drawing.Color.Sienna;
            this.highlighting_toolStripMenuItem2.Name = "highlighting_toolStripMenuItem2";
            this.highlighting_toolStripMenuItem2.Size = new System.Drawing.Size(105, 24);
            this.highlighting_toolStripMenuItem2.Text = "Выделение";
            // 
            // Kirsha_toolStripMenuItem
            // 
            this.Kirsha_toolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.Kirsha_toolStripMenuItem.ForeColor = System.Drawing.Color.Sienna;
            this.Kirsha_toolStripMenuItem.Name = "Kirsha_toolStripMenuItem";
            this.Kirsha_toolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.Kirsha_toolStripMenuItem.Text = "Выделение Кирша";
            this.Kirsha_toolStripMenuItem.Click += new System.EventHandler(this.kirsha_toolStripMenuItem_Click);
            // 
            // laplas_ToolStripMenuItem
            // 
            this.laplas_ToolStripMenuItem.ForeColor = System.Drawing.Color.Sienna;
            this.laplas_ToolStripMenuItem.Name = "laplas_ToolStripMenuItem";
            this.laplas_ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.laplas_ToolStripMenuItem.Text = "Метод Лапласа ";
            this.laplas_ToolStripMenuItem.Click += new System.EventHandler(this.laplaceToolStripMenuItem_Click);
            // 
            // методРобертсаToolStripMenuItem
            // 
            this.методРобертсаToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.методРобертсаToolStripMenuItem.ForeColor = System.Drawing.Color.Sienna;
            this.методРобертсаToolStripMenuItem.Name = "методРобертсаToolStripMenuItem";
            this.методРобертсаToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.методРобертсаToolStripMenuItem.Text = "Метод Робертса";
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
            this.panel5.Size = new System.Drawing.Size(355, 384);
            this.panel5.TabIndex = 0;
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
            this.label1.TabIndex = 3;
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
            this.btn_zoom.TabIndex = 0;
            this.btn_zoom.Text = "Zoom";
            this.btn_zoom.UseVisualStyleBackColor = true;
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
            this.btn_center.TabIndex = 1;
            this.btn_center.Text = "Center";
            this.btn_center.UseVisualStyleBackColor = true;
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
            this.panel6.Location = new System.Drawing.Point(0, 380);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(983, 205);
            this.panel6.TabIndex = 2;
            // 
            // Color_Picker_Panel
            // 
            this.Color_Picker_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Color_Picker_Panel.Controls.Add(this.label14);
            this.Color_Picker_Panel.Controls.Add(this.label13);
            this.Color_Picker_Panel.Controls.Add(this.label12);
            this.Color_Picker_Panel.Controls.Add(this.label10);
            this.Color_Picker_Panel.Controls.Add(this.label11);
            this.Color_Picker_Panel.Controls.Add(this.label8);
            this.Color_Picker_Panel.Controls.Add(this.label9);
            this.Color_Picker_Panel.Controls.Add(this.label7);
            this.Color_Picker_Panel.Controls.Add(this.label2);
            this.Color_Picker_Panel.Controls.Add(this.change_parammetrs_button);
            this.Color_Picker_Panel.Controls.Add(this.Brightnes);
            this.Color_Picker_Panel.Controls.Add(this.trk_bright);
            this.Color_Picker_Panel.Controls.Add(this.label6);
            this.Color_Picker_Panel.Controls.Add(this.trk_contrast);
            this.Color_Picker_Panel.Controls.Add(this.label4);
            this.Color_Picker_Panel.Controls.Add(this.trk_hue);
            this.Color_Picker_Panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Color_Picker_Panel.Location = new System.Drawing.Point(266, 81);
            this.Color_Picker_Panel.Name = "Color_Picker_Panel";
            this.Color_Picker_Panel.Size = new System.Drawing.Size(628, 99);
            this.Color_Picker_Panel.TabIndex = 0;
            this.Color_Picker_Panel.UseWaitCursor = true;
            this.Color_Picker_Panel.Visible = false;
            this.Color_Picker_Panel.Click += new System.EventHandler(this.change_parammetrs_button_Click);
            // 
            // change_parammetrs_button
            // 
            this.change_parammetrs_button.Location = new System.Drawing.Point(145, 61);
            this.change_parammetrs_button.Name = "change_parammetrs_button";
            this.change_parammetrs_button.Size = new System.Drawing.Size(109, 28);
            this.change_parammetrs_button.TabIndex = 0;
            this.change_parammetrs_button.Text = "Применить";
            this.change_parammetrs_button.UseVisualStyleBackColor = true;
            this.change_parammetrs_button.UseWaitCursor = true;
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
            this.Brightnes.TabIndex = 3;
            this.Brightnes.Text = "Brightnes";
            this.Brightnes.UseWaitCursor = true;
            // 
            // trk_bright
            // 
            this.trk_bright.AutoSize = false;
            this.trk_bright.Location = new System.Drawing.Point(459, 0);
            this.trk_bright.Margin = new System.Windows.Forms.Padding(1);
            this.trk_bright.Name = "trk_bright";
            this.trk_bright.Size = new System.Drawing.Size(140, 36);
            this.trk_bright.TabIndex = 4;
            this.trk_bright.UseWaitCursor = true;
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
            this.label6.TabIndex = 5;
            this.label6.Text = "Contrast";
            this.label6.UseWaitCursor = true;
            // 
            // trk_contrast
            // 
            this.trk_contrast.AutoSize = false;
            this.trk_contrast.Location = new System.Drawing.Point(255, 0);
            this.trk_contrast.Margin = new System.Windows.Forms.Padding(1);
            this.trk_contrast.Name = "trk_contrast";
            this.trk_contrast.Size = new System.Drawing.Size(140, 36);
            this.trk_contrast.TabIndex = 2;
            this.trk_contrast.UseWaitCursor = true;
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
            this.label4.TabIndex = 0;
            this.label4.Text = "Hue";
            this.label4.UseWaitCursor = true;
            // 
            // trk_hue
            // 
            this.trk_hue.AutoSize = false;
            this.trk_hue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trk_hue.Location = new System.Drawing.Point(47, 0);
            this.trk_hue.Margin = new System.Windows.Forms.Padding(1);
            this.trk_hue.Name = "trk_hue";
            this.trk_hue.Size = new System.Drawing.Size(140, 36);
            this.trk_hue.TabIndex = 1;
            this.trk_hue.UseWaitCursor = true;
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
            this.label5.TabIndex = 7;
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
            this.label3.TabIndex = 8;
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
            this.lbl_size.TabIndex = 1;
            this.lbl_size.Text = "Image Size";
            // 
            // txt_hight
            // 
            this.txt_hight.Location = new System.Drawing.Point(120, 94);
            this.txt_hight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_hight.Name = "txt_hight";
            this.txt_hight.Size = new System.Drawing.Size(100, 22);
            this.txt_hight.TabIndex = 6;
            this.txt_hight.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_width
            // 
            this.txt_width.Location = new System.Drawing.Point(4, 94);
            this.txt_width.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_width.Name = "txt_width";
            this.txt_width.Size = new System.Drawing.Size(100, 22);
            this.txt_width.TabIndex = 5;
            // 
            // txt_imgpath
            // 
            this.txt_imgpath.Location = new System.Drawing.Point(3, 30);
            this.txt_imgpath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_imgpath.Multiline = true;
            this.txt_imgpath.Name = "txt_imgpath";
            this.txt_imgpath.Size = new System.Drawing.Size(423, 38);
            this.txt_imgpath.TabIndex = 0;
            // 
            // btn_reload
            // 
            this.btn_reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_reload.FlatAppearance.BorderSize = 2;
            this.btn_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_reload.Location = new System.Drawing.Point(129, 142);
            this.btn_reload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(91, 38);
            this.btn_reload.TabIndex = 3;
            this.btn_reload.Text = "Reset";
            this.btn_reload.UseVisualStyleBackColor = true;
            // 
            // btn_resize
            // 
            this.btn_resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_resize.FlatAppearance.BorderSize = 2;
            this.btn_resize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_resize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_resize.Location = new System.Drawing.Point(1, 140);
            this.btn_resize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_resize.Name = "btn_resize";
            this.btn_resize.Size = new System.Drawing.Size(91, 38);
            this.btn_resize.TabIndex = 2;
            this.btn_resize.Text = "Resize";
            this.btn_resize.UseVisualStyleBackColor = true;
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
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Сохранить изображение";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "-180";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(159, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "180";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(364, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(252, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "-100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(569, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "100";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(457, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "-100";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(111, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(318, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(523, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 15);
            this.label14.TabIndex = 14;
            this.label14.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 560);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.MainMenuStrip = this.App_menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.App_menuStrip.ResumeLayout(false);
            this.App_menuStrip.PerformLayout();
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
        private void InitializeFiltersMenu()
        {
            // Создаем подменю для шумов
            ToolStripMenuItem noiseMenu = new ToolStripMenuItem("Add Noise");

            // Добавляем варианты шума "соль-перец"
            ToolStripMenuItem saltPepperMenu = new ToolStripMenuItem("Salt and Pepper");
            saltPepperMenu.DropDownItems.Add("0.1", null, (s, e) => AddSaltAndPepperNoise(0.1));
            saltPepperMenu.DropDownItems.Add("0.2", null, (s, e) => AddSaltAndPepperNoise(0.2));
            saltPepperMenu.DropDownItems.Add("0.3", null, (s, e) => AddSaltAndPepperNoise(0.3));
            saltPepperMenu.DropDownItems.Add("0.4", null, (s, e) => AddSaltAndPepperNoise(0.4));

            noiseMenu.DropDownItems.Add(saltPepperMenu);
            filters_tsmenu.DropDownItems.Add(noiseMenu);

            // Создаем подменю для восстанавливающих фильтров
            ToolStripMenuItem restoreMenu = new ToolStripMenuItem("Restoration Filters");

            // Добавляем варианты сглаживающего фильтра
            ToolStripMenuItem smoothingMenu = new ToolStripMenuItem("Smoothing Filter");
            smoothingMenu.DropDownItems.Add("3x3", null, (s, e) => ApplySmoothingFilter(3));
            smoothingMenu.DropDownItems.Add("5x5", null, (s, e) => ApplySmoothingFilter(5));
            smoothingMenu.DropDownItems.Add("7x7", null, (s, e) => ApplySmoothingFilter(7));

            // Добавляем варианты медианного фильтра
            ToolStripMenuItem medianMenu = new ToolStripMenuItem("Median Filter");
            medianMenu.DropDownItems.Add("3x3", null, (s, e) => ApplyMedianFilter(3));
            medianMenu.DropDownItems.Add("5x5", null, (s, e) => ApplyMedianFilter(5));
            medianMenu.DropDownItems.Add("7x7", null, (s, e) => ApplyMedianFilter(7));

            restoreMenu.DropDownItems.Add(smoothingMenu);
            restoreMenu.DropDownItems.Add(medianMenu);
            filters_tsmenu.DropDownItems.Add(restoreMenu);

            // Добавляем кнопку для сброса к оригинальному изображению
            filters_tsmenu.DropDownItems.Add("Reset", null, (s, e) => ResetImage());
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
        private System.Windows.Forms.MenuStrip App_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem file_tsmenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filters_tsmenu;
        private System.Windows.Forms.ToolStripMenuItem filters_binaris;
        private System.Windows.Forms.ToolStripMenuItem filters_shadesofgrey;
        private System.Windows.Forms.ToolStripMenuItem filters_negative;
        private System.Windows.Forms.ToolStripMenuItem view_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem весьЭкранF11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem image_ToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem цветподробноToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button change_parammetrs_button;
        private System.Windows.Forms.ToolStripMenuItem highlighting_toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Kirsha_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplas_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методРобертсаToolStripMenuItem;
        private Label label7;
        private Label label2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label label13;
    }
}

