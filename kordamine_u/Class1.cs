using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine_u
{
	class Class1
	{
        static void Saali_suurus()
        {
            Console.WriteLine("Vali saali suurus; 1,2,3");//kuvab teavet konsooli
            int suurus = int.Parse(Console.ReadLine());
            return suurus;
        }
        static int[,] saal = new int[,] { };
        static int kohad, read, mitu, mitu_veel;//säilitab isegi oma tähenduse
        static void Saali_taitmine(int suurus)
        {
            Random rnd = new Random();//randoomsed kohad tulevad
            if (suurus == 1)
            {
                kohad = 20;//esimese suuruse kohad ja read
                read = 10;
            }
            else if (suurus == 2)
            {
                kohad = 20;
                read = 20;
            }
            else
            {
                kohad = 30;
                read = 20;
            }
            saal = new int;//
            for (int rida = 0; rida < read; rida++)
            {
                for (int koht = 0; koht < kohad; koht++)
                {
                    saal[rida, koht] = rnd.Next(0, 2);
                }
            }
        }
        static void Saal_ekraanile()
        {
            Console.Write("     ");
            for (int koht = 0; koht < kohad; koht++)
            {
                if (koht.ToString().Lenght == 2)
                { Console.Write("{0}", koht + 1); }
                else
                { Console.WriteLine("{0}", koht + 1); }// millise koha valib klient, koguaeg hakkab tulema +1
            }

            Console.WriteLine();
            for (int rida = 0; rida < read; rida++)
            {
                Console.Write("rida" + (rida + 1).ToString() + ":");
                for (int koht = 0; koht < kohad; koht++)
                {
                    Console.Write(saal[rida, koht] + "  ");
                }
                Console.WriteLine();
            }
        }

        static void Muuk()
        {
            Console.Write("Rida: ");
            int pileti_rida = int.Parse(Console.ReadLine());

            Console.WriteLine("mitu piletid:");//küsimus kliendile
            mitu = int.Parse(Console.ReadLine());
            mitu_veel = mitu;
            ost = new int[mitu];
            int p = (kohad - mitu) / 2;//kohti lahutame selle arvuga mille valis klient
            bool t = false;
            int k = 0;//nulline tähtsus panime, kuna klient ise valib millise koha tahab valida
            do
            {
                if (saal[pileti_rida, p] == 0)
                {
                    Console.WriteLine("koht{0} on vaba", p);
                    return true;
                }
                else
                {
                    Console.WriteLine("koht{0} on kinni", p);
                    t = false;//kui see koht pole vaba siis see funktsioon hakkab tööle ja edasi ei lähe
                    ost = new int[mitu];
                    k = 0;
                    p = (kohad - mitu) / 2;
                    break;
                }
                p = p + 1;
                k++;
            } while (mitu != k);
            if (t == true)
            {
                Console.WriteLine("Sinu kohad on;");
                foreach (var koh in ost)//dubleerib massiivi iga kirje märgistuse osa ja seob selle märgistuse iga koopia vastava massiiviüksusega
                {
                    Console.WriteLine("{0}\n"koh);
                }
            }
            else
            {
                Console.WriteLine("Selles reas ei ole vabu kohti.Kas tahad teises reas otsida");//ütleb et on vaja infot otsida teise liini
            }
        }

        public static void Main(string[] args)
        {
            int suurus = Saali_suurus();
            int[,] saal = new int[20, 30];
            Random rnd = new Random();//randoomsed kohad tulevad
            for (int rida = 0; rida < 20; rida++)
            {
                for (int koht = 0; koht < 30; koht++)
                {
                    saal[rida, koht] = rnd.Next(0, 2);
                }
            }
            for (int rida = 0; rida < 20; rida++)
            {
                for (int koht = 0; koht < 30; rida++)
                {
                    Console.WriteLine(saal[rida, koht]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
	}
}
