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
    public partial class ParaxialRayTrace : Form
    {
        double MarginalRayHeight, InputRayAngle;

        public static List<double> PRTfocallength1 = new List<double>(); // Initialize array for focal length 1------ used with excel
        public static List<double> PRTfocallength2 = new List<double>(); // Initialize array for focal length 2------ used with excel
        public static List<double> PRTfocallength3 = new List<double>(); // Initialize array for focal length 3------ used with excel
        //public static List<double> EPD1 = new List<double>(); // Initialize List for Entrance pupil Dia 1 ------ used with excel
        //public static List<double> EPD2 = new List<double>(); // Initialize List for Entrance pupil Dia  2------ used with excel
        //public static List<double> EPD3 = new List<double>(); // Initialize List for fEntrance pupil Dia  3------ used with excel
        //public static List<string> VL1 = new List<string>(); // Initialize vender for focallength 1------ used with excel
        //public static List<string> VL2 = new List<string>(); // Initialize vendor for focallength 2------ used with excel
        //public static List<string> VL3 = new List<string>(); // Initialize vendor for focallength 3------ used with excel
        //public static List<string> LensPartList1 = new List<string>(); // Initialize Lens part number for focallength 1------ used with excel
        //public static List<string> LensPartList2 = new List<string>(); // Initialize Lens part number for focallength 2------ used with excel
        //public static List<string> LensPartList3 = new List<string>(); // Initialize Lens part number for focallength 3------ used with excel



        public ParaxialRayTrace()
        {
            InitializeComponent();
            getPRTExcelFile();
        }


        public static void getPRTExcelFile()
        {

            double PRTF1rngCount;
            double PRTF2rngCount;
            double PRTF3rngCount;
            //double PRTEPD1rngCount;
            //double PRTEPD2rngCount;
            //double PRTEPD3rngCount;
            //double PRTLP1rngCount;
            //double PRTLP2rngCount;
            //double PRTLP3rngCount;
            //double PRTVL1rngCount;
            //double PRTVL2rngCount;
            //double PRTVL3rngCount;



            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();

            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\Ali\Source\Repos\GUI-V2-Zoom-Lens\Basicapp start\Basicapp start\RayTrace.xlsx");

            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];

            Excel.Range xlRange = xlWorksheet.UsedRange;

            // get used range of Focal length, Entrance pupil Dia and Lens Part number columns

            Excel.Range F1range = xlWorksheet.UsedRange.Columns["D", Type.Missing];

            Excel.Range F2range = xlWorksheet.UsedRange.Columns["T", Type.Missing];

            Excel.Range F3range = xlWorksheet.UsedRange.Columns["AJ", Type.Missing];

            //Excel.Range EPD1range = xlWorksheet.UsedRange.Columns["E", Type.Missing];

            //Excel.Range EPD2range = xlWorksheet.UsedRange.Columns["R", Type.Missing];

            //Excel.Range EPD3range = xlWorksheet.UsedRange.Columns["AE", Type.Missing];

            //Excel.Range LP1range = xlWorksheet.UsedRange.Columns["C", Type.Missing];

            //Excel.Range LP2range = xlWorksheet.UsedRange.Columns["P", Type.Missing];

            //Excel.Range LP3range = xlWorksheet.UsedRange.Columns["AC", Type.Missing];

            //Excel.Range VL1range = xlWorksheet.UsedRange.Columns["B", Type.Missing];

            //Excel.Range VL2range = xlWorksheet.UsedRange.Columns["O", Type.Missing];

            //Excel.Range VL3range = xlWorksheet.UsedRange.Columns["AB", Type.Missing];




            // get number of used rows in column A, B and C

            PRTF1rngCount = F1range.Rows.Count;

            PRTF2rngCount = F2range.Rows.Count;

            PRTF3rngCount = F3range.Rows.Count;

            //PRTEPD1rngCount = EPD1range.Rows.Count;

            //PRTEPD2rngCount = EPD2range.Rows.Count;

            //PRTEPD3rngCount = EPD3range.Rows.Count;

            //PRTLP1rngCount = LP1range.Rows.Count;

            //PRTLP2rngCount = LP2range.Rows.Count;

            //PRTLP3rngCount = LP3range.Rows.Count;

            //PRTVL1rngCount = VL1range.Rows.Count;

            //PRTVL2rngCount = VL2range.Rows.Count;

            //PRTVL3rngCount = VL3range.Rows.Count;




            // iterate over column D, Q and AD's used row count and store values to the list for Focal lengths

            for (int i = 3; i <= PRTF1rngCount; i++)
            {
                PRTfocallength1.Add(xlWorksheet.Cells[i, "D"].Value());
            }

            for (int j = 3; j <= PRTF2rngCount; j++)
            {
                PRTfocallength2.Add(xlWorksheet.Cells[j, "T"].Value());
            }

            for (int k = 3; k <= PRTF3rngCount; k++)
            {
                PRTfocallength3.Add(xlWorksheet.Cells[k, "AJ"].Value());
            }

            // iterate over column E, R and AE's used row count and store values to the list for Entracne puplil Dia


            //for (int i = 3; i <= PRTEPD1rngCount; i++)
            //{
            //    EPD1.Add(xlWorksheet.Cells[i, "E"].Value());
            //}

            //for (int j = 3; j <= PRTEPD2rngCount; j++)
            //{
            //    EPD2.Add(xlWorksheet.Cells[j, "R"].Value());
            //}

            //for (int k = 3; k <= PRTEPD3rngCount; k++)
            //{
            //    EPD3.Add(xlWorksheet.Cells[k, "AE"].Value());
            //}

            //// iterate over column C, P and AC's used row count and store values to the list for lens part number

            //for (int i = 3; i <= PRTLP1rngCount; i++)
            //{
            //    LensPartList1.Add(xlWorksheet.Cells[i, "C"].Value());
            //}

            //for (int j = 3; j <= PRTLP2rngCount; j++)
            //{
            //    LensPartList2.Add(xlWorksheet.Cells[j, "P"].Value());
            //}

            //for (int k = 3; k <= PRTLP3rngCount; k++)
            //{
            //    LensPartList3.Add(xlWorksheet.Cells[k, "AC"].Value());
            //}

            //// iterate over column B, O and AB's used row count and store values to the list for vendor

            //for (int i = 3; i <= PRTVL1rngCount; i++)
            //{
            //    VL1.Add(xlWorksheet.Cells[i, "B"].Value());
            //}

            //for (int j = 3; j <= PRTVL2rngCount; j++)
            //{
            //    VL2.Add(xlWorksheet.Cells[j, "O"].Value());
            //}

            //for (int k = 3; k <= PRTVL3rngCount; k++)
            //{
            //    VL3.Add(xlWorksheet.Cells[k, "AB"].Value());
            //}


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


        private void ParaxialRayTrace_Load(object sender, EventArgs e)
        {
            MarginalRayHeight = BeamExpanderControl.InputbeamDia / 2;

            InputRayAngle = BeamExpanderControl.InputAngle;

            ParaxialInputHeighttextBox.Text = MarginalRayHeight.ToString();

            ParaxialInputAngletextBox.Text = InputRayAngle.ToString();

            Matrix<double> InputMatrix = Matrix<double>.Build.DenseOfArray(new[,] { { 2.5 }, { 0 } });

            Matrix<double> TransferMatrix = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, 10.0 }, { 0, 1.0 } });

            Matrix<double> TransferMatrixd1 = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, 14.78 }, { 0, 1.0 } });

            Matrix<double> TransferMatrixd2 = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, 32.398 }, { 0, 1.0 } });

            Matrix<double> Surface1RefractionMatrix = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, .0 }, { - 1 / PRTfocallength1[0], 1 } });

            Matrix<double> Surface2RefractionMatrix = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, .0 }, { -1 / PRTfocallength2[0], 1 } });

            Matrix<double> Surface3RefractionMatrix = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, .0 }, { -1 / PRTfocallength3[0], 1 } });

            //Matrix<double> Surface4RefractionMatrix = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, .0 }, { n1 - n2 / R1 * n2, n1 / n2 } });

            //Matrix<double> Surface5RefractionMatrix = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, .0 }, { n1 - n2 / R1 * n2, n1 / n2 } });

            //Matrix<double> Surface6RefractionMatrix = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, .0 }, { n1 - n2 / R1 * n2, n1 / n2 } });

            Matrix<double> lensThicknessMatrix = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, 0.0 }, { 0, 1.0 } });

            var v = TransferMatrix.Multiply(Surface3RefractionMatrix.Multiply(TransferMatrixd2.Multiply(Surface2RefractionMatrix.Multiply(TransferMatrixd1.Multiply(Surface1RefractionMatrix.Multiply(TransferMatrix)))))).Multiply(InputMatrix);

            
            richTextBox1.AppendText(v.ToString());

            richTextBox1.AppendText(TransferMatrix.ToString());
            richTextBox1.AppendText(Surface1RefractionMatrix.ToString());
            richTextBox1.AppendText(TransferMatrixd1.ToString());
            richTextBox1.AppendText(Surface2RefractionMatrix.ToString());
            richTextBox1.AppendText(TransferMatrixd2.ToString());
            richTextBox1.AppendText(Surface3RefractionMatrix.ToString());
            richTextBox1.AppendText(TransferMatrix.ToString());
            richTextBox1.AppendText(InputMatrix.ToString());


        }
    }
}
