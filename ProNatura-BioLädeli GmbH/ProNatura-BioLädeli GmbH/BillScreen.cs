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

        private void ShowBill()
        {
            sqlConnectionString.Open();
            string query = "select * from Bill";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnectionString);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            DGVBill.DataSource = dataSet.Tables[0];
            
            sqlConnectionString.Close();
            //Connect(query,null,null);TEST
        }
        private void Connect(string insert, string update, string delete)
        {
            //string sqlConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Adem Mirsada\Documents\ProNatura-BioLädeli GmbH.mdf;Integrated Security = True; Connect Timeout = 30";
            //SqlConnection connection = new SqlConnection(sqlConnectionString);

            sqlConnectionString.Open();
            //string insert = "insert into dbo.Bill";
            SqlCommand sqlCommand = new SqlCommand(insert, sqlConnectionString);
            SqlCommand sqlCommand2 = new SqlCommand(update, sqlConnectionString);
            SqlCommand sqlCommand3 = new SqlCommand(delete, sqlConnectionString);


            sqlConnectionString.Close();
        }
    }
}




