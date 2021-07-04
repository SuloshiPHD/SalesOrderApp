using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesOrderApp
{
    public partial class HomePage : Form
    {
        DBAccess dbaccess = new DBAccess();
        DataTable dtorderDetails = new DataTable();

        public HomePage()
        {
            InitializeComponent();
        }


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            SalesOrderPage salesPage = new SalesOrderPage();
            this.Hide();
            salesPage.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            string selectQuery = "Select * from dbo.OrderTable";
            dbaccess.readDatathroughAdapter(selectQuery, dtorderDetails);

            foreach(DataRow item in dtorderDetails.Rows)
            {
                int n = dgvHomePage.Rows.Add();
                string cusId = item["CustomerID"].ToString(); ;
                string selectCusName = "Select Name from dbo.Client where DCLInk= '" + cusId + "'";
                DataTable dtCusName = new DataTable();
                dbaccess.readDatathroughAdapter(selectCusName, dtCusName);

                foreach (DataRow item2 in dtCusName.Rows)
                {
                    dgvHomePage.Rows[n].Cells[0].Value = item2["Name"].ToString();
                }
                                   
                dgvHomePage.Rows[n].Cells[1].Value = item["InvoiceNo"].ToString();
                dgvHomePage.Rows[n].Cells[2].Value = item["InvoiceDate"].ToString();
                dgvHomePage.Rows[n].Cells[3].Value = item["InvoiceReferenceNo"].ToString();
                dgvHomePage.Rows[n].Cells[4].Value = item["InvoiceNote"].ToString();
            }
        }
         //TODO : add double cilck event to populate data and allow to update, delete 
        private void dgvHomePage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SalesOrderPage salesOrderPage = new SalesOrderPage();

            //salesOrderPage.txtInvoiceNo.Text = this.dgvHomePage.CurrentRow.Cells[1].Value.ToString();


        }

      /*
       * private void btnUpdate_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["SalesOrder.Properties.Settings.masterConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            sqlconn.Open();

            string sqlquery = "update [dbo].[Invoice] set InvoiceNumber = '" + Convert.ToInt32(txtBoxInvoiceNo.Text) + "', CustomerName = '" + comboBox1.Text.ToString() + "', InvoiceDate = '" + dateTimePicker1.Value.Date + "', ExclAmount = '" + float.Parse(txtBoxTotExcl.Text) + "', TaxAMount = '" + float.Parse(txtBoxTotTax.Text) + "', InclAmount = '" + float.Parse(txtBoxTotIncl.Text) + "' where InvoiceNumber = '" + Convert.ToInt32(txtBoxInvoiceNo.Text) + "'";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);

            sqlcomm.ExecuteNonQuery();
            MessageBox.Show("Updated");

            sqlconn.Close();
            this.Visible = false;
            Form2 f2 = new Form2();
            f2.Visible = true;
        }
      */
    }
}
