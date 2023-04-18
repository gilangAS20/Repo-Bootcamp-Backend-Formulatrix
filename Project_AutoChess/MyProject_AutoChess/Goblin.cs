namespace MyProject_AutoChess
{
    public class Goblin : IGoblin
    {
        // properties
        public int locationHero {get;set;}
        public string heroName {get;set;}
        public int HP {get;set;} // HP = Health Points
        public int damageHero {get;set;}
        public int armor {get;set;}
        public int HPRegeneration {get;set;}

        public Goblin()
        {
            locationHero = 0;
            heroName = "goblin";
            HP = 90;
            damageHero = 3;
            armor = 3;
            HPRegeneration = 1;
        }

        public string ShowHeroInfo()
        {
            return default;
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