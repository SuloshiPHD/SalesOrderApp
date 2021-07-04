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
using CrystalDecisions.CrystalReports.Engine;

namespace SalesOrderApp
{
    public partial class PrintReport : Form
    {
        DBAccess dbaccess = new DBAccess();
        DataTable dtReportDetails = new DataTable();

        ReportDocument crypt = new ReportDocument();
        public PrintReport()
        {
            InitializeComponent();
        }

        private void PrintReport_Load(object sender, EventArgs e)
        {
            string selectQuery = "Select * from dbo.OrderTable";
            dbaccess.readDatathroughAdapter(selectQuery, dtReportDetails);

            SalesOrderCrystalReport rpt = new SalesOrderCrystalReport();
            rpt.SetDataSource(dtReportDetails);
            crystalReportViewer1.ReportSource = rpt;

        }
    }
}
