using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0731712
{
    class Program
    {
        
        string a;
        static void Main(string[] args)
        {
            Program a = new Program();
            a.MyFunctionA("Ada Lovelace wrote the first algorithm designed for procession by an Analytical Engine");
        }

        public void MyFunctionA(string iutput)
        {
           
            string[] words = iutput.Split(' ');
            string b;
            
            int wordArrayLength = words.Length;
            int x = 0;
            foreach(var word in words)
            {
                
                foreach(var word2 in words)
                {
                    if(word2.Length > word.Length)
                    {
                        a = word2;
                        
                    }
                }
            }
            Console.WriteLine("Longest word in string is:  " + a);
            Console.ReadLine();
            
        }
    }
}