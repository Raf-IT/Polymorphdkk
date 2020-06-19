using System;
using System.Collections.Generic;
using PolymorphCollection.ClassAnak;
using PolymorphCollection.ClassInduk;

namespace PolymorphCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tugas8\n");
			
            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "19.11.2707";
            karyawanTetap.Nama = "Burhan";
            karyawanTetap.GajiBulanan = 3500000;
			
            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "19.11.7070";
            karyawanHarian.Nama = "Aziz";
            karyawanHarian.JumlahJamKerja = 10;
            karyawanHarian.UpahPerJam = 50000;

            Sales sales = new Sales();
            sales.Nik = "19.11.2077";
            sales.Nama = "Rafid";
            sales.JumlahPenjualan = 500;
            sales.Komisi = 5000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);
			
			int i = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine(" {0}.\tNIK: {1}\n\tNama: {2} \n\tGaji: {3:N0}\n", i, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                i++;
            }
            Console.WriteLine("\n\n\nm@d3 by\nNama: Burhan Rafid Aziz\nNIM: 19.11.2707\nKelas 19IF02\nTekan apapun untuk keluar ...");
            Console.ReadKey();
        }
    }
}