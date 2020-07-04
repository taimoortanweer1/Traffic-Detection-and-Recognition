using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace TrafficAnalytics
{
    public partial class VideoPlayControl : UserControl
    {
        private Capture capVid = null;
        public string VideoSourceFile { get; set; }

        public string VideoTitle
        {
            get
            {
                return this.groupBox.Text;
            }
            set
            {
                this.groupBox.Text = value;
            }
        }

        public VideoPlayControl()
        {
            InitializeComponent();
        }

        private void VideoPlayControl_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            try
            {
                if (this.VideoSourceFile == "")
                {
                    this.pictureBoxRawScreen.Image = new Image<Bgr, Byte>("offline.bmp").Bitmap;
                    return;
                }
                capVid = new Capture(this.VideoSourceFile);
                capVid.ImageGrabbed += ProcessFrame;
                capVid.Start();
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }

        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            Image<Bgr, Byte> frame_cap;
            frame_cap = capVid.RetrieveBgrFrame();

            this.pictureBoxRawScreen.Image = frame_cap.ToBitmap();
            this.pictureBoxRawScreen.Invalidate();
        }
    }
}
