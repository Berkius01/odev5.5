using System;
using System.Collections.Generic;
using System.Text;

namespace ödev5._5
{
    class RegisterManager : Interface
    {
        
        public void Add(Register reg)
        {
            
            Console.WriteLine(reg.Ad + " isimli kullanıcı " + reg.Id + " id ile eklendi");
            
        }
        public void Update(Register reg)
        {
            string name = reg.Ad;
            reg.Ad = "çağrı";
            Console.WriteLine(name + " isimli kullanıcı " + reg.Ad + " isimli kullanıcı olarak değiştirildi" 
                );
        }

        public void Delete(Register reg)
        {
            Console.WriteLine(reg.Ad + " isimli kullanıcı " + reg.Id + " id kullanıcı silindi");
        }
    }
}
