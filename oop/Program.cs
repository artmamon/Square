using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
       class All
    {
        public string a { get; }
        public All(string k)
       {
            a=k;
            
       }
        public void razdel1()
        {
            
        } 
        public void asd()
        {
            Console.WriteLine(a);
            string[] stroki = a.Split(new char[] { ':' });
            for (int i = 0; i < stroki.Length; i++)
            {
                Console.Write();
            }
            Console.WriteLine(stroki[i]);
        }
        
       


    }
    class Text : All
    {
        
    }
    class Images : All
    {

    }
    class Movies : All
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
             All text1 = new All(@"Text:file.txt(6B);Some string content
                                   Image: img.bmp(19MB) 1920х1080
                                   Text:data.txt(12B); Another string
                                   Text:data1.txt(7B); Yet another string
                                   Movie:logan.2017.mkv(19GB); 1920х1080; 2h12m ");
            text1.asd();
            Console.ReadKey();
            
        }
    }
}
