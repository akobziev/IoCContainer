using System;

namespace IoCContainer.Objects
{
    public abstract class Thief : ICharacter
    {
        public IWeapon Weapon { get; private set; }

        public Thief(IWeapon weapon)
        {
            Weapon = weapon;
        }

        public void Shoot()
        {
            if (Weapon != null)
            {
                Weapon.Kill();
            }
            throw new InvalidOperationException("Thief has now weapon.");
        }
    }
}
