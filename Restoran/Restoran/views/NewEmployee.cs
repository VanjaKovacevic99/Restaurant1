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
    public partial class NewEmployee : Form
    {
        public static string[] employeType = { "Administrator", "Korisnik" };
        public NewEmployee()
        {
            InitializeComponent();
            dtpDateOfBirth.Value.ToString("1990-01-01");
        }

        private void cbAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            if (tbJMB.Text != "" && tbName.Text != "" && tbPassword.Text != "" && tbPay.Text != "" && tbPhoneNumber.Text != "" && tbSurename.Text != "" && tbUserName.Text != "" && tbAddress.Text != "" && tbBanckAccaunt.Text != "" && ((cbAdmin.Checked && !cbUser.Checked) || (!cbAdmin.Checked && cbUser.Checked)))
            {
                employee.JMB = tbJMB.Text;
                employee.Name = tbName.Text;
                employee.Surename = tbSurename.Text;
                decimal pay1;
                Decimal.TryParse(tbPay.Text, out pay1);
                employee.Pay = pay1;
                employee.BanckAccaunt = tbBanckAccaunt.Text;
                if (cbAdmin.Checked)
                {
                    employee.Type = employeType[0];

                }
                else
                {
                    employee.Type = employeType[1];
                }
                employee.Phone = tbPhoneNumber.Text;
                employee.UserName = tbUserName.Text;
                employee.Password = tbPassword.Text;
                employee.DateOfBirth = dtpDateOfBirth.Value;
                employee.DateOfEmployment = dtpDateOfEmployment.Value;
                employee.Address = tbAddress.Text;
                if (db.DBRestoran.InsertEmployee(employee) != -1)
                {
                    CleanForm();

                }



            }
            else
            {

                MessageBox.Show("Niste dobro unijeli podatke !", "Upozorenje", MessageBoxButtons.OK);
            }
        }
        private void CleanForm()
        {

            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";
        }

        private void tbJMB_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbJMB.Text, "[^0-9]"))
            {
                MessageBox.Show("Molimo vas unosite samo brojeve.");
                tbJMB.Text = tbJMB.Text.Remove(tbJMB.Text.Length - 1);
                tbJMB.MaxLength = 13;
            }
        }

        private void tbPay_TextChanged(object sender, EventArgs e)
        {//@"[\d]{ 1,4} ([.,][\d]{ 1,2})?"
            if (System.Text.RegularExpressions.Regex.IsMatch(tbPay.Text, "[^0 - 9]{1,6}"))
            {
                MessageBox.Show("Molimo vas unosite u formatu xxxxxx.xx !");
                tbPay.Text = tbPay.Text.Remove(tbPay.Text.Length - 1);
                tbPay.MaxLength = 8;
            }

        }
    }
    

}
