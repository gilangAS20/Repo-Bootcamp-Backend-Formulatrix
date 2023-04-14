namespace MyProject_AutoChess
{
    public class Garo : IMech
    {
        //properties
        public int locationHero {get; set;}
        public string heroName {get;set;}
        public int HP {get;set;} // HP = Health Points
        public int damageHero {get;set;}
        public int heart {get;set;} // “Aturan sendiri”, jika heart bertambah maka, HP nya akan bertambah 10
        public int golden {get;set;} // “Aturan sendiri”, jika golden bertambah maka, Damage nya akan bertambah 1

        public Garo()
        {
            locationHero = 0;
            heroName = "garo";
            HP = 90;
            damageHero = 5;
            heart = 2;
            golden = 3;
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