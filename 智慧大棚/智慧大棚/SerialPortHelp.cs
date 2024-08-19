using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 智慧大棚
{
    public class SerialPortHelp
    {
        SerialPort serialPort = null;
        public SerialPortHelp()
        {
            serialPort = new SerialPort();
        }
        #region 打开关闭串口
        /// <summary>
        /// 打开串口
        /// </summary>
        /// <param name="portName">串口名</param>
        /// <param name="baudRate">波特率</param>
        /// <param name="dataBits">数据位</param>
        /// <param name="parity">奇偶校验位</param>
        /// <param name="stopBits">停止位</param>
        /// <returns>是否打开成功</returns>
        public bool OpenPort(string portName, int baudRate, int dataBits, Parity parity, StopBits stopBits)
        {
            if (serialPort == null)
            {
                return false;
            }
            if (!serialPort.IsOpen)
            {
                serialPort.Close();
            }
            try
            {
                serialPort.PortName = portName;
                serialPort.BaudRate = baudRate;
                serialPort.DataBits = dataBits;
                serialPort.Parity = parity;
                serialPort.StopBits = stopBits;
                serialPort.Open();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// 关闭串口
        /// </summary>
        /// <returns>是否关闭成功</returns>
        public bool ClosePort()
        {
            if (serialPort == null)
            {
                return false;
            }
            try
            {
                serialPort.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region 读取寄存器 03
        public byte[] ReadKeep(int iDevAdd, long iAddress, int iLength)
        {

        }
        #endregion
    }
}
