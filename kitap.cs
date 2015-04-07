using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uygulama
{
   abstract class kitap:IoduncAlınabilir,Interface1 
    {
        string yazar;
        string ISBN;
        string isim;

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }
        DateTime odunctarihi;
       string ozet;
        bool oduncalındı;
        public kitap(string yazar,string ISBN,string isim,DateTime odunctarihi,string ozet,bool oduncalındı)
        {
            this.yazar = yazar;
            this.ISBN = ISBN;
            this.isim =isim ;
            this.odunctarihi = odunctarihi;
            this.oduncalındı = oduncalındı;
            this .ozet =ozet =
        }

       
       public virtual string ToSitring()
       {
       return "isim"+this .isim +"\nyazar"+this .yazar ;
       }

       public void oduncal(DateTime Date)
       {
           odunctarihi =Date;
           oduncalındı =true ;
       }

       public string  Gözat()
       {
           return ozet ;
       }


       public void Iadeet()
       {
       oduncalındı =false ;
       }
    }
}
