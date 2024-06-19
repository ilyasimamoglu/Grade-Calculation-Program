using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculation_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //20 kişilik bir sınıfta her öğrencini adı ve notu girelcek.
            //sınıf ortalması hesaplancaktır ortalmanın altında notu olan öğrence KALMIŞ,
            // eşit ve üzerei olan öğrenci geçmiştir 
            // her öğrencini adını ve geçme durmunu yapcak bir console.app 
            
            
           Names bubi = new Names();
            bubi.isimler();
            bubi.puanlar();


            Console.ReadLine();
        }
    }
}
