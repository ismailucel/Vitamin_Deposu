using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaminDeposu
{
   public abstract class Meyve: IMeyve  //IMeyve arayüzünden Meyve soyut sınıfı oluşturuluyor
    {
       
        //soyut miktar özelliği
       abstract public int Miktar {

            get; set;

        }

        //soyut verim özelliği
        abstract public int Verim

        {
            get; set;

        }



        //soyut vitamina özelliği
        abstract public int VitaminA

        {
            get; set;

        }
        //soyut vitaminc özelliği
        abstract public int VitaminC

        {

            get; set;

        }
        //soyut toplamsivi özelliği
        abstract public int ToplamSivi
        {
            get; set; 
        }


        //soyut toplampure özelliği
        abstract public int ToplamPure 
        {
            get;  set; 
        }




        //soyut image özelliği
        abstract public Image Image 
        { 
            get; set;
        }
    }
}
