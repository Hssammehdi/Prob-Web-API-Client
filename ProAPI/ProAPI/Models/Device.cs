using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAPI.Models
{
    public class Device
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String DeviceTypeId { get; set; }
        public Boolean Failsafe { get; set; }
        public int TempMin { get; set; }
        public int TempMax { get; set; }
        public String InstallationPosition { get; set; }
        public Boolean InsertInto19InchCabinet { get; set; }

        public Boolean MotionEnable { get; set; }
        public Boolean SiplusCatalog { get; set; }

        public Boolean SimaticCatalog { get; set; }
        public int RotationAxisNumber { get; set; }
        public int PositionAxisNumber { get; set; }
        public Boolean TerminalElement { get; set; }
        public Boolean AdvancedEnvironmentalConditions { get; set; }

    }
}
