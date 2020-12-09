namespace Cities
{
    partial class CitiesForm
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.citiesListDataGridView = new System.Windows.Forms.DataGridView();
            this.citiesListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityPopulationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citySignGMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityGMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stringGMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.citiesListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEdit.Location = new System.Drawing.Point(286, 250);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Text = "Виправити";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Location = new System.Drawing.Point(204, 250);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(122, 250);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавити";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRefresh.Location = new System.Drawing.Point(40, 250);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 7;
            this.buttonRefresh.Text = "Оновити";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // citiesListDataGridView
            // 
            this.citiesListDataGridView.AllowUserToAddRows = false;
            this.citiesListDataGridView.AllowUserToDeleteRows = false;
            this.citiesListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.citiesListDataGridView.AutoGenerateColumns = false;
            this.citiesListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citiesListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityIDDataGridViewTextBoxColumn,
            this.eDataGridViewTextBoxColumn,
            this.cityNameDataGridViewTextBoxColumn,
            this.cityPopulationDataGridViewTextBoxColumn,
            this.citySignGMTDataGridViewTextBoxColumn,
            this.cityGMTDataGridViewTextBoxColumn,
            this.countryNameDataGridViewTextBoxColumn,
            this.stringGMTDataGridViewTextBoxColumn});
            this.citiesListDataGridView.DataSource = this.citiesListBindingSource;
            this.citiesListDataGridView.Location = new System.Drawing.Point(40, 23);
            this.citiesListDataGridView.Name = "citiesListDataGridView";
            this.citiesListDataGridView.ReadOnly = true;
            this.citiesListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.citiesListDataGridView.Size = new System.Drawing.Size(402, 220);
            this.citiesListDataGridView.TabIndex = 6;
            // 
            // citiesListBindingSource
            // 
            this.citiesListBindingSource.DataSource = typeof(AirportLib.City);
            // 
            // cityIDDataGridViewTextBoxColumn
            // 
            this.cityIDDataGridViewTextBoxColumn.DataPropertyName = "CityID";
            this.cityIDDataGridViewTextBoxColumn.HeaderText = "CityID";
            this.cityIDDataGridViewTextBoxColumn.Name = "cityIDDataGridViewTextBoxColumn";
            this.cityIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // eDataGridViewTextBoxColumn
            // 
            this.eDataGridViewTextBoxColumn.DataPropertyName = "e";
            this.eDataGridViewTextBoxColumn.HeaderText = "e";
            this.eDataGridViewTextBoxColumn.Name = "eDataGridViewTextBoxColumn";
            this.eDataGridViewTextBoxColumn.ReadOnly = true;
            this.eDataGridViewTextBoxColumn.Visible = false;
            // 
            // cityNameDataGridViewTextBoxColumn
            // 
            this.cityNameDataGridViewTextBoxColumn.DataPropertyName = "CityName";
            this.cityNameDataGridViewTextBoxColumn.HeaderText = "Назва міста";
            this.cityNameDataGridViewTextBoxColumn.Name = "cityNameDataGridViewTextBoxColumn";
            this.cityNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityPopulationDataGridViewTextBoxColumn
            // 
            this.cityPopulationDataGridViewTextBoxColumn.DataPropertyName = "CityPopulation";
            this.cityPopulationDataGridViewTextBoxColumn.HeaderText = "CityPopulation";
            this.cityPopulationDataGridViewTextBoxColumn.Name = "cityPopulationDataGridViewTextBoxColumn";
            this.cityPopulationDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityPopulationDataGridViewTextBoxColumn.Visible = false;
            // 
            // citySignGMTDataGridViewTextBoxColumn
            // 
            this.citySignGMTDataGridViewTextBoxColumn.DataPropertyName = "CitySignGMT";
            this.citySignGMTDataGridViewTextBoxColumn.HeaderText = "CitySignGMT";
            this.citySignGMTDataGridViewTextBoxColumn.Name = "citySignGMTDataGridViewTextBoxColumn";
            this.citySignGMTDataGridViewTextBoxColumn.ReadOnly = true;
            this.citySignGMTDataGridViewTextBoxColumn.Visible = false;
            // 
            // cityGMTDataGridViewTextBoxColumn
            // 
            this.cityGMTDataGridViewTextBoxColumn.DataPropertyName = "CityGMT";
            this.cityGMTDataGridViewTextBoxColumn.HeaderText = "CityGMT";
            this.cityGMTDataGridViewTextBoxColumn.Name = "cityGMTDataGridViewTextBoxColumn";
            this.cityGMTDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityGMTDataGridViewTextBoxColumn.Visible = false;
            // 
            // countryNameDataGridViewTextBoxColumn
            // 
            this.countryNameDataGridViewTextBoxColumn.DataPropertyName = "CountryName";
            this.countryNameDataGridViewTextBoxColumn.HeaderText = "Країна";
            this.countryNameDataGridViewTextBoxColumn.Name = "countryNameDataGridViewTextBoxColumn";
            this.countryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stringGMTDataGridViewTextBoxColumn
            // 
            this.stringGMTDataGridViewTextBoxColumn.DataPropertyName = "StringGMT";
            this.stringGMTDataGridViewTextBoxColumn.HeaderText = "Часовий пояс";
            this.stringGMTDataGridViewTextBoxColumn.Name = "stringGMTDataGridViewTextBoxColumn";
            this.stringGMTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 297);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.citiesListDataGridView);
            this.Name = "CitiesForm";
            this.Text = "Міста";
            this.Load += new System.EventHandler(this.CitiesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.citiesListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView citiesListDataGridView;
        private System.Windows.Forms.BindingSource citiesListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityCountryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityPopulationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn citySignGMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityGMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stringGMTDataGridViewTextBoxColumn;
    }
}

