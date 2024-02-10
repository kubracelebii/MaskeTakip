using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Vatandas vatandas1 = new Vatandas();
           

            SelamVer();
            int sonuc = Topla();

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            // List<string> sehirler1 = new List<string>{ "Ankara", "İstanbul", "İzmir" }; 
            // sehirler1.Add("Adana") diyerek o listeye ekleyebiliriz
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Mardin" };

            sehirler1 = sehirler2;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]); // Adana olur stack-heap olayından kaynaklı

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }


            Person person1 = new Person();
            person1.FirstName = "Kübra";
            person1.LastName = "Çelebi";
            person1.DateOfBirthYear = 2000;
            person1.NationalIdentity = 25183929054;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();

            
        }

        //resharper
        static void SelamVer(string isim= "isimsiz") // bu bir method ve void hiçbir şey döndürme demek
        {
            Console.WriteLine("selam");
        }

        static int Topla(int sayi1 = 5, int sayi2= 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + sonuc);
            return sonuc;
        }
       private static void Degiskenler()
        {
            string ad = "Kübra";
            string soyad = "Çelebi";
            int dogumYili = 2000;
            long tcNo = 12345678910;
        }

    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set;}
        public int DogumYili { get;  set;}
        public long TcNo { get;  set;}
    }
}