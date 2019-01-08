using System;

namespace IoCContainer.Objects
{
    public class Warrior : ICharacter
    {
        public IWeapon Weapon { get; private set; }

        public Warrior()
        {

        }

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
            throw new InvalidOperationException("Warior has now weapon.");
        }
    }
}
