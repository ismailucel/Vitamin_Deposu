using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace VitaminDeposu
{
    class Portakal : Meyve  //meyve sınıfından kalıtım alan portakal sınıfı
    {
        public Portakal(int miktar, int verim, Image image) {  //yapıcı metot

            Miktar = miktar;
            Verim = verim;
            Image = image;
        
        
        }
         Random rast = new Random();

        public Portakal()                   //parametresiz yapıcı metot 
        {
            Miktar = rast.Next(70,120);
            Verim = rast.Next(30,70);
            Image = Image.FromFile("portakal.png");


        }

        //kullanılacak private değişkenler
        private int _portakalVitamina;
        private int _portakalVitaminc;
        private int _portakalVerim;
        private int _portakalMiktar;
        private int _portakalSivi;

         
      

        //public miktar özelliğine değerler atanıyor
        public override int Miktar
        {
            get { return _portakalMiktar; }
            set { _portakalMiktar = value; }

        }

        //public verim özelliğine değerler atanıyor
        public override int Verim
        {
            get { return _portakalVerim; }
            set { _portakalVerim = value; }

        }

        //public vitamina özelliğine değerler atanıyor

        public override int VitaminA
        {
            get { return (_portakalMiktar * _portakalVerim / 100) * 225 / 100; }
            set { _portakalVitamina = value; }

        }

        //public vitaminc özelliğine değerler atanıyor
        public override int VitaminC
        {
            get { return (_portakalMiktar * _portakalVerim / 100) * 5 / 100; ; }
            set { _portakalVitaminc = value; }


        }

        //public toplamsivi özelliğine değerler atanıyor

        public override int ToplamSivi
        {
            get { return _portakalMiktar * _portakalVerim / 100;  }
            set { _portakalSivi = value; }

        }
        //public toplampure özelliğine değerler atanıyor

        public override int ToplamPure
        {
            get;set;

        }

        //public image özelliğine değerler atanıyor

        public override Image Image 
           {
            get;
            set;

           }
    


    }
}
