using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SalesOrderApp
{
    public partial class SalesOrderPage : Form
    {

        DBAccess dbaccess = new DBAccess();
        DataTable dtCustomers = new DataTable();


        public SalesOrderPage()
        {
            InitializeComponent();
            FillCustomerNameCmb();
            PopulateItemCodeCmb();
            PopulateItemDesCmb();
        }

        void FillCustomerNameCmb()
        {
            string selectQuery = "Select * from dbo.Client";
            dbaccess.readDatathroughAdapter(selectQuery, dtCustomers);

            if (dtCustomers.Rows.Count > 0)
            {

                dbaccess.closeConn();
                DataRow itemRow = dtCustomers.NewRow();
                itemRow[1] = " ";
                dtCustomers.Rows.InsertAt(itemRow, 0);

                cmbCusName.DataSource = dtCustomers;
                cmbCusName.DisplayMember = "Name";
                cmbCusName.ValueMember = "DCLink";
            }

        }

        void PopulateItemCodeCmb()
        {
            string itemQry = "Select * from dbo.StkItem";
            DataTable dtItems = new DataTable();
            dbaccess.readDatathroughAdapter(itemQry, dtItems);

            if (dtItems.Rows.Count > 0)
            {

                dbaccess.closeConn();
                DataRow itemRow = dtItems.NewRow();
                itemRow[1] = " ";
                dtItems.Rows.InsertAt(itemRow, 0);

                dgcmbItemCode.DataSource = dtItems;
                dgcmbItemCode.DisplayMember = "Code";
                dgcmbItemCode.ValueMember = "StockLink";
            }
        }

        void PopulateItemDesCmb()
        {
            string itemQry = "Select * from dbo.StkItem";
            DataTable dtItems = new DataTable();
            dbaccess.readDatathroughAdapter(itemQry, dtItems);

            if (dtItems.Rows.Count > 0)
            {

                dbaccess.closeConn();
                DataRow itemRow = dtItems.NewRow();
                itemRow[1] = " ";
                dtItems.Rows.InsertAt(itemRow, 0);

                dgcmbDescription.DataSource = dtItems;
                dgcmbDescription.DisplayMember = "Description_1";
                dgcmbDescription.ValueMember = "StockLink";
            }
        }

        private void cmbCusName_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedCusID = cmbCusName.SelectedValue.ToString();

            if (cmbCusName.SelectedValue.ToString() != null)
            {
                if (selectedCusID != "System.Data.DataRowView")
                {
                    string query = "Select * from dbo.Client Where DCLInk= '" + selectedCusID + "'";

                    DataTable dtSelectedCustomers = new DataTable();
                    dbaccess.readDatathroughAdapter(query, dtSelectedCustomers);

                    if (dtSelectedCustomers.Rows.Count > 0)
                    {
                        dbaccess.closeConn();
                        txtAdd1.Text = dtSelectedCustomers.Rows[0]["Physical1"].ToString();
                        txtAdd2.Text = dtSelectedCustomers.Rows[0]["Physical2"].ToString();
                        txtAdd3.Text = dtSelectedCustomers.Rows[0]["Physical3"].ToString();
                        txtSuburb.Text = dtSelectedCustomers.Rows[0]["Physical4"].ToString();
                        txtState.Text = dtSelectedCustomers.Rows[0]["Physical5"].ToString();
                        txtPostCode.Text = dtSelectedCustomers.Rows[0]["PhysicalPC"].ToString();
                    }
                }
            }


        }

        private void dgvItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //adding decimal places to price column 
            if (e.ColumnIndex == 4 && e.RowIndex != this.dgvItems.NewRowIndex)
            {
                if (dgvItems.Rows[e.RowIndex].Cells[4].Value != null)
                {

                    double val1 = double.Parse(e.Value.ToString());
                    e.Value = val1.ToString("N2");
                }
            }
            if (e.ColumnIndex == 6 && e.RowIndex != this.dgvItems.NewRowIndex)
            {
                if (dgvItems.Rows[e.RowIndex].Cells[6].Value != null)
                {

                    double val1 = double.Parse(e.Value.ToString());
                    e.Value = val1.ToString("N2");
                }
            }
            if (e.ColumnIndex == 7 && e.RowIndex != this.dgvItems.NewRowIndex)
            {
                if (dgvItems.Rows[e.RowIndex].Cells[7].Value != null)
                {

                    double val1 = double.Parse(e.Value.ToString());
                    e.Value = val1.ToString("N2");
                }
            }
                
        }

        private void dgvItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // calculating Excl, Tax amount, Incl amount in Total for each product
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                row.Cells[dgvItems.Columns["dgtxtExcl"].Index].Value = (Convert.ToDouble(row.Cells[dgvItems.Columns["dgtxtQty"].Index].Value) * Convert.ToDouble(row.Cells[dgvItems.Columns["dgtxtPrice"].Index].Value));
                row.Cells[dgvItems.Columns["dgtxtTaxAmount"].Index].Value = (Convert.ToDouble(row.Cells[dgvItems.Columns["dgtxtExcl"].Index].Value) * Convert.ToDouble(row.Cells[dgvItems.Columns["dgtxtTax"].Index].Value) / 100);

                row.Cells[dgvItems.Columns["dgtxtInclAmount"].Index].Value = (Convert.ToDouble(row.Cells[dgvItems.Columns["dgtxtExcl"].Index].Value) + Convert.ToDouble(row.Cells[dgvItems.Columns["dgtxtTaxAmount"].Index].Value));
            }

            //calculating each line total value and display in the fields
            double totExcl = 0;
            double totTax = 0;
            double totIncl = 0;

            for (int i = 0; i < dgvItems.Rows.Count; ++i)
            {
                totExcl += Convert.ToDouble(dgvItems.Rows[i].Cells[6].Value);
                totTax += Convert.ToDouble(dgvItems.Rows[i].Cells[7].Value);
                totIncl += Convert.ToDouble(dgvItems.Rows[i].Cells[8].Value);

            }

            txtTotExcl.Text = totExcl.ToString();
            txtTotTax.Text = totTax.ToString();
            txtTotIncl.Text = totIncl.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(cmbCusName.SelectedValue);
            int invoiceNo = Convert.ToInt32(txtInvoiceNo.Text);
            string invoiceDate = txtInvoiceDate.Text;
            string invoiceNote = txtNote.Text;
            string invoiceRefNo = txtReferenceNo.Text;
            float totExclAmt = (float)Convert.ToDouble(txtTotExcl.Text);
            float totTaxAmt = (float)Convert.ToDouble(txtTotTax.Text);
            float totInclAmt = (float)Convert.ToDouble(txtTotIncl.Text);

            if (customerId.ToString().Equals("")){
                MessageBox.Show("Please select customer name ");
            }else if (invoiceNo.Equals(""))
            {
                MessageBox.Show("Please enter invoice number ");
            }else if (invoiceDate.Equals(""))
            {
                MessageBox.Show("Please enter invoice date number ");
            }else if (invoiceRefNo.Equals(""))
            {
                MessageBox.Show("Please enter invoice date number ");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("Insert into dbo.OrderTable(CustomerId,InvoiceNo,InvoiceDate,InvoiceNote,InvoiceReferenceNo,TotExclAmt,TotTaxAmt,TotInclAmt) " +
                    "values(@customerId, @invoiceNo, @invoiceDate, @invoiceNote, @invoiceRefNo, @totExclAmt,@totTaxAmt,@totInclAmt)");
                insertCommand.Parameters.AddWithValue("@customerId", customerId);
                insertCommand.Parameters.AddWithValue("@invoiceNo", invoiceNo);
                insertCommand.Parameters.AddWithValue("@invoiceDate", invoiceDate);
                insertCommand.Parameters.AddWithValue("@invoiceNote", invoiceNote); 
                insertCommand.Parameters.AddWithValue("@invoiceRefNo", invoiceRefNo);
                insertCommand.Parameters.AddWithValue("@TotExclAmt", totExclAmt);
                insertCommand.Parameters.AddWithValue("@TotTaxAmt", totTaxAmt);
                insertCommand.Parameters.AddWithValue("@TotInclAmt", totInclAmt);


                int row = dbaccess.executeQuery(insertCommand);

                if(row == 1)
                {
                   //MessageBox.Show("Order has saved Successfully!!");
                }
            }
           

            for (int i=0; i< dgvItems.Rows.Count -1; i++)
            {
                SqlCommand cmdInsertItems = new SqlCommand(@"Insert into dbo.OrderDetail(OrderInvoiceNo,ItemCode,ItemDescription,ItemNote,Qty,Price,Tax,ExclAmount,TaxAmount,InclAmount) " +
                   "values('"+ invoiceNo +"','"+ dgvItems.Rows[i].Cells[0].Value+"', '"+ dgvItems.Rows[i].Cells[1].Value + "', '" + dgvItems.Rows[i].Cells[2].Value + "','" + dgvItems.Rows[i].Cells[3].Value + "','" + dgvItems.Rows[i].Cells[4].Value + "','" + dgvItems.Rows[i].Cells[5].Value + "','" + dgvItems.Rows[i].Cells[6].Value + "', '" + dgvItems.Rows[i].Cells[7].Value + "','" + dgvItems.Rows[i].Cells[8].Value + "')");

                int row = dbaccess.executeQuery(cmdInsertItems);

            }
            MessageBox.Show("Order has saved Successfully!!");
            this.Hide();
            PrintReport report = new PrintReport();
            report.Show();

        }

        /* TODO :
         *  
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
