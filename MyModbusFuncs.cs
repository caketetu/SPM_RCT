using System;
using System.Drawing;
using System.IO.Ports;
using System.Runtime.ConstrainedExecution;
using System.Threading;
//using static WindowsFormsApp1.Form1;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace MD
{
    public struct sModbusRegs
    {
        public int status;
        public Int16[] data;
        public int len;
    };

    class MyModbusFuncs
    {
        StandaloneFunctions.StandaloneFuncs SF = new StandaloneFunctions.StandaloneFuncs();

        //Read Holding Registers(03)
        public sModbusRegs MyModbusReadHoldingRegisters(SerialPort ser, byte slave, UInt16 adr, UInt16 len)
        {
            byte[] sd = new byte[8];
            sd[0] = slave;
            sd[1] = 0x03;
            sd[2] = (byte)(adr >> 8);
            sd[3] = (byte)(adr);
            sd[4] = (byte)(len >> 8);
            sd[5] = (byte)(len);
            UInt16 crc = SF.Calc_crc(sd, 6);
            sd[6] = (byte)(crc);
            sd[7] = (byte)(crc >> 8);
            ser.Write(sd, 0, 8);
            Thread.Sleep(30);
            //受信
            sModbusRegs modbus_data = new sModbusRegs();
            modbus_data.status = -1;
            if (ser.BytesToRead > 0)
            {
                int rlen = ser.BytesToRead;
                byte[] rd = new byte[rlen];
                ser.Read(rd, 0, rlen);
                UInt16 crc_check = SF.convert_UInt16(rd[rlen - 1], rd[rlen - 2]);
                if (crc_check != SF.Calc_crc(rd, rlen - 2))
                {
                    modbus_data.status = -1;
                    return modbus_data;
                }
                modbus_data.len = rd[2] / 2;
                modbus_data.data = new Int16[modbus_data.len];
                for (int i = 0; i < rd[2]; i += 2)
                {
                    modbus_data.data[i / 2] = SF.convert_Int16(rd[i + 3], rd[i + 4]);
                }
                modbus_data.status = 0;
            }
            return modbus_data;
        }

        //Read Input Registers(04)
        public sModbusRegs MyModbusReadInputRegisters(SerialPort ser, byte slave, UInt16 adr, UInt16 len)
        {
            byte[] sd = new byte[8];
            sd[0] = slave;
            sd[1] = 0x04;
            sd[2] = (byte)(adr >> 8);
            sd[3] = (byte)(adr);
            sd[4] = (byte)(len >> 8);
            sd[5] = (byte)(len);
            UInt16 crc = SF.Calc_crc(sd, 6);
            sd[6] = (byte)(crc);
            sd[7] = (byte)(crc >> 8);
            ser.Write(sd, 0, 8);
            Thread.Sleep(30);
            //受信
            sModbusRegs modbus_data = new sModbusRegs();
            modbus_data.status = -1;
            if (ser.BytesToRead > 0)
            {
                int rlen = ser.BytesToRead;
                byte[] rd = new byte[rlen];
                ser.Read(rd, 0, rlen);
                UInt16 crc_check = SF.convert_UInt16(rd[rlen - 1], rd[rlen - 2]);
                if (crc_check != SF.Calc_crc(rd, rlen - 2))
                {
                    modbus_data.status = -1;
                    return modbus_data;
                }
                modbus_data.len = rd[2] / 2;
                modbus_data.data = new Int16[modbus_data.len];
                for (int i = 0; i < rd[2]; i += 2)
                {
                    modbus_data.data[i / 2] = SF.convert_Int16(rd[i + 3], rd[i + 4]);
                }
                modbus_data.status = 0;
            }
            return modbus_data;
        }

        //Force Single Coil（05）
        public sModbusRegs MyModbusForceSingleCoil(SerialPort ser, byte slave, UInt16 adr, bool value)
        {
            byte[] sd = new byte[8];
            sd[0] = slave;
            sd[1] = 0x05;
            sd[2] = (byte)(adr >> 8);
            sd[3] = (byte)(adr);
            if (value) sd[4] = 0xff;
            else sd[4] = 0xff;
            sd[5] = 0x00;
            UInt16 crc = SF.Calc_crc(sd, 6);
            sd[6] = (byte)(crc);
            sd[7] = (byte)(crc >> 8);
            ser.Write(sd, 0, 8);
            Thread.Sleep(30);
            //受信
            sModbusRegs modbus_data = new sModbusRegs();
            modbus_data.status = -1;
            if (ser.BytesToRead > 0)
            {
                int rlen = ser.BytesToRead;
                byte[] rd = new byte[rlen];
                ser.Read(rd, 0, rlen);
                UInt16 crc_check = SF.convert_UInt16(rd[rlen - 1], rd[rlen - 2]);
                if (crc_check != SF.Calc_crc(rd, rlen - 2))
                {
                    modbus_data.status = -1;
                    return modbus_data;
                }
                modbus_data.len = 1;
                modbus_data.data = new Int16[1];
                modbus_data.data[0] = SF.convert_Int16(rd[4], rd[5]);
                modbus_data.status = 0;
            }
            return modbus_data;
        }

        //Preset Single Register（06)
        public sModbusRegs MyModbusPresetSingleRegisters(SerialPort ser, byte slave, UInt16 adr, Int16 value)
        {
            byte[] sd = new byte[8];
            sd[0] = slave;
            sd[1] = 0x06;
            sd[2] = (byte)(adr >> 8);
            sd[3] = (byte)(adr);
            sd[4] = (byte)(value >> 8);
            sd[5] = (byte)(value);
            UInt16 crc = SF.Calc_crc(sd, 6);
            sd[6] = (byte)(crc);
            sd[7] = (byte)(crc >> 8);
            ser.Write(sd, 0, 8);
            Thread.Sleep(30);
            //受信
            sModbusRegs modbus_data = new sModbusRegs();
            modbus_data.status = -1;
            if (ser.BytesToRead > 0)
            {
                int rlen = ser.BytesToRead;
                byte[] rd = new byte[rlen];
                ser.Read(rd, 0, rlen);
                UInt16 crc_check = SF.convert_UInt16(rd[rlen - 1], rd[rlen - 2]);
                if (crc_check != SF.Calc_crc(rd, rlen - 2))
                {
                    modbus_data.status = -1;
                    return modbus_data;
                }
                modbus_data.len = 1;
                modbus_data.data = new Int16[1];
                modbus_data.data[0] = SF.convert_Int16(rd[4], rd[5]);
                modbus_data.status = 0;
            }
            return modbus_data;
        }

        //Preset Multiple Registers（16，0x10）
        public sModbusRegs MyModbusPresetMultipleRegisters(SerialPort ser, byte slave, UInt16 adr, Int16[] value)
        {
            Int16 reg_len = (short)value.Length;
            byte[] sd = new byte[256];
            sd[0] = slave;
            sd[1] = 0x06;
            sd[2] = (byte)(adr >> 8);
            sd[3] = (byte)(adr);
            sd[4] = (byte)(reg_len >> 8);
            sd[5] = (byte)(reg_len);
            sd[6] = (byte)(reg_len * 2);
            int sd_len = 7;
            for(int i=0; i < reg_len; i++)
            {
                sd[sd_len++] = (byte)(value[i] >> 8);
                sd[sd_len++] = (byte)(value[i]);
            }

            UInt16 crc = SF.Calc_crc(sd, sd_len);
            sd[sd_len++] = (byte)(crc);
            sd[sd_len++] = (byte)(crc >> 8);
            ser.Write(sd, 0, sd_len);
            Thread.Sleep(30);
            //受信
            sModbusRegs modbus_data = new sModbusRegs();
            modbus_data.status = -1;
            if (ser.BytesToRead > 0)
            {
                int rlen = ser.BytesToRead;
                byte[] rd = new byte[rlen];
                ser.Read(rd, 0, rlen);
                UInt16 crc_check = SF.convert_UInt16(rd[rlen - 1], rd[rlen - 2]);
                if (crc_check != SF.Calc_crc(rd, rlen - 2))
                {
                    modbus_data.status = -1;
                    return modbus_data;
                }
                modbus_data.len = 1;
                modbus_data.data = new Int16[1];
                modbus_data.data[0] = SF.convert_Int16(rd[4], rd[5]);
                modbus_data.status = 0;
            }
            return modbus_data;
        }
        //Cyclic Functions（65-69）
        public sModbusRegs MyModbusCyclicFuncs(SerialPort ser, byte slave, int func_no, Int16[] values)
        {
            byte[] sd = new byte[256];
            int sl = 0;
            sd[sl++] = slave;
            sd[sl++] = (byte)(func_no+65);
            for (int i = 0; i < values.Length; i++)
            {
                sd[sl++] = (byte)(values[i] >> 8);
                sd[sl++] = (byte)(values[i]);
            }

            UInt16 crc = SF.Calc_crc(sd, sl);
            sd[sl++] = (byte)(crc);
            sd[sl++] = (byte)(crc >> 8);
            ser.Write(sd, 0, sl);
            Thread.Sleep(30);
            //受信
            sModbusRegs modbus_data = new sModbusRegs();
            modbus_data.status = -1;
            if (ser.BytesToRead > 0)
            {
                int rlen = ser.BytesToRead;
                byte[] rd = new byte[rlen];
                ser.Read(rd, 0, rlen);
                UInt16 crc_check = SF.convert_UInt16(rd[rlen - 1], rd[rlen - 2]);
                if (crc_check != SF.Calc_crc(rd, rlen - 2))
                {
                    modbus_data.status = -1;
                    return modbus_data;
                }
                modbus_data.len = (rlen-4)/2;
                modbus_data.data = new Int16[modbus_data.len];
                int trx = 2;
                for (int i = 0; i < modbus_data.len; i++)
                {
                    modbus_data.data[i] = SF.convert_Int16(rd[trx++], rd[trx++]);
                }
                modbus_data.status = 0;
            }
            return modbus_data;
        }
    }
}
