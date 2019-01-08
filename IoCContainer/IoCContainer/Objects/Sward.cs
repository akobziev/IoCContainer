using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCContainer.Test
{
    class Sward : IWeapon
    {
        public void Kill()
        {
            Console.WriteLine("Chick-Chick");
        }
    }
}
