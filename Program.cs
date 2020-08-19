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
                
                Fase2(myName);

            }
            else if(answer == "No" | answer =="no") Console.WriteLine($"\nOk then, your name is {name}");
            else Console.WriteLine("You did not enter a yes or no. The program ends here, try again");
        }
        static void Fase2(char [] myName)
        {
            Console.WriteLine("\nAnd here are your name's characters whether is a vowel or a consonant:");
            List<char> theName = new List<char>(myName);
            
            Dictionary<string, int> repeated = new Dictionary<string, int>();

            foreach(char chara in theName)
            {
                string vowel = "aeiou";
                string letter = chara.ToString();
                
                if(vowel.Contains(letter)) Console.WriteLine(letter + " is VOWEL"); // Contains is like "in" in Python
                else Console.WriteLine(letter + " is CONSONANT");
                
                if (repeated.ContainsKey(letter)) repeated[letter] += 1; // we UPDATE SUMMING 1 the lasta value of the key
                else repeated.Add(letter, 1);
            }
            Fase3(repeated);
        }
        static void Fase3(Dictionary<string, int> repeated)
        {
            Console.WriteLine("\nYour name has:");
            foreach(KeyValuePair<string, int> repeat in repeated)
            {
                Console.WriteLine(repeat.Value + " " + repeat.Key);
            }
        }
        
    }
}
