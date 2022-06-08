using System;
namespace Inheritance
{
    public class ElectricalDevice
    {
        // boolean to determine the state of the device
        public bool IsOn { get; set; }

        // string for the brand name of the device
        public string Brand { get; set; }


        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;

        }


        // switch ON device
        public void SwitchOn()
        {
            IsOn = true;
        }

        // switch OFF device
        public void SwitchOff()
        {
            IsOn = false;
        }
    }
}
