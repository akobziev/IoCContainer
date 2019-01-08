using IoCContainer.Test;

namespace IoCContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var cont = new Container();

            var warior = (Warior)cont.Get(typeof(Warior));
        }
    }
}
