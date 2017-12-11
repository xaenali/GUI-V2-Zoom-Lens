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

                BeamExpanderControl.MaxF1 = BeamExpanderControl.F1List[BeamExpanderControl.MaxtrackList.IndexOf(BeamExpanderControl.MaxtrackList.Max())];

                BeamExpanderControl.MaxF2 = BeamExpanderControl.F2List[BeamExpanderControl.MaxtrackList.IndexOf(BeamExpanderControl.MaxtrackList.Max())];

                BeamExpanderControl.MaxF3 = BeamExpanderControl.F3List[BeamExpanderControl.MaxtrackList.IndexOf(BeamExpanderControl.MaxtrackList.Max())];


                for (double i = BeamExpanderControl.InputMin; i < BeamExpanderControl.InputMax; i += 0.1)
                {
                    BeamExpanderControl.InputMin = BeamExpanderControl.InputMin + 0.1;


                    //Calculate d1 and d2 for the Input Magnification

                    BeamExpanderControl.Maxd1 = Math.Round((double)BeamExpanderControl.MaxF1 + BeamExpanderControl.MaxF2 + ((BeamExpanderControl.MaxF1 * BeamExpanderControl.MaxF2) / (BeamExpanderControl.InputMin * BeamExpanderControl.MaxF3)), 4);

                    BeamExpanderControl.Maxd2 = Math.Round((double)BeamExpanderControl.MaxF2 + BeamExpanderControl.MaxF3 + ((BeamExpanderControl.MaxF2 * BeamExpanderControl.MaxF3 * BeamExpanderControl.InputMin) / (BeamExpanderControl.MaxF1)), 4);

                    if ((BeamExpanderControl.Maxd1 >= -0.012) && (BeamExpanderControl.Maxd1 < 0))
                    {
                        BeamExpanderControl.Maxd1 = 0;
                    }
                    else

                        if ((BeamExpanderControl.Maxd2 >= -0.012) && (BeamExpanderControl.Maxd2 < 0))
                    {
                        BeamExpanderControl.Maxd2 = 0;
                    }

                    DistanceChart1.Series["D0"].Points.AddXY(0, BeamExpanderControl.InputMin);

                    DistanceChart1.Series["D1"].Points.AddXY(BeamExpanderControl.Maxd1, BeamExpanderControl.InputMin);

                    DistanceChart1.Series["D2"].Points.AddXY(BeamExpanderControl.Maxd1 + BeamExpanderControl.Maxd2, BeamExpanderControl.InputMin);

                }

            }

            else
                    if (BeamExpanderControl.Mintrackischecked == true)
            {
                BeamExpanderControl.MinF1 = BeamExpanderControl.F1List[BeamExpanderControl.MaxtrackList.IndexOf(BeamExpanderControl.MaxtrackList.Min())];

                BeamExpanderControl.MinF2 = BeamExpanderControl.F2List[BeamExpanderControl.MaxtrackList.IndexOf(BeamExpanderControl.MaxtrackList.Min())];

                BeamExpanderControl.MinF3 = BeamExpanderControl.F3List[BeamExpanderControl.MaxtrackList.IndexOf(BeamExpanderControl.MaxtrackList.Min())];

                for (double i = BeamExpanderControl.InputMin; i < BeamExpanderControl.InputMax; i += 0.1)
                {
                    BeamExpanderControl.InputMin = BeamExpanderControl.InputMin + 0.1;

                    //Calculate d1 and d2 for the Input Magnification

                    BeamExpanderControl.Mind1 = Math.Round((double)BeamExpanderControl.MinF1 + BeamExpanderControl.MinF2 + ((BeamExpanderControl.MinF1 * BeamExpanderControl.MinF2) / (BeamExpanderControl.InputMin * BeamExpanderControl.MinF3)), 4);

                    BeamExpanderControl.Mind2 = Math.Round((double)BeamExpanderControl.MinF2 + BeamExpanderControl.MinF3 + ((BeamExpanderControl.MinF2 * BeamExpanderControl.MinF3 * BeamExpanderControl.InputMin) / (BeamExpanderControl.MinF1)), 4);

                    if ((BeamExpanderControl.Mind1 >= -0.012) && (BeamExpanderControl.Mind1 < 0))
                    {
                        BeamExpanderControl.Mind1 = 0;
                    }
                    else

                        if ((BeamExpanderControl.Mind2 >= -0.012) && (BeamExpanderControl.Mind2 < 0))
                    {
                        BeamExpanderControl.Mind2 = 0;
                    }

                    DistanceChart1.Series["D0"].Points.AddXY(0, BeamExpanderControl.InputMin);

                    DistanceChart1.Series["D1"].Points.AddXY(BeamExpanderControl.Mind1, BeamExpanderControl.InputMin);

                    DistanceChart1.Series["D2"].Points.AddXY(BeamExpanderControl.Mind1 + BeamExpanderControl.Mind2, BeamExpanderControl.InputMin);

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
