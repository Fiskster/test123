using System;
using System.IO;

namespace test123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tja hangmantime");
            
            File.WriteAllText("hangman.txt","tja huremer");
            File.WriteAllText("svar.txt","tja, det är bra");
            string s = File.ReadAllText("hangman.txt");
            System.Console.WriteLine("micke sa " + s);
        
            string b = File.ReadAllText("svar.txt");
            System.Console.WriteLine("du svarade " + b);

            System.Console.WriteLine(":)");



            Console.ReadLine();
        }
    }
}
