using System;
using System.Collections;
namespace Koleksiyonlar_soru_1{
    class Program{
        public static void Main(string[] args){
            
            ArrayList asal = new ArrayList();
            ArrayList notAsal = new ArrayList();
            bool isNumVal;
            int numbers;
            for(int i = 0;i<4;i++){
            numbers = int.Parse(Console.ReadLine());
            if(numbers < 0 || numbers.GetType().Name !=  "Int32"){
                isNumVal = true;
                while(isNumVal){
                Console.Write("Sadece pozitif ve numerik deger : ");
                    numbers = int.Parse(Console.ReadLine());
                    if(numbers >= 0 || numbers.GetType().Name ==  "Int32"){
                        isNumVal = false;
                    }
                }
            }
            
            else if(numbers >= 0 || numbers.GetType().Name ==  "Int32"){
                bool conT = true; 
                if(numbers == 2 ){
                    asal.Add(numbers);
                    continue;
                }
                else
                {
                    if(numbers == 1){
                        notAsal.Add(numbers);
                        continue;
                    }else{
                        for(int j =2;j<numbers;j++){
                    if(numbers%j == 0){
                        conT = false;
                        break;
                    }
             }
             if(conT){
                asal.Add(numbers);
             }
             else{
                notAsal.Add(numbers);
             }
        }
                    }
                    
                
                }
            }
            int asalTop=0,notAsalTop=0;
            Console.WriteLine("Asal Sayilar : ");
            asal.Sort();
            asal.Reverse();
            foreach(var asalSay in asal){
                asalTop += Convert.ToInt32(asalSay);
                Console.Write(asalSay + " ");
            }

            
            //Console.WriteLine("asal top: " + asalTop);
            Console.WriteLine("Asal Olmayan Sayilar : ");
            notAsal.Sort();
            notAsal.Reverse();
            foreach(var asalSay in notAsal){
                notAsalTop += Convert.ToInt32(asalSay);
                Console.Write(asalSay + " ");
            }

            Console.WriteLine("Asal elemAan sayisi : " + asal.Count);
            Console.WriteLine("Asal olmayan eleman sayisi : " + notAsal.Count);
            
            double asalOrt= 0,notAsOrt=0;

            asalOrt = (double)asalTop/asal.Count;
            notAsOrt = (double)notAsalTop/notAsal.Count;

            Console.WriteLine("Asal ortalama : " + asalOrt);
            Console.WriteLine("Asal olmayan ortalama : " + notAsOrt);
            }
            
        }
     

    }