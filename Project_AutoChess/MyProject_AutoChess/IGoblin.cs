namespace MyProject_AutoChess
{
    public interface IGoblin : IHero
    {
        // properties
        public int locationHero {get;set;}
        public string heroName {get;set;}
        public int HP {get;set;} // HP = Health Points
        public int damageHero {get;set;}
        public int armor {get;set;}
        public int HPRegeneration {get;set;}
    

        // method
        public string ShowHeroInfo();
        public int GetLocationHero();

        public string GetHeroName();

        public int GetHP();

        public int GetDamageHero();

        public int GetArmor();

        public int GetHPRegeneration();
    } // end of class IGoblin
}