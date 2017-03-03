namespace CMPE1600_ICA08
{
    partial class Form1
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
            this.UI_LoadButton = new System.Windows.Forms.Button();
            this.UI_LongRunButton = new System.Windows.Forms.Button();
            this.UI_NumberRunButton = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.UI_FileName = new System.Windows.Forms.Label();
            this.FileLengthLabel = new System.Windows.Forms.Label();
            this.UI_FileLength = new System.Windows.Forms.Label();
            this.OnesLabel = new System.Windows.Forms.Label();
            this.UI_NumberOnes = new System.Windows.Forms.Label();
            this.UI_LongestRuns = new System.Windows.Forms.Label();
            this.LongestRunLabel = new System.Windows.Forms.Label();
            this.RunLengthLabel = new System.Windows.Forms.Label();
            this.UI_RunLength = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // UI_LoadButton
            // 
            this.UI_LoadButton.Location = new System.Drawing.Point(16, 15);
            this.UI_LoadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UI_LoadButton.Name = "UI_LoadButton";
            this.UI_LoadButton.Size = new System.Drawing.Size(100, 28);
            this.UI_LoadButton.TabIndex = 0;
            this.UI_LoadButton.Text = "Load File";
            this.UI_LoadButton.UseVisualStyleBackColor = true;
            this.UI_LoadButton.Click += new System.EventHandler(this.UI_LoadButton_Click);
            // 
            // UI_LongRunButton
            // 
            this.UI_LongRunButton.Location = new System.Drawing.Point(16, 197);
            this.UI_LongRunButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UI_LongRunButton.Name = "UI_LongRunButton";
            this.UI_LongRunButton.Size = new System.Drawing.Size(123, 28);
            this.UI_LongRunButton.TabIndex = 1;
            this.UI_LongRunButton.Text = "Longest Run";
            this.UI_LongRunButton.UseVisualStyleBackColor = true;
            this.UI_LongRunButton.Click += new System.EventHandler(this.UI_LongRunButton_Click);
            // 
            // UI_NumberRunButton
            // 
            this.UI_NumberRunButton.Location = new System.Drawing.Point(16, 233);
            this.UI_NumberRunButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UI_NumberRunButton.Name = "UI_NumberRunButton";
            this.UI_NumberRunButton.Size = new System.Drawing.Size(123, 28);
            this.UI_NumberRunButton.TabIndex = 2;
            this.UI_NumberRunButton.Text = "Number of Runs";
            this.UI_NumberRunButton.UseVisualStyleBackColor = true;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(16, 65);
            this.FileNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(73, 17);
            this.FileNameLabel.TabIndex = 3;
            this.FileNameLabel.Text = "File name:";
            // 
            // UI_FileName
            // 
            this.UI_FileName.AutoSize = true;
            this.UI_FileName.Location = new System.Drawing.Point(147, 65);
            this.UI_FileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UI_FileName.Name = "UI_FileName";
            this.UI_FileName.Size = new System.Drawing.Size(0, 17);
            this.UI_FileName.TabIndex = 4;
            // 
            // FileLengthLabel
            // 
            this.FileLengthLabel.AutoSize = true;
            this.FileLengthLabel.Location = new System.Drawing.Point(16, 97);
            this.FileLengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileLengthLabel.Name = "FileLengthLabel";
            this.FileLengthLabel.Size = new System.Drawing.Size(82, 17);
            this.FileLengthLabel.TabIndex = 5;
            this.FileLengthLabel.Text = "File Length:";
            // 
            // UI_FileLength
            // 
            this.UI_FileLength.AutoSize = true;
            this.UI_FileLength.Location = new System.Drawing.Point(147, 97);
            this.UI_FileLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UI_FileLength.Name = "UI_FileLength";
            this.UI_FileLength.Size = new System.Drawing.Size(0, 17);
            this.UI_FileLength.TabIndex = 6;
            // 
            // OnesLabel
            // 
            this.OnesLabel.AutoSize = true;
            this.OnesLabel.Location = new System.Drawing.Point(16, 129);
            this.OnesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OnesLabel.Name = "OnesLabel";
            this.OnesLabel.Size = new System.Drawing.Size(113, 17);
            this.OnesLabel.TabIndex = 7;
            this.OnesLabel.Text = "Number of ones:";
            // 
            // UI_NumberOnes
            // 
            this.UI_NumberOnes.AutoSize = true;
            this.UI_NumberOnes.Location = new System.Drawing.Point(147, 129);
            this.UI_NumberOnes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UI_NumberOnes.Name = "UI_NumberOnes";
            this.UI_NumberOnes.Size = new System.Drawing.Size(0, 17);
            this.UI_NumberOnes.TabIndex = 8;
            // 
            // UI_LongestRuns
            // 
            this.UI_LongestRuns.AutoSize = true;
            this.UI_LongestRuns.Location = new System.Drawing.Point(304, 203);
            this.UI_LongestRuns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UI_LongestRuns.Name = "UI_LongestRuns";
            this.UI_LongestRuns.Size = new System.Drawing.Size(0, 17);
            this.UI_LongestRuns.TabIndex = 9;
            // 
            // LongestRunLabel
            // 
            this.LongestRunLabel.AutoSize = true;
            this.LongestRunLabel.Location = new System.Drawing.Point(147, 203);
            this.LongestRunLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LongestRunLabel.Name = "LongestRunLabel";
            this.LongestRunLabel.Size = new System.Drawing.Size(93, 17);
            this.LongestRunLabel.TabIndex = 10;
            this.LongestRunLabel.Text = "Longest Run:";
            // 
            // RunLengthLabel
            // 
            this.RunLengthLabel.AutoSize = true;
            this.RunLengthLabel.Location = new System.Drawing.Point(147, 239);
            this.RunLengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RunLengthLabel.Name = "RunLengthLabel";
            this.RunLengthLabel.Size = new System.Drawing.Size(121, 17);
            this.RunLengthLabel.TabIndex = 11;
            this.RunLengthLabel.Text = "Runs of Length 0:";
            // 
            // UI_RunLength
            // 
            this.UI_RunLength.AutoSize = true;
            this.UI_RunLength.Location = new System.Drawing.Point(296, 239);
            this.UI_RunLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UI_RunLength.Name = "UI_RunLength";
            this.UI_RunLength.Size = new System.Drawing.Size(0, 17);
            this.UI_RunLength.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Data files|*.dat|Binary Files|*.bin|All Files|*.*\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.UI_RunLength);
            this.Controls.Add(this.RunLengthLabel);
            this.Controls.Add(this.LongestRunLabel);
            this.Controls.Add(this.UI_LongestRuns);
            this.Controls.Add(this.UI_NumberOnes);
            this.Controls.Add(this.OnesLabel);
            this.Controls.Add(this.UI_FileLength);
            this.Controls.Add(this.FileLengthLabel);
            this.Controls.Add(this.UI_FileName);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.UI_NumberRunButton);
            this.Controls.Add(this.UI_LongRunButton);
            this.Controls.Add(this.UI_LoadButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_LoadButton;
        private System.Windows.Forms.Button UI_LongRunButton;
        private System.Windows.Forms.Button UI_NumberRunButton;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label UI_FileName;
        private System.Windows.Forms.Label FileLengthLabel;
        private System.Windows.Forms.Label UI_FileLength;
        private System.Windows.Forms.Label OnesLabel;
        private System.Windows.Forms.Label UI_NumberOnes;
        private System.Windows.Forms.Label UI_LongestRuns;
        private System.Windows.Forms.Label LongestRunLabel;
        private System.Windows.Forms.Label RunLengthLabel;
        private System.Windows.Forms.Label UI_RunLength;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

