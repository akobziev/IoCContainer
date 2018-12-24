using IoCContainer.Test;

namespace IoCContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var cont = new Container();
            cont.Binde<IWeapon, Sward>();

            var warior = (Warior)cont.Get(typeof(Warior));
            warior.Shoot();
        }
    }
}
