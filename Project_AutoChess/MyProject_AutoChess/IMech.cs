namespace MyProject_AutoChess
{
    public interface IMech : IHero
    {
        //properties
        public int locationHero {get; set;}
        public string heroName {get;set;}
        public int HP {get;set;} // HP = Health Points
        public int damageHero {get;set;}
        public int heart {get;set;} // “Aturan sendiri”, jika heart bertambah maka, HP nya akan bertambah 10
        public int golden {get;set;} // “Aturan sendiri”, jika golden bertambah maka, Damage nya akan bertambah 1


        // methods
        public int GetLocationHero();
        public string GetHeroName();
        public int GetHP();
        public int GetDamageHero();
        public int GetHeartOfMech();
        public int GetGoldenHeartOfMech();
    }
}