namespace Aircompanies
{
    partial class AirCompaniesEditForm
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
            System.Windows.Forms.Label airCompanyAddressLabel;
            System.Windows.Forms.Label airCompanyPhoneLabel;
            System.Windows.Forms.Label airCompanyNameLabel;
            System.Windows.Forms.Label airCompanyIDLabel;
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.airCompanyAddressTextBox = new System.Windows.Forms.TextBox();
            this.airCompanyPhoneTextBox = new System.Windows.Forms.TextBox();
            this.airCompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.airCompanyIDTextBox = new System.Windows.Forms.TextBox();
            this.aircompanyInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            airCompanyAddressLabel = new System.Windows.Forms.Label();
            airCompanyPhoneLabel = new System.Windows.Forms.Label();
            airCompanyNameLabel = new System.Windows.Forms.Label();
            airCompanyIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aircompanyInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // airCompanyAddressLabel
            // 
            airCompanyAddressLabel.AutoSize = true;
            airCompanyAddressLabel.Location = new System.Drawing.Point(25, 141);
            airCompanyAddressLabel.Name = "airCompanyAddressLabel";
            airCompanyAddressLabel.Size = new System.Drawing.Size(44, 13);
            airCompanyAddressLabel.TabIndex = 16;
            airCompanyAddressLabel.Text = "Адреса";
            // 
            // airCompanyPhoneLabel
            // 
            airCompanyPhoneLabel.AutoSize = true;
            airCompanyPhoneLabel.Location = new System.Drawing.Point(17, 102);
            airCompanyPhoneLabel.Name = "airCompanyPhoneLabel";
            airCompanyPhoneLabel.Size = new System.Drawing.Size(52, 13);
            airCompanyPhoneLabel.TabIndex = 14;
            airCompanyPhoneLabel.Text = "Телефон";
            // 
            // airCompanyNameLabel
            // 
            airCompanyNameLabel.AutoSize = true;
            airCompanyNameLabel.Location = new System.Drawing.Point(30, 61);
            airCompanyNameLabel.Name = "airCompanyNameLabel";
            airCompanyNameLabel.Size = new System.Drawing.Size(39, 13);
            airCompanyNameLabel.TabIndex = 11;
            airCompanyNameLabel.Text = "Назва";
            // 
            // airCompanyIDLabel
            // 
            airCompanyIDLabel.AutoSize = true;
            airCompanyIDLabel.Location = new System.Drawing.Point(202, 15);
            airCompanyIDLabel.Name = "airCompanyIDLabel";
            airCompanyIDLabel.Size = new System.Drawing.Size(83, 13);
            airCompanyIDLabel.TabIndex = 10;
            airCompanyIDLabel.Text = "Air Company ID:";
            airCompanyIDLabel.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(315, 227);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Відміна";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(234, 227);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 18;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // airCompanyAddressTextBox
            // 
            this.airCompanyAddressTextBox.Location = new System.Drawing.Point(75, 138);
            this.airCompanyAddressTextBox.Name = "airCompanyAddressTextBox";
            this.airCompanyAddressTextBox.Size = new System.Drawing.Size(316, 20);
            this.airCompanyAddressTextBox.TabIndex = 17;
            // 
            // airCompanyPhoneTextBox
            // 
            this.airCompanyPhoneTextBox.Location = new System.Drawing.Point(75, 99);
            this.airCompanyPhoneTextBox.Name = "airCompanyPhoneTextBox";
            this.airCompanyPhoneTextBox.Size = new System.Drawing.Size(316, 20);
            this.airCompanyPhoneTextBox.TabIndex = 15;
            // 
            // airCompanyNameTextBox
            // 
            this.airCompanyNameTextBox.Location = new System.Drawing.Point(75, 61);
            this.airCompanyNameTextBox.Name = "airCompanyNameTextBox";
            this.airCompanyNameTextBox.Size = new System.Drawing.Size(316, 20);
            this.airCompanyNameTextBox.TabIndex = 13;
            // 
            // airCompanyIDTextBox
            // 
            this.airCompanyIDTextBox.Location = new System.Drawing.Point(291, 12);
            this.airCompanyIDTextBox.Name = "airCompanyIDTextBox";
            this.airCompanyIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.airCompanyIDTextBox.TabIndex = 12;
            this.airCompanyIDTextBox.Visible = false;
            // 
            // aircompanyInfoBindingSource
            // 
            this.aircompanyInfoBindingSource.DataSource = typeof(AirportLib.Aircompany);
            // 
            // AirCompaniesEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 257);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(airCompanyAddressLabel);
            this.Controls.Add(this.airCompanyAddressTextBox);
            this.Controls.Add(airCompanyPhoneLabel);
            this.Controls.Add(this.airCompanyPhoneTextBox);
            this.Controls.Add(airCompanyNameLabel);
            this.Controls.Add(this.airCompanyNameTextBox);
            this.Controls.Add(airCompanyIDLabel);
            this.Controls.Add(this.airCompanyIDTextBox);
            this.Name = "AirCompaniesEditForm";
            this.Text = "Авіакомпанія";
            this.Load += new System.EventHandler(this.AirCompaniesEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aircompanyInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox airCompanyAddressTextBox;
        private System.Windows.Forms.TextBox airCompanyPhoneTextBox;
        private System.Windows.Forms.TextBox airCompanyNameTextBox;
        private System.Windows.Forms.TextBox airCompanyIDTextBox;
        private System.Windows.Forms.BindingSource aircompanyInfoBindingSource;
    }
}

