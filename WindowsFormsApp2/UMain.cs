using System;
using System.Collections.Generic;
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
            //int I = 1;
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            //this.Text = this.Text + allDrives.Length.ToString();
           // foreach (DriveInfo d in allDrives)
            for (int I = 1;I < 7; I++)
            {
                DriveInfo d = allDrives[I];
                Label lbl = this.Controls.Find("lblDrive" + I.ToString(), true).FirstOrDefault() as Label;
                if (lbl != null)
                {
                    if (d.IsReady)
                    {
                        lbl.Visible = true;
                        lbl.Text = d.Name + "(" + d.DriveFormat.ToString() + ")";
                    }
                    else
                    {
                        lbl.Visible = false;
                    }
                }
                ProgressBar pb = this.Controls.Find("pbDrive" + I.ToString(), true).FirstOrDefault() as ProgressBar;
                if (pb != null)
                {
                    if (d.IsReady)
                    {
                        pb.Visible = true;
                        if (d.TotalSize > 1099511627776) // check > 2TB Int32 limitation.
                        {
                            pb.Maximum = Convert.ToInt32(d.TotalSize / 1048576);
                            pb.Value = Convert.ToInt32((d.TotalSize - d.TotalFreeSpace) / 1048576);
                        }
                        else
                        {

                            pb.Maximum = Convert.ToInt32(d.TotalSize / 1024);
                            pb.Value = Convert.ToInt32((d.TotalSize - d.TotalFreeSpace) / 1024);
                        }
                    }
                    else
                    {
                        pb.Visible = false;
                    }
                }
                Label lblInfo = this.Controls.Find("lblDriveInfo" + I.ToString(), true).FirstOrDefault() as Label;
                if (lblInfo != null)
                {
                    if (d.IsReady)
                    {
                        lblInfo.Visible = true;
                        string postfix = "Bytes";
                        double Available = d.TotalFreeSpace;

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

                        string VLabel = d.VolumeLabel;
                        double percentFree = Math.Round(100 * (double)d.TotalFreeSpace / d.TotalSize, 4);

                        if (VLabel == "") // Checks if Drive Label is empty
                        {
                            VLabel = "No Label";
                        }

                        lblInfo.Text = VLabel + " / " + percentFree + "% Free / " + SAvailable + " / " + STotal;
                    }
                    else
                    {
                        lblInfo.Visible = false;
                    }
                }
                       // I++;
            }
        }
    }
}
