using System.Text;
namespace MyProject_AutoChess
{
    public class Garo : IMech // --> Garo memiliki HP besar tapi damage-nya sangat kecil
    {
        //properties
        public int locationHero {get; set;}
        public string heroName {get;set;}
        public int HP {get;set;} // HP = Health Points
        public int damageHero {get;set;}
        public int heart {get;set;} 
        public int golden {get;set;} 
        private Random _random = new Random();

        public Garo(int locationInput)
        {
            heart = _random.Next(0, 5);
            golden = _random.Next(1, 4);

            locationHero = locationInput;
            heroName = "garo";
            HP = _random.Next(150, 200) + (heart*2);
            damageHero = _random.Next(2, 5) + golden;
        }

        public string ShowHeroInfo()
        {   
            StringBuilder heroInfo = new StringBuilder();
            heroInfo.Append("\nHero: " + heroName);
            heroInfo.Append("\nHP: " + HP);
            heroInfo.Append("\nDamage: " + damageHero);
            heroInfo.Append("\nHeart of Mech: " + heart);
            heroInfo.Append("\nGolden Heart of Mech: " + golden);
            heroInfo.Append("\nLocation: " + locationHero);
            heroInfo.Append("\n");
            return heroInfo.ToString();
        }

        // methods
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