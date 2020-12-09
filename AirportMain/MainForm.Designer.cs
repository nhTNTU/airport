namespace AirportMain
{
    partial class MainForm
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
            this.LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aircompaniesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aircompaniesOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airportsViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginToolStripMenuItem,
            this.editToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.sheduleToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // LoginToolStripMenuItem
            // 
            this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            this.LoginToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.LoginToolStripMenuItem.Text = "Увійти до системи";
            this.LoginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.editToolStripMenuItem.Text = "Правка";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aircompaniesToolStripMenuItem,
            this.airportsToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Дані";
            // 
            // aircompaniesToolStripMenuItem
            // 
            this.aircompaniesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aircompaniesOpenToolStripMenuItem,
            this.planesToolStripMenuItem});
            this.aircompaniesToolStripMenuItem.Name = "aircompaniesToolStripMenuItem";
            this.aircompaniesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.aircompaniesToolStripMenuItem.Text = "Авіакомпанії";
            // 
            // aircompaniesOpenToolStripMenuItem
            // 
            this.aircompaniesOpenToolStripMenuItem.Name = "aircompaniesOpenToolStripMenuItem";
            this.aircompaniesOpenToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aircompaniesOpenToolStripMenuItem.Text = "Відкрити";
            this.aircompaniesOpenToolStripMenuItem.Click += new System.EventHandler(this.aircompaniesToolStripMenuItem_Click);
            // 
            // planesToolStripMenuItem
            // 
            this.planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            this.planesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.planesToolStripMenuItem.Text = "Літаки";
            this.planesToolStripMenuItem.Click += new System.EventHandler(this.planesToolStripMenuItem_Click);
            // 
            // airportsToolStripMenuItem
            // 
            this.airportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.airportsViewToolStripMenuItem,
            this.countriesToolStripMenuItem,
            this.citiesToolStripMenuItem});
            this.airportsToolStripMenuItem.Name = "airportsToolStripMenuItem";
            this.airportsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.airportsToolStripMenuItem.Text = "Аеропорти";
            // 
            // airportsViewToolStripMenuItem
            // 
            this.airportsViewToolStripMenuItem.Name = "airportsViewToolStripMenuItem";
            this.airportsViewToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.airportsViewToolStripMenuItem.Text = "Відкрити";
            this.airportsViewToolStripMenuItem.Click += new System.EventHandler(this.airportsViewToolStripMenuItem_Click);
            // 
            // countriesToolStripMenuItem
            // 
            this.countriesToolStripMenuItem.Name = "countriesToolStripMenuItem";
            this.countriesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.countriesToolStripMenuItem.Text = "Країни";
            this.countriesToolStripMenuItem.Click += new System.EventHandler(this.countriesToolStripMenuItem_Click);
            // 
            // citiesToolStripMenuItem
            // 
            this.citiesToolStripMenuItem.Name = "citiesToolStripMenuItem";
            this.citiesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.citiesToolStripMenuItem.Text = "Міста";
            this.citiesToolStripMenuItem.Click += new System.EventHandler(this.citiesToolStripMenuItem_Click);
            // 
            // sheduleToolStripMenuItem
            // 
            this.sheduleToolStripMenuItem.Name = "sheduleToolStripMenuItem";
            this.sheduleToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.sheduleToolStripMenuItem.Text = "Розклад";
            this.sheduleToolStripMenuItem.Click += new System.EventHandler(this.sheduleToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.logoutToolStripMenuItem.Text = "Вийти з системи";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "ІС Аеропотр";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem LoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aircompaniesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aircompaniesOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airportsViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}



