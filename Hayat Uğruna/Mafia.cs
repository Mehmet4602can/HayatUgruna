using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hayat_Uğruna
{
    internal class Mafia
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public Mafia(string name, int mafiaHp, int mafiaAttack)
        {
            Name = name;
            HP = mafiaHp;
            Attack = mafiaAttack;
        }

    }
}
