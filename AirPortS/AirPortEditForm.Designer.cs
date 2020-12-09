namespace AirPortS
{
    partial class AirPortEditForm
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
            System.Windows.Forms.Label airPortNameLabel;
            this.cancelbutton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.airPortNameTextBox = new System.Windows.Forms.TextBox();
            this.airPortInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiesListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countriesListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            airPortNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.airPortInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // airPortNameLabel
            // 
            airPortNameLabel.AutoSize = true;
            airPortNameLabel.Location = new System.Drawing.Point(48, 38);
            airPortNameLabel.Name = "airPortNameLabel";
            airPortNameLabel.Size = new System.Drawing.Size(94, 13);
            airPortNameLabel.TabIndex = 9;
            airPortNameLabel.Text = "Назва аеропорту";
            // 
            // cancelbutton
            // 
            this.cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbutton.Location = new System.Drawing.Point(111, 183);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 16;
            this.cancelbutton.Text = "Відміна";
            this.cancelbutton.UseVisualStyleBackColor = true;
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(29, 183);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 15;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(109, 146);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(35, 13);
            this.CityLabel.TabIndex = 14;
            this.CityLabel.Text = "Місто";
            // 
            // CityComboBox
            // 
            this.CityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(150, 143);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(253, 21);
            this.CityComboBox.TabIndex = 13;
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(101, 88);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(41, 13);
            this.CountryLabel.TabIndex = 12;
            this.CountryLabel.Text = "Країна";
            // 
            // countryComboBox
            // 
            this.countryComboBox.DisplayMember = "CountryName";
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(150, 85);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(253, 21);
            this.countryComboBox.TabIndex = 11;
            this.countryComboBox.ValueMember = "CountryID";
            this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // airPortNameTextBox
            // 
            this.airPortNameTextBox.Location = new System.Drawing.Point(150, 35);
            this.airPortNameTextBox.Name = "airPortNameTextBox";
            this.airPortNameTextBox.Size = new System.Drawing.Size(253, 20);
            this.airPortNameTextBox.TabIndex = 10;
            // 
            // airPortInfoBindingSource
            // 
            this.airPortInfoBindingSource.DataSource = typeof(AirportLib.AirPort);
            // 
            // citiesListBindingSource
            // 
            this.citiesListBindingSource.DataSource = typeof(AirportLib.City);
            // 
            // countriesListBindingSource
            // 
            this.countriesListBindingSource.DataSource = typeof(AirportLib.Country);
            // 
            // AirPortEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 227);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.CityComboBox);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(airPortNameLabel);
            this.Controls.Add(this.airPortNameTextBox);
            this.Name = "AirPortEditForm";
            this.Text = "Аеропорт";
            this.Load += new System.EventHandler(this.AirPortEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airPortInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.TextBox airPortNameTextBox;
        private System.Windows.Forms.BindingSource airPortInfoBindingSource;
        private System.Windows.Forms.BindingSource citiesListBindingSource;
        private System.Windows.Forms.BindingSource countriesListBindingSource;
    }
}

