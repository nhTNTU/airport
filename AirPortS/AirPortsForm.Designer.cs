namespace AirPortS
{
    partial class AirPortsForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.airPortListDataGridView = new System.Windows.Forms.DataGridView();
            this.airPortListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airPortIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airPortCityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airPortNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airPortCityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airPortCountryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.airPortListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airPortListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Location = new System.Drawing.Point(97, 277);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshButton.Location = new System.Drawing.Point(16, 277);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 8;
            this.refreshButton.Text = "Оновити";
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.Location = new System.Drawing.Point(179, 277);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Видалити";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.Location = new System.Drawing.Point(260, 277);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Виправити";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // airPortListDataGridView
            // 
            this.airPortListDataGridView.AllowUserToAddRows = false;
            this.airPortListDataGridView.AllowUserToDeleteRows = false;
            this.airPortListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.airPortListDataGridView.AutoGenerateColumns = false;
            this.airPortListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.airPortListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.airPortListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.airPortIDDataGridViewTextBoxColumn,
            this.airPortCityIDDataGridViewTextBoxColumn,
            this.airPortNameDataGridViewTextBoxColumn,
            this.airPortCityNameDataGridViewTextBoxColumn,
            this.airPortCountryNameDataGridViewTextBoxColumn,
            this.eDataGridViewTextBoxColumn});
            this.airPortListDataGridView.DataSource = this.airPortListBindingSource;
            this.airPortListDataGridView.Location = new System.Drawing.Point(15, 21);
            this.airPortListDataGridView.Name = "airPortListDataGridView";
            this.airPortListDataGridView.ReadOnly = true;
            this.airPortListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.airPortListDataGridView.Size = new System.Drawing.Size(480, 250);
            this.airPortListDataGridView.TabIndex = 5;
            // 
            // airPortListBindingSource
            // 
            this.airPortListBindingSource.DataSource = typeof(AirportLib.AirPort);
            // 
            // airPortIDDataGridViewTextBoxColumn
            // 
            this.airPortIDDataGridViewTextBoxColumn.DataPropertyName = "AirPortID";
            this.airPortIDDataGridViewTextBoxColumn.HeaderText = "AirPortID";
            this.airPortIDDataGridViewTextBoxColumn.Name = "airPortIDDataGridViewTextBoxColumn";
            this.airPortIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.airPortIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // airPortCityIDDataGridViewTextBoxColumn
            // 
            this.airPortCityIDDataGridViewTextBoxColumn.DataPropertyName = "AirPortCityID";
            this.airPortCityIDDataGridViewTextBoxColumn.HeaderText = "AirPortCityID";
            this.airPortCityIDDataGridViewTextBoxColumn.Name = "airPortCityIDDataGridViewTextBoxColumn";
            this.airPortCityIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.airPortCityIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // airPortNameDataGridViewTextBoxColumn
            // 
            this.airPortNameDataGridViewTextBoxColumn.DataPropertyName = "AirPortName";
            this.airPortNameDataGridViewTextBoxColumn.HeaderText = "Аеропорт";
            this.airPortNameDataGridViewTextBoxColumn.Name = "airPortNameDataGridViewTextBoxColumn";
            this.airPortNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // airPortCityNameDataGridViewTextBoxColumn
            // 
            this.airPortCityNameDataGridViewTextBoxColumn.DataPropertyName = "AirPortCityName";
            this.airPortCityNameDataGridViewTextBoxColumn.HeaderText = "Місто";
            this.airPortCityNameDataGridViewTextBoxColumn.Name = "airPortCityNameDataGridViewTextBoxColumn";
            this.airPortCityNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // airPortCountryNameDataGridViewTextBoxColumn
            // 
            this.airPortCountryNameDataGridViewTextBoxColumn.DataPropertyName = "AirPortCountryName";
            this.airPortCountryNameDataGridViewTextBoxColumn.HeaderText = "Країна";
            this.airPortCountryNameDataGridViewTextBoxColumn.Name = "airPortCountryNameDataGridViewTextBoxColumn";
            this.airPortCountryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eDataGridViewTextBoxColumn
            // 
            this.eDataGridViewTextBoxColumn.DataPropertyName = "e";
            this.eDataGridViewTextBoxColumn.HeaderText = "e";
            this.eDataGridViewTextBoxColumn.Name = "eDataGridViewTextBoxColumn";
            this.eDataGridViewTextBoxColumn.ReadOnly = true;
            this.eDataGridViewTextBoxColumn.Visible = false;
            // 
            // AirPortsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 320);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.airPortListDataGridView);
            this.Name = "AirPortsForm";
            this.Text = "Аеропорти";
            this.Load += new System.EventHandler(this.AirPortsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airPortListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airPortListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.DataGridView airPortListDataGridView;
        private System.Windows.Forms.BindingSource airPortListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn airPortIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airPortCityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airPortNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airPortCityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airPortCountryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDataGridViewTextBoxColumn;
    }
}