namespace CMPE1600_ICA08
{
    partial class LongestRunForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_ZeroRuns = new System.Windows.Forms.RadioButton();
            this.UI_OneRuns = new System.Windows.Forms.RadioButton();
            this.UI_OkButton = new System.Windows.Forms.Button();
            this.UI_CancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_OneRuns);
            this.groupBox1.Controls.Add(this.UI_ZeroRuns);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Run of";
            // 
            // UI_ZeroRuns
            // 
            this.UI_ZeroRuns.AutoSize = true;
            this.UI_ZeroRuns.Location = new System.Drawing.Point(0, 33);
            this.UI_ZeroRuns.Name = "UI_ZeroRuns";
            this.UI_ZeroRuns.Size = new System.Drawing.Size(37, 21);
            this.UI_ZeroRuns.TabIndex = 0;
            this.UI_ZeroRuns.TabStop = true;
            this.UI_ZeroRuns.Text = "0";
            this.UI_ZeroRuns.UseVisualStyleBackColor = true;
            this.UI_ZeroRuns.CheckedChanged += new System.EventHandler(this.UI_ZeroRuns_CheckedChanged);
            // 
            // UI_OneRuns
            // 
            this.UI_OneRuns.AutoSize = true;
            this.UI_OneRuns.Location = new System.Drawing.Point(0, 71);
            this.UI_OneRuns.Name = "UI_OneRuns";
            this.UI_OneRuns.Size = new System.Drawing.Size(37, 21);
            this.UI_OneRuns.TabIndex = 1;
            this.UI_OneRuns.TabStop = true;
            this.UI_OneRuns.Text = "1";
            this.UI_OneRuns.UseVisualStyleBackColor = true;
            this.UI_OneRuns.CheckedChanged += new System.EventHandler(this.UI_OneRuns_CheckedChanged);
            // 
            // UI_OkButton
            // 
            this.UI_OkButton.Location = new System.Drawing.Point(12, 160);
            this.UI_OkButton.Name = "UI_OkButton";
            this.UI_OkButton.Size = new System.Drawing.Size(130, 26);
            this.UI_OkButton.TabIndex = 1;
            this.UI_OkButton.Text = "OK";
            this.UI_OkButton.UseVisualStyleBackColor = true;
            this.UI_OkButton.Click += new System.EventHandler(this.UI_OkButton_Click);
            // 
            // UI_CancelButton
            // 
            this.UI_CancelButton.Location = new System.Drawing.Point(215, 160);
            this.UI_CancelButton.Name = "UI_CancelButton";
            this.UI_CancelButton.Size = new System.Drawing.Size(130, 27);
            this.UI_CancelButton.TabIndex = 2;
            this.UI_CancelButton.Text = "Cancel";
            this.UI_CancelButton.UseVisualStyleBackColor = true;
            this.UI_CancelButton.Click += new System.EventHandler(this.UI_CancelButton_Click);
            // 
            // LongestRunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 253);
            this.ControlBox = false;
            this.Controls.Add(this.UI_CancelButton);
            this.Controls.Add(this.UI_OkButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LongestRunForm";
            this.Text = "Longest Run";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UI_OneRuns;
        private System.Windows.Forms.RadioButton UI_ZeroRuns;
        private System.Windows.Forms.Button UI_OkButton;
        private System.Windows.Forms.Button UI_CancelButton;
    }
}