using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProNatura_BioLädeli_GmbH
{
    public partial class BillScreen : Form
    {
        private SqlConnection sqlConnectionString = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Adem Mirsada\Documents\ProNatura-BioLädeli GmbH.mdf;Integrated Security = True; Connect Timeout = 30");
        private int lastSelectedBillKey;

        public BillScreen()
        {
            InitializeComponent();
            ShowBill();
        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            if (textBoxBillName == null
                || textBoxBillText == null
                || textBoxBillPrice == null)
            {
                MessageBox.Show("Bitte alle Felder ausfüllen");
                return;
            }

            ConnectInsert();
            ClearAllFields();
            ShowBill();
        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            if (lastSelectedBillKey == 0)
            {
                MessageBox.Show("Bitte eine Rechnung auswählen");
                return;
            }

            ConnectUpdate();
            ClearAllFields();
            ShowBill();
        }

        private void btnProductClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {

        }
        private void ConnectInsert()
        {
            sqlConnectionString.Open();

            string billRechnungsempf = textBoxBillName.Text;
            string billText = textBoxBillText.Text;
            string billPrice = textBoxBillPrice.Text;


            string insert = string.Format("insert into Bill values('{0}','{1}','{2}')"
                , billRechnungsempf, billText, billPrice);
            SqlCommand sqlCommand = new SqlCommand(insert, sqlConnectionString);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.InsertCommand = new SqlCommand(insert, sqlConnectionString);
            sqlDataAdapter.InsertCommand.ExecuteNonQuery();

            sqlCommand.Dispose();
            sqlConnectionString.Close();
        }
        private void ConnectUpdate()
        {
            sqlConnectionString.Open();

            string billRechnungsempf = textBoxBillName.Text;
            string billText = textBoxBillText.Text;
            string billPrice = textBoxBillPrice.Text;


            string update = string.Format("update Bill set Rechnungsempfänger ='{0}', Rechnungstext ='{1}', Preis ='{2}' where Id ={3}"
                , billRechnungsempf, billText, billPrice, lastSelectedBillKey);
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

            //SqlCommand sqlCommand3 = new SqlCommand(delete, sqlConnectionString);

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

            DGVBill.Columns[0].Visible = false;

            sqlConnectionString.Close();
        }

        private void DGVBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxBillName.Text = DGVBill.SelectedRows[0].Cells[1].Value.ToString();
            textBoxBillText.Text = DGVBill.SelectedRows[0].Cells[2].Value.ToString();
            textBoxBillPrice.Text = DGVBill.SelectedRows[0].Cells[3].Value.ToString();

            lastSelectedBillKey = (int)DGVBill.SelectedRows[0].Cells[0].Value;
            Console.WriteLine(lastSelectedBillKey);//Test was für ID 
        }
    }
}




