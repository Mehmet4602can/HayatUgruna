using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hayat_Uğruna
{
    internal class Karakterler
    {
        public string Name { get; set; }
        public string LoveName { get; set; }
        public string BestFirend { get; set; }
        public string School { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Love { get; set; }
        public Karakterler(string name, string loveName, string bestFriend, string school, int hp, int attack, int love)
        {
            Name = name;
            LoveName = loveName;
            BestFirend = bestFriend;
            School = school;
            HP = hp;
            Attack = attack;
            Love = love;
        }
        
    }
}
