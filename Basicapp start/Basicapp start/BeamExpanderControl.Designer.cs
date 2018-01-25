namespace Basicapp_start
{
    partial class BeamExpanderControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Partnumberbutton = new System.Windows.Forms.Button();
            this.Seefocallengthbutton = new System.Windows.Forms.Button();
            this.ZemaxInitializer = new System.Windows.Forms.Button();
            this.MinimumTrackButton = new System.Windows.Forms.RadioButton();
            this.MaxtrackRadioButton = new System.Windows.Forms.RadioButton();
            this.Distance2Texbox = new System.Windows.Forms.TextBox();
            this.Distance1Testbox = new System.Windows.Forms.TextBox();
            this.Distance2Label = new System.Windows.Forms.Label();
            this.Distance1Label = new System.Windows.Forms.Label();
            this.ChosenTrackLabel = new System.Windows.Forms.Label();
            this.InputTextbox = new System.Windows.Forms.TextBox();
            this.InputIndividualMag = new System.Windows.Forms.Button();
            this.Mintracktextbox = new System.Windows.Forms.TextBox();
            this.Maxtracktextbox = new System.Windows.Forms.TextBox();
            this.BeamDiaLable = new System.Windows.Forms.Label();
            this.BeamDiaInput = new System.Windows.Forms.TextBox();
            this.MinMagLabel = new System.Windows.Forms.Label();
            this.MaxMagLabel = new System.Windows.Forms.Label();
            this.MinMaginput = new System.Windows.Forms.TextBox();
            this.Magmaxinput = new System.Windows.Forms.TextBox();
            this.buttonMaginputs = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graphsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomCurvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.analyzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rayTraceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraxialRaytraceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.siedelCoefficientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearListbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.DistanceprogressBar = new System.Windows.Forms.ProgressBar();
            this.DistanceChecklabel = new System.Windows.Forms.Label();
            this.DistancebackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.Messagelabel = new System.Windows.Forms.Label();
            this.Distance1listBoxCheck = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Partnumberbutton
            // 
            this.Partnumberbutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.Partnumberbutton.Location = new System.Drawing.Point(184, 306);
            this.Partnumberbutton.Name = "Partnumberbutton";
            this.Partnumberbutton.Size = new System.Drawing.Size(86, 51);
            this.Partnumberbutton.TabIndex = 61;
            this.Partnumberbutton.Text = "See Part number and Vendor";
            this.Partnumberbutton.UseVisualStyleBackColor = true;
            this.Partnumberbutton.Click += new System.EventHandler(this.Partnumberbutton_Click);
            // 
            // Seefocallengthbutton
            // 
            this.Seefocallengthbutton.Location = new System.Drawing.Point(184, 234);
            this.Seefocallengthbutton.Name = "Seefocallengthbutton";
            this.Seefocallengthbutton.Size = new System.Drawing.Size(86, 47);
            this.Seefocallengthbutton.TabIndex = 60;
            this.Seefocallengthbutton.Text = "See Focal Lengths";
            this.Seefocallengthbutton.UseVisualStyleBackColor = true;
            this.Seefocallengthbutton.Click += new System.EventHandler(this.Seefocallengthbutton_Click);
            // 
            // ZemaxInitializer
            // 
            this.ZemaxInitializer.Location = new System.Drawing.Point(331, 276);
            this.ZemaxInitializer.Name = "ZemaxInitializer";
            this.ZemaxInitializer.Size = new System.Drawing.Size(85, 43);
            this.ZemaxInitializer.TabIndex = 59;
            this.ZemaxInitializer.Text = "Zemax Initializer";
            this.ZemaxInitializer.UseVisualStyleBackColor = true;
            this.ZemaxInitializer.Click += new System.EventHandler(this.ZemaxInitializer_Click);
            // 
            // MinimumTrackButton
            // 
            this.MinimumTrackButton.AutoSize = true;
            this.MinimumTrackButton.Location = new System.Drawing.Point(40, 289);
            this.MinimumTrackButton.Name = "MinimumTrackButton";
            this.MinimumTrackButton.Size = new System.Drawing.Size(94, 17);
            this.MinimumTrackButton.TabIndex = 58;
            this.MinimumTrackButton.TabStop = true;
            this.MinimumTrackButton.Text = "MinimumTrack";
            this.MinimumTrackButton.UseVisualStyleBackColor = true;
            this.MinimumTrackButton.CheckedChanged += new System.EventHandler(this.MinimumTrackButton_CheckedChanged);
            // 
            // MaxtrackRadioButton
            // 
            this.MaxtrackRadioButton.AutoSize = true;
            this.MaxtrackRadioButton.Location = new System.Drawing.Point(40, 210);
            this.MaxtrackRadioButton.Name = "MaxtrackRadioButton";
            this.MaxtrackRadioButton.Size = new System.Drawing.Size(97, 17);
            this.MaxtrackRadioButton.TabIndex = 57;
            this.MaxtrackRadioButton.TabStop = true;
            this.MaxtrackRadioButton.Text = "MaximumTrack";
            this.MaxtrackRadioButton.UseVisualStyleBackColor = true;
            // 
            // Distance2Texbox
            // 
            this.Distance2Texbox.Location = new System.Drawing.Point(529, 226);
            this.Distance2Texbox.Name = "Distance2Texbox";
            this.Distance2Texbox.Size = new System.Drawing.Size(146, 20);
            this.Distance2Texbox.TabIndex = 56;
            // 
            // Distance1Testbox
            // 
            this.Distance1Testbox.Location = new System.Drawing.Point(331, 226);
            this.Distance1Testbox.Name = "Distance1Testbox";
            this.Distance1Testbox.Size = new System.Drawing.Size(166, 20);
            this.Distance1Testbox.TabIndex = 55;
            // 
            // Distance2Label
            // 
            this.Distance2Label.AutoSize = true;
            this.Distance2Label.Location = new System.Drawing.Point(513, 174);
            this.Distance2Label.Name = "Distance2Label";
            this.Distance2Label.Size = new System.Drawing.Size(149, 13);
            this.Distance2Label.TabIndex = 54;
            this.Distance2Label.Text = "Distance from 2nd to 3rd Lens";
            // 
            // Distance1Label
            // 
            this.Distance1Label.AutoSize = true;
            this.Distance1Label.Location = new System.Drawing.Point(328, 174);
            this.Distance1Label.Name = "Distance1Label";
            this.Distance1Label.Size = new System.Drawing.Size(169, 13);
            this.Distance1Label.TabIndex = 53;
            this.Distance1Label.Text = "Distance From 1st to Second lens ";
            // 
            // ChosenTrackLabel
            // 
            this.ChosenTrackLabel.AutoSize = true;
            this.ChosenTrackLabel.Location = new System.Drawing.Point(423, 56);
            this.ChosenTrackLabel.Name = "ChosenTrackLabel";
            this.ChosenTrackLabel.Size = new System.Drawing.Size(177, 13);
            this.ChosenTrackLabel.TabIndex = 52;
            this.ChosenTrackLabel.Text = "Magnification Input for chosen track";
            // 
            // InputTextbox
            // 
            this.InputTextbox.Location = new System.Drawing.Point(452, 104);
            this.InputTextbox.Name = "InputTextbox";
            this.InputTextbox.Size = new System.Drawing.Size(100, 20);
            this.InputTextbox.TabIndex = 51;
            this.InputTextbox.TextChanged += new System.EventHandler(this.InputTextbox_TextChanged);
            this.InputTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTextbox_KeyDown);
            this.InputTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextbox_KeyPress);
            // 
            // InputIndividualMag
            // 
            this.InputIndividualMag.Location = new System.Drawing.Point(330, 98);
            this.InputIndividualMag.Name = "InputIndividualMag";
            this.InputIndividualMag.Size = new System.Drawing.Size(75, 29);
            this.InputIndividualMag.TabIndex = 50;
            this.InputIndividualMag.Text = "Input";
            this.InputIndividualMag.UseVisualStyleBackColor = true;
            this.InputIndividualMag.Click += new System.EventHandler(this.InputIndividualMag_Click);
            // 
            // Mintracktextbox
            // 
            this.Mintracktextbox.Location = new System.Drawing.Point(44, 323);
            this.Mintracktextbox.Name = "Mintracktextbox";
            this.Mintracktextbox.Size = new System.Drawing.Size(100, 20);
            this.Mintracktextbox.TabIndex = 49;
            this.Mintracktextbox.TextChanged += new System.EventHandler(this.Mintracktextbox_TextChanged);
            // 
            // Maxtracktextbox
            // 
            this.Maxtracktextbox.Location = new System.Drawing.Point(40, 249);
            this.Maxtracktextbox.Name = "Maxtracktextbox";
            this.Maxtracktextbox.Size = new System.Drawing.Size(100, 20);
            this.Maxtracktextbox.TabIndex = 48;
            // 
            // BeamDiaLable
            // 
            this.BeamDiaLable.AutoSize = true;
            this.BeamDiaLable.Location = new System.Drawing.Point(38, 123);
            this.BeamDiaLable.Name = "BeamDiaLable";
            this.BeamDiaLable.Size = new System.Drawing.Size(106, 13);
            this.BeamDiaLable.TabIndex = 47;
            this.BeamDiaLable.Text = "Input Beam Diameter";
            // 
            // BeamDiaInput
            // 
            this.BeamDiaInput.Location = new System.Drawing.Point(40, 154);
            this.BeamDiaInput.Name = "BeamDiaInput";
            this.BeamDiaInput.Size = new System.Drawing.Size(100, 20);
            this.BeamDiaInput.TabIndex = 46;
            this.BeamDiaInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BeamDiaInput_KeyPress);
            // 
            // MinMagLabel
            // 
            this.MinMagLabel.AutoSize = true;
            this.MinMagLabel.Location = new System.Drawing.Point(193, 48);
            this.MinMagLabel.Name = "MinMagLabel";
            this.MinMagLabel.Size = new System.Drawing.Size(90, 13);
            this.MinMagLabel.TabIndex = 45;
            this.MinMagLabel.Text = "Min Magnification";
            // 
            // MaxMagLabel
            // 
            this.MaxMagLabel.AutoSize = true;
            this.MaxMagLabel.Location = new System.Drawing.Point(38, 48);
            this.MaxMagLabel.Name = "MaxMagLabel";
            this.MaxMagLabel.Size = new System.Drawing.Size(93, 13);
            this.MaxMagLabel.TabIndex = 44;
            this.MaxMagLabel.Text = "Max Magnification";
            // 
            // MinMaginput
            // 
            this.MinMaginput.Location = new System.Drawing.Point(192, 89);
            this.MinMaginput.Name = "MinMaginput";
            this.MinMaginput.Size = new System.Drawing.Size(100, 20);
            this.MinMaginput.TabIndex = 43;
            this.MinMaginput.TextChanged += new System.EventHandler(this.MinMaginput_TextChanged);
            this.MinMaginput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinMaginput_KeyPress);
            // 
            // Magmaxinput
            // 
            this.Magmaxinput.Location = new System.Drawing.Point(40, 89);
            this.Magmaxinput.Name = "Magmaxinput";
            this.Magmaxinput.Size = new System.Drawing.Size(100, 20);
            this.Magmaxinput.TabIndex = 42;
            this.Magmaxinput.TextChanged += new System.EventHandler(this.Magmaxinput_TextChanged);
            this.Magmaxinput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Magmaxinput_KeyPress);
            // 
            // buttonMaginputs
            // 
            this.buttonMaginputs.Location = new System.Drawing.Point(192, 152);
            this.buttonMaginputs.Name = "buttonMaginputs";
            this.buttonMaginputs.Size = new System.Drawing.Size(106, 23);
            this.buttonMaginputs.TabIndex = 41;
            this.buttonMaginputs.Text = "Enter Input mags";
            this.buttonMaginputs.UseVisualStyleBackColor = true;
            this.buttonMaginputs.Click += new System.EventHandler(this.buttonMaginputs_Click);
            this.buttonMaginputs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonMaginputs_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphsToolStripMenuItem,
            this.analyzeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1502, 24);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // graphsToolStripMenuItem
            // 
            this.graphsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomCurvesToolStripMenuItem,
            this.toolStripSeparator1});
            this.graphsToolStripMenuItem.Name = "graphsToolStripMenuItem";
            this.graphsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.graphsToolStripMenuItem.Text = "Graphs";
            // 
            // zoomCurvesToolStripMenuItem
            // 
            this.zoomCurvesToolStripMenuItem.Name = "zoomCurvesToolStripMenuItem";
            this.zoomCurvesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.zoomCurvesToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.zoomCurvesToolStripMenuItem.Text = "Zoom&Curves";
            this.zoomCurvesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.zoomCurvesToolStripMenuItem.Click += new System.EventHandler(this.zoomCurvesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // analyzeToolStripMenuItem
            // 
            this.analyzeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rayTraceToolStripMenuItem,
            this.toolStripSeparator3,
            this.siedelCoefficientsToolStripMenuItem});
            this.analyzeToolStripMenuItem.Name = "analyzeToolStripMenuItem";
            this.analyzeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.analyzeToolStripMenuItem.Text = "Analyze";
            // 
            // rayTraceToolStripMenuItem
            // 
            this.rayTraceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paraxialRaytraceToolStripMenuItem});
            this.rayTraceToolStripMenuItem.Name = "rayTraceToolStripMenuItem";
            this.rayTraceToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.rayTraceToolStripMenuItem.Text = "RayTrace";
            this.rayTraceToolStripMenuItem.Click += new System.EventHandler(this.rayTraceToolStripMenuItem_Click);
            // 
            // paraxialRaytraceToolStripMenuItem
            // 
            this.paraxialRaytraceToolStripMenuItem.Name = "paraxialRaytraceToolStripMenuItem";
            this.paraxialRaytraceToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.paraxialRaytraceToolStripMenuItem.Text = "Paraxial Raytrace";
            this.paraxialRaytraceToolStripMenuItem.Click += new System.EventHandler(this.paraxialRaytraceToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(168, 6);
            // 
            // siedelCoefficientsToolStripMenuItem
            // 
            this.siedelCoefficientsToolStripMenuItem.Name = "siedelCoefficientsToolStripMenuItem";
            this.siedelCoefficientsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.siedelCoefficientsToolStripMenuItem.Text = "Siedel Coefficients";
            // 
            // ClearListbutton
            // 
            this.ClearListbutton.Location = new System.Drawing.Point(192, 182);
            this.ClearListbutton.Name = "ClearListbutton";
            this.ClearListbutton.Size = new System.Drawing.Size(106, 23);
            this.ClearListbutton.TabIndex = 63;
            this.ClearListbutton.Text = "Clear List";
            this.ClearListbutton.UseMnemonic = false;
            this.ClearListbutton.UseVisualStyleBackColor = true;
            this.ClearListbutton.Click += new System.EventHandler(this.ClearListbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(281, 462);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 65;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // DistanceprogressBar
            // 
            this.DistanceprogressBar.Location = new System.Drawing.Point(14, 423);
            this.DistanceprogressBar.Name = "DistanceprogressBar";
            this.DistanceprogressBar.Size = new System.Drawing.Size(342, 23);
            this.DistanceprogressBar.TabIndex = 66;
            // 
            // DistanceChecklabel
            // 
            this.DistanceChecklabel.AutoSize = true;
            this.DistanceChecklabel.Location = new System.Drawing.Point(14, 471);
            this.DistanceChecklabel.Name = "DistanceChecklabel";
            this.DistanceChecklabel.Size = new System.Drawing.Size(35, 13);
            this.DistanceChecklabel.TabIndex = 67;
            this.DistanceChecklabel.Text = "label1";
            // 
            // DistancebackgroundWorker
            // 
            this.DistancebackgroundWorker.WorkerReportsProgress = true;
            this.DistancebackgroundWorker.WorkerSupportsCancellation = true;
            this.DistancebackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DistancebackgroundWorker_DoWork);
            this.DistancebackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.DistancebackgroundWorker_ProgressChanged);
            this.DistancebackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DistancebackgroundWorker_RunWorkerCompleted);
            // 
            // Messagelabel
            // 
            this.Messagelabel.AutoSize = true;
            this.Messagelabel.Location = new System.Drawing.Point(14, 519);
            this.Messagelabel.Name = "Messagelabel";
            this.Messagelabel.Size = new System.Drawing.Size(35, 13);
            this.Messagelabel.TabIndex = 68;
            this.Messagelabel.Text = "label1";
            // 
            // Distance1listBoxCheck
            // 
            this.Distance1listBoxCheck.FormattingEnabled = true;
            this.Distance1listBoxCheck.Location = new System.Drawing.Point(468, 276);
            this.Distance1listBoxCheck.MultiColumn = true;
            this.Distance1listBoxCheck.Name = "Distance1listBoxCheck";
            this.Distance1listBoxCheck.ScrollAlwaysVisible = true;
            this.Distance1listBoxCheck.Size = new System.Drawing.Size(943, 433);
            this.Distance1listBoxCheck.TabIndex = 69;
            // 
            // BeamExpanderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.Distance1listBoxCheck);
            this.Controls.Add(this.Messagelabel);
            this.Controls.Add(this.DistanceChecklabel);
            this.Controls.Add(this.DistanceprogressBar);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.ClearListbutton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Partnumberbutton);
            this.Controls.Add(this.Seefocallengthbutton);
            this.Controls.Add(this.ZemaxInitializer);
            this.Controls.Add(this.MinimumTrackButton);
            this.Controls.Add(this.MaxtrackRadioButton);
            this.Controls.Add(this.Distance2Texbox);
            this.Controls.Add(this.Distance1Testbox);
            this.Controls.Add(this.Distance2Label);
            this.Controls.Add(this.Distance1Label);
            this.Controls.Add(this.ChosenTrackLabel);
            this.Controls.Add(this.InputTextbox);
            this.Controls.Add(this.InputIndividualMag);
            this.Controls.Add(this.Mintracktextbox);
            this.Controls.Add(this.Maxtracktextbox);
            this.Controls.Add(this.BeamDiaLable);
            this.Controls.Add(this.BeamDiaInput);
            this.Controls.Add(this.MinMagLabel);
            this.Controls.Add(this.MaxMagLabel);
            this.Controls.Add(this.MinMaginput);
            this.Controls.Add(this.Magmaxinput);
            this.Controls.Add(this.buttonMaginputs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BeamExpanderControl";
            this.Size = new System.Drawing.Size(1502, 927);
            this.Load += new System.EventHandler(this.BeamExpanderControl_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Partnumberbutton;
        private System.Windows.Forms.Button Seefocallengthbutton;
        private System.Windows.Forms.Button ZemaxInitializer;
        public System.Windows.Forms.RadioButton MinimumTrackButton;
        public System.Windows.Forms.RadioButton MaxtrackRadioButton;
        private System.Windows.Forms.TextBox Distance2Texbox;
        private System.Windows.Forms.TextBox Distance1Testbox;
        private System.Windows.Forms.Label Distance2Label;
        private System.Windows.Forms.Label Distance1Label;
        private System.Windows.Forms.Label ChosenTrackLabel;
        private System.Windows.Forms.TextBox InputTextbox;
        public System.Windows.Forms.TextBox Mintracktextbox;
        public System.Windows.Forms.TextBox Maxtracktextbox;
        private System.Windows.Forms.Label BeamDiaLable;
        public System.Windows.Forms.TextBox BeamDiaInput;
        private System.Windows.Forms.Label MinMagLabel;
        private System.Windows.Forms.Label MaxMagLabel;
        public System.Windows.Forms.TextBox MinMaginput;
        public System.Windows.Forms.TextBox Magmaxinput;
        public System.Windows.Forms.Button buttonMaginputs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem graphsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomCurvesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem analyzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rayTraceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem siedelCoefficientsToolStripMenuItem;
        public System.Windows.Forms.Button InputIndividualMag;
        private System.Windows.Forms.Button ClearListbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.ProgressBar DistanceprogressBar;
        private System.Windows.Forms.Label DistanceChecklabel;
        private System.ComponentModel.BackgroundWorker DistancebackgroundWorker;
        private System.Windows.Forms.Label Messagelabel;
        private System.Windows.Forms.ListBox Distance1listBoxCheck;
        private System.Windows.Forms.ToolStripMenuItem paraxialRaytraceToolStripMenuItem;
    }
}
