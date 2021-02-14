using System;

namespace ödev5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //kişiyi oluşturma
            Register register = new Register();
            register.Ad = "berk";
            register.Soyad = "sağlıcak";
            register.TcNo = "123456798";
            register.DoğumYılı = "01/01/2000";
            register.Id = 1;
            RegisterManager regManager = new RegisterManager();

            regManager.Add(register);
            regManager.Update(register);
            //sepeti ayarlama
            Store stor = new Store();

            stor.Addsepet(register);
            
            //kampanya ekleme
            KampanyaManager kamp = new KampanyaManager();
            kamp.Add(register);

            stor.Listsepet(register);

            Console.WriteLine("----------------");

            Register register2 = new Register();
            register2.Ad = "kubilay";
            register2.Soyad = "arslan";
            register2.TcNo = "987456312";
            register2.DoğumYılı = "01/01/2000";
            register2.Id = 2;

            RegisterManager regManager2 = new RegisterManager();

            regManager2.Add(register2);
            regManager2.Delete(register2);

            Console.WriteLine("----------------");

            Register register3 = new Register();
            register3.Ad = "ilayda";
            register3.Soyad = "turgut";
            register3.TcNo = "978645252";
            register3.DoğumYılı = "01/01/2000";
            register3.Id = 3;
            RegisterManager regManager3 = new RegisterManager();

            regManager3.Add(register3);
            
            Store stor2 = new Store();

            stor2.Addsepet(register3);
            stor2.Updatesepet(register3);

            KampanyaManager kamp2 = new KampanyaManager();
            kamp2.Add(register3);
            stor2.Listsepet(register3);

            Console.WriteLine("----------------");

            Register register4 = new Register();
            register4.Ad = "ata";
            register4.Soyad = "turkay";
            register4.TcNo = "954845252";
            register4.DoğumYılı = "01/01/2000";
            register4.Id = 4;
            RegisterManager regManager4 = new RegisterManager();
            regManager4.Add(register4);

            Store stor3 = new Store();
            stor3.Addsepet(register4);
            //kampanya değiştirme
            KampanyaManager kampanyaManaher4 = new KampanyaManager();
            kampanyaManaher4.Add(register4);
            kampanyaManaher4.Update(register4);
            stor3.Listsepet(register4);




        }
    }
}
