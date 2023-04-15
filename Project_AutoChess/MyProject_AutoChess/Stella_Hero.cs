namespace MyProject_AutoChess
{
    public class Stella : IGoblin, IMech
    {
        // properties
        public int locationHero {get;set;}
        public string heroName {get;set;}
        public int HP {get;set;} // HP = Health Points
        public int damageHero {get;set;}
        public int armor {get;set;}
        public int HPRegeneration {get;set;}
        public int heart {get;set;} // “Aturan sendiri”, jika heart bertambah maka, HP nya akan bertambah 10
        public int golden {get;set;} // “Aturan sendiri”, jika golden bertambah maka, Damage nya akan bertambah 1
        Random random = new Random();
        public Stella()
        {
            locationHero = 0;
            heroName = "stella";
            HP = random.Next(80, 120);
            damageHero = random.Next(7, 10);
            armor = 3;
            HPRegeneration = 1;
            heart = 1;
            golden = 1;
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
        public int GetHeartOfMech()
        {
            return heart;
        }
        public int GetGoldenHeartOfMech()
        {
            return golden;
        }
    }

}