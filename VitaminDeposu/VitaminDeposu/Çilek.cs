using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VitaminDeposu
{
    class Cilek : Meyve     //meyve sınıfından kalıtım alan çilek sınıfı
    {
        public Cilek(int miktar, int verim, Image image)      //yapıcı metot
        {

            Miktar = miktar;
            Verim = verim;
            Image = image;


        }
        Random rast = new Random();
        public Cilek()                //parametresiz yapıcı metot
        {
           

            Miktar = rast.Next(70, 120);

           

          
            Verim = rast.Next(80, 95);
            Image = Image.FromFile("çilek.png");


        }

        //kullanılacak private değişkenler
        private int _cilekVitamina;
        private int _cilekVitaminc;
        private int _cilekVerim;
        private int _cilekMiktar;
        private int _cilekPure;








        //public miktar özelliğine değerler atanıyor
        public override int Miktar
        {
            get { return _cilekMiktar; }
            set { _cilekMiktar = value; }

        }

        //public verim özelliğine değerler atanıyor
        public override int Verim
        {
            get { return _cilekVerim; }
            set { _cilekVerim = value; }

        }

        //public vitamina özelliğine değerler atanıyor
        public override int VitaminA
        {
            get { return (_cilekMiktar * _cilekVerim / 100) * 12 / 100; }
            set { _cilekVitamina = value; }

        }

        //public vitaminc özelliğine değerler atanıyor
        public override int VitaminC
        {
            get { return (_cilekMiktar * _cilekVerim / 100) * 60 / 100; ; }
            set { _cilekVitaminc = value; }


        }
        //public toplamsivi özelliğine değerler atanıyor
        public override int ToplamSivi
        {
            get; set;

        }

        //public toplampure özelliğine değerler atanıyor
        public override int ToplamPure
        {
            get { return _cilekMiktar * _cilekVerim / 100; }
            set { _cilekPure = value; }

        }
        //public image özelliğine değerler atanıyor
        public override Image Image
        {
            get;
            set;

        }


    }
}
