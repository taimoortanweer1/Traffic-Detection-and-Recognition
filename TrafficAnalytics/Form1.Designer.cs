namespace TrafficAnalytics
{
    partial class TrafficAnalytics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrafficAnalytics));
            this.displayScreen = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.rawScreen = new System.Windows.Forms.PictureBox();
            this.stInLTV = new System.Windows.Forms.TextBox();
            this.stInHTV = new System.Windows.Forms.TextBox();
            this.txtInFlow = new System.Windows.Forms.TextBox();
            this.stInFlow = new System.Windows.Forms.TextBox();
            this.txtInHTV = new System.Windows.Forms.TextBox();
            this.txtInLTV = new System.Windows.Forms.TextBox();
            this.grpIncomingTraffic = new System.Windows.Forms.GroupBox();
            this.grpOutgoingTraffic = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtOutHTV = new System.Windows.Forms.TextBox();
            this.txtOutLTV = new System.Windows.Forms.TextBox();
            this.txtOutFlow = new System.Windows.Forms.TextBox();
            this.stOutHTV = new System.Windows.Forms.TextBox();
            this.stOutLTV = new System.Windows.Forms.TextBox();
            this.incomingLabel = new System.Windows.Forms.Label();
            this.outgoingLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_alarm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawScreen)).BeginInit();
            this.grpIncomingTraffic.SuspendLayout();
            this.grpOutgoingTraffic.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayScreen
            // 
            this.displayScreen.BackColor = System.Drawing.Color.Black;
            this.displayScreen.Location = new System.Drawing.Point(12, 12);
            this.displayScreen.Name = "displayScreen";
            this.displayScreen.Size = new System.Drawing.Size(556, 466);
            this.displayScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.displayScreen.TabIndex = 0;
            this.displayScreen.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(590, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(185, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(590, 447);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(185, 31);
            this.btnStart.TabIndex = 21;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rawScreen
            // 
            this.rawScreen.BackColor = System.Drawing.Color.Black;
            this.rawScreen.Location = new System.Drawing.Point(12, 12);
            this.rawScreen.Name = "rawScreen";
            this.rawScreen.Size = new System.Drawing.Size(556, 466);
            this.rawScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rawScreen.TabIndex = 23;
            this.rawScreen.TabStop = false;
            // 
            // stInLTV
            // 
            this.stInLTV.Enabled = false;
            this.stInLTV.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stInLTV.Location = new System.Drawing.Point(6, 24);
            this.stInLTV.Name = "stInLTV";
            this.stInLTV.Size = new System.Drawing.Size(55, 23);
            this.stInLTV.TabIndex = 24;
            this.stInLTV.Text = "LTV";
            // 
            // stInHTV
            // 
            this.stInHTV.Enabled = false;
            this.stInHTV.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stInHTV.Location = new System.Drawing.Point(6, 58);
            this.stInHTV.Name = "stInHTV";
            this.stInHTV.Size = new System.Drawing.Size(55, 23);
            this.stInHTV.TabIndex = 25;
            this.stInHTV.Text = "HTV";
            // 
            // txtInFlow
            // 
            this.txtInFlow.Enabled = false;
            this.txtInFlow.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInFlow.Location = new System.Drawing.Point(6, 92);
            this.txtInFlow.Name = "txtInFlow";
            this.txtInFlow.Size = new System.Drawing.Size(55, 23);
            this.txtInFlow.TabIndex = 26;
            this.txtInFlow.Text = "0";
            // 
            // stInFlow
            // 
            this.stInFlow.Enabled = false;
            this.stInFlow.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stInFlow.Location = new System.Drawing.Point(67, 92);
            this.stInFlow.Name = "stInFlow";
            this.stInFlow.Size = new System.Drawing.Size(112, 23);
            this.stInFlow.TabIndex = 29;
            this.stInFlow.Text = "Vehicles/Hr";
            // 
            // txtInHTV
            // 
            this.txtInHTV.Enabled = false;
            this.txtInHTV.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInHTV.Location = new System.Drawing.Point(67, 58);
            this.txtInHTV.Name = "txtInHTV";
            this.txtInHTV.Size = new System.Drawing.Size(112, 23);
            this.txtInHTV.TabIndex = 28;
            this.txtInHTV.Text = "0";
            // 
            // txtInLTV
            // 
            this.txtInLTV.Enabled = false;
            this.txtInLTV.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInLTV.Location = new System.Drawing.Point(67, 24);
            this.txtInLTV.Name = "txtInLTV";
            this.txtInLTV.Size = new System.Drawing.Size(112, 23);
            this.txtInLTV.TabIndex = 27;
            this.txtInLTV.Text = "0";
            // 
            // grpIncomingTraffic
            // 
            this.grpIncomingTraffic.Controls.Add(this.stInFlow);
            this.grpIncomingTraffic.Controls.Add(this.txtInHTV);
            this.grpIncomingTraffic.Controls.Add(this.txtInLTV);
            this.grpIncomingTraffic.Controls.Add(this.txtInFlow);
            this.grpIncomingTraffic.Controls.Add(this.stInHTV);
            this.grpIncomingTraffic.Controls.Add(this.stInLTV);
            this.grpIncomingTraffic.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIncomingTraffic.Location = new System.Drawing.Point(590, 109);
            this.grpIncomingTraffic.Name = "grpIncomingTraffic";
            this.grpIncomingTraffic.Size = new System.Drawing.Size(185, 128);
            this.grpIncomingTraffic.TabIndex = 30;
            this.grpIncomingTraffic.TabStop = false;
            this.grpIncomingTraffic.Text = "Incoming Traffic";
            // 
            // grpOutgoingTraffic
            // 
            this.grpOutgoingTraffic.Controls.Add(this.textBox1);
            this.grpOutgoingTraffic.Controls.Add(this.txtOutHTV);
            this.grpOutgoingTraffic.Controls.Add(this.txtOutLTV);
            this.grpOutgoingTraffic.Controls.Add(this.txtOutFlow);
            this.grpOutgoingTraffic.Controls.Add(this.stOutHTV);
            this.grpOutgoingTraffic.Controls.Add(this.stOutLTV);
            this.grpOutgoingTraffic.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOutgoingTraffic.Location = new System.Drawing.Point(590, 240);
            this.grpOutgoingTraffic.Name = "grpOutgoingTraffic";
            this.grpOutgoingTraffic.Size = new System.Drawing.Size(185, 128);
            this.grpOutgoingTraffic.TabIndex = 31;
            this.grpOutgoingTraffic.TabStop = false;
            this.grpOutgoingTraffic.Text = "Outgoing Traffic";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(67, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 23);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = "Vehicles/Hr";
            // 
            // txtOutHTV
            // 
            this.txtOutHTV.Enabled = false;
            this.txtOutHTV.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutHTV.Location = new System.Drawing.Point(67, 58);
            this.txtOutHTV.Name = "txtOutHTV";
            this.txtOutHTV.Size = new System.Drawing.Size(112, 23);
            this.txtOutHTV.TabIndex = 28;
            this.txtOutHTV.Text = "0";
            // 
            // txtOutLTV
            // 
            this.txtOutLTV.Enabled = false;
            this.txtOutLTV.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutLTV.Location = new System.Drawing.Point(67, 24);
            this.txtOutLTV.Name = "txtOutLTV";
            this.txtOutLTV.Size = new System.Drawing.Size(112, 23);
            this.txtOutLTV.TabIndex = 27;
            this.txtOutLTV.Text = "0";
            // 
            // txtOutFlow
            // 
            this.txtOutFlow.Enabled = false;
            this.txtOutFlow.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutFlow.Location = new System.Drawing.Point(6, 92);
            this.txtOutFlow.Name = "txtOutFlow";
            this.txtOutFlow.Size = new System.Drawing.Size(55, 23);
            this.txtOutFlow.TabIndex = 26;
            this.txtOutFlow.Text = "0";
            // 
            // stOutHTV
            // 
            this.stOutHTV.Enabled = false;
            this.stOutHTV.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stOutHTV.Location = new System.Drawing.Point(6, 58);
            this.stOutHTV.Name = "stOutHTV";
            this.stOutHTV.Size = new System.Drawing.Size(55, 23);
            this.stOutHTV.TabIndex = 25;
            this.stOutHTV.Text = "HTV";
            // 
            // stOutLTV
            // 
            this.stOutLTV.Enabled = false;
            this.stOutLTV.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stOutLTV.Location = new System.Drawing.Point(6, 24);
            this.stOutLTV.Name = "stOutLTV";
            this.stOutLTV.Size = new System.Drawing.Size(55, 23);
            this.stOutLTV.TabIndex = 24;
            this.stOutLTV.Text = "LTV";
            // 
            // incomingLabel
            // 
            this.incomingLabel.BackColor = System.Drawing.Color.Transparent;
            this.incomingLabel.Font = new System.Drawing.Font("Verdana", 30F);
            this.incomingLabel.ForeColor = System.Drawing.Color.Navy;
            this.incomingLabel.Location = new System.Drawing.Point(12, 12);
            this.incomingLabel.Name = "incomingLabel";
            this.incomingLabel.Size = new System.Drawing.Size(234, 101);
            this.incomingLabel.TabIndex = 32;
            this.incomingLabel.Text = "Incoming Traffic";
            this.incomingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // outgoingLabel
            // 
            this.outgoingLabel.BackColor = System.Drawing.Color.Transparent;
            this.outgoingLabel.Font = new System.Drawing.Font("Verdana", 30F);
            this.outgoingLabel.ForeColor = System.Drawing.Color.Navy;
            this.outgoingLabel.Location = new System.Drawing.Point(334, 12);
            this.outgoingLabel.Name = "outgoingLabel";
            this.outgoingLabel.Size = new System.Drawing.Size(234, 101);
            this.outgoingLabel.TabIndex = 33;
            this.outgoingLabel.Text = "Outgoing Traffic";
            this.outgoingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_alarm);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(590, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 60);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alarm";
            // 
            // textBox_alarm
            // 
            this.textBox_alarm.Enabled = false;
            this.textBox_alarm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_alarm.Location = new System.Drawing.Point(6, 24);
            this.textBox_alarm.Name = "textBox_alarm";
            this.textBox_alarm.Size = new System.Drawing.Size(173, 23);
            this.textBox_alarm.TabIndex = 24;
            // 
            // TrafficAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 486);
            this.Controls.Add(this.outgoingLabel);
            this.Controls.Add(this.incomingLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpOutgoingTraffic);
            this.Controls.Add(this.grpIncomingTraffic);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rawScreen);
            this.Controls.Add(this.displayScreen);
            this.Name = "TrafficAnalytics";
            this.Text = "Traffic Analytics";
            ((System.ComponentModel.ISupportInitialize)(this.displayScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawScreen)).EndInit();
            this.grpIncomingTraffic.ResumeLayout(false);
            this.grpIncomingTraffic.PerformLayout();
            this.grpOutgoingTraffic.ResumeLayout(false);
            this.grpOutgoingTraffic.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox displayScreen;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox rawScreen;
        private System.Windows.Forms.TextBox stInLTV;
        private System.Windows.Forms.TextBox stInHTV;
        private System.Windows.Forms.TextBox txtInFlow;
        private System.Windows.Forms.TextBox stInFlow;
        private System.Windows.Forms.TextBox txtInHTV;
        private System.Windows.Forms.TextBox txtInLTV;
        private System.Windows.Forms.GroupBox grpIncomingTraffic;
        private System.Windows.Forms.GroupBox grpOutgoingTraffic;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtOutHTV;
        private System.Windows.Forms.TextBox txtOutLTV;
        private System.Windows.Forms.TextBox txtOutFlow;
        private System.Windows.Forms.TextBox stOutHTV;
        private System.Windows.Forms.TextBox stOutLTV;
        private System.Windows.Forms.Label incomingLabel;
        private System.Windows.Forms.Label outgoingLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_alarm;
    }
}

