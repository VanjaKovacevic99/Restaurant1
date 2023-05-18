using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restoran.models;

namespace Restoran.views
{
    public partial class AdminForm : Form
    {
        string jmb;
        public AdminForm(string jmb)
        {
            InitializeComponent();
            this.jmb = jmb;
            FillForm();
        }

      
        private void btnAddNewEmployed_Click(object sender, EventArgs e)
        {
            new NewEmployee().Show();
        }

        void FillForm()
        {
            Employee employee = db.DBRestoran.GetEmployedByJMB(jmb);
            tbUserName.Text = employee.UserName;
            dgvEmployee.EnableHeadersVisualStyles = false;
            dgvEmployee.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dgvEmployee.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            dgvEmployee.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 15, FontStyle.Bold);
            dgvEmployee.Rows.Clear();
            foreach (var p in db.DBRestoran.GetEmployees())
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p
                };
                row.CreateCells(dgvEmployee, p.Name, p.Surename, p.Type, p.Pay);
                dgvEmployee.Rows.Add(row);
              
            }
        }

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];
            Employee emmployee = (Employee)row.Tag;
            ShowDetails(emmployee.JMB);
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new FirstForm().Show();
            this.Close();
        }

        

        private void ShowDetails(string jmb) {
            
            
            EditEmployeeForm employeeForm = new EditEmployeeForm(jmb);
            employeeForm.WindowState = FormWindowState.Normal;
            employeeForm.BringToFront();
            employeeForm.TopMost = true;
            employeeForm.Focus();

            employeeForm.ShowDialog();
        }

        private void showDetailsDetaljeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEmployee.SelectedRows) {
                Employee emmployee = (Employee)row.Tag;
                ShowDetails(emmployee.JMB);
            }

        }

        private void cmsEmployee_Opening(object sender, CancelEventArgs e)
        {
            deleteToolStripMenuItem.Enabled = dgvEmployee.SelectedRows.Count > 0;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEmployee.SelectedRows)
            {
                Employee emmployee = (Employee)row.Tag;
                db.DBRestoran.DeleteEmployeeByJMB(emmployee.JMB);
               dgvEmployee.Rows.RemoveAt(row.Index);

            }
        }

    }
}
