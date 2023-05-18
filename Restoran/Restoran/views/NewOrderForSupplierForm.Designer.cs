
namespace Restoran.views
{
    partial class NewOrderForSupplierForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitleForSupplier = new System.Windows.Forms.Label();
            this.lbSupplier = new System.Windows.Forms.Label();
            this.lbArticle = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cbArticle = new System.Windows.Forms.ComboBox();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.lbTitleForSupplier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 89);
            this.panel1.TabIndex = 0;
            // 
            // lbTitleForSupplier
            // 
            this.lbTitleForSupplier.AutoSize = true;
            this.lbTitleForSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleForSupplier.Location = new System.Drawing.Point(108, 23);
            this.lbTitleForSupplier.Name = "lbTitleForSupplier";
            this.lbTitleForSupplier.Size = new System.Drawing.Size(562, 38);
            this.lbTitleForSupplier.TabIndex = 0;
            this.lbTitleForSupplier.Text = "Kreirajte novu narudžbu dobavljaču";
            // 
            // lbSupplier
            // 
            this.lbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSupplier.Location = new System.Drawing.Point(12, 120);
            this.lbSupplier.Name = "lbSupplier";
            this.lbSupplier.Size = new System.Drawing.Size(136, 33);
            this.lbSupplier.TabIndex = 2;
            this.lbSupplier.Text = "Dobavljač:";
            // 
            // lbArticle
            // 
            this.lbArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArticle.Location = new System.Drawing.Point(12, 171);
            this.lbArticle.Name = "lbArticle";
            this.lbArticle.Size = new System.Drawing.Size(136, 33);
            this.lbArticle.TabIndex = 3;
            this.lbArticle.Text = "Artikal:";
            // 
            // lbQuantity
            // 
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(12, 228);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(136, 33);
            this.lbQuantity.TabIndex = 4;
            this.lbQuantity.Text = "Količina:";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(93, 307);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(600, 173);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // cbArticle
            // 
            this.cbArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArticle.FormattingEnabled = true;
            this.cbArticle.Location = new System.Drawing.Point(177, 171);
            this.cbArticle.Margin = new System.Windows.Forms.Padding(4);
            this.cbArticle.Name = "cbArticle";
            this.cbArticle.Size = new System.Drawing.Size(405, 33);
            this.cbArticle.TabIndex = 6;
            // 
            // cbSupplier
            // 
            this.cbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(177, 120);
            this.cbSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(405, 33);
            this.cbSupplier.TabIndex = 7;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(177, 226);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(113, 30);
            this.nudQuantity.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(407, 223);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 33);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrder.Location = new System.Drawing.Point(285, 503);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(170, 43);
            this.btnCreateOrder.TabIndex = 10;
            this.btnCreateOrder.Text = "Kreiraj narudžbu";
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            // 
            // NewOrderForSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(782, 568);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.cbArticle);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbArticle);
            this.Controls.Add(this.lbSupplier);
            this.Controls.Add(this.panel1);
            this.Name = "NewOrderForSupplierForm";
            this.Text = "RestoranApp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitleForSupplier;
        private System.Windows.Forms.Label lbSupplier;
        private System.Windows.Forms.Label lbArticle;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox cbArticle;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCreateOrder;
    }
}