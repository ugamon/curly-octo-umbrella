
namespace Quest.Domain
{

    public class Archer : IPersona, IAction
    {
        public Archer() {
            Name = "Deadly archer";
            Description = "Deadly archer";

        }
        public string Name { get; }

        public string Description { get; }

        public double Damage => 0.5 * 100.0;

       

        public override string ToString()
        {
            return this.Name;
        }

    }

    public struct Weapon(string name, double damage);

    

    public class ArcherAttributes: IHeroAttributes
    {
        public ArcherAttributes()
        {
            HP = 100.0;
            MANA = 10.0;
            EXP = 0;
            DEX = 100;
            STR = 15;
        }

        public double HP { get; set; }
        public double MANA { get; set; }
        public int EXP { get; set; }
        public int DEX { get; set; }
        public int STR { get; set; }
    }


    public class Hero(int age, string name, IHeroClass heroClass, IHeroAttributes attributes): IPersona
    {
        public int Age => age;
        public string Name => name;
        
        public int level { get; } = 0;

        public IHeroClass HeroClass => heroClass;
        public IHeroAttributes Attributes => attributes;

        public void Shout() => Console.WriteLine($"Greeting! My name is {name} and i am a {heroClass} hero! \nWas born {age} ago in nearest village to become the most famous in the world!");
    }
}
