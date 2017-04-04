using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitFlow.Model
{
    public class Communication
    {
        public BluetoothSpecification Bluetooth { get; set; }
        public bool WiFi { get; set; }
        public bool GPS { get; set; }
        public bool AGPS { get; set; }
        public bool OTG { get; set; }

        public Communication(BluetoothSpecification bluetooth, bool wifi, bool gps, bool agps, bool otg)
        {
            Bluetooth = bluetooth;
            WiFi = wifi;
            GPS = gps;
            AGPS = agps;
            OTG = otg;
        }
    }
}
