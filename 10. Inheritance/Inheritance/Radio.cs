using System;

namespace Inheritance
{
    public class Radio : ElectricalDevice
    {
        // declare constructor upon the model of the base constructor in ElectricalDevice
        public Radio(bool isOn, string brand):base(isOn, brand) 
        {
            
        }

        // method to listen to the radio
        public void ListenRadio()
        {
            // first check if radio in on
            if (IsOn)
            {
                //listen to radio
                Console.WriteLine("Listening to the radio!");
            }
            else
            {
                // print error message
                Console.WriteLine("Radio is switched off, switch it on first");
            }
        }
    }
}
