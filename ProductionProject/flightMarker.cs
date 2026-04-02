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
    public class flightMarker : GMapMarker //Inherits from GMapMarker, which is a class from the GMap.NET library used to represent markers on a map.
    {
        public Image PlaneIcon; //Image property to hold the plane icon that will be displayed on the map marker.
        public float planeDirection { get; set; } //true_track passed which is the degree the plane is heading

        /// <summary>
        /// Constructor that uses passed in parameters to initialize the flightMarker object.
        /// It takes a PointLatLng for the position of the marker, an Image for the plane icon, and a float for the plane's direction. 
        /// The constructor also sets the size of the marker based on the dimensions of the plane icon and centers it using the Offset property.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="planeIcon"></param>
        /// <param name="planeDirection"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public flightMarker(PointLatLng position, Image planeIcon, float planeDirection) : base(position)
        {
            //ensures theres a plane icon to use for the marker
            if (planeIcon == null)
            {
                throw new ArgumentNullException(nameof(planeIcon), "Plane icon image cannot be null.");
            }

            this.PlaneIcon = planeIcon;
            this.planeDirection = planeDirection;
            Size = new Size(PlaneIcon.Width, planeIcon.Height);  //set the marker size using image image dimensions
            //ensrues marker is centred on the plane's position by setting the offset to half the width and height of the marker
            Offset = new Point(-Size.Width / 2, -Size.Height / 2);
        }
        /// <summary>
        /// Overrides default rendering to appl rotation adn scaling of plane image based on the plane's direction 
        /// and the zoom level of map.
        /// </summary>
        /// <param name="g"></param>
        public override void OnRender(Graphics g)
        {
            Matrix temp = g.Transform;//store current transformation matrix to restore it after drawing 
            //scaling marker size dynamically based off zoom level
            float baseZoom = 12f;
            float scale = (float)Math.Pow(1.1, Overlay.Control.Zoom - baseZoom);
            int scaledWidth = (int)(PlaneIcon.Width * scale);
            int scaledHeight = (int)(PlaneIcon.Height * scale);

            //update the size and offset of the marker based on the scaled dimensions to ensure it remains centered on the plane's position
            Size = new Size(scaledWidth, scaledHeight); // Set the size of the marker
            Offset = new Point(-scaledWidth / 2, -scaledHeight / 2);

            //move drawing position to marker coordinates on map
            g.TranslateTransform(LocalPosition.X + Size.Width/2, LocalPosition.Y + Size.Height /2);
            //adjust from plane's bearing and direction to ensure the plane icon is oriented correctly on the map
            g.RotateTransform(-Overlay.Control.Bearing);
            g.RotateTransform(planeDirection);//rotate the plane icon based on the plane's direction to keep it aligned
            g.DrawImage(PlaneIcon, -scaledWidth /2, -scaledHeight / 2, scaledWidth, scaledHeight);//draw the plane onm the map 
            //resore the original transformation matrix to prevent affecting other object on the map when theyre drawn
            g.Transform = temp;

        }
    }
}
