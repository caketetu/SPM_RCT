using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyServoTest
{

    class MyModbus
    {
        //定数
        const int SUCSESS = 0;
        const int ERR_CRC = 48;
        const int ERR_DATA_LEN = 49;
        const int ERR_DATA_ODD = 50;
        const int ERR_ID = 51;
        const int DATA_MAX = 200;

        public byte id;
        public byte fcode;
        public Int16[] data;
        public Int16 data_l;
        public UInt16 crc;
        public Int16 encode_error;
        //----------------------------------------------------------
        //    コンストラクタ
        //----------------------------------------------------------
        public MyModbus(byte dev_id)
        {
            id = dev_id;
            fcode = 0;
            data = new Int16[DATA_MAX];
            data_l = 0;
            crc = 0;
            encode_error = 0;
        }

        //----------------------------------------------------------
        //    modbusデータ->配列に変換
        //----------------------------------------------------------
        public Int16 Decode(byte[] data)
        {
            Int16 l = 0;
            data[l++] = this.id;
            data[l++] = this.fcode;
            for (int i = 0; i < this.data_l; i++)
            {
                data[l++] = (byte)(this.data[i] >> 8);
                data[l++] = (byte)this.data[i];
            }
            UInt16 crc = calc_crc(data, l);
            data[l++] = (byte)crc;
            data[l++] = (byte)(crc >> 8);
            return l;
        }

        //----------------------------------------------------------
        //    配列→modbusデータに変換
        //----------------------------------------------------------
        public Int16 Encode(byte[] data, Int16 data_l)
        {
            if (data_l < 6)
            {
                encode_error = ERR_DATA_ODD;
                return ERR_DATA_ODD;        //データが奇数の時エラー
            }
            if (data_l % 2 == 1)
            {
                encode_error = ERR_DATA_LEN;
                return ERR_DATA_LEN;   //データ数が＜６の時エラー
            }

            UInt16 temp_crc = calc_crc(data, data_l - 2); //CRCチェック
            UInt16 crc = (UInt16)(data[data_l - 2] + (data[data_l - 1] << 8));
            if (temp_crc != crc)
            {
                encode_error = ERR_CRC;
                return ERR_CRC;        //CRCが不正の時エラー
            }

            int l = 0;
            this.id = data[l++];
            this.fcode = data[l++];
            this.data_l = 0;
            for (int i = l; i < data_l - 2; i += 2)
            {
                this.data[this.data_l++] = (Int16)((data[i] << 8) + data[i + 1]);
            }
            this.crc = crc;

            return SUCSESS;
        }

        //----------------------------------------------------------
        //    CRC計算関数
        //----------------------------------------------------------
        UInt16 calc_crc(byte[] buf, int length)
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
    }
}
