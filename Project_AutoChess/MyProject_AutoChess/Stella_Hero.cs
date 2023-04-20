using System.Text;
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
        public int heart {get;set;} 
        public int golden {get;set;} 
        private Random random = new Random();
        
        public Stella(int locationInput)
        {
            armor = random.Next(0, 4);
            HPRegeneration = 1;
            heart = random.Next(0, 5);
            golden = random.Next(1, 4);

            locationHero = locationInput;
            heroName = "stella";
            HP = random.Next(90, 140) + heart;
            damageHero = random.Next(7, 10) + golden;
        }

        public string ShowHeroInfo()
        {   
            StringBuilder heroInfo = new StringBuilder();
            heroInfo.Append("\nHero: " + heroName);
            heroInfo.Append("\nHP: " + HP);
            heroInfo.Append("\nDamage: " + damageHero);
            heroInfo.Append("\nArmor: " + armor);
            heroInfo.Append("\nHP Regeneration: " + HPRegeneration);
            heroInfo.Append("\nHeart of Mech: " + heart);
            heroInfo.Append("\nGolden Heart of Mech: " + golden);
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