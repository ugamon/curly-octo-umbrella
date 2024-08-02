using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest.Domain
{
    public interface IPersona
    {
        public int Age { get; }
        public string Name { get; }
        virtual bool isAlive => true ? Attributes.HP > 0 : false;

        public IHeroClass HeroClass { get; }

        public IHeroAttributes Attributes { get; } 
        
        public List<Weapon>Weapons { get; set; }


    }

    public interface IAction
    {
        public void Hit(double attack);

        public void Attack(double attack);

    }
}
