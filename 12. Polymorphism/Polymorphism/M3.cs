using System;
namespace Polymorphism
{
    public class M3 : BMW
    {
        public M3(int hp, string color, string model):base(hp, color, model)
        {
            Model = model;
        }

        // Sealing a method always needs to be done after a method has been overriden already.
        // the method won't be accessible to future chil classes. It closes it from further inheritances.
        public sealed override void Repair()
        {
            base.Repair();
        }
    }
}
