using System.Windows.Forms;

namespace ImageProccesingApp_2attempt
{
    partial class Histograms
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.histogramBox_blue = new System.Windows.Forms.PictureBox();
            this.histogramBox_green = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.histogramBox_red = new System.Windows.Forms.PictureBox();
            this.histogramBox_bright = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.barchartpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox_bright)).BeginInit();
            this.SuspendLayout();
            // 
            // barchartpanel
            // 
            this.barchartpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.barchartpanel.AutoSize = true;
            this.barchartpanel.BackColor = System.Drawing.Color.Gray;
            this.barchartpanel.Controls.Add(this.label3);
            this.barchartpanel.Controls.Add(this.label1);
            this.barchartpanel.Controls.Add(this.histogramBox_blue);
            this.barchartpanel.Controls.Add(this.histogramBox_green);
            this.barchartpanel.Controls.Add(this.label8);
            this.barchartpanel.Controls.Add(this.label7);
            this.barchartpanel.Controls.Add(this.label2);
            this.barchartpanel.Controls.Add(this.histogramBox_red);
            this.barchartpanel.Controls.Add(this.histogramBox_bright);
            this.barchartpanel.Location = new System.Drawing.Point(9, 5);
            this.barchartpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barchartpanel.Name = "barchartpanel";
            this.barchartpanel.Size = new System.Drawing.Size(739, 378);
            this.barchartpanel.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 209);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(38, 0, 38, 0);
            this.label3.Size = new System.Drawing.Size(236, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "🔴 Гистограмма синего цвета";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 51);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(38, 0, 38, 0);
            this.label1.Size = new System.Drawing.Size(248, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "🔴 Гистограмма зеленого цвета";
            // 
            // histogramBox_blue
            // 
            this.histogramBox_blue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.histogramBox_blue.BackColor = System.Drawing.Color.White;
            this.histogramBox_blue.Location = new System.Drawing.Point(392, 222);
            this.histogramBox_blue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.histogramBox_blue.Name = "histogramBox_blue";
            this.histogramBox_blue.Size = new System.Drawing.Size(306, 142);
            this.histogramBox_blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.histogramBox_blue.TabIndex = 24;
            this.histogramBox_blue.TabStop = false;
            // 
            // histogramBox_green
            // 
            this.histogramBox_green.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.histogramBox_green.BackColor = System.Drawing.Color.White;
            this.histogramBox_green.Location = new System.Drawing.Point(392, 67);
            this.histogramBox_green.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.histogramBox_green.Name = "histogramBox_green";
            this.histogramBox_green.Size = new System.Drawing.Size(303, 142);
            this.histogramBox_green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.histogramBox_green.TabIndex = 23;
            this.histogramBox_green.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(94, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(259, 34);
            this.label8.TabIndex = 18;
            this.label8.Text = "Панель гистограмм";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 209);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(38, 0, 38, 0);
            this.label7.Size = new System.Drawing.Size(248, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "🔴 Гистограмма красного цвета";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 51);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(38, 0, 38, 0);
            this.label2.Size = new System.Drawing.Size(210, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "🌈 Гистограмма яркости";
            // 
            // histogramBox_red
            // 
            this.histogramBox_red.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.histogramBox_red.BackColor = System.Drawing.Color.White;
            this.histogramBox_red.Location = new System.Drawing.Point(15, 222);
            this.histogramBox_red.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.histogramBox_red.Name = "histogramBox_red";
            this.histogramBox_red.Size = new System.Drawing.Size(321, 142);
            this.histogramBox_red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.histogramBox_red.TabIndex = 15;
            this.histogramBox_red.TabStop = false;
            // 
            // histogramBox_bright
            // 
            this.histogramBox_bright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.histogramBox_bright.BackColor = System.Drawing.Color.White;
            this.histogramBox_bright.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.histogramBox_bright.Location = new System.Drawing.Point(15, 67);
            this.histogramBox_bright.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.histogramBox_bright.Name = "histogramBox_bright";
            this.histogramBox_bright.Size = new System.Drawing.Size(322, 143);
            this.histogramBox_bright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.histogramBox_bright.TabIndex = 14;
            this.histogramBox_bright.TabStop = false;
            // 
            // Histograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 387);
            this.Controls.Add(this.barchartpanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Histograms";
            this.Text = "histograms";
            this.barchartpanel.ResumeLayout(false);
            this.barchartpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox_bright)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel barchartpanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox histogramBox_red;
        private System.Windows.Forms.PictureBox histogramBox_bright;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox histogramBox_blue;
        private System.Windows.Forms.PictureBox histogramBox_green;
    }
}