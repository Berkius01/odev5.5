using System;
using System.Collections.Generic;
using System.Text;

namespace ödev5._5
{
    class KampanyaManager : Interface
    {
        public void Add(Register reg)
        {
            reg.indirim = "indirim";
            Console.WriteLine(reg.Ad + " isimli kullanıcı için " + reg.indirim + " kampanyası yapıldı");

        }
        public void Update(Register reg)
        {
            string kname = reg.Ad;
            reg.indirim = "indirim2";
            Console.WriteLine(kname + " isimli kampanya " + reg.indirim + " isimli kampanya olarak değiştirldi");
        }

        public void Delete(Register reg)
        {
            reg.indirim = null;
            Console.WriteLine(reg.indirim + " isimli indirim " + reg.Ad + " isimli kullanıcıdan silindi");
        }
    }
}
