using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAPI.Data
{
    public class Devices
    {
        String Id { get; set; }
        String Name { get; set; }
        String DeviceTypeId { get; set; }
        Boolean Failsafe { get; set; }
        int TempMin { get; set; }
        int TempMax { get; set; }
        String InstallationPosition { get; set; }
        Boolean InsertInto19InchCabinet { get; set; }

        Boolean MotionEnable { get; set; }
        Boolean SiplusCatalog { get; set; }

        Boolean SimaticCatalog { get; set; }
        int RotationAxisNumber { get; set; }
        int PositionAxisNumber { get; set; }
        Boolean TerminalElement { get; set; }
        Boolean AdvancedEnvironmentalConditions { get; set; }
    }
}
