namespace Basicapp_start
{
    partial class ZoomAppForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ZemaxbackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.Zemaxtimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graphsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CameraLensbutton = new System.Windows.Forms.Button();
            this.LaserFocusbutton = new System.Windows.Forms.Button();
            this.BeamExbutton = new System.Windows.Forms.Button();
            this.Homebutton = new System.Windows.Forms.Button();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.laserFocussingControl1 = new Basicapp_start.LaserFocussingControl();
            this.beamExpanderControl1 = new Basicapp_start.BeamExpanderControl();
            this.homeUserControl1 = new Basicapp_start.HomeUserControl();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ZemaxbackgroundWorker
            // 
            this.ZemaxbackgroundWorker.WorkerReportsProgress = true;
            this.ZemaxbackgroundWorker.WorkerSupportsCancellation = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1163, 28);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // graphsToolStripMenuItem
            // 
            this.graphsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.graphsToolStripMenuItem.Name = "graphsToolStripMenuItem";
            this.graphsToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.graphsToolStripMenuItem.Text = "File";
            this.graphsToolStripMenuItem.Click += new System.EventHandler(this.graphsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.CameraLensbutton);
            this.panel1.Controls.Add(this.LaserFocusbutton);
            this.panel1.Controls.Add(this.BeamExbutton);
            this.panel1.Controls.Add(this.Homebutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 688);
            this.panel1.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 58);
            this.panel2.TabIndex = 48;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // CameraLensbutton
            // 
            this.CameraLensbutton.Location = new System.Drawing.Point(0, 291);
            this.CameraLensbutton.Name = "CameraLensbutton";
            this.CameraLensbutton.Size = new System.Drawing.Size(213, 58);
            this.CameraLensbutton.TabIndex = 3;
            this.CameraLensbutton.Text = "Camera Lens";
            this.CameraLensbutton.UseVisualStyleBackColor = true;
            this.CameraLensbutton.Click += new System.EventHandler(this.CameraLensbutton_Click);
            // 
            // LaserFocusbutton
            // 
            this.LaserFocusbutton.Location = new System.Drawing.Point(0, 215);
            this.LaserFocusbutton.Name = "LaserFocusbutton";
            this.LaserFocusbutton.Size = new System.Drawing.Size(213, 58);
            this.LaserFocusbutton.TabIndex = 2;
            this.LaserFocusbutton.Text = "Laser Focussing";
            this.LaserFocusbutton.UseVisualStyleBackColor = true;
            this.LaserFocusbutton.Click += new System.EventHandler(this.LaserFocusbutton_Click);
            // 
            // BeamExbutton
            // 
            this.BeamExbutton.Location = new System.Drawing.Point(0, 130);
            this.BeamExbutton.Name = "BeamExbutton";
            this.BeamExbutton.Size = new System.Drawing.Size(213, 58);
            this.BeamExbutton.TabIndex = 1;
            this.BeamExbutton.Text = "Beam Expander";
            this.BeamExbutton.UseVisualStyleBackColor = true;
            this.BeamExbutton.Click += new System.EventHandler(this.BeamExbutton_Click);
            // 
            // Homebutton
            // 
            this.Homebutton.Location = new System.Drawing.Point(0, 51);
            this.Homebutton.Name = "Homebutton";
            this.Homebutton.Size = new System.Drawing.Size(213, 58);
            this.Homebutton.TabIndex = 0;
            this.Homebutton.Text = "Home";
            this.Homebutton.UseVisualStyleBackColor = true;
            this.Homebutton.Click += new System.EventHandler(this.Homebutton_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(195, 6);
            // 
            // laserFocussingControl1
            // 
            this.laserFocussingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laserFocussingControl1.Location = new System.Drawing.Point(212, 28);
            this.laserFocussingControl1.Name = "laserFocussingControl1";
            this.laserFocussingControl1.Size = new System.Drawing.Size(951, 688);
            this.laserFocussingControl1.TabIndex = 50;
            this.laserFocussingControl1.Load += new System.EventHandler(this.laserFocussingControl1_Load);
            // 
            // beamExpanderControl1
            // 
            this.beamExpanderControl1.BackColor = System.Drawing.Color.MintCream;
            this.beamExpanderControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beamExpanderControl1.Location = new System.Drawing.Point(212, 28);
            this.beamExpanderControl1.Name = "beamExpanderControl1";
            this.beamExpanderControl1.Size = new System.Drawing.Size(951, 688);
            this.beamExpanderControl1.TabIndex = 49;
            // 
            // homeUserControl1
            // 
            this.homeUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeUserControl1.Location = new System.Drawing.Point(212, 28);
            this.homeUserControl1.Name = "homeUserControl1";
            this.homeUserControl1.Size = new System.Drawing.Size(951, 688);
            this.homeUserControl1.TabIndex = 48;
            // 
            // ZoomAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 716);
            this.Controls.Add(this.laserFocussingControl1);
            this.Controls.Add(this.beamExpanderControl1);
            this.Controls.Add(this.homeUserControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ZoomAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoom App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker ZemaxbackgroundWorker;
        private System.Windows.Forms.Timer Zemaxtimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem graphsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CameraLensbutton;
        private System.Windows.Forms.Button LaserFocusbutton;
        private System.Windows.Forms.Button BeamExbutton;
        private System.Windows.Forms.Button Homebutton;
        private HomeUserControl homeUserControl1;
        private BeamExpanderControl beamExpanderControl1;
        private LaserFocussingControl laserFocussingControl1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

