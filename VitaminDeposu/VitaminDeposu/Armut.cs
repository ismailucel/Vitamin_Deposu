using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VitaminDeposu
{
    class Armut : Meyve     //meyve sınıfından kalıtım alan armut sınıfı
    {
        public Armut(int miktar, int verim, Image image)      //yapıcı metot
        {

            Miktar = miktar;
            Verim = verim;
            Image = image;


        }
        Random rast = new Random();
        public Armut()            //parametresiz yapıcı metot
        {
           
            Miktar = rast.Next(70, 120);

           
            Verim = rast.Next(80, 95);
            Image = Image.FromFile("armut.png");


        }


        //kullanılacak private değişkenler
        private int _armutVitamina;
        private int _armutVitaminc;
        private int _armutVerim;
        private int _armutMiktar;
        private int _armutPure;

      






        //public miktar özelliğine değerler atanıyor

        public override int Miktar
        {
            get { return _armutMiktar; }
            set { _armutMiktar = value; }

        }

        //public verim özelliğine değerler atanıyor
        public override int Verim
        {
            get { return _armutVerim; }
            set { _armutVerim = value; }

        }

        //public vitamina özelliğine değerler atanıyor


        public override int VitaminA
        {
            get { return (_armutMiktar * _armutVerim / 100) * 25 / 100; }
            set { _armutVitamina = value; }

        }

        //public vitaminc özelliğine değerler atanıyor

        public override int VitaminC
        {
            get { return (_armutMiktar * _armutVerim / 100 )* 5 / 100;  }
            set { _armutVitaminc = value; }


        }

        //public toplamsivi özelliğine değerler atanıyor

        public override int ToplamSivi
        {
            get; set;

        }

        //public toplampure özelliğine değerler atanıyor

        public override int ToplamPure
        {
            get { return _armutMiktar * _armutVerim / 100; }
            set { _armutPure = value; }

        }

        //public image özelliğine değerler atanıyor

        public override Image Image
        {
            get;
            set;

        }

   


    }
}
