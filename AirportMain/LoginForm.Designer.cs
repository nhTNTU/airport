namespace AirportMain
{
    partial class LoginForm
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
            this.remembercheckBox = new System.Windows.Forms.CheckBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.logintextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.noIntegratedSecurityRadioButton = new System.Windows.Forms.RadioButton();
            this.integratedSecurityRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // remembercheckBox
            // 
            this.remembercheckBox.AutoSize = true;
            this.remembercheckBox.Location = new System.Drawing.Point(73, 146);
            this.remembercheckBox.Name = "remembercheckBox";
            this.remembercheckBox.Size = new System.Drawing.Size(89, 17);
            this.remembercheckBox.TabIndex = 15;
            this.remembercheckBox.Text = "Запам\'ятати";
            this.remembercheckBox.UseVisualStyleBackColor = true;
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(109, 180);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 14;
            this.OKbutton.Text = "Увійти";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbutton.Location = new System.Drawing.Point(190, 180);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 13;
            this.cancelbutton.Text = "Відміна";
            this.cancelbutton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Логін:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(73, 119);
            this.passwordTextBox.MaxLength = 200;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(193, 20);
            this.passwordTextBox.TabIndex = 10;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // logintextBox
            // 
            this.logintextBox.Location = new System.Drawing.Point(73, 77);
            this.logintextBox.MaxLength = 100;
            this.logintextBox.Name = "logintextBox";
            this.logintextBox.Size = new System.Drawing.Size(193, 20);
            this.logintextBox.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.noIntegratedSecurityRadioButton);
            this.panel1.Controls.Add(this.integratedSecurityRadioButton);
            this.panel1.Location = new System.Drawing.Point(73, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 59);
            this.panel1.TabIndex = 8;
            // 
            // noIntegratedSecurityRadioButton
            // 
            this.noIntegratedSecurityRadioButton.AutoSize = true;
            this.noIntegratedSecurityRadioButton.Location = new System.Drawing.Point(4, 27);
            this.noIntegratedSecurityRadioButton.Name = "noIntegratedSecurityRadioButton";
            this.noIntegratedSecurityRadioButton.Size = new System.Drawing.Size(133, 17);
            this.noIntegratedSecurityRadioButton.TabIndex = 1;
            this.noIntegratedSecurityRadioButton.Text = "Ввести логін і пароль";
            this.noIntegratedSecurityRadioButton.UseVisualStyleBackColor = true;
            this.noIntegratedSecurityRadioButton.CheckedChanged += new System.EventHandler(this.integratedSecurityRadioButton_CheckedChanged);
            // 
            // integratedSecurityRadioButton
            // 
            this.integratedSecurityRadioButton.AutoSize = true;
            this.integratedSecurityRadioButton.Checked = true;
            this.integratedSecurityRadioButton.Location = new System.Drawing.Point(4, 4);
            this.integratedSecurityRadioButton.Name = "integratedSecurityRadioButton";
            this.integratedSecurityRadioButton.Size = new System.Drawing.Size(171, 17);
            this.integratedSecurityRadioButton.TabIndex = 0;
            this.integratedSecurityRadioButton.TabStop = true;
            this.integratedSecurityRadioButton.Text = "Вбудована безпека Windows";
            this.integratedSecurityRadioButton.UseVisualStyleBackColor = true;
            this.integratedSecurityRadioButton.CheckedChanged += new System.EventHandler(this.integratedSecurityRadioButton_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 215);
            this.Controls.Add(this.remembercheckBox);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.logintextBox);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "Вхід";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Click += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox remembercheckBox;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox logintextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton noIntegratedSecurityRadioButton;
        private System.Windows.Forms.RadioButton integratedSecurityRadioButton;
    }
}

