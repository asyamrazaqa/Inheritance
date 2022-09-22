using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asyam_Razaq_A._212410101021_PBO_PR_A_Inheritance
{
    internal class Program
    {
        class Ban
        {
            public String merk;

            public void MerkBanTampil(string merk)
            {
                this.merk = merk;
                Console.WriteLine("Mobil ini menggunakan ban: " + merk);
            }
        }
        class Michelin : Ban
        {
            public Michelin()
            {
                merk = "Michelin";
                MerkBanTampil(merk);
            }
        }

        class Bridgestone : Ban
        {
            public Bridgestone()
            {
                merk = "Bridgestone";

            }
        }
/// <summary>
/// 
/// </summary>
        class Mobil
        {
            public string merk;
            public string tipe;
            public Ban ban;

            public void NyalakanMesin()
            {
                System.Console.WriteLine("Mobil bermesin " + merk + " dengan tipe " + tipe + " menyala");
            }
            public void MatikanMesin()
            {
                System.Console.WriteLine("Mobil bermesin " + merk + " dengan tipe " + tipe + " mati");
            }

            public void NyalakanLampu()
            {
                Console.WriteLine("Merk lampu mobil " + merk + " dengan tipe " + tipe + " menyala");
            }
        }
        class Toyota : Mobil
        {
            public Toyota()
            {
                merk = "Toyota";
            }

        }

        class Daihatsu : Mobil
        {
            public Daihatsu()
            {
                merk = "Daihatsu";
            }
        }

        class Honda : Mobil
        {
            public Honda()
            {
                merk = "Honda";
            }
        }

        class Agya : Toyota
        {
            public Agya()
            {
                tipe = "Agya";
            }
        }

        class Innova : Toyota
        {
            public Innova()
            {
                tipe = "Innova";
            }
        }

        class Avanza : Toyota
        {
            public Avanza()
            {
                tipe = "Avanza";
            }
            public void NyalakanLampu()
            {
                Console.WriteLine("Merk lampu mobil " + merk + " dengan tipe " + tipe + " menyala");
            }
        }

        class Ayla : Daihatsu
        {
            public Ayla()
            {
                tipe = "Ayla";
            }
        }

        class Xenia : Daihatsu
        {
            public Xenia()
            {
                tipe = "Xenia";
            }
        }

        class Brio : Honda
        {
            public Brio()
            {
                tipe = "Brio";
            }
        }

        class Civic : Honda
        {
            public Civic()
            {
                tipe = "Civic";
            }
            public void VtecKickedIn()
            {
                Console.WriteLine("BRRRRMMMMMMMM NNGGGEEENGGG WWWWOOOOSSSHHH!!!!");
            }
        }
/// <summary>
/// 
/// </summary>
/// <param name="args"></param>
            static void Main(string[] args)
        {
                // Pada variabel mobil1 dengan objek Agya yang menggunakan ban Michelin
                Mobil mobil1 = new Agya();
                mobil1.ban = new Michelin();
                mobil1.NyalakanMesin();
                mobil1.MatikanMesin();

                // Pada variabel mobil2 dengan objek Avanza yang menggunakan ban Bridgestone
                Avanza mobil2 = new Avanza();
                mobil2.ban = new Bridgestone();
                mobil2.NyalakanLampu();

                // Pada variabel civic1 dengan objek Civic yang menggunakan ban Bridgestone
                Civic civic1 = new Civic();
                civic1.ban = new Bridgestone();
                civic1.VtecKickedIn();

                // Pada variabel honda1 bertipe data Honda, kemudian masukkan objek civic1 sebagai nilainya. 
                Honda honda1 = civic1;
                //honda1.VtecKickedIn();
            }
        }
    }
    

