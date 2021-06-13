using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryodev
{
    class PersonelSinifi : IPersonel
    {
        public int KimlikNo { get ; set ; }
        public string Ad { get ; set ; }
        public string Soyad { get ; set ; }
        public DateTime DogumTarihi { get ; set ; }
        public Enumlar.Departman Departman { get ; set ; }
        public Enumlar.Gorev Gorevi { get ; set ; }
        public DateTime BaslamaTarihi { get ; set ; }
    }
}
