using System;

namespace IoCContainer.Objects
{
    public class Bow : IWeapon
    {
        public void Kill()
        {
            Console.WriteLine("Pio-Pio");
        }
    }
}
