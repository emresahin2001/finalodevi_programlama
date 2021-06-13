using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;




namespace finalodevi
{
    class Program
    {
        static void Main(string[] args)
        {
            OgrenciSinifi product = new OgrenciSinifi();
            product.OgrenciNo = 325453;
            product.Ad = "Necati";
            product.Soyad = "Akçay";
            product.DoğumTarihi = "11.03.2000";
            product.Bolumu = "Elektrik Mühendisliği";
            product.Sinifi = "A";
            product.NotOrtalaması = 76;

            string json = JsonConvert.SerializeObject(product);



            PersonelSinifi product = new PersonelSinifi();
            product.KimlikNo = 477678378;
            product.Ad = "Buse";
            product.Soyad = "Aslanoglu";
            product.DoğumTarihi = "13.11.2000";
            product.Departman = "Denetleme ve Analiz Departmanı";
            product.Gorevi = "Hoca";
            product.BaslamaTarihi = "16.04.2000";

            string json = JsonConvert.SerializeObject(product);





            IdariPersonelSinifi product = new IdariPersonelSinifi();
            product.KimlikNo = 432523652;
            product.Ad = "Fatih";
            product.Soyad = "Terim";
            product.DoğumTarihi = "09.07.1956";
            product.Gorevi = "Hoca";


            string json = JsonConvert.SerializeObject(product);






            OgrenciIsleriPersonel product = new OgrenciIsleriPersonel();
            product.KimlikNo = 231354525;
            product.Ad = "Murat";
            product.Soyad = "Şahin";
            product.DoğumTarihi = "26.09.2000";
            product.Gorevi = "Hoca";

            string json = JsonConvert.SerializeObject(product);





            OgretimGorevlisiPersonel product = new OgretimGorevlisiPersonel();
            product.KimlikNo = 13543512;
            product.Ad = "Ali İhsan ";
            product.Soyad = "Varol";
            product.DoğumTarihi = "18.07.1997";
            product.Gorevi = "Hoca";

            string json = JsonConvert.SerializeObject(product);






            DerslerTanimSinifi product = new DerslerTanimSinifi();
            product.DersNo = 42;
            product.Ad = "Sergen";
            product.Acıklama = "Yalçın";
            product.OgretimGorevlisi = "05.10.1972";


            string json = JsonConvert.SerializeObject(product);





            OgrenciDerslerSinifi product = new OgrenciDerslerSinifi();
            product.DersNo = 54;
            product.OgrenciNo = 43243;


            string json = JsonConvert.SerializeObject(product);




        }

    }
}



