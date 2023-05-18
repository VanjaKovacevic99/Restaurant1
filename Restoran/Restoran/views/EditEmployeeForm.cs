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
using Restoran.db;

namespace Restoran.views
{
    public partial class EditEmployeeForm : Form
    {
        Employee employee;
        public EditEmployeeForm(string jmb)
        {
            InitializeComponent();
            FillGrid(jmb);
        }
     

        private void FillGrid(string jmb)
        {
            Console.WriteLine(jmb);
            employee = DBRestoran.GetEmployedByJMB(jmb);
            Console.WriteLine(employee.JMB + employee.Name);

             tbJMB.Text = employee.JMB;
            tbName.Text = employee.Name;
            tbSurename.Text = employee.Surename;
            tbPhone.Text = employee.Phone;
            tbPay.Text = employee.Pay.ToString();
            tbAddress.Text = employee.Address;
            tbBanckAccaunt.Text = employee.BanckAccaunt;
            tbUserName.Text = employee.UserName;
            dtpDateOfBirth.Value = employee.DateOfBirth;
            dtpDateOfBirth.Enabled = false;
            dtpDateOfEmployment.Enabled = false;
            dtpDateOfEmployment.Value = employee.DateOfEmployment;
            cbType.Enabled = false;
            cbType.Text = employee.Type;
            tbJMB.ReadOnly = true;
            tbName.ReadOnly = true;
            tbSurename.ReadOnly = true;
            tbPhone.ReadOnly = true;
            tbAddress.ReadOnly = true;
            tbBanckAccaunt.ReadOnly = true;
            tbUserName.ReadOnly = true;
            tbPay.ReadOnly = true;




        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            tbJMB.Enabled = true;
            dtpDateOfBirth.Enabled = true;

            dtpDateOfEmployment.Enabled = true;
            cbType.Enabled = true;
            tbName.ReadOnly = false;
            tbSurename.ReadOnly = false;
            tbPhone.ReadOnly = false;
            tbAddress.ReadOnly = false;
            tbBanckAccaunt.ReadOnly = false;
            tbUserName.ReadOnly = false;
            tbPay.ReadOnly = false;
            cbType.Items.AddRange(NewEmployee.employeType);

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

        }
    }
}
