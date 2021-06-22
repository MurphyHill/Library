using System;

namespace LibraryJune22
{
    public class Character
    {
        public string name = "Inwv";
        public int health = 100;
        public int damage = 24;
        public int armour = 5;
        public int travelSpeed = 280;

        public Character(string name, int health, int damage, int armour, int travelSpeed)
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
            this.armour = armour;
            this.travelSpeed = travelSpeed;
        }

        public void Punch()
        {
            Console.WriteLine("Удар рукой");
        }
        public void СoldWeaponStrike()
        {
            Console.WriteLine("Удар холодным оружием");
        }
        public void RestoreHealth()
        {
            Console.WriteLine("Восстановление здоровья");
        }
        public void RunAway()
        {
            Console.WriteLine("Убежать");
        }
        public void PutDefense()
        {
            Console.WriteLine("Поставить защиту");
        }
    }
}
