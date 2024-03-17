using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadizAutoShopManagementSystem.Components
{
    public partial class LoadingStateForm : Form
    {
        public LoadingStateForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(150, Color.White);
            this.TopMost = true;
            this.ShowInTaskbar = false;
            InitializeControls();
        }

        private void InitializeControls()
        {
            ProgressBar progressBar = new ProgressBar();
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 30;
            progressBar.Dock = DockStyle.Fill;
            this.Controls.Add(progressBar);
        }

        public void ShowLoadingState(Form parentForm)
        {
            this.Owner = parentForm;
            this.Show();
        }

        public void HideLoadingState()
        {
            this.Close();
        }
    }
}
