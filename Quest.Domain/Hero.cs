
using System.ComponentModel;

namespace Quest.Domain
{

    public class Archer: IHeroClass {

        public string Name => "Chaos archer";

        public string Description => "Chaos archer";

        public override string ToString()
        {
            return $"{Name}";
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


    public class Person(int age, string name, IHeroClass heroClass, IHeroAttributes attributes): IPersona
    {
        public int Age => age;
        public string Name => name;
        public int level { get; } = 0;
        public IHeroClass HeroClass => heroClass;
        public IHeroAttributes Attributes => attributes;

        public List<Weapon> Weapons => [];

        public void EquipWeapon(Weapon weapon){
            this.Weapons.Add(weapon);    
        }

        public void Shout() => Console.WriteLine($"Greeting! My name is {name} and i am a {heroClass} hero! \nWas born {age} ago in nearest village to become the most famous in the world!");
    }
}
