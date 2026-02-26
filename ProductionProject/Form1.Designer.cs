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
            submitButton = new Button();
            clockLabel = new Label();
            arrivalLabel = new Label();
            departureLabel = new Label();
            label1 = new Label();
            entryBox = new TextBox();
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
            estArrivalAirportDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            Refresh.Location = new Point(871, 879);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(133, 42);
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
            dataGridView1.Location = new Point(3, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(852, 370);
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
            icao24DataGridViewTextBoxColumn.Width = 136;
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
            origincountryDataGridViewTextBoxColumn.Width = 127;
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
            ongroundDataGridViewCheckBoxColumn.Width = 93;
            // 
            // category
            // 
            category.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            category.DataPropertyName = "category";
            category.HeaderText = "category";
            category.MinimumWidth = 8;
            category.Name = "category";
            category.Width = 117;
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
            gMapControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gMapControl1.AutoSize = true;
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.ForeColor = SystemColors.ActiveCaptionText;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(0, 0);
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
            gMapControl1.Size = new Size(919, 879);
            gMapControl1.TabIndex = 6;
            gMapControl1.Zoom = 0D;
            gMapControl1.Load += gMapControl1_Load;
            // 
            // splitContainer1
            // 
            splitContainer1.AllowDrop = true;
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(2, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(gMapControl1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.ControlDark;
            splitContainer1.Panel2.Controls.Add(submitButton);
            splitContainer1.Panel2.Controls.Add(clockLabel);
            splitContainer1.Panel2.Controls.Add(arrivalLabel);
            splitContainer1.Panel2.Controls.Add(departureLabel);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(entryBox);
            splitContainer1.Panel2.Controls.Add(dataGridView3);
            splitContainer1.Panel2.Controls.Add(dataGridView2);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1784, 861);
            splitContainer1.SplitterDistance = 948;
            splitContainer1.TabIndex = 7;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(451, 3);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(67, 31);
            submitButton.TabIndex = 17;
            submitButton.Text = "GO";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // clockLabel
            // 
            clockLabel.AutoSize = true;
            clockLabel.BackColor = SystemColors.ActiveCaptionText;
            clockLabel.ForeColor = Color.SpringGreen;
            clockLabel.Location = new Point(8, 0);
            clockLabel.Name = "clockLabel";
            clockLabel.Size = new Size(59, 25);
            clockLabel.TabIndex = 16;
            clockLabel.Text = "label4";
            clockLabel.Click += label4_Click;
            // 
            // arrivalLabel
            // 
            arrivalLabel.AutoSize = true;
            arrivalLabel.BackColor = SystemColors.ControlLightLight;
            arrivalLabel.Location = new Point(448, 468);
            arrivalLabel.Name = "arrivalLabel";
            arrivalLabel.Size = new Size(195, 25);
            arrivalLabel.TabIndex = 15;
            arrivalLabel.Text = "Airport Arrivals (24 hrs)";
            // 
            // departureLabel
            // 
            departureLabel.AutoSize = true;
            departureLabel.BackColor = SystemColors.Info;
            departureLabel.Location = new Point(8, 468);
            departureLabel.Name = "departureLabel";
            departureLabel.Size = new Size(160, 25);
            departureLabel.TabIndex = 14;
            departureLabel.Text = "Airport Departures";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Location = new Point(8, 48);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 13;
            label1.Text = "Current Flight Info";
            // 
            // entryBox
            // 
            entryBox.BackColor = Color.Azure;
            entryBox.Cursor = Cursors.IBeam;
            entryBox.ForeColor = SystemColors.MenuHighlight;
            entryBox.Location = new Point(197, 3);
            entryBox.Name = "entryBox";
            entryBox.Size = new Size(248, 31);
            entryBox.TabIndex = 10;
            entryBox.Text = "Search Location";
            entryBox.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.BackgroundColor = SystemColors.Menu;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { icao24DataGridViewTextBoxColumn2, firstSeenDataGridViewTextBoxColumn1, estDepartureAirportDataGridViewTextBoxColumn1, lastSeenDataGridViewTextBoxColumn1, callsignDataGridViewTextBoxColumn1 });
            dataGridView3.DataSource = airportArrivalsBindingSource;
            dataGridView3.Location = new Point(448, 502);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridView3.ShowCellToolTips = false;
            dataGridView3.Size = new Size(381, 356);
            dataGridView3.TabIndex = 9;
            // 
            // icao24DataGridViewTextBoxColumn2
            // 
            icao24DataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            icao24DataGridViewTextBoxColumn2.DataPropertyName = "icao24";
            icao24DataGridViewTextBoxColumn2.HeaderText = "icao24";
            icao24DataGridViewTextBoxColumn2.MinimumWidth = 8;
            icao24DataGridViewTextBoxColumn2.Name = "icao24DataGridViewTextBoxColumn2";
            icao24DataGridViewTextBoxColumn2.Width = 8;
            // 
            // firstSeenDataGridViewTextBoxColumn1
            // 
            firstSeenDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            firstSeenDataGridViewTextBoxColumn1.DataPropertyName = "firstSeen";
            firstSeenDataGridViewTextBoxColumn1.HeaderText = "firstSeen";
            firstSeenDataGridViewTextBoxColumn1.MinimumWidth = 8;
            firstSeenDataGridViewTextBoxColumn1.Name = "firstSeenDataGridViewTextBoxColumn1";
            firstSeenDataGridViewTextBoxColumn1.Width = 116;
            // 
            // estDepartureAirportDataGridViewTextBoxColumn1
            // 
            estDepartureAirportDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            estDepartureAirportDataGridViewTextBoxColumn1.DataPropertyName = "estDepartureAirport";
            estDepartureAirportDataGridViewTextBoxColumn1.HeaderText = "Airport Departed";
            estDepartureAirportDataGridViewTextBoxColumn1.MinimumWidth = 8;
            estDepartureAirportDataGridViewTextBoxColumn1.Name = "estDepartureAirportDataGridViewTextBoxColumn1";
            estDepartureAirportDataGridViewTextBoxColumn1.Width = 183;
            // 
            // lastSeenDataGridViewTextBoxColumn1
            // 
            lastSeenDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            lastSeenDataGridViewTextBoxColumn1.DataPropertyName = "lastSeen";
            lastSeenDataGridViewTextBoxColumn1.HeaderText = "lastSeen";
            lastSeenDataGridViewTextBoxColumn1.MinimumWidth = 8;
            lastSeenDataGridViewTextBoxColumn1.Name = "lastSeenDataGridViewTextBoxColumn1";
            lastSeenDataGridViewTextBoxColumn1.Width = 113;
            // 
            // callsignDataGridViewTextBoxColumn1
            // 
            callsignDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            callsignDataGridViewTextBoxColumn1.DataPropertyName = "callsign";
            callsignDataGridViewTextBoxColumn1.HeaderText = "callsign";
            callsignDataGridViewTextBoxColumn1.MinimumWidth = 8;
            callsignDataGridViewTextBoxColumn1.Name = "callsignDataGridViewTextBoxColumn1";
            callsignDataGridViewTextBoxColumn1.Width = 8;
            // 
            // airportArrivalsBindingSource
            // 
            airportArrivalsBindingSource.DataSource = typeof(airportArrivals);
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.BackgroundColor = SystemColors.Info;
            dataGridView2.ColumnHeadersHeight = 34;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { icao24DataGridViewTextBoxColumn1, firstSeenDataGridViewTextBoxColumn, estDepartureAirportDataGridViewTextBoxColumn, lastSeenDataGridViewTextBoxColumn, estArrivalAirportDataGridViewTextBoxColumn, callsignDataGridViewTextBoxColumn });
            dataGridView2.DataSource = airportDeparturesBindingSource;
            dataGridView2.GridColor = SystemColors.MenuHighlight;
            dataGridView2.Location = new Point(3, 502);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridView2.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridView2.ShowEditingIcon = false;
            dataGridView2.Size = new Size(442, 356);
            dataGridView2.TabIndex = 8;
            // 
            // icao24DataGridViewTextBoxColumn1
            // 
            icao24DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            icao24DataGridViewTextBoxColumn1.DataPropertyName = "icao24";
            icao24DataGridViewTextBoxColumn1.HeaderText = "icao24";
            icao24DataGridViewTextBoxColumn1.MinimumWidth = 8;
            icao24DataGridViewTextBoxColumn1.Name = "icao24DataGridViewTextBoxColumn1";
            // 
            // firstSeenDataGridViewTextBoxColumn
            // 
            firstSeenDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            firstSeenDataGridViewTextBoxColumn.DataPropertyName = "firstSeen";
            firstSeenDataGridViewTextBoxColumn.HeaderText = "Est Take Off Time";
            firstSeenDataGridViewTextBoxColumn.MinimumWidth = 8;
            firstSeenDataGridViewTextBoxColumn.Name = "firstSeenDataGridViewTextBoxColumn";
            firstSeenDataGridViewTextBoxColumn.Width = 184;
            // 
            // estDepartureAirportDataGridViewTextBoxColumn
            // 
            estDepartureAirportDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            estDepartureAirportDataGridViewTextBoxColumn.DataPropertyName = "estDepartureAirport";
            estDepartureAirportDataGridViewTextBoxColumn.HeaderText = "estDepartureAirport";
            estDepartureAirportDataGridViewTextBoxColumn.MinimumWidth = 8;
            estDepartureAirportDataGridViewTextBoxColumn.Name = "estDepartureAirportDataGridViewTextBoxColumn";
            estDepartureAirportDataGridViewTextBoxColumn.Width = 206;
            // 
            // lastSeenDataGridViewTextBoxColumn
            // 
            lastSeenDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            lastSeenDataGridViewTextBoxColumn.DataPropertyName = "lastSeen";
            lastSeenDataGridViewTextBoxColumn.HeaderText = "lastSeen";
            lastSeenDataGridViewTextBoxColumn.MinimumWidth = 8;
            lastSeenDataGridViewTextBoxColumn.Name = "lastSeenDataGridViewTextBoxColumn";
            lastSeenDataGridViewTextBoxColumn.Width = 113;
            // 
            // estArrivalAirportDataGridViewTextBoxColumn
            // 
            estArrivalAirportDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            estArrivalAirportDataGridViewTextBoxColumn.DataPropertyName = "estArrivalAirport";
            estArrivalAirportDataGridViewTextBoxColumn.HeaderText = "estArrivalAirport";
            estArrivalAirportDataGridViewTextBoxColumn.MinimumWidth = 8;
            estArrivalAirportDataGridViewTextBoxColumn.Name = "estArrivalAirportDataGridViewTextBoxColumn";
            estArrivalAirportDataGridViewTextBoxColumn.Width = 177;
            // 
            // callsignDataGridViewTextBoxColumn
            // 
            callsignDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            callsignDataGridViewTextBoxColumn.DataPropertyName = "callsign";
            callsignDataGridViewTextBoxColumn.HeaderText = "callsign";
            callsignDataGridViewTextBoxColumn.MinimumWidth = 8;
            callsignDataGridViewTextBoxColumn.Name = "callsignDataGridViewTextBoxColumn";
            callsignDataGridViewTextBoxColumn.Width = 106;
            // 
            // airportDeparturesBindingSource
            // 
            airportDeparturesBindingSource.DataSource = typeof(airportDepartures);
            // 
            // ShowDetectBox
            // 
            ShowDetectBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ShowDetectBox.AutoSize = true;
            ShowDetectBox.Location = new Point(12, 887);
            ShowDetectBox.Name = "ShowDetectBox";
            ShowDetectBox.Size = new Size(197, 29);
            ShowDetectBox.TabIndex = 7;
            ShowDetectBox.Text = "Show Detection Box";
            ShowDetectBox.UseVisualStyleBackColor = true;
            ShowDetectBox.CheckedChanged += ShowDetectBox_CheckedChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(224, 883);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1791, 933);
            Controls.Add(splitContainer1);
            Controls.Add(button1);
            Controls.Add(Refresh);
            Controls.Add(ShowDetectBox);
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
        private DataGridView dataGridView2;
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
        private DataGridViewTextBoxColumn icao24DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn firstSeenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estDepartureAirportDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastSeenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estArrivalAirportDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn callsignDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn icao24DataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn firstSeenDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn estDepartureAirportDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lastSeenDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn callsignDataGridViewTextBoxColumn1;
        private PrintDialog printDialog1;
        private Label arrivalLabel;
        private Label departureLabel;
        private Label label1;
        private Label clockLabel;
        private Button submitButton;
    }
}
