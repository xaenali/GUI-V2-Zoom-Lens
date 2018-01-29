using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using MathNet.Numerics;
using MathNet.Numerics.Data.Text;
using MathNet.Numerics.LinearAlgebra;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Basicapp_start
{
    public partial class RayTrace : Form
    {
        double MarginalRayHeight, InputRayAngle, n1 = 1;  // InputRayAngle is used for the form in Raytrace

        public static double a1, b1, c1, d1, ee1, ff1, gg1 , h1, i1, j1, k1, l1, m1, f1;

        public static List<double> R1 = new List<double>(); // Initialize array for focal length 1------ used with excel
        public static List<double> R2 = new List<double>(); // Initialize array for focal length 2------ used with excel
        public static List<double> R3 = new List<double>(); // Initialize array for focal length 3------ used with excel
        public static List<double> R4 = new List<double>(); // Initialize List for Entrance pupil Dia 1 ------ used with excel
        public static List<double> R5 = new List<double>(); // Initialize List for Entrance pupil Dia  2------ used with excel
        public static List<double> R6 = new List<double>(); // Initialize List for fEntrance pupil Dia  3------ used with excel
        public static List<double> n2 = new List<double>(); // Initialize vender for focallength 1------ used with excel
        public static List<double> n3 = new List<double>(); // Initialize vendor for focallength 2------ used with excel
        public static List<double> n4 = new List<double>(); // Initialize vendor for focallength 3------ used with excel
        public static List<double> T1 = new List<double>(); // Initialize Lens part number for focallength 1------ used with excel
        public static List<double> T2 = new List<double>(); // Initialize Lens part number for focallength 2------ used with excel
        public static List<double> T3 = new List<double>(); // Initialize Lens part number for focallength 3------ used with excel


        public RayTrace()
        {
            InitializeComponent();
            getRRTExcelFile();
        }

        public static void getRRTExcelFile()
        {

            double R1rngCount;
            double R2rngCount;
            double R3rngCount;
            double R4rngCount;
            double R5rngCount;
            double R6rngCount;
            double n2rngCount;
            double n3rngCount;
            double n4rngCount;
            double T1rngCount;
            double T2rngCount;
            double T3rngCount;



            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();

            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\Ali\Source\Repos\GUI-V2-Zoom-Lens\Basicapp start\Basicapp start\RayTrace.xlsx");

            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];

            Excel.Range xlRange = xlWorksheet.UsedRange;

            // get used range of Focal length, Entrance pupil Dia and Lens Part number columns

            Excel.Range R1range = xlWorksheet.UsedRange.Columns["M", Type.Missing];

            Excel.Range R2range = xlWorksheet.UsedRange.Columns["N", Type.Missing];

            Excel.Range R3range = xlWorksheet.UsedRange.Columns["AC", Type.Missing];

            Excel.Range R4range = xlWorksheet.UsedRange.Columns["AD", Type.Missing];

            Excel.Range R5range = xlWorksheet.UsedRange.Columns["AS", Type.Missing];

            Excel.Range R6range = xlWorksheet.UsedRange.Columns["AT", Type.Missing];

            Excel.Range n2range = xlWorksheet.UsedRange.Columns["O", Type.Missing];

            Excel.Range n3range = xlWorksheet.UsedRange.Columns["AE", Type.Missing];

            Excel.Range n4range = xlWorksheet.UsedRange.Columns["AU", Type.Missing];

            Excel.Range T1range = xlWorksheet.UsedRange.Columns["I", Type.Missing];

            Excel.Range T2range = xlWorksheet.UsedRange.Columns["Y", Type.Missing];

            Excel.Range T3range = xlWorksheet.UsedRange.Columns["AO", Type.Missing];




            // get number of used rows in column A, B and C

            R1rngCount = R1range.Rows.Count;

            R2rngCount = R2range.Rows.Count;

            R3rngCount = R3range.Rows.Count;

            R4rngCount = R4range.Rows.Count;

            R5rngCount = R5range.Rows.Count;

            R6rngCount = R6range.Rows.Count;

            n2rngCount = n2range.Rows.Count;

            n3rngCount = n3range.Rows.Count;

            n4rngCount = n4range.Rows.Count;

            T1rngCount = T1range.Rows.Count;

            T2rngCount = T2range.Rows.Count;

            T3rngCount = T3range.Rows.Count;




            // iterate over column D, Q and AD's used row count and store values to the list for Focal lengths

            for (int i = 3; i <= R1rngCount; i++)
            {
                R1.Add(xlWorksheet.Cells[i, "M"].Value());
            }

            for (int j = 3; j <= R2rngCount; j++)
            {
                R2.Add(xlWorksheet.Cells[j, "N"].Value());
            }

            for (int k = 3; k <= R3rngCount; k++)
            {
                R3.Add(xlWorksheet.Cells[k, "AC"].Value());
            }

            // iterate over column E, R and AE's used row count and store values to the list for Entracne puplil Dia


            for (int i = 3; i <= R4rngCount; i++)
            {
                R4.Add(xlWorksheet.Cells[i, "AD"].Value());
            }

            for (int j = 3; j <= R5rngCount; j++)
            {
                R5.Add(xlWorksheet.Cells[j, "AS"].Value());
            }

            for (int k = 3; k <= R6rngCount; k++)
            {
                R6.Add(xlWorksheet.Cells[k, "AT"].Value());
            }

            //// iterate over column C, P and AC's used row count and store values to the list for lens part number

            for (int i = 3; i <= n2rngCount; i++)
            {
                n2.Add(xlWorksheet.Cells[i, "O"].Value());
            }

            for (int j = 3; j <= n3rngCount; j++)
            {
                n3.Add(xlWorksheet.Cells[j, "AE"].Value());
            }

            for (int k = 3; k <= n4rngCount; k++)
            {
                n4.Add(xlWorksheet.Cells[k, "AU"].Value());
            }

            //// iterate over column B, O and AB's used row count and store values to the list for vendor

            for (int i = 3; i <= T1rngCount; i++)
            {
                T1.Add(xlWorksheet.Cells[i, "I"].Value());
            }

            for (int j = 3; j <= T2rngCount; j++)
            {
                T2.Add(xlWorksheet.Cells[j, "Y"].Value());
            }

            for (int k = 3; k <= T3rngCount; k++)
            {
                T3.Add(xlWorksheet.Cells[k, "AO"].Value());
            }


            //cleanup

            GC.Collect();

            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background

            Marshal.ReleaseComObject(xlRange);

            Marshal.ReleaseComObject(xlWorksheet);

            //close and release

            xlWorkbook.Close();

            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release

            xlApp.Quit();

            Marshal.ReleaseComObject(xlApp);


        }


        public void RayTrace_Load(object sender, EventArgs e)
        {
            MarginalRayHeight = BeamExpanderControl.InputbeamDia / 2;

            InputRayAngle = BeamExpanderControl.InputAngle;

            InputHeighttextBox.Text = MarginalRayHeight.ToString();

            InputAngletextBox.Text = InputRayAngle.ToString();

            Matrix<double> InputMatrix = Matrix<double>.Build.DenseOfArray(new[,] { {2.5}, { 0 } });

            Matrix<double> TransferMatrix = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, 10.0 }, { 0, 1.0 } });

            Matrix<double> TransferMatrixd1 = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, 14.780 }, { 0, 1.0 } });

            Matrix<double> TransferMatrixd2 = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, 32.398}, { 0, 1.0 } });

            Matrix<double> Surface1RefractionMatrix = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, 0 }, { (n1 - n2[0]) / (R1[0] * n2[0]), n1 / n2[0] } });

            Matrix<double> Surface2RefractionMatrix = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, 0 }, { (n2[0] - n1) / (R2[0] * n1), n2[0] / n1 } });

            Matrix<double> Surface3RefractionMatrix = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, 0 }, { (n1 - n3[0]) / (R3[0] * n3[0]), n1 / n3[0] } });

            Matrix<double> Surface4RefractionMatrix = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, 0 }, { (n3[0] - n1) / (R4[0] * n1), n3[0] / n1 } });

            Matrix<double> Surface5RefractionMatrix = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, 0 }, { (n1 - n4[0]) / (R5[0] * n4[0]), n1 / n4[0] } });

            Matrix<double> Surface6RefractionMatrix = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, 0 }, { (n4[0] - n1) / (R6[0] * n1), n4[0] / n1 } });

            Matrix<double> lensThicknessMatrix1 = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, T1[0] }, { 0, 1.0 } });

            Matrix<double> lensThicknessMatrix2 = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, T2[0] }, { 0, 1.0 } });

            Matrix<double> lensThicknessMatrix3 = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, T3[0] }, { 0, 1.0 } });


            var a = TransferMatrix.Multiply(InputMatrix);

            a1 = a.At(0, 0);

            TTextBox1.Text = a.ToString();

            var b = Surface1RefractionMatrix.Multiply(a);

            b1 = b.At(0, 0);

            RTextBox1.AppendText(b.ToString());

            var c = lensThicknessMatrix1.Multiply(b);

            c1 = c.At(0, 0);

            TTextBox2.AppendText(c.ToString());

            var d = Surface2RefractionMatrix.Multiply(c);

            d1 = d.At(0, 0);

            RTextBox2.AppendText(d.ToString());

            var ee = TransferMatrixd1.Multiply(d);

            ee1 = ee.At(0, 0);

            TTextBox3.AppendText(ee.ToString());

            var ff = Surface3RefractionMatrix.Multiply(ee);

            ff1 = ff.At(0, 0);

            RTextBox3.AppendText(ff.ToString());

            var gg = lensThicknessMatrix2.Multiply(ff);

            gg1 = gg.At(0, 0);

            TTextBox4.AppendText(gg.ToString());

            var h = Surface4RefractionMatrix.Multiply(gg);

            h1 = h.At(0, 0);

            RTextBox4.AppendText(h.ToString());

            var i = TransferMatrixd2.Multiply(h);

            i1 = i.At(0, 0);

            TTextBox5.AppendText(i.ToString());

            var j = Surface5RefractionMatrix.Multiply(i);

            j1 = j.At(0, 0);

            RTextBox5.AppendText(j.ToString());

            var k = lensThicknessMatrix3.Multiply(j);

            k1 = k.At(0, 0);
            
            TTextBox6.AppendText(k.ToString());

            var l = Surface6RefractionMatrix.Multiply(k);

            l1 = l.At(0, 0);

            RTextBox6.AppendText(l.ToString());

            var m = TransferMatrix.Multiply(l);

            m1 = m.At(0, 0);
            
            TTextBox7.AppendText(m.ToString());

            richTextBox1.AppendText(m.At(0, 0).ToString());


            richTextBox1.AppendText(InputMatrix.ToString());
            richTextBox1.AppendText(TransferMatrix.ToString());
            richTextBox1.AppendText(Surface1RefractionMatrix.ToString());
            richTextBox1.AppendText(lensThicknessMatrix1.ToString());
            richTextBox1.AppendText(Surface2RefractionMatrix.ToString());
            richTextBox1.AppendText(TransferMatrixd1.ToString());
            richTextBox1.AppendText(Surface3RefractionMatrix.ToString());
            richTextBox1.AppendText(lensThicknessMatrix2.ToString());
            richTextBox1.AppendText(Surface4RefractionMatrix.ToString());
            richTextBox1.AppendText(TransferMatrixd2.ToString());
            richTextBox1.AppendText(Surface5RefractionMatrix.ToString());
            richTextBox1.AppendText(lensThicknessMatrix3.ToString());
            richTextBox1.AppendText(Surface6RefractionMatrix.ToString());
            richTextBox1.AppendText(TransferMatrix.ToString());

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        
        _2D_Cross_Section Crossection2D;

        private void CrossSection_Click(object sender, EventArgs e)
        {
            //BeamExpanderControl.Maxtrackischecked = MaxtrackRadioButton.Checked;

            //BeamExpanderControl.Mintrackischecked = MinimumTrackButton.Checked;


            if (Crossection2D == null)
            {
                Crossection2D = new _2D_Cross_Section();



                Crossection2D.Show();


                Crossection2D.FormClosed += Crossection2D_FormClosed;



            }

            else
                Crossection2D.Activate();

        }

        void Crossection2D_FormClosed(object sender, FormClosedEventArgs e)
        {
            Crossection2D = null;
            //throw new NotImplementedException();
        }

      
    }
}
