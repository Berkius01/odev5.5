using System;
using System.Collections.Generic;
using System.Text;

namespace ödev5._5
{
    class Store
    {
        public void Addsepet(Register reg)
        {
            reg.Oyun = "gta v";
            reg.tutar = 100;
           // reg.indirim = "indirim";
            Console.WriteLine(reg.Oyun + " adlı oyun " + reg.Ad + " sepetine eklendi");
        }
        public void Listsepet(Register reg)
        {
            

            if (reg.indirim == "indirim")
            {
                int price = reg.tutar;
                reg.tutar = reg.tutar - (reg.tutar * 15 / 100);
                Console.WriteLine(reg.Oyun + " adlı oyunun fiyatı " + price + " indirimli tutar " + reg.tutar );
            }
            else if(reg.indirim == "indirim2")
            {
                int price = reg.tutar;
                reg.tutar = reg.tutar - (reg.tutar * 5 / 100);
                Console.WriteLine(reg.Oyun + " adlı oyunun fiyatı " + price + " indirimli tutar " + reg.tutar);
            }
            else
                Console.WriteLine(reg.Oyun + " adlı oyunun fiyatı " + reg.tutar);


        }
        public void Updatesepet(Register reg)
        {
            string oyunName = reg.Oyun;
            reg.Oyun = "csgo";
            reg.tutar = 50;
            Console.WriteLine(oyunName + " adlı oyun " + reg.Oyun + " ile değiştirldi");
        }
    }
}
