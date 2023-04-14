namespace MyProject_AutoChess
{
    public class Assassin : IAssassin
    {
        // properties
        public int locationHero {get; set;}
        public string heroName {get;set;}
        public int HP {get;set;} // HP = Health Points
        public int damageHero {get;set;}
        public double chance {get;set;}

        public Assassin()
        {
            locationHero = 0;
            heroName = "assassin";
            HP = 100;
            damageHero = 10;
            chance = 0.5;
        }

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
    }

}