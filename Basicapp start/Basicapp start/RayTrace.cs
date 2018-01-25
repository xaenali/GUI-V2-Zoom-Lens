using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;
using MathNet.Numerics.Data.Text;
using MathNet.Numerics.LinearAlgebra;

namespace Basicapp_start
{
    public partial class RayTrace : Form
    {
        double MarginalRayHeight, InputRayAngle;  // InputRayAngle is used for the form in Raytrace

        public RayTrace()
        {
            InitializeComponent();
        }

        private void RayTrace_Load(object sender, EventArgs e)
        {
            MarginalRayHeight = BeamExpanderControl.InputbeamDia / 2;

            InputRayAngle = BeamExpanderControl.InputAngle;

            InputHeighttextBox.Text = MarginalRayHeight.ToString();

            InputAngletextBox.Text = InputRayAngle.ToString();



        }
    }
}
