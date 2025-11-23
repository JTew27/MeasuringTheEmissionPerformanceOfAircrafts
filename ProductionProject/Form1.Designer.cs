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
            pictureBox1 = new PictureBox();
            splitContainer2 = new SplitContainer();
            aPIBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            flightsInfoBindingSource = new BindingSource(components);
            icao24DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            callsign = new DataGridViewTextBoxColumn();
            origincountryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timepositionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastcontactDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            longitudeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            latitudeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ongroundDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)aPIBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flightsInfoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Refresh
            // 
            Refresh.BackColor = Color.FromArgb(128, 255, 128);
            Refresh.BackgroundImageLayout = ImageLayout.None;
            Refresh.Location = new Point(556, 519);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(133, 42);
            Refresh.TabIndex = 1;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = false;
            Refresh.Click += Refresh_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(200, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(844, 487);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // splitContainer2
            // 
            splitContainer2.Location = new Point(972, 12);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Size = new Size(225, 597);
            splitContainer2.SplitterDistance = 75;
            splitContainer2.TabIndex = 4;
            // 
            // aPIBindingSource
            // 
            aPIBindingSource.DataSource = typeof(API);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { icao24DataGridViewTextBoxColumn, callsign, origincountryDataGridViewTextBoxColumn, timepositionDataGridViewTextBoxColumn, lastcontactDataGridViewTextBoxColumn, longitudeDataGridViewTextBoxColumn, latitudeDataGridViewTextBoxColumn, ongroundDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = flightsInfoBindingSource;
            dataGridView1.Location = new Point(6, 567);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1256, 219);
            dataGridView1.TabIndex = 5;
            // 
            // flightsInfoBindingSource
            // 
            flightsInfoBindingSource.DataSource = typeof(flightsInfo);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1274, 798);
            Controls.Add(dataGridView1);
            Controls.Add(splitContainer2);
            Controls.Add(pictureBox1);
            Controls.Add(Refresh);
            Name = "Form1";
            Text = "Flight Tracker";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)aPIBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)flightsInfoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button Refresh;
        private PictureBox pictureBox1;
        private SplitContainer splitContainer2;
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
    }
}
