namespace Plane
{
    partial class PlanesForm
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
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.planesListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planeAircompanyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planeModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planeAircompanyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editButton.Location = new System.Drawing.Point(259, 290);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 9;
            this.editButton.Text = "Виправити";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.Location = new System.Drawing.Point(178, 290);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Видалити";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Location = new System.Drawing.Point(97, 290);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Добавити";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshButton.Location = new System.Drawing.Point(16, 290);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.Text = "Оновити";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planeIDDataGridViewTextBoxColumn,
            this.planeAircompanyIDDataGridViewTextBoxColumn,
            this.planeModelDataGridViewTextBoxColumn,
            this.planeNumberDataGridViewTextBoxColumn,
            this.planeAircompanyNameDataGridViewTextBoxColumn,
            this.eDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.planesListBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(485, 259);
            this.dataGridView1.TabIndex = 5;
            // 
            // planesListBindingSource
            // 
            this.planesListBindingSource.DataSource = typeof(AirportLib.Plane);
            // 
            // planeIDDataGridViewTextBoxColumn
            // 
            this.planeIDDataGridViewTextBoxColumn.DataPropertyName = "PlaneID";
            this.planeIDDataGridViewTextBoxColumn.HeaderText = "PlaneID";
            this.planeIDDataGridViewTextBoxColumn.Name = "planeIDDataGridViewTextBoxColumn";
            this.planeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.planeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // planeAircompanyIDDataGridViewTextBoxColumn
            // 
            this.planeAircompanyIDDataGridViewTextBoxColumn.DataPropertyName = "PlaneAircompanyID";
            this.planeAircompanyIDDataGridViewTextBoxColumn.HeaderText = "PlaneAircompanyID";
            this.planeAircompanyIDDataGridViewTextBoxColumn.Name = "planeAircompanyIDDataGridViewTextBoxColumn";
            this.planeAircompanyIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.planeAircompanyIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // planeModelDataGridViewTextBoxColumn
            // 
            this.planeModelDataGridViewTextBoxColumn.DataPropertyName = "PlaneModel";
            this.planeModelDataGridViewTextBoxColumn.HeaderText = "Модель літака";
            this.planeModelDataGridViewTextBoxColumn.Name = "planeModelDataGridViewTextBoxColumn";
            this.planeModelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planeNumberDataGridViewTextBoxColumn
            // 
            this.planeNumberDataGridViewTextBoxColumn.DataPropertyName = "PlaneNumber";
            this.planeNumberDataGridViewTextBoxColumn.HeaderText = "Номер Літака";
            this.planeNumberDataGridViewTextBoxColumn.Name = "planeNumberDataGridViewTextBoxColumn";
            this.planeNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planeAircompanyNameDataGridViewTextBoxColumn
            // 
            this.planeAircompanyNameDataGridViewTextBoxColumn.DataPropertyName = "PlaneAircompanyName";
            this.planeAircompanyNameDataGridViewTextBoxColumn.HeaderText = "Власник";
            this.planeAircompanyNameDataGridViewTextBoxColumn.Name = "planeAircompanyNameDataGridViewTextBoxColumn";
            this.planeAircompanyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eDataGridViewTextBoxColumn
            // 
            this.eDataGridViewTextBoxColumn.DataPropertyName = "e";
            this.eDataGridViewTextBoxColumn.HeaderText = "e";
            this.eDataGridViewTextBoxColumn.Name = "eDataGridViewTextBoxColumn";
            this.eDataGridViewTextBoxColumn.ReadOnly = true;
            this.eDataGridViewTextBoxColumn.Visible = false;
            // 
            // PlanesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 339);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PlanesForm";
            this.Text = "Літаки";
            this.Load += new System.EventHandler(this.PlanesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource planesListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeAircompanyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeAircompanyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDataGridViewTextBoxColumn;
    }
}