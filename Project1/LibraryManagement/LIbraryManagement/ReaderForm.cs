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

namespace LIbraryManagement
{
    public partial class ReaderForm : Form
    {
        public ReaderForm()
        {
            InitializeComponent();
        }

        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;

        public void showGRD(string sql)
        {
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            readerListGridView.DataSource = tb;
            readerListGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReaderForm_Load(object sender, EventArgs e)
        {
            string con = "initial catalog = LibraryManagement; data source = LAPTOP-EO9R0JT3\\SQLEXPRESS; integrated security = true";
            cn = new SqlConnection(con);
            cn.Open();

            string sql = "select * from docgia";
            showGRD(sql);

            readerInfoBoxStatus(false);
            deleteButton.Enabled = false;
            editButton.Enabled = false;
            saveButton.Enabled = false;
        }
   


        private void cancelButton_Click(object sender, EventArgs e)
        {
            ReaderForm_Load(sender, e);
        }

        public void readerInfoBoxStatus(bool status)
        {
            readerIDTextBox.Enabled = status;
            nameTextBox.Enabled = status;
            dobBox.Enabled = status;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            readerInfoBoxStatus(true);
            readerIDTextBox.Clear();
            readerIDTextBox.Focus();
            nameTextBox.Clear();
            saveButton.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            readerInfoBoxStatus(true);
            readerIDTextBox.Enabled = false;
            saveButton.Enabled = true;
            nameTextBox.Focus();
        }

        private void readerListGridView_Click(object sender, EventArgs e)
        {
            readerInfoBoxStatus(false);
            if (readerListGridView.CurrentRow.Cells[0].Value != null)
            {
                readerIDTextBox.Text = readerListGridView.CurrentRow.Cells[0].Value.ToString();
                nameTextBox.Text = readerListGridView.CurrentRow.Cells[1].Value.ToString();
                DateTime date = DateTime.Parse(readerListGridView.CurrentRow.Cells[2].Value.ToString());
                dobBox.Value = date;

                editButton.Enabled = true;
                deleteButton.Enabled = true;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                string command = $"delete from docgia where DID = \'{readerListGridView.CurrentRow.Cells[0].Value}\'";
                cm = new SqlCommand(command, cn);
                cm.ExecuteNonQuery();
                ReaderForm_Load(sender, e);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (readerIDTextBox.Enabled)
            {
                string readerInfo = $"\'{readerIDTextBox.Text}\',N\'{nameTextBox.Text}\',\'{dobBox.Value}\'";
                string command = $"insert into docgia values ({ readerInfo })";
                cm = new SqlCommand(command, cn);
                cm.ExecuteNonQuery();
            }
            else
            {
                string readerInfo = $"Name = N\'{nameTextBox.Text}\',dob = \'{dobBox.Value}\'";
                string command = $"update docgia set { readerInfo } WHERE DID = \'{readerIDTextBox.Text}\'";
                cm = new SqlCommand(command, cn);
                cm.ExecuteNonQuery();
            }

            ReaderForm_Load(sender, e);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ReaderForm_Load(sender, e);
            string name = searchNameTextBox.Text;
            string sql = $"select * from docgia where name like N\'%{ name }%\'";
            
            showGRD(sql);
        }

    }
}