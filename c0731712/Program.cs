using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0731712
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine("The longest word is: ");
            a.MyFunctionA("Ada Lovelace wrote the first algorithm designed for procession by an Analytical Engine");
        }

        public MyFunctionA(string iutput)
        {
            //write a c#program to find the longest word in a string.
            string[] words = iutput.Split(' ');
            
            
            int wordArrayLength = words.Length;
            int[]wordsLength = new int[wordArrayLength];
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