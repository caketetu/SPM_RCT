namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.B_Serial = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.TB_Com = new System.Windows.Forms.TextBox();
            this.TB_DevID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B_DevIDSerach = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.L_ModelNo = new System.Windows.Forms.Label();
            this.L_DevVersion = new System.Windows.Forms.Label();
            this.DGV_InputRegs = new System.Windows.Forms.DataGridView();
            this.DGV_HoldingRegs = new System.Windows.Forms.DataGridView();
            this.B_AllWriteHoldingRegs = new System.Windows.Forms.Button();
            this.B_LoadHoldingRegs = new System.Windows.Forms.Button();
            this.B_LoadInputRegs = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.B_FlashParams = new System.Windows.Forms.Button();
            this.B_SaveParams = new System.Windows.Forms.Button();
            this.B_LoadParams = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.labelee = new System.Windows.Forms.Label();
            this.L_Description = new System.Windows.Forms.Label();
            this.B_CycRegs1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CB_CycFuncName = new System.Windows.Forms.ComboBox();
            this.DGV_CyclicFuncTx = new System.Windows.Forms.DataGridView();
            this.DGV_CyclicFuncRx = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InputRegs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_HoldingRegs)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CyclicFuncTx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CyclicFuncRx)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Serial
            // 
            this.B_Serial.Location = new System.Drawing.Point(1035, 62);
            this.B_Serial.Name = "B_Serial";
            this.B_Serial.Size = new System.Drawing.Size(136, 43);
            this.B_Serial.TabIndex = 0;
            this.B_Serial.Text = "Connect";
            this.B_Serial.UseVisualStyleBackColor = true;
            this.B_Serial.Click += new System.EventHandler(this.B_Serail_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // TB_Com
            // 
            this.TB_Com.Location = new System.Drawing.Point(1036, 12);
            this.TB_Com.Name = "TB_Com";
            this.TB_Com.Size = new System.Drawing.Size(136, 19);
            this.TB_Com.TabIndex = 1;
            this.TB_Com.Text = "COM1";
            // 
            // TB_DevID
            // 
            this.TB_DevID.Location = new System.Drawing.Point(1094, 37);
            this.TB_DevID.Name = "TB_DevID";
            this.TB_DevID.Size = new System.Drawing.Size(78, 19);
            this.TB_DevID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1033, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Device ID";
            // 
            // B_DevIDSerach
            // 
            this.B_DevIDSerach.Location = new System.Drawing.Point(1036, 111);
            this.B_DevIDSerach.Name = "B_DevIDSerach";
            this.B_DevIDSerach.Size = new System.Drawing.Size(136, 43);
            this.B_DevIDSerach.TabIndex = 6;
            this.B_DevIDSerach.Text = "Device Serch";
            this.B_DevIDSerach.UseVisualStyleBackColor = true;
            this.B_DevIDSerach.Click += new System.EventHandler(this.B_DevIDSerach_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1041, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1052, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Version";
            // 
            // L_ModelNo
            // 
            this.L_ModelNo.AutoSize = true;
            this.L_ModelNo.Location = new System.Drawing.Point(1110, 168);
            this.L_ModelNo.Name = "L_ModelNo";
            this.L_ModelNo.Size = new System.Drawing.Size(25, 12);
            this.L_ModelNo.TabIndex = 9;
            this.L_ModelNo.Text = "test";
            // 
            // L_DevVersion
            // 
            this.L_DevVersion.AutoSize = true;
            this.L_DevVersion.Location = new System.Drawing.Point(1110, 190);
            this.L_DevVersion.Name = "L_DevVersion";
            this.L_DevVersion.Size = new System.Drawing.Size(35, 12);
            this.L_DevVersion.TabIndex = 10;
            this.L_DevVersion.Text = "00000";
            // 
            // DGV_InputRegs
            // 
            this.DGV_InputRegs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_InputRegs.Location = new System.Drawing.Point(8, 28);
            this.DGV_InputRegs.Name = "DGV_InputRegs";
            this.DGV_InputRegs.RowTemplate.Height = 21;
            this.DGV_InputRegs.Size = new System.Drawing.Size(378, 653);
            this.DGV_InputRegs.TabIndex = 11;
            // 
            // DGV_HoldingRegs
            // 
            this.DGV_HoldingRegs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_HoldingRegs.Location = new System.Drawing.Point(412, 28);
            this.DGV_HoldingRegs.Name = "DGV_HoldingRegs";
            this.DGV_HoldingRegs.RowTemplate.Height = 21;
            this.DGV_HoldingRegs.Size = new System.Drawing.Size(471, 651);
            this.DGV_HoldingRegs.TabIndex = 12;
            this.DGV_HoldingRegs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_HoldingRegs_CellContentClick);
            this.DGV_HoldingRegs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_HoldingRegs_CellValueChanged);
            // 
            // B_AllWriteHoldingRegs
            // 
            this.B_AllWriteHoldingRegs.Location = new System.Drawing.Point(770, 683);
            this.B_AllWriteHoldingRegs.Name = "B_AllWriteHoldingRegs";
            this.B_AllWriteHoldingRegs.Size = new System.Drawing.Size(113, 38);
            this.B_AllWriteHoldingRegs.TabIndex = 14;
            this.B_AllWriteHoldingRegs.Text = "All Write";
            this.B_AllWriteHoldingRegs.UseVisualStyleBackColor = true;
            this.B_AllWriteHoldingRegs.Click += new System.EventHandler(this.B_SaveHoldingRegs_Click);
            // 
            // B_LoadHoldingRegs
            // 
            this.B_LoadHoldingRegs.Location = new System.Drawing.Point(631, 685);
            this.B_LoadHoldingRegs.Name = "B_LoadHoldingRegs";
            this.B_LoadHoldingRegs.Size = new System.Drawing.Size(113, 36);
            this.B_LoadHoldingRegs.TabIndex = 15;
            this.B_LoadHoldingRegs.Text = "LoadHoldingRegs";
            this.B_LoadHoldingRegs.UseVisualStyleBackColor = true;
            this.B_LoadHoldingRegs.Click += new System.EventHandler(this.B_LoadHoldingRegs_Click);
            // 
            // B_LoadInputRegs
            // 
            this.B_LoadInputRegs.Location = new System.Drawing.Point(273, 687);
            this.B_LoadInputRegs.Name = "B_LoadInputRegs";
            this.B_LoadInputRegs.Size = new System.Drawing.Size(113, 37);
            this.B_LoadInputRegs.TabIndex = 16;
            this.B_LoadInputRegs.Text = "LoadInputRegs";
            this.B_LoadInputRegs.UseVisualStyleBackColor = true;
            this.B_LoadInputRegs.Click += new System.EventHandler(this.B_LoadInputRegs_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "Input Registers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "Holding Registers";
            // 
            // B_FlashParams
            // 
            this.B_FlashParams.Location = new System.Drawing.Point(1059, 689);
            this.B_FlashParams.Name = "B_FlashParams";
            this.B_FlashParams.Size = new System.Drawing.Size(113, 38);
            this.B_FlashParams.TabIndex = 19;
            this.B_FlashParams.Text = "FlashParams";
            this.B_FlashParams.UseVisualStyleBackColor = true;
            // 
            // B_SaveParams
            // 
            this.B_SaveParams.Location = new System.Drawing.Point(1059, 645);
            this.B_SaveParams.Name = "B_SaveParams";
            this.B_SaveParams.Size = new System.Drawing.Size(113, 38);
            this.B_SaveParams.TabIndex = 20;
            this.B_SaveParams.Text = "Save Params";
            this.B_SaveParams.UseVisualStyleBackColor = true;
            this.B_SaveParams.Click += new System.EventHandler(this.B_SaveParams_Click);
            // 
            // B_LoadParams
            // 
            this.B_LoadParams.Location = new System.Drawing.Point(1059, 601);
            this.B_LoadParams.Name = "B_LoadParams";
            this.B_LoadParams.Size = new System.Drawing.Size(113, 38);
            this.B_LoadParams.TabIndex = 21;
            this.B_LoadParams.Text = "Load Params";
            this.B_LoadParams.UseVisualStyleBackColor = true;
            this.B_LoadParams.Click += new System.EventHandler(this.B_LoadParams_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "csvファイル|*.csv";
            this.openFileDialog1.InitialDirectory = "./Params";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "csvファイル|*.csv";
            // 
            // labelee
            // 
            this.labelee.AutoSize = true;
            this.labelee.Location = new System.Drawing.Point(1033, 212);
            this.labelee.Name = "labelee";
            this.labelee.Size = new System.Drawing.Size(63, 12);
            this.labelee.TabIndex = 22;
            this.labelee.Text = "Description";
            // 
            // L_Description
            // 
            this.L_Description.AutoSize = true;
            this.L_Description.Location = new System.Drawing.Point(1057, 235);
            this.L_Description.Name = "L_Description";
            this.L_Description.Size = new System.Drawing.Size(35, 12);
            this.L_Description.TabIndex = 23;
            this.L_Description.Text = "00000";
            // 
            // B_CycRegs1
            // 
            this.B_CycRegs1.Location = new System.Drawing.Point(1035, 270);
            this.B_CycRegs1.Name = "B_CycRegs1";
            this.B_CycRegs1.Size = new System.Drawing.Size(135, 38);
            this.B_CycRegs1.TabIndex = 24;
            this.B_CycRegs1.Text = "Cyclic Register 1";
            this.B_CycRegs1.UseVisualStyleBackColor = true;
            this.B_CycRegs1.Click += new System.EventHandler(this.B_CycRegs1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1015, 763);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.DGV_InputRegs);
            this.tabPage1.Controls.Add(this.DGV_HoldingRegs);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.B_AllWriteHoldingRegs);
            this.tabPage1.Controls.Add(this.B_LoadHoldingRegs);
            this.tabPage1.Controls.Add(this.B_LoadInputRegs);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1007, 737);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CB_CycFuncName);
            this.tabPage2.Controls.Add(this.DGV_CyclicFuncTx);
            this.tabPage2.Controls.Add(this.DGV_CyclicFuncRx);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1007, 737);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CB_CycFuncName
            // 
            this.CB_CycFuncName.FormattingEnabled = true;
            this.CB_CycFuncName.Location = new System.Drawing.Point(26, 16);
            this.CB_CycFuncName.Name = "CB_CycFuncName";
            this.CB_CycFuncName.Size = new System.Drawing.Size(246, 20);
            this.CB_CycFuncName.TabIndex = 2;
            this.CB_CycFuncName.SelectionChangeCommitted += new System.EventHandler(this.CB_CycFuncName_SelectionChangeCommitted);
            // 
            // DGV_CyclicFuncTx
            // 
            this.DGV_CyclicFuncTx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CyclicFuncTx.Location = new System.Drawing.Point(381, 51);
            this.DGV_CyclicFuncTx.Name = "DGV_CyclicFuncTx";
            this.DGV_CyclicFuncTx.RowTemplate.Height = 21;
            this.DGV_CyclicFuncTx.Size = new System.Drawing.Size(324, 395);
            this.DGV_CyclicFuncTx.TabIndex = 1;
            // 
            // DGV_CyclicFuncRx
            // 
            this.DGV_CyclicFuncRx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CyclicFuncRx.Location = new System.Drawing.Point(6, 51);
            this.DGV_CyclicFuncRx.Name = "DGV_CyclicFuncRx";
            this.DGV_CyclicFuncRx.RowTemplate.Height = 21;
            this.DGV_CyclicFuncRx.Size = new System.Drawing.Size(335, 395);
            this.DGV_CyclicFuncRx.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.B_CycRegs1);
            this.Controls.Add(this.L_Description);
            this.Controls.Add(this.labelee);
            this.Controls.Add(this.B_LoadParams);
            this.Controls.Add(this.B_SaveParams);
            this.Controls.Add(this.B_FlashParams);
            this.Controls.Add(this.L_DevVersion);
            this.Controls.Add(this.L_ModelNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.B_DevIDSerach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_DevID);
            this.Controls.Add(this.TB_Com);
            this.Controls.Add(this.B_Serial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InputRegs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_HoldingRegs)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CyclicFuncTx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CyclicFuncRx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Serial;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox TB_Com;
        private System.Windows.Forms.TextBox TB_DevID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_DevIDSerach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label L_ModelNo;
        private System.Windows.Forms.Label L_DevVersion;
        private System.Windows.Forms.DataGridView DGV_InputRegs;
        private System.Windows.Forms.DataGridView DGV_HoldingRegs;
        private System.Windows.Forms.Button B_AllWriteHoldingRegs;
        private System.Windows.Forms.Button B_LoadHoldingRegs;
        private System.Windows.Forms.Button B_LoadInputRegs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button B_FlashParams;
        private System.Windows.Forms.Button B_SaveParams;
        private System.Windows.Forms.Button B_LoadParams;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelee;
        private System.Windows.Forms.Label L_Description;
        private System.Windows.Forms.Button B_CycRegs1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGV_CyclicFuncTx;
        private System.Windows.Forms.DataGridView DGV_CyclicFuncRx;
        private System.Windows.Forms.ComboBox CB_CycFuncName;
    }
}

