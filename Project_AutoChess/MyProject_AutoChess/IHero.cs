using System.Text;
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
        public string ShowHeroInfo();
        public int GetLocationHero();
        public string GetHeroName();
        public int GetHP();
        public int GetDamageHero();
    } // end of class IHero
}
