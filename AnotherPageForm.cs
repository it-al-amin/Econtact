using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Econtact
{
    public partial class AnotherPageForm : Form
    {
        public AnotherPageForm()
        {
            InitializeComponent();
        }
     
        

        // Method to load data into the DataGridView
        public void LoadData(DataRow dt)
        {
            //Create a new DataTable with specific columns
            DataTable newDataTable = new DataTable();
            newDataTable.Columns.Add("ContactID", typeof(int)); // Assuming ContactID is of type int
            newDataTable.Columns.Add("FirstName", typeof(string));
            newDataTable.Columns.Add("LastName", typeof(string));
            newDataTable.Columns.Add("ContactNo", typeof(string));
            newDataTable.Columns.Add("Address", typeof(string));
            newDataTable.Columns.Add("Gender", typeof(string));

            // Add the specific DataRow to the new DataTable
            DataRow newRow = newDataTable.NewRow();
            newRow["ContactID"] = dt["ContactID"]; // Assuming ContactID is of type int
            newRow["FirstName"] = dt["FirstName"];
            newRow["LastName"] = dt["LastName"];
            newRow["ContactNo"] = dt["ContactNo"];
            newRow["Address"] = dt["Address"];
            newRow["Gender"] = dt["Gender"];
            newDataTable.Rows.Add(newRow);//Add the newRow data at DataTable

            // Set the DataGridView's DataSource to the new DataTable
            dataGridView.DataSource = newDataTable;
        }
        
    }
}
