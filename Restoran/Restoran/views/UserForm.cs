using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restoran.db;
using Restoran.models;

namespace Restoran.views
{
    public partial class UserForm : Form
    {
        string jmb;
        public UserForm(string jmb)
        {
            InitializeComponent();
            this.jmb = jmb;
            FillForm(jmb);
        }

        private void FillForm(string jmb) {
            Employee employee = db.DBRestoran.GetEmployedByJMB(jmb);
            tbUserName.Text = employee.UserName;
            dgvUserForm.EnableHeadersVisualStyles = false;
            dgvUserForm.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dgvUserForm.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            dgvUserForm.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 15, FontStyle.Bold);
            dgvUserForm.Rows.Clear();
           dgvUserForm.Columns[""].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            foreach (var p in db.DBRestoran.GetWaiterOrders(jmb))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p
                };
                row.CreateCells(dgvUserForm, p.Id, p.Name, p.Price,p.Quantity);
                dgvUserForm.Rows.Add(row);

            }


        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            
            new NewOrderForm(jmb).Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new FirstForm().Show();
            this.Close();
        }

        private void btnAddNewOrderForSuppliers_Click(object sender, EventArgs e)
        {

        }
    }
}
