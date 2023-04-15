namespace MyProject_AutoChess
{
    public class Freya : IAssassin, IGoblin
    {
        // properties
        public int locationHero {get; set;}
        public string heroName {get;set;}
        public int HP {get;set;} // HP = Health Points
        public int damageHero {get;set;}
        public double chance {get;set;}
        public int armor {get;set;}
        public int HPRegeneration {get;set;}
        Random random = new Random();
        public Freya()
        {
            locationHero = 0;
            heroName = "freya";
            HP = random.Next(80, 120);
            damageHero = random.Next(7, 10);
            chance = 0.3;
            armor = 3;
            HPRegeneration = 1;
        }

        // method
        public int GetLocationHero()
        {
            return locationHero;
        }

        public string GetHeroName()
        {
            return heroName;
        }

        public int GetHP()
        {
            return HP;
        }

        public int GetDamageHero()
        {
            return damageHero;
        }

        public double GetChance()
        {
            return chance;
        }

        public int GetArmor()
        {
            return armor;
        }

        public int GetHPRegeneration()
        {
            return HPRegeneration;
        }
    }

}