using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using ZOSAPI;
using OSAPI_NetHelper = ZOSAPI_NetHelper;
using ZOSAPI.Tools.General;
using ZOSAPI.Editors.MFE;
using ZOSAPI.Editors.MCE;
using ZOSAPI.Editors;
using ZOSAPI.Editors.LDE;
using ZOSAPI.SystemData;
using ZOSAPI.Tools.Optimization;


namespace Basicapp_start
{
    public partial class ZoomAppForm : Form
    {
        public ZoomAppForm()
        {
            InitializeComponent();

            panel2.Height = Homebutton.Height;

            homeUserControl1.BringToFront();

        }

        private void Homebutton_Click(object sender, EventArgs e)
        {
            panel2.Height = Homebutton.Height;

            panel2.Top = Homebutton.Top;

            homeUserControl1.BringToFront();

            
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void graphsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void BeamExbutton_Click(object sender, EventArgs e)
        {
            panel2.Height = BeamExbutton.Height;

            panel2.Top = BeamExbutton.Top;

            beamExpanderControl1.BringToFront();
        }

        private void LaserFocusbutton_Click(object sender, EventArgs e)
        {
            panel2.Height = LaserFocusbutton.Height;

            panel2.Top = LaserFocusbutton.Top;

            laserFocussingControl1.BringToFront();
        }

        private void CameraLensbutton_Click(object sender, EventArgs e)
        {
            panel2.Height = CameraLensbutton.Height;

            panel2.Top = CameraLensbutton.Top;
        }

        private void laserFocussingControl1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
