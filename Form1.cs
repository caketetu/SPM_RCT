//using MyServoTest;
using MyServoTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1;
using static MD.MyModbusFuncs;
using static StandaloneFunctions.StandaloneFuncs;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        StandaloneFunctions.StandaloneFuncs SF = new StandaloneFunctions.StandaloneFuncs();
        MD.MyModbusFuncs MD = new MD.MyModbusFuncs();

        public struct sRegister
        {
            public int address;
            public String name;
            public int min;
            public int max;
            public Int16 value;
            public bool rewrite;
        };

        sRegister[] input_regs;
        sRegister[] holding_regs;

        sRegister[] cyclic_regs_tx1;
        sRegister[] cyclic_regs_rx1;

        public Form1()
        {
            InitializeComponent();

            //設定ファイルがあるか確認
            if (!File.Exists("./sys_settings.csv"))
            {
                //なければ新規作成
                using (StreamWriter writer = new StreamWriter("./sys_settings.csv", false, Encoding.UTF8))
                {
                    writer.WriteLine("COM1");   //COMポート名
                }
            }

            //システム設定ファイルをロード
            using (StreamReader reader = new StreamReader("./sys_settings.csv", Encoding.UTF8))
            {
                //string line;
                TB_Com.Text = reader.ReadLine();        //一行目、COMポート名読み出し
            }
        }

        private void B_Serail_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                //Open->Close処理
                B_Serial.Text = "Disconnect";
                B_Serial.ForeColor = Color.Black;
                serialPort1.Close();
            }
            else
            {
                //Close->Open処理
                serialPort1.PortName = TB_Com.Text;
                serialPort1.Open();
                //デバイス情報の読み出し
                if (serialPort1.IsOpen)
                {
                    MD.sModbusRegs r_flame = MD.MyModbusReadInputRegisters(
                        serialPort1, 48, 0, 3);
                    if (r_flame.status == 0)
                    {
                        String s = SF.serch_profile(r_flame.data[0], r_flame.data[1]);
                        if (s != null)
                        {
                            load_profile(s);
                            reload_input_regs();
                            reload_holding_regs();
                            L_ModelNo.Text = r_flame.data[0].ToString();
                            L_DevVersion.Text = r_flame.data[1].ToString().PadLeft(4, '0')
                                              + '_' + r_flame.data[2].ToString().PadLeft(4, '0');
                        }
                        else
                        {
                            MessageBox.Show("Profile not found");
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Device not found");
                        return;
                    }
                    B_Serial.Text = "Connect";
                    B_Serial.ForeColor = Color.Red;
                }
            }
        }

        private void load_profile(String file)
        {
            StreamReader sr = new StreamReader(file);   //ファイルオープン
            String line = null; // ここで初期化
            //1行ずつ読み込み
            while ((line = sr.ReadLine()) != null)
            {
                String[] sline = line.Split(',');
                if (sline[0] == "info")
                {
                    while (sline[0] != "_info")
                    {
                        line = sr.ReadLine();
                        sline = line.Split(',');
                        if (sline[0] == "regs_max")
                        {
                            int regs_max = int.Parse(sline[1]);
                            input_regs = new sRegister[regs_max];
                            holding_regs = new sRegister[regs_max];
                        }
                        if (sline[0] == "description")
                        {
                            L_Description.Text = sline[1];
                        }
                    }
                }

                if (sline[0] == "input_regs")
                {
                    while (line != null)
                    {
                        line = sr.ReadLine();
                        sline = line.Split(',');
                        if (sline[0] == "_input_regs") break;
                        sRegister ir = new sRegister();
                        ir.address = int.Parse(sline[0]);
                        ir.name = sline[1];
                        ir.min = int.Parse(sline[2]);
                        ir.max = int.Parse(sline[3]);
                        ir.value = 0;
                        ir.rewrite = true;
                        input_regs[ir.address] = ir;
                    }
                }

                if (sline[0] == "holding_regs")
                {
                    while (line != null)
                    {
                        line = sr.ReadLine();
                        sline = line.Split(',');
                        if (sline[0] == "_holding_regs") break;
                        sRegister hr = new sRegister();
                        hr.address = int.Parse(sline[0]);
                        hr.name = sline[1];
                        hr.min = int.Parse(sline[2]);
                        hr.max = int.Parse(sline[3]);
                        hr.value = 0;
                        hr.rewrite = true;
                        holding_regs[hr.address] = hr;
                    }
                }
            }
            sr.Close();
        }

        private void reload_input_regs()
        {
            DGV_InputRegs.Rows.Clear();
            DGV_InputRegs.Columns.Clear();
            DGV_InputRegs.ColumnCount = 3;
            foreach (sRegister r in input_regs)
            {
                if (r.name != null)
                {
                    DGV_InputRegs.Rows.Add(r.address, r.name, r.value);
                }
            }
        }

        private void reload_holding_regs()
        {
            DGV_HoldingRegs.Rows.Clear();
            DGV_HoldingRegs.Columns.Clear();
            DGV_HoldingRegs.ColumnCount = 3;
            foreach (sRegister r in holding_regs)
            {
                if (r.name != null)
                {
                    DGV_HoldingRegs.Rows.Add(r.address, r.name, r.value);
                    if (r.rewrite)
                    {
                        DGV_HoldingRegs.Rows[r.address].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
            }
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.Name = "Button";
            column.UseColumnTextForButtonValue = true;
            column.Text = "write";
            //DataGridViewに追加する
            DGV_HoldingRegs.Columns.Add(column);
        }

        private void DGV_HoldingRegs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            String s = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            Int16 val = Convert.ToInt16(s);
            holding_regs[e.RowIndex].value = val;
            holding_regs[e.RowIndex].rewrite = true;
        }

        private void DGV_HoldingRegs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            //"Button"列ならば、ボタンがクリックされた
            if (dgv.Columns[e.ColumnIndex].Name == "Button")
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                int addr = (int)dgv.Rows[e.RowIndex].Cells[0].Value;
                String s = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                Int16 val = Convert.ToInt16(s);

                MD.sModbusRegs r_flame = MD.MyModbusPresetSingleRegisters(
                                            serialPort1, 48, (UInt16)addr, (Int16)val);
                if(r_flame.status == 0)
                {
                    holding_regs[addr].value = r_flame.data[0];
                    holding_regs[addr].rewrite = false;
                    reload_holding_regs();
                }
                else
                {
                    MessageBox.Show("Write Register Error!!");
                }
            }
        }

        private void B_DevIDSerach_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string s = "Find ID:";
                for (int i=1; i<254; i++)
                {
                    MD.sModbusRegs r_flame = MD.MyModbusReadInputRegisters(
                        serialPort1, (byte)i, 0, 1);
                    if (r_flame.status == 0)
                    {
                        s += i.ToString() + ",";
                    }
                    Thread.Sleep(30);
                }
                MessageBox.Show(s);
            }
        }

        private void B_SaveParams_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //パラメータをCSVファイルにセーブ
                if (holding_regs == null) return;
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName, false, Encoding.UTF8))
                {
                    writer.WriteLine("holding_regs");
                    foreach (sRegister r in holding_regs)
                    {
                        if (r.name != null)
                        {
                            if (r.name.Contains('#'))
                            {
                                writer.WriteLine(r.address.ToString() + "," + r.value.ToString());
                            }
                        }
                    }
                    writer.WriteLine("_holding_regs");
                }
            }
        }

        private void B_LoadParams_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //パラメータをCSVファイルからロード
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName, Encoding.UTF8))
                {
                    string line;
                    //1行ずつ読み込み
                    while ((line = reader.ReadLine()) != null)
                    {
                        String[] sline = line.Split(',');
                        if (sline[0] == "holding_regs")
                        {
                            while (line != null)
                            {
                                line = reader.ReadLine();
                                sline = line.Split(',');
                                if (sline[0] == "_holding_regs") break;
                                int addr = int.Parse(sline[0]);
                                Int16 val = Int16.Parse(sline[1]);
                                if (addr < holding_regs.Length)
                                {
                                    holding_regs[addr].value = val;
                                    holding_regs[addr].rewrite = true;
                                }
                            }
                        }
                    }
                }
                reload_holding_regs();
            }
        }

        private void B_SaveHoldingRegs_Click(object sender, EventArgs e)
        {
            for(int i=0; i<holding_regs.Length;i++)
            {
                holding_regs[i].rewrite = false;
            }
            reload_holding_regs();
        }

        private void B_LoadHoldingRegs_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < holding_regs.Length; i++)
            {
                MD.sModbusRegs r_flame = MD.MyModbusReadHoldingRegisters(
                                            serialPort1, 48, (UInt16)i, 1);
                if(r_flame.status == 0)
                {
                    holding_regs[i].value = r_flame.data[0];
                    holding_regs[i].rewrite = false;
                    Thread.Sleep(100);
                }
                else
                {
                    break;
                }
            }
            reload_holding_regs();
        }

        private void B_LoadInputRegs_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < input_regs.Length; i++)
            {
                MD.sModbusRegs r_flame = MD.MyModbusReadInputRegisters(
                                            serialPort1, 48, (UInt16)i, 1);
                if (r_flame.status == 0)
                {
                    input_regs[i].value = r_flame.data[0];
                    input_regs[i].rewrite = false;
                    Thread.Sleep(100);
                }
                else
                {
                    break;
                }
            }
            reload_input_regs();
        }

        private void B_CycRegs1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
