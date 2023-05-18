
namespace Restoran
{
    partial class FirstForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.msLenguage = new System.Windows.Forms.MenuStrip();
            this.podesavanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jezikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serbianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnShowForm = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.msLenguage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.msLenguage);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // msLenguage
            // 
            this.msLenguage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msLenguage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podesavanjaToolStripMenuItem});
            resources.ApplyResources(this.msLenguage, "msLenguage");
            this.msLenguage.Name = "msLenguage";
            // 
            // podesavanjaToolStripMenuItem
            // 
            this.podesavanjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jezikToolStripMenuItem});
            resources.ApplyResources(this.podesavanjaToolStripMenuItem, "podesavanjaToolStripMenuItem");
            this.podesavanjaToolStripMenuItem.Name = "podesavanjaToolStripMenuItem";
            // 
            // jezikToolStripMenuItem
            // 
            this.jezikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serbianToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.jezikToolStripMenuItem.Name = "jezikToolStripMenuItem";
            resources.ApplyResources(this.jezikToolStripMenuItem, "jezikToolStripMenuItem");
            // 
            // serbianToolStripMenuItem
            // 
            this.serbianToolStripMenuItem.Name = "serbianToolStripMenuItem";
            resources.ApplyResources(this.serbianToolStripMenuItem, "serbianToolStripMenuItem");
            this.serbianToolStripMenuItem.Click += new System.EventHandler(this.serbianToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // tbPassword
            // 
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // btnShowForm
            // 
            this.btnShowForm.BackColor = System.Drawing.Color.Turquoise;
            resources.ApplyResources(this.btnShowForm, "btnShowForm");
            this.btnShowForm.ForeColor = System.Drawing.Color.Black;
            this.btnShowForm.Name = "btnShowForm";
            this.btnShowForm.UseVisualStyleBackColor = false;
            this.btnShowForm.Click += new System.EventHandler(this.btnShowForm_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Black";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // tbUserName
            // 
            resources.ApplyResources(this.tbUserName, "tbUserName");
            this.tbUserName.ForeColor = System.Drawing.Color.DarkGray;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUserName_KeyDown);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // FirstForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnShowForm);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbUserName);
            this.MainMenuStrip = this.msLenguage;
            this.Name = "FirstForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.msLenguage.ResumeLayout(false);
            this.msLenguage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip msLenguage;
        private System.Windows.Forms.ToolStripMenuItem podesavanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jezikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serbianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnShowForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

