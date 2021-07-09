using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));

            dataGrid.DataSource = table;

            dataGrid.Columns["Messages"].Visible = false;
            dataGrid.Columns["Title"].Width = 240;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMsg.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int index = dataGrid.CurrentCell.RowIndex;

            if (index > -1)
            { 
                txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtMsg.Text = table.Rows[index].ItemArray[1].ToString();


            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, txtMsg.Text);

            txtTitle.Clear();
            txtMsg.Clear();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGrid.CurrentCell.RowIndex;

            table.Rows[index].Delete();

        }
    }
}
