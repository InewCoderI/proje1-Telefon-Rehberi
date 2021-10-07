using System;
using System.Collections;
using System.Collections.Generic;
namespace class_Dictionary
{
    class Metotlar:Kisiler
    {
        
        Dictionary<int,Kisiler> kisiler = new Dictionary<int, Kisiler>{}; 
        bool deger,deger1,deger2,deger3;
        public Metotlar()
        {
            var kisi = new Kisiler[100];
            
            string[] isimler={"Ali","Ahmet","Cem","Burak","Sevim"};
            string[] soyisimler={"Büyük","Yılmaz","Kaya","Orhan","Kanık"};
            string[] numaralar={"1","2","3","4","5"};
            for (int i = 0; i < 5; i++)
            {
                kisi[i]=new Kisiler();
                kisiler.Add(i,kisi[i]);
                kisi[i].Isim=isimler[i];
                kisi[i].Soyisim=soyisimler[i];
                kisi[i].No=numaralar[i];
            }
            
        }
        public void Numarakaydet(int cnt)
        {
            Console.WriteLine("Yeni Numara Kaydı");
            Console.WriteLine("İsim:");
            string isim=Console.ReadLine();
            Console.WriteLine("Soyisim:");
            string soyisim=Console.ReadLine();
            Console.WriteLine("Numara:");
            string no=Console.ReadLine();
            var kisi = new Kisiler[100];
            
            
            kisi[cnt] = new Kisiler();
            kisiler.Add(cnt,kisi[cnt]);
            kisi[cnt].Isim=isim;
            kisi[cnt].Soyisim=soyisim;
            kisi[cnt].No=no;
                
            
            
            
            
        }

        public void RehberListele()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("*********************");
            foreach (var item in kisiler)
                   {
                       Console.WriteLine("İsim:"+item.Value.Isim);
                       Console.WriteLine("Soyisim:"+item.Value.Soyisim);
                       Console.WriteLine("Telefon Numarası:"+item.Value.No);
                       Console.WriteLine("***********************");
                   }
        }

        public void NumaraSilme()
        {
            string silinecek;
            string secim;
            int secim2;
            
            while(true)
            {
                a:
                Console.WriteLine("Silmek istediğiniz numarayı isim ya da soyisim girerek arayınız.");
                silinecek=Console.ReadLine();
                
                foreach (var item in kisiler)
                {
                    
                    if(item.Value.Isim.Contains(silinecek)||item.Value.Soyisim.Contains(silinecek))
                    {
                        Console.WriteLine("{0} adlı/soyadlı kişi silmek üzere onaylıyor musunuz(y/n)",item.Value.Isim);
                        secim=Console.ReadLine();
                        deger = true;
                        if(secim=="y")
                        {
                            
                            kisiler.Remove(item.Key);
                            Console.WriteLine("Kişi silindi");
                            break;
                        }
                        else if(secim=="n")
                            break;

                    }
                    else 
                        deger=false;
                }
                    if(deger==false)
                    {
                        Console.WriteLine("Rehberde uygun veri bulunamadı.Lütfen bir seçim yapınız.");
                        b:
                        Console.WriteLine("Silmeyi sonlandırmak için (1)");
                        Console.WriteLine("yendiden denemek için (2)");
                        try
                        {
                            secim2=Convert.ToInt32(Console.ReadLine());
                        }
                        catch(FormatException)
                        {
                            Console.WriteLine("Sadece int türünde değer girebilirsiniz.");
                            goto b;
                        }
                        if(secim2==1)
                        {
                            break;
                        }
                        else if(secim2==2)
                        {
                            goto a;
                        }
                        else
                            Console.WriteLine("Geçersiz giriş.....");
                            goto b;
                    }

                
            break;
                    
            }
        }

