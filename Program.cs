using System;

namespace Feladatok1
{
    class Program
    {
        static void Main(string[] args)
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
            tizenotodikFeladat();


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
                while(bekertOsszeg % 1000 != 0)
                {
                    Console.WriteLine("Bankjegyautomata\n");
                    Console.WriteLine("A legkisebb cimlet 1000 Ft, a maximalisan felveheto osszeg 300 000 Ft.\n");
                    Console.Write("Adja meg a felvenni kivant osszeget!: ");
                    input = Console.ReadLine();
                    bekertOsszeg = Convert.ToInt32(input);
                    if(bekertOsszeg % 1000 != 0)
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
                Console.WriteLine($"{ezres,2} * {1000,5} = {ezres*1000,6}");
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
                
            }



        }
    }
}
