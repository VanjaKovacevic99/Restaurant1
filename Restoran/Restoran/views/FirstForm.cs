using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restoran.db;
using Restoran.models;
using Restoran.views;

namespace Restoran
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
            
        }

  

        private void btnShowForm_Click(object sender, EventArgs e)
        {
            Employee employee = DBRestoran.GetEmployedByNameAndPass(tbUserName.Text, tbPassword.Text);
            if (employee == null)
            {
                Label mylab = new Label();
                mylab.ForeColor = Color.Red;
                mylab.Text = "Pogresno uneseno korisnicko ime ili lozinka. Molimo pokusajte ponovo. ";
                mylab.Location = new Point(318, 337);
                mylab.Size = new Size(242, 35);
                mylab.BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(mylab);
            }
            else if (employee.Type == "korisnik")
            {
                new UserForm(employee.JMB).Show();
                this.Hide();
            }
            else if (employee.Type == "administrator")
                {
                new AdminForm(employee.JMB).Show();
                this.Hide();
            }
            
        }

        private void tbUserName_KeyDown(object sender, KeyEventArgs e)
        {

            if (tbUserName.Text == "Korisnicko ime" && e.KeyCode != Keys.Back)
            {
                tbUserName.ForeColor = Color.Black;
                tbUserName.Text = "";
            }
            else if (e.KeyCode == Keys.Back && tbUserName.Text.Length == 1) {
                tbUserName.ForeColor = Color.DarkGray;
                tbUserName.Text = "Korisnicko ime";
            }
         

        }


    

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter) {
                btnShowForm.PerformClick();
            }
            if (tbPassword.Text == "Lozinka" && e.KeyCode!= Keys.Back)
            {
                tbPassword.ForeColor = Color.Black;
                tbPassword.Text = "";
                tbPassword.PasswordChar = '*';
                
            }
            else if ((e.KeyCode == Keys.Back && tbPassword.Text.Length == 1) || (e.KeyCode == Keys.Back && tbPassword.Text.Length  == 0) )
            {
                tbPassword.ForeColor = Color.DarkGray;
                tbPassword.PasswordChar = '\0';
                tbPassword.Text = "Lozinka";
               
            }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();
            changeLanguage.UpdateConfig("language", "en");
            Application.Restart();
           
        }

        private void serbianToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var changeLanguage = new ChangeLanguage();
            changeLanguage.UpdateConfig("language", "sr");
            Application.Restart();
        }
    }
}
