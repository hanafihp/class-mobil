using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        class Program
        {
            static void Main(string[] args)
            {
                Mobil mobilku = new Mobil();
                mobilku.jumlahPintu = 2;
                mobilku.warna = "Putih";
                mobilku.merek = "Toyota";
                mobilku.model = "Supra MK";
                mobilku.tahunKeluaran = 2023;

                mobilku.tampilkanInfo(); // Output: "Mobil saya berwarna Putih, merek Toyota model Supra MK keluaran tahun 2023 dengan jumlah pintu sebanyak 2"

                mobilku.gas(320); // Output: "Mobil Supra MK berjalan dengan kecepatan 320"

                mobilku.klakson("pettt"); // Output: "pettt!"
            }
        }
    }
}
