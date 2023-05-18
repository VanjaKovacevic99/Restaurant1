
namespace Restoran.views
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnViewOrderForSuppliers = new System.Windows.Forms.Button();
            this.btnAddNewOrderForSuppliers = new System.Windows.Forms.Button();
            this.btnAddNewOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvUserForm = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnViewOrderForSuppliers);
            this.panel1.Controls.Add(this.btnAddNewOrderForSuppliers);
            this.panel1.Controls.Add(this.btnAddNewOrder);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnLogOut, "btnLogOut");
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnViewOrderForSuppliers
            // 
            this.btnViewOrderForSuppliers.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViewOrderForSuppliers.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnViewOrderForSuppliers, "btnViewOrderForSuppliers");
            this.btnViewOrderForSuppliers.ForeColor = System.Drawing.Color.Black;
            this.btnViewOrderForSuppliers.Name = "btnViewOrderForSuppliers";
            this.btnViewOrderForSuppliers.UseVisualStyleBackColor = false;
            // 
            // btnAddNewOrderForSuppliers
            // 
            this.btnAddNewOrderForSuppliers.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddNewOrderForSuppliers.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAddNewOrderForSuppliers, "btnAddNewOrderForSuppliers");
            this.btnAddNewOrderForSuppliers.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewOrderForSuppliers.Name = "btnAddNewOrderForSuppliers";
            this.btnAddNewOrderForSuppliers.UseVisualStyleBackColor = false;
            this.btnAddNewOrderForSuppliers.Click += new System.EventHandler(this.btnAddNewOrderForSuppliers_Click);
            // 
            // btnAddNewOrder
            // 
            this.btnAddNewOrder.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddNewOrder.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAddNewOrder, "btnAddNewOrder");
            this.btnAddNewOrder.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewOrder.Name = "btnAddNewOrder";
            this.btnAddNewOrder.UseVisualStyleBackColor = false;
            this.btnAddNewOrder.Click += new System.EventHandler(this.btnAddNewOrder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.tbUserName);
            this.panel2.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.SlateGray;
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbUserName, "tbUserName");
            this.tbUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbUserName.Name = "tbUserName";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.dgvUserForm);
            this.panel3.Cursor = System.Windows.Forms.Cursors.PanNW;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // dgvUserForm
            // 
            this.dgvUserForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvUserForm, "dgvUserForm");
            this.dgvUserForm.Name = "dgvUserForm";
            this.dgvUserForm.RowTemplate.Height = 24;
            // 
            // UserForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnViewOrderForSuppliers;
        private System.Windows.Forms.Button btnAddNewOrderForSuppliers;
        private System.Windows.Forms.Button btnAddNewOrder;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.DataGridView dgvUserForm;
    }
}