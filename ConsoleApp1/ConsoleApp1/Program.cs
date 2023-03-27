using System;

class Mobil
{
    public string warna { get; set; }
    public int jumlahPintu { get; set; }
    public string merek { get; set; }
    public string model { get; set; }
    public int tahunKeluaran { get; set; }

    public void gas(int kecepatan)
    {
        Console.WriteLine("Mobil " + model + " berjalan dengan kecepatan " + kecepatan);
    }

    public void klakson(string suara)
    {
        Console.WriteLine(suara);
    }

    public void tampilkanInfo()
    {
        Console.WriteLine("Mobil saya berwarna " + warna + ", merek " + merek + " model " + model + " keluaran tahun " + tahunKeluaran + " dengan jumlah pintu sebanyak " + jumlahPintu);
    }
}