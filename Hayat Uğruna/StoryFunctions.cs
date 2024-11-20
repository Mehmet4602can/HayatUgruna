using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayat_Uğruna
{
    internal class StoryFunctions
    { 
        public static void CharacterSelect()
        {
            Console.WriteLine("Hayat Uğruna v4");
            Console.ReadKey();
            Console.WriteLine("Savaş vakti Yaşa yada Öl");
            Console.WriteLine();
            Console.WriteLine("Karakterini seç");

            Console.WriteLine();
            Console.WriteLine("1.Mehmetcan");
            Console.WriteLine("Özellikleri;");
            Console.WriteLine("Sevgilisi: Cemre");
            Console.WriteLine("Can: 100");
            Console.WriteLine($"Saldırı: 40");
            Console.Write("sevgi: 35");
            Console.WriteLine("(Sevgi Karakterlerin birbiri arasındaki ilişkileri etkiler)");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("2.Apdurrahman");
            Console.WriteLine("Özellikleri;");
            Console.WriteLine("Sevgilisi: Büşra");
            Console.WriteLine("Can: 100 ");
            Console.WriteLine("Saldırı: 35");
            Console.WriteLine("sevgi: 10");
            Console.ReadKey();


            Console.WriteLine();
            Console.WriteLine("3.Süleyman");
            Console.WriteLine("Özellikleri;");
            Console.WriteLine("Sevgilisi: Nisa");
            Console.WriteLine("Can: 100 ");
            Console.WriteLine("Saldırı: 40");
            Console.WriteLine("sevgi: 30");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("4.Mali(Muhammed Ali)");
            Console.WriteLine("Özellikleri;");
            Console.WriteLine("Sevgilisi: Emine");
            Console.WriteLine("Can: 100 ");
            Console.WriteLine("Saldırı: 45");
            Console.WriteLine("sevgi: 15");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("5.Keleş(Muhammed said Keleş)");
            Console.WriteLine("Özellikleri;");
            Console.WriteLine("Sevgilisi: Aslı");
            Console.WriteLine("Can: 100 ");
            Console.WriteLine("Saldırı: 20");
            Console.WriteLine("sevgi: 15");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("6.Hafız(Muhammed Hamza Fatih Bozdağ)");
            Console.WriteLine("Özellikleri;");
            Console.WriteLine("Sevgilisi: Nehir");
            Console.WriteLine("Can: 100 ");
            Console.WriteLine("Saldırı: 40");
            Console.WriteLine("sevgi: 30");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("7.Burak");
            Console.WriteLine("Özellikleri;");
            Console.WriteLine("Sevgilisi: Hande");
            Console.WriteLine("Can: 100 ");
            Console.WriteLine("Saldırı: 35");
            Console.WriteLine("sevgi: 25");
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void StoryStart(Karakterler selectCharacter)
        {
            Console.WriteLine($"{selectCharacter.Name} Daha 12 Yaşındaydı. O zamanlar bir savaş olmuştu. Çok Büyük bir savaş. {selectCharacter.Name} Tüm ailesini kaybetmişti.");
            Console.Read();

            Console.WriteLine($"Ailesi için, vatanı için durmadan savaştı Hiçbir zaman durmadı. {selectCharacter.Name} savaştan sonra yazılım alanında kendini geliştirdi.");
            Console.Read();

            Console.WriteLine($"17 Yaşına girdiğinde {selectCharacter.School} gitti. Savaş bitmişti Ve artık rahatlamıştı.");
            Console.Read();
            Console.WriteLine($"Tabi okulda da bi ünü vardı. 25 ekim savaşın sona erdiği Barış anlaşmasının imzalandığı tarihti.\nYıl dönümünde Kürsüde konuşma bile yapmıştı.");
            Console.Read();
            Console.WriteLine("Kendi icatları çığırını aştı savaşta kaybbettiği gözünün yerine çip kullanarak yeni bir göz protitipi bile icat etmişti.");
            Console.ReadLine();
            Console.WriteLine("Fakat icatlarını çalmak isteyen Mafya ona Hain pusular düzenlemeye başladı. \nOkula giderken Karşına Bir adam çıktı. Bi anda sana hamle yapmaya çalıştı ama karşıladın.\nKaçamazsın savaşacaksın.");
            Console.ReadKey();
        }
        public static void StoryMeet(Karakterler selectCharacter)
        {
            Console.WriteLine($"{selectCharacter.Name} Gelişti +10 saldırı Puanı.");
            CharacterUpdate.CharacterAttackUp(selectCharacter, 10);
            Console.WriteLine($"{selectCharacter.Name}'nın güncel Saldırı puanı: {selectCharacter.Attack}");
            Console.Write($"Güncel Canın = ");
            EfectFunctions.graficHPBar(selectCharacter.HP, 100);


            Console.WriteLine($"Bu saldırıda yaralandın. yaranı gizlemeye çalıştın.");
            Console.ReadLine();
            Console.WriteLine($"Okula vardığında arkadaşların seni hürmetle karşıladı. Sıraya geçtin. Okuldaki en yakın arkadaşın olan {selectCharacter.BestFirend}'la beraber okula girdin.");
            Console.ReadLine();
            Console.WriteLine($"Sınıfa gelip dersi dinledin bu Esnada icat ettiğin Göz ile bilgisayarına bağlanıp kimse görmeden oyun oynadın.");
            Console.WriteLine($"İlk tenefüs zili çaldığında su almak için kantine indin {selectCharacter.BestFirend}'la.");
            Console.ReadLine();
            Console.WriteLine($"Bir anda elemanın biri Yanına Yaklaştı. Sana Dediki 'Sen {selectCharacter.Name}'sın değil mi?'");
            Console.ReadLine();
            Console.WriteLine($"-Evet, Bi sıkıntı mı var Kardeş?");
            Console.ReadLine();
            Console.WriteLine($"-Yok yok sen çok iyi bir adamsın ve sana hayranım.");
            Console.WriteLine($"Onun samimi tavrına karşın sende yumuşuyorsun.");
            Console.ReadLine();
            Console.WriteLine($"-Eyvallah kardeşim. Allah senden razı olsun. Mesele nedir?");
            Console.ReadLine();
            Console.WriteLine($"-{selectCharacter.Name}, Gel benimle seni biriyle tanıştırmak istiyorum.");
            Console.ReadLine();
            Console.WriteLine($"-Hayırdır kimmiş bu.");
            Console.ReadLine();
            Console.WriteLine($"-Gel abi sen çok vaktini almayacam.");
            Console.ReadLine();
            Console.WriteLine($"-iyi bari. Göster bakalım.");
            Console.ReadLine();
            Console.WriteLine($"Seni okulun bahçesine çıkardı ve eliyle birine işaret verdi. daha sonra bekle diyip gitti.");
            Console.ReadLine();
            Console.WriteLine($"Biraz geçti.");
            Console.ReadLine();
            Console.WriteLine($"Karşana bir baktınki {selectCharacter.LoveName}.");
            Console.ReadLine();
            Console.WriteLine($"Elin ayağına dolaşıyor ama belli etmiyorsun. Sakinliğini korumaya çalışıyorsun.");
            Console.WriteLine($"Sana bakarak.");
            Console.WriteLine($"-Demek Savaş gazisi {selectCharacter.Name} sensin.");
            Console.ReadLine();
            Console.WriteLine($"-Evet de Bir Mesele mi var?");
            Console.ReadLine();
            Console.WriteLine($"-Ben {selectCharacter.LoveName} 11-A Sınıfındayım. Senden Bir isteğim var.");
            Console.ReadLine();
            Console.WriteLine($"-Söyle bakalım.");
            Console.ReadLine();
            Console.WriteLine($"-Senin askeri bağlantıların vardır.");
            Console.ReadLine();
            Console.WriteLine($"-Evet");
            Console.ReadLine();
            Console.WriteLine($"-Ben Hava Harp okulunu kazanmak istiyorum. Bunu söylemek hoşuma gitmiyor fakat");
            Console.ReadLine();
            Console.WriteLine($"-Eğer Yapılan torpillerden dolayı kazanamazsam.");
            Console.ReadLine();
            Console.WriteLine($"Sözünü bölerek");
            Console.WriteLine($"-Benden Torpil Yapmamı mı istiyorsun?");
            Console.ReadLine();
            Console.WriteLine($"-Yani Öyle denemez ama lazım olursa.");
            Console.ReadLine();
            Console.WriteLine($"-Bana bak ben Torpille asker olmadım Eğer geçekten asker olmak istiyorsan Çalışacaksın. asla vazgeçmiyeceksin ama sana tavsiyem askeriyeden uzak dur. \nBen üsteğmen oldum savaşta ve nasıl biryer olduğunu biliyorum ve kimseye tavsiye etmiyorum.");
            Console.ReadLine();
            Console.WriteLine($"Derken ders zil çalar");
            Console.ReadLine();
            Console.WriteLine($"-Neyse {selectCharacter.LoveName} Eğer bir soracağın olursa çekinme elemanla bana haber yollamana gerek yok. Gel konuşalım. Dert etme");
            Console.ReadLine();
            Console.WriteLine($"Sevgin 10 arttı.");
            CharacterUpdate.CharacterLoveUp(selectCharacter, 10);
            Console.Write($"Güncel Sevgin = ");
            EfectFunctions.graficHPBar(selectCharacter.Love, 85);
            Console.WriteLine($"Güncel sevgi {selectCharacter.Love}");
            Console.ReadLine();
            Console.WriteLine($"Okul Bitince Çıkışta {selectCharacter.LoveName} ile karşılşıyorsun.");
            Console.WriteLine($"Yüksek sesle");
            Console.WriteLine($"-{selectCharacter.LoveName}");
            Console.WriteLine($"-Eğer istersen bırakayım seni.");
            Console.Read();
            Console.WriteLine($"-Zahmet etme.");
            Console.Read();
            Console.WriteLine($"-Nerede oturuyon sen");
            Console.Read();
            Console.WriteLine($"-Tekerekte");
            Console.Read();
            Console.WriteLine($"-Hee Bak bende oraya gidiyorum.");
            Console.Read();
            Console.WriteLine($"{selectCharacter.LoveName} Motora biner. Arkadan sana sarılır.");
            Console.Read();
            Console.WriteLine($"-Korkmazsın değil mi?");
            Console.Read();
            Console.WriteLine($"-Yok yok çok basma yeter.");
            Console.Read();
            Console.WriteLine($"-Merak etme");
            Console.WriteLine($"Okuldaki herkez size bakıyor\nSonuçta altında mt-09 var :D");
            Console.ReadLine();
            Console.WriteLine($"-Tabi sen durur musun? 100-200 km/sa Hızlara çıkıyorsun.");
            Console.Read();
            Console.WriteLine($"Arkandan iyice sarılıyor sana");
            Console.Read();
            Console.WriteLine($"-Evini göstererek\n-Burası, burda durabilirsin.");
            Console.Read();
            Console.WriteLine($"-Aha Hadi bakalım. Askerlik filimlerde gösterilen gibi değil senden çok güzel hakim/avukat olur sadece çalışman gerekir.");
            Console.Read();
            Console.WriteLine($"Demeye kalmadan bir kurşun {selectCharacter.LoveName}'nin yanından geçip senin eline denk geliyor.");
            Console.Read();
            CharacterUpdate.CharacterHPDown(selectCharacter, 20);
            Console.WriteLine($"-AAAAAAAAA diye bağrıyosun.");
            Console.Read();
            Console.WriteLine($"Arkanı döndüğünde Mafya adamlarının Sana doğru ateş ettiğini görüyorsun.");
            Console.Read();
            Console.WriteLine($"Bir anda zaman yavaşlıyor. Motorun üstünden hızlıca atlayıp {selectCharacter.LoveName}'yi sararak binaya sokuyorsun.");
            Console.Read();
            Console.WriteLine($"Ona hemen gitmesini söyleyip silahına davranıyorsun.");
            Console.Read();
        }
        public static string StoryPlace(ref Karakterler selectCharacter)
        {
            Console.WriteLine($"{selectCharacter.Name} Gelişti +10 saldırı Puanı.");
            CharacterUpdate.CharacterAttackUp(selectCharacter, 10);
            Console.WriteLine($"{selectCharacter.Name}'nın güncel Saldırı puanı: {selectCharacter.Attack}");
            Console.Write($"Güncel Canın = ");
            EfectFunctions.graficHPBar(selectCharacter.HP, 100);




            Console.WriteLine($"{selectCharacter.LoveName} korkuyla çatışmanın bittiğini görüp hemen yanına geliyor.");
            Console.ReadLine();
            Console.WriteLine($"-{selectCharacter.Name} iyi misin? o neydi öyle");
            Console.ReadLine();
            Console.WriteLine($"Gülerek ve eline bakarak\n-İşte bak askerlik bundan daha kötü");
            Console.ReadLine();
            Console.WriteLine($"-Saçmalama hemen hasteneye gitmeliyiz polisle ambulans şimdi burada olur.");
            Console.ReadLine();

            Console.WriteLine($"-Yok canım iyiyim sadece sıyırdı. Benim gitmem gerekiyor. Sakın polislere adımı verme. Bi adamla çatıştılar de tamam mı?");
            Console.ReadLine();

            Console.WriteLine($"Şaşkın ve ağlar bi halde\n-Neden?");
            Console.ReadLine();
            Console.WriteLine($"-Yarın okulda anlatırım. Sakın isim verme bu önemli lütfen.");
            Console.ReadLine();
            Console.WriteLine($"-Sana neden dedim.");
            Console.ReadLine();
            Console.WriteLine($"-Eğer Öğrenmek istiyorsan benimle gel");
            Console.ReadLine();
            Console.WriteLine($"-Tamam ama motoru nasıl sürecen");
            Console.ReadLine();
            Console.WriteLine($"-Ben sürerim acele et.");
            Console.ReadLine();
            Console.WriteLine($"Hemen Motoruna atlayıp eve gidiyorsun. Yolda eski arkadaşın Doktor Hafız Yunusu arayıp evine çağırıyorsun.");
            Console.ReadLine();
            Console.WriteLine($"Eve vardığında Hocam lakaplı Doktor Yunus seni tedavi ediyor.\nElindeki mermiyi Çıkartıp sarıyor.");
            CharacterUpdate.CharacterHpUp(selectCharacter, 20);
            Console.Write($"Güncel Canın = ");
            EfectFunctions.graficHPBar(selectCharacter.HP, 100);
            Console.ReadLine();
            Console.WriteLine($"-{selectCharacter.LoveName} bak ben askeriyeden sonra Gözüm gibi birçok icat yaptım.\n-Fakat mafya onlara çalışmamı ve araştırmalarımı satmak istedi");
            Console.ReadLine();

            Console.WriteLine($"-Buna izin veremezdim. Benim üzerimden para kazanmalarını istemedim. 3 yıldır Bunlarla savaşıyorum ve polisleri de satın almışlar. \n-Eğer polisler o halde beni görselerdi hepsini öldürmekten beni içeri atarlardı. Sende gördün onlar bize saldırdı.");
            Console.ReadLine();

            Console.WriteLine($"-Öyle mi?");
            Console.ReadLine();

            Console.WriteLine($"-Evet, hadi gel seni eve bırakayım.");
            Console.ReadLine();

            Console.WriteLine($"-Yine peşimize düşmezler mi?");
            Console.ReadLine();

            Console.WriteLine($"-Bizi bulamazlar arabayla gideriz hem.");
            Console.ReadLine();

            Console.WriteLine($"-Tamam");
            Console.ReadLine();

            Console.WriteLine($"Sevgin +10 arttı.");
            CharacterUpdate.CharacterLoveUp(selectCharacter, 10);
            Console.Write($"Güncel Sevgin = ");
            EfectFunctions.graficHPBar(selectCharacter.Love, 85);

            Console.ReadLine();


            Console.WriteLine($"Onu eve bırakıp meyhaneye gidiyorsun.");
            Console.ReadLine();

            Console.WriteLine($"Said Çalışkan, mekanın sahibi ve onunla iyi bir dostluğun var.");
            Console.ReadLine();
            Console.Write($"Güncel Canın = ");
            EfectFunctions.graficHPBar(selectCharacter.HP, 100);

            Console.WriteLine($"-Afiyet olsun kadeş");
            Console.ReadLine();
            Console.WriteLine($"-Eyvallah eyvallah kardeşim. Gel buyur.");
            Console.ReadLine();
            Console.WriteLine($"Oturuyorsun bi bardak rakı koyuyolar sana");
            Console.ReadLine();
            Console.WriteLine($"-Eee anlat bakalım Çalışkan");
            Console.ReadLine();
            Console.WriteLine($"-Ne anlatayım kardeş");
            Console.ReadLine();
            Console.WriteLine($"Elindeki sargıyı görür");
            Console.WriteLine($"-Eline ne oldu?");
            Console.ReadLine();
            Console.WriteLine($"-Bi şey olmadı yaw ufak bir sıyırık.");
            Console.ReadLine();
            Console.WriteLine($"Gülerek");
            Console.WriteLine($"-İyi o zaman. aman ha sana birşey olursa kimle içecez biz");
            Console.ReadLine();
            Console.WriteLine($"-Tabi tabi merak etme seni yanlız içirmem");
            Console.ReadLine();
            Console.WriteLine($"Bir Güzel içiyorsunuz sağlam sarhoş oluyorsun. Bu gece Çok eğlenceli geçiyor. seni evine bırakıyorlar.");
            Console.ReadLine();
            Console.WriteLine($"Direk Yatıyorsun.");
            Console.ReadLine();
            Console.WriteLine($"Sabah kaltığında sağlam bir baş ağrısı hissediyorsun. Bi soda açıyosun");
            Console.ReadLine();
            Console.WriteLine($"Güzel bir kahvaltı yaptıktan sonra okula gidiyorsun");
            Console.ReadLine();
            Console.WriteLine($"Yine herşey tekrar ediyor sıkıcı okul fakat bir fark var. {selectCharacter.LoveName} sürekli senle konuşmak istiyor. Yanından ayrılmıyor.");
            Console.ReadLine();
            Console.WriteLine($"Okulda dedikodu ortaya çıkıyor {selectCharacter.Name} ile {selectCharacter.LoveName} Çıkıyor mu? diyorlar");
            Console.ReadLine();
            Console.WriteLine($"Tabi sana soran oldu mu 'Hurafe bunlar inanmayın beyler' diyip geçiştiriyorsun.");
            Console.ReadLine();
            Console.WriteLine($"Sizin samimiyetiniz artıyor.");
            Console.ReadLine();
            Console.WriteLine($"iyileşiyorsun günler geçip gidiyor.");
            Console.ReadLine();
            selectCharacter.HP = 100;
            Console.Write($"Güncel Canın = ");
            EfectFunctions.graficHPBar(selectCharacter.HP, 100);
            Console.WriteLine($"Buluşmalar düzenliyorsunuz. {selectCharacter.BestFirend} {selectCharacter.LoveName} Hep baraber çok iyi anlaşıyorsunuz.");
            Console.ReadLine();
            Console.Write($"Güncel Sevgin = ");
            EfectFunctions.graficHPBar(selectCharacter.Love, 85);
            string sevgi;
            while (true)
            {
                Console.WriteLine($"Onu sevdiğini artık söyleyecek misin?(evet/hayır)");
                sevgi = Console.ReadLine();
                if (sevgi == "e" || sevgi == "evet")
                {
                    if (selectCharacter.Love > 30)
                    {
                        Console.WriteLine($"Ve en sonunda {selectCharacter.LoveName}'ye aşkını anlatıyorsun. Onu sevdiğini söylüyorsun.");
                        Console.ReadLine();
                        Console.WriteLine($"-{selectCharacter.LoveName} benim sana söylemem gereken çok önemli bir şey var.");
                        Console.ReadLine();
                        Console.WriteLine($"-Hayırdır? Ne oldu?");
                        Console.ReadLine();
                        Console.WriteLine($"-Anasını satayım ben seni seviyorum.");
                        Console.ReadLine();
                        Console.WriteLine($"Bi  anda sessizlik oluyor.");
                        Console.WriteLine($"...");
                        Console.ReadLine();
                        Console.WriteLine($"Yüzüne bakıyor ciddi bir ifadeyle");
                        Console.WriteLine($"...");
                        Console.ReadLine();
                        Console.WriteLine($"Heyecanla bekliyorsun");
                        Console.ReadLine();
                        Console.WriteLine($"-Lan niye Bu günü bekledin");
                        Console.WriteLine($"Kafana yavaşça vurur");
                        Console.ReadLine();
                        Console.WriteLine($"-Öyle Kolay mı söylemesi.");
                        Console.ReadLine();
                        Console.WriteLine($"-Şaka maka ben de seni seviyorum.");
                        Console.ReadLine();
                        Console.WriteLine($"Bi anda sarılıyorsun ve havaya kaldırıyorsun.");
                        Console.ReadLine();
                        Console.WriteLine($"sevgin +10 arttı.");
                        CharacterUpdate.CharacterLoveUp(selectCharacter, 10);
                        Console.Write($"Güncel Sevgin = ");
                        EfectFunctions.graficHPBar(selectCharacter.Love, 85);
                        Console.ReadLine();
                        Console.WriteLine($"Güelerek\n-dur la dur.");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Ona sevdiğini söylüyorsun.\n-{selectCharacter.LoveName} ben seni seviyorum.");
                        Console.ReadLine();
                        Console.WriteLine($"Şöyle Bi duruyor.\n-Ne saçmalıyorsun ben seni arkadaş olarak görüyorum sakın bana böyle davranma.");
                        Console.ReadLine();
                        Console.WriteLine($"-T Tt Tamam");
                        Console.ReadLine();
                        Console.WriteLine($"sevgin -15 azaldı");
                        CharacterUpdate.CharacterLoveDown(selectCharacter, 15);
                        Console.Write($"Güncel sevgin = ");
                        EfectFunctions.graficHPBar(selectCharacter.Love, 85);
                        Console.ReadLine();
                        break;
                    }
                }
                else if (sevgi == "h" || sevgi == "hayır")
                {
                    Console.WriteLine($"Onun Beklentilerini karşılayamadın\nEn iyisi birazdaha zamana ihtiyacım var diyorsun");
                    Console.ReadLine();
                    Console.WriteLine($"Sevgin -5 azaldı");
                    CharacterUpdate.CharacterLoveDown(selectCharacter, 5);
                    Console.Write($"Güncel Canın = ");
                    EfectFunctions.graficHPBar(selectCharacter.Love, 85);
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Doğru seçim yaptığınızdan emin olun!!!\n(evet/hayır) Olduğu gibi yazmayı deneyin.");
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"Günler Bu şekilde devam ediyor bir birinize güveninz artıyor ");
            Console.ReadLine();
            Console.WriteLine($"Eve gidip biraz filim izlemek istiyorsunuz.Yanınızda {selectCharacter.BestFirend}'da var. Yolda Size saldırıyorlar.\n-{selectCharacter.LoveName} Çabuk Eğil.");
            Console.ReadLine();
            Console.WriteLine($"arabayı durduruyorsun ve çatışmaya başlıyorsun.");
            Console.ReadLine();
            return sevgi;
        }
        public static void StoryFight(ref Karakterler selectCharacter, string sevgi)
        {
            Console.WriteLine($"{selectCharacter.Name} Gelişti +10 saldırı Puanı.");
            CharacterUpdate.CharacterAttackUp(selectCharacter, 10);
            Console.WriteLine($"{selectCharacter.Name}'nın güncel Saldırı puanı: {selectCharacter.Attack}");
            Console.Write($"Güncel Canın = ");
            EfectFunctions.graficHPBar(selectCharacter.HP, 100);
            Console.WriteLine($"{selectCharacter.LoveName} Hemen yanına geliyor\n-İyi misin? yaralanmışsın.");
            Console.ReadLine();
            Console.WriteLine($"-Bişeyim yok merak etme.");
            Console.ReadLine();
            Console.WriteLine($"Yaranı tutarak\n-{selectCharacter.BestFirend} bizi eve götür.");
            Console.ReadLine();
            Console.WriteLine($"eve varıp kendine pansuman yapıyorsun ve Sarıyorsun.");
            Console.ReadLine();
            Console.WriteLine($"Canın arttı");
            Console.ReadLine();
            CharacterUpdate.CharacterHpUp(selectCharacter, 10);
            Console.Write($"Güncel Canın = ");
            EfectFunctions.graficHPBar(selectCharacter.HP, 100);
            Console.ReadLine();
            Console.WriteLine($"{selectCharacter.BestFirend}\n-Hocamı Çağıralım.");
            Console.ReadLine();
            Console.WriteLine($"-Yok la iyiyim mermi girmedi merk etme");
            Console.ReadLine();
            Console.WriteLine($"{selectCharacter.LoveName}\nYaw sen salak mısın? {selectCharacter.BestFirend} haklı ara doktoru.");
            Console.ReadLine();
            Console.WriteLine($"-Hay Allah. Sizne abarttınız pansuman yaptım işte iyiyim.");
            Console.ReadLine();
            Console.WriteLine($"-ahh. Tamam {selectCharacter.BestFirend} arka odadan ev telefonunu getirir misin?");
            Console.WriteLine($"{selectCharacter.BestFirend} gider");
            Console.ReadLine();
            Console.WriteLine($"Sevgin +10 arttı");
            CharacterUpdate.CharacterLoveUp(selectCharacter, 10);
            Console.Write($"Güncel Sevgin = ");
            EfectFunctions.graficHPBar(selectCharacter.Love, 85);
            Console.ReadLine();
            if (sevgi == "h" || sevgi == "hayır")
            {

                while (true)
                {
                    Console.Write($"Güncel Sevgin = ");
                    EfectFunctions.graficHPBar(selectCharacter.Love, 85);
                    Console.WriteLine($"Şimdi tam sırası ona sevdiğini söylemek ister misin?(evet/hayır)");
                    sevgi = Console.ReadLine();
                    if (sevgi == "e" || sevgi == "evet")
                    {
                        if (selectCharacter.Love > 30)
                        {

                            Console.WriteLine($"-{selectCharacter.LoveName} ben seni seviyorum.");
                            Console.ReadLine();
                            Console.WriteLine($"-Be.. ne?");
                            Console.ReadLine();
                            Console.WriteLine($"-Evet ");
                            Console.ReadLine();
                            Console.WriteLine($"Gülerek");
                            Console.WriteLine($"-Ciddi misin?");
                            Console.ReadLine();
                            Console.WriteLine($"-Evet");
                            Console.ReadLine();
                            Console.WriteLine($"Sarılır");
                            Console.ReadLine();
                            Console.WriteLine($"Sevgin +10 arttı.");
                            Console.Write($"Güncel Sevgin = ");
                            EfectFunctions.graficHPBar(selectCharacter.Love, 85);
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"-Bak böyle olmaz ben seni sevmiyorum neden arama arkadaş kalalım lütfen!");
                            Console.ReadLine();
                            Console.WriteLine($"-T Tt.. Tamam");
                            Console.ReadLine();
                            Console.WriteLine($"Sevgin -10 azaldı");

                            CharacterUpdate.CharacterLoveDown(selectCharacter, 10);
                            Console.Write($"Güncel Sevgin = ");
                            EfectFunctions.graficHPBar(selectCharacter.Love, 85);
                            Console.ReadLine();
                            break;
                        }
                    }
                    else if (sevgi == "h" || sevgi == "hayır")
                    {
                        Console.WriteLine($"Beklemeyi tercih ediyorsun");
                        Console.WriteLine($"Sevgin -10 azaldı");
                        CharacterUpdate.CharacterLoveDown(selectCharacter, 10);
                        Console.Write($"Güncel Sevgin = ");
                        EfectFunctions.graficHPBar(selectCharacter.Love, 85);

                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Doğru seçim yaptığınızdan emin olun!!!\nOlduğu gibi yazmayı deneyin. (evet/hayır)");
                        Console.ReadLine();
                    }
                }
            }
            else
            {
                Console.WriteLine($"Sarılır\n-Sana birşey olsun istemiyorum.");
                Console.ReadLine();

                Console.WriteLine($"-Merak etme ");
                Console.ReadLine();
                Console.WriteLine($"Sevgin +10 arttı");
                CharacterUpdate.CharacterLoveUp(selectCharacter, 10);
                Console.Write($"Güncel Sevgin = ");
                EfectFunctions.graficHPBar(selectCharacter.Love, 85);
                Console.ReadLine();
            }
            Console.WriteLine($"{selectCharacter.BestFirend} arka odaya gittikten sonra {selectCharacter.Name}'ın Günlüğünü buluyor.\nRastgele bir sayfayı açıyor ki gözüne 'Daha sonra DAEŞ ile bağlantı kurup Türkiye'ye Saldırmaları için Bir plan yaptım' Cümlesini görüyor. Çok şaşırıyor.\nBirkaç fotoğraf Çekiyor ve telefonu alıp düğerlerinin yanına gidiyor.");
            Console.ReadLine();
            Console.WriteLine($"Loading...");
            Console.WriteLine($"Bundan sonra hikayeyi {selectCharacter.LoveName}'nin gözünden oynayacağız.");
            Console.ReadLine();
            Console.WriteLine($"{selectCharacter.Name} Hocamı arıyor");
            Console.ReadLine();
            Console.WriteLine($"-Bana bak başka yaran var mı?");
            Console.ReadLine();
            Console.WriteLine($"-Yok yok iyiyim ver her zaman yaşadığım şeyler bunlar.");
            Console.ReadLine();
            Console.WriteLine($"Hoca yunus gelir {selectCharacter.Name}'ı tedavi eder. Sana dönerek\n-{selectCharacter.Name} iyi birkaç gün sonra eski haline gelir merak etme.");
            Console.ReadLine();
            Console.WriteLine($"-Tamamdır. Çok teşekkür ederim senin hakkın ödenmez.");
            Console.ReadLine();
            Console.WriteLine($"-Yoo Ödeniyo {selectCharacter.Name} Her ay 100.000TL Maaş bağladı bana istediği zaman geliyorum.");
            Console.ReadLine();
            Console.WriteLine($"-Ee o manada değil.");
            Console.ReadLine();
            Console.WriteLine($"-Hee yok Estağfirullah, ben teşekkür ederim.");
            Console.ReadLine();
            Console.WriteLine($"{selectCharacter.Name} yatarken {selectCharacter.BestFirend} yanına yaklaşıyor.");
            Console.ReadLine();
            Console.WriteLine($"-Yenge ben bişey buldum ama");
            Console.ReadLine();
            Console.WriteLine($"-Ne buldun {selectCharacter.BestFirend}?");
            Console.ReadLine();
            Console.WriteLine($"-Ciddi bir şey bu sakin bir şekilde konuşmalıyız.");
            Console.ReadLine();
            Console.WriteLine($"-Konuşalım söyle");
            Console.ReadLine();
            Console.WriteLine($"-Burda değil onun olmaması lazım");
            Console.ReadLine();
            Console.WriteLine($"{selectCharacter.Name} bağırarak");
            Console.ReadLine();
            Console.WriteLine($"-Bensiz Ne söyleyeceksin {selectCharacter.BestFirend}");
            Console.ReadLine();
            Console.WriteLine($"-Yaw niye böldün");
            Console.ReadLine();
            Console.WriteLine($"Sinirle ayağı kalkarak {selectCharacter.BestFirend}'ın üstüne yürüyor");
            Console.WriteLine($"-Neyi bölüyom Lan?");
            Console.ReadLine();
            Console.WriteLine($"-Sana..");
            Console.ReadLine();
            Console.WriteLine($"bağırarak \n-Ne sana?");
            Console.ReadLine();
            Console.WriteLine($"-Sana süpriz yapacaktık amk ya");
            Console.ReadLine();
            Console.WriteLine($"Sana dönerek \nDoğru mu söylüyo?");
            Console.ReadLine();
            Console.WriteLine($"-E E.. Evet evet planı niye bozuyorsun ki");
            Console.ReadLine();
            Console.WriteLine($"Yumuşayarak \n-Hee");
            Console.ReadLine();
            Console.WriteLine($"-sen ne sandın lan?");
            Console.ReadLine();
            Console.WriteLine($"-Sandım ki");
            Console.ReadLine();
            Console.WriteLine($"-hee");
            Console.ReadLine();
            Console.WriteLine($"-Yaw tamam başım çatlıyor zaten");
            Console.WriteLine($"Sevgin -10 azaldı ");
            CharacterUpdate.CharacterLoveDown(selectCharacter, 10);
            Console.Write($"Güncel Sevgin = ");
            EfectFunctions.graficHPBar(selectCharacter.Love, 85);
            Console.ReadLine();
            Console.WriteLine($"{selectCharacter.LoveName}\n-Artık Bizim kola çekirdek işi olmaz.\n-Annem de beni çağırıyo çok dışardayız bu aralar.\n-Ben eve gidiyorum sen kendini zorlama tamam mı?");
            Console.ReadLine();
            Console.WriteLine($"-Tamam güzelim benim\n-Ben bırakırım seni");
            Console.ReadLine();
            Console.WriteLine($"-Bana bak {selectCharacter.Name} yarına kadar bu yataktan kalkmıyosun");
            Console.ReadLine();
            Console.WriteLine($"-Peki nasıl gidecen Hanım efendi?");
            Console.ReadLine();
            Console.WriteLine($"-Ayaklarım sağlam.");
            Console.ReadLine();
            Console.WriteLine($"-{selectCharacter.BestFirend} bıraksın bari. Tek gidemezsin.");
            Console.ReadLine();
            Console.WriteLine($"-Off Tamam tamam");
            Console.ReadLine();
            Console.WriteLine($"-İyi");
            Console.ReadLine();
            Console.WriteLine($"-{selectCharacter.BestFirend} dikkat et yamulursun böyle şeyler yapma.");
            Console.ReadLine();
            Console.WriteLine($"-Asıl sen yamulursun {selectCharacter.Name} dikkat et. Ben pis bir adam mıyım? Yawşak mıyım?");
            Console.ReadLine();
            Console.WriteLine($"-Tamam tamam haklısın.");
            Console.ReadLine();
            Console.WriteLine($"-Allah Allah ya");
            Console.ReadLine();
            Console.WriteLine($"{selectCharacter.BestFirend}'la beraber arabaya atlayıp ve evine doğru yola çıkıyorsunuz.");
            Console.ReadLine();
            Console.WriteLine($"-{selectCharacter.LoveName} al şu telefonu bak.");
            Console.ReadLine();
            Console.WriteLine($"Çektiği fotoğrafları gösteriyor.");
            Console.ReadLine();
            Console.WriteLine($"-Bu ne?");
            Console.ReadLine();
            Console.WriteLine($"-{selectCharacter.Name}'ın günlüğü");
            Console.ReadLine();
            Console.WriteLine($"-Tarihlere ve yazanlara baksana bu ne demek oluyor.");
            Console.ReadLine();
            Console.WriteLine($"   Yazanlar;");
            Console.WriteLine($"    Tarih 2014 mayıs ayları planımı uygulamak için babamın arabasını  ");
            Console.WriteLine($" kaçırıp süriyeye doğru yola çıktım. Yol 23 saat sürdü sınırdaki     ");
            Console.WriteLine($" askerleri öldürmek zorunda kaldım. Allah beni affetsin neyse        ");
            Console.WriteLine($" Allahtan bazıları teslim oldular. Suriye topraklarındaki ");
            Console.WriteLine($" tüm asker ve polisleri öldürdüm. Daha sonra DAEŞ ile  bağlantı kurup ");
            Console.WriteLine($" Türkiye'ye Saldırmaları için Bir plan yaptım ve Hakkari'ye     ");
            Console.WriteLine($"  bomba atmalarını sağladım. Ondan önce ailemi arayıp      ");
            Console.WriteLine($" Beni hakkariye kaçırdıklarını söyledim ve gelip almalarını iste-    ");
            Console.WriteLine($" dim. Fakat tek sorun zamanı iyi ayarlamaktı. Görüyor musun? Zamanı  ");
            Console.WriteLine($" Kontrol edebildiğim halde bu ayarlamayı yapmak çok zor oldu.        ");
            Console.WriteLine($" Tam istediğim gibi Bobanın ilk hedefi babam gil oldu. Bende hızlıca ");
            Console.WriteLine($" oraya gidip Türkiye tarafında savaşmaya başladım.                   ");
            Console.ReadLine();

            Console.WriteLine($"    Diğer sayfada;");
            Console.WriteLine($"     Tarih  2017 DAEŞ Tamamen bitti. Bende savaşta artık Teğmenim   ");
            Console.WriteLine($"  fakat daha uzun bir savaş olmalı 10.Sınıfa gidebilmem için daha   ");
            Console.WriteLine($"  önümde 5 yıl var. Herşey planladığım gibi olmalı İngiltere'deki   ");
            Console.WriteLine($"  adamıma haber yolladım. Deliveroo Sadece bana değil onlarada kaza-");
            Console.WriteLine($"  ndıracak. İngilterenin türkiyeye savaş açması lazım bu sayede     ");
            Console.WriteLine($"  3.dünya savaşı başlayacak ve ben iyice askeriyede kalacam. Burada ");
            Console.WriteLine($"  Te 2070lerde yapılan gözler ve birçok icadı sanki kendim yapmış   ");
            Console.WriteLine($"  gibi yayacam Bu beni daha da zenginleştirecek ve saygınlığım arta-");
            Console.WriteLine($"  cak. Ben bu sefer en iyi hayatı yaşayacağım.");
            Console.ReadLine();


            Console.WriteLine($"   Diğer sayfada;");
            Console.WriteLine($"    Tarih 2023 Artık herşey bitti başardım. Hem zenginim hem itibar- ");
            Console.WriteLine($"  lı çok güzel. Sırada {selectCharacter.BestFirend} ile iyice samimi olmak var. Onu");
            Console.WriteLine($"  seviyorum Çok şerefsiz fakat iyi bir çocuk. Ben onu korumalıyım.  ");
            Console.WriteLine($"  Aslında çok ta saf varya. Onu çok kullanıcam. Daha sonra sırada   ");
            Console.WriteLine($"  {selectCharacter.LoveName} olacak onu iyice kendime aşık edecem daha sonra Bu yazdıklarımı");
            Console.WriteLine($"  bulacak {selectCharacter.BestFirend}. Bir yandan korkarken bir yandan");
            Console.WriteLine($"Devamı yırtılmış");
            Console.ReadLine();

            Console.WriteLine($"-Lan {selectCharacter.BestFirend} Bu ne?\n-Nasıl olur bu?");
            Console.ReadLine();
            Console.WriteLine($"-Banada saçma geldi.");
            Console.ReadLine();
            Console.WriteLine($"-ama herşey doğru sadece..\n-Lan nasıl?");
            Console.ReadLine();
            Console.WriteLine($"-Ne oldu?");
            Console.ReadLine();
            Console.WriteLine($"-{selectCharacter.Name}'ı benimle ilk karşılaştıran çocuk var ya");
            Console.ReadLine();
            Console.WriteLine($"-Eee");
            Console.ReadLine();
            Console.WriteLine($"-Daha önce hiç konuşmamıştım.\n-Sadece benim yanıma gelip 'Asker olmak istiyor musun?' dedi.");
            Console.ReadLine();
            Console.WriteLine($"-Nasıl?");
            Console.ReadLine();
            Console.WriteLine($"-Çocuk benim asker olmak istediğimi nereden biliyorduki?");
            Console.ReadLine();
            Console.WriteLine($"-Hiç sormadın mı?");
            Console.ReadLine();
            Console.WriteLine($"-Aklıma gelmedi");
            Console.ReadLine();
            Console.WriteLine($"-Bak bide beni ilk kez eve bıraktığında olağan üstü hızlarla koşuyordu sanki");
            Console.ReadLine();
            Console.WriteLine($"-Benim aptallığımdır dedim ama\n-Gerçek olabilir mi sence?");
            Console.ReadLine();
            Console.WriteLine($"-Yaw olmaması gerek. Yani nasıl olsun?");
            Console.ReadLine();
            Console.WriteLine($"-Evet, neyse bişey belli etmeyek şimdilik.");
            Console.ReadLine();
            Console.WriteLine($"-Delirmiş olmalı değil mi?");
            Console.ReadLine();
            Console.WriteLine($"-Evet");
            Console.ReadLine();
            Console.WriteLine($"Eve vardığınızda Kapının önünde {selectCharacter.Name}'ı görüyorsunuz.");
            Console.ReadLine();
            Console.WriteLine($"Şaşkın bir şekilde {selectCharacter.BestFirend}");
            Console.WriteLine($"-N n.. nasıl?");
            Console.ReadLine();
            Console.WriteLine($"-Dur bakayım");
            Console.ReadLine();
            Console.WriteLine($"{selectCharacter.Name}\n-Lan neredesiniz yarım saatdir.");
            Console.ReadLine();
            Console.WriteLine($"{selectCharacter.BestFirend}\n-Bişey olmadı yoldaydık.");
            Console.ReadLine();
            Console.WriteLine($"-Geç bakayım şöyle");
            Console.ReadLine();
            Console.WriteLine($"{selectCharacter.BestFirend} arabayı park ediyor.");
            Console.ReadLine();
            Console.WriteLine($"Sende arabadan iniyorsun.");
            Console.WriteLine($"-Sen ne diye yatağından kalktın?");
            Console.ReadLine();
            Console.WriteLine($"Loading...\nArtık {selectCharacter.BestFirend} karakterinin gözünden görüyoruz.");
            Console.ReadLine();
            Console.WriteLine($"Gülerek\n-{selectCharacter.BestFirend}'a sormalı.");
            Console.ReadLine();
            Console.WriteLine($"Endişeyle");
            Console.WriteLine($"-Demek zaman senin elinde.");
            Console.ReadLine();
            Console.WriteLine($"-Zaman benim elimde");
            Console.ReadLine();
            Console.WriteLine($"-Lan nasıl bir aptalsın sen böyle bir şey mümkün mü?");
            Console.ReadLine();
            Console.WriteLine($"-Belli değil mi Günlüğü okumadınız mı?");
            Console.ReadLine();
            Console.WriteLine($"-Oku..duk.");
            Console.ReadLine();
            Console.WriteLine($"-{selectCharacter.BestFirend} hadi bakalım saldır bana.");
            Console.ReadLine();
            Console.WriteLine($"-Neden?");
            Console.ReadLine();
            Console.WriteLine($"-Benim yaptıklarımdan sonra beni serbest mi bırakacaksın?");
            Console.ReadLine();
            Console.WriteLine($"-Ben.. Lan aptal.");
            Console.ReadLine();
            Console.WriteLine($"-{selectCharacter.LoveName} Ağlar bi halde\n-Durun yapmayın");
            Console.ReadLine();
            Console.WriteLine($"{selectCharacter.Name} karnına sağlam bir yumruk atıyor. ");
            Console.ReadLine();
            Console.WriteLine($"-Aaaaa\n-Şerefsiz");
            Console.ReadLine();
        }
        public static void StoryFinaly(ref Karakterler selectCharacter, Mafia Dusmandost)
        {
            Console.WriteLine("             Son                ");
            Console.WriteLine("Mehmetcan Çelik yapımı");
            Console.ReadLine();
            Console.WriteLine("Yazar:       Mehmetcan Çelik");
            Console.WriteLine("Senaryo:     Mehmetcan Çelik");
            Console.WriteLine("Seslendirme: Mehmetcan Çelik");
            Console.WriteLine("Görsel:      Mehmetcan Çelik");
            Console.WriteLine("Karakterler: Mehmetcan Çelik");
            Console.WriteLine("Efektler:    Mehmetcan Çelik");
            Console.WriteLine("Müzikler:    Mehmetcan Çelik");
            Console.WriteLine("Arkaplan:    Mehmetcan Çelik");
            Console.WriteLine("Çalışkan ve hocam karakterleri mübarektir.");
            Console.ReadKey();

            Console.WriteLine($"    {Dusmandost.Name} ile {selectCharacter.LoveName}");
            Console.WriteLine("        Düğünümüze davetlisiniz.");

            Console.ReadKey();
        }
    }
}
