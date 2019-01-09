using System;

namespace IoCContainer.Objects
{
    public class Sward : IWeapon
    {
        public void Kill()
        {
            Console.WriteLine("Chick-Chick");
        }
    }
}
