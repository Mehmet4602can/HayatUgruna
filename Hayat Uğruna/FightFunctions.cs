using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hayat_Uğruna
{
    internal class FightFunctions
    {
        
        public static int Fight1(ref Karakterler selectCharacter, Mafia mafiaMan)
        {
            Console.WriteLine("Dövüş sistemi; Öncelikle 1-3 arası bir seçim yapın.\nDaha sonra Ok işareti bitip 'Şimdi! entere bas' Yazısı geldiği anda Enter tuşuna basın.\nNekadar hızlı basabilirseniz okadar hasar verirsiniz. Düşmanı öldürmeden savaştan çıkamazsınız. İyi oyunlar.");
            Console.ReadLine();
            Console.Clear();
            string secim = "1";
            while (mafiaMan.HP > 0)
            {
                Console.Clear();
                Console.Write($"Güncel Canın = ");
                EfectFunctions.graficHPBar(selectCharacter.HP, 100);

                Console.WriteLine($"Savaş Başladı! {selectCharacter.Name} vs Mafya Adamı");
                Console.WriteLine("1.Yumruk at\n2.Tekme at\n3.Teslim Ol");
                Console.WriteLine("Seçim yapın: ");
                secim = Console.ReadLine();
                if (!int.TryParse(secim, out int hareket) || hareket < 1 || hareket > 3)
                {
                    Console.WriteLine($"{selectCharacter.Name} Hiçbirşey yapmadı.");
                    Console.ReadKey();
                    continue;
                }
                if (secim == "3")
                {
                    Console.WriteLine($"{selectCharacter.Name} teslim oldu. Mafya adamı seni Öldürdü.");
                    Console.ReadLine();
                    return 1;
                }

                else if (secim == "1")
                {

                    int hasar = Hit(selectCharacter);
                    CharacterUpdate.MafiaManHPDown(mafiaMan, hasar);
                    EfectFunctions.FightPunchEfect(selectCharacter, mafiaMan);
                    Console.WriteLine($"{selectCharacter.Name}, Mafya Adamı 'na {hasar} hasar verdi! Kalan can: {mafiaMan.HP}");
                    Console.ReadLine();
                }
                else if (secim == "2")
                {

                    int hasar = Hit(selectCharacter);
                    CharacterUpdate.MafiaManHPDown(mafiaMan, hasar);
                    EfectFunctions.FightKickEfect(selectCharacter, mafiaMan);
                    Console.WriteLine($"{selectCharacter.Name}, Mafya Adamı'na {hasar} hasar verdi! Kalan can: {mafiaMan.HP}");
                }


                if (mafiaMan.HP <= 0)
                {
                    Console.WriteLine("Düşmanı yendiniz!");
                    Console.ReadLine();
                }

                int dusmanHasar = mafiaMan.Attack / 2;
                CharacterUpdate.CharacterHPDown(selectCharacter, dusmanHasar);
                EfectFunctions.FightPunchDusmanEfect(selectCharacter, mafiaMan);
                Console.WriteLine($"Mafya Adamı, {selectCharacter.Name}'na {dusmanHasar} hasar verdi! Kalan can: {selectCharacter.HP}");
                Console.Write($"Güncel Canın = ");
                EfectFunctions.graficHPBar(selectCharacter.HP, 100);
                if (selectCharacter.HP <= 0)
                {
                    Console.WriteLine($"Mafyanın adamı {selectCharacter.Name}'ı Öldürdü.");
                    Console.ReadLine();
                    return 1;
                }
                Console.ReadKey();
                
            }
            return 0;
        }
        public static int Fight2(ref Karakterler selectCharacter, Mafia mafiaMans)
        {
            string secim = "1";

            while (mafiaMans.HP > 0)
            {
                Console.Clear();
                Console.Write($"Güncel Canın = ");
                EfectFunctions.graficHPBar(selectCharacter.HP, 100);
                Console.WriteLine($"Savaş Başladı! {selectCharacter.Name} vs Mafya Adamları");
                Console.WriteLine("1.Karşılık ver\n2.Çatıdan üstlerine atla\n3.Teslim Ol");
                Console.Write("Seçim yapın: ");
                secim = Console.ReadLine();

                if (!int.TryParse(secim, out int hareket) || hareket < 1 || hareket > 3)
                {
                    Console.WriteLine($"Yanlış tuşa bastınız.");
                    Console.ReadKey();
                    continue;
                }

                if (secim == "3")
                {
                    Console.WriteLine($"{selectCharacter.Name} teslim oldu. Mafya adamları seni Öldürdü.");
                    Console.ReadKey();
                    return 1;
                }

                else if (secim == "1")
                {
                    int hasar = Hit(selectCharacter);
                    CharacterUpdate.MafiaManHPDown(mafiaMans, hasar);
                    EfectFunctions.FightGunEfect(selectCharacter, mafiaMans);
                    Console.WriteLine($"{selectCharacter.Name}, Mafya Adamları'na {hasar} hasar verdi! Kalan can: {mafiaMans.HP}");

                }
                else if (secim == "2")
                {
                    int hasar = Hit(selectCharacter);
                    EfectFunctions.FightJumpEfect(selectCharacter, mafiaMans);
                    CharacterUpdate.MafiaManHPDown(mafiaMans, hasar);
                    Console.WriteLine($"{selectCharacter.Name}, Mafya Adamlarına {hasar} hasar verdi! Kalan can: {mafiaMans.HP}");
                }
                if (mafiaMans.HP <= 0)
                {
                    Console.WriteLine("Düşmanı yendiniz!");
                    Console.ReadKey();
                    return 0;
                }
                int dusmanHasar = mafiaMans.Attack / 2;
                CharacterUpdate.CharacterHPDown(selectCharacter, dusmanHasar);
                EfectFunctions.FightGunDusmanEfect(selectCharacter, mafiaMans);
                Console.WriteLine($"Mafya Adamları, {selectCharacter.Name}'na {dusmanHasar} hasar verdi! Kalan can: {selectCharacter.HP}");
                Console.Write($"Güncel Canın = ");
                EfectFunctions.graficHPBar(selectCharacter.HP, 100);

                if (selectCharacter.HP <= 0)
                {
                    Console.WriteLine($"Mafyanın adamı {selectCharacter.Name}'ı Öldürdü.");
                    Console.ReadKey();
                    return 1;
                }
                Console.ReadLine();
                
            }
            return 0;
        }
        public static int Fight3(ref Karakterler selectCharacter, Mafia mafiaMans)
        {
            string secim = "1";
            while (mafiaMans.HP > 0)
            {
                Console.Clear();
                Console.Write($"Güncel Canın = ");
                EfectFunctions.graficHPBar(selectCharacter.HP, 100);
                Console.WriteLine($"Savaş Başladı! {selectCharacter.Name} vs Mafya Adamları");
                Console.WriteLine("1.Karşılık ver\n2.Zamanı yavşlatarak hareketleri iyi kullan\n3.Teslim Ol");
                Console.Write("Seçim yapın: ");
                secim = Console.ReadLine();

                if (!int.TryParse(secim, out int hareket) || hareket < 1 || hareket > 3)
                {
                    Console.WriteLine($"{selectCharacter.Name} Hiçbirşey yapmadı.");
                    Console.ReadKey();
                    continue;
                }

                if (secim == "3")
                {
                    Console.WriteLine($"{selectCharacter.Name} teslim oldu. Mafya adamları Hepinizi Öldürdü.");
                    Console.ReadKey();
                    return 1;
                }

                else if (secim == "1")
                {
                    int hasar = Hit(selectCharacter);
                    EfectFunctions.FightGunEfect(selectCharacter, mafiaMans);
                    CharacterUpdate.MafiaManHPDown(mafiaMans, hasar);
                    Console.WriteLine($"{selectCharacter.Name}, Mafya Adamları'na {hasar} hasar verdi! Kalan can: {mafiaMans.HP}");

                }
                else if (secim == "2")
                {
                    int hasar = Hit(selectCharacter);
                    EfectFunctions.FightGunEfect(selectCharacter, mafiaMans);
                    CharacterUpdate.MafiaManHPDown(mafiaMans, hasar);
                    Console.WriteLine($"{selectCharacter.Name}, Mafya Adamlarına {hasar} hasar verdi! Kalan can: {mafiaMans.HP}");
                }
                if (mafiaMans.HP <= 0)
                {
                    Console.WriteLine("Düşmanı yendiniz!");
                    Console.ReadKey();
                    return 0;
                }
                int dusmanHasar = mafiaMans.Attack / 2;
                CharacterUpdate.CharacterHPDown(selectCharacter, dusmanHasar);
                EfectFunctions.FightGunDusmanEfect(selectCharacter, mafiaMans);
                Console.WriteLine($"Mafya Adamları, {selectCharacter.Name}'na {dusmanHasar} hasar verdi! Kalan can: {selectCharacter.HP}");
                Console.Write($"Güncel Canın = ");
                EfectFunctions.graficHPBar(selectCharacter.HP, 100);

                if (selectCharacter.HP <= 0)
                {
                    Console.WriteLine($"Mafyanın adamı {selectCharacter.Name}'ı Öldürdü.");
                    Console.ReadKey();

                    return 1;
                }
                Console.ReadKey();
            }
            return 0;
        }
        public static void BossFight(ref Karakterler selectCharacter, Mafia dusmanDost)
        {
            string secim = "1";
            selectCharacter.Name = selectCharacter.BestFirend;
            selectCharacter.HP = 85;
            int s = 0;
            int m = 0;
            while (true)
            {
                Console.Clear();
                Console.Write($"Güncel Canın = ");
                EfectFunctions.graficHPBar(selectCharacter.HP, 100);
                Console.WriteLine($"Savaş Başladı! {selectCharacter.BestFirend} vs {dusmanDost.Name}");
                Console.WriteLine("1.Yumruk at\n2.Tekme at\n3.Yalvar");
                Console.Write("Seçim yapın: ");
                secim = Console.ReadLine();
                if (s == 0)
                {
                    Console.WriteLine("-Eğer beni eğlendirebilirsen");
                    Console.WriteLine("-Hiç birşey olmamış gibi Herşeyi gei alırım.");
                    Console.ReadKey();
                }
                if (s == 5)
                {
                    Console.WriteLine("-Bak bu beni eğlendiriyor. Ha yine iyisin");

                }
                if (!int.TryParse(secim, out int hareket) || hareket < 1 || hareket > 3)
                {
                    Console.WriteLine($"{selectCharacter.BestFirend} Hiçbirşey yapmadı.");
                    Console.ReadKey();
                    continue;
                }

                if (secim == "3")
                {
                    Console.WriteLine($"-{selectCharacter.BestFirend} Adam ol");
                    Console.ReadKey();
                    continue;
                }

                else if (secim == "1")
                {
                    int hasar = Hit(selectCharacter);
                    CharacterUpdate.MafiaManHPDown(dusmanDost, hasar);
                    EfectFunctions.FightPunchEfect(selectCharacter, dusmanDost);
                    Console.WriteLine($"{selectCharacter.BestFirend}, {dusmanDost.Name}'a {hasar} hasar verdi! Kalan can: {dusmanDost.HP}");

                }
                else if (secim == "2")
                {
                    int hasar = Hit(selectCharacter);
                    CharacterUpdate.MafiaManHPDown(dusmanDost, hasar);
                    EfectFunctions.FightKickEfect(selectCharacter, dusmanDost);
                    Console.WriteLine($"{selectCharacter.BestFirend}, {dusmanDost.Name}'a {hasar} hasar verdi! Kalan can: {dusmanDost.HP}");
                }
                if (dusmanDost.HP <= 0)
                {
                    if (m == 10)
                    {
                        Console.WriteLine("-Tamam zevkimi aldım. Herşeyi düzelte bilirim.");
                        Console.ReadKey();
                        Console.WriteLine("-Ama bu yaptıklarımın hepsi sizinle kaliteli zaman geçirebilmek içindi.");
                        Console.WriteLine("-Baksana sen her defasında bu olaylar yaşanmamış gibi olacak ama ben unutmayacam.");
                        Console.ReadKey();
                        Console.WriteLine("-Bu benim çok zoruma gidiyor.");
                        Console.ReadKey();

                        Console.WriteLine("-Evet ailemi öldürdüm fakat istediğim zaman gidip görebiliyorum.");
                        Console.ReadKey();
                        Console.WriteLine($"{selectCharacter.BestFirend}\n-Ama");

                        Console.WriteLine("-Şşşş");
                        Console.WriteLine("-Zaten herşeyi yaptım döngü hiç bitmiyor bende zevkine herşeyi yapıyorum.");
                        Console.WriteLine("-Neyse eski halinle beraber Yaşamaya devam edelim.");

                        break;
                    }
                    else
                    {
                        Console.WriteLine("-Afferin lan sucuk olmaktan kurtuldun");
                        Console.WriteLine("-Ama daha bitmedi.");
                        m++;
                        CharacterUpdate.DusmanDostHpUp(dusmanDost, 100);
                        Console.WriteLine($"{dusmanDost.Name}'ın Canı 100 arttı.");
                    }
                }
                int dusmanHasar = dusmanDost.Attack / 2;
                EfectFunctions.FightPunchDusmanEfect(selectCharacter, dusmanDost);
                CharacterUpdate.CharacterHPDown(selectCharacter, dusmanHasar);
                Console.WriteLine($"{dusmanDost.Name}, {selectCharacter.BestFirend}'na {dusmanHasar} hasar verdi! Kalan can: {selectCharacter.HP}");
                Console.Write($"Güncel Canın = ");
                EfectFunctions.graficHPBar(selectCharacter.HP, 100);

                if (selectCharacter.HP <= 0)
                {
                    if (s == 10)
                    {
                        Console.WriteLine("-Tamama zevkimi aldım herşeyi düzelte bilirim.");
                        Console.ReadKey();
                        Console.WriteLine("-Ama bu yaptıklarımın hepsi sizinle kaliteli zaman geçirebilmek içindi.");
                        Console.WriteLine("-Baksana sen her defasında bu olaylar yaşanmamış gibi olacak ama ben unutmayacam.");
                        Console.ReadKey();
                        Console.WriteLine("-Bu benim çok zoruma gidiyor.");
                        Console.ReadKey();

                        Console.WriteLine("-Evet ailemi öldürdüm fakat istediğim zaman gidip görebiliyorum.");
                        Console.ReadKey();
                        Console.WriteLine($"{selectCharacter.BestFirend}\n-Ama");

                        Console.WriteLine("-Şşşş");
                        Console.WriteLine("-Zaten herşeyi yaptım döngü hiç bitmiyor bende zevkine herşeyi yapıyorum.");
                        Console.WriteLine("-Neyse eski halinle beraber Yaşamaya devam edelim.");

                        break;

                    }
                    else
                    {
                        Console.WriteLine($"-Bu kadar kolay ölemezsin");
                        Console.ReadKey();
                        Console.WriteLine($"Canın 100 arttı");
                        CharacterUpdate.CharacterHpUp(selectCharacter, 100);
                        Console.Write($"Güncel Canın = ");
                        EfectFunctions.graficHPBar(selectCharacter.HP, 100);
                        s++;
                        continue;
                    }
                }
                Console.ReadKey();
            }
        }
        public static int Hit(Karakterler karakter)
        {
            bool flag = true;
            Console.WriteLine("Çizgi Bittiği Anda Entere Bas!");
            while (Console.KeyAvailable) { Console.ReadKey(true); }
            for (int i = 0; i < 20; i++)
            {
                Console.Write("|" + new string('=', i) + ">");
                Thread.Sleep(100);
                Console.SetCursorPosition(0, Console.CursorTop);
            }
            while (Console.KeyAvailable) { flag = false; break; }
            Console.WriteLine("\nŞimdi!!! Enter'a bas");
            Stopwatch kronometre = new Stopwatch();
            kronometre.Start();
            Console.ReadKey();
            kronometre.Stop();


            double sure = kronometre.ElapsedMilliseconds;

            if (flag)
            {
                if (sure <= 200)
                {
                    Console.WriteLine("Mükemmel! Ekstra hasar verdin.");
                    return karakter.Attack / 2;
                }
                else if (sure <= 500)
                {
                    Console.WriteLine("İyi vuruş! Normal hasar verdin.");
                    return karakter.Attack / 2 - 5;
                }
                else
                {
                    Console.WriteLine("Geç kaldın! Zayıf bir hasar verdin.");
                    return karakter.Attack / 2 - 10;
                }
            }
            else
            {
                Console.WriteLine("Çok Erken");
                return karakter.Attack / 3 - 5;
            }
        }
    }
}
