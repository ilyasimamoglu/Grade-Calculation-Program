using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculation_Program
{
    internal class Names
    {
       public string[] name = new string[2];
       public int[] point = new int[2];
        


       public void isimler()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter Name ::");
                name[i] = Console.ReadLine();


            }
        }

        public void puanlar() 
        {
            int ort = 0;
            for(int j = 0;j < 2;j++)
            {
                Console.WriteLine("Enter Grade ::");
                point[j] = Convert.ToInt32(Console.ReadLine());
                ort += point[j];
            
             
                

            }
            int tt = ort / 2;
            Console.WriteLine("The Avrage is ::" + tt);
            for (int j = 0; j <= 2; j++)
            {
                if (point[j] >= tt)
                {
                    Console.WriteLine(name[j] + "::pass !!!");
                    Console.WriteLine("The Grade is ::" + point[j]);

                }
                else
                {
                    Console.WriteLine(name[j] + "::faild !!!");
                    Console.WriteLine("The Grade is ::" + point[j]);
                }
            }



        }
    }
}
