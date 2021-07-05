using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VitaminDeposu
{
    class Mandalina : Meyve //meyve sınıfından kalıtım alan mandalina sınıfı
    {
        public Mandalina(int miktar, int verim, Image image)    //yapıcı metot
        {

            Miktar = miktar;
            Verim = verim;
            Image = image;


        }
        Random rast = new Random();
        public Mandalina()          //parametresiz yapıcı metot
        {
            

            Miktar = rast.Next(70, 120);

            
           
            Verim = rast.Next(30, 70);
            Image = Image.FromFile("mandalina.png");


        }

        //kullanılacak private değişkenler
        private int _mandalinaVitamina;
        private int _mandalinaVitaminc;
        private int _mandalinaVerim;
        private int _mandalinaMiktar;
        private int _mandalinaSivi;









        //public miktar özelliğine değerler atanıyor
        public override int Miktar
        {
            get { return _mandalinaMiktar; }
            set { _mandalinaMiktar = value; }

        }

        //public verim özelliğine değerler atanıyor

        public override int Verim
        {
            get { return _mandalinaVerim; }
            set { _mandalinaVerim = value; }

        }

        //public vitamina özelliğine değerler atanıyor

        public override int VitaminA
        {
            get { return (_mandalinaMiktar * _mandalinaVerim / 100) * 681 / 100; }
            set { _mandalinaVitamina = value; }

        }

        //public vitaminc özelliğine değerler atanıyor

        public override int VitaminC
        {
            get { return (_mandalinaMiktar * _mandalinaVerim / 100) * 26 / 100; ; }
            set { _mandalinaVitaminc = value; }


        }

        //public toplamsivi özelliğine değerler atanıyor
        public override int ToplamSivi
        {
            get { return _mandalinaMiktar * _mandalinaVerim / 100; }
            set { _mandalinaSivi = value; }

        }

        //public toplampure özelliğine değerler atanıyor
        public override int ToplamPure
        {
            get; set;

        }
        //public image özelliğine değerler atanıyor

        public override Image Image
        {
            get;
            set;

        }


    }
}
