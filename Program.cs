using System;
using System.Collections;
using System.Collections.Generic;
namespace class_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {   
            int secim=0;
            int cnt=5;
            Metotlar metotlar = new Metotlar();
           
           while(true)
           {

               Console.WriteLine("Numara kaydetmek için 1'e basınız.");
               Console.WriteLine("Numara Silmek için 2'ye basınız.");
               Console.WriteLine("Numara güncellemek için 3'e basınız.");
               Console.WriteLine("Rehberi listelemk için 4'e basınız.");
               Console.WriteLine("Arama yapmak için 5'e basınız.");
                try
                {
                    secim=Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("Sadece int türünde değer girebilirsiniz.");
                }           
                   
               
                

               if(secim==1)
               {
                   metotlar.Numarakaydet(cnt);
                   cnt++;

               }
               else if(secim==2)               
                   metotlar.NumaraSilme();              
               else if(secim==3)              
                   metotlar.NumaraGüncelleme();               
               else if(secim==4)               
                   metotlar.RehberListele();
                else if(secim==5)
                    metotlar.AramaYapma();
                else
                    Console.WriteLine("Geçersiz Giriş......");
               

                
           }

           

               
        }
    }

    
    

}
    

   