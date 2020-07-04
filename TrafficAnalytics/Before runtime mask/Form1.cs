using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.CvEnum;
using Helpers;


namespace TrafficAnalytics
{
    public partial class TrafficAnalytics : Form
    {
        const int HTVSIZE = 2500;
        const int speedX = 1;

        private Capture capVid = null;
        private bool capInProg = false;
        int cars = 0;
        int HTV = 0;
        int LTV = 0;
        int inHTV = 0;
        int inLTV = 0;
        int outHTV = 0;
        int outLTV = 0;
        int frameCount = 0;

        DateTime flowTime = DateTime.Now;
        int preMin = 0;
        

        int[] ln = new int[6];
        int[] lnsize = new int[6];
        bool[] hasCar = new bool[6];
        int[] inFlowCount = new int[60];
        int[] outFlowCount = new int[60];


        int row = 444;

        public TrafficAnalytics()
        {
            InitializeComponent();
            //CheckForIllegalCrossThreadCalls = false;


            incomingLabel.Parent = rawScreen;
            incomingLabel.BackColor = Color.Transparent;
            outgoingLabel.Parent = rawScreen;
            outgoingLabel.BackColor = Color.Transparent;

            try
            {
                capVid = new Capture("convertedNight.avi");
                capVid.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (capVid != null)
            {
                if (capInProg)
                {  //stop the capture
                    btnStart.Text = "Start";
                    capVid.Pause();
                }
                else
                {
                    //start the capture
                    btnStart.Text = "Stop";
                    capVid.Start();
                    //process();
                }

                capInProg = !capInProg;
            }
        }

        void process()
        {
            //capVid.Pause();
            //while (true)
            //{
            //    //Thread.Sleep(10);
            //    Image<Bgr, Byte> frame_cap;// = _capture.RetrieveBgrFrame();
            //    capVid.QueryGrayFrame();

            //    frame_cap = capVid.RetrieveBgrFrame();

            //    Image<Gray, byte> grayIm = new Image<Gray, byte>(frame_cap.Width, frame_cap.Height);
            //    grayIm = frame_cap.Convert<Gray, byte>();

            //    Image<Gray, byte> binmask = new Image<Gray, byte>("bitMask.bmp");
            //    Image<Gray, Byte> rodmask = new Image<Gray, byte>("maskRoad.bmp");
            //    Image<Gray, byte> result = new Image<Gray, byte>(frame_cap.Width, frame_cap.Height);

            //    Gray avgclr = rodmask.GetAverage();
            //    int avg = (int)avgclr.Intensity;

            //    result = binmask.And(grayIm);

            //    //for (int i = 0; i < frame_cap.Height; i++)
            //    //{
            //    //    for (int j = 0; j < frame_cap.Width; j++)
            //    //    {
            //    //        if (binmask.Data[i, j, 0] == 0)
            //    //        {
            //    //            //result.Data[i, j, 0] = grayIm.Data[i, j, 0] - rodmask.Data[i, j, 0];
            //    //            grayIm.Data[i, j, 0] = 0;
            //    //        }
            //    //    }
            //    //}

            //    result = result.Sub(rodmask);

            //    //Gray thr = new Gray(30);
            //    //result = result.ThresholdToZero(thr);
            //    result = result.Mul(5);


            //    result = result.SmoothBlur(15, 15);
            //    Gray thr = new Gray(80);
            //    Gray mx = new Gray(255);
            //    result = result.ThresholdBinary(thr, mx);

            //    for (int i = 0; i < 6; i++)
            //    {
            //        ln[i] = 0;
            //        //hasCar[i] = false;
            //    }


            //    for (int i = 313; i < 400; i++)
            //    {
            //        if (result.Data[row, i, 0] > 100)
            //        {
            //            ln[0]++;
            //        }
            //    }

            //    for (int i = 410; i < 490; i++)
            //    {
            //        if (result.Data[row, i, 0] > 100)
            //        {
            //            ln[1]++;
            //        }
            //    }

            //    for (int i = 510; i < 580; i++)
            //    {
            //        if (result.Data[row, i, 0] > 100)
            //        {
            //            ln[2]++;
            //        }
            //    }

            //    for (int i = 720; i < 800; i++)
            //    {
            //        if (result.Data[row, i, 0] > 100)
            //        {
            //            ln[3]++;
            //        }
            //    }

            //    for (int i = 830; i < 920; i++)
            //    {
            //        if (result.Data[row, i, 0] > 100)
            //        {
            //            ln[4]++;
            //        }
            //    }

            //    for (int i = 945; i < 1040; i++)
            //    {
            //        if (result.Data[row, i, 0] > 100)
            //        {
            //            ln[5]++;
            //        }
            //    }

            //    for (int i = 0; i < grayIm.Width; i++)
            //    {
            //        if ((i > 313 && i < 400) || (i > 410 && i < 490) || (i > 510 && i < 580) || (i > 720 && i < 800) || (i > 830 && i < 920) || (i > 945 && i < 1040))
            //        {

            //            grayIm.Data[row, i, 0] = 0;
            //            result.Data[row, i, 0] = 255;
            //        }
            //    }

            //    displayScreen.Image = result.ToBitmap();
            //    rawScreen.Image = grayIm.ToBitmap();
            //    displayScreen.Invalidate();
            //    rawScreen.Invalidate();

            //    for (int i = 0; i < 6; i++)
            //    {
            //        if (!hasCar[i] && ln[i] > 20)
            //        {
            //            cars++;
            //            MessageBox.Show("car in lane " + (i + 1).ToString() + "\nTotal cars =" + cars.ToString());
            //            txtCarCnt.Text = "Car Count = " + cars.ToString();
            //        }
            //        if (ln[i] > 20)
            //        {
            //            hasCar[i] = true;
            //        }
            //        else
            //        {
            //            hasCar[i] = false;
            //        }
            //    }
            //}
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            capVid.SetCaptureProperty((CAP_PROP)1, frameCount);
            frameCount += speedX;
            //DateTime t1 = DateTime.Now;
            //rawScreen.Image = capVid.RetrieveBgrFrame().Bitmap;
            //return;

            Image<Bgr, Byte> frame_cap;// = _capture.RetrieveBgrFrame();
            frame_cap = capVid.RetrieveBgrFrame();

            Image<Gray, byte> grayIm = new Image<Gray, byte>(frame_cap.Width, frame_cap.Height);
            grayIm = frame_cap.Convert<Gray, byte>();

            Image<Gray, byte> binmask = new Image<Gray, byte>("bitMask.bmp");
            Image<Gray, Byte> rodmask = new Image<Gray, byte>("nightmask.bmp");
            Image<Gray, byte> result = new Image<Gray, byte>(frame_cap.Width, frame_cap.Height);

            Gray avgclr = rodmask.GetAverage();
            int avg = (int)avgclr.Intensity;

            result = binmask.And(grayIm);

            result = result.Sub(rodmask);

            //Gray thr = new Gray(50);
            //result = result.ThresholdToZero(thr);

            result = result.Mul(5);


            result = result.SmoothBlur(15, 15);
            Gray thr = new Gray(80);
            Gray mx = new Gray(255);
            result = result.ThresholdBinary(thr, mx);

            for (int i = 0; i < 6; i++)
            {
                ln[i] = 0;
                //hasCar[i] = false;
            }


            for (int i = 313; i < 400; i++)
            {
                if (result.Data[row, i, 0] > 100)
                {
                    ln[0]++;
                }
            }

            for (int i = 410; i < 490; i++)
            {
                if (result.Data[row, i, 0] > 100)
                {
                    ln[1]++;
                }
            }

            for (int i = 510; i < 580; i++)
            {
                if (result.Data[row, i, 0] > 100)
                {
                    ln[2]++;
                }
            }

            for (int i = 720; i < 800; i++)
            {
                if (result.Data[row, i, 0] > 100)
                {
                    ln[3]++;
                }
            }

            for (int i = 830; i < 920; i++)
            {
                if (result.Data[row, i, 0] > 100)
                {
                    ln[4]++;
                }
            }

            for (int i = 945; i < 1040; i++)
            {
                if (result.Data[row, i, 0] > 100)
                {
                    ln[5]++;
                }
            }

            for (int i = 0; i < grayIm.Width; i++)
            {
                if ((i > 313 && i < 400) || (i > 410 && i < 490) || (i > 510 && i < 580) || (i > 720 && i < 800) || (i > 830 && i < 920) || (i > 945 && i < 1040))
                {

                    grayIm.Data[row, i, 0] = 0;
                    result.Data[row, i, 0] = 255;
                }
            }

            //displayScreen.Image = result.ToBitmap();
            rawScreen.Image = frame_cap.ToBitmap();
            //displayScreen.Invalidate();
            rawScreen.Invalidate();
            //MessageBox.Show("");

            for (int i = 0; i < 6; i++)
            {
                //if (!hasCar[i] && ln[i] > 20)
                //{
                //    cars++;
                //    MessageBox.Show("car in lane " + (i + 1).ToString() + "\nTotal cars =" + cars.ToString() + "\nHTV = " + HTV.ToString() + "\nLTV = " + LTV.ToString());
                //    //txtCarCnt.Text = "Car Count = " + cars.ToString();
                //}

                if (hasCar[i] && ln[i] < 20)
                {
                    cars++;
                    //MessageBox.Show("car in lane " + (i + 1).ToString() + "\nTotal cars =" + cars.ToString() + "\nHTV = " + HTV.ToString() + "\nLTV = " + LTV.ToString());
                    //txtCarCnt.Text = "Car Count = " + cars.ToString();
                }


                if (ln[i] > 20)
                {
                    lnsize[i] += ln[i];
                    hasCar[i] = true;
                }
                else
                {
                    if (lnsize[i] > HTVSIZE)
                    {
                        HTV++;
                        if (i >= 0 && i < 4)
                        {
                            inHTV++;

                            CrossThreadOperation.Invoke(txtInHTV, () =>
                            {
                                txtInHTV.Text = inHTV.ToString();
                            });
                        }
                        else if (i > 3 && i < 6)
                        {
                            outHTV++;
                            CrossThreadOperation.Invoke(txtOutHTV, () =>
                            {
                                txtOutHTV.Text = outHTV.ToString();
                            });
                        }
                    }
                    else if (lnsize[i] < HTVSIZE && lnsize[i] > 0)
                    {
                        LTV++;
                        if(i >= 0 && i < 3)
                        {
                            inLTV++;
                            CrossThreadOperation.Invoke(txtInLTV, () =>
                            {
                                txtInLTV.Text = inLTV.ToString();
                            });
                        }
                        else if (i > 2 && i < 6)
                        {
                            outLTV++;
                            CrossThreadOperation.Invoke(txtOutLTV, () =>
                            {
                                txtOutLTV.Text = outLTV.ToString();
                            });
                        }
                    }
                    lnsize[i] = 0;
                    hasCar[i] = false;
                }
            }

            flowTime = DateTime.Now;

            if (flowTime.Minute != preMin)
            {
                for (int i = 59; i > 0; i--)
                {
                    inFlowCount[i] = inFlowCount[i - 1];
                    outFlowCount[i] = outFlowCount[i - 1];
                }
                inFlowCount[0] = inHTV + inLTV - inFlowCount[1];
                CrossThreadOperation.Invoke(txtInFlow, () =>
                {
                    txtInFlow.Text = inFlowCount.Sum().ToString();
                });
                outFlowCount[0] = outHTV + outLTV - outFlowCount[1];
                CrossThreadOperation.Invoke(txtOutFlow, () =>
                {
                    txtOutFlow.Text = outFlowCount.Sum().ToString();
                }); 
            }

            preMin = flowTime.Minute;
            
            //DateTime t2 = DateTime.Now;
            //MessageBox.Show(t1.Millisecond.ToString() + "\n" + t2.Millisecond.ToString());
        }
    }
}
