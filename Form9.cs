using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MANTRA;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;


namespace WindowsFormsApplication4
{
    public partial class Form9 : Form
    {
        public Form9(string a, string b)
        {
            InitializeComponent();
            finl3.Text = a;
            finl4.Text = b;

        }
        MFS100 mfs100 = null;
        int quality = 60;
        int timeout = 10000000;
        string datapath = Application.StartupPath + "\\FingerData";
        byte[] ISOTemplate = null;
        byte[] ANSITemplate = null;
        DeviceInfo deviceInfo = null;
        string key = "";
        int MatchThreshold = 14000;
        public SqlCommand com = new SqlCommand();
        public SqlConnection con = new SqlConnection();
        SqlDataReader rd;
        
        

        private void Form9_Load(object sender, EventArgs e)
        {
            com.Connection = con;
            con.ConnectionString = "Data Source=VASIM\\SQLEXPRESS;Initial Catalog=a;Integrated Security=True";
            con.Open();
            
            Control.CheckForIllegalCrossThreadCalls = false;
            finl1.Text = "";
            mfs100 = new MFS100(key);
            mfs100.OnPreview += OnPreview;
            mfs100.OnMFS100Attached += OnMFS100Attached;
            mfs100.OnMFS100Detached += OnMFS100Detached;
            string datapath = Application.StartupPath + "\\FingerData";
            try
            {
                if (!Directory.Exists(datapath))
                {
                    Directory.CreateDirectory(datapath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }



        void OnPreview(FingerData fingerprintData)
        {
            try
            {
                if (fingerprintData != null)
                {

                    finpb1.Image = fingerprintData.FingerImage;
                    finpb1.Refresh();
                    finl1.Text = "Quality: " + fingerprintData.Quality.ToString();
                    finl1.Refresh();
                   

                }
                
            }
            catch (Exception ex)
            {
            }

        }


        void ShowMessage(string msg, bool iserror)
        {
            MessageBox.Show(msg, "MFS100", MessageBoxButtons.OK,
                (iserror ? MessageBoxIcon.Error : MessageBoxIcon.Information), MessageBoxDefaultButton.Button1);
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FingerData fingerprintData = null;
                ISOTemplate = null;
                ANSITemplate = null;
                
                

                int ret = mfs100.AutoCapture(ref fingerprintData, timeout, false, false);
                if (ret != 0)
                {
                    ShowMessage(mfs100.GetErrorMsg(ret), true);
                }
                else
                {
                    //lblStatus.Text = "Success: Quality: " + fingerprintData.Quality.ToString() + " Nfiq: " + fingerprintData.Nfiq.ToString();
                    File.WriteAllBytes(datapath + "//ISOTemplate.iso", fingerprintData.ISOTemplate);
                    File.WriteAllBytes(datapath + "//ISOImage.iso", fingerprintData.ISOImage);
                    File.WriteAllBytes(datapath + "//AnsiTemplate.ansi", fingerprintData.ANSITemplate);
                    File.WriteAllBytes(datapath + "//RawData.raw", fingerprintData.RawData);
                    fingerprintData.FingerImage.Save(datapath + "//FingerImage.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                    File.WriteAllBytes(datapath + "//WSQImage.wsq", fingerprintData.WSQImage);
                    ISOTemplate = new byte[fingerprintData.ISOTemplate.Length];
                    fingerprintData.ISOTemplate.CopyTo(ISOTemplate, 0);
                    ANSITemplate = new byte[fingerprintData.ANSITemplate.Length];
                    fingerprintData.ANSITemplate.CopyTo(ANSITemplate, 0);
                    string info = "Quality: " + fingerprintData.Quality.ToString() + "     Nfiq: " + fingerprintData.Nfiq.ToString() + "     Bpp: " + fingerprintData.Bpp.ToString() + "     GrayScale:" + fingerprintData.GrayScale.ToString() + "\nW(in):" + fingerprintData.InWidth.ToString() + "     H(in):" + fingerprintData.InHeight.ToString() + "     area(in):" + fingerprintData.InArea.ToString() + "     Dpi/Ppi:" + fingerprintData.Resolution.ToString() + "     Compress Ratio:" + fingerprintData.WSQCompressRatio.ToString() + "     WSQ Info:" + fingerprintData.WSQInfo.ToString();
                    finl1.Text = info;
                    ShowMessage("Capture Success matching process", false);
                     com.CommandText = "select iso from a  where name='" + finl3.Text + "' and password='" + finl4.Text + "'";

                   byte[] c = (byte[])com.ExecuteScalar();

                   try
                   {
                       if (ISOTemplate != null && ISOTemplate.Length > 0)
                       {
                           int score = 0;

                           int re = mfs100.MatchISO(ISOTemplate, c, ref score);

                           if (re == 0)
                           {
                               if (score >= MatchThreshold)
                               {
                                   
                                   MessageBox.Show("Finger matched with score: " + score.ToString());
                                   this.Hide();
                                   Form3 f = new Form3(finl3.Text, finl4.Text);
                                   f.Show();
                                                 
                                 }
                               else
                               {
                                   MessageBox.Show("Finger not matched, score: " + score.ToString() + " is too low");
                                   this.Hide();
                                   Form10 fa = new Form10(finl3.Text, finl4.Text);
                                   fa.Show();
                               }
                           }
                           else
                           {
                               MessageBox.Show(mfs100.GetErrorMsg(ret));
                           }
                       }
                       else
                       {
                           MessageBox.Show("Please capture finger first");
                       }
                   }

                   catch (Exception ex)
                   {
                       MessageBox.Show(ex.ToString());
                   }
            finally
            {
                GC.Collect();
            }
                
                }

                }
            
            catch (Exception ex)
            {
                ShowMessage(ex.ToString(), true);
            }
            finally
            {
                GC.Collect();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ret = mfs100.Init();
                if (ret != 0)
                {
                    MessageBox.Show(mfs100.GetErrorMsg(ret));
                }
                else
                {
                    deviceInfo = mfs100.GetDeviceInfo();
                    if (deviceInfo != null)
                    {
                        string scannerInfo = "SERIAL NO.: " + deviceInfo.SerialNo + "     MAKE: " + deviceInfo.Make + "     MODEL: " + deviceInfo.Model + "\nWIDTH: " + deviceInfo.Width.ToString() + "     HEIGHT: " + deviceInfo.Height.ToString() + "     CERT: " + mfs100.GetCertification();
                        finl1.Text = scannerInfo;
                    }
                    else
                    {
                        finl1.Text = "";
                    }
                    MessageBox.Show(mfs100.GetErrorMsg(ret));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                GC.Collect();
            }

        }
        void OnMFS100Attached()
        {
            MessageBox.Show("MFS100 found, You can initialized now");
        }
        void OnMFS100Detached()
        {
            MessageBox.Show("MFS100 removed");
        }


      
        
           
        

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int ret = mfs100.StopCapture();
                MessageBox.Show(mfs100.GetErrorMsg(ret));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                GC.Collect();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                ISOTemplate = null;
                ANSITemplate = null;

                int ret = mfs100.StartCapture(quality, timeout, true);
                if (ret != 0)
                {
                    ShowMessage(mfs100.GetErrorMsg(ret), true);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.ToString(), true);
            }
            finally
            {
                GC.Collect();
            }
        }
     

     
     


        
    }
}
