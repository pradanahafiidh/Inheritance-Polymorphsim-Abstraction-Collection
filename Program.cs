using System;
using Tugas_8.ClassAnak;
using Tugas_8.ClassInduk;
using System.Collections.Generic;

namespace Tugas_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 : Inheritance,Polymorphism,Abstractions,& Collection";

            karyawanHarian karyawan1 = new karyawanHarian();
            karyawan1.Nik = "2645";
            karyawan1.Nama = "Hafiidh";
            karyawan1.upahPerjam = 100000;
            karyawan1.jumlahJam = 8;

            karyawanTetap karyawan2 = new karyawanTetap();
            karyawan2.Nik = "2192";
            karyawan2.Nama = "Khoiru";
            karyawan2.gajiBulanan = 4000000;

            sales karyawan3 = new sales();
            karyawan3.Nik = "2726";
            karyawan3.Nama = "Pradana";
            karyawan3.jumlahPenjualan = 30;
            karyawan3.komisi = 100000;

            List<Karyawan> listKaryawan = new  List<Karyawan>();
            listKaryawan.Add(karyawan1);
            listKaryawan.Add(karyawan2);
            listKaryawan.Add(karyawan3);

            int nomorUrut = 1;

            foreach(Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}." + " " + "Nik.{1}" + "\t" + "Nama : {2}" + "\t" + "Gaji : {3}"
                    ,nomorUrut,karyawan.Nik,karyawan.Nama,karyawan.Gaji());
                nomorUrut++;
            }

            Console.ReadKey();
        }
    }
}
