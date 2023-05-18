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
    public partial class NewOrderForm : Form
    {
        string jmb;
        List<Article> articles = new List<Article>();
        List<Table> tables = new List<Table>();
        List<Article> order = new List<Article>();
        List<int> quantity = new List<int>();
        public NewOrderForm(string jmb)
        {
            InitializeComponent();
            this.jmb = jmb;
            FillForm();
        }

        private void FillForm() {
            tables = db.DBRestoran.GetTables();
            foreach(Table table in tables){
                cbNumberOfTable.Items.Add(table.TableNumber);
            }
            articles = db.DBRestoran.GetArticlesForOrder();
            foreach (Article article in articles) {
                cbArticle.Items.Add(article.Name);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int index = -1;
            if (cbArticle.SelectedIndex > -1)
            {
                index = order.IndexOf(articles[cbArticle.SelectedIndex]);
                if (cbArticle.SelectedIndex > -1 && nudQuantity.Value > 0 && index == -1)
                {
                    string[] row = { articles[cbArticle.SelectedIndex].Name, nudQuantity.Value.ToString() };
                    var listViewItem = new ListViewItem(row);
                    lvOrder.Items.Add(listViewItem);
                    Console.WriteLine("aaaa" + cbArticle.SelectedIndex);
                    Console.WriteLine("id" + articles[cbArticle.SelectedIndex].Id);
                    order.Add(articles[cbArticle.SelectedIndex]);
                    quantity.Add(Decimal.ToInt32(nudQuantity.Value));
                }
                else
                {
                    string[] row = { articles[cbArticle.SelectedIndex].Name, nudQuantity.Value.ToString() };
                    var listViewItem = new ListViewItem(row);
                    lvOrder.Items.Add(listViewItem);
                    quantity[index] += Decimal.ToInt32(nudQuantity.Value);

                }
            }
            else {
                MessageBox.Show("Izaberite artikal!");
            }
        }

        private void cmsOrder_Opening(object sender, CancelEventArgs e)
        {
            deleteToolStripMenuItem.Enabled = lvOrder.SelectedItems.Count > 0;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvOrder.SelectedItems) {
                order.RemoveAt(lvi.Index);
                quantity.RemoveAt(lvi.Index);
                lvi.Remove();
                

            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
             foreach (ListViewItem lvi in lvOrder.Items) {
                lvi.Selected= true;

            }

        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (cbNumberOfTable.SelectedIndex == -1) {
                MessageBox.Show("Niste izabrali broj stola!");
            }
            else if (order.Count == 0) {
                MessageBox.Show("Dodajete artikle na narudžbu!");
            }
            else {
                int index=db.DBRestoran.InsertOrder(jmb, tables[cbNumberOfTable.SelectedIndex].Id);

                for (int i = 0; i < order.Count; i++) {
                    Console.WriteLine(order.Count);
                    Console.WriteLine(order[i].Id);
                    db.DBRestoran.InsertOrderArticle(new OrderArticle(index, order[i].Id, order[i].SalePrice, quantity[i]));
                   }
                order.Clear();
                quantity.Clear();
                lvOrder.Items.Clear();

            }
        }
    }
}
