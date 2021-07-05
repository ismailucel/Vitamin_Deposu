using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VitaminDeposu
{
    class Greyfurt : Meyve //meyve sınıfından kalıtım alan greyfurt sınıfı
    {
        public Greyfurt(int miktar, int verim, Image image)   //yapıcı metot
        {

            Miktar = miktar;
            Verim = verim;
            Image = image;


        }
        Random rast = new Random();
        public Greyfurt()            //parametresiz yapıcı metot
        {
            
            

            Miktar = rast.Next(70, 120);

            
            Verim = rast.Next(30, 70);
            Image = Image.FromFile("greyfurt.png");


        }

        //kullanılacak private değişkenler
        private int _greyfurtVitamina;
        private int _greyfurtVitaminc;
        private int _greyfurtVerim;
        private int _greyfurtMiktar;
        private int _greyfurtSivi;









        //public miktar özelliğine değerler atanıyor
        public override int Miktar
        {

            get { return _greyfurtMiktar; }
            set { _greyfurtMiktar = value; }

        }

        //public verim özelliğine değerler atanıyor

        public override int Verim
        {

            get { return _greyfurtVerim; }
            set { _greyfurtVerim = value; }

        }

        //public vitamina özelliğine değerler atanıyor

        public override int VitaminA
        {
            get { return (_greyfurtMiktar * _greyfurtVerim / 100) * 3 / 100; }
            set { _greyfurtVitamina = value; }

        }

        //public vitaminc özelliğine değerler atanıyor

        public override int VitaminC
        {
            get { return (_greyfurtMiktar * _greyfurtVerim / 100) * 44 / 100; ; }
            set { _greyfurtVitaminc = value; }


        }

        //public toplamsivi özelliğine değerler atanıyor

        public override int ToplamSivi
        {
            get { return _greyfurtMiktar * _greyfurtVerim / 100; }
            set { _greyfurtSivi = value; }

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
