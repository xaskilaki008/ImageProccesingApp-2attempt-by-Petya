using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProccesingApp_2attempt
{
    public partial class FormResult : Form
    {
        public FormResult(Image resultImage)
        {
            InitializeComponent();
            this.Text = "Результат фильтра Кирша";

            // Настройка PictureBox для отображения результата
            PictureBox pictureBoxResult = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = resultImage
            };

            this.Controls.Add(pictureBoxResult);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
