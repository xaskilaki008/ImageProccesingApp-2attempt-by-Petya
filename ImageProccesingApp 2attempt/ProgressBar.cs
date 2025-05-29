using System
;
using System.Windows.Forms
;

namespace ImageProccesingApp_2attempt {
    public partial class ProgressBar : Form {
        // Добавляем свойство Style
        public ProgressBarStyle Style {
            get => pbar.Style;
            set => pbar.Style = value;
        }

        public ProgressBar() {
            InitializeComponent();
            pbar .Value = 0;
            pbar .Text = "0%";
        }

        private void timer1_Tick(object sender, EventArgs e) {
            pbar .Value += 1;
            pbar .Text = pbar.Value.ToString() + "%";

            if (pbar.Value == 100) {
                timer1 .Enabled = false;
                this .Close();
            }
        }

        public void UpdateProgress(int value) {
            if (value < 0) value = 0;
            if (value > 100) value = 100;

            if (pbar.InvokeRequired) {
                pbar.Invoke(new Action(() => {
                    pbar.Value = value;
                    pbar.Text = $"{value}%";
                }))
                ;
            }

            else {
                pbar .Value = value;
                pbar .Text = $"{value}%";
            }

            if (value == 100) {
                this .Close();
            }
        }
    }
}
