namespace MyProject_AutoChess
{
    public interface IHero
    {
        // properties
        public int LocationHero {get; set;}
        public string HeroName {get;set;}
        public int HP {get;set;} // HP = Health Points
        public int DamageHero {get;set;}


        // methods
        public int GetLocationHero();
        public string GetHeroName();
        public int GetHP();
        public int GetDamageHero();
    }

    public class IAssassin : IHero
    {
        // properties
        public int LocationHero {get; set;}
        public string HeroName {get;set;}
        public int HP {get;set;} // HP = Health Points
        public int DamageHero {get;set;}
        public double Chance {get;set;}

        // method
        public int GetLocationHero()
        {
            return 0; // smeentara dulu
        }

        public string GetHeroName()
        {
            return "IAssassin";
        }

        public int GetHP()
        {
            return 100;
        }

        public int GetDamageHero()
        {
            return 10;
        }

        public double GetChance()
        {
            return 0.3;
        }
    } // end of class IAssassin

    public class IGoblin : IHero
    {
        // properties
        public int LocationHero {get;set;}
        public string HeroName {get;set;}
        public int HP {get;set;} // HP = Health Points
        public int DamageHero {get;set;}
        public int Armor {get;set;}
        public int HPRegeneration {get;set;}
    

        // method
        public int GetLocationHero()
        {
            return 0; // smeentara dulu
        }

        public string GetHeroName()
        {
            return "IGoblin";
        }

        public int GetHP()
        {
            return 100;
        }

        public int GetDamageHero()
        {
            return 3;
        }

        public int GetArmor()
        {
            return 2; // jika ada yang nge-attack, maka damage yang diterima akan dikurangi armor
        }

        public int GetHPRegeneration()
        {
            return 1; // setiap 1 detik, HP akan bertambah 1
        }
    } // end of class IGoblin

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


    public class Assassin : IAssassin
    {
        // properties
        public int LocationHero {get;set;}
        public string HeroName = "Assassin";
        public int HP {get;set;} = 100; // HP = Health Points
        public int DamageHero {get;set;} = 10;
        public double Chance {get;set;} = 0.3;

        // method
        public int GetLocationHero(int locationHero)
        {
            return locationHero;
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
