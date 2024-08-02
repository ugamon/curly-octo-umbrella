using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest.Domain
{
    public interface IHeroAttributes
    {
        public double HP { get; set; }

        public double MANA { get; set; }
        public int EXP { get; set;}

        public int DEX { get; set; }

        public int STR { get; set; }
         
    }
}
