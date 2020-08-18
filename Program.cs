using System;
using System.Collections.Generic;

namespace LletresRepetides
{
    class Program
    {
        static char [] myName;
        static void Main(string[] args)
        {
            Fase1();
        }
        static void Fase1()
        {
            Console.WriteLine("Insert your name");
            string name = Console.ReadLine();
            myName = name.ToCharArray(0, name.Length);
            foreach(char letter in myName)
            {
                bool verify = Char.IsLetter(letter);
                if(verify != true)
                {
                    Console.WriteLine("Wait, your name must be all letters.The program ends here, try again");
                    return; 
                }
            }
            Console.WriteLine("Do you think I can spell it? (Yes or No)");
            string answer = Console.ReadLine();
            if(answer == "Yes" | answer == "yes")
            {
                Console.WriteLine("\nYou are right, here you have it:");
                //string [] myName = {"a", "l", "f", "r", "e", "d"};
                // El char es solo el espacio en memoria para un caracter,
                // (numero, simbolo, espacio o letra), y el String es un conjunto de caracteres, o un array de char
                foreach(char i in myName)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("\nBye");
            }
            else if(answer == "No" | answer =="no") Console.WriteLine($"\nOk then, your name is {name}");
            else Console.WriteLine("You did not enter a yes or no. The program ends here, try again");
            
            Fase2();
        }
        static void Fase2()
        {
            Console.WriteLine("\nHere are your name's characters whether is a vowel or a consonant:");
            List<char> theName = new List<char>(myName);
            foreach(char chara in theName)
            {
                string vowel = "aeiou";
                string letter = chara.ToString();
                if(vowel.Contains(letter)) Console.WriteLine(letter + " is VOWEL"); // Contains is like "in" in Python
                else Console.WriteLine(letter + " is CONSONANT");
            }
        }
    }
}
