using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaminDeposu
{
   public interface IMeyve  //IMeyve arayüzü oluşturuluyor
    {
        //miktar özelliği

         int Miktar { get; set; }

        //verim özelliği

        int Verim { get; set; }

        //vitamina özelliği

        int VitaminA { get; set; }

        //vitaminc özelliği

        int VitaminC { get; set; }

        //toplamsivi özelliği

        int ToplamSivi { get; set; }

        //toplampure özelliği

        int ToplamPure { get; set; }


        //image özelliği
        System.Drawing.Image Image { get; set; }



    }
}
