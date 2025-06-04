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
            filters_binaris.Click += filters_binaris_Click;
            ToolStripMenuItem_Rotate.Click += ToolStripMenuItem_Rotate_Click;
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // Добавьте в конструктор Form1() после инициализации других элементов:
            this.KeyPreview = true; // Для обработки горячих клавиш
            this.KeyDown += Form1_KeyDown;

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
        //Бинаризация изображения
        private void filters_binaris_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;

            using (var form = new Form())
            {
                form.Text = "Параметры бинаризации";
                form.Size = new Size(400, 350);
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterParent;
                form.BackColor = Color.Lavender;

                // Группа для типа бинаризации
                var groupBoxType = new GroupBox()
                {
                    Text = "Тип бинаризации",
                    Location = new Point(10, 10),
                    Size = new Size(370, 80)
                };

                var rbBrightness = new RadioButton()
                {
                    Text = "По яркости (чёрно-белая)",
                    Checked = true,
                    Location = new Point(15, 20),
                    AutoSize = true
                };

                var rbTwoColor = new RadioButton()
                {
                    Text = "Двухцветная бинаризация",
                    Location = new Point(15, 45),
                    AutoSize = true
                };

                // Группа для выбора цветов
                var groupBoxColors = new GroupBox()
                {
                    Text = "Цвета для бинаризации",
                    Location = new Point(10, 100),
                    Size = new Size(370, 100),
                    Enabled = false
                };

                Color color1 = Color.Black;
                Color color2 = Color.White;

                var btnColor1 = new Button()
                {
                    Text = "Цвет 1 (фон)",
                    Location = new Point(15, 20),
                    Size = new Size(150, 30),
                    BackColor = color1,
                    ForeColor = Color.White
                };

                var btnColor2 = new Button()
                {
                    Text = "Цвет 2 (объекты)",
                    Location = new Point(200, 20),
                    Size = new Size(150, 30),
                    BackColor = color2
                };

                // Обработчики выбора цветов
                btnColor1.Click += (s, ev) =>
                {
                    using (ColorDialog dlg = new ColorDialog())
                    {
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            color1 = dlg.Color;
                            btnColor1.BackColor = color1;
                            btnColor1.ForeColor = GetContrastColor(color1);
                        }
                    }
                };

                btnColor2.Click += (s, ev) =>
                {
                    using (ColorDialog dlg = new ColorDialog())
                    {
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            color2 = dlg.Color;
                            btnColor2.BackColor = color2;
                            btnColor2.ForeColor = GetContrastColor(color2);
                        }
                    }
                };

                // Активация группы цветов при выборе двухцветного режима
                rbTwoColor.CheckedChanged += (s, ev) =>
                {
                    groupBoxColors.Enabled = rbTwoColor.Checked;
                };

                // Настройка порога
                var lblThreshold = new Label()
                {
                    Text = "Порог бинаризации: 128",
                    Location = new Point(10, 210),
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    AutoSize = true
                };

                var trkThreshold = new TrackBar()
                {
                    Minimum = 0,
                    Maximum = 255,
                    Value = 128,
                    Location = new Point(10, 235),
                    Size = new Size(360, 45),
                    TickFrequency = 16
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
                    Location = new Point(150, 280),
                    Size = new Size(100, 30),
                    BackColor = Color.LightSteelBlue,
                    FlatStyle = FlatStyle.Flat
                };

                // Добавление элементов на форму
                groupBoxType.Controls.Add(rbBrightness);
                groupBoxType.Controls.Add(rbTwoColor);

                groupBoxColors.Controls.Add(btnColor1);
                groupBoxColors.Controls.Add(btnColor2);

                form.Controls.Add(groupBoxType);
                form.Controls.Add(groupBoxColors);
                form.Controls.Add(lblThreshold);
                form.Controls.Add(trkThreshold);
                form.Controls.Add(btnApply);

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
                            Color resultColor;

                            if (rbBrightness.Checked)
                            {
                                // Стандартная бинаризация по яркости
                                int gray = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                                resultColor = gray > threshold ? color2 : color1;
                            }
                            else
                            {
                                // Двухцветная бинаризация
                                int gray = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                                resultColor = gray > threshold ? color2 : color1;
                            }

                            binary.SetPixel(x, y, resultColor);
                        }
                    }

                    pictureBox1.Image = binary;
                    processedImage = new Bitmap(binary);
                }
            }

            undoHistory.Push(new Bitmap(processedImage));
            redoHistory.Clear();
        }

        // Вспомогательная функция для определения контрастного цвета текста
        private Color GetContrastColor(Color color)
        {
            int brightness = (int)(color.R * 0.299 + color.G * 0.587 + color.B * 0.114);
            return brightness > 128 ? Color.Black : Color.White;
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
        private DateTime lastScrollTime = DateTime.MinValue;
        //применение параметров Scroll Bars цвета
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
        //4лб Фильтр выделение границ Кирша
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
                // Создаем и показываем ProgressBar
                var progressForm = new ProgressBar();
                progressForm.Show();

                Bitmap original = new Bitmap(pictureBox1.Image);
                Bitmap result = KirschEdgeDetection(original, progressForm);

                // Открываем результат в новом окне
                FormResult resultForm = new FormResult(result);
                resultForm.Show();

                progressForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обработки: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Bitmap KirschEdgeDetection(Bitmap original, ProgressBar progressForm)
        {
            Bitmap result = new Bitmap(original.Width, original.Height);
            int totalPixels = original.Width * original.Height;
            int processedPixels = 0;

            // Маски Кирша
            int[,] kirschMask1 = { { 5, 5, 5 }, { -3, 0, -3 }, { -3, -3, -3 } };
            int[,] kirschMask2 = { { -3, 5, 5 }, { -3, 0, 5 }, { -3, -3, -3 } };
            int[,] kirschMask3 = { { -3, -3, 5 }, { -3, 0, 5 }, { -3, -3, 5 } };
            int[,] kirschMask4 = { { -3, -3, -3 }, { -3, 0, 5 }, { -3, 5, 5 } };
            int[,] kirschMask5 = { { -3, -3, -3 }, { -3, 0, -3 }, { 5, 5, 5 } };
            int[,] kirschMask6 = { { -3, -3, -3 }, { 5, 0, -3 }, { 5, 5, -3 } };
            int[,] kirschMask7 = { { 5, -3, -3 }, { 5, 0, -3 }, { 5, -3, -3 } };
            int[,] kirschMask8 = { { 5, 5, -3 }, { 5, 0, -3 }, { -3, -3, -3 } };

            for (int y = 1; y < original.Height - 1; y++)
            {
                for (int x = 1; x < original.Width - 1; x++)
                {
                    int maxGradient = 0;

                    // Применяем все 8 масок Кирша
                    int g1 = ApplyKirschMask(original, x, y, kirschMask1);
                    int g2 = ApplyKirschMask(original, x, y, kirschMask2);
                    int g3 = ApplyKirschMask(original, x, y, kirschMask3);
                    int g4 = ApplyKirschMask(original, x, y, kirschMask4);
                    int g5 = ApplyKirschMask(original, x, y, kirschMask5);
                    int g6 = ApplyKirschMask(original, x, y, kirschMask6);
                    int g7 = ApplyKirschMask(original, x, y, kirschMask7);
                    int g8 = ApplyKirschMask(original, x, y, kirschMask8);

                    // Находим максимальное значение градиента
                    maxGradient = Math.Max(maxGradient, g1);
                    maxGradient = Math.Max(maxGradient, g2);
                    maxGradient = Math.Max(maxGradient, g3);
                    maxGradient = Math.Max(maxGradient, g4);
                    maxGradient = Math.Max(maxGradient, g5);
                    maxGradient = Math.Max(maxGradient, g6);
                    maxGradient = Math.Max(maxGradient, g7);
                    maxGradient = Math.Max(maxGradient, g8);

                    // Нормализуем и повышаем яркость
                    maxGradient = Math.Min(255, maxGradient + 100);

                    result.SetPixel(x, y, Color.FromArgb(maxGradient, maxGradient, maxGradient));

                    // Обновление прогресса
                    processedPixels++;
                    int progress = (int)((double)processedPixels / totalPixels * 100);
                    progressForm.UpdateProgress(progress);
                    Application.DoEvents();
                }
            }
            return result;
        }
        private int ApplyKirschMask(Bitmap image, int x, int y, int[,] mask)
        {
            int sum = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    Color pixel = image.GetPixel(x + j, y + i);
                    int grayValue = (pixel.R + pixel.G + pixel.B) / 3;
                    sum += grayValue * mask[i + 1, j + 1];
                }
            }
            return Math.Abs(sum);
        }

        //Функция получения якрости
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
        public static class ProgressHelper
        {
            private static ProgressBar _progressBar;
            private static Form _mainForm;

            // Инициализация (вызовите при старте программы)
            public static void Initialize(ProgressBar progressBar, Form mainForm)
            {
                _progressBar = progressBar;
                _mainForm = mainForm;
            }

            // Запуск операции с ProgressBar
            public static async Task RunWithProgress(Func<Task> action)
            {
                _progressBar.Visible = true;
                _progressBar.Style = ProgressBarStyle.Marquee; // Анимация

                await Task.Run(action);

                _progressBar.Visible = false;
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
                // Создаем и показываем ProgressBar
                var progressForm = new ProgressBar();
                progressForm.Show();

                Bitmap original = new Bitmap(pictureBox1.Image);
                Bitmap result = LaplaceEdgeDetection(original, 150, progressForm);

                // Открываем результат в новом окне
                FormResult resultForm = new FormResult(result);
                resultForm.Show();

                progressForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обработки: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Bitmap LaplaceEdgeDetection(Bitmap original, int brightnessThreshold, ProgressBar progressForm)
        {
            Bitmap result = new Bitmap(original.Width, original.Height);
            int totalPixels = original.Width * original.Height;
            int processedPixels = 0;

            // Маска Лапласа
            int[,] laplaceMask = { { -1, -1, -1 }, { -1, 8, -1 }, { -1, -1, -1 } };

            for (int y = 1; y < original.Height - 1; y++)
            {
                for (int x = 1; x < original.Width - 1; x++)
                {
                    int sum = 0;

                    // Применяем маску Лапласа
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color pixel = original.GetPixel(x + j, y + i);
                            int grayValue = (pixel.R + pixel.G + pixel.B) / 3;
                            sum += grayValue * laplaceMask[i + 1, j + 1];
                        }
                    }

                    // Применяем порог яркости
                    sum = Math.Abs(sum);
                    if (sum < brightnessThreshold) sum = 0;

                    // Нормализуем значение
                    sum = Math.Min(255, sum);

                    result.SetPixel(x, y, Color.FromArgb(sum, sum, sum));

                    // Обновление прогресса
                    processedPixels++;
                    int progress = (int)((double)processedPixels / totalPixels * 100);
                    progressForm.UpdateProgress(progress);
                    Application.DoEvents();
                }
            }
            return result;
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

            // Создаем и показываем ProgressBar
            var progressForm = new ProgressBar();
            progressForm.Show();

            processedImage = new Bitmap(originalImage);
            Random rand = new Random();

            int totalPixels = processedImage.Width * processedImage.Height;
            int processedPixels = 0;

            for (int y = 0; y < processedImage.Height; y++)
            {
                for (int x = 0; x < processedImage.Width; x++)
                {
                    if (rand.NextDouble() < probability)
                    {
                        processedImage.SetPixel(x, y, rand.NextDouble() < 0.5 ? Color.White : Color.Black);
                    }

                    // Обновляем прогресс
                    processedPixels++;
                    int progress = (int)((double)processedPixels / totalPixels * 100);
                    progressForm.UpdateProgress(progress);

                    // Чтобы UI не зависал
                    Application.DoEvents();
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

        private void методРобертсаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Сначала загрузите изображение!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Создаем и показываем ProgressBar
                var progressForm = new ProgressBar();
                progressForm.Show();

                Bitmap original = new Bitmap(pictureBox1.Image);
                Bitmap result = RobertsEdgeDetection(original, progressForm);

                // Открываем результат в новом окне
                FormResult resultForm = new FormResult(result);
                resultForm.Show();

                progressForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обработки: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Bitmap RobertsEdgeDetection(Bitmap original, ProgressBar progressForm)
        {
            Bitmap result = new Bitmap(original.Width, original.Height);
            int totalPixels = original.Width * original.Height;
            int processedPixels = 0;

            // Порог для определения границ (можно регулировать)
            int threshold = 30;

            for (int y = 0; y < original.Height - 1; y++)
            {
                for (int x = 0; x < original.Width - 1; x++)
                {
                    Color c1 = original.GetPixel(x, y);
                    Color c2 = original.GetPixel(x + 1, y + 1);
                    Color c3 = original.GetPixel(x + 1, y);
                    Color c4 = original.GetPixel(x, y + 1);

                    // Вычисляем градиенты для каждого канала
                    int gxR = c1.R - c2.R;
                    int gyR = c1.R - c3.R - c4.R + c2.R;
                    int gradientR = (int)Math.Sqrt(gxR * gxR + gyR * gyR);

                    int gxG = c1.G - c2.G;
                    int gyG = c1.G - c3.G - c4.G + c2.G;
                    int gradientG = (int)Math.Sqrt(gxG * gxG + gyG * gyG);

                    int gxB = c1.B - c2.B;
                    int gyB = c1.B - c3.B - c4.B + c2.B;
                    int gradientB = (int)Math.Sqrt(gxB * gxB + gyB * gyB);

                    // Общий градиент (можно использовать максимальное значение)
                    int maxGradient = Math.Max(gradientR, Math.Max(gradientG, gradientB));

                    // Применяем порог: если градиент выше порога - белый, иначе - черный
                    Color edgeColor = maxGradient > threshold ? Color.White : Color.Black;

                    result.SetPixel(x, y, edgeColor);

                    // Обновление прогресса
                    processedPixels++;
                    int progress = (int)((double)processedPixels / totalPixels * 100);
                    progressForm.UpdateProgress(progress);
                    Application.DoEvents();
                }
            }
            return result;
        }
        // Метод Уоллеса
        private void методУоллесаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Сначала загрузите изображение!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var progressForm = new ProgressBar())
                {
                    progressForm.Show();

                    Bitmap result = WallaceEdgeDetection(
                        new Bitmap(pictureBox1.Image),
                        progressForm);

                    FormResult resultForm = new FormResult(result, "Метод Уоллеса");
                    resultForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обработки: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Статистический метод
        private void статистическийМетодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Сначала загрузите изображение!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var progressForm = new ProgressBar())
                {
                    progressForm.Show();

                    Bitmap result = StatisticalEdgeDetection(
                        new Bitmap(pictureBox1.Image),
                        progressForm);

                    FormResult resultForm = new FormResult(result, "Статистический метод");
                    resultForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обработки: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Реализация метода Уоллеса
        private Bitmap WallaceEdgeDetection(Bitmap original, ProgressBar progressForm)
        {
            Bitmap result = new Bitmap(original.Width, original.Height);
            int totalPixels = original.Width * original.Height;
            int processedPixels = 0;

            // Коэффициенты согласно инструкции
            const double multiplier = 500.0;
            const int brightnessBoost = 100;

            // Функция для ограничения значения в диапазоне [0, 255]
            int Clamp(int value)
            {
                return value < 0 ? 0 : (value > 255 ? 255 : value);
            }

            for (int y = 1; y < original.Height - 1; y++)
            {
                for (int x = 1; x < original.Width - 1; x++)
                {
                    // Получаем цвет центрального пикселя
                    Color centerColor = original.GetPixel(x, y);

                    // Получаем цвета соседних пикселей (верх, право, низ, лево)
                    Color topColor = original.GetPixel(x, y - 1);
                    Color rightColor = original.GetPixel(x + 1, y);
                    Color bottomColor = original.GetPixel(x, y + 1);
                    Color leftColor = original.GetPixel(x - 1, y);

                    // Обрабатываем каждый цветовой канал отдельно
                    int r = ProcessChannel(centerColor.R, topColor.R, rightColor.R, bottomColor.R, leftColor.R);
                    int g = ProcessChannel(centerColor.G, topColor.G, rightColor.G, bottomColor.G, leftColor.G);
                    int b = ProcessChannel(centerColor.B, topColor.B, rightColor.B, bottomColor.B, leftColor.B);

                    // Применяем усиление и ограничение диапазона
                    r = Clamp((int)(r * multiplier + brightnessBoost));
                    g = Clamp((int)(g * multiplier + brightnessBoost));
                    b = Clamp((int)(b * multiplier + brightnessBoost));

                    result.SetPixel(x, y, Color.FromArgb(r, g, b));

                    // Обновление прогресса
                    processedPixels++;
                    progressForm.Value = (int)((double)processedPixels / totalPixels * 100);
                    Application.DoEvents();
                }
            }
            return result;
        }

        // Метод для обработки одного цветового канала
        private double ProcessChannel(byte center, byte top, byte right, byte bottom, byte left)
        {
            // Вычисляем отношения center/neighbor с добавлением 1 (чтобы избежать деления на 0)
            double ratio1 = (center + 1) / (double)(top + 1);
            double ratio3 = (center + 1) / (double)(right + 1);
            double ratio5 = (center + 1) / (double)(bottom + 1);
            double ratio7 = (center + 1) / (double)(left + 1);

            // Вычисляем логарифмы отношений
            double log1 = Math.Log(ratio1);
            double log3 = Math.Log(ratio3);
            double log5 = Math.Log(ratio5);
            double log7 = Math.Log(ratio7);

            // Вычисляем новое значение по формуле Уоллеса
            return (log1 * log3 * log5 * log7) / 4.0;
        }

        // Реализация статистического метода
        private Bitmap StatisticalEdgeDetection(Bitmap original, ProgressBar progressForm)
        {
            const int BrightnessThreshold = 50;
            Bitmap result = new Bitmap(original.Width, original.Height);
            int totalPixels = original.Width * original.Height;
            int processedPixels = 0;

            for (int y = 1; y < original.Height - 1; y++)
            {
                for (int x = 1; x < original.Width - 1; x++)
                {
                    double sum = 0;
                    for (int i = -1; i <= 1; i++)
                        for (int j = -1; j <= 1; j++)
                            sum += original.GetPixel(x + i, y + j).R;
                    double mean = sum / 9;

                    double variance = 0;
                    for (int i = -1; i <= 1; i++)
                        for (int j = -1; j <= 1; j++)
                        {
                            double diff = original.GetPixel(x + i, y + j).R - mean;
                            variance += diff * diff;
                        }
                    double stdDev = Math.Sqrt(variance / 9);

                    int newValue = (int)(stdDev * original.GetPixel(x, y).R);
                    newValue += BrightnessThreshold;
                    newValue = Math.Max(0, Math.Min(255, newValue));

                    result.SetPixel(x, y, Color.FromArgb(newValue, newValue, newValue));

                    processedPixels++;
                    progressForm.UpdateProgress((int)((double)processedPixels / totalPixels * 100));
                    Application.DoEvents();
                }
            }
            return result;
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
}
