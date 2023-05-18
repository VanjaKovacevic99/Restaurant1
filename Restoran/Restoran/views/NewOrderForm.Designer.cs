
namespace Restoran.views
{
    partial class NewOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrderForm));
            this.lbNumTable = new System.Windows.Forms.Label();
            this.cbNumberOfTable = new System.Windows.Forms.ComboBox();
            this.lbArticle = new System.Windows.Forms.Label();
            this.cbArticle = new System.Windows.Forms.ComboBox();
            this.lbNumArticle = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvOrder = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsOrder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.cmsOrder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNumTable
            // 
            resources.ApplyResources(this.lbNumTable, "lbNumTable");
            this.lbNumTable.Name = "lbNumTable";
            // 
            // cbNumberOfTable
            // 
            resources.ApplyResources(this.cbNumberOfTable, "cbNumberOfTable");
            this.cbNumberOfTable.FormattingEnabled = true;
            this.cbNumberOfTable.Name = "cbNumberOfTable";
            // 
            // lbArticle
            // 
            resources.ApplyResources(this.lbArticle, "lbArticle");
            this.lbArticle.Name = "lbArticle";
            // 
            // cbArticle
            // 
            resources.ApplyResources(this.cbArticle, "cbArticle");
            this.cbArticle.FormattingEnabled = true;
            this.cbArticle.Name = "cbArticle";
            // 
            // lbNumArticle
            // 
            resources.ApplyResources(this.lbNumArticle, "lbNumArticle");
            this.lbNumArticle.Name = "lbNumArticle";
            // 
            // nudQuantity
            // 
            resources.ApplyResources(this.nudQuantity, "nudQuantity");
            this.nudQuantity.Name = "nudQuantity";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvOrder
            // 
            this.lvOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvOrder.ContextMenuStrip = this.cmsOrder;
            this.lvOrder.FullRowSelect = true;
            this.lvOrder.HideSelection = false;
            resources.ApplyResources(this.lvOrder, "lvOrder");
            this.lvOrder.Name = "lvOrder";
            this.lvOrder.UseCompatibleStateImageBehavior = false;
            this.lvOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // cmsOrder
            // 
            this.cmsOrder.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.cmsOrder.Name = "contextMenuStrip1";
            resources.ApplyResources(this.cmsOrder, "cmsOrder");
            this.cmsOrder.Opening += new System.ComponentModel.CancelEventHandler(this.cmsOrder_Opening);
            // 
            // deleteToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            resources.ApplyResources(this.selectAllToolStripMenuItem, "selectAllToolStripMenuItem");
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.btnCreateOrder, "btnCreateOrder");
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.lbTitle);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lbTitle
            // 
            resources.ApplyResources(this.lbTitle, "lbTitle");
            this.lbTitle.Name = "lbTitle";
            // 
            // NewOrderForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.lvOrder);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lbNumArticle);
            this.Controls.Add(this.cbArticle);
            this.Controls.Add(this.lbArticle);
            this.Controls.Add(this.cbNumberOfTable);
            this.Controls.Add(this.lbNumTable);
            this.Name = "NewOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.cmsOrder.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNumTable;
        private System.Windows.Forms.ComboBox cbNumberOfTable;
        private System.Windows.Forms.Label lbArticle;
        private System.Windows.Forms.ComboBox cbArticle;
        private System.Windows.Forms.Label lbNumArticle;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvOrder;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip cmsOrder;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitle;
    }
}