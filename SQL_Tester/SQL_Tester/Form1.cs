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

namespace SQL_Tester
{
    public partial class frmSqlTester : Form
    {
        public frmSqlTester()
        {
            InitializeComponent();
        }

        SqlConnection testDatabase;

        private void frmSqlTester_Load(object sender, EventArgs e)
        {
            // connect to test database
            testDatabase = new SqlConnection("Data Source=.\\MSSQLSERVER1; Database= GDB_GBL1_100; Integrated Security=True; Connect Timeout=30;");
            testDatabase.Open();
        }

        private void frmSqlTester_FormClosing(object sender, FormClosedEventArgs e)
        {
            // on form close, close and dispose DB
            testDatabase.Close();
            testDatabase.Dispose();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            SqlCommand resultsCommand = null;
            SqlDataAdapter resultsAdapter = new SqlDataAdapter();

            DataTable resultsTable = new DataTable();

            try
            {
                // establish command object and data adapter
                resultsCommand = new SqlCommand(txtSQLTester.Text, testDatabase);
                resultsAdapter.SelectCommand = resultsCommand;
                resultsAdapter.Fill(resultsTable);

                // bind grid view to data table
                grdSQLTester.DataSource = resultsTable;
                lblRecords.Text = resultsTable.Rows.Count.ToString();
            }

            catch (Exception ex)
            {
                // Show error to user otherwise
                MessageBox.Show(ex.Message, "Error in Processing SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // dispose all
            resultsCommand.Dispose();
            resultsAdapter.Dispose();
            resultsTable.Dispose();
        }
    }
}
