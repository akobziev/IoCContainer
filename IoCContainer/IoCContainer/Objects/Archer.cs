using System;

namespace IoCContainer.Objects
{
    public class Archer : ICharacter
    {
        public IWeapon Weapon { get; private set; }

        public Archer()
        {
            Weapon = new Bow();
        }

        public void Shoot()
        {
            if (Weapon != null)
            {
                Weapon.Kill();
            }
            throw new InvalidOperationException("Archer has now weapon.");
        }
    }
}
