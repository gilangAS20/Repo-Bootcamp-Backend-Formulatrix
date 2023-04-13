namespace MyProject_AutoChess
{
    public interface IAssassin : IHero
    {
        // properties
        public int LocationHero {get; set;}
        public string HeroName {get;set;}
        public int HP {get;set;} // HP = Health Points
        public int DamageHero {get;set;}
        public double Chance {get;set;}

        // method
        public int GetLocationHero();
        public string GetHeroName();
        public int GetHP();
        public int GetDamageHero();
        public double GetChance();
    } // end of class IAssassin
}