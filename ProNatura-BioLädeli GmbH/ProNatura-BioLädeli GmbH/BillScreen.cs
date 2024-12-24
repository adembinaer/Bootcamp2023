using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProNatura_BioLädeli_GmbH
{
    public partial class BillScreen : Form
    {
        //string connectionString = @"Data Source=MyServerName;Initial Catalog=MyDbName; User ID=Admin; Password=Root";
        //SqlConnection connection = new SqlConnection(connectionString);

        private SqlConnection sqlConnectionString = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Adem Mirsada\Documents\ProNatura-BioLädeli GmbH.mdf;Integrated Security = True; Connect Timeout = 30");


        public BillScreen()
        {
            InitializeComponent();
            ShowBill();
        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {

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

        private void ConnectInsert()
        {
            string billRechnungsempf = textBoxBillName.Text;
            string billText = textBoxBillText.Text;
            string billPrice = textBoxBillPrice.Text;

            sqlConnectionString.Open();
            string insert = string.Format("insert into dbo.Bill values('{0}','{1}','{2}')"
                ,billRechnungsempf, billText, billPrice);
            SqlCommand sqlCommand = new SqlCommand(insert, sqlConnectionString);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.InsertCommand = new SqlCommand(insert, sqlConnectionString);
            sqlDataAdapter.InsertCommand.ExecuteNonQuery();

            sqlCommand.Dispose();
            sqlConnectionString.Close();
        }
        private void ConnectUpdate()
        {
            string billRechnungsempf = textBoxBillName.Text;
            string billText = textBoxBillText.Text;
            string billPrice = textBoxBillPrice.Text;

            sqlConnectionString.Open();
            string update = string.Format("update Bill set Rechnungsempfänger ='{0}', Rechnungstext ='{1}', Preis ='{2}' where Id ={4}"
                , billRechnungsempf, billText, billPrice);
            SqlCommand sqlCommand = new SqlCommand(update, sqlConnectionString);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.InsertCommand = new SqlCommand(update, sqlConnectionString);
            sqlDataAdapter.InsertCommand.ExecuteNonQuery();

            sqlCommand.Dispose();
            sqlConnectionString.Close();
        }
        private void ConnectDelete()
        {
            sqlConnectionString.Open();

            SqlCommand sqlCommand3 = new SqlCommand(delete, sqlConnectionString);

            sqlConnectionString.Close();
        }
        private void ClearAllFields()
        {
            textBoxBillName.Clear();
            textBoxBillText.Clear();
            textBoxBillPrice.Clear();
        }
        private void ShowBill()
        {
            sqlConnectionString.Open();
            string query = "select * from Bill";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnectionString);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            DGVBill.DataSource = dataSet.Tables[0];
            
            sqlConnectionString.Close();
        }
    }
}




