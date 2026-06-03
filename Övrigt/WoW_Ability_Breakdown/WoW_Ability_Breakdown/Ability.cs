using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_Ability_Breakdown
{
    abstract class Ability
    {
        public string name;
        public int maxRange;
        public int minRange;
        public int maxDamage;
        public int minDamage;
        public float coolDown;
        public float castTime;
        public int resource;
    }
}
