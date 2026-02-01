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
            flightsInfoBindingSource = new BindingSource(components);
            aPIBindingSource = new BindingSource(components);
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            splitContainer1 = new SplitContainer();
            dataGridView3 = new DataGridView();
            airportArrivalsBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            airportDeparturesBindingSource = new BindingSource(components);
            ShowDetectBox = new CheckBox();
            button1 = new Button();
            icao24DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            callsign = new DataGridViewTextBoxColumn();
            origincountryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastcontactDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ongroundDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            category = new DataGridViewTextBoxColumn();
            icao24DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            firstSeenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estDepartureAirportDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastSeenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estArrivalAirportDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            callsignDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            icao24DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            firstSeenDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            estDepartureAirportDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            lastSeenDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            estArrivalAirportDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            callsignDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            arrivalAirportCandidatesCountDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
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
            Refresh.BackColor = Color.FromArgb(128, 255, 128);
            Refresh.BackgroundImageLayout = ImageLayout.None;
            Refresh.Location = new Point(871, 744);
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
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { icao24DataGridViewTextBoxColumn, callsign, origincountryDataGridViewTextBoxColumn, lastcontactDataGridViewTextBoxColumn, ongroundDataGridViewCheckBoxColumn, category });
            dataGridView1.DataSource = flightsInfoBindingSource;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(855, 279);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            gMapControl1.Size = new Size(919, 720);
            gMapControl1.TabIndex = 6;
            gMapControl1.Zoom = 0D;
            gMapControl1.Load += gMapControl1_Load;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(2, -2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(gMapControl1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView3);
            splitContainer1.Panel2.Controls.Add(dataGridView2);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1764, 726);
            splitContainer1.SplitterDistance = 925;
            splitContainer1.TabIndex = 7;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.BackgroundColor = SystemColors.Menu;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { icao24DataGridViewTextBoxColumn2, firstSeenDataGridViewTextBoxColumn1, estDepartureAirportDataGridViewTextBoxColumn1, lastSeenDataGridViewTextBoxColumn1, estArrivalAirportDataGridViewTextBoxColumn1, callsignDataGridViewTextBoxColumn1, arrivalAirportCandidatesCountDataGridViewTextBoxColumn1 });
            dataGridView3.DataSource = airportArrivalsBindingSource;
            dataGridView3.Location = new Point(429, 299);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.ShowCellToolTips = false;
            dataGridView3.Size = new Size(403, 263);
            dataGridView3.TabIndex = 9;
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
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.BackgroundColor = SystemColors.Info;
            dataGridView2.ColumnHeadersHeight = 34;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { icao24DataGridViewTextBoxColumn1, firstSeenDataGridViewTextBoxColumn, estDepartureAirportDataGridViewTextBoxColumn, lastSeenDataGridViewTextBoxColumn, estArrivalAirportDataGridViewTextBoxColumn, callsignDataGridViewTextBoxColumn });
            dataGridView2.DataSource = airportDeparturesBindingSource;
            dataGridView2.GridColor = SystemColors.MenuHighlight;
            dataGridView2.Location = new Point(3, 299);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(420, 263);
            dataGridView2.TabIndex = 8;
            // 
            // airportDeparturesBindingSource
            // 
            airportDeparturesBindingSource.DataSource = typeof(airportDepartures);
            // 
            // ShowDetectBox
            // 
            ShowDetectBox.AutoSize = true;
            ShowDetectBox.Location = new Point(12, 730);
            ShowDetectBox.Name = "ShowDetectBox";
            ShowDetectBox.Size = new Size(197, 29);
            ShowDetectBox.TabIndex = 7;
            ShowDetectBox.Text = "Show Detection Box";
            ShowDetectBox.UseVisualStyleBackColor = true;
            ShowDetectBox.CheckedChanged += ShowDetectBox_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(224, 726);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Flight Path ";
            button1.UseVisualStyleBackColor = true;
            // 
            // icao24DataGridViewTextBoxColumn
            // 
            icao24DataGridViewTextBoxColumn.DataPropertyName = "icao24";
            icao24DataGridViewTextBoxColumn.DividerWidth = 1;
            icao24DataGridViewTextBoxColumn.HeaderText = "icao24 Code";
            icao24DataGridViewTextBoxColumn.MinimumWidth = 8;
            icao24DataGridViewTextBoxColumn.Name = "icao24DataGridViewTextBoxColumn";
            icao24DataGridViewTextBoxColumn.ReadOnly = true;
            icao24DataGridViewTextBoxColumn.Width = 130;
            // 
            // callsign
            // 
            callsign.DataPropertyName = "callsign";
            callsign.HeaderText = "callsign";
            callsign.MinimumWidth = 8;
            callsign.Name = "callsign";
            callsign.ReadOnly = true;
            // 
            // origincountryDataGridViewTextBoxColumn
            // 
            origincountryDataGridViewTextBoxColumn.DataPropertyName = "origin_country";
            origincountryDataGridViewTextBoxColumn.HeaderText = "Country of Origin";
            origincountryDataGridViewTextBoxColumn.MinimumWidth = 8;
            origincountryDataGridViewTextBoxColumn.Name = "origincountryDataGridViewTextBoxColumn";
            origincountryDataGridViewTextBoxColumn.ReadOnly = true;
            origincountryDataGridViewTextBoxColumn.Width = 150;
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
            ongroundDataGridViewCheckBoxColumn.DataPropertyName = "on_ground";
            ongroundDataGridViewCheckBoxColumn.HeaderText = "on ground";
            ongroundDataGridViewCheckBoxColumn.MinimumWidth = 8;
            ongroundDataGridViewCheckBoxColumn.Name = "ongroundDataGridViewCheckBoxColumn";
            ongroundDataGridViewCheckBoxColumn.ReadOnly = true;
            ongroundDataGridViewCheckBoxColumn.Width = 150;
            // 
            // category
            // 
            category.DataPropertyName = "category";
            category.HeaderText = "category";
            category.MinimumWidth = 8;
            category.Name = "category";
            category.Width = 150;
            // 
            // icao24DataGridViewTextBoxColumn1
            // 
            icao24DataGridViewTextBoxColumn1.DataPropertyName = "icao24";
            icao24DataGridViewTextBoxColumn1.HeaderText = "icao24";
            icao24DataGridViewTextBoxColumn1.MinimumWidth = 8;
            icao24DataGridViewTextBoxColumn1.Name = "icao24DataGridViewTextBoxColumn1";
            icao24DataGridViewTextBoxColumn1.Width = 80;
            // 
            // firstSeenDataGridViewTextBoxColumn
            // 
            firstSeenDataGridViewTextBoxColumn.DataPropertyName = "firstSeen";
            firstSeenDataGridViewTextBoxColumn.HeaderText = "Est Take Off Time";
            firstSeenDataGridViewTextBoxColumn.MinimumWidth = 8;
            firstSeenDataGridViewTextBoxColumn.Name = "firstSeenDataGridViewTextBoxColumn";
            firstSeenDataGridViewTextBoxColumn.Width = 150;
            // 
            // estDepartureAirportDataGridViewTextBoxColumn
            // 
            estDepartureAirportDataGridViewTextBoxColumn.DataPropertyName = "estDepartureAirport";
            estDepartureAirportDataGridViewTextBoxColumn.HeaderText = "estDepartureAirport";
            estDepartureAirportDataGridViewTextBoxColumn.MinimumWidth = 8;
            estDepartureAirportDataGridViewTextBoxColumn.Name = "estDepartureAirportDataGridViewTextBoxColumn";
            estDepartureAirportDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastSeenDataGridViewTextBoxColumn
            // 
            lastSeenDataGridViewTextBoxColumn.DataPropertyName = "lastSeen";
            lastSeenDataGridViewTextBoxColumn.HeaderText = "lastSeen";
            lastSeenDataGridViewTextBoxColumn.MinimumWidth = 8;
            lastSeenDataGridViewTextBoxColumn.Name = "lastSeenDataGridViewTextBoxColumn";
            lastSeenDataGridViewTextBoxColumn.Width = 150;
            // 
            // estArrivalAirportDataGridViewTextBoxColumn
            // 
            estArrivalAirportDataGridViewTextBoxColumn.DataPropertyName = "estArrivalAirport";
            estArrivalAirportDataGridViewTextBoxColumn.HeaderText = "estArrivalAirport";
            estArrivalAirportDataGridViewTextBoxColumn.MinimumWidth = 8;
            estArrivalAirportDataGridViewTextBoxColumn.Name = "estArrivalAirportDataGridViewTextBoxColumn";
            estArrivalAirportDataGridViewTextBoxColumn.Width = 150;
            // 
            // callsignDataGridViewTextBoxColumn
            // 
            callsignDataGridViewTextBoxColumn.DataPropertyName = "callsign";
            callsignDataGridViewTextBoxColumn.HeaderText = "callsign";
            callsignDataGridViewTextBoxColumn.MinimumWidth = 8;
            callsignDataGridViewTextBoxColumn.Name = "callsignDataGridViewTextBoxColumn";
            callsignDataGridViewTextBoxColumn.Width = 150;
            // 
            // icao24DataGridViewTextBoxColumn2
            // 
            icao24DataGridViewTextBoxColumn2.DataPropertyName = "icao24";
            icao24DataGridViewTextBoxColumn2.HeaderText = "icao24";
            icao24DataGridViewTextBoxColumn2.MinimumWidth = 8;
            icao24DataGridViewTextBoxColumn2.Name = "icao24DataGridViewTextBoxColumn2";
            icao24DataGridViewTextBoxColumn2.Width = 80;
            // 
            // firstSeenDataGridViewTextBoxColumn1
            // 
            firstSeenDataGridViewTextBoxColumn1.DataPropertyName = "firstSeen";
            firstSeenDataGridViewTextBoxColumn1.HeaderText = "firstSeen";
            firstSeenDataGridViewTextBoxColumn1.MinimumWidth = 8;
            firstSeenDataGridViewTextBoxColumn1.Name = "firstSeenDataGridViewTextBoxColumn1";
            firstSeenDataGridViewTextBoxColumn1.Width = 150;
            // 
            // estDepartureAirportDataGridViewTextBoxColumn1
            // 
            estDepartureAirportDataGridViewTextBoxColumn1.DataPropertyName = "estDepartureAirport";
            estDepartureAirportDataGridViewTextBoxColumn1.HeaderText = "estDepartureAirport";
            estDepartureAirportDataGridViewTextBoxColumn1.MinimumWidth = 8;
            estDepartureAirportDataGridViewTextBoxColumn1.Name = "estDepartureAirportDataGridViewTextBoxColumn1";
            estDepartureAirportDataGridViewTextBoxColumn1.Width = 150;
            // 
            // lastSeenDataGridViewTextBoxColumn1
            // 
            lastSeenDataGridViewTextBoxColumn1.DataPropertyName = "lastSeen";
            lastSeenDataGridViewTextBoxColumn1.HeaderText = "lastSeen";
            lastSeenDataGridViewTextBoxColumn1.MinimumWidth = 8;
            lastSeenDataGridViewTextBoxColumn1.Name = "lastSeenDataGridViewTextBoxColumn1";
            lastSeenDataGridViewTextBoxColumn1.Width = 150;
            // 
            // estArrivalAirportDataGridViewTextBoxColumn1
            // 
            estArrivalAirportDataGridViewTextBoxColumn1.DataPropertyName = "estArrivalAirport";
            estArrivalAirportDataGridViewTextBoxColumn1.HeaderText = "estArrivalAirport";
            estArrivalAirportDataGridViewTextBoxColumn1.MinimumWidth = 8;
            estArrivalAirportDataGridViewTextBoxColumn1.Name = "estArrivalAirportDataGridViewTextBoxColumn1";
            estArrivalAirportDataGridViewTextBoxColumn1.Width = 150;
            // 
            // callsignDataGridViewTextBoxColumn1
            // 
            callsignDataGridViewTextBoxColumn1.DataPropertyName = "callsign";
            callsignDataGridViewTextBoxColumn1.HeaderText = "callsign";
            callsignDataGridViewTextBoxColumn1.MinimumWidth = 8;
            callsignDataGridViewTextBoxColumn1.Name = "callsignDataGridViewTextBoxColumn1";
            callsignDataGridViewTextBoxColumn1.Width = 150;
            // 
            // arrivalAirportCandidatesCountDataGridViewTextBoxColumn1
            // 
            arrivalAirportCandidatesCountDataGridViewTextBoxColumn1.DataPropertyName = "arrivalAirportCandidatesCount";
            arrivalAirportCandidatesCountDataGridViewTextBoxColumn1.HeaderText = "arrivalAirportCandidatesCount";
            arrivalAirportCandidatesCountDataGridViewTextBoxColumn1.MinimumWidth = 8;
            arrivalAirportCandidatesCountDataGridViewTextBoxColumn1.Name = "arrivalAirportCandidatesCountDataGridViewTextBoxColumn1";
            arrivalAirportCandidatesCountDataGridViewTextBoxColumn1.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1791, 798);
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
        private DataGridViewTextBoxColumn icao24DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn callsign;
        private DataGridViewTextBoxColumn origincountryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastcontactDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn ongroundDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn icao24DataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn firstSeenDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn estDepartureAirportDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lastSeenDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn estArrivalAirportDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn callsignDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn arrivalAirportCandidatesCountDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn icao24DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn firstSeenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estDepartureAirportDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastSeenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estArrivalAirportDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn callsignDataGridViewTextBoxColumn;
    }
}
