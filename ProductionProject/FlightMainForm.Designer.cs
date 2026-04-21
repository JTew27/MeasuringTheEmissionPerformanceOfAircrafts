namespace ProductionProject
{
    partial class FlightMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightMainForm));
            Refresh = new Button();
            dataGridView1 = new DataGridView();
            icao24DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            callsign = new DataGridViewTextBoxColumn();
            origincountryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastcontactDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ongroundDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            Velocity = new DataGridViewTextBoxColumn();
            baro_altitude = new DataGridViewTextBoxColumn();
            vertical_rate = new DataGridViewTextBoxColumn();
            geo_altitude = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            flightsInfoBindingSource = new BindingSource(components);
            aPIBindingSource = new BindingSource(components);
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel3 = new TableLayoutPanel();
            clockLabel = new Label();
            comboBox1 = new ComboBox();
            entryBox = new TextBox();
            submitButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            departureLabel = new Label();
            arrivalLabel = new Label();
            dataGridView3 = new DataGridView();
            icao24DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            firstSeenDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            estDepartureAirportDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            lastSeenDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            callsignDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            airportArrivalsBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            icao24DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            firstSeenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estDepartureAirportDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastSeenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            callsignDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            airportDeparturesBindingSource = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            ICAO = new Label();
            CallsignLabel = new Label();
            TypecodeLabel = new Label();
            FuelFlow = new Label();
            flightPhaseLabel = new Label();
            EngineLabel = new Label();
            IcaoLabelInfo = new Label();
            CallsignLabelInfo = new Label();
            TypecodeLabelInfo = new Label();
            FuelFlowLabelInfo = new Label();
            FlightPhaseInfoLabel = new Label();
            EngineCountLabelInfo = new Label();
            flightInfoLabel = new Label();
            ShowDetectBox = new CheckBox();
            printDialog1 = new PrintDialog();
            sensorsBindingSource = new BindingSource(components);
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flightsInfoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aPIBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)airportArrivalsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)airportDeparturesBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sensorsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Refresh
            // 
            Refresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Refresh.BackColor = Color.FromArgb(128, 255, 128);
            Refresh.BackgroundImageLayout = ImageLayout.None;
            Refresh.Location = new Point(695, 878);
            Refresh.Margin = new Padding(2);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(390, 32);
            Refresh.TabIndex = 1;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = false;
            Refresh.Click += Refresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.DarkSlateGray;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9.163636F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { icao24DataGridViewTextBoxColumn, callsign, origincountryDataGridViewTextBoxColumn, lastcontactDataGridViewTextBoxColumn, ongroundDataGridViewCheckBoxColumn, Velocity, baro_altitude, vertical_rate, geo_altitude, category });
            dataGridView1.DataSource = flightsInfoBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "--";
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(13, 57);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 45;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "--";
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.Size = new Size(977, 304);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // icao24DataGridViewTextBoxColumn
            // 
            icao24DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            icao24DataGridViewTextBoxColumn.DataPropertyName = "icao24";
            icao24DataGridViewTextBoxColumn.DividerWidth = 1;
            icao24DataGridViewTextBoxColumn.HeaderText = "ICAO24 Code";
            icao24DataGridViewTextBoxColumn.MinimumWidth = 8;
            icao24DataGridViewTextBoxColumn.Name = "icao24DataGridViewTextBoxColumn";
            icao24DataGridViewTextBoxColumn.ReadOnly = true;
            icao24DataGridViewTextBoxColumn.ToolTipText = "24-bit Unique identifier ICAO transponder ID which can be used to track specific flights ";
            icao24DataGridViewTextBoxColumn.Width = 123;
            // 
            // callsign
            // 
            callsign.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            callsign.DataPropertyName = "callsign";
            callsign.HeaderText = "Callsign";
            callsign.MinimumWidth = 8;
            callsign.Name = "callsign";
            callsign.ReadOnly = true;
            callsign.ToolTipText = " Most airlines indicate the airline and the flight number in the callsign";
            callsign.Width = 89;
            // 
            // origincountryDataGridViewTextBoxColumn
            // 
            origincountryDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            origincountryDataGridViewTextBoxColumn.DataPropertyName = "origin_country";
            origincountryDataGridViewTextBoxColumn.HeaderText = "Country of Origin";
            origincountryDataGridViewTextBoxColumn.MinimumWidth = 8;
            origincountryDataGridViewTextBoxColumn.Name = "origincountryDataGridViewTextBoxColumn";
            origincountryDataGridViewTextBoxColumn.ReadOnly = true;
            origincountryDataGridViewTextBoxColumn.ToolTipText = "Where the aircraft is registered";
            origincountryDataGridViewTextBoxColumn.Width = 107;
            // 
            // lastcontactDataGridViewTextBoxColumn
            // 
            lastcontactDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            lastcontactDataGridViewTextBoxColumn.DataPropertyName = "last_contact";
            lastcontactDataGridViewTextBoxColumn.FillWeight = 90F;
            lastcontactDataGridViewTextBoxColumn.HeaderText = "Last Contact";
            lastcontactDataGridViewTextBoxColumn.MinimumWidth = 8;
            lastcontactDataGridViewTextBoxColumn.Name = "lastcontactDataGridViewTextBoxColumn";
            lastcontactDataGridViewTextBoxColumn.ReadOnly = true;
            lastcontactDataGridViewTextBoxColumn.ToolTipText = "Time at which data was last recieved from aircraft";
            lastcontactDataGridViewTextBoxColumn.Width = 115;
            // 
            // ongroundDataGridViewCheckBoxColumn
            // 
            ongroundDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ongroundDataGridViewCheckBoxColumn.DataPropertyName = "on_ground";
            ongroundDataGridViewCheckBoxColumn.HeaderText = "On Ground";
            ongroundDataGridViewCheckBoxColumn.MinimumWidth = 8;
            ongroundDataGridViewCheckBoxColumn.Name = "ongroundDataGridViewCheckBoxColumn";
            ongroundDataGridViewCheckBoxColumn.ReadOnly = true;
            ongroundDataGridViewCheckBoxColumn.Width = 81;
            // 
            // Velocity
            // 
            Velocity.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Velocity.DataPropertyName = "velocity";
            Velocity.HeaderText = "Velocity m/s";
            Velocity.MinimumWidth = 8;
            Velocity.Name = "Velocity";
            Velocity.ReadOnly = true;
            Velocity.ToolTipText = "The speed over ground of the aircraft in meters per second";
            Velocity.Width = 113;
            // 
            // baro_altitude
            // 
            baro_altitude.DataPropertyName = "baro_altitude";
            baro_altitude.HeaderText = "Baro Altitude m";
            baro_altitude.MinimumWidth = 8;
            baro_altitude.Name = "baro_altitude";
            baro_altitude.ReadOnly = true;
            baro_altitude.ToolTipText = "Barometric Altitude in metres -0 means it is on the ground";
            baro_altitude.Width = 150;
            // 
            // vertical_rate
            // 
            vertical_rate.DataPropertyName = "vertical_rate";
            vertical_rate.HeaderText = "Vertical Rate m/s";
            vertical_rate.MinimumWidth = 8;
            vertical_rate.Name = "vertical_rate";
            vertical_rate.ReadOnly = true;
            vertical_rate.ToolTipText = "A positive value indicates that the airplane is climbing, a negative value indicates that it descends";
            vertical_rate.Width = 150;
            // 
            // geo_altitude
            // 
            geo_altitude.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            geo_altitude.DataPropertyName = "geo_altitude";
            geo_altitude.HeaderText = "Geo Altitude";
            geo_altitude.MinimumWidth = 8;
            geo_altitude.Name = "geo_altitude";
            geo_altitude.ReadOnly = true;
            geo_altitude.ToolTipText = "Geometric Altitude measured by on board barometer";
            geo_altitude.Width = 112;
            // 
            // category
            // 
            category.DataPropertyName = "category";
            category.HeaderText = "category";
            category.MinimumWidth = 6;
            category.Name = "category";
            category.Width = 115;
            // 
            // flightsInfoBindingSource
            // 
            flightsInfoBindingSource.DataSource = typeof(flightsInfo);
            // 
            // aPIBindingSource
            // 
            aPIBindingSource.DataSource = typeof(API);
            // 
            // gMapControl1
            // 
            gMapControl1.AutoSize = true;
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.Dock = DockStyle.Left;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.ForeColor = SystemColors.ActiveCaptionText;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(0, 0);
            gMapControl1.Margin = new Padding(2);
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 2;
            gMapControl1.MinZoom = 2;
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.Name = "gMapControl1";
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.RetryLoadTile = 0;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapControl1.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Size = new Size(0, 864);
            gMapControl1.TabIndex = 6;
            gMapControl1.Zoom = 0D;
            gMapControl1.Load += gMapControl1_Load;
            // 
            // splitContainer1
            // 
            splitContainer1.AllowDrop = true;
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(2, 10);
            splitContainer1.Margin = new Padding(2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.LightCyan;
            splitContainer1.Panel1.Controls.Add(gMapControl1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(0, 64, 64);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel3);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel2.Controls.Add(flightInfoLabel);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1711, 864);
            splitContainer1.SplitterDistance = 737;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 193F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 337F));
            tableLayoutPanel3.Controls.Add(clockLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(comboBox1, 3, 0);
            tableLayoutPanel3.Controls.Add(entryBox, 1, 0);
            tableLayoutPanel3.Controls.Add(submitButton, 2, 0);
            tableLayoutPanel3.Location = new Point(15, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(944, 30);
            tableLayoutPanel3.TabIndex = 22;
            // 
            // clockLabel
            // 
            clockLabel.AutoSize = true;
            clockLabel.BackColor = SystemColors.ActiveCaptionText;
            clockLabel.Font = new Font("Ebrima", 11.1272726F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clockLabel.ForeColor = Color.SpringGreen;
            clockLabel.Location = new Point(2, 0);
            clockLabel.Margin = new Padding(2, 0, 2, 0);
            clockLabel.Name = "clockLabel";
            clockLabel.Size = new Size(59, 23);
            clockLabel.TabIndex = 16;
            clockLabel.Text = "label4";
            clockLabel.Click += label4_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Menu;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { " Airline Callsigns", "AFR = Air France", "BAW = British Airways", "DLH = Lufthansa", "EAG = Emerald Airlines", "EXS = Jet2", "EZY = easyJet", "GLID = Glider", "KLM = KLM Royal Dutch Airlines", "LOG = Loganair", "QTR = Qatar Airways", "RYR = Ryanair", "UAE = Emirates", "VIR = Virgin Atlantic", "WZZ = Wizz Air" });
            comboBox1.Location = new Point(610, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 27);
            comboBox1.TabIndex = 21;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // entryBox
            // 
            entryBox.BackColor = Color.Azure;
            entryBox.Cursor = Cursors.IBeam;
            entryBox.Font = new Font("Britannic Bold", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryBox.ForeColor = SystemColors.MenuHighlight;
            entryBox.Location = new Point(209, 2);
            entryBox.Margin = new Padding(2);
            entryBox.Name = "entryBox";
            entryBox.PlaceholderText = "Search Location";
            entryBox.Size = new Size(199, 23);
            entryBox.TabIndex = 10;
            entryBox.TextAlign = HorizontalAlignment.Center;
            entryBox.TextChanged += entryBox_TextChanged;
            // 
            // submitButton
            // 
            submitButton.Font = new Font("Segoe UI", 9.163636F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitButton.Location = new Point(416, 2);
            submitButton.Margin = new Padding(2);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(54, 24);
            submitButton.TabIndex = 17;
            submitButton.Text = "GO";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(departureLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(arrivalLabel, 1, 0);
            tableLayoutPanel2.Controls.Add(dataGridView3, 1, 1);
            tableLayoutPanel2.Controls.Add(dataGridView2, 0, 1);
            tableLayoutPanel2.Location = new Point(13, 380);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 258F));
            tableLayoutPanel2.Size = new Size(950, 281);
            tableLayoutPanel2.TabIndex = 20;
            // 
            // departureLabel
            // 
            departureLabel.AutoSize = true;
            departureLabel.BackColor = SystemColors.Info;
            departureLabel.Location = new Point(2, 0);
            departureLabel.Margin = new Padding(2, 0, 2, 0);
            departureLabel.Name = "departureLabel";
            departureLabel.Size = new Size(171, 19);
            departureLabel.TabIndex = 14;
            departureLabel.Text = "Airport Departures (24hrs)";
            departureLabel.Click += departureLabel_Click;
            // 
            // arrivalLabel
            // 
            arrivalLabel.AutoSize = true;
            arrivalLabel.BackColor = SystemColors.Info;
            arrivalLabel.Location = new Point(477, 0);
            arrivalLabel.Margin = new Padding(2, 0, 2, 0);
            arrivalLabel.Name = "arrivalLabel";
            arrivalLabel.Size = new Size(152, 19);
            arrivalLabel.TabIndex = 15;
            arrivalLabel.Text = "Airport Arrivals (24 hrs)";
            arrivalLabel.Click += arrivalLabel_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToOrderColumns = true;
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView3.BackgroundColor = SystemColors.Info;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Consolas", 9.163636F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { icao24DataGridViewTextBoxColumn2, firstSeenDataGridViewTextBoxColumn1, estDepartureAirportDataGridViewTextBoxColumn1, lastSeenDataGridViewTextBoxColumn1, callsignDataGridViewTextBoxColumn1 });
            dataGridView3.DataSource = airportArrivalsBindingSource;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Sylfaen", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.NullValue = "--";
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.GridColor = SystemColors.ScrollBar;
            dataGridView3.Location = new Point(478, 26);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Consolas", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 51;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView3.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridView3.ShowEditingIcon = false;
            dataGridView3.Size = new Size(469, 252);
            dataGridView3.TabIndex = 18;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // icao24DataGridViewTextBoxColumn2
            // 
            icao24DataGridViewTextBoxColumn2.DataPropertyName = "icao24";
            icao24DataGridViewTextBoxColumn2.HeaderText = "ICAO24";
            icao24DataGridViewTextBoxColumn2.MinimumWidth = 8;
            icao24DataGridViewTextBoxColumn2.Name = "icao24DataGridViewTextBoxColumn2";
            icao24DataGridViewTextBoxColumn2.ReadOnly = true;
            icao24DataGridViewTextBoxColumn2.ToolTipText = "Aircrafts Unique ICAO Identifier";
            icao24DataGridViewTextBoxColumn2.Width = 85;
            // 
            // firstSeenDataGridViewTextBoxColumn1
            // 
            firstSeenDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            firstSeenDataGridViewTextBoxColumn1.DataPropertyName = "firstSeen";
            firstSeenDataGridViewTextBoxColumn1.HeaderText = "First Seen ";
            firstSeenDataGridViewTextBoxColumn1.MinimumWidth = 8;
            firstSeenDataGridViewTextBoxColumn1.Name = "firstSeenDataGridViewTextBoxColumn1";
            firstSeenDataGridViewTextBoxColumn1.ReadOnly = true;
            firstSeenDataGridViewTextBoxColumn1.ToolTipText = "Date/Time was first detected";
            firstSeenDataGridViewTextBoxColumn1.Width = 8;
            // 
            // estDepartureAirportDataGridViewTextBoxColumn1
            // 
            estDepartureAirportDataGridViewTextBoxColumn1.DataPropertyName = "estDepartureAirport";
            estDepartureAirportDataGridViewTextBoxColumn1.HeaderText = "Airport Departed";
            estDepartureAirportDataGridViewTextBoxColumn1.MinimumWidth = 8;
            estDepartureAirportDataGridViewTextBoxColumn1.Name = "estDepartureAirportDataGridViewTextBoxColumn1";
            estDepartureAirportDataGridViewTextBoxColumn1.ReadOnly = true;
            estDepartureAirportDataGridViewTextBoxColumn1.Width = 151;
            // 
            // lastSeenDataGridViewTextBoxColumn1
            // 
            lastSeenDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            lastSeenDataGridViewTextBoxColumn1.DataPropertyName = "lastSeen";
            lastSeenDataGridViewTextBoxColumn1.HeaderText = "Last Seen";
            lastSeenDataGridViewTextBoxColumn1.MinimumWidth = 8;
            lastSeenDataGridViewTextBoxColumn1.Name = "lastSeenDataGridViewTextBoxColumn1";
            lastSeenDataGridViewTextBoxColumn1.ReadOnly = true;
            lastSeenDataGridViewTextBoxColumn1.ToolTipText = "Date/Time Flight was last Detected";
            lastSeenDataGridViewTextBoxColumn1.Width = 72;
            // 
            // callsignDataGridViewTextBoxColumn1
            // 
            callsignDataGridViewTextBoxColumn1.DataPropertyName = "callsign";
            callsignDataGridViewTextBoxColumn1.HeaderText = "callsign";
            callsignDataGridViewTextBoxColumn1.MinimumWidth = 8;
            callsignDataGridViewTextBoxColumn1.Name = "callsignDataGridViewTextBoxColumn1";
            callsignDataGridViewTextBoxColumn1.ReadOnly = true;
            callsignDataGridViewTextBoxColumn1.Width = 101;
            // 
            // airportArrivalsBindingSource
            // 
            airportArrivalsBindingSource.DataSource = typeof(airportArrivals);
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView2.BackgroundColor = SystemColors.Info;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Consolas", 9.163636F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { icao24DataGridViewTextBoxColumn1, firstSeenDataGridViewTextBoxColumn, estDepartureAirportDataGridViewTextBoxColumn, lastSeenDataGridViewTextBoxColumn, callsignDataGridViewTextBoxColumn });
            dataGridView2.DataSource = airportDeparturesBindingSource;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Consolas", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridView2.GridColor = SystemColors.ActiveBorder;
            dataGridView2.Location = new Point(3, 26);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Consolas", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(469, 252);
            dataGridView2.TabIndex = 18;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // icao24DataGridViewTextBoxColumn1
            // 
            icao24DataGridViewTextBoxColumn1.DataPropertyName = "icao24";
            icao24DataGridViewTextBoxColumn1.HeaderText = "ICAO24";
            icao24DataGridViewTextBoxColumn1.MinimumWidth = 6;
            icao24DataGridViewTextBoxColumn1.Name = "icao24DataGridViewTextBoxColumn1";
            icao24DataGridViewTextBoxColumn1.ReadOnly = true;
            icao24DataGridViewTextBoxColumn1.ToolTipText = "Aircrafts Unique Identifier";
            icao24DataGridViewTextBoxColumn1.Width = 85;
            // 
            // firstSeenDataGridViewTextBoxColumn
            // 
            firstSeenDataGridViewTextBoxColumn.DataPropertyName = "firstSeen";
            firstSeenDataGridViewTextBoxColumn.HeaderText = "First Seen";
            firstSeenDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstSeenDataGridViewTextBoxColumn.Name = "firstSeenDataGridViewTextBoxColumn";
            firstSeenDataGridViewTextBoxColumn.ReadOnly = true;
            firstSeenDataGridViewTextBoxColumn.ToolTipText = "Date/time the flight was first detected";
            firstSeenDataGridViewTextBoxColumn.Width = 117;
            // 
            // estDepartureAirportDataGridViewTextBoxColumn
            // 
            estDepartureAirportDataGridViewTextBoxColumn.DataPropertyName = "estDepartureAirport";
            estDepartureAirportDataGridViewTextBoxColumn.HeaderText = "Departed";
            estDepartureAirportDataGridViewTextBoxColumn.MinimumWidth = 6;
            estDepartureAirportDataGridViewTextBoxColumn.Name = "estDepartureAirportDataGridViewTextBoxColumn";
            estDepartureAirportDataGridViewTextBoxColumn.ReadOnly = true;
            estDepartureAirportDataGridViewTextBoxColumn.ToolTipText = "Airport that this flight departed ";
            estDepartureAirportDataGridViewTextBoxColumn.Width = 101;
            // 
            // lastSeenDataGridViewTextBoxColumn
            // 
            lastSeenDataGridViewTextBoxColumn.DataPropertyName = "lastSeen";
            lastSeenDataGridViewTextBoxColumn.HeaderText = "Last Seen";
            lastSeenDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastSeenDataGridViewTextBoxColumn.Name = "lastSeenDataGridViewTextBoxColumn";
            lastSeenDataGridViewTextBoxColumn.ReadOnly = true;
            lastSeenDataGridViewTextBoxColumn.ToolTipText = "Date/Time Flight was first Detected";
            lastSeenDataGridViewTextBoxColumn.Width = 109;
            // 
            // callsignDataGridViewTextBoxColumn
            // 
            callsignDataGridViewTextBoxColumn.DataPropertyName = "callsign";
            callsignDataGridViewTextBoxColumn.HeaderText = "Callsign";
            callsignDataGridViewTextBoxColumn.MinimumWidth = 6;
            callsignDataGridViewTextBoxColumn.Name = "callsignDataGridViewTextBoxColumn";
            callsignDataGridViewTextBoxColumn.ReadOnly = true;
            callsignDataGridViewTextBoxColumn.ToolTipText = "Aircrafts unique callsign usually associating with Company";
            callsignDataGridViewTextBoxColumn.Width = 101;
            // 
            // airportDeparturesBindingSource
            // 
            airportDeparturesBindingSource.DataSource = typeof(airportDepartures);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Center;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.9100456F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.08996F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 242F));
            tableLayoutPanel1.Controls.Add(ICAO, 0, 0);
            tableLayoutPanel1.Controls.Add(CallsignLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(TypecodeLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(FuelFlow, 2, 0);
            tableLayoutPanel1.Controls.Add(flightPhaseLabel, 2, 1);
            tableLayoutPanel1.Controls.Add(EngineLabel, 2, 2);
            tableLayoutPanel1.Controls.Add(IcaoLabelInfo, 1, 0);
            tableLayoutPanel1.Controls.Add(CallsignLabelInfo, 1, 1);
            tableLayoutPanel1.Controls.Add(TypecodeLabelInfo, 1, 2);
            tableLayoutPanel1.Controls.Add(FuelFlowLabelInfo, 3, 0);
            tableLayoutPanel1.Controls.Add(FlightPhaseInfoLabel, 3, 1);
            tableLayoutPanel1.Controls.Add(EngineCountLabelInfo, 3, 2);
            tableLayoutPanel1.Font = new Font("Century", 11.1272726F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(70, 684);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40.22989F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 59.7701149F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.Size = new Size(860, 156);
            tableLayoutPanel1.TabIndex = 19;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // ICAO
            // 
            ICAO.AutoSize = true;
            ICAO.Location = new Point(5, 2);
            ICAO.Name = "ICAO";
            ICAO.Size = new Size(58, 21);
            ICAO.TabIndex = 0;
            ICAO.Text = "ICAO";
            // 
            // CallsignLabel
            // 
            CallsignLabel.AutoSize = true;
            CallsignLabel.Location = new Point(5, 50);
            CallsignLabel.Name = "CallsignLabel";
            CallsignLabel.Size = new Size(81, 21);
            CallsignLabel.TabIndex = 1;
            CallsignLabel.Text = "Callsign";
            // 
            // TypecodeLabel
            // 
            TypecodeLabel.AutoSize = true;
            TypecodeLabel.Location = new Point(5, 120);
            TypecodeLabel.Name = "TypecodeLabel";
            TypecodeLabel.Size = new Size(93, 21);
            TypecodeLabel.TabIndex = 3;
            TypecodeLabel.Text = "Typecode";
            // 
            // FuelFlow
            // 
            FuelFlow.AutoSize = true;
            FuelFlow.Location = new Point(516, 2);
            FuelFlow.Name = "FuelFlow";
            FuelFlow.Size = new Size(55, 42);
            FuelFlow.TabIndex = 2;
            FuelFlow.Text = "Fuel Flow";
            // 
            // flightPhaseLabel
            // 
            flightPhaseLabel.AutoSize = true;
            flightPhaseLabel.Location = new Point(516, 50);
            flightPhaseLabel.Name = "flightPhaseLabel";
            flightPhaseLabel.Size = new Size(69, 42);
            flightPhaseLabel.TabIndex = 4;
            flightPhaseLabel.Text = "Flight Phase";
            // 
            // EngineLabel
            // 
            EngineLabel.AutoSize = true;
            EngineLabel.Location = new Point(516, 120);
            EngineLabel.Name = "EngineLabel";
            EngineLabel.Size = new Size(77, 34);
            EngineLabel.TabIndex = 5;
            EngineLabel.Text = "Engine Count";
            // 
            // IcaoLabelInfo
            // 
            IcaoLabelInfo.AutoSize = true;
            IcaoLabelInfo.Location = new Point(219, 2);
            IcaoLabelInfo.Name = "IcaoLabelInfo";
            IcaoLabelInfo.Size = new Size(24, 21);
            IcaoLabelInfo.TabIndex = 6;
            IcaoLabelInfo.Text = "--";
            // 
            // CallsignLabelInfo
            // 
            CallsignLabelInfo.AutoSize = true;
            CallsignLabelInfo.Location = new Point(219, 50);
            CallsignLabelInfo.Name = "CallsignLabelInfo";
            CallsignLabelInfo.Size = new Size(24, 21);
            CallsignLabelInfo.TabIndex = 7;
            CallsignLabelInfo.Text = "--";
            // 
            // TypecodeLabelInfo
            // 
            TypecodeLabelInfo.AutoSize = true;
            TypecodeLabelInfo.Location = new Point(219, 120);
            TypecodeLabelInfo.Name = "TypecodeLabelInfo";
            TypecodeLabelInfo.Size = new Size(24, 21);
            TypecodeLabelInfo.TabIndex = 8;
            TypecodeLabelInfo.Text = "--";
            // 
            // FuelFlowLabelInfo
            // 
            FuelFlowLabelInfo.AutoSize = true;
            FuelFlowLabelInfo.Location = new Point(618, 2);
            FuelFlowLabelInfo.Name = "FuelFlowLabelInfo";
            FuelFlowLabelInfo.Size = new Size(24, 21);
            FuelFlowLabelInfo.TabIndex = 9;
            FuelFlowLabelInfo.Text = "--";
            // 
            // FlightPhaseInfoLabel
            // 
            FlightPhaseInfoLabel.AutoSize = true;
            FlightPhaseInfoLabel.Location = new Point(618, 50);
            FlightPhaseInfoLabel.Name = "FlightPhaseInfoLabel";
            FlightPhaseInfoLabel.Size = new Size(24, 21);
            FlightPhaseInfoLabel.TabIndex = 10;
            FlightPhaseInfoLabel.Text = "--";
            // 
            // EngineCountLabelInfo
            // 
            EngineCountLabelInfo.AutoSize = true;
            EngineCountLabelInfo.Location = new Point(618, 120);
            EngineCountLabelInfo.Name = "EngineCountLabelInfo";
            EngineCountLabelInfo.Size = new Size(24, 21);
            EngineCountLabelInfo.TabIndex = 11;
            EngineCountLabelInfo.Text = "--";
            // 
            // flightInfoLabel
            // 
            flightInfoLabel.AutoSize = true;
            flightInfoLabel.BackColor = SystemColors.GradientInactiveCaption;
            flightInfoLabel.Location = new Point(13, 36);
            flightInfoLabel.Margin = new Padding(2, 0, 2, 0);
            flightInfoLabel.Name = "flightInfoLabel";
            flightInfoLabel.Size = new Size(122, 19);
            flightInfoLabel.TabIndex = 13;
            flightInfoLabel.Text = "Current Flight Info";
            // 
            // ShowDetectBox
            // 
            ShowDetectBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ShowDetectBox.AutoSize = true;
            ShowDetectBox.Location = new Point(10, 878);
            ShowDetectBox.Margin = new Padding(2);
            ShowDetectBox.Name = "ShowDetectBox";
            ShowDetectBox.Size = new Size(204, 23);
            ShowDetectBox.TabIndex = 7;
            ShowDetectBox.Text = "Show Default Detection Area";
            ShowDetectBox.UseVisualStyleBackColor = true;
            ShowDetectBox.CheckedChanged += ShowDetectBox_CheckedChanged;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // sensorsBindingSource
            // 
            sensorsBindingSource.DataMember = "sensors";
            sensorsBindingSource.DataSource = flightsInfoBindingSource;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(339, 879);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(176, 23);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Dynamic Detection Area";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // FlightMainForm
            // 
            AcceptButton = Refresh;
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1717, 913);
            Controls.Add(checkBox1);
            Controls.Add(Refresh);
            Controls.Add(ShowDetectBox);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FlightMainForm";
            Text = "Flight Tracker";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)flightsInfoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)aPIBindingSource).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)airportArrivalsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)airportDeparturesBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sensorsBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Refresh;
        private BindingSource aPIBindingSource;
        private DataGridView dataGridView1;
        private BindingSource flightsInfoBindingSource;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private SplitContainer splitContainer1;
        private CheckBox ShowDetectBox;
        private BindingSource airportDeparturesBindingSource;
        private DataGridView dataGridView3;
        private BindingSource airportArrivalsBindingSource;
        private TextBox entryBox;
        private PrintDialog printDialog1;
        private Label arrivalLabel;
        private Label departureLabel;
        private Label flightInfoLabel;
        private Label clockLabel;
        private Button submitButton;
        private DataGridView dataGridView2;
        private BindingSource sensorsBindingSource;
        private TableLayoutPanel tableLayoutPanel1;
        private Label ICAO;
        private Label CallsignLabel;
        private Label FuelFlow;
        private Label TypecodeLabel;
        private Label flightPhaseLabel;
        private Label EngineLabel;
        private Label IcaoLabelInfo;
        private Label CallsignLabelInfo;
        private Label TypecodeLabelInfo;
        private Label FuelFlowLabelInfo;
        private Label FlightPhaseInfoLabel;
        private Label EngineCountLabelInfo;
        private DataGridViewTextBoxColumn icao24DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn firstSeenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estDepartureAirportDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastSeenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn callsignDataGridViewTextBoxColumn;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox comboBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridViewTextBoxColumn icao24DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn callsign;
        private DataGridViewTextBoxColumn origincountryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastcontactDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn ongroundDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn Velocity;
        private DataGridViewTextBoxColumn baro_altitude;
        private DataGridViewTextBoxColumn vertical_rate;
        private DataGridViewTextBoxColumn geo_altitude;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn icao24DataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn firstSeenDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn estDepartureAirportDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lastSeenDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn callsignDataGridViewTextBoxColumn1;
        private CheckBox checkBox1;
    }
}
