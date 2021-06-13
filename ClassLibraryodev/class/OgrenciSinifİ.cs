using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryodev
{
    class OgrenciSinifİ : IOgrenci
    {
        public int OgrenciNo { get ; set ; }
        public string Ad { get ; set ; }
        public string Soyad { get ; set ; }
        public DateTime DogumTarihi { get ; set ; }
        public string Bolumu { get ; set ; }
        public string Sınıfı { get ; set ; }

        public int NotOrtalamasi()
        {
            throw new NotImplementedException();
        }
    }
}
