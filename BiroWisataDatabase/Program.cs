using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace BiroWisataConsole
{
    class Program
    {
        static string connectionString =
            "Data Source=KAMILIA\\KAMILIANURMALA;Initial Catalog=DbProgramSiswa;Integrated Security=True;";

        static List<Pelanggan> Pelanggans = new List<Pelanggan>();
        static List<Driver> Drivers = new List<Driver>();
        static List<Kendaraan> Kendaraans = new List<Kendaraan>();
        static List<PaketWisata> Pakets = new List<PaketWisata>();
        static List<Pemesanan> Pemesanans = new List<Pemesanan>();
        static List<Pembayaran> Pembayarans = new List<Pembayaran>();
        static List<Operasional> Operasionals = new List<Operasional>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== SISTEM BIRO WISATA (ADMIN) ===");
                ...
                Console.Write("Pilih menu: ");

                switch (Console.ReadLine())
                {
                    ...
                }
        }
    }


}