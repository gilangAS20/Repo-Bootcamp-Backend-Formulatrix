namespace MyProject_AutoChess
{
    public interface IAssassin : IHero
    {
        // properties
        public int locationHero {get; set;}
        public string heroName {get;set;}
        public int HP {get;set;} // HP = Health Points
        public int damageHero {get;set;}
        public int chance {get;set;}

        // method
        public string ShowHeroInfo();
        public int GetLocationHero();
        public string GetHeroName();
        public int GetHP();
        public int GetDamageHero();
        public int GetChance();
    } // end of class IAssassin
}