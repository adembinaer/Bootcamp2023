using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatura_BioLädeli_GmbH
{
    public partial class ProductsScreen : Form
    {
        private SqlConnection sqlConnectionString = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Adem Mirsada\Documents\ProNatura-BioLädeli GmbH.mdf;Integrated Security = True; Connect Timeout = 30");

        public ProductsScreen()
        {
            InitializeComponent();

            // Statpunkt -> DB muss Daten geladen haben
            sqlConnectionString.Open();

            string query = "select * from Products";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnectionString);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet); //Das Ergebnis aus der DB(query) ins DataSet rein.

            productsDGV.DataSource = dataSet.Tables[0]; //DataSource bezogen auf DataGrid UI

            productsDGV.Columns[0].Visible = false; //Spalte mit Id ist nicht mehr sichtbar

            sqlConnectionString.Close();
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
