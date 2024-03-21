using Econtact.econtactClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Econtact
{
    public partial class Econtact : Form
    {
        public Econtact()
        {
            InitializeComponent();
        }
        contactClass c = new contactClass();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IblLastName_Click(object sender, EventArgs e)
        {

        }

        private void IblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void IblContactID_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get data from textBoxes
            try
            {
                c.ContactID = int.Parse(textboxContactID.Text);

                c.FirstName = textboxFirstName.Text;
                c.LastName = textboxLastName.Text;
                c.ContactNo = textboxContactNumber.Text;
                c.Address = textboxAddress.Text;
                c.Gender = cmbGender.Text;
                //Update data in the database
                bool success = c.Update(c);
                if (success == true)
                {
                    // successfully updated
                    MessageBox.Show("Data is  successfully updated");
                    //load data on gridview
                    DataTable dt = c.Select();
                    dataGridViewContactList.DataSource = dt;//data is sent to data gridview
                    clear();
                }
                else
                {
                    MessageBox.Show("Failed to update data . Try again!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("You have selected empty row . Please try again");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the contact ID from the application
            try
            {
                c.ContactID = int.Parse(textboxContactID.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("ContactID is not exist. Please try again..");
            }
            bool success = c.Delete(c);
            if (success == true)
            {
                // successfully deleted
                MessageBox.Show("Data is  successfully deleted");
                //load data on gridview
                //Refresh the data gridview
                DataTable dt = c.Select();
                dataGridViewContactList.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Failed to delete data . Try again!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get  the value from input fields
            c.FirstName = textboxFirstName.Text;
            c.LastName = textboxLastName.Text;
            c.ContactNo = textboxContactNumber.Text;
            c.Address = textboxAddress.Text;
            c.Gender = cmbGender.Text;
            // Inserting data into database using the method we created
            bool success = c.Insert(c);
            if (success == true)
            {
                // successfully inserted
                MessageBox.Show("New contact successfully inserted");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to add new contact.Try again!");
            }
            //load data on gridview
            DataTable dt = c.Select();
            dataGridViewContactList.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //call clear method
            clear();
        }

        private void textboxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxContactNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        // visit each cell and right click in it and go another page.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void textboxFirstName_TextChanged(object sender, EventArgs e)
        {

        }
        // Create DB connection
        static string myConnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void textboxSearch_TextChanged(object sender, EventArgs e)
        {
            //get the value from text box;
            string keyword = textboxSearch.Text;

            SqlConnection conn = new SqlConnection(myConnstrng);
            //create sql command
            string sql = "SELECT * FROM tbl_contact WHERE FirstName LIKE '%" + keyword + "%' OR LastName LIKE '%" + keyword + "%' OR Address LIKE '%" + keyword + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewContactList.DataSource = dt;
        }
        //close event
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //Page load event

        private void Econtact_Load(object sender, EventArgs e)
        {
            //load data on gridview
            DataTable dt = c.Select();
            dataGridViewContactList.DataSource = dt;//send all the data to the data gridview
        }
        // method to clear alll this field
        public void clear()
        {
            textboxContactID.Text = "";
            textboxFirstName.Text = "";
            textboxLastName.Text = "";
            textboxContactNumber.Text = "";
            textboxAddress.Text = "";
            cmbGender.Text = "";



        }

        private void dataGridViewContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the data from grid view and load it to the textboxes respectively
            //Identify the row on which mouse is clicked

            int rowIndex = e.RowIndex;
            textboxContactID.Text = dataGridViewContactList.Rows[rowIndex].Cells[0].Value.ToString();
            textboxFirstName.Text = dataGridViewContactList.Rows[rowIndex].Cells[1].Value.ToString();
            textboxLastName.Text = dataGridViewContactList.Rows[rowIndex].Cells[2].Value.ToString();
            textboxContactNumber.Text = dataGridViewContactList.Rows[rowIndex].Cells[3].Value.ToString();
            textboxAddress.Text = dataGridViewContactList.Rows[rowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dataGridViewContactList.Rows[rowIndex].Cells[5].Value.ToString();


        }

        private void dataGridViewContactList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewContactList_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void dataGridViewContactList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridViewContactList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Assuming you want to load another page when the cell is entered
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int rowIndex = e.RowIndex;

                // Populate your data object (assuming 'c' is an instance of your data class)
                try
                {
                    c.ContactID = int.Parse(dataGridViewContactList.Rows[rowIndex].Cells[0].Value.ToString());
                }
                catch (Exception ex)
                {
                    c.ContactID = 0;
                }
                c.FirstName = dataGridViewContactList.Rows[rowIndex].Cells[1].Value.ToString();
                c.LastName = dataGridViewContactList.Rows[rowIndex].Cells[2].Value.ToString();
                c.ContactNo = dataGridViewContactList.Rows[rowIndex].Cells[3].Value.ToString();
                c.Address = dataGridViewContactList.Rows[rowIndex].Cells[4].Value.ToString();
                c.Gender = dataGridViewContactList.Rows[rowIndex].Cells[5].Value.ToString();

                // Hide the current form
                this.Hide();
                AnotherPageForm anotherPage = new AnotherPageForm();//create an object 
               //Find all data from database 
                DataTable dt = c.Select();
                //filter specific dataRow from dataTable with ContactID
                DataRow specificRow = null;

                foreach (DataRow row in dt.Rows)
                {
                    if (row["ContactID"].ToString() == c.ContactID.ToString()) // Comparing IDs as strings
                    {
                        specificRow = row;
                        break;
                    }
                }
                if (specificRow != null) { 
                 //load data in new form 
                  anotherPage.LoadData(specificRow);
                  //MessageBox.Show($"ContactID: {specificRow["ContactID"]}");
                }
                else
                {
                   // Row with the specific ID not found
                    MessageBox.Show("There is no data to send as such ContactID is not exist..");
                }
                anotherPage.FormClosed += (s, ev) =>
                {
                    // Show the current form again when the new form is closed
                    this.Show();
                };
                anotherPage.ShowDialog(); // Show the new form as a dialog  
            }
        }

    }
}