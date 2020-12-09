namespace Aircompanies
{
    partial class AirCompaniesForm
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.aircompaniesListDataGridView = new System.Windows.Forms.DataGridView();
            this.aircompaniesListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aircompanyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aircompanyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aircompanyPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aircompanyAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aircompaniesListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircompaniesListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(431, 250);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Text = "Виправити";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(350, 249);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(269, 250);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавити";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(188, 249);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "Оновити";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // aircompaniesListDataGridView
            // 
            this.aircompaniesListDataGridView.AllowUserToAddRows = false;
            this.aircompaniesListDataGridView.AllowUserToDeleteRows = false;
            this.aircompaniesListDataGridView.AutoGenerateColumns = false;
            this.aircompaniesListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aircompaniesListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aircompanyIDDataGridViewTextBoxColumn,
            this.aircompanyNameDataGridViewTextBoxColumn,
            this.aircompanyPhoneDataGridViewTextBoxColumn,
            this.aircompanyAddressDataGridViewTextBoxColumn});
            this.aircompaniesListDataGridView.DataSource = this.aircompaniesListBindingSource;
            this.aircompaniesListDataGridView.Location = new System.Drawing.Point(12, 12);
            this.aircompaniesListDataGridView.Name = "aircompaniesListDataGridView";
            this.aircompaniesListDataGridView.ReadOnly = true;
            this.aircompaniesListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.aircompaniesListDataGridView.Size = new System.Drawing.Size(494, 231);
            this.aircompaniesListDataGridView.TabIndex = 6;
            // 
            // aircompaniesListBindingSource
            // 
            this.aircompaniesListBindingSource.DataSource = typeof(AirportLib.Aircompany);
            // 
            // aircompanyIDDataGridViewTextBoxColumn
            // 
            this.aircompanyIDDataGridViewTextBoxColumn.DataPropertyName = "AircompanyID";
            this.aircompanyIDDataGridViewTextBoxColumn.HeaderText = "AircompanyID";
            this.aircompanyIDDataGridViewTextBoxColumn.Name = "aircompanyIDDataGridViewTextBoxColumn";
            this.aircompanyIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aircompanyIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // aircompanyNameDataGridViewTextBoxColumn
            // 
            this.aircompanyNameDataGridViewTextBoxColumn.DataPropertyName = "AircompanyName";
            this.aircompanyNameDataGridViewTextBoxColumn.HeaderText = "Авіакомпанія";
            this.aircompanyNameDataGridViewTextBoxColumn.Name = "aircompanyNameDataGridViewTextBoxColumn";
            this.aircompanyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aircompanyPhoneDataGridViewTextBoxColumn
            // 
            this.aircompanyPhoneDataGridViewTextBoxColumn.DataPropertyName = "AircompanyPhone";
            this.aircompanyPhoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.aircompanyPhoneDataGridViewTextBoxColumn.Name = "aircompanyPhoneDataGridViewTextBoxColumn";
            this.aircompanyPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aircompanyAddressDataGridViewTextBoxColumn
            // 
            this.aircompanyAddressDataGridViewTextBoxColumn.DataPropertyName = "AircompanyAddress";
            this.aircompanyAddressDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.aircompanyAddressDataGridViewTextBoxColumn.Name = "aircompanyAddressDataGridViewTextBoxColumn";
            this.aircompanyAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AirCompaniesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 282);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.aircompaniesListDataGridView);
            this.Name = "AirCompaniesForm";
            this.Text = "Авіакомпанії";
            this.Load += new System.EventHandler(this.AirCompaniesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aircompaniesListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircompaniesListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.DataGridView aircompaniesListDataGridView;
        private System.Windows.Forms.BindingSource aircompaniesListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn airсompanyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airсompanyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airсompanyPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airсompanyAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aircompanyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aircompanyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aircompanyPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aircompanyAddressDataGridViewTextBoxColumn;
    }
}