using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            DataClass.StringValue = "";
        }

        public void RefreshData()
        {
            TB_SerialLog.Text = DataClass.StringValue;
            TB_SerialLog.SelectionStart = TB_SerialLog.Text.Length; // キャレットを末尾に移動
            TB_SerialLog.ScrollToCaret(); // キャレット位置までスクロール
        }
    }
    public static class DataClass
    {
        public static string StringValue { get; set; }
    }
}
