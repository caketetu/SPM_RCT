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
            this.DGV_CycRx1 = new System.Windows.Forms.DataGridView();
            this.DGV_CycTx1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CycRx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CycTx1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_CycRx1
            // 
            this.DGV_CycRx1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CycRx1.Location = new System.Drawing.Point(36, 25);
            this.DGV_CycRx1.Name = "DGV_CycRx1";
            this.DGV_CycRx1.RowTemplate.Height = 21;
            this.DGV_CycRx1.Size = new System.Drawing.Size(256, 368);
            this.DGV_CycRx1.TabIndex = 0;
            // 
            // DGV_CycTx1
            // 
            this.DGV_CycTx1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CycTx1.Location = new System.Drawing.Point(331, 25);
            this.DGV_CycTx1.Name = "DGV_CycTx1";
            this.DGV_CycTx1.RowTemplate.Height = 21;
            this.DGV_CycTx1.Size = new System.Drawing.Size(253, 368);
            this.DGV_CycTx1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 457);
            this.Controls.Add(this.DGV_CycTx1);
            this.Controls.Add(this.DGV_CycRx1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CycRx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CycTx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_CycRx1;
        private System.Windows.Forms.DataGridView DGV_CycTx1;
    }
}