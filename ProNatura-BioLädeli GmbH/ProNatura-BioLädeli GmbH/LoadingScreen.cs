using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatura_BioLädeli_GmbH
{
    public partial class LoadingScreen : Form
    {
        private int loadingBarValue; // Int immer Null
        private int loadingProgressBarMaximum;

        public LoadingScreen()
        {
            InitializeComponent();
        }
        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            loadingbarTimer.Start();
        }

        private void loadingbarTimer_Tick(object sender, EventArgs e)
        {
            loadingProgressBarMaximum = loadingProgressBar.Maximum;
            loadingBarValue += 1;

            loadingProgressBar.Value = loadingBarValue; // loadingProgressBar.Value Ist dasselbe wie beim Design in PropertyWindow man Value von Hand eintippt
            lblLoadingProgress.Text = loadingBarValue.ToString() + "%";

            //if(loadingBarValue >= 100) // Mit Magic Number 100
            //{
            //    loadingbarTimer.Stop();
            //    // Finish loading
            //}
            if (loadingBarValue >= loadingProgressBarMaximum) // Ohne Magic Number 100
            {
                loadingbarTimer.Stop();
                // Finish loading
                // Finish loading show main menu screen

                MainMenuScreen mainMenuScreen = new MainMenuScreen();
                mainMenuScreen.Show();

                this.Hide();
            }
        }

    }
}
