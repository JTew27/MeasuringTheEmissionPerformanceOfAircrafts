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
            timepositionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastcontactDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            longitudeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            latitudeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ongroundDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            flightsInfoBindingSource = new BindingSource(components);
            aPIBindingSource = new BindingSource(components);
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flightsInfoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aPIBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { icao24DataGridViewTextBoxColumn, callsign, origincountryDataGridViewTextBoxColumn, timepositionDataGridViewTextBoxColumn, lastcontactDataGridViewTextBoxColumn, longitudeDataGridViewTextBoxColumn, latitudeDataGridViewTextBoxColumn, ongroundDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = flightsInfoBindingSource;
            dataGridView1.Location = new Point(-1, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(814, 171);
            dataGridView1.TabIndex = 5;
            // 
            // icao24DataGridViewTextBoxColumn
            // 
            icao24DataGridViewTextBoxColumn.DataPropertyName = "icao24";
            icao24DataGridViewTextBoxColumn.HeaderText = "icao24 Code";
            icao24DataGridViewTextBoxColumn.MinimumWidth = 8;
            icao24DataGridViewTextBoxColumn.Name = "icao24DataGridViewTextBoxColumn";
            icao24DataGridViewTextBoxColumn.ReadOnly = true;
            icao24DataGridViewTextBoxColumn.Width = 150;
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
            origincountryDataGridViewTextBoxColumn.DataPropertyName = "origin_country";
            origincountryDataGridViewTextBoxColumn.HeaderText = "Country of Origin";
            origincountryDataGridViewTextBoxColumn.MinimumWidth = 8;
            origincountryDataGridViewTextBoxColumn.Name = "origincountryDataGridViewTextBoxColumn";
            origincountryDataGridViewTextBoxColumn.ReadOnly = true;
            origincountryDataGridViewTextBoxColumn.Width = 150;
            // 
            // timepositionDataGridViewTextBoxColumn
            // 
            timepositionDataGridViewTextBoxColumn.DataPropertyName = "time_position";
            timepositionDataGridViewTextBoxColumn.HeaderText = "time_position";
            timepositionDataGridViewTextBoxColumn.MinimumWidth = 8;
            timepositionDataGridViewTextBoxColumn.Name = "timepositionDataGridViewTextBoxColumn";
            timepositionDataGridViewTextBoxColumn.ReadOnly = true;
            timepositionDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastcontactDataGridViewTextBoxColumn
            // 
            lastcontactDataGridViewTextBoxColumn.DataPropertyName = "last_contact";
            lastcontactDataGridViewTextBoxColumn.HeaderText = "last_contact";
            lastcontactDataGridViewTextBoxColumn.MinimumWidth = 8;
            lastcontactDataGridViewTextBoxColumn.Name = "lastcontactDataGridViewTextBoxColumn";
            lastcontactDataGridViewTextBoxColumn.ReadOnly = true;
            lastcontactDataGridViewTextBoxColumn.Width = 150;
            // 
            // longitudeDataGridViewTextBoxColumn
            // 
            longitudeDataGridViewTextBoxColumn.DataPropertyName = "longitude";
            longitudeDataGridViewTextBoxColumn.HeaderText = "longitude";
            longitudeDataGridViewTextBoxColumn.MinimumWidth = 8;
            longitudeDataGridViewTextBoxColumn.Name = "longitudeDataGridViewTextBoxColumn";
            longitudeDataGridViewTextBoxColumn.ReadOnly = true;
            longitudeDataGridViewTextBoxColumn.Width = 150;
            // 
            // latitudeDataGridViewTextBoxColumn
            // 
            latitudeDataGridViewTextBoxColumn.DataPropertyName = "latitude";
            latitudeDataGridViewTextBoxColumn.HeaderText = "latitude";
            latitudeDataGridViewTextBoxColumn.MinimumWidth = 8;
            latitudeDataGridViewTextBoxColumn.Name = "latitudeDataGridViewTextBoxColumn";
            latitudeDataGridViewTextBoxColumn.ReadOnly = true;
            latitudeDataGridViewTextBoxColumn.Width = 150;
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
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(3, 3);
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
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1764, 726);
            splitContainer1.SplitterDistance = 925;
            splitContainer1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1791, 798);
            Controls.Add(splitContainer1);
            Controls.Add(Refresh);
            Name = "Form1";
            Text = "Flight Tracker";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)flightsInfoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)aPIBindingSource).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button Refresh;
        private BindingSource aPIBindingSource;
        private DataGridView dataGridView1;
        private BindingSource flightsInfoBindingSource;
        private DataGridViewTextBoxColumn callsignDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn icao24DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn callsign;
        private DataGridViewTextBoxColumn origincountryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timepositionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastcontactDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn longitudeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn latitudeDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn ongroundDataGridViewCheckBoxColumn;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private SplitContainer splitContainer1;
    }
}
