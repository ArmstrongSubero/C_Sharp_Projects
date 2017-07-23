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

namespace Traders_Database_SQL
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        // form level declarations for new data objects
        SqlConnection NWindConnection;
        SqlCommand customersCommand;
        SqlDataAdapter customersAdapter;
        DataTable customersTable;
        CurrencyManager customersManager;

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            // connect to NWind database
            try
            {
                NWindConnection = new SqlConnection("Data Source=.\\MSSQLSERVER1; AttachDbFilename=C:\\Users\\armst\\Desktop\\C# Programs\\SQLNwind.mdf; Integrated Security = True; Connect Timeout = 30;");
            }

            // if connection uncessful alert user
            catch (Exception)
            {
                MessageBox.Show("Error connecting to database");
            }

            // open the connection
            NWindConnection.Open();

            // establish command object
            customersCommand = new SqlCommand("SELECT * FROM Customers", NWindConnection);

            // establish data adapter/data table
            customersAdapter = new SqlDataAdapter();

            // select the created customers command 
            customersAdapter.SelectCommand = customersCommand;
            customersTable = new DataTable();
            customersAdapter.Fill(customersTable);

            // bind controls to the datatable
            txtCustomerID.DataBindings.Add("Text", customersTable, "CustomerID");
            txtCompanyName.DataBindings.Add("Text", customersTable, "CompanyName");
            txtContactName.DataBindings.Add("Text", customersTable, "ContactName");
            txtContactTitle.DataBindings.Add("Text", customersTable, "ContactTitle");

            // establish currency manager
            customersManager = (CurrencyManager)BindingContext[customersTable];

            // close the connection
            NWindConnection.Close();

            // dispose of the connection object
            NWindConnection.Dispose();
            customersCommand.Dispose();
            customersAdapter.Dispose();
            customersTable.Dispose();

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            customersManager.Position = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            customersManager.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            customersManager.Position++;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            customersManager.Position = customersManager.Count - 1;
        }
    }
}
