using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GMap.NET;
using GMap.NET.WindowsForms;
using System.Drawing.Drawing2D;



namespace ProductionProject
{
    public class flightMarker : GMapMarker
    {
        private readonly Image PlaneIcon;
        public float planeDirection { get; set; } //true_track passed which is the degree the plane is heading

        public flightMarker(PointLatLng position, Image planeIcon, float planeDirection) : base(position)
        {
            if (planeIcon == null)
            {
                throw new ArgumentNullException(nameof(planeIcon), "Plane icon image cannot be null.");
            }

            this.PlaneIcon = planeIcon;
            this.planeDirection = planeDirection;
            Size = new Size(PlaneIcon.Width, planeIcon.Height); // Set the size of the marker
            Offset = new Point(-Size.Width / 2, -Size.Height / 2); // Center the marker

            
        }

        public override void OnRender(Graphics g)
        {
            Matrix temp = g.Transform;

            g.TranslateTransform(LocalPosition.X, LocalPosition.Y);
            //g.RotateTransform(-Overlay.Control.Bearing); 
            g.RotateTransform(planeDirection);

            float baseZoom = 12f;
            float scale = (float)Math.Pow(1.1, Overlay.Control.Zoom - baseZoom);

            int scaledWidth = (int)(PlaneIcon.Width * scale);
            int scaledHeight = (int)(PlaneIcon.Height * scale);


            g.DrawImage(PlaneIcon, -scaledWidth /2, scaledHeight / 2, scaledWidth, scaledHeight);
            g.Transform = temp;

        }
    }
}
