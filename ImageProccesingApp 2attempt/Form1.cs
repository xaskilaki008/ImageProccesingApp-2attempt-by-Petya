using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
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
            InitializeFiltersMenu();


            Color_Picker_Panel.Visible = false; // Скрываем панель при запуске
            App_menuStrip.Renderer = new ToolStripProfessionalRenderer(new MyOrangeColorTable());
            openToolStripMenuItem.Click += delegate
            {
                openToolStripMenuItem.BackColor = Color.Green;
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
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
                openFileDialog.Title = "Select an Image File";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Очистка предыдущих изображений (если были)
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

                        // Загрузка изображения с проверкой на поддерживаемый формат
                        using (var tempImage = new Bitmap(openFileDialog.FileName))
                        {
                            originalImage = new Bitmap(tempImage);
                            processedImage = new Bitmap(tempImage);
                        }

                        // Обновление элементов интерфейса
                        pictureBox1.Image = originalImage;
                        pictureBox2.Image = originalImage;

                        txt_imgpath.Text = openFileDialog.FileName;
                        UpdateImageInfo(originalImage);

                        // Настройка PictureBox
                        ConfigurePictureBoxes();
                    }
                    catch (OutOfMemoryException)
                    {
                        MessageBox.Show("The selected file is not a valid image or is too large.",
                                      "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ResetImageControls();
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show("The selected file could not be found.",
                                      "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ResetImageControls();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while loading the image:\n{ex.Message}",
                                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ResetImageControls();
                    }
                }
            }
        }

        private void UpdateImageInfo(Bitmap image)
        {
            lbl_size.Text = $"{image.Width} × {image.Height}";
            txt_width.Text = image.Width.ToString();
            txt_hight.Text = image.Height.ToString();
        }

        private void ConfigurePictureBoxes()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            // Опционально: можно добавить обработку слишком больших изображений
            if (originalImage.Width > 2000 || originalImage.Height > 2000)
            {
                MessageBox.Show("The image is very large. Processing may take longer.",
                               "Large Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ResetImageControls()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            txt_imgpath.Text = string.Empty;
            lbl_size.Text = "0 × 0";
            txt_width.Text = string.Empty;
            txt_hight.Text = string.Empty;

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
                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Нет изображения для копирования", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Очищаем буфер обмена (опционально)
                Clipboard.Clear();

                // Копируем изображение
                Clipboard.SetImage(pictureBox1.Image);

                // Можно заменить MessageBox на статус в интерфейсе, например:
                // statusLabel.Text = "Изображение скопировано!";
                MessageBox.Show("Изображение скопировано в буфер обмена", "Успех",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ExternalException)
            {
                MessageBox.Show("Буфер обмена занят другим приложением", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (!Clipboard.ContainsImage())
                {
                    MessageBox.Show("В буфере обмена нет изображения", "Информация",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Image pastedImage = Clipboard.GetImage();
                if (pastedImage == null)
                {
                    MessageBox.Show("Не удалось получить изображение из буфера", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Освобождаем старые изображения, если они есть
                pictureBox1.Image?.Dispose();
                pictureBox2.Image?.Dispose();
                originalImage?.Dispose();
                processedImage?.Dispose();

                // Обновляем изображения
                pictureBox1.Image = (Image)pastedImage.Clone();
                pictureBox2.Image = (Image)pastedImage.Clone();
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
            catch (ExternalException ex)
            {
                MessageBox.Show($"Ошибка доступа к буферу обмена: {ex.Message}", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неизвестная ошибка: {ex.Message}", "Ошибка",
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
        private void filters_binaris_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;

            using (var form = new Form())
            {
                form.Text = "Параметры бинаризации";
                form.Size = new Size(300, 250);
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterParent;

                // Радиокнопки для выбора типа бинаризации
                var rbBrightness = new RadioButton()
                {
                    Text = "По яркости (чёрно-белая)",
                    Checked = true,
                    Location = new Point(10, 10)
                };

                var rbColor = new RadioButton()
                {
                    Text = "По выбранному цвету",
                    Location = new Point(10, 40)
                };

                // Кнопка выбора цвета (только для режима "По цвету")
                var btnPickColor = new Button()
                {
                    Text = "Выбрать цвет...",
                    Location = new Point(30, 70),
                    Enabled = false
                };
                Color targetColor = Color.Red; // Цвет по умолчанию

                rbColor.CheckedChanged += (s, ev) =>
                {
                    btnPickColor.Enabled = rbColor.Checked;
                };

                btnPickColor.Click += (s, ev) =>
                {
                    using (ColorDialog colorDialog = new ColorDialog())
                    {
                        if (colorDialog.ShowDialog() == DialogResult.OK)
                        {
                            targetColor = colorDialog.Color;
                            btnPickColor.BackColor = targetColor;
                        }
                    }
                };

                // Трекбар для порога (общий для обоих режимов)
                var lblThreshold = new Label()
                {
                    Text = "Чувствительность: 50",
                    Location = new Point(10, 110)
                };
                var trkThreshold = new TrackBar()
                {
                    Minimum = 1,
                    Maximum = 100,
                    Value = 50,
                    Location = new Point(10, 130),
                    Width = 200
                };
                trkThreshold.Scroll += (s, ev) =>
                {
                    lblThreshold.Text = $"Чувствительность: {trkThreshold.Value}";
                };

                // Кнопка применения
                var btnApply = new Button()
                {
                    Text = "Применить",
                    DialogResult = DialogResult.OK,
                    Location = new Point(10, 170)
                };

                form.Controls.AddRange(new Control[] {
            rbBrightness, rbColor, btnPickColor,
            lblThreshold, trkThreshold, btnApply
        });

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

                            if (rbBrightness.Checked)
                            {
                                // Режим по яркости
                                int gray = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                                binaryColor = gray > threshold * 2.55 ? Color.White : Color.Black;
                            }
                            else
                            {
                                // Режим по цвету (проверка близости к выбранному цвету)
                                double colorDistance = Math.Sqrt(
                                    Math.Pow(pixel.R - targetColor.R, 2) +
                                    Math.Pow(pixel.G - targetColor.G, 2) +
                                    Math.Pow(pixel.B - targetColor.B, 2));

                                // Чем выше threshold, тем меньше чувствительность
                                double maxDistance = 441.67; // Максимальное расстояние между цветами (~√(255²+255²+255²))
                                double sensitivity = (100 - threshold) / 100.0;

                                binaryColor = colorDistance < (maxDistance * sensitivity) ? Color.White : Color.Black;
                            }

                            binary.SetPixel(x, y, binaryColor);
                        }
                    }

                    pictureBox1.Image = binary;
                    processedImage = new Bitmap(binary);
                }
            }
            undoHistory.Push(new Bitmap(processedImage));
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

        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            App_menuStrip.Renderer = new ToolStripProfessionalRenderer(new MyOrangeColorTable());
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
                undoHistory.Push(new Bitmap(processedImage)); // Сохраняем ДО очистки
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
        private void ApplyRoundedCorners(Panel panel, int radius)
        {
            // Создаем графический путь с скругленными углами
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); // Левый верхний
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90); // Правый верхний
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90); // Правый нижний
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90); // Левый нижний
            path.CloseFigure();

            // Устанавливаем регион для панели
            panel.Region = new Region(path);

            // Настраиваем внешний вид панели
            panel.BackColor = Color.FromArgb(240, 240, 240); // Светло-серый фон
            panel.BorderStyle = BorderStyle.None; // Убираем стандартную рамку
        }

        // Обработчик изменения размера панели
        private void Color_Picker_Panel_SizeChanged(object sender, EventArgs e)
        {
            if (Color_Picker_Panel.Visible)
            {
                ApplyRoundedCorners(Color_Picker_Panel, 15);
            }
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

            private void kirsha_toolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Сначала загрузите изображение!", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    // Преобразуем изображение в Bitmap (если это ещё не Bitmap)
                    Bitmap original = new Bitmap(pictureBox1.Image);

                    // Применяем фильтр Кирша
                    Bitmap result = KirschEdgeDetection(original);

                    // Открываем результат в новом окне
                    FormResult resultForm = new FormResult(result);
                    resultForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка обработки: {ex.Message}", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            private static int GetBrightness(Color pixel)
            {
                return (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
            }
            public static Bitmap KirschEdgeDetection(Bitmap originalImage, int brightnessThreshold = 100)
            {
                Bitmap resultImage = new Bitmap(originalImage.Width, originalImage.Height);

                // Ядра Кирша (8 направлений)
                int[][,] kernels = new int[8][,]
                {
                new int[3,3] { { -3, -3,  5 }, { -3,  0,  5 }, { -3, -3,  5 } },
                new int[3,3] { { -3,  5,  5 }, { -3,  0,  5 }, { -3, -3, -3 } },
                new int[3,3] { {  5,  5,  5 }, { -3,  0, -3 }, { -3, -3, -3 } },
                new int[3,3] { {  5,  5, -3 }, {  5,  0, -3 }, { -3, -3, -3 } },
                new int[3,3] { {  5, -3, -3 }, {  5,  0, -3 }, {  5, -3, -3 } },
                new int[3,3] { { -3, -3, -3 }, {  5,  0, -3 }, {  5,  5, -3 } },
                new int[3,3] { { -3, -3, -3 }, { -3,  0, -3 }, {  5,  5,  5 } },
                new int[3,3] { { -3, -3, -3 }, { -3,  0,  5 }, { -3,  5,  5 } }
                };

                for (int y = 1; y < originalImage.Height - 1; y++)
                {
                    for (int x = 1; x < originalImage.Width - 1; x++)
                    {
                        int maxGradient = 0;

                        // Применяем все 8 ядер
                        for (int k = 0; k < 8; k++)
                        {
                            int gradient = 0;

                            // Свёртка с ядром 3x3
                            for (int ky = -1; ky <= 1; ky++)
                            {
                                for (int kx = -1; kx <= 1; kx++)
                                {
                                    Color pixel = originalImage.GetPixel(x + kx, y + ky);
                                    int brightness = GetBrightness(pixel);
                                    gradient += brightness * kernels[k][ky + 1, kx + 1];
                                }
                            }

                            if (gradient > maxGradient)
                                maxGradient = gradient;
                        }

                        // Коррекция яркости и запись результата
                        int resultValue = Math.Max(0, Math.Min(maxGradient + brightnessThreshold, 255));
                        resultImage.SetPixel(x, y, Color.FromArgb(resultValue, resultValue, resultValue));
                    }
                }

                return resultImage;
            }
            private Bitmap LaplaceEdgeDetection(Bitmap sourceImage, int brightnessThreshold)
            {
                if (sourceImage == null)
                    throw new ArgumentNullException(nameof(sourceImage));

                Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

                // Ядро оператора Лапласа
                int[,] laplacianKernel = {
                { -1, -1, -1 },
                { -1,  8, -1 },
                { -1, -1, -1 }
            };

            for (int y = 1; y < sourceImage.Height - 1; y++)
            {
                for (int x = 1; x < sourceImage.Width - 1; x++)
                {
                    int r = 0, g = 0, b = 0;

                    // Применяем ядро к окружающим пикселям
                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            Color pixel = sourceImage.GetPixel(x + kx, y + ky);
                            int kernelValue = laplacianKernel[ky + 1, kx + 1];

                            r += pixel.R * kernelValue;
                            g += pixel.G * kernelValue;
                            b += pixel.B * kernelValue;
                        }
                    }

                    // Нормализация и применение порога
                    r = Math.Abs(r) > brightnessThreshold ? 255 : 0;
                    g = Math.Abs(g) > brightnessThreshold ? 255 : 0;
                    b = Math.Abs(b) > brightnessThreshold ? 255 : 0;

                    resultImage.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return resultImage;
            }
            private void ApplyEdgeDetection()
            {
                if (pictureBox1.Image != null)
                {
                    try
                    {
                        Bitmap original = new Bitmap(pictureBox1.Image);
                        int threshold = 30; // Значение порога по умолчанию

                        // Если у вас есть control для выбора порога, используйте его значение:
                        // if (int.TryParse(txtThreshold.Text, out threshold)) { ... }

                        Bitmap edgeImage = LaplaceEdgeDetection(original, threshold);
                        pictureBox2.Image = edgeImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при обработке изображения: {ex.Message}");
                    }
                }
            }
            private void saveToolStripMenuItem_Click(object sender, EventArgs e)
            {
            if (pictureBox1.Image != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ImageFormat format = ImageFormat.Jpeg;
                        switch (saveFileDialog.FilterIndex)
                        {
                            case 1: format = ImageFormat.Jpeg; break;
                            case 2: format = ImageFormat.Png; break;
                            case 3: format = ImageFormat.Bmp; break;
                        }
                        pictureBox1.Image.Save(saveFileDialog.FileName, format);
                    }
                }
            }
            }
            private void AddSaltAndPepperNoise(double probability)
            {
                if (originalImage == null) return;

                processedImage = new Bitmap(originalImage);
                Random rand = new Random();

                for (int y = 0; y < processedImage.Height; y++)
                {
                    for (int x = 0; x < processedImage.Width; x++)
                    {
                        if (rand.NextDouble() < probability)
                        {
                            // Соль или перец с равной вероятностью
                            if (rand.NextDouble() < 0.5)
                                processedImage.SetPixel(x, y, Color.White); // Соль
                            else
                                processedImage.SetPixel(x, y, Color.Black); // Перец
                        }
                    }
                }

                pictureBox1.Image = processedImage;
            }

            private void ApplySmoothingFilter(int apertureSize)
            {
                if (processedImage == null) return;

                Bitmap tempImage = new Bitmap(processedImage);
                int offset = apertureSize / 2;

                for (int y = offset; y < processedImage.Height - offset; y++)
                {
                    for (int x = offset; x < processedImage.Width - offset; x++)
                    {
                        int totalR = 0, totalG = 0, totalB = 0;
                        int pixelCount = 0;

                        for (int fy = -offset; fy <= offset; fy++)
                        {
                            for (int fx = -offset; fx <= offset; fx++)
                            {
                                Color pixel = processedImage.GetPixel(x + fx, y + fy);
                                totalR += pixel.R;
                                totalG += pixel.G;
                                totalB += pixel.B;
                                pixelCount++;
                            }
                        }

                        int avgR = totalR / pixelCount;
                        int avgG = totalG / pixelCount;
                        int avgB = totalB / pixelCount;

                        tempImage.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                    }
                }

                processedImage = tempImage;
                pictureBox1.Image = processedImage;
            }

            private void ApplyMedianFilter(int apertureSize)
            {
                if (processedImage == null) return;

                Bitmap tempImage = new Bitmap(processedImage);
                int offset = apertureSize / 2;
                int pixelCount = apertureSize * apertureSize;
                int medianIndex = pixelCount / 2;

                for (int y = offset; y < processedImage.Height - offset; y++)
                {
                    for (int x = offset; x < processedImage.Width - offset; x++)
                    {
                        // Массивы для хранения значений каналов
                        int[] rValues = new int[pixelCount];
                        int[] gValues = new int[pixelCount];
                        int[] bValues = new int[pixelCount];
                        int index = 0;

                        // Собираем значения пикселей в окрестности
                        for (int fy = -offset; fy <= offset; fy++)
                        {
                            for (int fx = -offset; fx <= offset; fx++)
                            {
                                Color pixel = processedImage.GetPixel(x + fx, y + fy);
                                rValues[index] = pixel.R;
                                gValues[index] = pixel.G;
                                bValues[index] = pixel.B;
                                index++;
                            }
                        }

                        // Сортируем массивы
                        Array.Sort(rValues);
                        Array.Sort(gValues);
                        Array.Sort(bValues);

                        // Берем медианное значение
                        int medianR = rValues[medianIndex];
                        int medianG = gValues[medianIndex];
                        int medianB = bValues[medianIndex];

                        tempImage.SetPixel(x, y, Color.FromArgb(medianR, medianG, medianB));
                    }
                }

                processedImage = tempImage;
                pictureBox1.Image = processedImage;
            }

            private void ResetImage()
            {
                if (originalImage != null)
                {
                    processedImage = new Bitmap(originalImage);
                    pictureBox1.Image = processedImage;
                }
            }
            
        

        private void laplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Сначала загрузите изображение!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Bitmap original = new Bitmap(pictureBox1.Image);
                Bitmap result = LaplaceEdgeDetection(original, brightnessThreshold: 150); // Порог можно настроить

                // Открываем результат в новом окне
                FormResult resultForm = new FormResult(result);
                resultForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обработки: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
