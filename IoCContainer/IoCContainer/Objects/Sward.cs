﻿using System;

namespace IoCContainer.Objects
{
    class Sward : IWeapon
    {
        public void Kill()
        {
            Console.WriteLine("Chick-Chick");
        }
    }
}
