using System;

namespace IoCContainer.Objects
{
    class Staff : IWeapon
    {
        public void Kill()
        {
            Console.WriteLine("Feo-Feo!");
        }
    }
}
