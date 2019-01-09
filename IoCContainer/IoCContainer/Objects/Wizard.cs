using System;

namespace IoCContainer.Objects
{
    public class Wizard : ICharacter
    {
        public IWeapon Weapon { get; private set; }
        public IMagicObject MagicObject { get; private set; }

        public Wizard(IWeapon mainWeapon, IMagicObject magicObject)
        {
            Weapon = mainWeapon;
            MagicObject = magicObject;
        }

        public void Shoot()
        {
            if (Weapon != null && MagicObject != null)
            {
                Weapon.Kill();
                MagicObject.Cast();
            }
            else
            {
                throw new InvalidOperationException("Wizard has now weapon.");
            }
        }
    }
}
