namespace Cities
{
    partial class CityEditForm
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
            System.Windows.Forms.Label countryIDLabel;
            System.Windows.Forms.Label populationLabel;
            System.Windows.Forms.Label cityNameLabel;
            System.Windows.Forms.Label gMTLabel;
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.countryIDcomboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.cityNameTextBox = new System.Windows.Forms.TextBox();
            this.gMTDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.citiesListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            countryIDLabel = new System.Windows.Forms.Label();
            populationLabel = new System.Windows.Forms.Label();
            cityNameLabel = new System.Windows.Forms.Label();
            gMTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.citiesListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // countryIDLabel
            // 
            countryIDLabel.AutoSize = true;
            countryIDLabel.Location = new System.Drawing.Point(62, 15);
            countryIDLabel.Name = "countryIDLabel";
            countryIDLabel.Size = new System.Drawing.Size(44, 13);
            countryIDLabel.TabIndex = 18;
            countryIDLabel.Text = "Країна:";
            // 
            // populationLabel
            // 
            populationLabel.AutoSize = true;
            populationLabel.Location = new System.Drawing.Point(42, 110);
            populationLabel.Name = "populationLabel";
            populationLabel.Size = new System.Drawing.Size(66, 13);
            populationLabel.TabIndex = 14;
            populationLabel.Text = "Населення:";
            // 
            // cityNameLabel
            // 
            cityNameLabel.AutoSize = true;
            cityNameLabel.Location = new System.Drawing.Point(34, 46);
            cityNameLabel.Name = "cityNameLabel";
            cityNameLabel.Size = new System.Drawing.Size(72, 13);
            cityNameLabel.TabIndex = 13;
            cityNameLabel.Text = "Назва міста:";
            // 
            // gMTLabel
            // 
            gMTLabel.AutoSize = true;
            gMTLabel.Location = new System.Drawing.Point(27, 78);
            gMTLabel.Name = "gMTLabel";
            gMTLabel.Size = new System.Drawing.Size(81, 13);
            gMTLabel.TabIndex = 11;
            gMTLabel.Text = "Часовий пояс:";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(209, 137);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 21;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(290, 137);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Відміна";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // countryIDcomboBox
            // 
            this.countryIDcomboBox.DisplayMember = "CountryName";
            this.countryIDcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryIDcomboBox.FormattingEnabled = true;
            this.countryIDcomboBox.Location = new System.Drawing.Point(114, 12);
            this.countryIDcomboBox.Name = "countryIDcomboBox";
            this.countryIDcomboBox.Size = new System.Drawing.Size(252, 21);
            this.countryIDcomboBox.TabIndex = 19;
            this.countryIDcomboBox.ValueMember = "CountryID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-"});
            this.comboBox1.Location = new System.Drawing.Point(114, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(38, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // populationTextBox
            // 
            this.populationTextBox.Location = new System.Drawing.Point(114, 107);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(252, 20);
            this.populationTextBox.TabIndex = 16;
            // 
            // cityNameTextBox
            // 
            this.cityNameTextBox.Location = new System.Drawing.Point(114, 43);
            this.cityNameTextBox.Name = "cityNameTextBox";
            this.cityNameTextBox.Size = new System.Drawing.Size(252, 20);
            this.cityNameTextBox.TabIndex = 15;
            // 
            // gMTDateTimePicker
            // 
            this.gMTDateTimePicker.CustomFormat = "HH:mm";
            this.gMTDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.gMTDateTimePicker.Location = new System.Drawing.Point(158, 75);
            this.gMTDateTimePicker.Name = "gMTDateTimePicker";
            this.gMTDateTimePicker.ShowUpDown = true;
            this.gMTDateTimePicker.Size = new System.Drawing.Size(208, 20);
            this.gMTDateTimePicker.TabIndex = 12;
            // 
            // CityEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 173);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.countryIDcomboBox);
            this.Controls.Add(countryIDLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(populationLabel);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(cityNameLabel);
            this.Controls.Add(this.cityNameTextBox);
            this.Controls.Add(gMTLabel);
            this.Controls.Add(this.gMTDateTimePicker);
            this.Name = "CityEditForm";
            this.Text = "Місто - ";
            this.Load += new System.EventHandler(this.CityEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.citiesListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox countryIDcomboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.TextBox cityNameTextBox;
        private System.Windows.Forms.DateTimePicker gMTDateTimePicker;
        private System.Windows.Forms.BindingSource citiesListBindingSource;
    }
}