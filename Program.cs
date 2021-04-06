using System;

namespace Feladatok1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kiíratás, adatbekérés billentyűzetről, változók, matematikai műveletek
            {
                // elsoFeladat();
                // masodikFeladat();
                // harmadikFeladat();
                // negyedikFeladat();
                // otodikFeladat();
                // hatodikFeladat();
                // hetedikFeladat();
                // nyolcadikFeladat();
                // kilencedikFeladat();
                // tizedikFeladat();
                // tizenegyedikFeladat();
                // tizenkettedikFeladat();
                // tizenharmadikFeladat();
                // tizennegyedikFeladat();
                // tizenotodikFeladat();



                void elsoFeladat()
                {
                    string varos, kozteruletNeve, kozteruletJellege, iranyitoszam, hazszam;
                    Console.Write("Adja meg asz iranyitoszamot! ");
                    iranyitoszam = Console.ReadLine();
                    Console.Write("Adja meg a varost! ");
                    varos = Console.ReadLine();
                    Console.Write("Adja meg a kozterulet nevet! ");
                    kozteruletNeve = Console.ReadLine();
                    Console.Write("Adja meg a kozterulet jelleget! ");
                    kozteruletJellege = Console.ReadLine();
                    Console.Write("Adja meg a hazzsamot! ");
                    hazszam = Console.ReadLine();
                    Console.WriteLine(iranyitoszam + " " + varos + " " + kozteruletNeve + " " + kozteruletJellege + " " + hazszam);
                }
                void masodikFeladat()
                {
                    Console.Write("Adja meg az elso vezeteknevet! ");
                    string elsoVezetek = Console.ReadLine();
                    Console.Write("Adja meg a masodik vezeteknevet! ");
                    string masodikVezetek = Console.ReadLine();
                    Console.Write("Adja meg az elso keresztnevet! ");
                    string elsoKereszt = Console.ReadLine();
                    Console.Write("Adja meg a masodik keresztnevet! ");
                    string masodikKereszt = Console.ReadLine();

                    Console.WriteLine(elsoVezetek + " " + elsoKereszt);
                    Console.WriteLine(elsoVezetek + " " + masodikKereszt);
                    Console.WriteLine(masodikVezetek + " " + elsoKereszt);
                    Console.WriteLine(masodikVezetek + " " + masodikKereszt);
                }
                void harmadikFeladat()
                {
                    Console.Write("Adja meg a havi fizeteset! ");
                    string input = Console.ReadLine();
                    int fizetes = Convert.ToInt32(input);
                    Console.WriteLine($"Az eves fizetes: {fizetes * 12}");
                }
                void negyedikFeladat()
                {
                    Console.Write("Adja meg az euro arfolyamat! ");
                    string input = Console.ReadLine();
                    int arfolyam = Convert.ToInt32(input);
                    Console.Write("Mennyi eurot szeretne atvaltani? ");
                    input = Console.ReadLine();
                    int mennyiseg = Convert.ToInt32(input);
                    Console.WriteLine($"Az atvaltott euro {mennyiseg * arfolyam} forint.");
                }
                void otodikFeladat()
                {
                    Console.Write("Adja meg a teglalap elso oldalat! ");
                    string input = Console.ReadLine();
                    int a = Convert.ToInt32(input);
                    Console.Write("Adja meg a teglalap masodik oldalat! ");
                    input = Console.ReadLine();
                    int b = Convert.ToInt32(input);
                    Console.WriteLine($"A teglalap kerulete {2 * (a + b)}, a terulete pedig {a * b}");
                }
                void hatodikFeladat()
                {
                    Console.Write("Adja meg a kor sugarat! ");
                    string input = Console.ReadLine();
                    int sugar = Convert.ToInt32(input);
                    Console.WriteLine($"A kor sugara {2 * sugar * 3.14}, a terulete pedig {sugar * sugar * 3.14}");
                }
                void hetedikFeladat()
                {
                    Console.Write("Adja meg az elso befogot! ");
                    string input = Console.ReadLine();
                    int elsoBefogo = Convert.ToInt32(input);
                    Console.Write("Adja meg a masodik befogot! ");
                    input = Console.ReadLine();
                    int masodikBefogo = Convert.ToInt32(input);
                    double atfogo = Math.Sqrt((elsoBefogo * elsoBefogo) + (masodikBefogo * masodikBefogo));
                    Console.WriteLine($"Az atfogo hossza {atfogo}");
                }
                void nyolcadikFeladat()
                {
                    Console.Write("Adja meg a megtett ut hosszat(km)! ");
                    string input = Console.ReadLine();
                    double ut = Convert.ToInt32(input);
                    Console.Write("Adja meg az eltelt idot(ora)! ");
                    input = Console.ReadLine();
                    double ido = Convert.ToInt32(input);
                    double sebesseg = ut / ido;
                    Console.WriteLine($"Az atlagsebesseg {sebesseg}km/h");
                }
                void kilencedikFeladat()
                {
                    Console.Write("Adja meg a a megtett ut hosszat(km)! ");
                    string input = Console.ReadLine();
                    double ut = Convert.ToInt32(input);
                    Console.Write("Adja meg az auto fogyasztasat(ft/liter)! ");
                    input = Console.ReadLine();
                    double fogyasztas = Convert.ToInt32(input);
                    Console.Write("Adja meg a benzin arat! ");
                    input = Console.ReadLine();
                    double benzin = Convert.ToInt32(input);
                    double utikoltseg = (ut / 100) * fogyasztas * benzin;
                    Console.WriteLine($"Az utikoltseg {utikoltseg}Ft");
                }
                void tizedikFeladat()
                {
                    Console.Write("Adja meg a tomeget(kg)! ");
                    string input = Console.ReadLine();
                    double tomeg = Convert.ToInt32(input);
                    Console.Write("Adja meg a magassagat!(cm) ");
                    input = Console.ReadLine();
                    double magassag = Convert.ToInt32(input);
                    double tti = tomeg / ((magassag / 100) * (magassag / 100));
                    Console.WriteLine($"A testtomeg indexe: {tti,4:f}");
                }
                void tizenegyedikFeladat()
                {
                    int alma = 120;
                    int szilva = 200;
                    int szolo = 135;
                    int osszesen = 0;
                    Console.WriteLine($"Alma: {alma,3:C}");
                    Console.Write("Mennyit szeretne vasarolni?(kg) ");
                    string input = Console.ReadLine();
                    int mennyit = Convert.ToInt32(input);
                    Console.WriteLine($"Ez {alma * mennyit,0:C}");
                    osszesen += alma * mennyit;
                    Console.WriteLine($"Szilva: {szilva,3:C}");
                    Console.Write("Mennyit szeretne vasarolni?(kg) ");
                    input = Console.ReadLine();
                    mennyit = Convert.ToInt32(input);
                    Console.WriteLine($"Ez {szilva * mennyit,0:C}");
                    osszesen += szilva * mennyit;
                    Console.WriteLine($"Szolo: {szolo,3:C}");
                    Console.Write("Mennyit szeretne vasarolni?(kg) ");
                    input = Console.ReadLine();
                    mennyit = Convert.ToInt32(input);
                    Console.WriteLine($"Ez {szolo * mennyit,0:C}");
                    osszesen += szolo * mennyit;
                    Console.WriteLine($"Osszesen {osszesen,0:C} kell fizetni");

                }
                void tizenkettedikFeladat()
                {
                    Console.Write("Adja meg a hordo terfogatat! ");
                    string input = Console.ReadLine();
                    int hordoTerfogata = Convert.ToInt32(input);
                    Console.Write("Adja meg a kancso terfogatat! ");
                    input = Console.ReadLine();
                    int kancsoTerfogata = Convert.ToInt32(input);
                    Console.WriteLine($"A hordobol {(hordoTerfogata - (hordoTerfogata % kancsoTerfogata)) / kancsoTerfogata} kancso merheto ki es {hordoTerfogata % kancsoTerfogata} kancso marad");
                    double hanyados = (double)hordoTerfogata / (double)kancsoTerfogata;
                    Console.WriteLine($"A hordo es a kancso hanyadosa {hanyados}");
                }
                void tizenharmadikFeladat()
                {
                    int bekertOsszeg = 1;
                    string input;
                    while (bekertOsszeg % 1000 != 0)
                    {
                        Console.WriteLine("Bankjegyautomata\n");
                        Console.WriteLine("A legkisebb cimlet 1000 Ft, a maximalisan felveheto osszeg 300 000 Ft.\n");
                        Console.Write("Adja meg a felvenni kivant osszeget!: ");
                        input = Console.ReadLine();
                        bekertOsszeg = Convert.ToInt32(input);
                        if (bekertOsszeg % 1000 != 0)
                        {
                            Console.WriteLine("Nem jo osszeget adott meg. Az osszegnek ezerrel oszthatonak kell lennie.");
                        }
                    }
                    int tizezres = 0, otezres = 0, ezres = 0;
                    ezres = (bekertOsszeg % 5000) / 1000;
                    bekertOsszeg = bekertOsszeg - (ezres * 1000);
                    otezres = (bekertOsszeg % 10000) / 5000;
                    bekertOsszeg = bekertOsszeg - (otezres * 5000);
                    tizezres = bekertOsszeg / 10000;
                    // Console.WriteLine($"{ezres} {otezres} {tizezres}"); debug sor
                    Console.WriteLine("A kiadott bakjegyek:\n");
                    Console.WriteLine($"{tizezres,2} * {10000,5} = {tizezres * 10000,6}");
                    Console.WriteLine($"{otezres,2} * {5000,5} = {otezres * 5000,6}");
                    Console.WriteLine($"{ezres,2} * {1000,5} = {ezres * 1000,6}");
                }
                void tizennegyedikFeladat()
                {
                    int uzemido = 0;
                    string input;
                    Console.Write("Adja meg az eszkoz uzemidejet masodpercben!: ");
                    input = Console.ReadLine();
                    uzemido = Convert.ToInt32(input);
                    int masodperc = uzemido % 3600;
                    uzemido = uzemido - masodperc;
                    uzemido = uzemido / 3600;
                    int ora = uzemido % 24;
                    uzemido = (uzemido - ora) / 24;
                    Console.WriteLine($"Az eszkoz {uzemido}napja {ora}oraja es {masodperc}masodperce uzemel.");
                }
                void tizenotodikFeladat()
                {
                    Console.WriteLine("Utazasi koltsegterites\n");
                    Console.Write("Add meg a megtett utat km-ben! ");
                    float megtettUt = float.Parse(Console.ReadLine());
                    Console.Write("Add meg az auto fogyasztasat 100km-re literben! ");
                    float fogyasztas = float.Parse(Console.ReadLine());
                    Console.Write("Add meg az uzemanyag arat ft-ban! ");
                    float uzemanyagAr = float.Parse(Console.ReadLine());

                    //üzemanyagköltség=(út*fogyasztás*üzemanyag ár)/100 ] 

                    float uzemanyagKoltseg = ((megtettUt * fogyasztas * uzemanyagAr) / 100);

                    if (megtettUt <= 100)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"Koltsegterites: {uzemanyagKoltseg:n3} ft.");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"Koltsegterites: {uzemanyagKoltseg + (megtettUt * 25):n3} ft.");
                        Console.ResetColor();
                    }

                }
            }
            //Elágazások
            {
                // tizenhatodikFeladat();
                // tizenhetedikFeladat();
                // tizennyolcadikFeladat();
                // tizenkilencedikFeladat();
                // huszadikFeladat();
                // huszonegyedikFeladat();
                // huszonkettedikFeladat();
                // huszonharmadikFeladat();
                // huszonnegyedikFeladat();
                // huszonotodikFeladat();
                // huszonhatodikFeladat();
                // huszonhetedikFeladat();
                // huszonnyolcadikFeladat();
                // huszonkilencedikFeladat();
                // harmincadikFeladat();

                void tizenhatodikFeladat()
                {
                    Console.Write("Adja meg a homersekletet!: ");
                    float homerseklet = float.Parse(Console.ReadLine());
                    if(homerseklet < 0)
                    {
                        Console.WriteLine("Kint fagy.");
                    }
                    else
                    {
                        Console.WriteLine("Nincs fagy.");
                    }
                }
                void tizenhetedikFeladat()
                {
                    Console.Write("Szeretsz programozni?(igen/nem) ");
                    string szeret = Console.ReadLine();
                    if(szeret == "i" || szeret == "igen")
                        {
                            Console.WriteLine("Még sokra viszed!");
                        }
                    Console.WriteLine("Viszontlátásra!");
                       
                }
                void tizennyolcadikFeladat()
                {
                    Console.Write("Adjon meg egy szamot! ");
                    int szam = int.Parse(Console.ReadLine());
                    if(szam % 2 == 0)
                    {
                        Console.WriteLine("A szam paros.");
                    }
                    else
                    {
                        Console.WriteLine("A szam paratlan.");
                    }
                }
                void tizenkilencedikFeladat()
                {
                    Console.Write("Adjon meg egy szamot! ");
                    int szam = int.Parse(Console.ReadLine());
                    if(szam % 3 == 0)
                    {
                        Console.WriteLine("A szam oszthato 3-mal.");
                    }
                    else
                    {
                        Console.WriteLine("A szam nem oszthato 3-mal.");
                    }
                }
                void huszadikFeladat()
                {
                    Console.Write("Adjon meg egy szamot! ");
                    int szam = int.Parse(Console.ReadLine());
                    if(szam < 0)
                    {
                        Console.WriteLine("A szam negativ.");
                    }
                    else if(szam > 0){
                        Console.WriteLine("A szam pozitiv.");
                    }
                    else
                    {
                        Console.WriteLine("A szam 0.");
                    }
                }
                void huszonegyedikFeladat()
                {
                    Console.Write("Adja meg az elso szamot! ");
                    int elso = int.Parse(Console.ReadLine());
                    Console.Write("Adja meg a masodik szamot! ");
                    int masodik = int.Parse(Console.ReadLine());
                    if(elso > masodik)
                    {
                        Console.WriteLine($"{elso} > {masodik}");
                    }
                    else if(elso < masodik)
                    {
                        Console.WriteLine($"{elso} < {masodik}");
                    }
                    else
                    {
                        Console.WriteLine($"{elso} = {masodik}");
                    }
                }
                void huszonkettedikFeladat()
                {
                    Console.Write("Adja meg a szamot! ");
                    int szam = int.Parse(Console.ReadLine());
                    if(szam > -30 && szam < 40)
                    {
                        Console.WriteLine("A szam kozotte van.");
                    }
                    else
                    {
                        Console.WriteLine("A szam nincs kozotte.");
                    }
                }
                void huszonharmadikFeladat()
                {
                    Console.Write("Adja meg a dolgozat pontszamat!(0-100) ");
                    int pontszam = int.Parse(Console.ReadLine());
                    if(pontszam < 43)
                    {
                        Console.WriteLine("Elegtelen.");
                    }
                    else if(pontszam < 58)
                    {
                        Console.WriteLine("Elegseges.");
                    }
                    else if (pontszam < 73)
                    {
                        Console.WriteLine("Kozepes.");
                    }
                    else if(pontszam < 88)
                    {
                        Console.WriteLine("Jo.");
                    }
                    else
                    {
                        Console.WriteLine("Jeles.");
                    }
                }
                void huszonnegyedikFeladat()
                {
                    Console.Write("Adja meg a helységnevet! ");
                    string helyseg = Console.ReadLine();
                    Console.Write("Adja meg a lelekszamot! ");
                    int lelekszam = int.Parse(Console.ReadLine());
                    if(lelekszam <= 0)
                    {
                        Console.WriteLine("Hibas adatbevitel.");
                    }
                    else if(lelekszam < 5000)
                    {
                        Console.WriteLine($"{helyseg} egy kozseg.");
                    }
                    else if(lelekszam < 20000)
                    {
                        Console.WriteLine($"{helyseg} egy kisvaros.");
                    }
                    else if (lelekszam < 100000)
                    {
                        Console.WriteLine($"{helyseg} egy kozepvaros.");
                    }
                    else if(lelekszam < 1000000)
                    {
                        Console.WriteLine($"{helyseg} egy nagyvaros.");
                    }
                    else
                    {
                        Console.WriteLine($"{helyseg} egy metropolis.");
                    }
               
                        
                    

                }
                void huszonotodikFeladat()
                {
                    Console.Write("Adja meg az elso szamot! ");
                    float elso = float.Parse(Console.ReadLine());
                    Console.Write("Adja meg a masodik szamot! ");
                    float masodik = float.Parse(Console.ReadLine());
                    Console.Write("Adja meg a muveleti jelet!(+,-,*,/) ");
                    string muveletiJel = Console.ReadLine();
                    switch (muveletiJel)
                    {
                        case "+":
                            Console.WriteLine(elso + masodik);
                            break;
                        case "-":
                            Console.WriteLine(elso - masodik);
                            break;
                        case "*":
                            Console.WriteLine(elso * masodik);
                            break;
                        case "/":
                            Console.WriteLine(elso / masodik);
                            break;
                    }
                }
                void huszonhatodikFeladat()
                {
                    Console.Write("Adja meg a diak evvegi jegyet! ");
                    int jegy = int.Parse(Console.ReadLine());
                    switch (jegy)
                    {
                        case 1:
                            Console.WriteLine("elegtelen");
                            break;
                        case 2:
                            Console.WriteLine("elegseges");
                            break;
                        case 3:
                            Console.WriteLine("kozepes");
                            break;
                        case 4:
                            Console.WriteLine("jo");
                            break;
                        case 5:
                            Console.WriteLine("jeles");
                            break;
                        default:
                            Console.WriteLine("Hibas adat.");
                            break;
                    }
                }
                void huszonhetedikFeladat()
                {
                    Console.Write("Adja meg a nap sorszamat!(1-7) ");
                    int nap = int.Parse(Console.ReadLine());
                    switch (nap)
                    {
                        case 1:
                            Console.WriteLine("hetfo");
                            break;
                        case 2:
                            Console.WriteLine("kedd");
                            break;
                        case 3:
                            Console.WriteLine("szerda");
                            break;
                        case 4:
                            Console.WriteLine("csutortok");
                            break;
                        case 5:
                            Console.WriteLine("pentek");
                            break;
                        case 6:
                            Console.WriteLine("szombat");
                            break;
                        case 7:
                            Console.WriteLine("vasarnap");
                            break;
                        default:
                            Console.WriteLine("hibas adat");
                            break;
                    }
                }
                void huszonnyolcadikFeladat()
                {
                    Console.Write("Adja meg a honap sorszamat!(1-12) ");
                    int honap = int.Parse(Console.ReadLine());
                    switch (honap)
                    {
                        case 1:
                            Console.WriteLine("Januar");
                            break;
                        case 2:
                            Console.WriteLine("Februar");
                            break;
                        case 3:
                            Console.WriteLine("Marcius");
                            break;
                        case 4:
                            Console.WriteLine("Aprilis");
                            break;
                        case 5:
                            Console.WriteLine("Majus");
                            break;
                        case 6:
                            Console.WriteLine("Junius");
                            break;
                        case 7:
                            Console.WriteLine("Julius");
                            break;
                        case 8:
                            Console.WriteLine("Augusztus");
                            break;
                        case 9:
                            Console.WriteLine("Szeptember");
                            break;
                        case 10:
                            Console.WriteLine("Oktober");
                            break;
                        case 11:
                            Console.WriteLine("November");
                            break;
                        case 12:
                            Console.WriteLine("December");
                            break;
                        default:
                            Console.WriteLine("hibas adat");
                            break;
                    }
                }
                void huszonkilencedikFeladat()
                {
                    Console.Write("Adja meg az aru egysegarat! ");
                    int egysegar = int.Parse(Console.ReadLine());
                    Console.Write("Adja meg a vasarolni kivant mennyiseget! ");
                    int mennyiseg = int.Parse(Console.ReadLine());
                    Console.Write("Adjam eg mennyi penze van! ");
                    int penz = int.Parse(Console.ReadLine());
                    if(egysegar*mennyiseg <= penz)
                    {
                        Console.WriteLine($"Meg tudjuk vasarolni a kivant darabszamot es {penz - (egysegar * mennyiseg)} forintunk maradna.");
                    }
                    else
                    {
                        Console.WriteLine($"{penz / egysegar} darabot tudunk megvasarolni.");
                    }
                }
                void harmincadikFeladat()
                {
                    Console.Write("Adja meg az evet! ");
                    int ev = int.Parse(Console.ReadLine());
                    if(((ev % 4 == 0) && (ev % 100 != 0)) || (ev % 400 == 0))
                    {
                        Console.WriteLine("Szokoev.");
                    }
                    else
                    {
                        Console.WriteLine("Nem szokoev.");
                    }
                }
            }
            //Véletlenszámok
            {
                // harmincegyedikFeladat();
                // harminckettedikFeladat();
                // harmincharmadikFeladat();
                // harmincnegyedikFeladat();
                // harmincotodikFeladat();
                // harminchatodikFeladat();
                // harminchetedikFeladat();
                harmincnyolcadikFeladat();
                // harminckilencedikFeladat();
                // negyvenedikFeladat();

                void harmincegyedikFeladat()
                {
                    var rand = new Random();
                    int veletlenHaromjegyu = rand.Next(100, 1000);
                    Console.WriteLine(veletlenHaromjegyu);
                }
                void harminckettedikFeladat()
                {
                    var rand = new Random();
                    int egesz = rand.Next(0, 26);
                    double tizedes = 25 * rand.NextDouble();
                    Console.WriteLine($"Az egesz szam: {egesz}\nA tizedes: {tizedes:n3}");
                }
                void harmincharmadikFeladat()
                {
                    var rand = new Random();
                    int egesz = rand.Next(15, 26);
                    double tizedes = rand.Next(15, 25) + rand.NextDouble();
                    Console.WriteLine($"Az egesz szam: {egesz}\nA tizedes: {tizedes:n3}");
                }
                void harmincnegyedikFeladat()
                {
                    var rand = new Random();
                    int paros = 1;
                    while (paros % 2 != 0)
                    {
                        paros = rand.Next(0, 100);
                    }
                    Console.WriteLine(paros);
                }
                void harmincotodikFeladat()
                {
                    var rand = new Random();
                    int ottel = 4;
                    while(ottel % 5 != 0)
                    {
                        ottel = rand.Next(100, 201);
                    }
                    Console.WriteLine(ottel);
                }
                void harminchatodikFeladat()
                {
                    var rand = new Random();
                    int szam = rand.Next(0, 1000001);
                    string szamSzoveg = szam.ToString();
                    Console.WriteLine(szamSzoveg.Length);
                }
                void harminchetedikFeladat()
                {
                    var rand = new Random();
                    for(int i = 0; i < 6; i++)
                    {
                        Console.Write((rand.Next(1, 7)) + " ");
                    }
                }
                void harmincnyolcadikFeladat()
                {
                    var rand = new Random();
                    string[] lotto = { "0", "0", "0", "0", "0"};
                    for(int i = 0; i < lotto.Length; i++)
                    {
                        int szam = rand.Next(1, 91);
                        lotto[i] = szam.ToString();
                    }
                    for (int i = 0; i < lotto.Length; i++)
                    {
                        Console.WriteLine(lotto[i]);
                    }




                }
                void harminckilencedikFeladat()
                {
                    var rand = new Random();
                    int a = rand.Next(10, 51);
                    int b = rand.Next(10, 51);
                    int osszeg = a + b;
                    Console.Write($"{a}+{b}=?: ");
                    int valasz = int.Parse(Console.ReadLine());
                    if(valasz == osszeg)
                    {
                        Console.WriteLine("A valasz helyes.");
                    }
                    else
                    {
                        Console.WriteLine("A valasz helytelen.");
                    }
                }
                void negyvenedikFeladat()
                {
                    var rand = new Random();
                    int szam = rand.Next(0, 101);
                    // Console.WriteLine(szam); --debug
                    Console.Write("Tippeljen! ");
                    int tipp = int.Parse(Console.ReadLine());
                    if(tipp == szam)
                    {
                        Console.WriteLine("Eltalalta!");
                    }
                    else
                    {
                        Console.WriteLine("Nem nyert.");
                    }
                }
            }

        }
    }
}
