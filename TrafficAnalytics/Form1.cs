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
using VideoAnalytics;


namespace TrafficAnalytics
{
    public partial class TrafficAnalytics : Form
    {
        const int   HTVSIZE = 1000;
        const int   speedX = 1;
        const int   isCAR = 40;
        const int   isSumCAR = 00;
        const bool  DAY = true;


        Image<Gray, Byte> prv = new Image<Gray, byte>(1280, 720);
        Image<Gray, byte> subtr = new Image<Gray, byte>(1280, 720);

        private Capture capVid = null;
        private bool capInProg = false;
        int cars = 0;
        int HTV = 0;
        int LTV = 0;
        int inHTV = 0;
        int inLTV = 0;
        int outHTV = 0;
        int outLTV = 0;
        int frameCount = 200;

        DateTime flowTime = DateTime.Now;
        int preMin = 0;


        int[] ln = new int[6];
        int[] lnsize = new int[6];
        bool[] hasCar = new bool[6];
        int[] inFlowCount = new int[60];
        int[] outFlowCount = new int[60];


        int row = 444 + 100;

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
                if (DAY)
                {
                    capVid = new Capture("convertedVideoDay.avi");
                }
                else
                {
                    capVid = new Capture("convertedNight.avi");
                }
                
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

        bool alert_sent = false;

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
            Image<Gray, byte> binmask = new Image<Gray, byte>(frame_cap.Width, frame_cap.Height);
            Image<Gray, byte> rodmask = new Image<Gray, byte>(frame_cap.Width, frame_cap.Height);

            if (DAY)
            {
                binmask = new Image<Gray, byte>("bitMask.bmp");
                rodmask = new Image<Gray, byte>("maskRoad.bmp");
            }
            else
            {
                binmask = new Image<Gray, byte>("bitMaskNight.bmp");
                rodmask = new Image<Gray, byte>("nightmask.bmp");
            }

            
            Image<Gray, byte> result = new Image<Gray, byte>(frame_cap.Width, frame_cap.Height);

            Gray avgclr = rodmask.GetAverage();
            int avg = (int)avgclr.Intensity;

            result = binmask.And(grayIm);
            if (DAY)
            {
                result = result.Sub(rodmask);// +rodmask.Sub(result);
            }
            else
            {
                result = result.Sub(rodmask) + rodmask.Sub(result);
            }
            //result = result.Sub(rodmask);//add this for night +rodmask.Sub(result);

            //for (int i = row-200; i < grayIm.Height; i++)
            //{
            //    for (int j = 0; j < grayIm.Width; j++)
            //    {
            //        int r = rodmask.Data[i, j, 0] - result.Data[i, j, 0];
                    
            //        if (r > 20 || r < -20)
            //        {
            //            result.Data[i, j, 0] = 255;
            //        }
            //        else
            //        {
            //            result.Data[i, j, 0] = 0;
            //        }
            //    }
            //}


            //displayScreen.Image = grayIm.ToBitmap();
            //rawScreen.Image = result.ToBitmap();
            //return;

            //Gray thr = new Gray(50);
            //result = result.ThresholdToZero(thr);

            result = result.Mul(5);
            result = result.SmoothBlur(25, 15);
            Gray thr;
            if (DAY)
            {
                thr = new Gray(80);//day threshhold 80
            }
            else
            {
                thr = new Gray(60);//night threshhold 60
            }
            //Gray thr = new Gray(80);//night threshhold 60
            Gray mx = new Gray(255);
            result = result.ThresholdBinary(thr, mx);

            for (int i = 0; i < 6; i++)
            {
                ln[i] = 0;
                //hasCar[i] = false;
            }


            for (int i = 210; i < 350; i++)
            {
                if (result.Data[row, i, 0] > 100)
                {
                    ln[0]++;
                }
            }

            for (int i = 350; i < 420; i++)
            {
                if (result.Data[row, i, 0] > 100)
                {
                    ln[1]++;
                }
            }

            for (int i = 420; i < 570; i++)
            {
                if (result.Data[row, i, 0] > 100)
                {
                    ln[2]++;
                }
            }

            //for (int i = 720; i < 800; i++)
            //{
            //    if (result.Data[row, i, 0] > 100)
            //    {
            //        ln[3]++;
            //    }
            //}

            //for (int i = 830; i < 920; i++)
            //{
            //    if (result.Data[row, i, 0] > 100)
            //    {
            //        ln[4]++;
            //    }
            //}

            //for (int i = 945; i < 1040; i++)
            //{
            //    if (result.Data[row, i, 0] > 100)
            //    {
            //        ln[5]++;
            //    }
            //}

