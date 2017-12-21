using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.Design;

namespace Basicapp_start
{
    public partial class ZoomCurvesForm : Form
    {

        public ZoomCurvesForm()
        {
            InitializeComponent();

        }

        private void ZoomCurves_Load(object sender, EventArgs e)
        {

            if (BeamExpanderControl.Maxtrackischecked == true)
            {

                BeamExpanderControl.MaxF1 = BeamExpanderControl.CopyF1List[BeamExpanderControl.CopyMaxtrackList.IndexOf(BeamExpanderControl.CopyMaxtrackList.Max())];

                BeamExpanderControl.MaxF2 = BeamExpanderControl.CopyF2List[BeamExpanderControl.CopyMaxtrackList.IndexOf(BeamExpanderControl.CopyMaxtrackList.Max())];

                BeamExpanderControl.MaxF3 = BeamExpanderControl.CopyF3List[BeamExpanderControl.CopyMaxtrackList.IndexOf(BeamExpanderControl.CopyMaxtrackList.Max())];


                for (double i = BeamExpanderControl.CopyInputMin; i < BeamExpanderControl.InputMax; i += 0.1)
                {

                    //Calculate d1 and d2 for the Input Magnification

                    BeamExpanderControl.Maxd1 = Math.Round((double)BeamExpanderControl.MaxF1 + BeamExpanderControl.MaxF2 + ((BeamExpanderControl.MaxF1 * BeamExpanderControl.MaxF2) / (BeamExpanderControl.CopyInputMin * BeamExpanderControl.MaxF3)), 4);

                    BeamExpanderControl.Maxd2 = Math.Round((double)BeamExpanderControl.MaxF2 + BeamExpanderControl.MaxF3 + ((BeamExpanderControl.MaxF2 * BeamExpanderControl.MaxF3 * BeamExpanderControl.CopyInputMin) / (BeamExpanderControl.MaxF1)), 4);

                    BeamExpanderControl.CopyInputMin = BeamExpanderControl.CopyInputMin + 0.1;


                    if ((BeamExpanderControl.Maxd1 >= -0.012) && (BeamExpanderControl.Maxd1 < 0))
                    {
                        BeamExpanderControl.Maxd1 = 0;
                    }
                    else

                        if ((BeamExpanderControl.Maxd2 >= -0.012) && (BeamExpanderControl.Maxd2 < 0))
                    {
                        BeamExpanderControl.Maxd2 = 0;
                    }

                    DistanceChart1.Series["D0"].Points.AddXY(0, BeamExpanderControl.CopyInputMin);

                    DistanceChart1.Series["D1"].Points.AddXY(BeamExpanderControl.Maxd1, BeamExpanderControl.CopyInputMin);

                    DistanceChart1.Series["D2"].Points.AddXY(BeamExpanderControl.Maxd1 + BeamExpanderControl.Maxd2, BeamExpanderControl.CopyInputMin);

                }

            }

            else
                    if (BeamExpanderControl.Mintrackischecked == true)
            {
                BeamExpanderControl.MinF1 = BeamExpanderControl.CopyF1List[BeamExpanderControl.CopyMaxtrackList.IndexOf(BeamExpanderControl.CopyMaxtrackList.Min())];

                BeamExpanderControl.MinF2 = BeamExpanderControl.CopyF2List[BeamExpanderControl.CopyMaxtrackList.IndexOf(BeamExpanderControl.CopyMaxtrackList.Min())];

                BeamExpanderControl.MinF3 = BeamExpanderControl.CopyF3List[BeamExpanderControl.CopyMaxtrackList.IndexOf(BeamExpanderControl.CopyMaxtrackList.Min())];

                for (double i = BeamExpanderControl.CopyInputMin; i < BeamExpanderControl.InputMax; i += 0.1)
                {

                    //Calculate d1 and d2 for the Input Magnification

                    BeamExpanderControl.Mind1 = Math.Round((double)BeamExpanderControl.MinF1 + BeamExpanderControl.MinF2 + ((BeamExpanderControl.MinF1 * BeamExpanderControl.MinF2) / (BeamExpanderControl.CopyInputMin * BeamExpanderControl.MinF3)), 4);

                    BeamExpanderControl.Mind2 = Math.Round((double)BeamExpanderControl.MinF2 + BeamExpanderControl.MinF3 + ((BeamExpanderControl.MinF2 * BeamExpanderControl.MinF3 * BeamExpanderControl.CopyInputMin) / (BeamExpanderControl.MinF1)), 4);

                    BeamExpanderControl.CopyInputMin = BeamExpanderControl.CopyInputMin + 0.1;

                    
                    if ((BeamExpanderControl.Mind1 >= -0.012) && (BeamExpanderControl.Mind1 < 0))
                    {
                        BeamExpanderControl.Mind1 = 0;
                    }
                    else

                        if ((BeamExpanderControl.Mind2 >= -0.012) && (BeamExpanderControl.Mind2 < 0))
                    {
                        BeamExpanderControl.Mind2 = 0;
                    }

                    DistanceChart1.Series["D0"].Points.AddXY(0, BeamExpanderControl.CopyInputMin);

                    DistanceChart1.Series["D1"].Points.AddXY(BeamExpanderControl.Mind1, BeamExpanderControl.CopyInputMin);

                    DistanceChart1.Series["D2"].Points.AddXY(BeamExpanderControl.Mind1 + BeamExpanderControl.Mind2, BeamExpanderControl.CopyInputMin);

                }

            }

        }

        private void DistanceChart1_Click(object sender, EventArgs e)
        {

        }

        private void DistanceChart1_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            DistanceChart1.Series["D1"].ToolTip = "Mag: #VALY, D1: #VALX";

            DistanceChart1.Series["D2"].ToolTip = "Mag: #VALY, D2: #VALX";

        }

        private void DistanceChart1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void DistanceChart1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
