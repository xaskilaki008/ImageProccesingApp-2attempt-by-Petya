using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageProccesingApp_2attempt

{
    public partial class histograms : Form
    {
        private readonly Bitmap processedImage;
        private const int HistWidth = 256;
        private const int HistHeight = 100;
        public histograms(Bitmap img)
        {
            if (img == null)
                throw new ArgumentNullException(nameof(img));

            InitializeComponent();
            this.processedImage = new Bitmap(img); ;

            // Автоматически строим гистограмму при открытии формы
            this.Shown += (s, e) => BuildHistograms();
        }
        // Единственный конструктор, требующий изображение
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                processedImage?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void BuildHistograms()
        {
            try
            {
                // 1. Создаем битмапы для гистограмм
                Bitmap brightnessHist = new Bitmap(HistWidth, HistHeight);
                Bitmap redHist = new Bitmap(HistWidth, HistHeight);
                Bitmap greenHist = new Bitmap(HistWidth, HistHeight);
                Bitmap blueHist = new Bitmap(HistWidth, HistHeight);

                // 2. Массивы для подсчета частот
                int[] brightnessValues = new int[256];
                int[] redValues = new int[256];
                int[] greenValues = new int[256];
                int[] blueValues = new int[256];

                // 3. Сбор статистики
                for (int x = 0; x < processedImage.Width; x++)
                {
                    for (int y = 0; y < processedImage.Height; y++)
                    {
                        Color pixel = processedImage.GetPixel(x, y);

                        int brightness = Clamp((int)(0.34 * pixel.R + 0.5 * pixel.G + 0.16 * pixel.B), 0, 255);
                        brightnessValues[brightness]++;
                        redValues[pixel.R]++;
                        greenValues[pixel.G]++;
                        blueValues[pixel.B]++;
                    }
                }

                // 4. Нормализация и отрисовка
                DrawHistogram(brightnessHist, brightnessValues, Color.Black);
                DrawHistogram(redHist, redValues, Color.Red);
                DrawHistogram(greenHist, greenValues, Color.Green);
                DrawHistogram(blueHist, blueValues, Color.Blue);

                // 5. Отображение в соответствующих PictureBox
                histogramBox_bright.Image = brightnessHist;
                histogramBox_red.Image = redHist;
                histogramBox_green.Image = greenHist;
                histogramBox_blue.Image = blueHist;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка построения гистограммы: {ex.Message}",
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawHistogram(Bitmap bitmap, int[] values, Color color)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
                int maxValue = GetMaxValue(values);

                for (int i = 0; i < values.Length; i++)
                {
                    int height = (int)((values[i] / (float)maxValue) * HistHeight);
                    g.DrawLine(new Pen(color), i, HistHeight, i, HistHeight - height);
                }
            }
        }


       

        private int GetMaxValue(int[] values)
        {
            int max = 0;
            foreach (int value in values)
            {
                if (value > max) max = value;
            }
            return max == 0 ? 1 : max; // Чтобы избежать деления на 0
        }

        private static int Clamp(int value, int min, int max)
        {
            return value < min ? min : value > max ? max : value;
        }

        private void histograms_rebuild_Click(object sender, EventArgs e)
        {
            if (processedImage == null)
            {
                MessageBox.Show("Сначала обработайте изображение!");
                return;
            }

            // Передаем processedImage в конструктор
            var histForm = new histograms(processedImage);
            histForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}