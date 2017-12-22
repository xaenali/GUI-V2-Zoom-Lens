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
    public partial class BeamExpanderControl : UserControl
    {
        public static double Distance1Add, CopyInputMin, TM, Input, InputMax, InputMin, InputbeamDia, EPDConstrainF1, EPDConstrainF3, Mind1, Mind2, MinF1, MinF2, MinF3, Maxd1, Maxd2, MaxF1, MaxF2, MaxF3, Maxa1, Maxa2, Maxb1, Maxb2, MaxMx, MaxMy, MaxMxratioMy, Mina1, Mina2, Minb1, Minb2, MinMx, MinMy, MinMxratioMy, md1,d2;
        public static string VendorL1, VendorL2, VendorL3, LP1, LP2, LP3; // Vendors and Lenspart variable to be used in MinTrack, Maxtrack and in Standalone application as sorted out for Maxtrack or Min track length
        public static List<double> Temp1 = new List<double>(); // List for Distance 1 that will be used to add thickness in Zemax LDE
        public static List<double> Temp2 = new List<double>(); // List for Distance 2 that will be used to add thickness in Zemax LDE
        public static List<string> LPTemp1 = new List<string>(); // List for lens part 1
        public static List<string> LPTemp2 = new List<string>(); // List for lens part 2
        public static List<string> LPTemp3 = new List<string>(); // List for lens part 3
        public static IList<double> MaxtrackList = new List<double>();
        public static IList<double> CopyMaxtrackList = new List<double>();
        public static IList<double> F1List = new List<double>();
        public static IList<double> F2List = new List<double>();
        public static IList<double> F3List = new List<double>();
        public static IList<double> CopyF1List = new List<double>();
        public static IList<double> CopyF2List = new List<double>();
        public static IList<double> CopyF3List = new List<double>();
        public static IList<double> CopyInpList = new List<double>();
        public static double[] Mx = new double[1000000];
        public static double[] My = new double[1000000];
        public static List<double> MxList = new List<double>();
        public static List<double> MyList = new List<double>();
        public static double[] a1 = new double[1000000];
        public static double[] a2 = new double[1000000];
        public static double[] b1 = new double[1000000];
        public static double[] b2 = new double[1000000];
        public static double[] MxratioMy = new double[1000000];
        public static IList<double> templist = new List<double>();
        public static double[] Maxtrack = new double[1000000];
        public static List<double> d1 = new List<double>();
        public static List<double> focallength1 = new List<double>(); // Initialize array for focal length 1------ used with excel
        public static List<double> focallength2 = new List<double>(); // Initialize array for focal length 2------ used with excel
        public static List<double> focallength3 = new List<double>(); // Initialize array for focal length 3------ used with excel
        public static List<double> EPD1 = new List<double>(); // Initialize List for Entrance pupil Dia 1 ------ used with excel
        public static List<double> EPD2 = new List<double>(); // Initialize List for Entrance pupil Dia  2------ used with excel
        public static List<double> EPD3 = new List<double>(); // Initialize List for fEntrance pupil Dia  3------ used with excel
        public static List<double> EPD1List = new List<double>(); // Initialize List for Entrance pupil Dia 1
        public static List<double> EPD2List = new List<double>(); // Initialize List for Entrance pupil Dia  2
        public static List<double> EPD3List = new List<double>(); // Initialize List for fEntrance pupil Dia  3
        public static List<double> CopyEPD1List = new List<double>(); // Copy Initialize List for Entrance pupil Dia 1
        public static List<double> CopyEPD2List = new List<double>(); // Copy Initialize List for Entrance pupil Dia  2
        public static List<double> CopyEPD3List = new List<double>(); // Copy Initialize List for fEntrance pupil Dia  3
        public static List<string> LensPartList1 = new List<string>(); // Initialize Lens part number for focallength 1------ used with excel
        public static List<string> LensPartList2 = new List<string>(); // Initialize Lens part number for focallength 2------ used with excel
        public static List<string> LensPartList3 = new List<string>(); // Initialize Lens part number for focallength 3------ used with excel
        public static List<string> LensList1 = new List<string>(); // Initialize Lens part number for focallength 1
        public static List<string> LensList2 = new List<string>(); // Initialize Lens part number for focallength 2
        public static List<string> LensList3 = new List<string>(); // Initialize Lens part number for focallength 3
        public static List<string> CopyLensList1 = new List<string>(); // Copy Initialize Lens part number for focallength 1
        public static List<string> CopyLensList2 = new List<string>(); // Copy Initialize Lens part number for focallength 2
        public static List<string> CopyLensList3 = new List<string>(); // Copy Initialize Lens part number for focallength 3

        public static List<string> VL1 = new List<string>(); // Initialize vender for focallength 1------ used with excel
        public static List<string> VL2 = new List<string>(); // Initialize vendor for focallength 2------ used with excel
        public static List<string> VL3 = new List<string>(); // Initialize vendor for focallength 3------ used with excel
        public static List<string> vendorList1 = new List<string>(); // Initialize vendor for focallength 1
        public static List<string> vendorList2 = new List<string>(); // Initialize vendor for focallength 2
        public static List<string> vendorList3 = new List<string>(); // Initialize vendor for focallength 3
        public static List<string> CopyvendorList1 = new List<string>(); // Copy Initialize vendor for focallength 1
        public static List<string> CopyvendorList2 = new List<string>(); // Copy Initialize vendor for focallength 2
        public static List<string> CopyvendorList3 = new List<string>(); // Copy Initialize vendor for focallength 3



        public static bool Maxtrackischecked;
        public static bool Mintrackischecked;

        //Commints


    public BeamExpanderControl()
        {
            getExcelFile();
            InitializeComponent();

            Maxtracktextbox.ReadOnly = true;

            Mintracktextbox.ReadOnly = true;

            Distance1Testbox.ReadOnly = true;

            Distance2Texbox.ReadOnly = true;

        }

        private void Magmaxinput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;

                MessageBox.Show("Please enter only Numeric values");
            }

        }

        private void Magmaxinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void MinMaginput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;

                MessageBox.Show("Please enter only Numeric values");
            }



        }

        private void MinMaginput_TextChanged(object sender, EventArgs e)
        {

        }

        private void BeamDiaInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;

                MessageBox.Show("Please enter only Numeric values");
            }

        }

        private void BeamExpanderControl_Load(object sender, EventArgs e)
        {

        }

        private void buttonMaginputs_Click(object sender, EventArgs e)
        {
            //if (!DistancebackgroundWorker.IsBusy)
            //{
            //    DistancebackgroundWorker.RunWorkerAsync();
            //}

            //else
            //{
            //    Messagelabel.Text = ("Busy processign please wait");

            //}

            InputMax = double.Parse(Magmaxinput.Text);

            InputMin = double.Parse(MinMaginput.Text);

            InputbeamDia = double.Parse(BeamDiaInput.Text);

            EPDConstrainF1 = (double)1.5 * InputbeamDia;

            EPDConstrainF3 = (double)(1 / InputMin) * 1.5 * InputbeamDia;

            CopyInputMin = InputMin;

            perm(focallength1, focallength2, focallength3, EPD1, EPD2, EPD3);



            if (!MaxtrackList.Any())
            {
                //Empty Magnification text box

                Magmaxinput.Text = " ";
                MinMaginput.Text = " ";
            }

            else
                if (MaxtrackList.Any())
                {
                    for (int c = 0; c < F1List.Count; c++)
                    {

                        for (double x = InputMin; x < InputMax; x += 0.1)
                        {
                            Distance1Add = Math.Round((double)F1List[c] + F2List[c] + ((F1List[c] * F2List[c]) / (InputMin * F3List[c])), 4);

                            d1.Add(Distance1Add);


                        }

                        bool Distance1 = d1.All(elements => elements >= 10);

                        if (Distance1 == true)
                        {
                            CopyMaxtrackList.Add(MaxtrackList[c]);

                            CopyF1List.Add(F1List[c]);

                            CopyF2List.Add(F2List[c]);

                            CopyF3List.Add(F3List[c]);

                            CopyEPD1List.Add(EPD1List[c]);

                            CopyEPD2List.Add(EPD2List[c]);

                            CopyEPD3List.Add(EPD3List[c]);

                            CopyLensList1.Add(LensList1[c]);

                            CopyLensList2.Add(LensList2[c]);

                            CopyLensList3.Add(LensList3[c]);

                            CopyvendorList1.Add(vendorList1[c]);

                            CopyvendorList2.Add(vendorList2[c]);

                            CopyvendorList3.Add(vendorList3[c]);




                        }



                    }


                }


            if (InputMax < InputMin)
            {
                MessageBox.Show("Please Enter Maximum value to Max and Minimum to Min");

                Magmaxinput.Text = " ";
                MinMaginput.Text = " ";

            }

            else
                if (!CopyMaxtrackList.Any())
                {
                    MessageBox.Show("There is no possible combination for such inputs in Database");

                }

                else

                    if (InputMax > InputMin && CopyMaxtrackList.Any())
                    {
                        for (int y = 0; y < CopyMaxtrackList.Count; y++)
                        {
                            Distance1listBoxCheck.Items.Add(CopyMaxtrackList[y]);

                        }

                        Maxtracktextbox.Text = CopyMaxtrackList.Max().ToString();

                        Mintracktextbox.Text = CopyMaxtrackList.Min().ToString();


                    }

    


        }

        public static double perm(List<double> F1, List<double> F2, List<double> F3, List<double> EP1, List<double> EP2, List<double> EP3)
        {
            int i, j, k;

                for (i = 0; i < F1.Count; i++)
                {

                    for (j = 0; j < F2.Count; j++)
                    {
                        for (k = 0; k < F3.Count; k++)
                        {

                            a1[k] = Math.Round((double)F1[i] + F2[j], 4);

                            MxratioMy[k] = Math.Round((double)F1[i] / F3[k], 4);

                            a2[k] = Math.Round((double)F2[j] + F3[k], 4);

                            b1[k] = Math.Round((double)(F1[i] * F2[j]) / F3[k], 4);

                            b2[k] = Math.Round((double)(F2[j] * F3[k]) / F1[i], 4);

                            Mx[k] = Math.Round((double)-a2[k] / b2[k], 4);

                            My[k] = Math.Round((double)-b1[k] / a1[k], 4);

                            Maxtrack[k] = Math.Round((double)F1[i] + 2 * F2[j] + F3[k] + (F2[j] * (((F3[k] * MxratioMy[k]) / F1[i]) + F1[i] / (F3[k] * MxratioMy[k]))), 4);


                            if (EPD1[i] >= EPDConstrainF1)
                            {
                                if (EPD3[k] >= EPDConstrainF3 && EPD2[j] != EPD3[k])
                                {
                                    if ((Mx[k] > MxratioMy[k]) && (MxratioMy[k] > My[k]) && (InputMax <= Mx[k]) && (InputMin >= My[k]) && (InputMax > InputMin) && (InputMin < InputMax) )
                                    {

                                        F1List.Add(F1[i]);

                                        F2List.Add(F2[j]);

                                        F3List.Add(F3[k]);

                                        EPD1List.Add(EPD1[i]);

                                        EPD2List.Add(EPD2[j]);

                                        EPD3List.Add(EPD3[k]);

                                        LensList1.Add(LensPartList1[i]);

                                        LensList2.Add(LensPartList2[j]);

                                        LensList3.Add(LensPartList3[k]);

                                        vendorList1.Add(VL1[i]);

                                        vendorList2.Add(VL2[j]);

                                        vendorList3.Add(VL3[k]);

                                        MaxtrackList.Add(Maxtrack[k]);

                                        MxList.Add(Mx[k]);

                                        MyList.Add(My[k]);

                                       

                                    }

                                }
                            }

                            else

                                if (EPD1[i] < EPDConstrainF1)
                                {
                                    if (EPD3[k] < EPDConstrainF3 || EPD2[j] == EPD3[k])
                                    {
                                        if ((MxratioMy[k] > Mx[k]) || (My[k] > MxratioMy[k]) || (InputMax > Mx[k]) || (InputMin < My[k]) || (InputMax < InputMin))
                                        {

                                            // Do nothing here just ignore the values

                                        }

                                    }
                                }

                        }

                    }
                }

            //check for emptiness of a List for no suitable combination of focal length


            //if (!MaxtrackList.Any())
            //{
            //    MessageBox.Show("There is no suitable focal length in database for this configuration");

            //}
           
                return 0;

        }

        public static void getExcelFile()
        {

            double F1rngCount;
            double F2rngCount;
            double F3rngCount;
            double EPD1rngCount;
            double EPD2rngCount;
            double EPD3rngCount;
            double LP1rngCount;
            double LP2rngCount;
            double LP3rngCount;
            double VL1rngCount;
            double VL2rngCount;
            double VL3rngCount;



            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();

            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\Ali\Source\Repos\GUI-V2-Zoom-Lens\Basicapp start\Basicapp start\Lens Database.xlsx");

            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];

            Excel.Range xlRange = xlWorksheet.UsedRange;

            // get used range of Focal length, Entrance pupil Dia and Lens Part number columns

            Excel.Range F1range = xlWorksheet.UsedRange.Columns["D", Type.Missing];

            Excel.Range F2range = xlWorksheet.UsedRange.Columns["Q", Type.Missing];

            Excel.Range F3range = xlWorksheet.UsedRange.Columns["AD", Type.Missing];

            Excel.Range EPD1range = xlWorksheet.UsedRange.Columns["E", Type.Missing];

            Excel.Range EPD2range = xlWorksheet.UsedRange.Columns["R", Type.Missing];

            Excel.Range EPD3range = xlWorksheet.UsedRange.Columns["AE", Type.Missing];

            Excel.Range LP1range = xlWorksheet.UsedRange.Columns["C", Type.Missing];

            Excel.Range LP2range = xlWorksheet.UsedRange.Columns["P", Type.Missing];

            Excel.Range LP3range = xlWorksheet.UsedRange.Columns["AC", Type.Missing];

            Excel.Range VL1range = xlWorksheet.UsedRange.Columns["B", Type.Missing];

            Excel.Range VL2range = xlWorksheet.UsedRange.Columns["O", Type.Missing];

            Excel.Range VL3range = xlWorksheet.UsedRange.Columns["AB", Type.Missing];




            // get number of used rows in column A, B and C

            F1rngCount = F1range.Rows.Count;

            F2rngCount = F2range.Rows.Count;

            F3rngCount = F3range.Rows.Count;

            EPD1rngCount = EPD1range.Rows.Count;

            EPD2rngCount = EPD2range.Rows.Count;

            EPD3rngCount = EPD3range.Rows.Count;

            LP1rngCount = LP1range.Rows.Count;

            LP2rngCount = LP2range.Rows.Count;

            LP3rngCount = LP3range.Rows.Count;

            VL1rngCount = VL1range.Rows.Count;

            VL2rngCount = VL2range.Rows.Count;

            VL3rngCount = VL3range.Rows.Count;




            // iterate over column D, Q and AD's used row count and store values to the list for Focal lengths

            for (int i = 3; i <= F1rngCount; i++)
            {
                focallength1.Add(xlWorksheet.Cells[i, "D"].Value());
            }

            for (int j = 3; j <= F2rngCount; j++)
            {
                focallength2.Add(xlWorksheet.Cells[j, "Q"].Value());
            }

            for (int k = 3; k <= F3rngCount; k++)
            {
                focallength3.Add(xlWorksheet.Cells[k, "AD"].Value());
            }

            // iterate over column E, R and AE's used row count and store values to the list for Entracne puplil Dia


            for (int i = 3; i <= EPD1rngCount; i++)
            {
                EPD1.Add(xlWorksheet.Cells[i, "E"].Value());
            }

            for (int j = 3; j <= EPD2rngCount; j++)
            {
                EPD2.Add(xlWorksheet.Cells[j, "R"].Value());
            }

            for (int k = 3; k <= EPD3rngCount; k++)
            {
                EPD3.Add(xlWorksheet.Cells[k, "AE"].Value());
            }

            // iterate over column C, P and AC's used row count and store values to the list for lens part number

            for (int i = 3; i <= LP1rngCount; i++)
            {
                LensPartList1.Add(xlWorksheet.Cells[i, "C"].Value());
            }

            for (int j = 3; j <= LP2rngCount; j++)
            {
                LensPartList2.Add(xlWorksheet.Cells[j, "P"].Value());
            }

            for (int k = 3; k <= LP3rngCount; k++)
            {
                LensPartList3.Add(xlWorksheet.Cells[k, "AC"].Value());
            }

            // iterate over column B, O and AB's used row count and store values to the list for vendor

            for (int i = 3; i <= VL1rngCount; i++)
            {
                VL1.Add(xlWorksheet.Cells[i, "B"].Value());
            }

            for (int j = 3; j <= VL2rngCount; j++)
            {
                VL2.Add(xlWorksheet.Cells[j, "O"].Value());
            }

            for (int k = 3; k <= VL3rngCount; k++)
            {
                VL3.Add(xlWorksheet.Cells[k, "AB"].Value());
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

        private void Seefocallengthbutton_Click(object sender, EventArgs e)
        {
            StringBuilder MessageText = new StringBuilder();

            if (MaxtrackRadioButton.Checked == true)
            {

                MessageText.AppendLine(string.Format("F1 = {0}, F2 = {1}, F3 = {2} ", CopyF1List[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())], CopyF2List[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())], CopyF3List[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())]));

                MessageBox.Show(MessageText.ToString());


            }

            else
                if (MinimumTrackButton.Checked == true )
            {
                MessageText.AppendLine(string.Format("F1 = {0}, F2 = {1}, F3 = {2} ", CopyF1List[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())], CopyF2List[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())], CopyF3List[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())]));

                MessageBox.Show(MessageText.ToString());

                //MessageBox.Show("F2 = " + F2List[MaxtrackList.IndexOf(MaxtrackList.Min())]);

                //MessageBox.Show("F3 = " + F3List[MaxtrackList.IndexOf(MaxtrackList.Min())]);

            }
            else
            {
                MessageBox.Show("Please Choose a track first");
            }

        }

        private void InputIndividualMag_Click(object sender, EventArgs e)
        {
            //if (InputIndividualMag == null && buttonMaginputs !=null)
            //{
                Input = double.Parse(InputTextbox.Text);

                if (MaxtrackRadioButton.Checked == true)
                {
                    // Take the values for focallengths, Lensparts and vendors as obtained at Maximum track length

                    MaxF1 = CopyF1List[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())];

                    MaxF2 = CopyF2List[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())];

                    MaxF3 = CopyF3List[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())];

                    LP1 = CopyLensList1[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())];

                    LP2 = CopyLensList2[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())];

                    LP3 = CopyLensList3[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())];

                    VendorL1 = CopyvendorList1[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())];

                    VendorL2 = CopyvendorList2[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())];

                    VendorL3 = CopyvendorList3[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())];

                    // Calculate here again all values needed for distance calculation

                    //Maxa1 = Math.Round((double)MaxF1 + MaxF2, 4);

                    //MaxMxratioMy = Math.Round((double)MaxF1 / MaxF3, 4);

                    //Maxa2 = Math.Round((double)MaxF2 + MaxF3, 4);

                    //Maxb1 = Math.Round((double)(MaxF1 * MaxF2 / MaxF3), 4);

                    //Maxb2 = Math.Round((double)(MaxF2 * MaxF3) / MaxF1, 4);

                    //MaxMx = Math.Round((double)-Maxa2 / Maxb2, 4);

                    //MaxMy = Math.Round((double)-Maxb1 / Maxa1, 4);


                    if ((Input <= InputMax) && (Input >= InputMin))
                    {

                        //Calculate d1 and d2 for the Input Magnification

                        Maxd1 = Math.Round((double)MaxF1 + MaxF2 + ((MaxF1 * MaxF2) / (Input * MaxF3)), 4);

                        Maxd2 = Math.Round((double)MaxF2 + MaxF3 + ((MaxF2 * MaxF3 * Input) / (MaxF1)), 4);

                        if ((Maxd1 >= -0.012) && (Maxd1 < 0))
                        {
                            Maxd1 = 0;
                        }
                        else

                            if ((Maxd2 >= -0.012) && (Maxd2 < 0))
                        {
                            Maxd2 = 0;
                        }

                        Distance1Testbox.Text = Maxd1.ToString();

                        Distance2Texbox.Text = Maxd2.ToString();

                        // Add distances to temporay list and use later to add these as thickness in Zemax LDE

                        Temp1.Add(Maxd1);

                        Temp2.Add(Maxd2);

                        // Add Lenspart to temporay list and use later to add these in Zemax LDE

                        //LPTemp1.Add(LP1);

                        //LPTemp2.Add(LP2);

                        //LPTemp3.Add(LP3);



                        //}

                        //else

                        if ((Input > InputMax) || (Input < InputMin))
                        {

                            MessageBox.Show("Please choose values between or equal to Max and Min Magnification");

                        }

                    }

                }

                else
                    if (MinimumTrackButton.Checked == true)
                {
                    MinF1 = CopyF1List[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())];

                    MinF2 = CopyF2List[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())];

                    MinF3 = CopyF3List[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())];

                    LP1 = CopyLensList1[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())];

                    LP2 = CopyLensList2[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())];

                    LP3 = CopyLensList3[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())];

                    VendorL1 = CopyvendorList1[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())];

                    VendorL2 = CopyvendorList2[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())];

                    VendorL3 = CopyvendorList3[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())];


                    // Calculate here again all values needed for distance calculation

                    //Mina1 = Math.Round((double)MinF1 + MinF2, 4);

                    //MinMxratioMy = Math.Round((double)MinF1 / MinF3, 4);

                    //Mina2 = Math.Round((double)MinF2 + MinF3, 4);

                    //Minb1 = Math.Round((double)(MinF1 * MinF2 / MinF3), 4);

                    //Minb2 = Math.Round((double)(MinF2 * MinF3) / MinF1, 4);

                    //MinMx = Math.Round((double)-Mina2 / Minb2, 4);

                    //MinMy = Math.Round((double)-Minb1 / Mina1, 4);


                    if ((Input <= InputMax) && (Input >= InputMin))
                    {


                        //Calculate d1 and d2 for the Input Magnification

                        Mind1 = Math.Round((double)MinF1 + MinF2 + ((MinF1 * MinF2) / (Input * MinF3)), 4);

                        Mind2 = Math.Round((double)MinF2 + MinF3 + ((MinF2 * MinF3 * Input) / (MinF1)), 4);

                        if ((Mind1 >= -0.012) && (Mind1 < 0))
                        {
                            Mind1 = 0;
                        }
                        else

                            if ((Mind2 >= -0.012) && (Mind2 < 0))
                        {
                            Mind2 = 0;
                        }

                        Distance1Testbox.Text = Mind1.ToString();

                        Distance2Texbox.Text = Mind2.ToString();


                        // Add distances to temporay list and use later to add these as thickness in Zemax LDE

                        Temp1.Add(Mind1);

                        Temp2.Add(Mind2);

                        // Add Lensparts to temporay list and use later to add these in Zemax LDE

                        //LPTemp1.Add(LP1);

                        //LPTemp2.Add(LP2);

                        //LPTemp3.Add(LP3);

                    }

                    else

                        if ((Input > InputMax) || (Input < InputMin))
                    {

                        MessageBox.Show("Please choose values between or equal to Max and Min Magnification");

                    }

                }

            //}

            //else
            //{
            //    MessageBox.Show("Please Enter the Magnifications");
            //}



        }

        private void MinimumTrackButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        ZoomCurvesForm Graphs;

        private void zoomCurvesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maxtrackischecked = MaxtrackRadioButton.Checked;

            Mintrackischecked = MinimumTrackButton.Checked;

               
            if (Graphs == null)
            {
                    Graphs = new ZoomCurvesForm();
                    


                Graphs.Show();

           
            Graphs.FormClosed += new FormClosedEventHandler(Graphs_FormClosed);


           }

            else
              Graphs.Activate();
           


        }

        void Graphs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Graphs = null;
            //    //throw new NotImplementedException();
        }

        private void Partnumberbutton_Click(object sender, EventArgs e)
    {
        StringBuilder MessageText = new StringBuilder();

        if (MaxtrackRadioButton.Checked == true)
        {
            MessageText.AppendLine(string.Format("The Lens Part for F1 = {0}, F2 = {1} and F3 = {2} \n", CopyLensList1[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())], CopyLensList2[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())], CopyLensList3[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())]));

            MessageBox.Show(MessageText.ToString());

        }

        else
            if (MinimumTrackButton.Checked == true)
        {
            MessageText.AppendLine(string.Format("The Lens Part for F1 = {0}, F2 = {1} and F3 = {2} \n", CopyLensList1[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())], CopyLensList2[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())], CopyLensList3[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())]));

            MessageBox.Show(MessageText.ToString());

        }
            else
            {
                MessageBox.Show("Choose a Track first");
            }
        }

        private void ZemaxInitializer_Click(object sender, EventArgs e)
        {
            ZemaxInitialize();

        }

        public static void ZemaxInitialize()
        {
            // Find the installed version of OpticStudio
            bool isInitialized = ZOSAPI_NetHelper.ZOSAPI_Initializer.Initialize();
            // Note -- uncomment the following line to use a custom initialization path
            //bool isInitialized = ZOSAPI_NetHelper.ZOSAPI_Initializer.Initialize(@"C:\Program Files\OpticStudio\");
            if (isInitialized)
            {
                LogInfo("Found OpticStudio at: " + ZOSAPI_NetHelper.ZOSAPI_Initializer.GetZemaxDirectory());
            }
            else
            {
                HandleError("Failed to locate OpticStudio!");
                return;
            }

            BeginStandaloneApplication();

        }

        static void BeginStandaloneApplication()
        {
            // Create the initial connection class
            ZOSAPI_Connection TheConnection = new ZOSAPI_Connection();

            // Attempt to create a Standalone connection
            IZOSAPI_Application TheApplication = TheConnection.CreateNewApplication();
            if (TheApplication == null)
            {
                HandleError("An unknown connection error occurred!");
                return;
            }

            // Check the connection status
            if (!TheApplication.IsValidLicenseForAPI)
            {
                HandleError("Failed to connect to OpticStudio: " + TheApplication.LicenseStatus);
                return;
            }
            if (TheApplication.Mode != ZOSAPI_Mode.Server)
            {
                HandleError("User plugin was started in the wrong mode: expected Server, found " + TheApplication.Mode.ToString());
                return;
            }

            IOpticalSystem TheSystem = TheApplication.PrimarySystem;

            // Add your custom code here...

            // creates new directory
            string strPath = System.IO.Path.Combine(TheApplication.SamplesDir, @"API\CS#");
            System.IO.Directory.CreateDirectory(strPath);

            TheSystem.LoadFile(TheApplication.SamplesDir + "\\Sequential\\Objectives\\BX.zmx", false);

            TheSystem.New(false);

            // ISystemData represents the System Explorer in GUI.
            // We access options in System Explorer through ISystemData in ZOS-API
            ISystemData TheSystemData = TheSystem.SystemData;
            TheSystemData.Aperture.ApertureValue = InputbeamDia;
            TheSystemData.Aperture.SemiDiameterMargin = 2;
            TheSystemData.Aperture.AFocalImageSpace = true;
            TheSystemData.Wavelengths.GetWavelength(1).Wavelength = 1.0641;


            // Add Material Catlogs

            ISDMaterialCatalogData sysCat = TheSystem.SystemData.MaterialCatalogs;

            sysCat.AddCatalog("Schott");
            sysCat.AddCatalog("Angstromlink");
            sysCat.AddCatalog("Apel");
            sysCat.AddCatalog("Archer");
            sysCat.AddCatalog("Arton");
            sysCat.AddCatalog("Birefringent");
            sysCat.AddCatalog("Cdgm");
            sysCat.AddCatalog("Corning");
            sysCat.AddCatalog("Heraeus");
            sysCat.AddCatalog("Hikari");
            sysCat.AddCatalog("Hoya");
            sysCat.AddCatalog("Infrared");
            sysCat.AddCatalog("Irphotonics");
            sysCat.AddCatalog("Isuzu");
            sysCat.AddCatalog("Lightpath");
            sysCat.AddCatalog("Luxexcel");
            sysCat.AddCatalog("Lzos");
            sysCat.AddCatalog("Misc");
            sysCat.AddCatalog("Nhg");
            sysCat.AddCatalog("Schott_irg");


            List<string> lenslist1 = new List<string>();
            List<string> lenslist2 = new List<string>();
            List<string> lenslist3 = new List<string>();


            // Get the interface for Lens Catalogs


            ILensCatalogs Cataloglenses = TheSystem.Tools.OpenLensCatalogs();

            Cataloglenses.GetAllVendors();

            // Check for Vendor for focallength 1

            if (VendorL1 == "THORLABS" || VendorL1 == "EDMUND OPTICS")
            {
                if (VendorL1 == "THORLABS")
                {
                    string VendorName = "THORLABS";

                    Cataloglenses.SelectedVendor = VendorName;

                }

                else

                    if (VendorL1 == "EDMUND OPTICS")
                {
                    string VendorName = "EDMUND OPTICS";

                    Cataloglenses.SelectedVendor = VendorName;

                }


                int elementNumber = 1;


                Cataloglenses.NumberOfElements = elementNumber;

                // Default Check box setting

                Cataloglenses.IncShapeEqui = true;

                Cataloglenses.IncShapeBi = true;

                Cataloglenses.IncShapePlano = true;

                Cataloglenses.IncShapeMeniscus = true;

                Cataloglenses.IncTypeSpherical = true;

                Cataloglenses.IncTypeGRIN = false;

                Cataloglenses.IncTypeAspheric = false;

                Cataloglenses.IncTypeToroidal = false;

                Cataloglenses.UseEPD = true;

                Cataloglenses.UseEFL = false;

                Cataloglenses.MinEPD = 5.0;

                Cataloglenses.MaxEPD = 50;

                //Cataloglenses.MinEFL = 40.0;

                //Cataloglenses.MaxEFL = 62.0;

                Cataloglenses.Run();

                int matchlens = Cataloglenses.MatchingLenses;

                //Console.WriteLine(matchlens);

                // Add matching lenses to firstlist

                for (int x = 0; x < matchlens; x++)
                {

                    lenslist1.Add(Cataloglenses.GetResult(x).LensName);

                }

                // Output into LDE for selected lens

            }

            for (int y = 0; y < lenslist1.Count; y++)
            {

                if (VendorL1 == "THORLABS" && lenslist1[y] == LP1)
                {
                    //Console.WriteLine(MinLP1 + "\n");

                    Cataloglenses.GetResult(y).InsertLensSeq(2, true, false);
                }

                if (VendorL1 == "EDMUND OPTICS" && "EO-" + lenslist1[y] == LP1)
                {
                    //Console.WriteLine(MinLP1 + "\n");

                    Cataloglenses.GetResult(y).InsertLensSeq(2, true, false);
                }


            }


            // ------------------------------------------------------------------------------

            if (VendorL2 == "THORLABS" || VendorL2 == "EDMUND OPTICS")
            {
                if (VendorL2 == "THORLABS")
                {
                    string VendorName = "THORLABS";

                    Cataloglenses.SelectedVendor = VendorName;

                }

                else

                    if (VendorL2 == "EDMUND OPTICS")
                {
                    string VendorName = "EDMUND OPTICS";

                    Cataloglenses.SelectedVendor = VendorName;

                }



                int elementNumber = 1;


                Cataloglenses.NumberOfElements = elementNumber;

                // Default Check box setting

                Cataloglenses.IncShapeEqui = true;

                Cataloglenses.IncShapeBi = true;

                Cataloglenses.IncShapePlano = true;

                Cataloglenses.IncShapeMeniscus = true;

                Cataloglenses.IncTypeSpherical = true;

                Cataloglenses.IncTypeGRIN = false;

                Cataloglenses.IncTypeAspheric = false;

                Cataloglenses.IncTypeToroidal = false;

                Cataloglenses.UseEPD = true;

                Cataloglenses.UseEFL = false;

                Cataloglenses.MinEPD = 5.0;

                Cataloglenses.MaxEPD = 50;

                //Cataloglenses.MinEFL = 40.0;

                //Cataloglenses.MaxEFL = 62.0;

                Cataloglenses.Run();

                int matchlens = Cataloglenses.MatchingLenses;

                //Console.WriteLine(matchlens);

                // Add matching lenses to firstlist

                for (int x = 0; x < matchlens; x++)
                {

                    lenslist2.Add(Cataloglenses.GetResult(x).LensName);

                }

                // Output into LDE for selected lens

            }

            for (int y = 0; y < lenslist2.Count; y++)
            {
                if (VendorL2 == "THORLABS" && lenslist2[y] == LP2)
                {
                    //Console.WriteLine(MinLP1 + "\n");

                    Cataloglenses.GetResult(y).InsertLensSeq(4, true, false);
                }

                if (VendorL2 == "EDMUND OPTICS" && "EO-" + lenslist2[y] == LP2)
                {
                    //Console.WriteLine(MinLP1 + "\n");

                    Cataloglenses.GetResult(y).InsertLensSeq(4, true, false);
                }

            }




            // ------------------------------------------------------------------------------

            if (VendorL3 == "THORLABS" || VendorL3 == "EDMUND OPTICS")
            {
                if (VendorL3 == "THORLABS")
                {
                    string VendorName = "THORLABS";

                    Cataloglenses.SelectedVendor = VendorName;

                }

                else

                    if (VendorL3 == "EDMUND OPTICS")
                {
                    string VendorName = "EDMUND OPTICS";

                    Cataloglenses.SelectedVendor = VendorName;

                }


                int elementNumber = 1;

                Cataloglenses.NumberOfElements = elementNumber;

                // Default Check box setting

                Cataloglenses.IncShapeEqui = true;

                Cataloglenses.IncShapeBi = true;

                Cataloglenses.IncShapePlano = true;

                Cataloglenses.IncShapeMeniscus = true;

                Cataloglenses.IncTypeSpherical = true;

                Cataloglenses.IncTypeGRIN = false;

                Cataloglenses.IncTypeAspheric = false;

                Cataloglenses.IncTypeToroidal = false;

                Cataloglenses.UseEPD = true;

                Cataloglenses.UseEFL = false;

                Cataloglenses.MinEPD = 5.0;

                Cataloglenses.MaxEPD = 50;

                //Cataloglenses.MinEFL = 40.0;

                //Cataloglenses.MaxEFL = 62.0;

                Cataloglenses.Run();

                int matchlens = Cataloglenses.MatchingLenses;

                //Console.WriteLine(matchlens);

                // Add matching lenses to firstlist

                for (int x = 0; x < matchlens; x++)
                {

                    lenslist3.Add(Cataloglenses.GetResult(x).LensName);

                }

                // Output into LDE for selected lens

            }

            for (int y = 0; y < lenslist3.Count; y++)
            {
                if (VendorL3 == "THORLABS" && lenslist3[y] == LP3)
                {
                    //Console.WriteLine(MinLP1 + "\n");

                    Cataloglenses.GetResult(y).InsertLensSeq(6, true, false);
                }

                if (VendorL3 == "EDMUND OPTICS" && "EO-" + lenslist3[y] == LP3)
                {
                    //Console.WriteLine(MinLP1 + "\n");

                    Cataloglenses.GetResult(y).InsertLensSeq(6, true, false);
                }

            }


            // Get interface of Lens Data Editor
            //------------------------------------

            ILensDataEditor TheLDE = TheSystem.LDE;
            //TheLDE.InsertNewSurfaceAt(2);
            //TheLDE.InsertNewSurfaceAt(3);
            //TheLDE.InsertNewSurfaceAt(4);
            //TheLDE.InsertNewSurfaceAt(5);
            //TheLDE.InsertNewSurfaceAt(6);
            //TheLDE.InsertNewSurfaceAt(7);

            //-----------------------------------

            // To change surface type, we need to first get an ISurfaceTypesettings and then assign it.
            //----------------------------

            //ISurfaceTypeSettings SurfaceType_Paraxial = TheLDE.GetSurfaceAt(2).GetSurfaceTypeSettings(SurfaceType.Paraxial);
            //TheLDE.GetSurfaceAt(2).ChangeType(SurfaceType_Paraxial);
            //TheLDE.GetSurfaceAt(3).ChangeType(SurfaceType_Paraxial);
            //TheLDE.GetSurfaceAt(4).ChangeType(SurfaceType_Paraxial);
            //TheLDE.GetSurfaceAt(5).ChangeType(SurfaceType_Paraxial);
            //TheLDE.GetSurfaceAt(6).ChangeType(SurfaceType_Paraxial);
            //TheLDE.GetSurfaceAt(7).ChangeType(SurfaceType_Paraxial);



            // Set thickness and material for each surface.

            List<double> T1 = new List<double>();
            List<double> T2 = new List<double>();

            TheLDE.GetSurfaceAt(1).Thickness = 20;



            T1.Add(TheLDE.GetSurfaceAt(3).Thickness);
            T1 = Temp1;

            T2.Add(TheLDE.GetSurfaceAt(5).Thickness);
            T2 = Temp2;

            // Get interface of the Multi-Configuration Editor

            IMultiConfigEditor TheMCE = TheSystem.MCE;


            // Add two configurations (totally 3)

            TheMCE.AddConfiguration(false);
            TheMCE.AddConfiguration(false);

            // Add one operand (totally 2)

            TheMCE.AddOperand();

            // Get interface of each operand

            IMCERow MCOperand1 = TheMCE.GetOperandAt(1);
            IMCERow MCOperand2 = TheMCE.GetOperandAt(2);

            // Change both operands' type to THIC

            MCOperand1.ChangeType(MultiConfigOperandType.THIC);
            MCOperand2.ChangeType(MultiConfigOperandType.THIC);

            // Set parameters of operands
            // If the type of operand is THIC, the first parameter here means surface number

            MCOperand1.Param1 = 3;
            MCOperand2.Param1 = 5;

            // Setup Variables

            ISolveData configvariable = TheMCE.GetOperandAt(1).GetOperandCell(1).CreateSolveType(ZOSAPI.Editors.SolveType.Variable);




            // Set values of opeand for each configurations

            for (int w = 0; w < Temp1.Count; w++)
            {
                MCOperand1.GetOperandCell(3).DoubleValue = T1[0];
                MCOperand2.GetOperandCell(3).DoubleValue = T2[0];
                TheMCE.GetOperandAt(1).GetOperandCell(3).SetSolveData(configvariable);
                TheMCE.GetOperandAt(2).GetOperandCell(3).SetSolveData(configvariable);



                MCOperand1.GetOperandCell(2).DoubleValue = T1[1];
                MCOperand2.GetOperandCell(2).DoubleValue = T2[1];
                TheMCE.GetOperandAt(1).GetOperandCell(2).SetSolveData(configvariable);
                TheMCE.GetOperandAt(2).GetOperandCell(2).SetSolveData(configvariable);


                MCOperand1.GetOperandCell(1).DoubleValue = T1[2];
                MCOperand2.GetOperandCell(1).DoubleValue = T2[2];
                TheMCE.GetOperandAt(1).GetOperandCell(1).SetSolveData(configvariable);
                TheMCE.GetOperandAt(2).GetOperandCell(1).SetSolveData(configvariable);

            }

            TheLDE.GetSurfaceAt(7).Thickness = 20;


            //-------------------------------

            //Merit Funtions

            //--------------------------------------------

            // Operands for 1st Configuration

            // CONF 1


            IMeritFunctionEditor TheMFE = TheSystem.MFE;

            IMFERow Operand_CONF1 = TheMFE.GetOperandAt(1);

            Operand_CONF1.ChangeType(MeritOperandType.CONF);

            Operand_CONF1.GetCellAt(2).IntegerValue = 1;

            IMFERow Operand_REAYop2_CONF1 = TheMFE.InsertNewOperandAt(2);

            Operand_REAYop2_CONF1.ChangeType(MeritOperandType.REAY);

            Operand_REAYop2_CONF1.GetCellAt(2).IntegerValue = 1;

            Operand_REAYop2_CONF1.GetCellAt(7).DoubleValue = 1;

            IMFERow Operand_REAYop3_CONF1 = TheMFE.InsertNewOperandAt(3);

            Operand_REAYop3_CONF1.ChangeType(MeritOperandType.REAY);

            Operand_REAYop3_CONF1.GetCellAt(2).IntegerValue = 7;

            Operand_REAYop3_CONF1.GetCellAt(7).DoubleValue = 1;

            Operand_REAYop3_CONF1.Weight = 1;

            IMFERow Operand_RANGop4_CONF1 = TheMFE.InsertNewOperandAt(4);

            Operand_RANGop4_CONF1.ChangeType(MeritOperandType.RANG);

            Operand_RANGop4_CONF1.GetCellAt(2).IntegerValue = 7;

            Operand_RANGop4_CONF1.GetCellAt(7).DoubleValue = 1;

            Operand_RANGop4_CONF1.Target = 0;

            Operand_RANGop4_CONF1.Weight = 0;

            Operand_RANGop4_CONF1.GetCellAt(7).DoubleValue = 1;

            //IMFERow Operand_EFLXop5_CONF1 = TheMFE.InsertNewOperandAt(5); // EFLX for operand 5

            //Operand_EFLXop5_CONF1.ChangeType(MeritOperandType.EFLX);

            //Operand_EFLXop5_CONF1.GetCellAt(2).IntegerValue = 2;

            //Operand_EFLXop5_CONF1.GetCellAt(3).IntegerValue = 3;

            //Operand_EFLXop5_CONF1.Target = MinF1;//Operand_EFLXop5_CONF1.GetCellAt(12).DoubleValue;

            //Operand_EFLXop5_CONF1.Weight = 1;

            //IMFERow Operand_EFLXop6_CONF1 = TheMFE.InsertNewOperandAt(6);

            //Operand_EFLXop6_CONF1.ChangeType(MeritOperandType.EFLX);

            //Operand_EFLXop6_CONF1.GetCellAt(2).IntegerValue = 4;

            //Operand_EFLXop6_CONF1.GetCellAt(3).IntegerValue = 5;

            //Operand_EFLXop6_CONF1.Target = MinF2; //Operand_EFLXop6_CONF1.GetCellAt(12).DoubleValue;

            //Operand_EFLXop6_CONF1.Weight = 1;

            //IMFERow Operand_EFLXop7_CONF1 = TheMFE.InsertNewOperandAt(7);

            //Operand_EFLXop7_CONF1.ChangeType(MeritOperandType.EFLX);

            //Operand_EFLXop7_CONF1.GetCellAt(2).IntegerValue = 6;

            //Operand_EFLXop7_CONF1.GetCellAt(3).IntegerValue = 7;

            //Operand_EFLXop7_CONF1.Target = MinF3;//Operand_EFLXop7_CONF1.GetCellAt(12).DoubleValue;

            //Operand_EFLXop7_CONF1.Weight = 1;

            //IMFERow Operand_CTGTop8_CONF1 = TheMFE.InsertNewOperandAt(8);

            //Operand_CTGTop8_CONF1.ChangeType(MeritOperandType.CTGT);

            //Operand_CTGTop8_CONF1.GetCellAt(2).IntegerValue = 3;

            //Operand_CTGTop8_CONF1.Target = 1;

            //Operand_CTGTop8_CONF1.Weight = 1;

            //IMFERow Operand_CTGTop9_CONF1 = TheMFE.InsertNewOperandAt(9);

            //Operand_CTGTop9_CONF1.ChangeType(MeritOperandType.CTGT);

            //Operand_CTGTop9_CONF1.GetCellAt(2).IntegerValue = 5;

            //Operand_CTGTop9_CONF1.Target = 1;

            //Operand_CTGTop9_CONF1.Weight = 0;

            IMFERow Operand_DIVIop23_CONF1 = TheMFE.InsertNewOperandAt(5);

            Operand_DIVIop23_CONF1.ChangeType(MeritOperandType.DIVI);

            Operand_DIVIop23_CONF1.GetCellAt(2).IntegerValue = 2;

            Operand_DIVIop23_CONF1.GetCellAt(3).IntegerValue = 3;

            Operand_DIVIop23_CONF1.Target = 0.32;

            Operand_DIVIop23_CONF1.Weight = 1;


            //-------------------------------------------

            //Operand for 2nd Configuration

            // CONF 2

            IMFERow Operand_CONF2 = TheMFE.InsertNewOperandAt(6);

            Operand_CONF2.ChangeType(MeritOperandType.CONF);

            Operand_CONF2.GetCellAt(2).IntegerValue = 2;

            IMFERow Operand_REAYop12_CONF2 = TheMFE.InsertNewOperandAt(7);

            Operand_REAYop12_CONF2.ChangeType(MeritOperandType.REAY);

            Operand_REAYop12_CONF2.GetCellAt(2).IntegerValue = 1;

            Operand_REAYop12_CONF2.GetCellAt(7).DoubleValue = 1;

            IMFERow Operand_REAYop13_CONF2 = TheMFE.InsertNewOperandAt(8);

            Operand_REAYop13_CONF2.ChangeType(MeritOperandType.REAY);

            Operand_REAYop13_CONF2.GetCellAt(2).IntegerValue = 7;

            Operand_REAYop13_CONF2.GetCellAt(7).DoubleValue = 1;

            Operand_REAYop13_CONF2.Weight = 1;

            IMFERow Operand_RANGop14_CONF2 = TheMFE.InsertNewOperandAt(9);

            Operand_RANGop14_CONF2.ChangeType(MeritOperandType.RANG);

            Operand_RANGop14_CONF2.GetCellAt(2).IntegerValue = 7;

            Operand_RANGop14_CONF2.GetCellAt(7).DoubleValue = 1;

            Operand_RANGop14_CONF2.Target = 0;

            Operand_RANGop14_CONF2.Weight = 0;

            Operand_RANGop14_CONF2.GetCellAt(7).DoubleValue = 1;

            //IMFERow Operand_EFLXop15_CONF2 = TheMFE.InsertNewOperandAt(15); // EFLX for operand 5

            //Operand_EFLXop15_CONF2.ChangeType(MeritOperandType.EFLX);

            //Operand_EFLXop15_CONF2.GetCellAt(2).IntegerValue = 2;

            //Operand_EFLXop15_CONF2.GetCellAt(3).IntegerValue = 3;

            //Operand_EFLXop15_CONF2.Target = MinF1;//Operand_EFLXop15_CONF2.GetCellAt(12).DoubleValue;

            //Operand_EFLXop15_CONF2.Weight = 1;

            //IMFERow Operand_EFLXop16_CONF2 = TheMFE.InsertNewOperandAt(16);

            //Operand_EFLXop16_CONF2.ChangeType(MeritOperandType.EFLX);

            //Operand_EFLXop16_CONF2.GetCellAt(2).IntegerValue = 4;

            //Operand_EFLXop16_CONF2.GetCellAt(3).IntegerValue = 5;

            //Operand_EFLXop16_CONF2.Target = MinF2;//Operand_EFLXop16_CONF2.GetCellAt(12).DoubleValue;

            //Operand_EFLXop16_CONF2.Weight = 1;

            //IMFERow Operand_EFLXop17_CONF2 = TheMFE.InsertNewOperandAt(17);

            //Operand_EFLXop17_CONF2.ChangeType(MeritOperandType.EFLX);

            //Operand_EFLXop17_CONF2.GetCellAt(2).IntegerValue = 6;

            //Operand_EFLXop17_CONF2.GetCellAt(3).IntegerValue = 7;

            //Operand_EFLXop17_CONF2.Target = MinF3;//Operand_EFLXop17_CONF2.GetCellAt(12).DoubleValue;

            //Operand_EFLXop17_CONF2.Weight = 1;

            //IMFERow Operand_CTGTop18_CONF2 = TheMFE.InsertNewOperandAt(18);

            //Operand_CTGTop18_CONF2.ChangeType(MeritOperandType.CTGT);

            //Operand_CTGTop18_CONF2.GetCellAt(2).IntegerValue = 3;

            //Operand_CTGTop18_CONF2.Target = 1;

            //Operand_CTGTop18_CONF2.Weight = 1;

            //IMFERow Operand_CTGTop19_CONF2 = TheMFE.InsertNewOperandAt(19);

            //Operand_CTGTop19_CONF2.ChangeType(MeritOperandType.CTGT);

            //Operand_CTGTop19_CONF2.GetCellAt(2).IntegerValue = 5;

            //Operand_CTGTop19_CONF2.Target = 1;

            //Operand_CTGTop19_CONF2.Weight = 0;


            IMFERow Operand_DIVIop20_CONF2 = TheMFE.InsertNewOperandAt(10);

            Operand_DIVIop20_CONF2.ChangeType(MeritOperandType.DIVI);

            Operand_DIVIop20_CONF2.GetCellAt(2).IntegerValue = 7;

            Operand_DIVIop20_CONF2.GetCellAt(3).IntegerValue = 8;

            Operand_DIVIop20_CONF2.Target = 1.08;

            Operand_DIVIop20_CONF2.Weight = 1;


            //---------------------------------------------------

            //Operand for 3rd Configuration

            // CONF 3

            IMFERow Operand_CONF3 = TheMFE.InsertNewOperandAt(11);

            Operand_CONF3.ChangeType(MeritOperandType.CONF);

            Operand_CONF3.GetCellAt(2).IntegerValue = 3;

            IMFERow Operand_REAYop22_CONF3 = TheMFE.InsertNewOperandAt(12);

            Operand_REAYop22_CONF3.ChangeType(MeritOperandType.REAY);

            Operand_REAYop22_CONF3.GetCellAt(2).IntegerValue = 1;

            Operand_REAYop22_CONF3.GetCellAt(7).DoubleValue = 1;

            IMFERow Operand_REAYop33_CONF3 = TheMFE.InsertNewOperandAt(13);

            Operand_REAYop33_CONF3.ChangeType(MeritOperandType.REAY);

            Operand_REAYop33_CONF3.GetCellAt(2).IntegerValue = 7;

            Operand_REAYop33_CONF3.GetCellAt(7).DoubleValue = 1;

            Operand_REAYop33_CONF3.Weight = 1;

            IMFERow Operand_RANGop24_CONF3 = TheMFE.InsertNewOperandAt(14);

            Operand_RANGop24_CONF3.ChangeType(MeritOperandType.RANG);

            Operand_RANGop24_CONF3.GetCellAt(2).IntegerValue = 7;

            Operand_RANGop24_CONF3.GetCellAt(7).DoubleValue = 1;

            Operand_RANGop24_CONF3.Target = 0;

            Operand_RANGop24_CONF3.Weight = 0;

            Operand_RANGop24_CONF3.GetCellAt(7).DoubleValue = 1;

            //IMFERow Operand_EFLXop25_CONF3 = TheMFE.InsertNewOperandAt(25); // EFLX for operand 5

            //Operand_EFLXop25_CONF3.ChangeType(MeritOperandType.EFLX);

            //Operand_EFLXop25_CONF3.GetCellAt(2).IntegerValue = 2;

            //Operand_EFLXop25_CONF3.GetCellAt(3).IntegerValue = 3;

            //Operand_EFLXop25_CONF3.Target = MinF1;//Operand_EFLXop15_CONF2.GetCellAt(12).DoubleValue;

            //Operand_EFLXop25_CONF3.Weight = 1;

            //IMFERow Operand_EFLXop26_CONF3 = TheMFE.InsertNewOperandAt(26);

            //Operand_EFLXop26_CONF3.ChangeType(MeritOperandType.EFLX);

            //Operand_EFLXop26_CONF3.GetCellAt(2).IntegerValue = 4;

            //Operand_EFLXop26_CONF3.GetCellAt(3).IntegerValue = 5;

            //Operand_EFLXop26_CONF3.Target = MinF2;//Operand_EFLXop26_CONF3.GetCellAt(12).DoubleValue;

            //Operand_EFLXop26_CONF3.Weight = 1;

            //IMFERow Operand_EFLXop27_CONF3 = TheMFE.InsertNewOperandAt(27);

            //Operand_EFLXop27_CONF3.ChangeType(MeritOperandType.EFLX);

            //Operand_EFLXop27_CONF3.GetCellAt(2).IntegerValue = 6;

            //Operand_EFLXop27_CONF3.GetCellAt(3).IntegerValue = 7;

            //Operand_EFLXop27_CONF3.Target = MinF3;//Operand_EFLXop27_CONF3.GetCellAt(12).DoubleValue;

            //Operand_EFLXop27_CONF3.Weight = 1;

            //IMFERow Operand_CTGTop28_CONF3 = TheMFE.InsertNewOperandAt(28);

            //Operand_CTGTop28_CONF3.ChangeType(MeritOperandType.CTGT);

            //Operand_CTGTop28_CONF3.GetCellAt(2).IntegerValue = 3;

            //Operand_CTGTop28_CONF3.Target = 1;

            //Operand_CTGTop28_CONF3.Weight = 1;

            //IMFERow Operand_CTGTop29_CONF3 = TheMFE.InsertNewOperandAt(29);

            //Operand_CTGTop29_CONF3.ChangeType(MeritOperandType.CTGT);

            //Operand_CTGTop29_CONF3.GetCellAt(2).IntegerValue = 5;

            //Operand_CTGTop29_CONF3.Target = 1;

            //Operand_CTGTop29_CONF3.Weight = 0;


            IMFERow Operand_DIVIop30_CONF3 = TheMFE.InsertNewOperandAt(15);

            Operand_DIVIop30_CONF3.ChangeType(MeritOperandType.DIVI);

            Operand_DIVIop30_CONF3.GetCellAt(2).IntegerValue = 12;

            Operand_DIVIop30_CONF3.GetCellAt(3).IntegerValue = 13;

            Operand_DIVIop30_CONF3.Target = 2.92;

            Operand_DIVIop30_CONF3.Weight = 1;


            // Local optimisation till completion

            //ILocalOptimization LocalOpt = TheSystem.Tools.OpenLocalOptimization();

            //LocalOpt.Algorithm = OptimizationAlgorithm.DampedLeastSquares;

            //LocalOpt.Cycles = OptimizationCycles.Automatic;

            //LocalOpt.NumberOfCores = 12;

            //LocalOpt.RunAndWaitForCompletion();

            //LocalOpt.Close();

            //--------------------------------------------

            // Open MCE and MFE

            //TheSystem.MCE.ShowMCE();

            //TheSystem.MFE.ShowMFE();

            //------------------------------------------

            //setup choosen focal lengths (F1, F2 and F3)

            //ILDERow Surface2 = TheLDE.GetSurfaceAt(2);

            //Surface2.GetCellAt(12).DoubleValue = SelF1;

            //ILDERow Surface3 = TheLDE.GetSurfaceAt(3);

            //Surface3.GetCellAt(12).DoubleValue = SelF2;

            //ILDERow Surface4 = TheLDE.GetSurfaceAt(4);

            //Surface4.GetCellAt(12).DoubleValue = SelF3;

            // Save file
            TheSystem.SaveAs(TheApplication.SamplesDir + "\\API\\CS#\\BX.ZMX");
            //! [e19s07_cs]

            // TheSystem.LoadFile(TheApplication.SamplesDir + "\\Sequential\\Objectives\\BX.zmx");




            //! [e19s08_cs]
            // Run tool Convert Local To Global Coordinates to convert surface #2 to surface #35 to be globally referenced to surface #1
            //------------------------------------------
            //TheLDE.RunTool_ConvertLocalToGlobalCoordinates(2, 35, 1);
            //TheSystem.SaveAs(TheApplication.SamplesDir + "\\API\\CS#\\e19_Sample_Prism_Chain_GlobalCoordinate.ZMX");
            //------------------------------------------
            //! [e19s08_cs]

            //! [e19s09_cs]
            // Run tool Conver Global To Local Coordinates to convert surface #1 to surface #57 back to local coordinate.
            //------------------------------------------
            //TheLDE.RunTool_ConvertGlobalToLocalCoordinates(1, 57, 0);
            //TheSystem.SaveAs(TheApplication.SamplesDir + "\\API\\CS#\\e19_Sample_Prism_Chain_BackTo_LocalCoordinate.ZMX");
            //------------------------------------------
            //! [e19s09_cs]

            // Clean up
            FinishStandaloneApplication(TheApplication);
        }

        static void FinishStandaloneApplication(IZOSAPI_Application TheApplication)
        {
            // Note - TheApplication will close automatically when this application exits, so this isn't strictly necessary in most cases
            if (TheApplication != null)
            {
                TheApplication.CloseApplication();
            }
        }

        static void LogInfo(string message)
        {
            // TODO - add custom logging
            Console.WriteLine(message);
        }

        static void HandleError(string errorMessage)
        {
            // TODO - add custom error handling

            MessageBox.Show("Please close one of the two running Zemax Applications");

            throw new Exception(errorMessage);
        }

        private void Mintracktextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearListbutton_Click(object sender, EventArgs e)
        {
            MaxtrackList.Clear();

            CopyMaxtrackList.Clear();

            Maxtracktextbox.Clear();

            Mintracktextbox.Clear();

            Magmaxinput.Clear();

            MinMaginput.Clear();

            return;
        }


        private void DistancebackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            //DistanceprogressBar.Value = e.ProgressPercentage;

            DistanceChecklabel.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void DistancebackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                DistanceChecklabel.Text = "Proccessing Cancelled";
            }

            else
                if (e.Error != null)
                {
                    DistanceChecklabel.Text = e.Error.Message;
                }

                else
                {
                    //if (InputMax < InputMin)
                    //{
                    //    MessageBox.Show("Please Enter Maximum value to Max and Minimum to Min");

                    //    Magmaxinput.Text = " ";
                    //    MinMaginput.Text = " ";

                    //}

                    //else
                    //    if (!CopyMaxtrackList.Any())
                    //    {
                    //        MessageBox.Show("There is no possible combination for such inputs in Database");

                    //    }

                    //    else

                    //        if (InputMax > InputMin && CopyMaxtrackList.Any())
                    //        {
                    //            for (int y = 0; y < CopyMaxtrackList.Count; y++)
                    //            {
                    //                Distance1listBoxCheck.Items.Add(CopyMaxtrackList[y]);

                    //            }

                                // Maxtracktextbox.Text = e.Result.ToString();

                                Mintracktextbox.Text = e.Result.ToString();


                            //}

                  //Messagelabel.Text = "Sum = " + e.Result.ToString();

                }
        }

        private void DistancebackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            //InputMax = double.Parse(Magmaxinput.Text);

            //InputMin = double.Parse(MinMaginput.Text);

            //InputbeamDia = double.Parse(BeamDiaInput.Text);

            //EPDConstrainF1 = (double)1.5 * InputbeamDia;

            //EPDConstrainF3 = (double)(1 / InputMin) * 1.5 * InputbeamDia;

            //CopyInputMin = InputMin;

            //perm(focallength1, focallength2, focallength3, EPD1, EPD2, EPD3);

            //MessageBox.Show("Passed Permutation");

            //if (!MaxtrackList.Any())
            //{
            //    //Empty Magnification text box

            //    Magmaxinput.Text = " ";
            //    MinMaginput.Text = " ";
            //}

            //else
            //    if (MaxtrackList.Any())
            //    {
            //        MessageBox.Show("Passed Permutation 2nd ttime");

            //        for (int c = 0; c < F1List.Count; c++)
            //        {
            //            Thread.Sleep(10);


            //            for (double x = InputMin; x < InputMax; x += 0.1)
            //            {
            //                Distance1Add = Math.Round((double)F1List[c] + F2List[c] + ((F1List[c] * F2List[c]) / (InputMin * F3List[c])), 4);

            //                d1.Add(Distance1Add);


            //            }

            //            bool Distance1 = d1.All(elements => elements >= 10);

            //            if (Distance1 == true)
            //            {
            //                CopyMaxtrackList.Add(MaxtrackList[c]);

            //                CopyF1List.Add(F1List[c]);

            //                CopyF2List.Add(F2List[c]);

            //                CopyF3List.Add(F3List[c]);

            //                CopyEPD1List.Add(EPD1List[c]);

            //                CopyEPD2List.Add(EPD2List[c]);

            //                CopyEPD3List.Add(EPD3List[c]);

            //                CopyLensList1.Add(LensList1[c]);

            //                CopyLensList2.Add(LensList2[c]);

            //                CopyLensList3.Add(LensList3[c]);

            //                CopyvendorList1.Add(vendorList1[c]);

            //                CopyvendorList2.Add(vendorList2[c]);

            //                CopyvendorList3.Add(vendorList3[c]);

            //                DistancebackgroundWorker.ReportProgress(c);



            //            }

            //            if (DistancebackgroundWorker.CancellationPending)
            //            {
            //                e.Cancel = true;

            //                DistancebackgroundWorker.ReportProgress(0);

            //                return;
            //            }



            //        }

            //    }

            //if (InputMax < InputMin)
            //{
            //    MessageBox.Show("Please Enter Maximum value to Max and Minimum to Min");

            //    Magmaxinput.Text = " ";
            //    MinMaginput.Text = " ";

            //}

            //else
            //    if (!CopyMaxtrackList.Any())
            //    {
            //        MessageBox.Show("There is no possible combination for such inputs in Database");

            //    }

            //    else

            //        if (InputMax > InputMin && CopyMaxtrackList.Any())
            //        {
            //            for (int y = 0; y < CopyMaxtrackList.Count; y++)
            //            {
            //                Distance1listBoxCheck.Items.Add(CopyMaxtrackList[y]);

            //            }


            //        }


            //e.Result = CopyMaxtrackList.Min();
            //int sum = 0;

            //for(int i = 0; i < 100; i++)
            //{
            //    Thread.Sleep(100);

            //    sum = sum + i;

            //    DistancebackgroundWorker.ReportProgress(i);

            //    if (DistancebackgroundWorker.CancellationPending)
            //    {
            //        e.Cancel = true;

            //        DistancebackgroundWorker.ReportProgress(0);

            //        return;
            //    }

            //}


            //e.Result = sum;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            if(DistancebackgroundWorker.IsBusy)
            {
                DistancebackgroundWorker.CancelAsync();
            }
            else
            {
                DistanceChecklabel.Text = "No Operation to cancel";
            }
        }

        private void InputTextbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void InputTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void InputTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //if (InputIndividualMag == null && buttonMaginputs !=null)
                //{
                Input = double.Parse(InputTextbox.Text);

                if (MaxtrackRadioButton.Checked == true)
                {
                    // Take the values for focallengths, Lensparts and vendors as obtained at Maximum track length

                    MaxF1 = CopyF1List[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())];

                    MaxF2 = CopyF2List[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())];

                    MaxF3 = CopyF3List[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())];

                    LP1 = CopyLensList1[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())];

                    LP2 = CopyLensList2[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())];

                    LP3 = CopyLensList3[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())];

                    VendorL1 = CopyvendorList1[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())];

                    VendorL2 = CopyvendorList2[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())];

                    VendorL3 = CopyvendorList3[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Max())];

                    // Calculate here again all values needed for distance calculation

                    //Maxa1 = Math.Round((double)MaxF1 + MaxF2, 4);

                    //MaxMxratioMy = Math.Round((double)MaxF1 / MaxF3, 4);

                    //Maxa2 = Math.Round((double)MaxF2 + MaxF3, 4);

                    //Maxb1 = Math.Round((double)(MaxF1 * MaxF2 / MaxF3), 4);

                    //Maxb2 = Math.Round((double)(MaxF2 * MaxF3) / MaxF1, 4);

                    //MaxMx = Math.Round((double)-Maxa2 / Maxb2, 4);

                    //MaxMy = Math.Round((double)-Maxb1 / Maxa1, 4);


                    if ((Input <= InputMax) && (Input >= InputMin))
                    {

                        //Calculate d1 and d2 for the Input Magnification

                        Maxd1 = Math.Round((double)MaxF1 + MaxF2 + ((MaxF1 * MaxF2) / (Input * MaxF3)), 4);

                        Maxd2 = Math.Round((double)MaxF2 + MaxF3 + ((MaxF2 * MaxF3 * Input) / (MaxF1)), 4);

                        if ((Maxd1 >= -0.012) && (Maxd1 < 0))
                        {
                            Maxd1 = 0;
                        }
                        else

                            if ((Maxd2 >= -0.012) && (Maxd2 < 0))
                            {
                                Maxd2 = 0;
                            }

                        Distance1Testbox.Text = Maxd1.ToString();

                        Distance2Texbox.Text = Maxd2.ToString();

                        // Add distances to temporay list and use later to add these as thickness in Zemax LDE

                        Temp1.Add(Maxd1);

                        Temp2.Add(Maxd2);

                        // Add Lenspart to temporay list and use later to add these in Zemax LDE

                        //LPTemp1.Add(LP1);

                        //LPTemp2.Add(LP2);

                        //LPTemp3.Add(LP3);



                        //}

                        //else

                        if ((Input > InputMax) || (Input < InputMin))
                        {

                            MessageBox.Show("Please choose values between or equal to Max and Min Magnification");

                        }

                    }

                }

                else
                    if (MinimumTrackButton.Checked == true)
                    {
                        MinF1 = CopyF1List[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())];

                        MinF2 = CopyF2List[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())];

                        MinF3 = CopyF3List[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())];

                        LP1 = CopyLensList1[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())];

                        LP2 = CopyLensList2[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())];

                        LP3 = CopyLensList3[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())];

                        VendorL1 = CopyvendorList1[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())];

                        VendorL2 = CopyvendorList2[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())];

                        VendorL3 = CopyvendorList3[CopyMaxtrackList.IndexOf(CopyMaxtrackList.Min())];


                        // Calculate here again all values needed for distance calculation

                        //Mina1 = Math.Round((double)MinF1 + MinF2, 4);

                        //MinMxratioMy = Math.Round((double)MinF1 / MinF3, 4);

                        //Mina2 = Math.Round((double)MinF2 + MinF3, 4);

                        //Minb1 = Math.Round((double)(MinF1 * MinF2 / MinF3), 4);

                        //Minb2 = Math.Round((double)(MinF2 * MinF3) / MinF1, 4);

                        //MinMx = Math.Round((double)-Mina2 / Minb2, 4);

                        //MinMy = Math.Round((double)-Minb1 / Mina1, 4);


                        if ((Input <= InputMax) && (Input >= InputMin))
                        {


                            //Calculate d1 and d2 for the Input Magnification

                            Mind1 = Math.Round((double)MinF1 + MinF2 + ((MinF1 * MinF2) / (Input * MinF3)), 4);

                            Mind2 = Math.Round((double)MinF2 + MinF3 + ((MinF2 * MinF3 * Input) / (MinF1)), 4);

                            if ((Mind1 >= -0.012) && (Mind1 < 0))
                            {
                                Mind1 = 0;
                            }
                            else

                                if ((Mind2 >= -0.012) && (Mind2 < 0))
                                {
                                    Mind2 = 0;
                                }

                            Distance1Testbox.Text = Mind1.ToString();

                            Distance2Texbox.Text = Mind2.ToString();


                            // Add distances to temporay list and use later to add these as thickness in Zemax LDE

                            Temp1.Add(Mind1);

                            Temp2.Add(Mind2);

                            // Add Lensparts to temporay list and use later to add these in Zemax LDE

                            //LPTemp1.Add(LP1);

                            //LPTemp2.Add(LP2);

                            //LPTemp3.Add(LP3);

                        }

                        else

                            if ((Input > InputMax) || (Input < InputMin))
                            {

                                MessageBox.Show("Please choose values between or equal to Max and Min Magnification");

                            }

                    }

                //}

                //else
                //{
                //    MessageBox.Show("Please Enter the Magnifications");
                //}

            }

        }

        private void buttonMaginputs_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //if (!DistancebackgroundWorker.IsBusy)
                //{
                //    DistancebackgroundWorker.RunWorkerAsync();
                //}

                //else
                //{
                //    Messagelabel.Text = ("Busy processign please wait");

                //}

                InputMax = double.Parse(Magmaxinput.Text);

                InputMin = double.Parse(MinMaginput.Text);

                InputbeamDia = double.Parse(BeamDiaInput.Text);

                EPDConstrainF1 = (double)1.5 * InputbeamDia;

                EPDConstrainF3 = (double)(1 / InputMin) * 1.5 * InputbeamDia;

                CopyInputMin = InputMin;

                perm(focallength1, focallength2, focallength3, EPD1, EPD2, EPD3);



                if (!MaxtrackList.Any())
                {
                    //Empty Magnification text box

                    Magmaxinput.Text = " ";
                    MinMaginput.Text = " ";
                }

                else
                    if (MaxtrackList.Any())
                    {
                        for (int c = 0; c < F1List.Count; c++)
                        {

                            for (double x = InputMin; x < InputMax; x += 0.1)
                            {
                                Distance1Add = Math.Round((double)F1List[c] + F2List[c] + ((F1List[c] * F2List[c]) / (InputMin * F3List[c])), 4);

                                d1.Add(Distance1Add);


                            }

                            bool Distance1 = d1.All(elements => elements >= 10);

                            if (Distance1 == true)
                            {
                                CopyMaxtrackList.Add(MaxtrackList[c]);

                                CopyF1List.Add(F1List[c]);

                                CopyF2List.Add(F2List[c]);

                                CopyF3List.Add(F3List[c]);

                                CopyEPD1List.Add(EPD1List[c]);

                                CopyEPD2List.Add(EPD2List[c]);

                                CopyEPD3List.Add(EPD3List[c]);

                                CopyLensList1.Add(LensList1[c]);

                                CopyLensList2.Add(LensList2[c]);

                                CopyLensList3.Add(LensList3[c]);

                                CopyvendorList1.Add(vendorList1[c]);

                                CopyvendorList2.Add(vendorList2[c]);

                                CopyvendorList3.Add(vendorList3[c]);




                            }



                        }


                    }


                if (InputMax < InputMin)
                {
                    MessageBox.Show("Please Enter Maximum value to Max and Minimum to Min");

                    Magmaxinput.Text = " ";
                    MinMaginput.Text = " ";

                }

                else
                    if (!CopyMaxtrackList.Any())
                    {
                        MessageBox.Show("There is no possible combination for such inputs in Database");

                    }

                    else

                        if (InputMax > InputMin && CopyMaxtrackList.Any())
                        {
                            for (int y = 0; y < CopyMaxtrackList.Count; y++)
                            {
                                Distance1listBoxCheck.Items.Add(CopyMaxtrackList[y]);

                            }

                            Maxtracktextbox.Text = CopyMaxtrackList.Max().ToString();

                            Mintracktextbox.Text = CopyMaxtrackList.Min().ToString();


                        }

            }
        }





    }
}
