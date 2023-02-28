using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LibraryManagement
{
    public partial class BorrowForm : Form
    {
        public BorrowForm()
        {
            InitializeComponent();
        }

        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;


        private void BorrowForm_Load(object sender, EventArgs e)
        {
            borrowDateBox.Enabled = false;
            borrowIDTextBox.Enabled = false;

            returnButton.Enabled = false;
            return_cancelButton.Enabled = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string PID = searchBorrowIDTextBox.Text;
            string sql = $"select * from phieumuon where PID = \'{PID}\'";

            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            borrowGridView.DataSource = tb;
            borrowGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if(borrowGridView.Rows[0].Cells[0].Value.ToString() == null)
            {
                MessageBox.Show("PID doesn't exist!");
            }
            else
            {
                returnButton.Enabled = true;
                return_cancelButton.Enabled = true;
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            string PID = borrowGridView.Rows[0].Cells[0].Value.ToString();
            string sql = $"select * from phieumuon where PID = \'1\'";

            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            borrowGridView.DataSource = tb;
            borrowGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            string cmd = $"delete from phieumuon where PID = \'{PID}\'";
            cm = new SqlCommand(cmd, cn);
            cm.ExecuteNonQuery();

            MessageBox.Show("Return success");
        }

        private void return_cancelButton_Click(object sender, EventArgs e)
        {
            searchBorrowIDTextBox.Clear();

            string sql = $"select * from phieumuon where PID = \'1\'";

            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            borrowGridView.DataSource = tb;
            borrowGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            readerIDTextBox.Clear();
            bookIDTextBox.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
