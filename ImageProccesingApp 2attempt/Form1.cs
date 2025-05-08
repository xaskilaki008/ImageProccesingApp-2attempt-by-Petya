using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProccesingApp_2attempt
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage; // Оригинальное изображение
        private Bitmap laterImage; //Для действия назад
        private Bitmap processedImage; // Обработанное изображение
        private Stack<Bitmap> undoHistory = new Stack<Bitmap>();  // История для отката
        private Stack<Bitmap> redoHistory = new Stack<Bitmap>();  // История для повтора (опционально)
        public Form1()
        {
            InitializeComponent();



            Color_Picker_Panel.Visible = false; // Скрываем панель при запуске
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyOrangeColorTable());
            openToolStripMenuItem.Click += delegate
            {
                openToolStripMenuItem.BackColor = Color.Red;
            };
            // Настройка начальных значений
            trk_hue.Minimum = -180;
            trk_hue.Maximum = 180;
            trk_hue.Value = 0;

            trk_contrast.Minimum = -100;
            trk_contrast.Maximum = 100;
            trk_contrast.Value = 0;

            trk_bright.Minimum = -100;
            trk_bright.Maximum = 100;
            trk_bright.Value = 0;

            // Подписка на события
            нормальныйToolStripMenuItem.Click += нормальныйToolStripMenuItem_Click;
            btn_stretch.Click += Btn_stretch_Click;
            btn_center.Click += Btn_center_Click;
            btn_zoom.Click += Btn_zoom_Click;
            btn_resize.Click += Btn_resize_Click;
            btn_reload.Click += Btn_reload_Click;
            filters_binaris.Click += filters_binaris_Click_1;
            ToolStripMenuItem_Rotate.Click += ToolStripMenuItem_Rotate_Click;
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // Добавьте в конструктор Form1() после инициализации других элементов:
            this.KeyPreview = true; // Для обработки горячих клавиш
            this.KeyDown += Form1_KeyDown;

            trk_hue.Scroll += TrackBar_Scroll;
            trk_contrast.Scroll += TrackBar_Scroll;
            trk_bright.Scroll += TrackBar_Scroll;

        }
        histograms f2;
        private void построитьУбратьГистограммыToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        originalImage = new Bitmap(openFileDialog.FileName);
                        processedImage = new Bitmap(originalImage);

                        pictureBox1.Image = originalImage;
                        pictureBox2.Image = originalImage;

                        txt_imgpath.Text = openFileDialog.FileName;
                        lbl_size.Text = $"{originalImage.Width} x {originalImage.Height}";
                        txt_width.Text = originalImage.Width.ToString();
                        txt_hight.Text = originalImage.Height.ToString();

                        // Установка режимов отображения
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}");
                    }
                }
            }
        }

        // Режимы отображения изображения
        private void Btn_normal_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
        private void нормальныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            undoHistory.Push(new Bitmap(processedImage));  // Сохраняем текущее состояние
                                                           // Очищаем redoHistory при новом действии
            redoHistory.Clear();
        }
        private void Btn_stretch_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Btn_autosize_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void Btn_center_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void Btn_zoom_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // Изменение размера изображения
        private void Btn_resize_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;

            try
            {
                int width = int.Parse(txt_width.Text);
                int height = int.Parse(txt_hight.Text);

                processedImage = new Bitmap(originalImage, width, height);
                pictureBox1.Image = processedImage;
                lbl_size.Text = $"{width} x {height}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error resizing image: {ex.Message}");
            }
            undoHistory.Push(new Bitmap(processedImage));  // Сохраняем текущее состояние
                                                           // Очищаем redoHistory при новом действии
            redoHistory.Clear();
        }

        // Сброс изменений
        private void Btn_reload_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                undoHistory.Push(new Bitmap(processedImage)); // Сохраняем текущее состояние

                processedImage?.Dispose();
                processedImage = new Bitmap(originalImage);
                pictureBox1.Image = processedImage;

                // Сброс трекбаров
                trk_hue.Value = 0;
                trk_contrast.Value = 0;
                trk_bright.Value = 0;
            }
        }
        // Метод для кнопки "Назад"
        private void back_button_Click(object sender, EventArgs e)
        {
            if (undoHistory.Count > 0)
            {
                // Сохраняем текущее состояние в redoHistory (если нужно)
                redoHistory.Push(new Bitmap(processedImage));

                // Восстанавливаем предыдущее состояние
                processedImage = new Bitmap(undoHistory.Pop());
                pictureBox1.Image = new Bitmap(processedImage);
            }
            else
            {
                MessageBox.Show("Нет предыдущих состояний для отката.");
            }
        }

        // Метод для сравнения двух изображений (по пикселям)
        private bool AreImagesEqual(Bitmap img1, Bitmap img2)
        {
            if (img1 == null || img2 == null)
                return false;
            if (img1.Width != img2.Width || img1.Height != img2.Height)
                return false;

            for (int y = 0; y < img1.Height; y++)
            {
                for (int x = 0; x < img1.Width; x++)
                {
                    if (img1.GetPixel(x, y) != img2.GetPixel(x, y))
                        return false;
                }
            }
            return true;
        }

        // Где-то в коде (например, после применения фильтра) сохраняем предыдущее состояние:
        private void ApplyFilter()
        {
            // Перед изменением processedImage сохраняем его в laterImage
            laterImage = new Bitmap(processedImage);

            // Применяем изменения к processedImage...
            // Например: processedImage = ApplyGrayscale(processedImage);
        }
        // Поворот изображения
        private void Btn_rotate_Click(object sender, EventArgs e)
        {
            if (processedImage == null) return;

            processedImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = processedImage;
            undoHistory.Push(new Bitmap(processedImage));  // Сохраняем текущее состояние
                                                           // Очищаем redoHistory при новом действии
            redoHistory.Clear();
        }
        private void ToolStripMenuItem_Rotate_Click(object sender, EventArgs e)
        {
            if (processedImage == null) return;

            processedImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = processedImage;
            undoHistory.Push(new Bitmap(processedImage));  // Сохраняем текущее состояние
                                                           // Очищаем redoHistory при новом действии
            redoHistory.Clear();
        }
        

        // Метод для настройки изображения (цвет, контраст, яркость)
        private Bitmap AdjustImage(Bitmap image, float hue, float contrast, float brightness)
        {
            Bitmap adjustedImage = new Bitmap(image.Width, image.Height);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);

                    // Применение hue (оттенка)
                    float h = pixel.GetHue() + hue * 360;
                    if (h > 360) h -= 360;
                    if (h < 0) h += 360;

                    float s = pixel.GetSaturation();
                    float l = pixel.GetBrightness();

                    // Применение яркости и контраста
                    l = l * brightness;
                    l = (l - 0.5f) * contrast + 0.5f;

                    // Ограничение значений
                    l = Math.Max(0, Math.Min(1, l));
                    s = Math.Max(0, Math.Min(1, s));

                    Color newPixel = ColorFromAhsb(pixel.A, h, s, l);
                    adjustedImage.SetPixel(x, y, newPixel);
                }
            }

            return adjustedImage;
        }

        // Преобразование из HSB в Color
        private Color ColorFromAhsb(int alpha, float hue, float saturation, float brightness)
        {
            if (saturation == 0)
            {
                return Color.FromArgb(alpha,
                    Convert.ToInt32(brightness * 255),
                    Convert.ToInt32(brightness * 255),
                    Convert.ToInt32(brightness * 255));
            }

            float fMax, fMid, fMin;
            int iSextant, iMax, iMid, iMin;

            if (brightness > 0.5)
            {
                fMax = brightness - (brightness * saturation) + saturation;
                fMin = brightness + (brightness * saturation) - saturation;
            }
            else
            {
                fMax = brightness + (brightness * saturation);
                fMin = brightness - (brightness * saturation);
            }

            iSextant = (int)Math.Floor(hue / 60f);
            if (hue >= 300f)
            {
                hue -= 360f;
            }
            hue /= 60f;
            hue -= 2f * (float)Math.Floor(((iSextant + 1f) % 6f) / 2f);
            if (iSextant % 2 == 0)
            {
                fMid = hue * (fMax - fMin) + fMin;
            }
            else
            {
                fMid = fMin - hue * (fMax - fMin);
            }

            iMax = Convert.ToInt32(fMax * 255);
            iMid = Convert.ToInt32(fMid * 255);
            iMin = Convert.ToInt32(fMin * 255);

            switch (iSextant)
            {
                case 1:
                    return Color.FromArgb(alpha, iMid, iMax, iMin);
                case 2:
                    return Color.FromArgb(alpha, iMin, iMax, iMid);
                case 3:
                    return Color.FromArgb(alpha, iMin, iMid, iMax);
                case 4:
                    return Color.FromArgb(alpha, iMid, iMin, iMax);
                case 5:
                    return Color.FromArgb(alpha, iMax, iMin, iMid);
                default:
                    return Color.FromArgb(alpha, iMax, iMid, iMin);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

            
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Можно реализовать предпросмотр или другие функции
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Обработка клика по метке
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Обработка изменения текста
        }



        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image != null)
                {
                    // Копируем текущее изображение в буфер обмена
                    Clipboard.SetImage(pictureBox1.Image);
                    MessageBox.Show("Изображение скопировано в буфер обмена", "Успех",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Нет изображения для копирования", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при копировании: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            try
            {
                if (Clipboard.ContainsImage())
                {
                    // Вставляем изображение из буфера обмена
                    Image pastedImage = Clipboard.GetImage();

                    // Обновляем изображения и интерфейс
                    pictureBox1.Image = pastedImage;
                    pictureBox2.Image = pastedImage;
                    processedImage = new Bitmap(pastedImage);
                    originalImage = new Bitmap(pastedImage);

                    // Обновляем информацию о размере
                    txt_width.Text = pastedImage.Width.ToString();
                    txt_hight.Text = pastedImage.Height.ToString();
                    lbl_size.Text = $"{pastedImage.Width} x {pastedImage.Height}";

                    // Сбрасываем трекбары
                    trk_hue.Value = 0;
                    trk_contrast.Value = 0;
                    trk_bright.Value = 0;
                }
                else
                {
                    MessageBox.Show("В буфере обмена нет изображения", "Информация",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при вставке: {ex.Message}", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //ДЛЯ Tool Strip menu копировать и вставить
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image != null)
                {
                    // Копируем текущее изображение в буфер обмена
                    Clipboard.SetImage(pictureBox1.Image);
                    MessageBox.Show("Изображение скопировано в буфер обмена", "Успех",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Нет изображения для копирования", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при копировании: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Clipboard.ContainsImage())
                {
                    // Вставляем изображение из буфера обмена
                    Image pastedImage = Clipboard.GetImage();

                    // Обновляем изображения и интерфейс
                    pictureBox1.Image = pastedImage;
                    pictureBox2.Image = pastedImage;
                    processedImage = new Bitmap(pastedImage);
                    originalImage = new Bitmap(pastedImage);

                    // Обновляем информацию о размере
                    txt_width.Text = pastedImage.Width.ToString();
                    txt_hight.Text = pastedImage.Height.ToString();
                    lbl_size.Text = $"{pastedImage.Width} x {pastedImage.Height}";

                    // Сбрасываем трекбары
                    trk_hue.Value = 0;
                    trk_contrast.Value = 0;
                    trk_bright.Value = 0;
                }
                else
                {
                    MessageBox.Show("В буфере обмена нет изображения", "Информация",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при вставке: {ex.Message}", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                btnCopy_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                btnPaste_Click(null, null);
            }
        }

        private void btn_f1_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;

            Bitmap original = new Bitmap(pictureBox1.Image);
            Bitmap binary = new Bitmap(original.Width, original.Height);

            // Порог бинаризации (можно регулировать)
            int threshold = 128;

            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color pixel = original.GetPixel(x, y);
                    // Преобразование в grayscale
                    int gray = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                    // Бинаризация
                    Color binaryColor = gray > threshold ? Color.White : Color.Black;
                    binary.SetPixel(x, y, binaryColor);
                }
            }

            pictureBox1.Image = binary;
            processedImage = new Bitmap(binary); // Сохраняем результат
        }
        //функция для бинаризации--------------------
        private void filters_binaris_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;

            // Создаем диалог для выбора параметров бинаризации
            using (var form = new Form())
            {
                form.Text = "Параметры бинаризации";
                form.Size = new Size(300, 200);
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterParent;

                // Комбобокс для выбора режима
                var cmbMode = new ComboBox()
                {
                    Location = new Point(10, 10),
                    Width = 250,
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                cmbMode.Items.AddRange(new object[] {
                "По яркости (общий)",
                "По красному каналу",
                "По зеленому каналу",
                "По синему каналу",
                "Адаптивная бинаризация"
                });
                cmbMode.SelectedIndex = 0;

                // Трекбар для порога
                var lblThreshold = new Label()
                {
                    Text = "Порог бинаризации: 180",
                    Location = new Point(10, 40)
                };
                var trkThreshold = new TrackBar()
                {
                    Minimum = 0,
                    Maximum = 255,
                    Value = 180, // Увеличенный порог по умолчанию
                    Location = new Point(10, 60),
                    Width = 200
                };
                trkThreshold.Scroll += (s, ev) =>
                {
                    lblThreshold.Text = $"Порог бинаризации: {trkThreshold.Value}";
                };

                // Кнопка применения
                var btnApply = new Button()
                {
                    Text = "Применить",
                    DialogResult = DialogResult.OK,
                    Location = new Point(10, 100)
                };

                form.Controls.AddRange(new Control[] { cmbMode, lblThreshold, trkThreshold, btnApply });

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    Bitmap original = new Bitmap(pictureBox1.Image);
                    Bitmap binary = new Bitmap(original.Width, original.Height);
                    int threshold = trkThreshold.Value;

                    for (int y = 0; y < original.Height; y++)
                    {
                        for (int x = 0; x < original.Width; x++)
                        {
                            Color pixel = original.GetPixel(x, y);
                            Color binaryColor = Color.Black;

                            switch (cmbMode.SelectedIndex)
                            {
                                case 0: // По яркости
                                    int gray = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                                    binaryColor = gray > threshold ? Color.White : Color.Black;
                                    break;
                                case 1: // По красному каналу
                                    binaryColor = pixel.R > threshold ? Color.White : Color.Black;
                                    break;
                                case 2: // По зеленому каналу
                                    binaryColor = pixel.G > threshold ? Color.White : Color.Black;
                                    break;
                                case 3: // По синему каналу
                                    binaryColor = pixel.B > threshold ? Color.White : Color.Black;
                                    break;
                                case 4: // Адаптивная бинаризация
                                    int avg = (pixel.R + pixel.G + pixel.B) / 3;
                                    int localThreshold = threshold + (avg - 128) / 2;
                                    binaryColor = avg > localThreshold ? Color.White : Color.Black;
                                    break;
                            }

                            binary.SetPixel(x, y, binaryColor);
                        }
                    }

                    pictureBox1.Image = binary;
                    processedImage = new Bitmap(binary);
                }
            }
            undoHistory.Push(new Bitmap(processedImage));  // Сохраняем текущее состояние
                                                           // Очищаем redoHistory при новом действии
            redoHistory.Clear();
        }

        private void btn_f2_Click_1(object sender, EventArgs e)
        {
            // Проверяем, загружено ли изображение в PictureBox (например, pictureBox1)
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Сначала загрузите изображение!");
                return;
            }

            // Получаем изображение из PictureBox
            Bitmap originalImage = new Bitmap(pictureBox1.Image);
            Bitmap grayImage = new Bitmap(originalImage.Width, originalImage.Height);

            // Применяем фильтр оттенков серого
            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color pixel = originalImage.GetPixel(x, y);

                    // Вычисляем среднее значение RGB (простой метод)
                    int grayValue = (int)((pixel.R * 0.299) + (pixel.G * 0.587) + (pixel.B * 0.114));

                    // Создаем новый цвет в градациях серого
                    Color grayPixel = Color.FromArgb(grayValue, grayValue, grayValue);
                    grayImage.SetPixel(x, y, grayPixel);
                }
            }
        }
        //Для шейдс оф грей tool strip menu
        private void filters_shadesofgrey_Click(object sender, EventArgs e)
        {
            // Проверяем, загружено ли изображение в PictureBox (например, pictureBox1)
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Сначала загрузите изображение!");
                return;
            }

            // Получаем изображение из PictureBox
            Bitmap originalImage = new Bitmap(pictureBox1.Image);
            Bitmap grayImage = new Bitmap(originalImage.Width, originalImage.Height);

            // Применяем фильтр оттенков серого
            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color pixel = originalImage.GetPixel(x, y);

                    // Вычисляем среднее значение RGB (простой метод)
                    int grayValue = (int)((pixel.R * 0.299) + (pixel.G * 0.587) + (pixel.B * 0.114));

                    // Создаем новый цвет в градациях серого
                    Color grayPixel = Color.FromArgb(grayValue, grayValue, grayValue);
                    grayImage.SetPixel(x, y, grayPixel);
                }
            }
            // Отображаем результат
            pictureBox1.Image = grayImage;
        }

        private void btn_f3_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;

            Bitmap original = new Bitmap(pictureBox1.Image);
            Bitmap negative = new Bitmap(original.Width, original.Height);

            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color pixel = original.GetPixel(x, y);
                    // Инвертируем каждый цветовой канал
                    Color negativeColor = Color.FromArgb(
                        255 - pixel.R,
                        255 - pixel.G,
                        255 - pixel.B);
                    negative.SetPixel(x, y, negativeColor);
                }
            }

            pictureBox1.Image = negative;
            processedImage = new Bitmap(negative); // Сохраняем результат
        }
        //Для негатива в  tool strip menu
        private void filters_negative_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;

            Bitmap original = new Bitmap(pictureBox1.Image);
            Bitmap negative = new Bitmap(original.Width, original.Height);

            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color pixel = original.GetPixel(x, y);
                    // Инвертируем каждый цветовой канал
                    Color negativeColor = Color.FromArgb(
                        255 - pixel.R,
                        255 - pixel.G,
                        255 - pixel.B);
                    negative.SetPixel(x, y, negativeColor);
                }
            }

            pictureBox1.Image = negative;
            processedImage = new Bitmap(negative); // Сохраняем результат
        }
        private void четоToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BinarisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyOrangeColorTable());
        }

        private void btn_autosize_Click_1(object sender, EventArgs e)
        {

        }

        private void filters_shadesofgrey_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_open_Click(object sender, EventArgs e)
        {

        }

        private void btn_normal_Click(object sender, EventArgs e)
        {

        }

        private void btn_stretch_Click(object sender, EventArgs e)
        {

        }

        private void btn_center_Click(object sender, EventArgs e)
        {

        }

        private void btn_zoom_Click(object sender, EventArgs e)
        {

        }

        private void btn_reload_Click(object sender, EventArgs e)
        {

        }

        private void btn_resize_Click(object sender, EventArgs e)
        {

        }

        private void file_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void filters_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void view_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void picture_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Rotate_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Освобождаем ресурсы изображений
            if (originalImage != null)
            {
                originalImage.Dispose();
                originalImage = null;
            }

            if (processedImage != null)
            {
                processedImage.Dispose();
                processedImage = null;
            }

            // Очищаем PictureBox
            pictureBox1.Image = null;
            pictureBox2.Image = null;

            // Сбрасываем текстовые поля
            txt_imgpath.Text = string.Empty;
            lbl_size.Text = "0 x 0";
            txt_width.Text = string.Empty;
            txt_hight.Text = string.Empty;

            // Опционально: сбрасываем режимы отображения
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox2.SizeMode = PictureBoxSizeMode.Normal;
            undoHistory.Push(new Bitmap(processedImage));  // Сохраняем текущее состояние
                                                           // Очищаем redoHistory при новом действии
            redoHistory.Clear();
        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void back_button(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_rotate_Click(object sender, EventArgs e)
        {

        }

        private void СоханитьctrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DrawHistogram(Bitmap image, PictureBox pictureBox, Color channelColor, bool isBrightness = false)
        {
            if (image == null || pictureBox == null || pictureBox.Width <= 10 || pictureBox.Height <= 10)
                return;

            try
            {
                // 1. Создаем гистограмму (без unsafe)
                int[] histogram = new int[256];

                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        Color pixel = image.GetPixel(x, y);

                        int value = isBrightness ?
                            (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11) :
                            channelColor.R == 255 ? pixel.R :
                            channelColor.G == 255 ? pixel.G : pixel.B;

                        histogram[value]++;
                    }
                }

                // 2. Нормализуем и рисуем
                int maxCount = histogram.Max();
                if (maxCount == 0) maxCount = 1;

                Bitmap histImage = new Bitmap(pictureBox.Width, pictureBox.Height);
                using (Graphics g = Graphics.FromImage(histImage))
                {
                    g.Clear(Color.White);
                    Pen pen = new Pen(channelColor, 1.5f);

                    float columnWidth = (float)pictureBox.Width / 256;
                    float scale = (float)pictureBox.Height / maxCount;

                    for (int i = 0; i < 256; i++)
                    {
                        float height = histogram[i] * scale;
                        float x = i * columnWidth;
                        g.DrawLine(pen, x, pictureBox.Height, x, pictureBox.Height - height);
                    }

                    // Добавляем рамку
                    g.DrawRectangle(Pens.Black, 0, 0, histImage.Width - 1, histImage.Height - 1);
                }

                // 3. Обновляем PictureBox
                if (pictureBox.Image != null)
                    pictureBox.Image.Dispose();

                pictureBox.Image = histImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при построении гистограммы: {ex.Message}");
            }
        }



        private void цветподробноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Переключаем видимость панели
            Color_Picker_Panel.Visible = !Color_Picker_Panel.Visible;

            // Обновляем текст пункта меню в зависимости от состояния
            цветподробноToolStripMenuItem.Text = Color_Picker_Panel.Visible
                ? "Скрыть панель цвета"
                : "Показать панель цвета";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private bool isPreviewMode = true; // Режим предпросмотра

        private DateTime lastScrollTime = DateTime.MinValue;

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            // Пусто! Никаких действий при движении ползунков
        }

        private void change_parammetrs_button_Click(object sender, EventArgs e)
        {
            if (processedImage == null) // Используем processedImage вместо originalImage
            {
                MessageBox.Show("Сначала загрузите изображение!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Сохраняем текущее состояние для возможного отката
                undoHistory.Push(new Bitmap(processedImage));
                redoHistory.Clear();

                // Получаем значения с ползунков
                float hue = trk_hue.Value / 100f;
                float contrast = 1 + trk_contrast.Value / 100f;
                float brightness = 1 + trk_bright.Value / 100f;

                // Применяем изменения к ТЕКУЩЕМУ обработанному изображению
                Bitmap newImage = AdjustImage(processedImage, hue, contrast, brightness);

                // Обновляем изображения
                processedImage.Dispose(); // Освобождаем старый ресурс
                processedImage = newImage;
                pictureBox1.Image = newImage;

                // Сбрасываем ползунки в 0
                trk_hue.Value = 0;
                trk_contrast.Value = 0;
                trk_bright.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обработке: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void change_parammetrs_button_Click1(object sender, EventArgs e)
        {

        }
    }

    //Класс для измения цвета при наведении на кнопки
    public class MyOrangeColorTable : ProfessionalColorTable
    {
        // Основные цвета для подсветки
        public override Color MenuItemSelected => Color.FromArgb(255, 224, 192); // Светло-оранжевый фон

        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(255, 224, 192);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(255, 224, 192);

        public override Color MenuItemBorder => Color.FromArgb(255, 180, 120); // Граница

        // Цвета при нажатии
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(255, 180, 120);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(255, 180, 120);

        // Фон выпадающего меню
        public override Color ToolStripDropDownBackground => Color.White;

        // Граница меню
        public override Color MenuBorder => Color.LightGray;

    }

}
