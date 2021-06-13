using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryodev
{
    class DerslerTanimSinifi : IDerslerTanim
    {
        public int DerslerNo { get; set; }
        public string Ad { get ; set ; }
        public string Aciklama { get ; set; }
        public string OgretimGorevlisi { get ; set ; }
    }
}
