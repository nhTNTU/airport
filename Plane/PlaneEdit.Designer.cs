namespace Plane
{
    partial class PlaneEdit
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.airCompanycomboBox = new System.Windows.Forms.ComboBox();
            this.planeNumberTextbox = new System.Windows.Forms.TextBox();
            this.modeltextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(297, 152);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Відміна";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(216, 152);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 14;
            this.OKbutton.Text = "ОК";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // airCompanycomboBox
            // 
            this.airCompanycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.airCompanycomboBox.FormattingEnabled = true;
            this.airCompanycomboBox.Location = new System.Drawing.Point(153, 104);
            this.airCompanycomboBox.Name = "airCompanycomboBox";
            this.airCompanycomboBox.Size = new System.Drawing.Size(220, 21);
            this.airCompanycomboBox.TabIndex = 13;
            // 
            // planeNumberTextbox
            // 
            this.planeNumberTextbox.Location = new System.Drawing.Point(153, 63);
            this.planeNumberTextbox.MaxLength = 50;
            this.planeNumberTextbox.Name = "planeNumberTextbox";
            this.planeNumberTextbox.Size = new System.Drawing.Size(220, 20);
            this.planeNumberTextbox.TabIndex = 12;
            // 
            // modeltextBox
            // 
            this.modeltextBox.Location = new System.Drawing.Point(153, 21);
            this.modeltextBox.MaxLength = 20;
            this.modeltextBox.Name = "modeltextBox";
            this.modeltextBox.Size = new System.Drawing.Size(220, 20);
            this.modeltextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Авіакомпанія-власник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Бортовий номер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Модель літака";
            // 
            // PlaneEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 197);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.airCompanycomboBox);
            this.Controls.Add(this.planeNumberTextbox);
            this.Controls.Add(this.modeltextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PlaneEdit";
            this.Text = "Літак";
            this.Load += new System.EventHandler(this.PlaneEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.ComboBox airCompanycomboBox;
        private System.Windows.Forms.TextBox planeNumberTextbox;
        private System.Windows.Forms.TextBox modeltextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

