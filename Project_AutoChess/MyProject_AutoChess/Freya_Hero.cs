using System.Text;
namespace MyProject_AutoChess
{
    public class Freya : IAssassin, IGoblin
    {
        // properties
        public int locationHero {get; set;}
        public string heroName {get;set;}
        public int HP {get;set;} // HP = Health Points
        public int damageHero {get;set;}
        public int chance {get;set;}
        public int armor {get;set;}
        public int HPRegeneration {get;set;}
        private Random _random = new Random();

        public Freya(int locationInput)
        {
            chance = _random.Next(0, 5);
            armor = _random.Next(0, 3);
            HPRegeneration = 1;

            locationHero = locationInput;
            heroName = "freya";
            HP = _random.Next(80, 120) + armor + HPRegeneration;
            damageHero = _random.Next(15, 20) + chance;
        }

        public string ShowHeroInfo()
        {
            StringBuilder heroInfo = new StringBuilder();
            heroInfo.Append("\nHero: " + heroName);
            heroInfo.Append("\nHP: " + HP);
            heroInfo.Append("\nDamage: " + damageHero);
            heroInfo.Append("\nChance: " + chance);
            heroInfo.Append("\nArmor: " + armor);
            heroInfo.Append("\nHP Regeneration: " + HPRegeneration);
            heroInfo.Append("\nLocation: " + locationHero);
            heroInfo.Append("\n");
            return heroInfo.ToString();
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

        public int GetChance()
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
    } // end of class Freya
}