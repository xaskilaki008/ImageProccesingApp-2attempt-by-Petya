using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ImageProccesingApp_2attempt
{
    public partial class histograms : Form
    {
        Graphics graphColored, graphMainImage;
        private Bitmap processedImage;

        // Конструктор, принимающий Bitmap
        public histograms(Bitmap img)
        {
            InitializeComponent();
            this.processedImage = img;
            // Здесь можно сразу использовать image для построения гистограммы
        }

        // Выбранный цвет
        Color currentColor;
        // Выбранный регион
        Point currentRegion;
        bool isPaint = false;

        public histograms()
        {
            InitializeComponent();

        }


        private void histograms_rebuild_Click(object sender, EventArgs e)
        {
            // Построить гистограмму
            isPaint = false;
            int[] brightly = new int[processedImage.Width * processedImage.Height];
            Bitmap bipmapGist = new Bitmap(256, processedImage.Width * processedImage.Height);
            Graphics graphBrightly = Graphics.FromImage(bipmapGist);
            histogramBox_bright.Image = bipmapGist;
            Dictionary<int, List<int>> dictRed = new Dictionary<int, List<int>>();
            Dictionary<int, List<int>> dictGreen = new Dictionary<int, List<int>>();
            Dictionary<int, List<int>> dictBlue = new Dictionary<int, List<int>>();

            Pen pen = new Pen(Color.Black);
            int x = 0, y = 0;
            for (int i = 0; i < processedImage.Width; i++)
            {
                List<int> red = new List<int>();
                List<int> green = new List<int>();
                List<int> blue = new List<int>();
                for (int j = 0; j < processedImage.Height; j++)
                {
                    int r = Convert.ToInt32(processedImage.GetPixel(i, j).R);
                    int g = Convert.ToInt32(processedImage.GetPixel(i, j).G);
                    int b = Convert.ToInt32(processedImage.GetPixel(i, j).B);
                    red.Add(r);
                    green.Add(g);
                    blue.Add(b);

                    brightly[y] = (int)(0.34 * r + 0.5 * g + 0.16 * b); // получили яркость
                    graphBrightly.DrawLine(pen, new Point(x, 0), new Point(x, brightly[y]));
                    y++;

                }
                dictRed.Add(x, red);
                dictBlue.Add(x, blue);
                dictGreen.Add(x, green);
                x++;
            }
            Bitmap gist1 = new Bitmap(256, processedImage.Width * processedImage.Height);
            graphColored = Graphics.FromImage(gist1);
            histogramBox_color.Image = gist1;
            Drawing(dictRed, new Pen(Color.Red));
            Drawing(dictGreen, new Pen(Color.Green));
            Drawing(dictBlue, new Pen(Color.Blue));
        }
        private void Drawing(Dictionary<int, List<int>> colors, Pen pen)
        {
            for (int x = 0; x < colors.Keys.Count; x++)
            {
                for (int y = 0; y < colors[x].Count; y++)
                {
                    int color = colors[x][y];
                    graphColored.DrawLine(pen, new Point(x, 0), new Point(x, color));
                }
            }
        }
    }
}
