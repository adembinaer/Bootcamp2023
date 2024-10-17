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
    public partial class Produkte : Form
    {
        public Produkte()
        {
            InitializeComponent();
        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            string productName = txtBoxProductName.Text;
            Console.WriteLine(productName);

            //Save product name in database
        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnProductClear_Click(object sender, EventArgs e)
        {

        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
