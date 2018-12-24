namespace IoCContainer.Test
{
    public class Warrior
    {
        public IWeapon Weapon { get; set; }

        public Warrior(IWeapon weapon)
        {
            Weapon = weapon;
        }

        public void Shoot()
        {
            Weapon.Kill();
        }
    }
}
