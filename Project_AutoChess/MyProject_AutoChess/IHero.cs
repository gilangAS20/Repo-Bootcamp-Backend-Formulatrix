namespace MyProject_AutoChess
{
    public interface IHero
    {
        // properties
        public int locationHero {get; set;}
        public string heroName {get;set;}
        public int HP {get;set;} // HP = Health Points
        public int damageHero {get;set;}


        // methods
        public int GetLocationHero();
        public string GetHeroName();
        public int GetHP();
        public int GetDamageHero();
    }

    
    /*
    public class IMech : IHero
    {
        // properties
        public int LocationHero {get; set;}
        public string HeroName {get;set;}
        public int HP {get;set;} // HP = Health Points
        public int DamageHero {get;set;}
        public int Heart {get;set;} // “Aturan sendiri”, jika heart bertambah maka, HP nya akan bertambah 10
        public int Golden {get;set;} // “Aturan sendiri”, jika golden bertambah maka, Damage nya akan bertambah 1

        // method
        public int GetLocationHero()
        {
            return 0; // smeentara dulu
        }

        public string GetHeroName()
        {
            return "IMech";
        }

        public int GetHP()
        {
            return 100;
        }

        public int GetDamageHero()
        {
            return 2;
        }

        public int GetHeart()
        {
            return 0;
        }

        public int GetGolden()
        {
            return 0;
        }
    }
    */


}
