namespace MyProject_AutoChess
{
    public class Assassin : IAssassin
    {
        // properties
        public int LocationHero {get; set;}
        public string HeroName {get;set;}
        public int HP {get;set;} // HP = Health Points
        public int DamageHero {get;set;}
        public double Chance {get;set;}

        public Assassin()
        {
            LocationHero = 0;
            HeroName = "assassin";
            HP = 100;
            DamageHero = 10;
            Chance = 0.5;
        }

        public int GetLocationHero()
        {
            return LocationHero;
        }
        public string GetHeroName()
        {
            return HeroName;
        }
        public int GetHP()
        {
            return HP;
        }
        public int GetDamageHero()
        {
            return DamageHero;
        }
        public double GetChance()
        {
            return Chance;
        }
    }

}