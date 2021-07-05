using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitaminDeposu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //gerekli değişkenler
        int time = 60;
        double vitaminA = 0;
        double vitaminC = 0;
        double toplamSivi = 0;
        double toplamPure = 0;



        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop(); //programa giriş yapıldığında süre durdurulur

            NarenciyeButonu.Enabled = false;

            KatiButonu.Enabled = false;

            nSikButonu.Enabled = false;
            kSikButonu.Enabled = false;


            SayacLabeli.Text = time.ToString();
            
            ToplamPureLabeli.Text = toplamPure.ToString();
            ToplamSiviLabeli.Text = toplamSivi.ToString();

        }






        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Çıkışa basınca program kapanır.
        }

        List<IMeyve> meyveler = new List<IMeyve>()  //IMeyve arayüzüyle oluşturulmuş meyve listesi
        {
            new Portakal(),
            new Mandalina(),
            new Greyfurt(),
            new Elma(),
            new Armut(),
            new Cilek(),
            

        };


        private void YeniOyunButonu_Click_1(object sender, EventArgs e)
        {
            Narenciyelistbox.Items.Clear(); //Yeni oyun butonuna basılınca önceki kısımından kalanlar değerler silinir.

            Katılistbox.Items.Clear();




            vitaminA = 0;
            ToplamVitaminaLabeli.Text = vitaminA.ToString();

            vitaminC = 0;
            ToplamVitamincLabeli.Text = vitaminC.ToString();

            toplamSivi = 0;
            ToplamSiviLabeli.Text = toplamSivi.ToString();

            toplamPure = 0;
            ToplamPureLabeli.Text = toplamPure.ToString();


            time = 60; //Süre 60sn olarak ayarlandı.

            timer1.Start();



            var rand = new Random();
            Resimler.Image = meyveler[rand.Next(0, 6)].Image;

            SayacLabeli.BackColor = System.Drawing.Color.Turquoise; //Sayaç arkaplan rengi değişir.
          

            NarenciyeButonu.Enabled = true;  // narenciye ve katı meyveler için işlem yapma ve sıkma butonları aktivite oldu

            KatiButonu.Enabled = true;

            nSikButonu.Enabled = true;
            kSikButonu.Enabled = true;

        }

        private void NarenciyeButonu_Click_1(object sender, EventArgs e)   //narenciye seçilirse olacaklar
        {
            var rand = new Random();


            if (Resimler.Image == meyveler[0].Image) //Ekrandaki resim portakal ise 
            {
                
                Narenciyelistbox.Items.Add("Portakal sıkılacak. ");
              


                
            }
            else if (Resimler.Image == meyveler[1].Image)//Ekrandaki resim mandalina ise
            {


                Narenciyelistbox.Items.Add("Mandalina sıkılacak. ");

            }
            else if (Resimler.Image == meyveler[2].Image)//Ekrandaki resim greyfurt ise
            {
                
                Narenciyelistbox.Items.Add("Greyfurt sıkılacak. ");
            

            }
        }

        private void KatiButonu_Click(object sender, EventArgs e) //katı meyve seçilirse
        {
            


            if (Resimler.Image == meyveler[3].Image)//Ekrandaki resim elma ise
            {

                Katılistbox.Items.Add("Elma sıkılacak.");


            }

            else if (Resimler.Image == meyveler[4].Image)//Ekrandaki resim armut ise
            {
               
                Katılistbox.Items.Add("Armut sıkılacak.");
       


            }

            else if (Resimler.Image == meyveler[5].Image)//Ekrandaki resim çilek ise
            {
             
                Katılistbox.Items.Add("Çilek sıkılacak. ");
               


               
            }
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time >= 0) // süre 0 oluncaya kadar azalır
            {
                timer1.Interval = 1000;
                int sayac = time--;
                SayacLabeli.Text = sayac.ToString();
                YeniOyunButonu.Enabled = false; //Süre bitmeden yeni oyun başlatılamaz.
            }
            else
            {
                //Süre 0 iken sadece yeni oyun butonuna basılabilir.
                YeniOyunButonu.Enabled = true;
                NarenciyeButonu.Enabled = false;

                KatiButonu.Enabled = false;

                nSikButonu.Enabled = false;
                kSikButonu.Enabled = false;

                timer1.Stop();
            }
        }

        private void nSikButonu_Click(object sender, EventArgs e)  //narenciye sıkmak için
        {
            if (Resimler.Image == meyveler[0].Image) //Ekrandaki resim portakal ise 
            {


                vitaminA = vitaminA + meyveler[0].VitaminA;         //vitamin a değeri hesaplanır ve yazdırılır
                ToplamVitaminaLabeli.Text = vitaminA.ToString();

                vitaminC = vitaminC + meyveler[0].VitaminC;          //vitamin c değeri hesaplanır ve yazdırılır
                ToplamVitamincLabeli.Text = vitaminC.ToString();

                toplamSivi = toplamSivi + meyveler[0].ToplamSivi;    //toplam sıvı değeri hesaplanır ve yazdırılır
                ToplamSiviLabeli.Text = toplamSivi.ToString();



               
                var rand = new Random();
                Resimler.Image = meyveler[rand.Next(0, 6)].Image;  //yeni resim
            }
            else if (Resimler.Image == meyveler[1].Image)//Ekrandaki resim mandalina ise
            {
                

                vitaminA = vitaminA + meyveler[1].VitaminA;          //vitamin a değeri hesaplanır ve yazdırılır
                ToplamVitaminaLabeli.Text = vitaminA.ToString();

                vitaminC = vitaminC + meyveler[1].VitaminC;          //vitamin c değeri hesaplanır ve yazdırılır
                ToplamVitamincLabeli.Text = vitaminC.ToString();       

                toplamSivi = toplamSivi + meyveler[1].ToplamSivi;   //toplam sıvı değeri hesaplanır ve yazdırılır
                ToplamSiviLabeli.Text = toplamSivi.ToString();

                
                var rand = new Random();
                Resimler.Image = meyveler[rand.Next(0, 6)].Image; //yeni resim

            }
            else if (Resimler.Image == meyveler[2].Image)   //Ekrandaki resim greyfurt ise
            {

                    
                vitaminA = vitaminA + meyveler[2].VitaminA;              //vitamin a değeri hesaplanır ve yazdırılır
                ToplamVitaminaLabeli.Text = vitaminA.ToString();

                vitaminC = vitaminC + meyveler[2].VitaminC;
                ToplamVitamincLabeli.Text = vitaminC.ToString();         //vitamin a değeri hesaplanır ve yazdırılır

                toplamSivi = toplamSivi + meyveler[2].ToplamSivi;
                ToplamSiviLabeli.Text = toplamSivi.ToString();          //toplam sıvı değeri hesaplanır ve yazdırılır


                var rand = new Random();
                Resimler.Image = meyveler[rand.Next(0, 6)].Image; //yeni resim
            }

        }

        private void kSikButonu_Click(object sender, EventArgs e)
        {
            if (Resimler.Image == meyveler[3].Image)//Ekrandaki resim elma ise
            {



                vitaminA = vitaminA + meyveler[3].VitaminA;         //vitamin a değeri hesaplanır ve yazdırılır
                ToplamVitaminaLabeli.Text = vitaminA.ToString();

                vitaminC = vitaminC + meyveler[3].VitaminC;         //vitamin c değeri hesaplanır ve yazdırılır
                ToplamVitamincLabeli.Text = vitaminC.ToString();

                toplamPure = toplamPure + meyveler[3].ToplamPure;     //toplam püre değeri hesaplanır ve yazdırılır
                ToplamPureLabeli.Text = toplamPure.ToString();

               
                var rand = new Random();
                Resimler.Image = meyveler[rand.Next(0, 6)].Image;        //yeni resim
            }

            else if (Resimler.Image == meyveler[4].Image)//Ekrandaki resim armut ise
            {
                    
                vitaminA = vitaminA + meyveler[4].VitaminA;          //vitamin a değeri hesaplanır ve yazdırılır
                ToplamVitaminaLabeli.Text = vitaminA.ToString();

                vitaminC = vitaminC + meyveler[4].VitaminC;
                ToplamVitamincLabeli.Text = vitaminC.ToString();         //vitamin c değeri hesaplanır ve yazdırılır

                toplamPure = toplamPure + meyveler[4].ToplamPure;
                ToplamPureLabeli.Text = toplamPure.ToString();          //toplam püre değeri hesaplanır ve yazdırılır


                var rand = new Random();
                Resimler.Image = meyveler[rand.Next(0, 6)].Image;    //yeni resim
            }

            else if (Resimler.Image == meyveler[5].Image)//Ekrandaki resim çilek ise
            {
                

                vitaminA = vitaminA + meyveler[5].VitaminA;          //vitamin a değeri hesaplanır ve yazdırılır
                ToplamVitaminaLabeli.Text = vitaminA.ToString();

                vitaminC = vitaminC + meyveler[5].VitaminC;
                ToplamVitamincLabeli.Text = vitaminC.ToString();    //vitamin c değeri hesaplanır ve yazdırılır


                toplamPure = toplamPure + meyveler[5].ToplamPure;
                ToplamPureLabeli.Text = toplamPure.ToString();      //toplam püre değeri hesaplanır ve yazdırılır



                var rand = new Random();
                Resimler.Image = meyveler[rand.Next(0, 6)].Image;   //yeni resim
            }
        }

       
    }
}
