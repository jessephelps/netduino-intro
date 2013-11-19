using System;
using System.IO.Ports;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace Intro.XBeeMotion
{
    public class MotionSensor
    {
        static SerialPort xbee = new SerialPort("COM1");

        static public void Run()
        {
            xbee.DataReceived += serialPort_DataReceived;

            xbee.Open();

            while (true)
            {
                // Spin
            }
        }

        static void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (xbee.BytesToRead >= 14)
            {
                var buffer = new byte[xbee.BytesToRead];

                xbee.Read(buffer, 0, xbee.BytesToRead);
                String output = "";
                foreach (var item in buffer)
                {
                    output += item.ToString("X2");
                }

                if(buffer[12] == 1)
                    Debug.Print("MOTION!");
                else
                    Debug.Print("NO MOTION!");

                Debug.Print(output);
            }
        }
    }
}
