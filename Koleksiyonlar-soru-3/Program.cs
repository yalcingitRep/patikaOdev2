using System;
namespace Koleksiyonlar_soru_3{
    class Program{
        public static void Main(string[] args){
            Console.WriteLine("Cumle yaziniz : ");
            string harfler;
            int count = 0;
            harfler = Console.ReadLine();

            for(int i =0;i<harfler.Length;i++){
                
                if(harfler[i] == 'a' || harfler[i] == 'e' || harfler[i] =='o' || harfler[i]=='ö'|| harfler[i] =='u' || harfler[i]=='i' || harfler[i]=='ü'){
                    count++;
                }

            }
            char[] sesliArray = new char[count];
            int sesliCon = 0;
            for(int i =0;i<harfler.Length;i++){
                
                if(harfler[i] == 'a' || harfler[i] == 'e' || harfler[i] =='o' || harfler[i]=='ö'|| harfler[i] =='u' || harfler[i]=='i' || harfler[i]=='ü'){
                    //Console.WriteLine("neee : " + harfler[i]);
                    sesliArray[sesliCon++] = harfler[i];
                }
                else{
                    continue;
                }

            }

            //Array.Sort(sesliArray);
            Console.WriteLine("sesli dizi : ");

            foreach(var sesli in sesliArray){
                Console.Write(sesli);
            }
        }
    }
}