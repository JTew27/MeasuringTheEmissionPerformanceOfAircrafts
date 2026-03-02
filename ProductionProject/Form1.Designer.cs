namespace ProductionProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            button1 = new Button();
            printDialog1 = new PrintDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flightsInfoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aPIBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)airportArrivalsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)airportDeparturesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Refresh
            // 
            Refresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Refresh.BackColor = Color.FromArgb(128, 255, 128);
            Refresh.BackgroundImageLayout = ImageLayout.None;
            Refresh.Location = new Point(697, 668);
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
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { icao24DataGridViewTextBoxColumn, callsign, origincountryDataGridViewTextBoxColumn, lastcontactDataGridViewTextBoxColumn, ongroundDataGridViewCheckBoxColumn, category, Velocity, baro_altitude, vertical_rate, geo_altitude });
            dataGridView1.DataSource = flightsInfoBindingSource;
            dataGridView1.Location = new Point(3, 59);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(828, 281);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // icao24DataGridViewTextBoxColumn
            // 
            icao24DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            icao24DataGridViewTextBoxColumn.DataPropertyName = "icao24";
            icao24DataGridViewTextBoxColumn.DividerWidth = 1;
            icao24DataGridViewTextBoxColumn.HeaderText = "icao24 Code";
            icao24DataGridViewTextBoxColumn.MinimumWidth = 8;
            icao24DataGridViewTextBoxColumn.Name = "icao24DataGridViewTextBoxColumn";
            icao24DataGridViewTextBoxColumn.ReadOnly = true;
            icao24DataGridViewTextBoxColumn.Width = 106;
            // 
            // callsign
            // 
            callsign.DataPropertyName = "callsign";
            callsign.HeaderText = "callsign";
            callsign.MinimumWidth = 8;
            callsign.Name = "callsign";
            callsign.ReadOnly = true;
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
            // 
            // lastcontactDataGridViewTextBoxColumn
            // 
            lastcontactDataGridViewTextBoxColumn.DataPropertyName = "last_contact";
            lastcontactDataGridViewTextBoxColumn.FillWeight = 90F;
            lastcontactDataGridViewTextBoxColumn.HeaderText = "Last Contact";
            lastcontactDataGridViewTextBoxColumn.MinimumWidth = 8;
            lastcontactDataGridViewTextBoxColumn.Name = "lastcontactDataGridViewTextBoxColumn";
            lastcontactDataGridViewTextBoxColumn.ReadOnly = true;
            lastcontactDataGridViewTextBoxColumn.Width = 150;
            // 
            // ongroundDataGridViewCheckBoxColumn
            // 
            ongroundDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ongroundDataGridViewCheckBoxColumn.DataPropertyName = "on_ground";
            ongroundDataGridViewCheckBoxColumn.HeaderText = "on ground";
            ongroundDataGridViewCheckBoxColumn.MinimumWidth = 8;
            ongroundDataGridViewCheckBoxColumn.Name = "ongroundDataGridViewCheckBoxColumn";
            ongroundDataGridViewCheckBoxColumn.ReadOnly = true;
            ongroundDataGridViewCheckBoxColumn.Width = 72;
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
            Velocity.HeaderText = "velocity";
            Velocity.MinimumWidth = 8;
            Velocity.Name = "Velocity";
            Velocity.ReadOnly = true;
            Velocity.Width = 150;
            // 
            // baro_altitude
            // 
            baro_altitude.DataPropertyName = "baro_altitude";
            baro_altitude.HeaderText = "baro_altitude";
            baro_altitude.MinimumWidth = 8;
            baro_altitude.Name = "baro_altitude";
            baro_altitude.ReadOnly = true;
            baro_altitude.Width = 150;
            // 
            // vertical_rate
            // 
            vertical_rate.DataPropertyName = "vertical_rate";
            vertical_rate.HeaderText = "vertical_rate";
            vertical_rate.MinimumWidth = 8;
            vertical_rate.Name = "vertical_rate";
            vertical_rate.ReadOnly = true;
            vertical_rate.Width = 150;
            // 
            // geo_altitude
            // 
            geo_altitude.DataPropertyName = "geo_altitude";
            geo_altitude.HeaderText = "geo_altitude";
            geo_altitude.MinimumWidth = 8;
            geo_altitude.Name = "geo_altitude";
            geo_altitude.ReadOnly = true;
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
            gMapControl1.Size = new Size(0, 655);
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
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.ControlDark;
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
            splitContainer1.Size = new Size(1711, 655);
            splitContainer1.SplitterDistance = 908;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 7;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.Anchor = AnchorStyles.None;
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.BackgroundColor = SystemColors.Menu;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { icao24DataGridViewTextBoxColumn2, firstSeenDataGridViewTextBoxColumn1, estDepartureAirportDataGridViewTextBoxColumn1, lastSeenDataGridViewTextBoxColumn1, callsignDataGridViewTextBoxColumn1 });
            dataGridView3.DataSource = airportArrivalsBindingSource;
            dataGridView3.Location = new Point(420, 364);
            dataGridView3.Margin = new Padding(2);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridView3.ShowCellToolTips = false;
            dataGridView3.ShowEditingIcon = false;
            dataGridView3.Size = new Size(388, 288);
            dataGridView3.TabIndex = 9;
            // 
            // icao24DataGridViewTextBoxColumn2
            // 
            icao24DataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            icao24DataGridViewTextBoxColumn2.DataPropertyName = "icao24";
            icao24DataGridViewTextBoxColumn2.HeaderText = "icao24";
            icao24DataGridViewTextBoxColumn2.MinimumWidth = 8;
            icao24DataGridViewTextBoxColumn2.Name = "icao24DataGridViewTextBoxColumn2";
            icao24DataGridViewTextBoxColumn2.ReadOnly = true;
            icao24DataGridViewTextBoxColumn2.Width = 8;
            // 
            // firstSeenDataGridViewTextBoxColumn1
            // 
            firstSeenDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            firstSeenDataGridViewTextBoxColumn1.DataPropertyName = "firstSeen";
            firstSeenDataGridViewTextBoxColumn1.HeaderText = "firstSeen";
            firstSeenDataGridViewTextBoxColumn1.MinimumWidth = 8;
            firstSeenDataGridViewTextBoxColumn1.Name = "firstSeenDataGridViewTextBoxColumn1";
            firstSeenDataGridViewTextBoxColumn1.ReadOnly = true;
            firstSeenDataGridViewTextBoxColumn1.Width = 90;
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
            lastSeenDataGridViewTextBoxColumn1.HeaderText = "lastSeen";
            lastSeenDataGridViewTextBoxColumn1.MinimumWidth = 8;
            lastSeenDataGridViewTextBoxColumn1.Name = "lastSeenDataGridViewTextBoxColumn1";
            lastSeenDataGridViewTextBoxColumn1.ReadOnly = true;
            lastSeenDataGridViewTextBoxColumn1.Width = 88;
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
            arrivalLabel.BackColor = SystemColors.ControlLightLight;
            arrivalLabel.Location = new Point(420, 342);
            arrivalLabel.Margin = new Padding(2, 0, 2, 0);
            arrivalLabel.Name = "arrivalLabel";
            arrivalLabel.Size = new Size(152, 19);
            arrivalLabel.TabIndex = 15;
            arrivalLabel.Text = "Airport Arrivals (24 hrs)";
            // 
            // submitButton
            // 
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
            departureLabel.Location = new Point(6, 342);
            departureLabel.Margin = new Padding(2, 0, 2, 0);
            departureLabel.Name = "departureLabel";
            departureLabel.Size = new Size(124, 19);
            departureLabel.TabIndex = 14;
            departureLabel.Text = "Airport Departures";
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
            flightInfoLabel.Location = new Point(6, 36);
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
            entryBox.ForeColor = SystemColors.MenuHighlight;
            entryBox.Location = new Point(158, 2);
            entryBox.Margin = new Padding(2);
            entryBox.Name = "entryBox";
            entryBox.PlaceholderText = "Search Location";
            entryBox.Size = new Size(199, 26);
            entryBox.TabIndex = 10;
            entryBox.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.Anchor = AnchorStyles.None;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.BackgroundColor = SystemColors.Info;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { icao24DataGridViewTextBoxColumn1, firstSeenDataGridViewTextBoxColumn, estDepartureAirportDataGridViewTextBoxColumn, lastSeenDataGridViewTextBoxColumn, callsignDataGridViewTextBoxColumn });
            dataGridView2.DataSource = airportDeparturesBindingSource;
            dataGridView2.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridView2.Location = new Point(6, 364);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(396, 289);
            dataGridView2.TabIndex = 18;
            // 
            // icao24DataGridViewTextBoxColumn1
            // 
            icao24DataGridViewTextBoxColumn1.DataPropertyName = "icao24";
            icao24DataGridViewTextBoxColumn1.HeaderText = "icao24";
            icao24DataGridViewTextBoxColumn1.MinimumWidth = 6;
            icao24DataGridViewTextBoxColumn1.Name = "icao24DataGridViewTextBoxColumn1";
            icao24DataGridViewTextBoxColumn1.ReadOnly = true;
            icao24DataGridViewTextBoxColumn1.Width = 125;
            // 
            // firstSeenDataGridViewTextBoxColumn
            // 
            firstSeenDataGridViewTextBoxColumn.DataPropertyName = "firstSeen";
            firstSeenDataGridViewTextBoxColumn.HeaderText = "firstSeen";
            firstSeenDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstSeenDataGridViewTextBoxColumn.Name = "firstSeenDataGridViewTextBoxColumn";
            firstSeenDataGridViewTextBoxColumn.ReadOnly = true;
            firstSeenDataGridViewTextBoxColumn.Width = 125;
            // 
            // estDepartureAirportDataGridViewTextBoxColumn
            // 
            estDepartureAirportDataGridViewTextBoxColumn.DataPropertyName = "estDepartureAirport";
            estDepartureAirportDataGridViewTextBoxColumn.HeaderText = "estDepartureAirport";
            estDepartureAirportDataGridViewTextBoxColumn.MinimumWidth = 6;
            estDepartureAirportDataGridViewTextBoxColumn.Name = "estDepartureAirportDataGridViewTextBoxColumn";
            estDepartureAirportDataGridViewTextBoxColumn.ReadOnly = true;
            estDepartureAirportDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastSeenDataGridViewTextBoxColumn
            // 
            lastSeenDataGridViewTextBoxColumn.DataPropertyName = "lastSeen";
            lastSeenDataGridViewTextBoxColumn.HeaderText = "lastSeen";
            lastSeenDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastSeenDataGridViewTextBoxColumn.Name = "lastSeenDataGridViewTextBoxColumn";
            lastSeenDataGridViewTextBoxColumn.ReadOnly = true;
            lastSeenDataGridViewTextBoxColumn.Width = 125;
            // 
            // callsignDataGridViewTextBoxColumn
            // 
            callsignDataGridViewTextBoxColumn.DataPropertyName = "callsign";
            callsignDataGridViewTextBoxColumn.HeaderText = "callsign";
            callsignDataGridViewTextBoxColumn.MinimumWidth = 6;
            callsignDataGridViewTextBoxColumn.Name = "callsignDataGridViewTextBoxColumn";
            callsignDataGridViewTextBoxColumn.ReadOnly = true;
            callsignDataGridViewTextBoxColumn.Width = 125;
            // 
            // airportDeparturesBindingSource
            // 
            airportDeparturesBindingSource.DataSource = typeof(airportDepartures);
            // 
            // ShowDetectBox
            // 
            ShowDetectBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ShowDetectBox.AutoSize = true;
            ShowDetectBox.Location = new Point(10, 674);
            ShowDetectBox.Margin = new Padding(2);
            ShowDetectBox.Name = "ShowDetectBox";
            ShowDetectBox.Size = new Size(150, 23);
            ShowDetectBox.TabIndex = 7;
            ShowDetectBox.Text = "Show Detection Box";
            ShowDetectBox.UseVisualStyleBackColor = true;
            ShowDetectBox.CheckedChanged += ShowDetectBox_CheckedChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(179, 671);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(90, 26);
            button1.TabIndex = 6;
            button1.Text = "Flight Path ";
            button1.UseVisualStyleBackColor = true;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            AcceptButton = Refresh;
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1717, 709);
            Controls.Add(button1);
            Controls.Add(Refresh);
            Controls.Add(ShowDetectBox);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
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
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)airportArrivalsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)airportDeparturesBindingSource).EndInit();
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
        private Button button1;
        private CheckBox ShowDetectBox;
        private BindingSource airportDeparturesBindingSource;
        private DataGridView dataGridView3;
        private BindingSource airportArrivalsBindingSource;
        private TextBox entryBox;
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
        private DataGridViewTextBoxColumn icao24DataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn firstSeenDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn estDepartureAirportDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lastSeenDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn callsignDataGridViewTextBoxColumn1;
        private PrintDialog printDialog1;
        private Label arrivalLabel;
        private Label departureLabel;
        private Label flightInfoLabel;
        private Label clockLabel;
        private Button submitButton;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn icao24DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn firstSeenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estDepartureAirportDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastSeenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn callsignDataGridViewTextBoxColumn;
    }
}
