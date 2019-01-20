namespace adopse1112
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCustomersViaIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeOpenFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(282, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openOrdersToolStripMenuItem,
            this.searchCustomersViaIDToolStripMenuItem,
            this.closeOpenFormsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // openOrdersToolStripMenuItem
            // 
            this.openOrdersToolStripMenuItem.Name = "openOrdersToolStripMenuItem";
            this.openOrdersToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.openOrdersToolStripMenuItem.Text = "Open Orders";
            this.openOrdersToolStripMenuItem.Click += new System.EventHandler(this.openOrdersToolStripMenuItem_Click);
            // 
            // searchCustomersViaIDToolStripMenuItem
            // 
            this.searchCustomersViaIDToolStripMenuItem.Name = "searchCustomersViaIDToolStripMenuItem";
            this.searchCustomersViaIDToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.searchCustomersViaIDToolStripMenuItem.Text = "Search Customers via ID";
            this.searchCustomersViaIDToolStripMenuItem.Click += new System.EventHandler(this.searchCustomersViaIDToolStripMenuItem_Click);
            // 
            // closeOpenFormsToolStripMenuItem
            // 
            this.closeOpenFormsToolStripMenuItem.Name = "closeOpenFormsToolStripMenuItem";
            this.closeOpenFormsToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.closeOpenFormsToolStripMenuItem.Text = "Close open forms";
            this.closeOpenFormsToolStripMenuItem.Click += new System.EventHandler(this.closeOpenFormsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 268);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchCustomersViaIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeOpenFormsToolStripMenuItem;
    }
}

