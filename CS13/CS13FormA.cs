using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS13
{
    public partial class frmCS13A : Form
    {
        public frmCS13A()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void customerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }

        private void customerBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {

        }

        private void customerBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cs13databasesDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void customerBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cs13_databasesDataSet);

        }

        private void frmCS13A_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cs13_databasesDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.cs13_databasesDataSet.Customer);

        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
