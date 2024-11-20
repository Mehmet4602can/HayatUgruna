using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hayat_Uğruna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int tekrar = 0;
                while (true)
                {
                    Karakterler selectCharacter = null;
                    Mafia mafiaMan = new Mafia("Mafya Adamı", 30, 20);
                    Mafia mafiaMans = new Mafia("Mafya Adamları", 70, 30);
                    StoryFunctions.CharacterSelect();
                    SwitchGo(ref selectCharacter);
                    StoryFunctions.StoryStart(selectCharacter);
                    tekrar = FightFunctions.Fight1(ref selectCharacter, mafiaMan);
                    if (tekrar == 1)
                    {
                        break;
                    }
                    StoryFunctions.StoryMeet(selectCharacter);
                    tekrar = FightFunctions.Fight2(ref selectCharacter, mafiaMans);
                    if (tekrar == 1)
                    {
                        break;
                    }
                    string sevgi = StoryFunctions.StoryPlace(ref selectCharacter);
                    mafiaMans.HP = 70;
                    tekrar = FightFunctions.Fight3(ref selectCharacter, mafiaMans);
                    if (tekrar == 1)
                    {
                        break;
                    }
                    StoryFunctions.StoryFight(ref selectCharacter, sevgi);
                    Mafia dusmanDost = new Mafia(selectCharacter.Name, 85, 100);
                    FightFunctions.BossFight(ref selectCharacter, dusmanDost);
                    StoryFunctions.StoryFinaly(ref selectCharacter, dusmanDost);
                }
                Console.Clear();
                Console.WriteLine("Sucuk oldun.");
                Console.ReadLine();
                Console.WriteLine("Tekrar dene.");
                Console.ReadLine();
            }
        }      
        static int SwitchSelect(string Selected,ref Karakterler selectCharacter)
        {
            switch (Selected)
            {
                case "1":
                    selectCharacter = new Karakterler("Mehmetcan", "Cemre", "Süleyman", "Ticaret ve Sanayi Odası MTAL Bilişim Bölümüne", 100, 40, 35);
                    return 1;
                case "2":
                    selectCharacter = new Karakterler("Apdurrahman", "Büşra", "Mustafa", "Teknokent Koleji Bilişim Bölümüne", 100, 35, 10);
                    return 1;
                case "3":
                    selectCharacter = new Karakterler("Süleyman", "Nisa", "Mehmetcan", "Ticaret ve Sanayi Odası MTAL Bilişim Bölümüne", 100, 30, 30);
                    return 1;
                case "4":
                    selectCharacter = new Karakterler("Mali", "Emine", "Nuri", "Şehit İdere Ateşe Galip Özmen MTAL Bilişim Bölümüne", 100, 45, 10);
                    return 1;
                case "5":
                    selectCharacter = new Karakterler("Keleş", "Aslı", "Hafız", "Kahramanmaraş Süleyman Demirel Fen Lisesi'ne", 100, 20, 15);
                    return 1;
                case "6":
                    selectCharacter = new Karakterler("Hafız", "Nehir", "Keleş", "Kahramanmaraş Süleyman Demirel Fen Lisesi'ne", 100, 40, 30);
                    return 1;
                case "7":
                    selectCharacter = new Karakterler("Burak", "Hande", "Usame", "Ticaret ve Sanayi Odası MTAL Bilişim Bölümüne", 100, 35, 25);
                    return 1;

                default:
                    Console.WriteLine("Yanlış seçim yaptınız tekrar deneyin!!!");
                    return 8;
            }
            
        }
        static void SwitchGo(ref Karakterler selectCharacter)
        {
            while (true)
            {
                Console.WriteLine("Seçminizi yapın...(1-7)");
                string Selected = Console.ReadLine();
                int select = SwitchSelect(Selected, ref selectCharacter);
                if (select == 8)
                    continue;
                break;
            }
        }
    }    
}
