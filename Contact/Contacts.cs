using Contact.ContactClasses;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Contact
{
    public partial class Contacts : Form
    {
        public Contacts()
        {
            InitializeComponent();
        }

        contactClass c = new contactClass();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load on Data Grid View
            DataTable dt = c.Select();

            dgvContactList.DataSource = dt;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get the Value From input Fields
            c.FirstName = txtBoxFirstName.Text;
            c.LastName = txtBoxLastName.Text;
            c.ContactNo = txtBoxContactNo.Text;
            c.Address = txtBoxAddress.Text;
            c.Gender = comboBoxGender.Text;

            //Inserting data into database
            bool success = c.Insert(c);
            if (success)
            {
                //Successfully Insertd
                MessageBox.Show("New Contact Successfully Inserted");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to insert data for some reason. Please try again");
            }

            //Load on Data Grid View
            DataTable dt = c.Select();

            dgvContactList.DataSource = dt;

        }

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{

        //}

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Clear()
        {
            txtBoxContactID.Text = "";
            txtBoxFirstName.Text = "";
            txtBoxLastName.Text = "";
            txtBoxContactNo.Text = "";
            txtBoxAddress.Text = "";
            comboBoxGender.Text = "";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get the data from the Text Box
            c.ContactID = Convert.ToInt32(txtBoxContactID.Text);
            bool Success = c.Delete(c);
            if (Success)
            {
                MessageBox.Show("Contact Successfully Daleted ");
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;

                Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete the Contact");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get the Data from textBoxes

            c.ContactID = int.Parse(txtBoxContactID.Text);

            c.FirstName = txtBoxFirstName.Text;
            c.LastName = txtBoxLastName.Text;
            c.ContactNo = txtBoxContactNo.Text;
            c.Address = txtBoxAddress.Text;
            c.Gender = comboBoxGender.Text;

            //Update the data in database
            //MessageBox.Show("button work");
            bool Success = c.Update(c);
            if (Success == true)
            {
                //Updated Successfully
                MessageBox.Show("Contacts has been updated Successfully");

                //Load on Data Grid View
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;

                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Update the Contact for Some reason. Please tyr again later ");
            }

        }

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the Data from Data Grid View and Load it to form
            //identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            txtBoxContactID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            txtBoxFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            txtBoxLastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            txtBoxContactNo.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            txtBoxAddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            comboBoxGender.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();


        }
        static string myConnectionString = "data source=localhost\\SQLEXPRESS; database=ContactApp; Integrated Security=True;Encrypt=False;";
        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            //Get the value from the searchbar
            string keyword = SearchBar.Text;
            SqlConnection conn = new SqlConnection(myConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM ContactTable WHERE FirstName LIKE '%" + keyword + "%' OR lastName LIKE '%" + keyword + "%' OR Address LIKE '%" + keyword + "%' OR ContactNo LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvContactList.DataSource = dt;
        }

        private void dgvContactList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
