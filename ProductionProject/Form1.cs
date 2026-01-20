using Newtonsoft.Json;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace ProductionProject
{
    public partial class Form1 : Form
    {
        private API api;
        private flightsInfo flights;
        private List<flightsInfo> flightList;
        public string json;
        Bitmap map;

        private GMapControl gmap;
        private GMapOverlay aircraftOverlay;
        //GMap.NET.WindowsForms.GMapControl gmap;

        public Form1()
        {
            InitializeComponent();
            api = new API();
            this.Load += Form1_Load;

            //gmap = new GMapControl();
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            //gmap.Dock = DockStyle.Fill;
            //gmap.ShowCenter = false;
            gMapControl1.MinZoom = 1;
            gMapControl1.MaxZoom = 20;
            gMapControl1.Zoom = 12;
            gMapControl1.Position = new PointLatLng(53.8, -1.6); // Centered on Leeds
            gMapControl1.DragButton = MouseButtons.Left;

            splitContainer1.Panel1.Controls.Add(gmap);
            gMapControl1.Dock = DockStyle.Fill;

            




        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                flightList = await api.GetStatesAsync();
                Debug.WriteLine("API was called");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = flightList;

                map = new Bitmap("leedsMapDemo.png");
            }

            catch (Exception er)
            {
                Debug.WriteLine("Error: " + er.Message);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Debug.WriteLine("painting");


            //pictureBox1.Image = Bitmap.FromFile("leedsMapDemo.png");






        }
        // private void pictureBox1_Paint(object sender, PaintEventArgs e)
        //{
        //   Pen pen = new Pen(Color.Red, 3);
        //   Bitmap myBitmap = new Bitmap("C:/Users/ianct/source/repos/ProductionProject/LeedsMapDemo.png.png");
        //   Graphics g = Graphics.FromImage(myBitmap);
        //   e.Graphics.DrawImage(myBitmap, 0, 0, pictureBox1.Width, pictureBox1.Height);
        //   e.Graphics.DrawEllipse(pen, 230, 100, 500, 500);
        //  }


        private async void Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                flightList = await api.GetStatesAsync();
                Debug.WriteLine("API was called");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = flightList;
            }

            catch (Exception er)
            {
                Debug.WriteLine("Error: " + er.Message);
            }
        }

       

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            
        }

    
    }
}
