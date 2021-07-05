using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VitaminDeposu
{
    class Elma : Meyve //meyve sınıfından kalıtım alan elma sınıfı
    {
        public Elma(int miktar, int verim, Image image)      //yapıcı metot
        {

            Miktar = miktar;
            Verim = verim;
            Image = image;


        }

        Random rast = new Random();
        public Elma()            //parametresiz yapıcı metot
        {
            

            Miktar = rast.Next(70, 120);

          

           
            Verim = rast.Next(80, 95);
            Image = Image.FromFile("elma.png");


        }

        //kullanılacak private değişkenler
        private int _elmaVitamina;
        private int _elmaVitaminc;
        private int _elmaVerim;
        private int _elmaMiktar;
        private int _elmaPure;








        //public miktar özelliğine değerler atanıyor
        public override int Miktar
        {
            get { return _elmaMiktar; }
            set { _elmaMiktar = value; }

        }

        //public verim özelliğine değerler atanıyor
        public override int Verim
        {
            get { return _elmaVerim; }
            set { _elmaVerim = value; }

        }

        //public vitamina özelliğine değerler atanıyor
        public override int VitaminA
        {
            get { return (_elmaMiktar * _elmaVerim / 100) * 54 / 100; }
            set { _elmaVitamina = value; }

        }

        //public vitaminc özelliğine değerler atanıyor
        public override int VitaminC
        {
            get { return (_elmaMiktar * _elmaVerim / 100) * 5 / 100; ; }
            set { _elmaVitaminc = value; }


        }

        //public toplamsivi özelliğine değerler atanıyor
        public override int ToplamSivi
        {
            get;set;

        }

        //public toplampure özelliğine değerler atanıyor
        public override int ToplamPure
        {
            get { return _elmaMiktar * _elmaVerim / 100; }
            set { _elmaPure = value; }

        }

        //public iMAGE özelliğine değerler atanıyor
        public override Image Image
        {
            get;
            set;

        }

    }
}
