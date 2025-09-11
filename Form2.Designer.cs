namespace WindowsFormsApp1
{
    partial class Form2
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
            this.TB_SerialLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TB_SerialLog
            // 
            this.TB_SerialLog.Location = new System.Drawing.Point(12, 12);
            this.TB_SerialLog.Multiline = true;
            this.TB_SerialLog.Name = "TB_SerialLog";
            this.TB_SerialLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_SerialLog.Size = new System.Drawing.Size(572, 342);
            this.TB_SerialLog.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 366);
            this.Controls.Add(this.TB_SerialLog);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_SerialLog;
    }
}