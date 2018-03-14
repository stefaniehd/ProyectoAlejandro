namespace FirstProjectAlejandro.View
{
    partial class FrmCrud
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tabCrud = new System.Windows.Forms.TabControl();
            this.tabCountry = new System.Windows.Forms.TabPage();
            this.gbNewCountry = new System.Windows.Forms.GroupBox();
            this.btnSearchFlag = new System.Windows.Forms.Button();
            this.txtCountryId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountryFlag = new System.Windows.Forms.TextBox();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.btnSaveCountry = new System.Windows.Forms.Button();
            this.dgvCountry = new System.Windows.Forms.DataGridView();
            this.cCountryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCountryFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbActionsCountry = new System.Windows.Forms.GroupBox();
            this.btnDoCountry = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCountries = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCountryAction = new System.Windows.Forms.ComboBox();
            this.tabPlace = new System.Windows.Forms.TabPage();
            this.gbPlaceActions = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPlaceByPCountry = new System.Windows.Forms.ComboBox();
            this.txtPlaceId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPlaceName = new System.Windows.Forms.TextBox();
            this.btnSavePlace = new System.Windows.Forms.Button();
            this.dgvPlace = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDoPlace = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPlace = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPlacesActions = new System.Windows.Forms.ComboBox();
            this.tabAirport = new System.Windows.Forms.TabPage();
            this.cmbAirportsByPlace = new System.Windows.Forms.ComboBox();
            this.btnSaveAirports = new System.Windows.Forms.Button();
            this.dgvAirport = new System.Windows.Forms.DataGridView();
            this.cAirportId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAirportName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAirportLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbAirportsAction = new System.Windows.Forms.ComboBox();
            this.s = new System.Windows.Forms.TabPage();
            this.btnVehicleDone = new System.Windows.Forms.Button();
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.cVehicleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVehicleMake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVehicleModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVehiclePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVehicleAmmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbVehicleActions = new System.Windows.Forms.ComboBox();
            this.tabRoute = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHoursAirline = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvAirline = new System.Windows.Forms.DataGridView();
            this.cAirlineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHoursAirline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbAirlineActions = new System.Windows.Forms.ComboBox();
            this.tabHotel = new System.Windows.Forms.TabPage();
            this.cmbHotelByLocation = new System.Windows.Forms.ComboBox();
            this.btnDoneHotel = new System.Windows.Forms.Button();
            this.dgvHotel = new System.Windows.Forms.DataGridView();
            this.cHotelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHotelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHotelPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHotelRooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbHotelAction = new System.Windows.Forms.ComboBox();
            this.tabHotelRate = new System.Windows.Forms.TabPage();
            this.cmbHotelRate = new System.Windows.Forms.ComboBox();
            this.btnDoneHotelRate = new System.Windows.Forms.Button();
            this.dgvHotelRate = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbHotelRateActions = new System.Windows.Forms.ComboBox();
            this.cHotelRateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHotelRatePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHotelRateHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAirlineRate = new System.Windows.Forms.TabPage();
            this.tabCrud.SuspendLayout();
            this.tabCountry.SuspendLayout();
            this.gbNewCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).BeginInit();
            this.gbActionsCountry.SuspendLayout();
            this.tabPlace.SuspendLayout();
            this.gbPlaceActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlace)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabAirport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirport)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabRoute.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirline)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotel)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tabHotelRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelRate)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogOut.Location = new System.Drawing.Point(675, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(106, 35);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // tabCrud
            // 
            this.tabCrud.Controls.Add(this.tabCountry);
            this.tabCrud.Controls.Add(this.tabPlace);
            this.tabCrud.Controls.Add(this.tabAirport);
            this.tabCrud.Controls.Add(this.s);
            this.tabCrud.Controls.Add(this.tabRoute);
            this.tabCrud.Controls.Add(this.tabHotel);
            this.tabCrud.Controls.Add(this.tabHotelRate);
            this.tabCrud.Controls.Add(this.tabAirlineRate);
            this.tabCrud.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCrud.Location = new System.Drawing.Point(23, 85);
            this.tabCrud.Name = "tabCrud";
            this.tabCrud.SelectedIndex = 0;
            this.tabCrud.Size = new System.Drawing.Size(733, 328);
            this.tabCrud.TabIndex = 2;
            // 
            // tabCountry
            // 
            this.tabCountry.Controls.Add(this.gbNewCountry);
            this.tabCountry.Controls.Add(this.dgvCountry);
            this.tabCountry.Controls.Add(this.gbActionsCountry);
            this.tabCountry.Location = new System.Drawing.Point(4, 24);
            this.tabCountry.Name = "tabCountry";
            this.tabCountry.Padding = new System.Windows.Forms.Padding(3);
            this.tabCountry.Size = new System.Drawing.Size(725, 300);
            this.tabCountry.TabIndex = 0;
            this.tabCountry.Text = "Country";
            this.tabCountry.UseVisualStyleBackColor = true;
            // 
            // gbNewCountry
            // 
            this.gbNewCountry.Controls.Add(this.btnSearchFlag);
            this.gbNewCountry.Controls.Add(this.txtCountryId);
            this.gbNewCountry.Controls.Add(this.label4);
            this.gbNewCountry.Controls.Add(this.label3);
            this.gbNewCountry.Controls.Add(this.txtCountryFlag);
            this.gbNewCountry.Controls.Add(this.txtCountryName);
            this.gbNewCountry.Controls.Add(this.btnSaveCountry);
            this.gbNewCountry.Location = new System.Drawing.Point(344, 17);
            this.gbNewCountry.Name = "gbNewCountry";
            this.gbNewCountry.Size = new System.Drawing.Size(354, 87);
            this.gbNewCountry.TabIndex = 2;
            this.gbNewCountry.TabStop = false;
            this.gbNewCountry.Text = "New";
            this.gbNewCountry.Visible = false;
            // 
            // btnSearchFlag
            // 
            this.btnSearchFlag.BackColor = System.Drawing.Color.White;
            this.btnSearchFlag.Location = new System.Drawing.Point(207, 51);
            this.btnSearchFlag.Name = "btnSearchFlag";
            this.btnSearchFlag.Size = new System.Drawing.Size(27, 23);
            this.btnSearchFlag.TabIndex = 10;
            this.btnSearchFlag.UseVisualStyleBackColor = false;
            this.btnSearchFlag.Click += new System.EventHandler(this.btnSearchFlag_Click);
            // 
            // txtCountryId
            // 
            this.txtCountryId.Location = new System.Drawing.Point(257, 22);
            this.txtCountryId.Name = "txtCountryId";
            this.txtCountryId.Size = new System.Drawing.Size(91, 23);
            this.txtCountryId.TabIndex = 9;
            this.txtCountryId.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Flag:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            // 
            // txtCountryFlag
            // 
            this.txtCountryFlag.Location = new System.Drawing.Point(59, 51);
            this.txtCountryFlag.Name = "txtCountryFlag";
            this.txtCountryFlag.Size = new System.Drawing.Size(142, 23);
            this.txtCountryFlag.TabIndex = 6;
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(59, 22);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(175, 23);
            this.txtCountryName.TabIndex = 5;
            // 
            // btnSaveCountry
            // 
            this.btnSaveCountry.BackColor = System.Drawing.Color.White;
            this.btnSaveCountry.Location = new System.Drawing.Point(257, 51);
            this.btnSaveCountry.Name = "btnSaveCountry";
            this.btnSaveCountry.Size = new System.Drawing.Size(91, 24);
            this.btnSaveCountry.TabIndex = 4;
            this.btnSaveCountry.Text = "Save";
            this.btnSaveCountry.UseVisualStyleBackColor = false;
            this.btnSaveCountry.Click += new System.EventHandler(this.btnSaveCountry_Click);
            // 
            // dgvCountry
            // 
            this.dgvCountry.AllowUserToAddRows = false;
            this.dgvCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCountryId,
            this.cCountryName,
            this.cCountryFlag});
            this.dgvCountry.Enabled = false;
            this.dgvCountry.Location = new System.Drawing.Point(25, 122);
            this.dgvCountry.Name = "dgvCountry";
            this.dgvCountry.Size = new System.Drawing.Size(673, 152);
            this.dgvCountry.TabIndex = 1;
            // 
            // cCountryId
            // 
            this.cCountryId.HeaderText = "Id";
            this.cCountryId.Name = "cCountryId";
            this.cCountryId.Visible = false;
            // 
            // cCountryName
            // 
            this.cCountryName.HeaderText = "Name";
            this.cCountryName.Name = "cCountryName";
            // 
            // cCountryFlag
            // 
            this.cCountryFlag.HeaderText = "Flag";
            this.cCountryFlag.Name = "cCountryFlag";
            this.cCountryFlag.Visible = false;
            // 
            // gbActionsCountry
            // 
            this.gbActionsCountry.Controls.Add(this.btnDoCountry);
            this.gbActionsCountry.Controls.Add(this.label2);
            this.gbActionsCountry.Controls.Add(this.cmbCountries);
            this.gbActionsCountry.Controls.Add(this.label1);
            this.gbActionsCountry.Controls.Add(this.cmbCountryAction);
            this.gbActionsCountry.Location = new System.Drawing.Point(25, 17);
            this.gbActionsCountry.Name = "gbActionsCountry";
            this.gbActionsCountry.Size = new System.Drawing.Size(304, 87);
            this.gbActionsCountry.TabIndex = 0;
            this.gbActionsCountry.TabStop = false;
            this.gbActionsCountry.Text = "Choose the action!";
            // 
            // btnDoCountry
            // 
            this.btnDoCountry.BackColor = System.Drawing.Color.White;
            this.btnDoCountry.Location = new System.Drawing.Point(201, 50);
            this.btnDoCountry.Name = "btnDoCountry";
            this.btnDoCountry.Size = new System.Drawing.Size(91, 24);
            this.btnDoCountry.TabIndex = 4;
            this.btnDoCountry.Text = "Do!";
            this.btnDoCountry.UseVisualStyleBackColor = false;
            this.btnDoCountry.Click += new System.EventHandler(this.btnDoCountry_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Country:";
            // 
            // cmbCountries
            // 
            this.cmbCountries.Enabled = false;
            this.cmbCountries.FormattingEnabled = true;
            this.cmbCountries.Location = new System.Drawing.Point(74, 51);
            this.cmbCountries.Name = "cmbCountries";
            this.cmbCountries.Size = new System.Drawing.Size(121, 23);
            this.cmbCountries.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Action:";
            // 
            // cmbCountryAction
            // 
            this.cmbCountryAction.FormattingEnabled = true;
            this.cmbCountryAction.Items.AddRange(new object[] {
            "Select one...",
            "View all",
            "Delete",
            "Update",
            "Insert"});
            this.cmbCountryAction.Location = new System.Drawing.Point(74, 22);
            this.cmbCountryAction.Name = "cmbCountryAction";
            this.cmbCountryAction.Size = new System.Drawing.Size(121, 23);
            this.cmbCountryAction.TabIndex = 0;
            this.cmbCountryAction.SelectedIndexChanged += new System.EventHandler(this.cmbCountryAction_SelectedIndexChanged);
            // 
            // tabPlace
            // 
            this.tabPlace.Controls.Add(this.gbPlaceActions);
            this.tabPlace.Controls.Add(this.dgvPlace);
            this.tabPlace.Controls.Add(this.groupBox2);
            this.tabPlace.Location = new System.Drawing.Point(4, 24);
            this.tabPlace.Name = "tabPlace";
            this.tabPlace.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlace.Size = new System.Drawing.Size(725, 300);
            this.tabPlace.TabIndex = 1;
            this.tabPlace.Text = "Place";
            this.tabPlace.UseVisualStyleBackColor = true;
            // 
            // gbPlaceActions
            // 
            this.gbPlaceActions.Controls.Add(this.label5);
            this.gbPlaceActions.Controls.Add(this.cmbPlaceByPCountry);
            this.gbPlaceActions.Controls.Add(this.txtPlaceId);
            this.gbPlaceActions.Controls.Add(this.label6);
            this.gbPlaceActions.Controls.Add(this.txtPlaceName);
            this.gbPlaceActions.Controls.Add(this.btnSavePlace);
            this.gbPlaceActions.Location = new System.Drawing.Point(345, 22);
            this.gbPlaceActions.Name = "gbPlaceActions";
            this.gbPlaceActions.Size = new System.Drawing.Size(354, 87);
            this.gbPlaceActions.TabIndex = 5;
            this.gbPlaceActions.TabStop = false;
            this.gbPlaceActions.Text = "New";
            this.gbPlaceActions.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Country:";
            // 
            // cmbPlaceByPCountry
            // 
            this.cmbPlaceByPCountry.FormattingEnabled = true;
            this.cmbPlaceByPCountry.Location = new System.Drawing.Point(66, 22);
            this.cmbPlaceByPCountry.Name = "cmbPlaceByPCountry";
            this.cmbPlaceByPCountry.Size = new System.Drawing.Size(175, 23);
            this.cmbPlaceByPCountry.TabIndex = 10;
            // 
            // txtPlaceId
            // 
            this.txtPlaceId.Location = new System.Drawing.Point(257, 22);
            this.txtPlaceId.Name = "txtPlaceId";
            this.txtPlaceId.Size = new System.Drawing.Size(91, 23);
            this.txtPlaceId.TabIndex = 9;
            this.txtPlaceId.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Name:";
            // 
            // txtPlaceName
            // 
            this.txtPlaceName.Location = new System.Drawing.Point(66, 51);
            this.txtPlaceName.Name = "txtPlaceName";
            this.txtPlaceName.Size = new System.Drawing.Size(175, 23);
            this.txtPlaceName.TabIndex = 5;
            // 
            // btnSavePlace
            // 
            this.btnSavePlace.BackColor = System.Drawing.Color.White;
            this.btnSavePlace.Location = new System.Drawing.Point(257, 51);
            this.btnSavePlace.Name = "btnSavePlace";
            this.btnSavePlace.Size = new System.Drawing.Size(91, 24);
            this.btnSavePlace.TabIndex = 4;
            this.btnSavePlace.Text = "Save";
            this.btnSavePlace.UseVisualStyleBackColor = false;
            this.btnSavePlace.Click += new System.EventHandler(this.btnSavePlace_Click);
            // 
            // dgvPlace
            // 
            this.dgvPlace.AllowUserToAddRows = false;
            this.dgvPlace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlace.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvPlace.Enabled = false;
            this.dgvPlace.Location = new System.Drawing.Point(26, 127);
            this.dgvPlace.Name = "dgvPlace";
            this.dgvPlace.Size = new System.Drawing.Size(673, 152);
            this.dgvPlace.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "IdCountry";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDoPlace);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbPlace);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbPlacesActions);
            this.groupBox2.Location = new System.Drawing.Point(26, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 87);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose the action!";
            // 
            // btnDoPlace
            // 
            this.btnDoPlace.BackColor = System.Drawing.Color.White;
            this.btnDoPlace.Location = new System.Drawing.Point(201, 50);
            this.btnDoPlace.Name = "btnDoPlace";
            this.btnDoPlace.Size = new System.Drawing.Size(91, 24);
            this.btnDoPlace.TabIndex = 4;
            this.btnDoPlace.Text = "Do!";
            this.btnDoPlace.UseVisualStyleBackColor = false;
            this.btnDoPlace.Click += new System.EventHandler(this.btnDoPlace_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Place:";
            // 
            // cmbPlace
            // 
            this.cmbPlace.Enabled = false;
            this.cmbPlace.FormattingEnabled = true;
            this.cmbPlace.Location = new System.Drawing.Point(74, 51);
            this.cmbPlace.Name = "cmbPlace";
            this.cmbPlace.Size = new System.Drawing.Size(121, 23);
            this.cmbPlace.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Action:";
            // 
            // cmbPlacesActions
            // 
            this.cmbPlacesActions.FormattingEnabled = true;
            this.cmbPlacesActions.Items.AddRange(new object[] {
            "Select one...",
            "View all",
            "Delete",
            "Update",
            "Insert"});
            this.cmbPlacesActions.Location = new System.Drawing.Point(74, 22);
            this.cmbPlacesActions.Name = "cmbPlacesActions";
            this.cmbPlacesActions.Size = new System.Drawing.Size(121, 23);
            this.cmbPlacesActions.TabIndex = 0;
            this.cmbPlacesActions.SelectedIndexChanged += new System.EventHandler(this.cmbPlacesActions_SelectedIndexChanged);
            // 
            // tabAirport
            // 
            this.tabAirport.Controls.Add(this.cmbAirportsByPlace);
            this.tabAirport.Controls.Add(this.btnSaveAirports);
            this.tabAirport.Controls.Add(this.dgvAirport);
            this.tabAirport.Controls.Add(this.groupBox3);
            this.tabAirport.Location = new System.Drawing.Point(4, 24);
            this.tabAirport.Name = "tabAirport";
            this.tabAirport.Padding = new System.Windows.Forms.Padding(3);
            this.tabAirport.Size = new System.Drawing.Size(725, 300);
            this.tabAirport.TabIndex = 2;
            this.tabAirport.Text = "Airport";
            this.tabAirport.UseVisualStyleBackColor = true;
            // 
            // cmbAirportsByPlace
            // 
            this.cmbAirportsByPlace.Enabled = false;
            this.cmbAirportsByPlace.FormattingEnabled = true;
            this.cmbAirportsByPlace.Location = new System.Drawing.Point(481, 249);
            this.cmbAirportsByPlace.Name = "cmbAirportsByPlace";
            this.cmbAirportsByPlace.Size = new System.Drawing.Size(121, 23);
            this.cmbAirportsByPlace.TabIndex = 9;
            // 
            // btnSaveAirports
            // 
            this.btnSaveAirports.BackColor = System.Drawing.Color.White;
            this.btnSaveAirports.Location = new System.Drawing.Point(608, 247);
            this.btnSaveAirports.Name = "btnSaveAirports";
            this.btnSaveAirports.Size = new System.Drawing.Size(91, 24);
            this.btnSaveAirports.TabIndex = 8;
            this.btnSaveAirports.Text = "Done";
            this.btnSaveAirports.UseVisualStyleBackColor = false;
            this.btnSaveAirports.Click += new System.EventHandler(this.btnSaveAirports_Click);
            // 
            // dgvAirport
            // 
            this.dgvAirport.AllowUserToAddRows = false;
            this.dgvAirport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cAirportId,
            this.cAirportName,
            this.cAirportLocation,
            this.cIata});
            this.dgvAirport.Enabled = false;
            this.dgvAirport.Location = new System.Drawing.Point(26, 89);
            this.dgvAirport.Name = "dgvAirport";
            this.dgvAirport.Size = new System.Drawing.Size(673, 152);
            this.dgvAirport.TabIndex = 7;
            // 
            // cAirportId
            // 
            this.cAirportId.HeaderText = "Id";
            this.cAirportId.Name = "cAirportId";
            this.cAirportId.Visible = false;
            // 
            // cAirportName
            // 
            this.cAirportName.HeaderText = "Name";
            this.cAirportName.Name = "cAirportName";
            // 
            // cAirportLocation
            // 
            this.cAirportLocation.HeaderText = "Location";
            this.cAirportLocation.Name = "cAirportLocation";
            this.cAirportLocation.Visible = false;
            // 
            // cIata
            // 
            this.cIata.HeaderText = "IATA";
            this.cIata.Name = "cIata";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cmbAirportsAction);
            this.groupBox3.Location = new System.Drawing.Point(26, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 61);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choose the action!";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Action:";
            // 
            // cmbAirportsAction
            // 
            this.cmbAirportsAction.FormattingEnabled = true;
            this.cmbAirportsAction.Items.AddRange(new object[] {
            "Select one...",
            "Add",
            "Delete",
            "Update",
            "Refresh"});
            this.cmbAirportsAction.Location = new System.Drawing.Point(74, 22);
            this.cmbAirportsAction.Name = "cmbAirportsAction";
            this.cmbAirportsAction.Size = new System.Drawing.Size(121, 23);
            this.cmbAirportsAction.TabIndex = 0;
            this.cmbAirportsAction.SelectedIndexChanged += new System.EventHandler(this.cmbAirportsAction_SelectedIndexChanged);
            // 
            // s
            // 
            this.s.Controls.Add(this.btnVehicleDone);
            this.s.Controls.Add(this.dgvVehicles);
            this.s.Controls.Add(this.groupBox4);
            this.s.Location = new System.Drawing.Point(4, 24);
            this.s.Name = "s";
            this.s.Padding = new System.Windows.Forms.Padding(3);
            this.s.Size = new System.Drawing.Size(725, 300);
            this.s.TabIndex = 3;
            this.s.Text = "Vehicle";
            this.s.UseVisualStyleBackColor = true;
            // 
            // btnVehicleDone
            // 
            this.btnVehicleDone.BackColor = System.Drawing.Color.White;
            this.btnVehicleDone.Location = new System.Drawing.Point(608, 266);
            this.btnVehicleDone.Name = "btnVehicleDone";
            this.btnVehicleDone.Size = new System.Drawing.Size(91, 24);
            this.btnVehicleDone.TabIndex = 9;
            this.btnVehicleDone.Text = "Done";
            this.btnVehicleDone.UseVisualStyleBackColor = false;
            this.btnVehicleDone.Click += new System.EventHandler(this.btnVehicleDone_Click);
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cVehicleId,
            this.cVehicleMake,
            this.cVehicleModel,
            this.cVehicleType,
            this.cVehiclePrice,
            this.cVehicleAmmount});
            this.dgvVehicles.Enabled = false;
            this.dgvVehicles.Location = new System.Drawing.Point(26, 81);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.Size = new System.Drawing.Size(673, 179);
            this.dgvVehicles.TabIndex = 7;
            // 
            // cVehicleId
            // 
            this.cVehicleId.HeaderText = "Id";
            this.cVehicleId.Name = "cVehicleId";
            this.cVehicleId.Visible = false;
            // 
            // cVehicleMake
            // 
            this.cVehicleMake.HeaderText = "Make";
            this.cVehicleMake.Name = "cVehicleMake";
            // 
            // cVehicleModel
            // 
            this.cVehicleModel.HeaderText = "Model";
            this.cVehicleModel.Name = "cVehicleModel";
            // 
            // cVehicleType
            // 
            this.cVehicleType.HeaderText = "Type";
            this.cVehicleType.Name = "cVehicleType";
            // 
            // cVehiclePrice
            // 
            this.cVehiclePrice.HeaderText = "Price";
            this.cVehiclePrice.Name = "cVehiclePrice";
            // 
            // cVehicleAmmount
            // 
            this.cVehicleAmmount.HeaderText = "Ammount";
            this.cVehicleAmmount.Name = "cVehicleAmmount";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.cmbVehicleActions);
            this.groupBox4.Location = new System.Drawing.Point(26, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 53);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Choose the action!";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Action:";
            // 
            // cmbVehicleActions
            // 
            this.cmbVehicleActions.FormattingEnabled = true;
            this.cmbVehicleActions.Items.AddRange(new object[] {
            "Select one...",
            "View all",
            "Delete",
            "Update",
            "Insert"});
            this.cmbVehicleActions.Location = new System.Drawing.Point(74, 22);
            this.cmbVehicleActions.Name = "cmbVehicleActions";
            this.cmbVehicleActions.Size = new System.Drawing.Size(121, 23);
            this.cmbVehicleActions.TabIndex = 0;
            this.cmbVehicleActions.SelectedIndexChanged += new System.EventHandler(this.cmbVehicleActions_SelectedIndexChanged);
            // 
            // tabRoute
            // 
            this.tabRoute.Controls.Add(this.groupBox1);
            this.tabRoute.Controls.Add(this.dgvAirline);
            this.tabRoute.Controls.Add(this.groupBox5);
            this.tabRoute.Location = new System.Drawing.Point(4, 24);
            this.tabRoute.Name = "tabRoute";
            this.tabRoute.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoute.Size = new System.Drawing.Size(725, 300);
            this.tabRoute.TabIndex = 4;
            this.tabRoute.Text = "Airline";
            this.tabRoute.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHoursAirline);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbTo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbFrom);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(345, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 124);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New";
            // 
            // txtHoursAirline
            // 
            this.txtHoursAirline.Location = new System.Drawing.Point(66, 90);
            this.txtHoursAirline.Name = "txtHoursAirline";
            this.txtHoursAirline.Size = new System.Drawing.Size(175, 23);
            this.txtHoursAirline.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Hours:";
            // 
            // cmbTo
            // 
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(66, 56);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(175, 23);
            this.cmbTo.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "From:";
            // 
            // cmbFrom
            // 
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(66, 22);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(175, 23);
            this.cmbFrom.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "To:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(257, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Do";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvAirline
            // 
            this.dgvAirline.AllowUserToAddRows = false;
            this.dgvAirline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cAirlineId,
            this.cFrom,
            this.cTo,
            this.cHoursAirline});
            this.dgvAirline.Enabled = false;
            this.dgvAirline.Location = new System.Drawing.Point(26, 170);
            this.dgvAirline.Name = "dgvAirline";
            this.dgvAirline.Size = new System.Drawing.Size(673, 109);
            this.dgvAirline.TabIndex = 7;
            // 
            // cAirlineId
            // 
            this.cAirlineId.HeaderText = "Id";
            this.cAirlineId.Name = "cAirlineId";
            // 
            // cFrom
            // 
            this.cFrom.HeaderText = "From";
            this.cFrom.Name = "cFrom";
            // 
            // cTo
            // 
            this.cTo.HeaderText = "To";
            this.cTo.Name = "cTo";
            // 
            // cHoursAirline
            // 
            this.cHoursAirline.HeaderText = "Hours";
            this.cHoursAirline.Name = "cHoursAirline";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.cmbAirlineActions);
            this.groupBox5.Location = new System.Drawing.Point(26, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(304, 58);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Choose the action!";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Action:";
            // 
            // cmbAirlineActions
            // 
            this.cmbAirlineActions.FormattingEnabled = true;
            this.cmbAirlineActions.Items.AddRange(new object[] {
            "Select one...",
            "View all",
            "Delete",
            "Update",
            "Insert"});
            this.cmbAirlineActions.Location = new System.Drawing.Point(74, 22);
            this.cmbAirlineActions.Name = "cmbAirlineActions";
            this.cmbAirlineActions.Size = new System.Drawing.Size(121, 23);
            this.cmbAirlineActions.TabIndex = 0;
            this.cmbAirlineActions.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // tabHotel
            // 
            this.tabHotel.Controls.Add(this.cmbHotelByLocation);
            this.tabHotel.Controls.Add(this.btnDoneHotel);
            this.tabHotel.Controls.Add(this.dgvHotel);
            this.tabHotel.Controls.Add(this.groupBox6);
            this.tabHotel.Location = new System.Drawing.Point(4, 24);
            this.tabHotel.Name = "tabHotel";
            this.tabHotel.Padding = new System.Windows.Forms.Padding(3);
            this.tabHotel.Size = new System.Drawing.Size(725, 300);
            this.tabHotel.TabIndex = 5;
            this.tabHotel.Text = "Hotel";
            this.tabHotel.UseVisualStyleBackColor = true;
            // 
            // cmbHotelByLocation
            // 
            this.cmbHotelByLocation.Enabled = false;
            this.cmbHotelByLocation.FormattingEnabled = true;
            this.cmbHotelByLocation.Location = new System.Drawing.Point(481, 250);
            this.cmbHotelByLocation.Name = "cmbHotelByLocation";
            this.cmbHotelByLocation.Size = new System.Drawing.Size(121, 23);
            this.cmbHotelByLocation.TabIndex = 13;
            // 
            // btnDoneHotel
            // 
            this.btnDoneHotel.BackColor = System.Drawing.Color.White;
            this.btnDoneHotel.Location = new System.Drawing.Point(608, 250);
            this.btnDoneHotel.Name = "btnDoneHotel";
            this.btnDoneHotel.Size = new System.Drawing.Size(91, 24);
            this.btnDoneHotel.TabIndex = 12;
            this.btnDoneHotel.Text = "Done";
            this.btnDoneHotel.UseVisualStyleBackColor = false;
            this.btnDoneHotel.Click += new System.EventHandler(this.btnDoneHotel_Click);
            // 
            // dgvHotel
            // 
            this.dgvHotel.AllowUserToAddRows = false;
            this.dgvHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cHotelId,
            this.cHotelName,
            this.cHotelPlace,
            this.cHotelRooms});
            this.dgvHotel.Enabled = false;
            this.dgvHotel.Location = new System.Drawing.Point(26, 92);
            this.dgvHotel.Name = "dgvHotel";
            this.dgvHotel.Size = new System.Drawing.Size(673, 152);
            this.dgvHotel.TabIndex = 11;
            // 
            // cHotelId
            // 
            this.cHotelId.HeaderText = "Id";
            this.cHotelId.Name = "cHotelId";
            this.cHotelId.Visible = false;
            // 
            // cHotelName
            // 
            this.cHotelName.HeaderText = "Name";
            this.cHotelName.Name = "cHotelName";
            // 
            // cHotelPlace
            // 
            this.cHotelPlace.HeaderText = "Place";
            this.cHotelPlace.Name = "cHotelPlace";
            this.cHotelPlace.Visible = false;
            // 
            // cHotelRooms
            // 
            this.cHotelRooms.HeaderText = "Rooms";
            this.cHotelRooms.Name = "cHotelRooms";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.cmbHotelAction);
            this.groupBox6.Location = new System.Drawing.Point(26, 25);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(216, 61);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Choose the action!";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "Action:";
            // 
            // cmbHotelAction
            // 
            this.cmbHotelAction.FormattingEnabled = true;
            this.cmbHotelAction.Items.AddRange(new object[] {
            "Select one...",
            "Add",
            "Delete",
            "Update",
            "Refresh"});
            this.cmbHotelAction.Location = new System.Drawing.Point(74, 22);
            this.cmbHotelAction.Name = "cmbHotelAction";
            this.cmbHotelAction.Size = new System.Drawing.Size(121, 23);
            this.cmbHotelAction.TabIndex = 0;
            this.cmbHotelAction.SelectedIndexChanged += new System.EventHandler(this.cmbHotelAction_SelectedIndexChanged);
            // 
            // tabHotelRate
            // 
            this.tabHotelRate.Controls.Add(this.cmbHotelRate);
            this.tabHotelRate.Controls.Add(this.btnDoneHotelRate);
            this.tabHotelRate.Controls.Add(this.dgvHotelRate);
            this.tabHotelRate.Controls.Add(this.groupBox7);
            this.tabHotelRate.Location = new System.Drawing.Point(4, 24);
            this.tabHotelRate.Name = "tabHotelRate";
            this.tabHotelRate.Padding = new System.Windows.Forms.Padding(3);
            this.tabHotelRate.Size = new System.Drawing.Size(725, 300);
            this.tabHotelRate.TabIndex = 6;
            this.tabHotelRate.Text = "Hotel\'s Rate";
            this.tabHotelRate.UseVisualStyleBackColor = true;
            // 
            // cmbHotelRate
            // 
            this.cmbHotelRate.Enabled = false;
            this.cmbHotelRate.FormattingEnabled = true;
            this.cmbHotelRate.Location = new System.Drawing.Point(481, 251);
            this.cmbHotelRate.Name = "cmbHotelRate";
            this.cmbHotelRate.Size = new System.Drawing.Size(121, 23);
            this.cmbHotelRate.TabIndex = 17;
            // 
            // btnDoneHotelRate
            // 
            this.btnDoneHotelRate.BackColor = System.Drawing.Color.White;
            this.btnDoneHotelRate.Location = new System.Drawing.Point(608, 251);
            this.btnDoneHotelRate.Name = "btnDoneHotelRate";
            this.btnDoneHotelRate.Size = new System.Drawing.Size(91, 24);
            this.btnDoneHotelRate.TabIndex = 16;
            this.btnDoneHotelRate.Text = "Done";
            this.btnDoneHotelRate.UseVisualStyleBackColor = false;
            this.btnDoneHotelRate.Click += new System.EventHandler(this.btnDoneHotelRate_Click);
            // 
            // dgvHotelRate
            // 
            this.dgvHotelRate.AllowUserToAddRows = false;
            this.dgvHotelRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotelRate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cHotelRateId,
            this.cHotelRatePrice,
            this.cHotelRateHotel});
            this.dgvHotelRate.Enabled = false;
            this.dgvHotelRate.Location = new System.Drawing.Point(26, 93);
            this.dgvHotelRate.Name = "dgvHotelRate";
            this.dgvHotelRate.Size = new System.Drawing.Size(673, 152);
            this.dgvHotelRate.TabIndex = 15;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.cmbHotelRateActions);
            this.groupBox7.Location = new System.Drawing.Point(26, 26);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(216, 61);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Choose the action!";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 15);
            this.label16.TabIndex = 1;
            this.label16.Text = "Action:";
            // 
            // cmbHotelRateActions
            // 
            this.cmbHotelRateActions.FormattingEnabled = true;
            this.cmbHotelRateActions.Items.AddRange(new object[] {
            "Select one...",
            "Add",
            "Delete",
            "Update",
            "Refresh"});
            this.cmbHotelRateActions.Location = new System.Drawing.Point(74, 22);
            this.cmbHotelRateActions.Name = "cmbHotelRateActions";
            this.cmbHotelRateActions.Size = new System.Drawing.Size(121, 23);
            this.cmbHotelRateActions.TabIndex = 0;
            this.cmbHotelRateActions.SelectedIndexChanged += new System.EventHandler(this.cmbHotelRateActions_SelectedIndexChanged);
            // 
            // cHotelRateId
            // 
            this.cHotelRateId.HeaderText = "Id";
            this.cHotelRateId.Name = "cHotelRateId";
            this.cHotelRateId.Visible = false;
            // 
            // cHotelRatePrice
            // 
            this.cHotelRatePrice.HeaderText = "Price";
            this.cHotelRatePrice.Name = "cHotelRatePrice";
            // 
            // cHotelRateHotel
            // 
            this.cHotelRateHotel.HeaderText = "Hotel";
            this.cHotelRateHotel.Name = "cHotelRateHotel";
            this.cHotelRateHotel.Visible = false;
            // 
            // tabAirlineRate
            // 
            this.tabAirlineRate.Location = new System.Drawing.Point(4, 24);
            this.tabAirlineRate.Name = "tabAirlineRate";
            this.tabAirlineRate.Padding = new System.Windows.Forms.Padding(3);
            this.tabAirlineRate.Size = new System.Drawing.Size(725, 300);
            this.tabAirlineRate.TabIndex = 7;
            this.tabAirlineRate.Text = "Airline\'s Rate";
            this.tabAirlineRate.UseVisualStyleBackColor = true;
            // 
            // FrmCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 436);
            this.Controls.Add(this.tabCrud);
            this.Controls.Add(this.btnLogOut);
            this.MaximizeBox = false;
            this.Name = "FrmCrud";
            this.Resizable = false;
            this.Text = "Admin View";
            this.tabCrud.ResumeLayout(false);
            this.tabCountry.ResumeLayout(false);
            this.gbNewCountry.ResumeLayout(false);
            this.gbNewCountry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).EndInit();
            this.gbActionsCountry.ResumeLayout(false);
            this.gbActionsCountry.PerformLayout();
            this.tabPlace.ResumeLayout(false);
            this.gbPlaceActions.ResumeLayout(false);
            this.gbPlaceActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlace)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabAirport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirport)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.s.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabRoute.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirline)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabHotel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotel)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabHotelRate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotelRate)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TabControl tabCrud;
        private System.Windows.Forms.TabPage tabCountry;
        private System.Windows.Forms.TabPage tabPlace;
        private System.Windows.Forms.DataGridView dgvCountry;
        private System.Windows.Forms.GroupBox gbActionsCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCountryAction;
        private System.Windows.Forms.Button btnDoCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCountries;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCountryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCountryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCountryFlag;
        private System.Windows.Forms.GroupBox gbNewCountry;
        private System.Windows.Forms.TextBox txtCountryId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCountryFlag;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Button btnSaveCountry;
        private System.Windows.Forms.Button btnSearchFlag;
        private System.Windows.Forms.GroupBox gbPlaceActions;
        private System.Windows.Forms.TextBox txtPlaceId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPlaceName;
        private System.Windows.Forms.Button btnSavePlace;
        private System.Windows.Forms.DataGridView dgvPlace;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDoPlace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPlace;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPlacesActions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPlaceByPCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TabPage tabAirport;
        private System.Windows.Forms.DataGridView dgvAirport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbAirportsAction;
        private System.Windows.Forms.Button btnSaveAirports;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAirportId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAirportName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAirportLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIata;
        private System.Windows.Forms.ComboBox cmbAirportsByPlace;
        private System.Windows.Forms.TabPage s;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVehicleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVehicleMake;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVehicleModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVehiclePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVehicleAmmount;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbVehicleActions;
        private System.Windows.Forms.Button btnVehicleDone;
        private System.Windows.Forms.TabPage tabRoute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvAirline;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbAirlineActions;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.TextBox txtHoursAirline;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAirlineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHoursAirline;
        private System.Windows.Forms.TabPage tabHotel;
        private System.Windows.Forms.ComboBox cmbHotelByLocation;
        private System.Windows.Forms.Button btnDoneHotel;
        private System.Windows.Forms.DataGridView dgvHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHotelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHotelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHotelPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHotelRooms;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbHotelAction;
        private System.Windows.Forms.TabPage tabHotelRate;
        private System.Windows.Forms.ComboBox cmbHotelRate;
        private System.Windows.Forms.Button btnDoneHotelRate;
        private System.Windows.Forms.DataGridView dgvHotelRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHotelRateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHotelRatePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHotelRateHotel;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbHotelRateActions;
        private System.Windows.Forms.TabPage tabAirlineRate;
    }
}