namespace ImageProccesingApp_2attempt
{
    partial class histograms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.barchartpanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.histogramBox_color = new System.Windows.Forms.PictureBox();
            this.histogramBox_bright = new System.Windows.Forms.PictureBox();
            this.histograms_rebuild = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.barchartpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox_bright)).BeginInit();
            this.SuspendLayout();
            // 
            // barchartpanel
            // 
            this.barchartpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.barchartpanel.AutoSize = true;
            this.barchartpanel.BackColor = System.Drawing.Color.Gray;
            this.barchartpanel.Controls.Add(this.label8);
            this.barchartpanel.Controls.Add(this.label7);
            this.barchartpanel.Controls.Add(this.label2);
            this.barchartpanel.Controls.Add(this.histogramBox_color);
            this.barchartpanel.Controls.Add(this.histogramBox_bright);
            this.barchartpanel.Location = new System.Drawing.Point(12, 6);
            this.barchartpanel.Name = "barchartpanel";
            this.barchartpanel.Size = new System.Drawing.Size(461, 465);
            this.barchartpanel.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(126, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(314, 41);
            this.label8.TabIndex = 18;
            this.label8.Text = "Панель гистограмм";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 257);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Гистограмма цвета";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Гистограмма яркости";
            // 
            // histogramBox_color
            // 
            this.histogramBox_color.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.histogramBox_color.BackColor = System.Drawing.Color.White;
            this.histogramBox_color.Location = new System.Drawing.Point(20, 273);
            this.histogramBox_color.Name = "histogramBox_color";
            this.histogramBox_color.Size = new System.Drawing.Size(400, 175);
            this.histogramBox_color.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.histogramBox_color.TabIndex = 15;
            this.histogramBox_color.TabStop = false;
            // 
            // histogramBox_bright
            // 
            this.histogramBox_bright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.histogramBox_bright.BackColor = System.Drawing.Color.White;
            this.histogramBox_bright.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.histogramBox_bright.Location = new System.Drawing.Point(20, 82);
            this.histogramBox_bright.Name = "histogramBox_bright";
            this.histogramBox_bright.Size = new System.Drawing.Size(400, 175);
            this.histogramBox_bright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.histogramBox_bright.TabIndex = 14;
            this.histogramBox_bright.TabStop = false;
            // 
            // histograms_rebuild
            // 
            this.histograms_rebuild.AllowDrop = true;
            this.histograms_rebuild.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.histograms_rebuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.histograms_rebuild.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.histograms_rebuild.FlatAppearance.BorderSize = 3;
            this.histograms_rebuild.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.histograms_rebuild.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.histograms_rebuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.histograms_rebuild.Location = new System.Drawing.Point(499, 45);
            this.histograms_rebuild.Name = "histograms_rebuild";
            this.histograms_rebuild.Size = new System.Drawing.Size(74, 58);
            this.histograms_rebuild.TabIndex = 10;
            this.histograms_rebuild.Text = "в новом окне";
            this.histograms_rebuild.UseVisualStyleBackColor = false;
            this.histograms_rebuild.Click += new System.EventHandler(this.histograms_rebuild_Click);
            // 
            // histograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 476);
            this.Controls.Add(this.histograms_rebuild);
            this.Controls.Add(this.barchartpanel);
            this.Name = "histograms";
            this.Text = "histograms";
            this.barchartpanel.ResumeLayout(false);
            this.barchartpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox_color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox_bright)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel barchartpanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox histogramBox_color;
        private System.Windows.Forms.PictureBox histogramBox_bright;
        private System.Windows.Forms.Button histograms_rebuild;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}