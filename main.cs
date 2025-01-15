using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {//bu kod kısaca tekrarlı tanımlamayı engelliyor
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();
            Singleton singleton3 = Singleton.GetInstance();
            //bir tanıma birden fazla defa çağırıyor ve bu çağırmalardan sonra eylemi sadece 1 defa gerçekleştiriyor
            Console.ReadKey();
        }
        class Singleton
        {
            private static Singleton instance;
            private  Singleton()
            {
                Console.WriteLine("İnstance oluşturulmuştur ");
                //tanımın yapacak olduğu eylem
            }
            public static Singleton GetInstance()
            {
                if (instance == null) 
                { 
                instance = new Singleton();
                    //eğer instance tanımında değer yoksa ona değer atar
                }
                return instance;
                //değeri ekrana yazdırır
            }
        
        }
    }
}
