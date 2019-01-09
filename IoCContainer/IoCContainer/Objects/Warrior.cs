using System;

namespace IoCContainer.Objects
{
    public class Warrior : ICharacter
    {
        public IWeapon Weapon { get; private set; }

        public Warrior(IWeapon weapon)
        {
            Weapon = weapon;
        }

        public void Shoot()
        {
            if (Weapon != null)
            {
                Weapon.Kill();
            }
            else
            {
                throw new InvalidOperationException("Warior has now weapon.");
            }
        }
    }
}
