namespace Basicapp_start
{
    partial class RayTrace
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
            this.InputHeightLabel = new System.Windows.Forms.Label();
            this.InputHeighttextBox = new System.Windows.Forms.TextBox();
            this.InputAnglelabel = new System.Windows.Forms.Label();
            this.InputAngletextBox = new System.Windows.Forms.TextBox();
            this.OutputHeightlabel = new System.Windows.Forms.Label();
            this.OutputAnglelabel = new System.Windows.Forms.Label();
            this.OutputHeighttextBox = new System.Windows.Forms.TextBox();
            this.OutputAngletextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputHeightLabel
            // 
            this.InputHeightLabel.AutoSize = true;
            this.InputHeightLabel.Location = new System.Drawing.Point(45, 69);
            this.InputHeightLabel.Name = "InputHeightLabel";
            this.InputHeightLabel.Size = new System.Drawing.Size(65, 13);
            this.InputHeightLabel.TabIndex = 0;
            this.InputHeightLabel.Text = "Input Height";
            // 
            // InputHeighttextBox
            // 
            this.InputHeighttextBox.Location = new System.Drawing.Point(48, 95);
            this.InputHeighttextBox.Name = "InputHeighttextBox";
            this.InputHeighttextBox.ReadOnly = true;
            this.InputHeighttextBox.Size = new System.Drawing.Size(100, 20);
            this.InputHeighttextBox.TabIndex = 1;
            // 
            // InputAnglelabel
            // 
            this.InputAnglelabel.AutoSize = true;
            this.InputAnglelabel.Location = new System.Drawing.Point(48, 138);
            this.InputAnglelabel.Name = "InputAnglelabel";
            this.InputAnglelabel.Size = new System.Drawing.Size(61, 13);
            this.InputAnglelabel.TabIndex = 2;
            this.InputAnglelabel.Text = "Input Angle";
            // 
            // InputAngletextBox
            // 
            this.InputAngletextBox.Location = new System.Drawing.Point(51, 180);
            this.InputAngletextBox.Name = "InputAngletextBox";
            this.InputAngletextBox.ReadOnly = true;
            this.InputAngletextBox.Size = new System.Drawing.Size(100, 20);
            this.InputAngletextBox.TabIndex = 3;
            // 
            // OutputHeightlabel
            // 
            this.OutputHeightlabel.AutoSize = true;
            this.OutputHeightlabel.Location = new System.Drawing.Point(503, 69);
            this.OutputHeightlabel.Name = "OutputHeightlabel";
            this.OutputHeightlabel.Size = new System.Drawing.Size(73, 13);
            this.OutputHeightlabel.TabIndex = 4;
            this.OutputHeightlabel.Text = "Output Height";
            // 
            // OutputAnglelabel
            // 
            this.OutputAnglelabel.AutoSize = true;
            this.OutputAnglelabel.Location = new System.Drawing.Point(503, 138);
            this.OutputAnglelabel.Name = "OutputAnglelabel";
            this.OutputAnglelabel.Size = new System.Drawing.Size(69, 13);
            this.OutputAnglelabel.TabIndex = 5;
            this.OutputAnglelabel.Text = "Output Angle";
            // 
            // OutputHeighttextBox
            // 
            this.OutputHeighttextBox.Location = new System.Drawing.Point(492, 95);
            this.OutputHeighttextBox.Name = "OutputHeighttextBox";
            this.OutputHeighttextBox.ReadOnly = true;
            this.OutputHeighttextBox.Size = new System.Drawing.Size(100, 20);
            this.OutputHeighttextBox.TabIndex = 6;
            // 
            // OutputAngletextBox
            // 
            this.OutputAngletextBox.Location = new System.Drawing.Point(492, 180);
            this.OutputAngletextBox.Name = "OutputAngletextBox";
            this.OutputAngletextBox.ReadOnly = true;
            this.OutputAngletextBox.Size = new System.Drawing.Size(100, 20);
            this.OutputAngletextBox.TabIndex = 7;
            // 
            // RayTrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 567);
            this.Controls.Add(this.OutputAngletextBox);
            this.Controls.Add(this.OutputHeighttextBox);
            this.Controls.Add(this.OutputAnglelabel);
            this.Controls.Add(this.OutputHeightlabel);
            this.Controls.Add(this.InputAngletextBox);
            this.Controls.Add(this.InputAnglelabel);
            this.Controls.Add(this.InputHeighttextBox);
            this.Controls.Add(this.InputHeightLabel);
            this.Name = "RayTrace";
            this.Text = "RayTrace";
            this.Load += new System.EventHandler(this.RayTrace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputHeightLabel;
        private System.Windows.Forms.TextBox InputHeighttextBox;
        private System.Windows.Forms.Label InputAnglelabel;
        private System.Windows.Forms.TextBox InputAngletextBox;
        private System.Windows.Forms.Label OutputHeightlabel;
        private System.Windows.Forms.Label OutputAnglelabel;
        private System.Windows.Forms.TextBox OutputHeighttextBox;
        private System.Windows.Forms.TextBox OutputAngletextBox;
    }
}