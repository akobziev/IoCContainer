namespace IoCContainer.Test
{
    class Warior
    {
        public IWeapon Weapon { get; set; }

        public Warior(IWeapon weapon)
        {
            Weapon = weapon;
        }

        public void Shoot()
        {
            Weapon.Kill();
        }
    }
}
