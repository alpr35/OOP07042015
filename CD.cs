using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uygulama
{
    class CD:Interface1 
    {
        string isim;

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }
        string turu;
        string ozet;
        public CD(string isim, string turu, string ozet)
        {
            this.isim = isim;
            this.turu = turu;
            this.ozet = ozet;
        }

        public string gözat()
        {
           oduncTarihi=
        }

    }
}
