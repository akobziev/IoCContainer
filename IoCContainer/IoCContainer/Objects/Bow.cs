using System;

namespace IoCContainer.Test
{
    public class Bow : IWeapon
    {
        public void Kill()
        {
            Console.WriteLine("Pio-Pio");
        }
    }
}
