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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightMainForm));
            Refresh = new Button();
            dataGridView1 = new DataGridView();
            icao24DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            callsign = new DataGridViewTextBoxColumn();
            origincountryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastcontactDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ongroundDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            category = new DataGridViewTextBoxColumn();
            Velocity = new DataGridViewTextBoxColumn();
            baro_altitude = new DataGridViewTextBoxColumn();
            vertical_rate = new DataGridViewTextBoxColumn();
            geo_altitude = new DataGridViewTextBoxColumn();
            flightsInfoBindingSource = new BindingSource(components);
            aPIBindingSource = new BindingSource(components);
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            splitContainer1 = new SplitContainer();
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
            dataGridView3 = new DataGridView();
            icao24DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            firstSeenDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            estDepartureAirportDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            lastSeenDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            callsignDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            airportArrivalsBindingSource = new BindingSource(components);
            arrivalLabel = new Label();
            submitButton = new Button();
            departureLabel = new Label();
            clockLabel = new Label();
            flightInfoLabel = new Label();
            entryBox = new TextBox();
            dataGridView2 = new DataGridView();
            icao24DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            firstSeenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estDepartureAirportDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastSeenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            callsignDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            airportDeparturesBindingSource = new BindingSource(components);
            ShowDetectBox = new CheckBox();
            printDialog1 = new PrintDialog();
            sensorsBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flightsInfoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aPIBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)airportArrivalsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)airportDeparturesBindingSource).BeginInit();
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { icao24DataGridViewTextBoxColumn, callsign, origincountryDataGridViewTextBoxColumn, lastcontactDataGridViewTextBoxColumn, ongroundDataGridViewCheckBoxColumn, category, Velocity, baro_altitude, vertical_rate, geo_altitude });
            dataGridView1.DataSource = flightsInfoBindingSource;
            dataGridView1.Location = new Point(11, 57);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.Size = new Size(871, 281);
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
            icao24DataGridViewTextBoxColumn.Width = 114;
            // 
            // callsign
            // 
            callsign.DataPropertyName = "callsign";
            callsign.HeaderText = "Callsign";
            callsign.MinimumWidth = 8;
            callsign.Name = "callsign";
            callsign.ReadOnly = true;
            callsign.ToolTipText = " Most airlines indicate the airline and the flight number in the callsign";
            callsign.Width = 150;
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
            // 
            // lastcontactDataGridViewTextBoxColumn
            // 
            lastcontactDataGridViewTextBoxColumn.DataPropertyName = "last_contact";
            lastcontactDataGridViewTextBoxColumn.FillWeight = 90F;
            lastcontactDataGridViewTextBoxColumn.HeaderText = "Last Contact";
            lastcontactDataGridViewTextBoxColumn.MinimumWidth = 8;
            lastcontactDataGridViewTextBoxColumn.Name = "lastcontactDataGridViewTextBoxColumn";
            lastcontactDataGridViewTextBoxColumn.ReadOnly = true;
            lastcontactDataGridViewTextBoxColumn.ToolTipText = "Time at which data was last recieved from aircraft";
            lastcontactDataGridViewTextBoxColumn.Width = 150;
            // 
            // ongroundDataGridViewCheckBoxColumn
            // 
            ongroundDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ongroundDataGridViewCheckBoxColumn.DataPropertyName = "on_ground";
            ongroundDataGridViewCheckBoxColumn.HeaderText = "On Ground";
            ongroundDataGridViewCheckBoxColumn.MinimumWidth = 8;
            ongroundDataGridViewCheckBoxColumn.Name = "ongroundDataGridViewCheckBoxColumn";
            ongroundDataGridViewCheckBoxColumn.ReadOnly = true;
            ongroundDataGridViewCheckBoxColumn.Width = 77;
            // 
            // category
            // 
            category.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            category.DataPropertyName = "category";
            category.HeaderText = "category";
            category.MinimumWidth = 8;
            category.Name = "category";
            category.Width = 91;
            // 
            // Velocity
            // 
            Velocity.DataPropertyName = "velocity";
            Velocity.HeaderText = "Velocity m/s";
            Velocity.MinimumWidth = 8;
            Velocity.Name = "Velocity";
            Velocity.ReadOnly = true;
            Velocity.ToolTipText = "The speed over ground of the aircraft in meters per second";
            Velocity.Width = 150;
            // 
            // baro_altitude
            // 
            baro_altitude.DataPropertyName = "baro_altitude";
            baro_altitude.HeaderText = "Baro Altitude m";
            baro_altitude.MinimumWidth = 8;
            baro_altitude.Name = "baro_altitude";
            baro_altitude.ReadOnly = true;
            baro_altitude.ToolTipText = "Barometric Altitude in metres";
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
            geo_altitude.DataPropertyName = "geo_altitude";
            geo_altitude.HeaderText = "Geo Altitude";
            geo_altitude.MinimumWidth = 8;
            geo_altitude.Name = "geo_altitude";
            geo_altitude.ReadOnly = true;
            geo_altitude.ToolTipText = "Geometric Altitude measured by on board barometer";
            geo_altitude.Width = 150;
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
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel2.Controls.Add(dataGridView3);
            splitContainer1.Panel2.Controls.Add(arrivalLabel);
            splitContainer1.Panel2.Controls.Add(submitButton);
            splitContainer1.Panel2.Controls.Add(departureLabel);
            splitContainer1.Panel2.Controls.Add(clockLabel);
            splitContainer1.Panel2.Controls.Add(flightInfoLabel);
            splitContainer1.Panel2.Controls.Add(entryBox);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Controls.Add(dataGridView2);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1711, 864);
            splitContainer1.SplitterDistance = 884;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.13814F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.8618622F));
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
            tableLayoutPanel1.Location = new Point(78, 684);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40.22989F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 59.7701149F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(672, 156);
            tableLayoutPanel1.TabIndex = 19;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // ICAO
            // 
            ICAO.AutoSize = true;
            ICAO.Location = new Point(3, 0);
            ICAO.Name = "ICAO";
            ICAO.Size = new Size(42, 19);
            ICAO.TabIndex = 0;
            ICAO.Text = "ICAO";
            // 
            // CallsignLabel
            // 
            CallsignLabel.AutoSize = true;
            CallsignLabel.Location = new Point(3, 49);
            CallsignLabel.Name = "CallsignLabel";
            CallsignLabel.Size = new Size(56, 19);
            CallsignLabel.TabIndex = 1;
            CallsignLabel.Text = "Callsign";
            // 
            // TypecodeLabel
            // 
            TypecodeLabel.AutoSize = true;
            TypecodeLabel.Location = new Point(3, 122);
            TypecodeLabel.Name = "TypecodeLabel";
            TypecodeLabel.Size = new Size(66, 19);
            TypecodeLabel.TabIndex = 3;
            TypecodeLabel.Text = "Typecode";
            // 
            // FuelFlow
            // 
            FuelFlow.AutoSize = true;
            FuelFlow.Location = new Point(332, 0);
            FuelFlow.Name = "FuelFlow";
            FuelFlow.Size = new Size(66, 19);
            FuelFlow.TabIndex = 2;
            FuelFlow.Text = "Fuel Flow";
            // 
            // flightPhaseLabel
            // 
            flightPhaseLabel.AutoSize = true;
            flightPhaseLabel.Location = new Point(332, 49);
            flightPhaseLabel.Name = "flightPhaseLabel";
            flightPhaseLabel.Size = new Size(83, 19);
            flightPhaseLabel.TabIndex = 4;
            flightPhaseLabel.Text = "Flight Phase";
            // 
            // EngineLabel
            // 
            EngineLabel.AutoSize = true;
            EngineLabel.Location = new Point(332, 122);
            EngineLabel.Name = "EngineLabel";
            EngineLabel.Size = new Size(92, 19);
            EngineLabel.TabIndex = 5;
            EngineLabel.Text = "Engine Count";
            // 
            // IcaoLabelInfo
            // 
            IcaoLabelInfo.AutoSize = true;
            IcaoLabelInfo.Location = new Point(128, 0);
            IcaoLabelInfo.Name = "IcaoLabelInfo";
            IcaoLabelInfo.Size = new Size(21, 19);
            IcaoLabelInfo.TabIndex = 6;
            IcaoLabelInfo.Text = "--";
            // 
            // CallsignLabelInfo
            // 
            CallsignLabelInfo.AutoSize = true;
            CallsignLabelInfo.Location = new Point(128, 49);
            CallsignLabelInfo.Name = "CallsignLabelInfo";
            CallsignLabelInfo.Size = new Size(21, 19);
            CallsignLabelInfo.TabIndex = 7;
            CallsignLabelInfo.Text = "--";
            // 
            // TypecodeLabelInfo
            // 
            TypecodeLabelInfo.AutoSize = true;
            TypecodeLabelInfo.Location = new Point(128, 122);
            TypecodeLabelInfo.Name = "TypecodeLabelInfo";
            TypecodeLabelInfo.Size = new Size(21, 19);
            TypecodeLabelInfo.TabIndex = 8;
            TypecodeLabelInfo.Text = "--";
            // 
            // FuelFlowLabelInfo
            // 
            FuelFlowLabelInfo.AutoSize = true;
            FuelFlowLabelInfo.Location = new Point(432, 0);
            FuelFlowLabelInfo.Name = "FuelFlowLabelInfo";
            FuelFlowLabelInfo.Size = new Size(21, 19);
            FuelFlowLabelInfo.TabIndex = 9;
            FuelFlowLabelInfo.Text = "--";
            // 
            // FlightPhaseInfoLabel
            // 
            FlightPhaseInfoLabel.AutoSize = true;
            FlightPhaseInfoLabel.Location = new Point(432, 49);
            FlightPhaseInfoLabel.Name = "FlightPhaseInfoLabel";
            FlightPhaseInfoLabel.Size = new Size(21, 19);
            FlightPhaseInfoLabel.TabIndex = 10;
            FlightPhaseInfoLabel.Text = "--";
            // 
            // EngineCountLabelInfo
            // 
            EngineCountLabelInfo.AutoSize = true;
            EngineCountLabelInfo.Location = new Point(432, 122);
            EngineCountLabelInfo.Name = "EngineCountLabelInfo";
            EngineCountLabelInfo.Size = new Size(21, 19);
            EngineCountLabelInfo.TabIndex = 11;
            EngineCountLabelInfo.Text = "--";
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.Anchor = AnchorStyles.Right;
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView3.BackgroundColor = SystemColors.Info;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { icao24DataGridViewTextBoxColumn2, firstSeenDataGridViewTextBoxColumn1, estDepartureAirportDataGridViewTextBoxColumn1, lastSeenDataGridViewTextBoxColumn1, callsignDataGridViewTextBoxColumn1 });
            dataGridView3.DataSource = airportArrivalsBindingSource;
            dataGridView3.GridColor = SystemColors.ScrollBar;
            dataGridView3.Location = new Point(439, 374);
            dataGridView3.Margin = new Padding(2);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridView3.ShowCellToolTips = false;
            dataGridView3.ShowEditingIcon = false;
            dataGridView3.Size = new Size(389, 288);
            dataGridView3.TabIndex = 9;
            // 
            // icao24DataGridViewTextBoxColumn2
            // 
            icao24DataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            icao24DataGridViewTextBoxColumn2.DataPropertyName = "icao24";
            icao24DataGridViewTextBoxColumn2.HeaderText = "ICAO24";
            icao24DataGridViewTextBoxColumn2.MinimumWidth = 8;
            icao24DataGridViewTextBoxColumn2.Name = "icao24DataGridViewTextBoxColumn2";
            icao24DataGridViewTextBoxColumn2.ReadOnly = true;
            icao24DataGridViewTextBoxColumn2.ToolTipText = "Aircrafts Unique ICAO Identifier";
            icao24DataGridViewTextBoxColumn2.Width = 8;
            // 
            // firstSeenDataGridViewTextBoxColumn1
            // 
            firstSeenDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            firstSeenDataGridViewTextBoxColumn1.DataPropertyName = "firstSeen";
            firstSeenDataGridViewTextBoxColumn1.HeaderText = "First Seen ";
            firstSeenDataGridViewTextBoxColumn1.MinimumWidth = 8;
            firstSeenDataGridViewTextBoxColumn1.Name = "firstSeenDataGridViewTextBoxColumn1";
            firstSeenDataGridViewTextBoxColumn1.ReadOnly = true;
            firstSeenDataGridViewTextBoxColumn1.ToolTipText = "Date/Time was first detected";
            firstSeenDataGridViewTextBoxColumn1.Width = 101;
            // 
            // estDepartureAirportDataGridViewTextBoxColumn1
            // 
            estDepartureAirportDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            estDepartureAirportDataGridViewTextBoxColumn1.DataPropertyName = "estDepartureAirport";
            estDepartureAirportDataGridViewTextBoxColumn1.HeaderText = "Airport Departed";
            estDepartureAirportDataGridViewTextBoxColumn1.MinimumWidth = 8;
            estDepartureAirportDataGridViewTextBoxColumn1.Name = "estDepartureAirportDataGridViewTextBoxColumn1";
            estDepartureAirportDataGridViewTextBoxColumn1.ReadOnly = true;
            estDepartureAirportDataGridViewTextBoxColumn1.Width = 142;
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
            lastSeenDataGridViewTextBoxColumn1.Width = 96;
            // 
            // callsignDataGridViewTextBoxColumn1
            // 
            callsignDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            callsignDataGridViewTextBoxColumn1.DataPropertyName = "callsign";
            callsignDataGridViewTextBoxColumn1.HeaderText = "callsign";
            callsignDataGridViewTextBoxColumn1.MinimumWidth = 8;
            callsignDataGridViewTextBoxColumn1.Name = "callsignDataGridViewTextBoxColumn1";
            callsignDataGridViewTextBoxColumn1.ReadOnly = true;
            callsignDataGridViewTextBoxColumn1.Width = 8;
            // 
            // airportArrivalsBindingSource
            // 
            airportArrivalsBindingSource.DataSource = typeof(airportArrivals);
            // 
            // arrivalLabel
            // 
            arrivalLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            arrivalLabel.AutoSize = true;
            arrivalLabel.BackColor = SystemColors.Info;
            arrivalLabel.Location = new Point(438, 350);
            arrivalLabel.Margin = new Padding(2, 0, 2, 0);
            arrivalLabel.Name = "arrivalLabel";
            arrivalLabel.Size = new Size(152, 19);
            arrivalLabel.TabIndex = 15;
            arrivalLabel.Text = "Airport Arrivals (24 hrs)";
            arrivalLabel.Click += arrivalLabel_Click;
            // 
            // submitButton
            // 
            submitButton.Font = new Font("Segoe UI", 9.163636F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitButton.Location = new Point(361, 2);
            submitButton.Margin = new Padding(2);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(54, 24);
            submitButton.TabIndex = 17;
            submitButton.Text = "GO";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // departureLabel
            // 
            departureLabel.Anchor = AnchorStyles.Bottom;
            departureLabel.AutoSize = true;
            departureLabel.BackColor = SystemColors.Info;
            departureLabel.Location = new Point(17, 350);
            departureLabel.Margin = new Padding(2, 0, 2, 0);
            departureLabel.Name = "departureLabel";
            departureLabel.Size = new Size(171, 19);
            departureLabel.TabIndex = 14;
            departureLabel.Text = "Airport Departures (24hrs)";
            departureLabel.Click += departureLabel_Click;
            // 
            // clockLabel
            // 
            clockLabel.AutoSize = true;
            clockLabel.BackColor = SystemColors.ActiveCaptionText;
            clockLabel.ForeColor = Color.SpringGreen;
            clockLabel.Location = new Point(6, 0);
            clockLabel.Margin = new Padding(2, 0, 2, 0);
            clockLabel.Name = "clockLabel";
            clockLabel.Size = new Size(45, 19);
            clockLabel.TabIndex = 16;
            clockLabel.Text = "label4";
            clockLabel.Click += label4_Click;
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
            // entryBox
            // 
            entryBox.BackColor = Color.Azure;
            entryBox.Cursor = Cursors.IBeam;
            entryBox.Font = new Font("Britannic Bold", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryBox.ForeColor = SystemColors.MenuHighlight;
            entryBox.Location = new Point(158, 2);
            entryBox.Margin = new Padding(2);
            entryBox.Name = "entryBox";
            entryBox.PlaceholderText = "Search Location";
            entryBox.Size = new Size(199, 23);
            entryBox.TabIndex = 10;
            entryBox.TextAlign = HorizontalAlignment.Center;
            entryBox.TextChanged += entryBox_TextChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.Anchor = AnchorStyles.Left;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView2.BackgroundColor = SystemColors.Info;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { icao24DataGridViewTextBoxColumn1, firstSeenDataGridViewTextBoxColumn, estDepartureAirportDataGridViewTextBoxColumn, lastSeenDataGridViewTextBoxColumn, callsignDataGridViewTextBoxColumn });
            dataGridView2.DataSource = airportDeparturesBindingSource;
            dataGridView2.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridView2.GridColor = SystemColors.ActiveBorder;
            dataGridView2.Location = new Point(12, 373);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(398, 289);
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
            icao24DataGridViewTextBoxColumn1.Width = 87;
            // 
            // firstSeenDataGridViewTextBoxColumn
            // 
            firstSeenDataGridViewTextBoxColumn.DataPropertyName = "firstSeen";
            firstSeenDataGridViewTextBoxColumn.HeaderText = "First Seen";
            firstSeenDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstSeenDataGridViewTextBoxColumn.Name = "firstSeenDataGridViewTextBoxColumn";
            firstSeenDataGridViewTextBoxColumn.ReadOnly = true;
            firstSeenDataGridViewTextBoxColumn.ToolTipText = "Date/time the flight was first detected";
            firstSeenDataGridViewTextBoxColumn.Width = 97;
            // 
            // estDepartureAirportDataGridViewTextBoxColumn
            // 
            estDepartureAirportDataGridViewTextBoxColumn.DataPropertyName = "estDepartureAirport";
            estDepartureAirportDataGridViewTextBoxColumn.HeaderText = "Departed";
            estDepartureAirportDataGridViewTextBoxColumn.MinimumWidth = 6;
            estDepartureAirportDataGridViewTextBoxColumn.Name = "estDepartureAirportDataGridViewTextBoxColumn";
            estDepartureAirportDataGridViewTextBoxColumn.ReadOnly = true;
            estDepartureAirportDataGridViewTextBoxColumn.ToolTipText = "Airport that this flight departed ";
            estDepartureAirportDataGridViewTextBoxColumn.Width = 95;
            // 
            // lastSeenDataGridViewTextBoxColumn
            // 
            lastSeenDataGridViewTextBoxColumn.DataPropertyName = "lastSeen";
            lastSeenDataGridViewTextBoxColumn.HeaderText = "Last Seen";
            lastSeenDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastSeenDataGridViewTextBoxColumn.Name = "lastSeenDataGridViewTextBoxColumn";
            lastSeenDataGridViewTextBoxColumn.ReadOnly = true;
            lastSeenDataGridViewTextBoxColumn.ToolTipText = "Date/Time Flight was first Detected";
            lastSeenDataGridViewTextBoxColumn.Width = 96;
            // 
            // callsignDataGridViewTextBoxColumn
            // 
            callsignDataGridViewTextBoxColumn.DataPropertyName = "callsign";
            callsignDataGridViewTextBoxColumn.HeaderText = "Callsign";
            callsignDataGridViewTextBoxColumn.MinimumWidth = 6;
            callsignDataGridViewTextBoxColumn.Name = "callsignDataGridViewTextBoxColumn";
            callsignDataGridViewTextBoxColumn.ReadOnly = true;
            callsignDataGridViewTextBoxColumn.ToolTipText = "Aircrafts unique callsign usually associating with Company";
            callsignDataGridViewTextBoxColumn.Width = 85;
            // 
            // airportDeparturesBindingSource
            // 
            airportDeparturesBindingSource.DataSource = typeof(airportDepartures);
            // 
            // ShowDetectBox
            // 
            ShowDetectBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ShowDetectBox.AutoSize = true;
            ShowDetectBox.Location = new Point(10, 878);
            ShowDetectBox.Margin = new Padding(2);
            ShowDetectBox.Name = "ShowDetectBox";
            ShowDetectBox.Size = new Size(150, 23);
            ShowDetectBox.TabIndex = 7;
            ShowDetectBox.Text = "Show Detection Box";
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
            // FlightMainForm
            // 
            AcceptButton = Refresh;
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1717, 913);
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)airportArrivalsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)airportDeparturesBindingSource).EndInit();
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
        private DataGridViewTextBoxColumn icao24DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn callsign;
        private DataGridViewTextBoxColumn origincountryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastcontactDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn ongroundDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn Velocity;
        private DataGridViewTextBoxColumn baro_altitude;
        private DataGridViewTextBoxColumn vertical_rate;
        private DataGridViewTextBoxColumn geo_altitude;
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
        private DataGridViewTextBoxColumn icao24DataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn firstSeenDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn estDepartureAirportDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lastSeenDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn callsignDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn icao24DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn firstSeenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estDepartureAirportDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastSeenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn callsignDataGridViewTextBoxColumn;
    }
}
