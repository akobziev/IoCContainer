using System;

namespace IoCContainer.Test
{
    class Warior
    {
        public IWeapon Weapon { get; private set; }

        public Warior()
        {

        }

        public Warior(IWeapon weapon)
        {
            Weapon = weapon;
        }

        public void Shoot()
        {
            if (Weapon != null)
            {
                Weapon.Kill();
            }
            throw new InvalidOperationException("Warior has now weapon.");
        }
    }
}
