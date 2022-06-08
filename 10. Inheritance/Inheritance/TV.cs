using System;
namespace Inheritance
{
    public class TV : ElectricalDevice
    {

        public TV(bool isOn, string brand):base(isOn, brand)
        {

        }


        // method to watch TV
        public void WatchTV()
        {
            // first check if TV is on
            if (IsOn)
            {
                //Watch TV
                Console.WriteLine("Watching TV!");
            }
            else
            {
                // print error message
                Console.WriteLine("TV is switched off, switch it on first");
            }
        }
    }
}
