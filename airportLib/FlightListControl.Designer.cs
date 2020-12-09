namespace airportLib
{
    partial class FlightListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.headerLabel = new System.Windows.Forms.Label();
            this.startDatePanel = new System.Windows.Forms.Panel();
            this.iWantToSelectBeginDateRadioButton = new System.Windows.Forms.RadioButton();
            this.currentBeginDateRadioButton = new System.Windows.Forms.RadioButton();
            this.noBeginDateRadioButton = new System.Windows.Forms.RadioButton();
            this.endDatePanel = new System.Windows.Forms.Panel();
            this.iWantToSelectEndDateRadioButton = new System.Windows.Forms.RadioButton();
            this.noEndDateRadioButton = new System.Windows.Forms.RadioButton();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.airportComboBox = new System.Windows.Forms.ComboBox();
            this.findButton = new System.Windows.Forms.Button();
            this.flightsDataGridView = new System.Windows.Forms.DataGridView();
            this.flightIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightAircompanyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightPlaneIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightAirPortIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightAircompanyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightPlaneModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightAirportNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightCityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightCountryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightDateTimeStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightDateTimeArrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightPeriodicityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightNumOfFlightsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightPriceEconomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightPriceBusinessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightPriceFirstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightFilterBeginDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightFilterEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightDateTimeStartGMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightDateTimeArrivalGMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.startDatePanel.SuspendLayout();
            this.endDatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(318, 8);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(179, 31);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Пошук рейсу";
            // 
            // startDatePanel
            // 
            this.startDatePanel.Controls.Add(this.iWantToSelectBeginDateRadioButton);
            this.startDatePanel.Controls.Add(this.currentBeginDateRadioButton);
            this.startDatePanel.Controls.Add(this.noBeginDateRadioButton);
            this.startDatePanel.Location = new System.Drawing.Point(280, 52);
            this.startDatePanel.Name = "startDatePanel";
            this.startDatePanel.Size = new System.Drawing.Size(83, 71);
            this.startDatePanel.TabIndex = 1;
            // 
            // iWantToSelectBeginDateRadioButton
            // 
            this.iWantToSelectBeginDateRadioButton.AutoSize = true;
            this.iWantToSelectBeginDateRadioButton.Location = new System.Drawing.Point(3, 51);
            this.iWantToSelectBeginDateRadioButton.Name = "iWantToSelectBeginDateRadioButton";
            this.iWantToSelectBeginDateRadioButton.Size = new System.Drawing.Size(67, 17);
            this.iWantToSelectBeginDateRadioButton.TabIndex = 2;
            this.iWantToSelectBeginDateRadioButton.Text = "Вибрати";
            this.iWantToSelectBeginDateRadioButton.UseVisualStyleBackColor = true;
            this.iWantToSelectBeginDateRadioButton.CheckedChanged += new System.EventHandler(this.iWantToSelectBeginDateButton_CheckedChanged);
            // 
            // currentBeginDateRadioButton
            // 
            this.currentBeginDateRadioButton.AutoSize = true;
            this.currentBeginDateRadioButton.Location = new System.Drawing.Point(4, 28);
            this.currentBeginDateRadioButton.Name = "currentBeginDateRadioButton";
            this.currentBeginDateRadioButton.Size = new System.Drawing.Size(69, 17);
            this.currentBeginDateRadioButton.TabIndex = 1;
            this.currentBeginDateRadioButton.Text = "Сьогодні";
            this.currentBeginDateRadioButton.UseVisualStyleBackColor = true;
            // 
            // noBeginDateRadioButton
            // 
            this.noBeginDateRadioButton.AutoSize = true;
            this.noBeginDateRadioButton.Checked = true;
            this.noBeginDateRadioButton.Location = new System.Drawing.Point(3, 5);
            this.noBeginDateRadioButton.Name = "noBeginDateRadioButton";
            this.noBeginDateRadioButton.Size = new System.Drawing.Size(70, 17);
            this.noBeginDateRadioButton.TabIndex = 0;
            this.noBeginDateRadioButton.TabStop = true;
            this.noBeginDateRadioButton.Text = "Будь-яка";
            this.noBeginDateRadioButton.UseVisualStyleBackColor = true;
            // 
            // endDatePanel
            // 
            this.endDatePanel.Controls.Add(this.iWantToSelectEndDateRadioButton);
            this.endDatePanel.Controls.Add(this.noEndDateRadioButton);
            this.endDatePanel.Location = new System.Drawing.Point(531, 67);
            this.endDatePanel.Name = "endDatePanel";
            this.endDatePanel.Size = new System.Drawing.Size(78, 50);
            this.endDatePanel.TabIndex = 2;
            // 
            // iWantToSelectEndDateRadioButton
            // 
            this.iWantToSelectEndDateRadioButton.AutoSize = true;
            this.iWantToSelectEndDateRadioButton.Location = new System.Drawing.Point(3, 28);
            this.iWantToSelectEndDateRadioButton.Name = "iWantToSelectEndDateRadioButton";
            this.iWantToSelectEndDateRadioButton.Size = new System.Drawing.Size(67, 17);
            this.iWantToSelectEndDateRadioButton.TabIndex = 3;
            this.iWantToSelectEndDateRadioButton.Text = "Вибрати";
            this.iWantToSelectEndDateRadioButton.UseVisualStyleBackColor = true;
            this.iWantToSelectEndDateRadioButton.CheckedChanged += new System.EventHandler(this.iWantToSelectEndDateButton_CheckedChanged);
            // 
            // noEndDateRadioButton
            // 
            this.noEndDateRadioButton.AutoSize = true;
            this.noEndDateRadioButton.Checked = true;
            this.noEndDateRadioButton.Location = new System.Drawing.Point(3, 5);
            this.noEndDateRadioButton.Name = "noEndDateRadioButton";
            this.noEndDateRadioButton.Size = new System.Drawing.Size(70, 17);
            this.noEndDateRadioButton.TabIndex = 2;
            this.noEndDateRadioButton.TabStop = true;
            this.noEndDateRadioButton.Text = "Будь-яка";
            this.noEndDateRadioButton.UseVisualStyleBackColor = true;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(196, 84);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(78, 13);
            this.startDateLabel.TabIndex = 3;
            this.startDateLabel.Text = "Дата початку:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(432, 84);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(94, 13);
            this.endDateLabel.TabIndex = 4;
            this.endDateLabel.Text = "Дата закінчення:";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(199, 129);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateTimePicker.TabIndex = 5;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(432, 129);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateTimePicker.TabIndex = 6;
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(199, 177);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(121, 21);
            this.countryComboBox.TabIndex = 7;
            this.countryComboBox.SelectedValueChanged += new System.EventHandler(this.countryComboBox_SelectedValueChanged);
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(326, 177);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(121, 21);
            this.cityComboBox.TabIndex = 8;
            this.cityComboBox.SelectedValueChanged += new System.EventHandler(this.cityComboBox_SelectedValueChanged);
            // 
            // airportComboBox
            // 
            this.airportComboBox.FormattingEnabled = true;
            this.airportComboBox.Location = new System.Drawing.Point(453, 177);
            this.airportComboBox.Name = "airportComboBox";
            this.airportComboBox.Size = new System.Drawing.Size(121, 21);
            this.airportComboBox.TabIndex = 9;
            // 
            // findButton
            // 
            this.findButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.findButton.Location = new System.Drawing.Point(593, 177);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 10;
            this.findButton.Text = "Пошук";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // flightsDataGridView
            // 
            this.flightsDataGridView.AutoGenerateColumns = false;
            this.flightsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flightIDDataGridViewTextBoxColumn,
            this.flightAircompanyIDDataGridViewTextBoxColumn,
            this.flightPlaneIDDataGridViewTextBoxColumn,
            this.flightAirPortIDDataGridViewTextBoxColumn,
            this.flightAircompanyNameDataGridViewTextBoxColumn,
            this.flightPlaneModelDataGridViewTextBoxColumn,
            this.flightAirportNameDataGridViewTextBoxColumn,
            this.flightCityNameDataGridViewTextBoxColumn,
            this.flightCountryNameDataGridViewTextBoxColumn,
            this.flightTypeDataGridViewTextBoxColumn,
            this.flightStatusDataGridViewTextBoxColumn,
            this.flightDateTimeStartDataGridViewTextBoxColumn,
            this.flightDurationDataGridViewTextBoxColumn,
            this.flightDateTimeArrivalDataGridViewTextBoxColumn,
            this.flightPeriodicityDataGridViewTextBoxColumn,
            this.flightNumOfFlightsDataGridViewTextBoxColumn,
            this.flightPriceEconomDataGridViewTextBoxColumn,
            this.flightPriceBusinessDataGridViewTextBoxColumn,
            this.flightPriceFirstDataGridViewTextBoxColumn,
            this.flightFilterBeginDateDataGridViewTextBoxColumn,
            this.flightFilterEndDateDataGridViewTextBoxColumn,
            this.flightDateTimeStartGMTDataGridViewTextBoxColumn,
            this.flightDateTimeArrivalGMTDataGridViewTextBoxColumn,
            this.eDataGridViewTextBoxColumn});
            this.flightsDataGridView.DataSource = this.flightListBindingSource;
            this.flightsDataGridView.Location = new System.Drawing.Point(25, 208);
            this.flightsDataGridView.Name = "flightsDataGridView";
            this.flightsDataGridView.Size = new System.Drawing.Size(800, 227);
            this.flightsDataGridView.TabIndex = 11;
            this.flightsDataGridView.SelectionChanged += new System.EventHandler(this.flightsDataGridView_SelectionChanged);
            // 
            // flightIDDataGridViewTextBoxColumn
            // 
            this.flightIDDataGridViewTextBoxColumn.DataPropertyName = "FlightID";
            this.flightIDDataGridViewTextBoxColumn.HeaderText = "FlightID";
            this.flightIDDataGridViewTextBoxColumn.Name = "flightIDDataGridViewTextBoxColumn";
            this.flightIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // flightAircompanyIDDataGridViewTextBoxColumn
            // 
            this.flightAircompanyIDDataGridViewTextBoxColumn.DataPropertyName = "FlightAircompanyID";
            this.flightAircompanyIDDataGridViewTextBoxColumn.HeaderText = "FlightAircompanyID";
            this.flightAircompanyIDDataGridViewTextBoxColumn.Name = "flightAircompanyIDDataGridViewTextBoxColumn";
            this.flightAircompanyIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // flightPlaneIDDataGridViewTextBoxColumn
            // 
            this.flightPlaneIDDataGridViewTextBoxColumn.DataPropertyName = "FlightPlaneID";
            this.flightPlaneIDDataGridViewTextBoxColumn.HeaderText = "FlightPlaneID";
            this.flightPlaneIDDataGridViewTextBoxColumn.Name = "flightPlaneIDDataGridViewTextBoxColumn";
            this.flightPlaneIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // flightAirPortIDDataGridViewTextBoxColumn
            // 
            this.flightAirPortIDDataGridViewTextBoxColumn.DataPropertyName = "FlightAirPortID";
            this.flightAirPortIDDataGridViewTextBoxColumn.HeaderText = "FlightAirPortID";
            this.flightAirPortIDDataGridViewTextBoxColumn.Name = "flightAirPortIDDataGridViewTextBoxColumn";
            this.flightAirPortIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // flightAircompanyNameDataGridViewTextBoxColumn
            // 
            this.flightAircompanyNameDataGridViewTextBoxColumn.DataPropertyName = "FlightAircompanyName";
            this.flightAircompanyNameDataGridViewTextBoxColumn.HeaderText = "Авіакомпанія";
            this.flightAircompanyNameDataGridViewTextBoxColumn.Name = "flightAircompanyNameDataGridViewTextBoxColumn";
            // 
            // flightPlaneModelDataGridViewTextBoxColumn
            // 
            this.flightPlaneModelDataGridViewTextBoxColumn.DataPropertyName = "FlightPlaneModel";
            this.flightPlaneModelDataGridViewTextBoxColumn.HeaderText = "Борт";
            this.flightPlaneModelDataGridViewTextBoxColumn.Name = "flightPlaneModelDataGridViewTextBoxColumn";
            // 
            // flightAirportNameDataGridViewTextBoxColumn
            // 
            this.flightAirportNameDataGridViewTextBoxColumn.DataPropertyName = "FlightAirportName";
            this.flightAirportNameDataGridViewTextBoxColumn.HeaderText = "Аеропорт";
            this.flightAirportNameDataGridViewTextBoxColumn.Name = "flightAirportNameDataGridViewTextBoxColumn";
            // 
            // flightCityNameDataGridViewTextBoxColumn
            // 
            this.flightCityNameDataGridViewTextBoxColumn.DataPropertyName = "FlightCityName";
            this.flightCityNameDataGridViewTextBoxColumn.HeaderText = "Місто";
            this.flightCityNameDataGridViewTextBoxColumn.Name = "flightCityNameDataGridViewTextBoxColumn";
            // 
            // flightCountryNameDataGridViewTextBoxColumn
            // 
            this.flightCountryNameDataGridViewTextBoxColumn.DataPropertyName = "FlightCountryName";
            this.flightCountryNameDataGridViewTextBoxColumn.HeaderText = "Країна";
            this.flightCountryNameDataGridViewTextBoxColumn.Name = "flightCountryNameDataGridViewTextBoxColumn";
            // 
            // flightTypeDataGridViewTextBoxColumn
            // 
            this.flightTypeDataGridViewTextBoxColumn.DataPropertyName = "FlightType";
            this.flightTypeDataGridViewTextBoxColumn.HeaderText = "Рейс";
            this.flightTypeDataGridViewTextBoxColumn.Name = "flightTypeDataGridViewTextBoxColumn";
            // 
            // flightStatusDataGridViewTextBoxColumn
            // 
            this.flightStatusDataGridViewTextBoxColumn.DataPropertyName = "FlightStatus";
            this.flightStatusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.flightStatusDataGridViewTextBoxColumn.Name = "flightStatusDataGridViewTextBoxColumn";
            // 
            // flightDateTimeStartDataGridViewTextBoxColumn
            // 
            this.flightDateTimeStartDataGridViewTextBoxColumn.DataPropertyName = "FlightDateTimeStart";
            this.flightDateTimeStartDataGridViewTextBoxColumn.HeaderText = "Виліт";
            this.flightDateTimeStartDataGridViewTextBoxColumn.Name = "flightDateTimeStartDataGridViewTextBoxColumn";
            // 
            // flightDurationDataGridViewTextBoxColumn
            // 
            this.flightDurationDataGridViewTextBoxColumn.DataPropertyName = "FlightDuration";
            this.flightDurationDataGridViewTextBoxColumn.HeaderText = "В дорозі";
            this.flightDurationDataGridViewTextBoxColumn.Name = "flightDurationDataGridViewTextBoxColumn";
            // 
            // flightDateTimeArrivalDataGridViewTextBoxColumn
            // 
            this.flightDateTimeArrivalDataGridViewTextBoxColumn.DataPropertyName = "FlightDateTimeArrival";
            this.flightDateTimeArrivalDataGridViewTextBoxColumn.HeaderText = "Прибуває";
            this.flightDateTimeArrivalDataGridViewTextBoxColumn.Name = "flightDateTimeArrivalDataGridViewTextBoxColumn";
            // 
            // flightPeriodicityDataGridViewTextBoxColumn
            // 
            this.flightPeriodicityDataGridViewTextBoxColumn.DataPropertyName = "FlightPeriodicity";
            this.flightPeriodicityDataGridViewTextBoxColumn.HeaderText = "FlightPeriodicity";
            this.flightPeriodicityDataGridViewTextBoxColumn.Name = "flightPeriodicityDataGridViewTextBoxColumn";
            this.flightPeriodicityDataGridViewTextBoxColumn.Visible = false;
            // 
            // flightNumOfFlightsDataGridViewTextBoxColumn
            // 
            this.flightNumOfFlightsDataGridViewTextBoxColumn.DataPropertyName = "FlightNumOfFlights";
            this.flightNumOfFlightsDataGridViewTextBoxColumn.HeaderText = "FlightNumOfFlights";
            this.flightNumOfFlightsDataGridViewTextBoxColumn.Name = "flightNumOfFlightsDataGridViewTextBoxColumn";
            this.flightNumOfFlightsDataGridViewTextBoxColumn.Visible = false;
            // 
            // flightPriceEconomDataGridViewTextBoxColumn
            // 
            this.flightPriceEconomDataGridViewTextBoxColumn.DataPropertyName = "FlightPriceEconom";
            this.flightPriceEconomDataGridViewTextBoxColumn.HeaderText = "FlightPriceEconom";
            this.flightPriceEconomDataGridViewTextBoxColumn.Name = "flightPriceEconomDataGridViewTextBoxColumn";
            this.flightPriceEconomDataGridViewTextBoxColumn.Visible = false;
            // 
            // flightPriceBusinessDataGridViewTextBoxColumn
            // 
            this.flightPriceBusinessDataGridViewTextBoxColumn.DataPropertyName = "FlightPriceBusiness";
            this.flightPriceBusinessDataGridViewTextBoxColumn.HeaderText = "FlightPriceBusiness";
            this.flightPriceBusinessDataGridViewTextBoxColumn.Name = "flightPriceBusinessDataGridViewTextBoxColumn";
            this.flightPriceBusinessDataGridViewTextBoxColumn.Visible = false;
            // 
            // flightPriceFirstDataGridViewTextBoxColumn
            // 
            this.flightPriceFirstDataGridViewTextBoxColumn.DataPropertyName = "FlightPriceFirst";
            this.flightPriceFirstDataGridViewTextBoxColumn.HeaderText = "FlightPriceFirst";
            this.flightPriceFirstDataGridViewTextBoxColumn.Name = "flightPriceFirstDataGridViewTextBoxColumn";
            this.flightPriceFirstDataGridViewTextBoxColumn.Visible = false;
            // 
            // flightFilterBeginDateDataGridViewTextBoxColumn
            // 
            this.flightFilterBeginDateDataGridViewTextBoxColumn.DataPropertyName = "FlightFilterBeginDate";
            this.flightFilterBeginDateDataGridViewTextBoxColumn.HeaderText = "FlightFilterBeginDate";
            this.flightFilterBeginDateDataGridViewTextBoxColumn.Name = "flightFilterBeginDateDataGridViewTextBoxColumn";
            this.flightFilterBeginDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // flightFilterEndDateDataGridViewTextBoxColumn
            // 
            this.flightFilterEndDateDataGridViewTextBoxColumn.DataPropertyName = "FlightFilterEndDate";
            this.flightFilterEndDateDataGridViewTextBoxColumn.HeaderText = "FlightFilterEndDate";
            this.flightFilterEndDateDataGridViewTextBoxColumn.Name = "flightFilterEndDateDataGridViewTextBoxColumn";
            this.flightFilterEndDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // flightDateTimeStartGMTDataGridViewTextBoxColumn
            // 
            this.flightDateTimeStartGMTDataGridViewTextBoxColumn.DataPropertyName = "FlightDateTimeStartGMT";
            this.flightDateTimeStartGMTDataGridViewTextBoxColumn.HeaderText = "FlightDateTimeStartGMT";
            this.flightDateTimeStartGMTDataGridViewTextBoxColumn.Name = "flightDateTimeStartGMTDataGridViewTextBoxColumn";
            this.flightDateTimeStartGMTDataGridViewTextBoxColumn.Visible = false;
            // 
            // flightDateTimeArrivalGMTDataGridViewTextBoxColumn
            // 
            this.flightDateTimeArrivalGMTDataGridViewTextBoxColumn.DataPropertyName = "FlightDateTimeArrivalGMT";
            this.flightDateTimeArrivalGMTDataGridViewTextBoxColumn.HeaderText = "FlightDateTimeArrivalGMT";
            this.flightDateTimeArrivalGMTDataGridViewTextBoxColumn.Name = "flightDateTimeArrivalGMTDataGridViewTextBoxColumn";
            this.flightDateTimeArrivalGMTDataGridViewTextBoxColumn.Visible = false;
            // 
            // eDataGridViewTextBoxColumn
            // 
            this.eDataGridViewTextBoxColumn.DataPropertyName = "e";
            this.eDataGridViewTextBoxColumn.HeaderText = "e";
            this.eDataGridViewTextBoxColumn.Name = "eDataGridViewTextBoxColumn";
            this.eDataGridViewTextBoxColumn.Visible = false;
            // 
            // flightListBindingSource
            // 
            this.flightListBindingSource.DataSource = typeof(AirportLib.FlightList);
            // 
            // FlightListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flightsDataGridView);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.airportComboBox);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.endDatePanel);
            this.Controls.Add(this.startDatePanel);
            this.Controls.Add(this.headerLabel);
            this.Name = "FlightListControl";
            this.Size = new System.Drawing.Size(843, 465);
            this.Load += new System.EventHandler(this.FlightListControl_Load);
            this.startDatePanel.ResumeLayout(false);
            this.startDatePanel.PerformLayout();
            this.endDatePanel.ResumeLayout(false);
            this.endDatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel startDatePanel;
        private System.Windows.Forms.RadioButton iWantToSelectBeginDateRadioButton;
        private System.Windows.Forms.RadioButton currentBeginDateRadioButton;
        private System.Windows.Forms.RadioButton noBeginDateRadioButton;
        private System.Windows.Forms.Panel endDatePanel;
        private System.Windows.Forms.RadioButton iWantToSelectEndDateRadioButton;
        private System.Windows.Forms.RadioButton noEndDateRadioButton;
        private System.Windows.Forms.BindingSource flightListBindingSource;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.ComboBox airportComboBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.DataGridView flightsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightAircompanyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightPlaneIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightAirPortIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightAircompanyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightPlaneModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightAirportNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightCityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightCountryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightDateTimeStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightDateTimeArrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightPeriodicityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNumOfFlightsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightPriceEconomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightPriceBusinessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightPriceFirstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightFilterBeginDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightFilterEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightDateTimeStartGMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightDateTimeArrivalGMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDataGridViewTextBoxColumn;
    }
}
