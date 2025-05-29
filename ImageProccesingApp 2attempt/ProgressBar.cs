using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProccesingApp_2attempt {
    public partial class ProgressBar : Form {
        public ProgressBar() {
            InitializeComponent();
            pbar .Value = 0;
        }

        public ProgressBarStyle Style {
            get;
            internal set;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            pbar .Value += 1;
            pbar.Text = pbar.Value.ToString()+ "%";
            if(pbar.Value == 100){
                timer1.Enabled=false;
            }
        }
    }
}
