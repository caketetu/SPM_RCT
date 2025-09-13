using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace StandaloneFunctions
{
    class StandaloneFuncs
    {
        //CRCチェック
        // buf		受信データ
        // length	受信データ長(CRCを除く)
        public UInt16 Calc_crc(byte[] buf, int length)
        {
            UInt16 crc = 0xFFFF;
            int i, j;
            byte carrayFlag;
            for (i = 0; i < length; i++)
            {
                crc ^= buf[i];
                for (j = 0; j < 8; j++)
                {
                    carrayFlag = (byte)(crc & 1);
                    crc = (UInt16)(crc >> 1);
                    if (carrayFlag > 0)
                    {
                        crc ^= 0xA001;
                    }
                }
            }
            return crc;
        }
        public Int16 convert_Int16(byte h_data, byte l_data)
        {
            Int16 conv_data = (short)((Int16)(h_data << 8) + l_data);
            return conv_data;
        }
        public UInt16 convert_UInt16(byte h_data, byte l_data)
        {
            UInt16 conv_data = (UInt16)((UInt16)(h_data << 8) + l_data);
            return conv_data;
        }
        public String serch_profile(Int16 model_no, Int16 ver)
        {
            //特定のフォルダ内のファイル名をすべて列挙
            string path = @"./DevProfiles";
            string[] files = System.IO.Directory.GetFiles(path, "*.csv");
            //model_no_ver.cevが含まれるファイルを探す
            String target_string = model_no.ToString() + "_" + ver.ToString().PadLeft(4, '0') + ".csv";
            foreach (string file in files)
            {
                if (file.Contains(target_string))
                {
                    //見つかった場合、ファイル名を表示
                    return file;
                }
            }
            return null;
        }
    }
}
