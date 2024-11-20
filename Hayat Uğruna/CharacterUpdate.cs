using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayat_Uğruna
{
    internal class CharacterUpdate
    {
        public static void CharacterLoveDown(Karakterler karakter, int Miktar)
        {
            karakter.Love -= Miktar;

        }
        public static void CharacterLoveUp(Karakterler karakter, int Miktar)
        {
            karakter.Love += Miktar;

        }
        public static void CharacterHpUp(Karakterler karakter, int Miktar)
        {
            karakter.HP += Miktar;

        }
        public static void CharacterAttackUp(Karakterler karakter, int Miktar)
        {
            karakter.Attack += Miktar;

        }
        public static void DusmanDostHpUp(Mafia karakter, int Miktar)
        {
            karakter.HP += Miktar;

        }
        public static void CharacterHPDown(Karakterler karakter, int Miktar)
        {
            karakter.HP -= Miktar;

        }
        public static void MafiaManHPDown(Mafia dusman, int Miktar)
        {
            dusman.HP -= Miktar;

        }
    }
}
