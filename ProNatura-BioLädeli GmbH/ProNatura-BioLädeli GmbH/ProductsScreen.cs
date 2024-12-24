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
        private int lastSelectedProductKey;
        public ProductsScreen()
        {
            InitializeComponent();

            // Statpunkt -> DB muss Daten geladen haben
            ShowProducts();
        }
        private void btnProductSave_Click(object sender, EventArgs e)
        {
            //Test
            //string productName = txtBoxProductName.Text;
            //Console.WriteLine(productName);

            //Save product name in database

            if (txtBoxProductName.Text == null
                || textBoxProductBrand.Text == null
                || comboBoxProductCategory.Text == null
                || textBoxProductPrice.Text == "") //null ergibt beim Parsen einen Fehler!!!
            {
                MessageBox.Show("Bitte alle Werte ausfüllen");
                return;//Hier wird der Restcode abgebrochen wenn if-statement erfüllt ist.
            }

            string productName = txtBoxProductName.Text;
            string productBrand = textBoxProductBrand.Text;
            string productCategory = comboBoxProductCategory.Text;
            string productPrice = textBoxProductPrice.Text;
            //float productPrice = float.Parse(textBoxProductPrice.Text);

            //Dieser Codesnippet wurde in eine Extended Method übertragen ExecuteQuery()
            //sqlConnectionString.Open(); // Bei jedem SqlCommand muss man eine DB Connection erzeugen Open/Close();
            //string query = string.Format("insert into Products values('{0}','{1}','{2}','{3}')", productName, productBrand, productCategory, productPrice);
            //SqlCommand sqlCommand = new SqlCommand(query, sqlConnectionString);
            //sqlCommand.ExecuteNonQuery();
            //sqlConnectionString.Close();

            string query = string.Format("insert into Products values('{0}','{1}','{2}','{3}')"
                , productName, productBrand, productCategory, productPrice);
            ExecuteQuery(query);

            ClearAllFields();
            ShowProducts();
        }


        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            if (lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Produkt aus");
                return;
            }

            string productName = txtBoxProductName.Text;
            string productBrand = textBoxProductBrand.Text;
            string productCategory = comboBoxProductCategory.Text;
            string productPrice = textBoxProductPrice.Text;

            string query = string.Format("update Products set Name='{0}', Brand='{1}', Category='{2}', Price='{3}' where Id={4}"
                ,productName, productBrand, productCategory, productPrice, lastSelectedProductKey);

            ExecuteQuery(query);
            ShowProducts();
        }
        private void btnProductClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }
        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            if(lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Produkt aus");
            }
            string query = string.Format("delete from Products where Id = {0}", lastSelectedProductKey);
            ExecuteQuery(query);

            ClearAllFields();
            ShowProducts();
        }
        private void ClearAllFields()
        {
            txtBoxProductName.Clear();
            textBoxProductBrand.Clear();
            textBoxProductPrice.Clear();
            comboBoxProductCategory.Text = "";
            comboBoxProductCategory.SelectedItem = null;
        }
        private void ExecuteQuery(string query)
        {
            sqlConnectionString.Open(); // Bei jedem SqlCommand muss man eine DB Connection erzeugen Open/Close();          
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnectionString);
            sqlCommand.ExecuteNonQuery();
            sqlConnectionString.Close();
        }
        private void ShowProducts()
        {
            sqlConnectionString.Open();

            string query = "select * from Products";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnectionString);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet); //Das Ergebnis aus der DB(query) ins DataSet rein.

            productsDGV.DataSource = dataSet.Tables[0]; //DataSource bezogen auf DataGrid UI

            productsDGV.Columns[0].Visible = false; //Spalte mit Id ist nicht mehr sichtbar

            sqlConnectionString.Close();
        }

        private void productsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxProductName.Text = productsDGV.SelectedRows[0].Cells[1].Value.ToString();
            textBoxProductBrand.Text = productsDGV.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxProductCategory.Text = productsDGV.SelectedRows[0].Cells[3].Value.ToString();
            textBoxProductPrice.Text = productsDGV.SelectedRows[0].Cells[4].Value.ToString();

            lastSelectedProductKey = (int)productsDGV.SelectedRows[0].Cells[0].Value;
            Console.WriteLine(lastSelectedProductKey);//Test was lastSelectedProductKey ausgibt

        }
    }
}
