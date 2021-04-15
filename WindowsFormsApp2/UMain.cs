using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;



namespace WindowsFormsApp2
{



    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            //int I = 1;
            //foreach (DriveInfo d in allDrives)
            for (int I = 0; I < 6; I++)
            {
                Label lbl = this.Controls.Find("lblDrive" + I.ToString(), true).FirstOrDefault() as Label;
                ProgressBar pb = this.Controls.Find("pbDrive" + I.ToString(), true).FirstOrDefault() as ProgressBar;
                Label lblInfo = this.Controls.Find("lblDriveInfo" + I.ToString(), true).FirstOrDefault() as Label;
                if (I < allDrives.Length)
                {

                    DriveInfo d = allDrives[I];
                    if (lbl != null)
                    {
                        lbl.Visible = true;
                        if (d.IsReady == true)
                        {

                            lbl.Text = d.Name + "(" + d.DriveFormat.ToString() + ")";
                        }
                        else
                        {
                            lbl.Text = d.Name + "(N/A)";
                        }
                    }

                    if (pb != null)
                    {
                        pb.Visible = true;
                        if (d.IsReady == true)
                        {
                            if (d.TotalSize > 1099511627776) // check > 2TB Int32 limitation.
                            {
                                pb.Maximum = Convert.ToInt32(d.TotalSize / 1048576);
                                pb.Value = Convert.ToInt32((d.TotalSize - d.AvailableFreeSpace) / 1048576);
                            }
                            else
                            {

                                pb.Maximum = Convert.ToInt32(d.TotalSize / 1024);
                                pb.Value = Convert.ToInt32((d.TotalSize - d.AvailableFreeSpace) / 1024);
                            }
                        }
                        else
                        {
                            pb.Maximum = 1;
                            pb.Value = 0;
                        }
                    }
                    if (lblInfo != null)
                    {
                        lblInfo.Visible = true;
                        if (d.IsReady == true)
                        {
                            string postfix = "Bytes";
                            double Available = d.AvailableFreeSpace;

                            if (Available >= 1099511627776)//more than 1 TB
                            {
                                Available = Available / 1099511627776;
                                postfix = "TB";
                            }
                            if (Available >= 1073741824)//more than 1 GB
                            {
                                Available = Available / 1073741824;
                                postfix = "GB";
                            }
                            else if (Available >= 1048576)//more that 1 MB
                            {
                                Available = Available / 1048576;
                                postfix = "MB";
                            }
                            else if (Available >= 1024)//more that 1 KB
                            {
                                Available = Available / 1024;
                                postfix = "KB";
                            }
                            string SAvailable = Math.Round(Available, 2).ToString() + " " + postfix;

                            double Total = d.TotalSize;
                            ;

                            if (Total >= 1099511627776)//more than 1 TB
                            {
                                Total = Total / 1099511627776;
                                postfix = "TB";
                            }
                            if (Total >= 1073741824)//more than 1 GB
                            {
                                Total = Total / 1073741824;
                                postfix = "GB";
                            }
                            else if (Total >= 1048576)//more that 1 MB
                            {
                                Total = Total / 1048576;
                                postfix = "MB";
                            }
                            else if (Total >= 1024)//more that 1 KB
                            {
                                Total = Total / 1024;
                                postfix = "KB";
                            }
                            string STotal = Math.Round(Total, 2).ToString() + " " + postfix;
                            string DType = d.DriveType.ToString();
                            string VLabel = d.VolumeLabel;
                            double percentFree = Math.Round(100 * (double)d.AvailableFreeSpace / d.TotalSize, 4);

                            if (VLabel == "") // Checks if Drive Label is empty
                            {
                                VLabel = "No Label";
                            }

                            lblInfo.Text = VLabel + " / " + percentFree.ToString("0.0000") + "% Free / " + SAvailable + " / " + STotal + " / " + DType;
                        }
                        else
                        {
                            lblInfo.Text = "No Medium inserted";
                        }

                    }
                }
                else
                {
                    lbl.Visible = false;
                    pb.Visible = false;
                    lblInfo.Visible = false;
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }
    }
}
    