            //for night

            for (int i = 750; i < 870; i++)
            {
                if (result.Data[row, i, 0] > 100)
                {
                    ln[3]++;
                }
            }

            for (int i = 920; i < 1070; i++)
            {
                if (result.Data[row, i, 0] > 100)
                {
                    ln[4]++;
                }
            }

            for (int i = 1130; i < 1220; i++)
            {
                if (result.Data[row, i, 0] > 100)
                {
                    ln[5]++;
                }
            }

            //for (int i = 0; i < grayIm.Width; i++)
            //{
            //    if ((i > 313 && i < 400) || (i > 410 && i < 490) || (i > 510 && i < 580) || (i > 720 && i < 800) || (i > 830 && i < 920) || (i > 945 && i < 1040))
            //    {

            //        grayIm.Data[row, i, 0] = 0;
            //        result.Data[row, i, 0] = 255;
            //    }
            //}


            //for night

            for (int i = 0; i < grayIm.Width; i++)
            {
                if ((i > 210 && i < 350) || (i > 350 && i < 420) || (i > 420 && i < 570) || (i > 750 && i < 870) || (i > 920 && i < 1070) || (i > 1130 && i < 1220))
                {

                    grayIm.Data[row, i, 0] = 0;
                    result.Data[row, i, 0] = 255;
                }
            }

            
            if (!(prv.Equals(grayIm.CopyBlank())))
            {
                //subtr = subtr.Add(prv.Sub(grayIm));
                subtr = prv.Sub(grayIm.And(binmask));
            }

            subtr = subtr.ThresholdBinary(new Gray(50), new Gray(255));

            prv = grayIm;
            
            
            //displayScreen.Image = frame_cap.ToBitmap();
            CrossThreadOperation.Invoke(rawScreen, () =>
            {
                rawScreen.Image = frame_cap.ToBitmap();
            });
            //displayScreen.Invalidate();
            //rawScreen.Invalidate();
            //MessageBox.Show("");

            for (int i = 0; i < 6; i++)
            {
                //if (!hasCar[i] && ln[i] > 20)
                //{
                //    cars++;
                //    MessageBox.Show("car in lane " + (i + 1).ToString() + "\nTotal cars =" + cars.ToString() + "\nHTV = " + HTV.ToString() + "\nLTV = " + LTV.ToString());
                //    //txtCarCnt.Text = "Car Count = " + cars.ToString();
                //}

                if (hasCar[i] && ln[i] < isCAR)
                {
                    cars++;
                    //MessageBox.Show("car in lane " + (i + 1).ToString() + "\nTotal cars =" + cars.ToString() + "\nHTV = " + HTV.ToString() + "\nLTV = " + LTV.ToString());
                    //txtCarCnt.Text = "Car Count = " + cars.ToString();
                }


                if (ln[i] > isCAR)
                {
                    lnsize[i] += ln[i];
                    hasCar[i] = true;
                }
                else
                {
                    if (lnsize[i] > HTVSIZE)
                    {
                        HTV++;
                        if (i >= 0 && i < 3)
                        {
                            inHTV++;

                            CrossThreadOperation.Invoke(txtInHTV, () =>
                            {
                                txtInHTV.Text = inHTV.ToString();
                            });
                        }
                        else if (i > 2 && i < 6)
                        {
                            outHTV++;
                            CrossThreadOperation.Invoke(txtOutHTV, () =>
                            {
                                txtOutHTV.Text = outHTV.ToString();
                            });
                        }
                    }
                    else if (lnsize[i] < HTVSIZE && lnsize[i] > isSumCAR)
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

            if (outHTV % 5 == 0 && outHTV > 0)
            {
                if (!alert_sent)
                {
                    //MessageBox.Show("sent");
                    CrossThreadOperation.Invoke(textBox_alarm, () =>
                    {
                        textBox_alarm.Text = "HTV Alarm Generated";
                    });
                    analysis_event_handler.SendMessage(VideoAnalyticsEvents.EventType.HTV_ALARM, "5 HTVs Gone Towards Tunnel");
                    alert_sent = true;
                }
            }
            else
            {
                CrossThreadOperation.Invoke(textBox_alarm, () =>
                {
                    textBox_alarm.Text = "";
                });
                alert_sent = false;
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

            if (capVid.GetCaptureProperty((CAP_PROP)1) >= 1100)
            {
                //capVid.SetCaptureProperty((CAP_PROP)1, 0);
                frameCount = 200;
            }
        }
    }
}
