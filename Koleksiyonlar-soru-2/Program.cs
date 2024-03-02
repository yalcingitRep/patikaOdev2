using System;
namespace Koleksiyonlar_soru_2{
    class Program{
        public static void Main(string[] args){

            int[] enBuy = new int[3];
            int[] enKuc = new int[3];
            int num;
            int[] sayilar = new int[20];
            int enBuyOrt = 0,enBuySay = 0;
            int enKucOrt = 0,enKucSay = 0;
            int topOrt = 0;
            Console.WriteLine("sayi giriniz : ");

            try{
                for(int i = 0;i<20;i++){
                    num = Convert.ToInt32(Console.ReadLine());
                    if(num.GetType().Name == "Int32"){
                        sayilar[i] = num;
                    }
                    else{
                        Console.WriteLine("Gecerli deger giriniz.");
                        while(num.GetType().Name != "Int32"){
                            num = Convert.ToInt32(Console.ReadLine());
                        }
                        sayilar[i] = num;
                    }
                }
                Array.Sort(sayilar);

                for(int i =0 ; i<3;i++){
                    enKuc[i] = sayilar[i];
                }
                sayilar.Reverse();
                for(int i =0 ; i<3;i++){
                    enBuy[i] = sayilar[i];
                }
                
                foreach(var say in enBuy){
                    enBuySay +=say;
                }

                foreach(var say in enKuc){
                    enKucSay +=say;
                }

                enBuyOrt = enBuySay/enBuy.Length;
                enKucOrt = enKucSay/enKuc.Length;

                Console.WriteLine("En büyük ortalama : " + enBuyOrt);
                Console.WriteLine("En kuc oralama : "+ enKucOrt);

                topOrt = (enBuyOrt + enKucOrt)/20;

                Console.WriteLine("Toplam ortalama : "+ topOrt);
            }catch(Exception ex){
                Console.WriteLine("Sadece sayi giriniz : ");
            }


        }
    }
}