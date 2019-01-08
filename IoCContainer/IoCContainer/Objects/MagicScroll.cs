using System;

namespace IoCContainer.Objects
{
    public class MagicScroll : IMagicObject
    {
        public void Cast()
        {
            Console.WriteLine("Avada Kedavra");
        }
    }
}