        public void NumaraGüncelleme()
        {
            string  guncellenecek;
            string yeniisim;
            string yenisoyisim;
            string yeninumara;
            int secim3;
            string secim4;
            while(true)
            {
                a:
                Console.WriteLine("Numarasını güncellemek istediğiniz kişinin adını ya da soyadını yazınız.");
                guncellenecek=Console.ReadLine();

                foreach (var item in kisiler)
                {
                    
                    if(item.Value.Isim.Contains(guncellenecek)||item.Value.Soyisim.Contains(guncellenecek))
                    {
                        Console.WriteLine("{0} adlı/soyadlı kişi güncellemek üzere onaylıyor musunuz(y/n)",item.Value.Isim);
                        secim4=Console.ReadLine();
                        deger1=true;
                        if(secim4=="y")
                        {
                            
                            Console.WriteLine("Yeni isim:");
                            yeniisim=Console.ReadLine();
                            Console.WriteLine("Yeni Soyisim:");
                            yenisoyisim=Console.ReadLine();
                            Console.WriteLine("Yeni Numara");
                            yeninumara=Console.ReadLine();
                            item.Value.Isim=yeniisim;
                            item.Value.Soyisim=yenisoyisim;
                            item.Value.No=yeninumara;
                            Console.WriteLine("Bilgiler güncellendi");
                            break;
                        }
                        else if(secim4=="n")
                            break;
                        

                    }
                    else 
                        deger1=false;
                }
                if(deger1==false)
                {
                    Console.WriteLine("Rehberde uygun veri bulunamadı.Lütfen bir seçim yapınız.");
                    c:
                    Console.WriteLine("Güncellemeyi sonlandırmak için (1)");
                    Console.WriteLine("yendiden denemek için (2)");
                    try{
                        secim3=Convert.ToInt32(Console.ReadLine());
                    }
                    catch(FormatException)
                    {   
                        Console.WriteLine("Sadece int türünde değer girebilirsiniz...");
                        goto c;
                    }
                    
                    if(secim3==1)
                    {
                        break;
                    }
                    else if(secim3==2)
                    {
                        goto a;
                        
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz giriş....");
                        goto c;
                    }
                }
                break;

            }
        }

        public void AramaYapma()
        {
            string aranacak;
            string aranacakno;
            int secim5;
            while(true)
            {

            Console.WriteLine("Arama yapmak istediğiniz tip seçin.");
            Console.WriteLine("**********************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için :(1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için :(2)");
            secim5=Convert.ToInt32(Console.ReadLine());
            if(secim5==1)
            {
                deger2=false;
                Console.WriteLine("Arama yapmak istediğiniz kişinin adını ya da soyadını giriniz:");
                aranacak=Console.ReadLine();
                foreach (var item in kisiler)
                {
                    if(item.Value.Isim.Contains(aranacak)|| item.Value.Soyisim.Contains(aranacak))
                    {
                        deger2=true;
                        Console.WriteLine("Arama Sonuçlarınız");
                        Console.WriteLine("***********************************");
                        Console.WriteLine(item.Value.Isim);
                        Console.WriteLine(item.Value.Soyisim);
                        Console.WriteLine(item.Value.No);
                        break;
                    }
                }
                if(deger2==false)
                {
                    Console.WriteLine("Aradığınız kriterlere uygun veri bulunamadı.");
                    
                }
            }
            else if(secim5==2)
            {
                deger3=false;
                Console.WriteLine("Arama yapmak istediğiniz numarayı giriniz.");
                aranacakno=Console.ReadLine();
                foreach (var item in kisiler)
                {
                    if(item.Value.No.Contains(aranacakno))
                    {
                        deger3=true;
                        Console.WriteLine("Arama Sonuçlarınız");
                        Console.WriteLine("***********************************");
                        Console.WriteLine(item.Value.Isim);
                        Console.WriteLine(item.Value.Soyisim);
                        Console.WriteLine(item.Value.No);
                        break;
                    }             
                }
                if(deger3==false)
                    {
                        Console.WriteLine("Aradığınız veri bulunamadı...");
                    }
            }
            break;
            }


        }
    }
}