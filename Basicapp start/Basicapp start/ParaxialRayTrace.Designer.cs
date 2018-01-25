namespace Basicapp_start
{
    partial class ParaxialRayTrace
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
            this.ParaxialOutputAngletextBox = new System.Windows.Forms.TextBox();
            this.ParaxialOutputHeighttextBox = new System.Windows.Forms.TextBox();
            this.ParaxialOutputAnglelabel = new System.Windows.Forms.Label();
            this.ParaxialOutputHeightlabel = new System.Windows.Forms.Label();
            this.ParaxialInputAngletextBox = new System.Windows.Forms.TextBox();
            this.ParaxialInputAnglelabel = new System.Windows.Forms.Label();
            this.ParaxialInputHeighttextBox = new System.Windows.Forms.TextBox();
            this.ParaxialInputHeightLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ParaxialOutputAngletextBox
            // 
            this.ParaxialOutputAngletextBox.Location = new System.Drawing.Point(537, 188);
            this.ParaxialOutputAngletextBox.Name = "ParaxialOutputAngletextBox";
            this.ParaxialOutputAngletextBox.ReadOnly = true;
            this.ParaxialOutputAngletextBox.Size = new System.Drawing.Size(100, 20);
            this.ParaxialOutputAngletextBox.TabIndex = 15;
            // 
            // ParaxialOutputHeighttextBox
            // 
            this.ParaxialOutputHeighttextBox.Location = new System.Drawing.Point(537, 103);
            this.ParaxialOutputHeighttextBox.Name = "ParaxialOutputHeighttextBox";
            this.ParaxialOutputHeighttextBox.ReadOnly = true;
            this.ParaxialOutputHeighttextBox.Size = new System.Drawing.Size(100, 20);
            this.ParaxialOutputHeighttextBox.TabIndex = 14;
            // 
            // ParaxialOutputAnglelabel
            // 
            this.ParaxialOutputAnglelabel.AutoSize = true;
            this.ParaxialOutputAnglelabel.Location = new System.Drawing.Point(534, 146);
            this.ParaxialOutputAnglelabel.Name = "ParaxialOutputAnglelabel";
            this.ParaxialOutputAnglelabel.Size = new System.Drawing.Size(109, 13);
            this.ParaxialOutputAnglelabel.TabIndex = 13;
            this.ParaxialOutputAnglelabel.Text = "Paraxial Output Angle";
            // 
            // ParaxialOutputHeightlabel
            // 
            this.ParaxialOutputHeightlabel.AutoSize = true;
            this.ParaxialOutputHeightlabel.Location = new System.Drawing.Point(534, 77);
            this.ParaxialOutputHeightlabel.Name = "ParaxialOutputHeightlabel";
            this.ParaxialOutputHeightlabel.Size = new System.Drawing.Size(113, 13);
            this.ParaxialOutputHeightlabel.TabIndex = 12;
            this.ParaxialOutputHeightlabel.Text = "Paraxial Output Height";
            // 
            // ParaxialInputAngletextBox
            // 
            this.ParaxialInputAngletextBox.Location = new System.Drawing.Point(82, 188);
            this.ParaxialInputAngletextBox.Name = "ParaxialInputAngletextBox";
            this.ParaxialInputAngletextBox.ReadOnly = true;
            this.ParaxialInputAngletextBox.Size = new System.Drawing.Size(100, 20);
            this.ParaxialInputAngletextBox.TabIndex = 11;
            // 
            // ParaxialInputAnglelabel
            // 
            this.ParaxialInputAnglelabel.AutoSize = true;
            this.ParaxialInputAnglelabel.Location = new System.Drawing.Point(79, 146);
            this.ParaxialInputAnglelabel.Name = "ParaxialInputAnglelabel";
            this.ParaxialInputAnglelabel.Size = new System.Drawing.Size(101, 13);
            this.ParaxialInputAnglelabel.TabIndex = 10;
            this.ParaxialInputAnglelabel.Text = "Paraxial Input Angle";
            // 
            // ParaxialInputHeighttextBox
            // 
            this.ParaxialInputHeighttextBox.Location = new System.Drawing.Point(79, 103);
            this.ParaxialInputHeighttextBox.Name = "ParaxialInputHeighttextBox";
            this.ParaxialInputHeighttextBox.ReadOnly = true;
            this.ParaxialInputHeighttextBox.Size = new System.Drawing.Size(100, 20);
            this.ParaxialInputHeighttextBox.TabIndex = 9;
            // 
            // ParaxialInputHeightLabel
            // 
            this.ParaxialInputHeightLabel.AutoSize = true;
            this.ParaxialInputHeightLabel.Location = new System.Drawing.Point(76, 77);
            this.ParaxialInputHeightLabel.Name = "ParaxialInputHeightLabel";
            this.ParaxialInputHeightLabel.Size = new System.Drawing.Size(105, 13);
            this.ParaxialInputHeightLabel.TabIndex = 8;
            this.ParaxialInputHeightLabel.Text = "Paraxial Input Height";
            this.ParaxialInputHeightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(392, 236);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(423, 229);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // ParaxialRayTrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 535);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ParaxialOutputAngletextBox);
            this.Controls.Add(this.ParaxialOutputHeighttextBox);
            this.Controls.Add(this.ParaxialOutputAnglelabel);
            this.Controls.Add(this.ParaxialOutputHeightlabel);
            this.Controls.Add(this.ParaxialInputAngletextBox);
            this.Controls.Add(this.ParaxialInputAnglelabel);
            this.Controls.Add(this.ParaxialInputHeighttextBox);
            this.Controls.Add(this.ParaxialInputHeightLabel);
            this.Name = "ParaxialRayTrace";
            this.Text = "ParaxialRayTrace";
            this.Load += new System.EventHandler(this.ParaxialRayTrace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ParaxialOutputAngletextBox;
        private System.Windows.Forms.TextBox ParaxialOutputHeighttextBox;
        private System.Windows.Forms.Label ParaxialOutputAnglelabel;
        private System.Windows.Forms.Label ParaxialOutputHeightlabel;
        private System.Windows.Forms.TextBox ParaxialInputAngletextBox;
        private System.Windows.Forms.Label ParaxialInputAnglelabel;
        private System.Windows.Forms.TextBox ParaxialInputHeighttextBox;
        private System.Windows.Forms.Label ParaxialInputHeightLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}