namespace TrafficAnalytics
{
    partial class DahsboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.videoPlayControl2 = new VideoPlayControl();
            this.videoPlayControl1 = new VideoPlayControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Location = new System.Drawing.Point(227, 28);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(594, 592);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // videoPlayControl2
            // 
            this.videoPlayControl2.BackgroundImage = global::TrafficAnalytics.Properties.Resources.offline;
            this.videoPlayControl2.Location = new System.Drawing.Point(12, 187);
            this.videoPlayControl2.Name = "videoPlayControl2";
            this.videoPlayControl2.Size = new System.Drawing.Size(209, 153);
            this.videoPlayControl2.TabIndex = 4;
            this.videoPlayControl2.VideoSourceFile = "";
            this.videoPlayControl2.VideoTitle = "Video 2";
            // 
            // videoPlayControl1
            // 
            this.videoPlayControl1.Location = new System.Drawing.Point(12, 28);
            this.videoPlayControl1.Name = "videoPlayControl1";
            this.videoPlayControl1.Size = new System.Drawing.Size(209, 153);
            this.videoPlayControl1.TabIndex = 4;
            this.videoPlayControl1.VideoSourceFile = "convertedVideo.avi";
            this.videoPlayControl1.VideoTitle = "Video 1";
            // 
            // DahsboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 632);
            this.Controls.Add(this.videoPlayControl2);
            this.Controls.Add(this.videoPlayControl1);
            this.Controls.Add(this.pictureBox4);
            this.Name = "DahsboardForm";
            this.Text = "DahsboardForm";
            this.Load += new System.EventHandler(this.DahsboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private VideoPlayControl videoPlayControl1;
        private VideoPlayControl videoPlayControl2;
    }
}