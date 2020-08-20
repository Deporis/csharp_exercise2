using System;
using System.Collections.Generic;

namespace LletresRepetides
{
    class Program
    {
        static char [] nameArray;
        static char [] lastNameArray;
        static void Main(string[] args)
        {
            Fase1();
        }
        static void isProper(char [] nameArray)
        {
            foreach(char letter in nameArray)
            {
                bool verify = Char.IsLetter(letter);
                if(verify != true)
                {
                    Console.WriteLine("Wait, your name must be all letters.The program ends here, try again");
                    return; 
                }
            }
        }
        static void Fase1()
        { 
            Console.WriteLine("Insert your name");
            string name = Console.ReadLine();
            nameArray = name.ToCharArray(0, name.Length); // I think this is the default (0, name.Length)
            isProper(nameArray);
            Console.WriteLine("Do you think I can spell it? (Yes or No)");
            string answer = Console.ReadLine();
            if(answer == "Yes" | answer == "yes")
            {
                Console.WriteLine("\nYou are right, here you have it:");
                //string [] myName = {"a", "l", "f", "r", "e", "d"};
                // El char es solo el espacio en memoria para un caracter,
                // (numero, simbolo, espacio o letra), y el String es un conjunto de caracteres, o un array de char
                foreach(char i in nameArray)
                {
                    Console.WriteLine(i);
                }
                Fase2(nameArray);
            }
            else if(answer == "No" | answer =="no") Console.WriteLine($"\nOk then, your name is {name}");
            else Console.WriteLine("You did not enter a yes or no. The program ends here, try again");
        }
        static void Fase2(char [] myNameArray)
        {
            Console.WriteLine("\nAnd here are your name's characters whether is a vowel or a consonant:");
            List<char> myNameList = new List<char>(myNameArray);
            Dictionary<string, int> repeated = new Dictionary<string, int>();
            foreach(char chara in myNameList)
            {
                string vowel = "aeiou";
                string letter = chara.ToString();
                
                if(vowel.Contains(letter)) Console.WriteLine(letter + " is VOWEL"); // Contains is like "in" in Python
                else Console.WriteLine(letter + " is CONSONANT");
                
                if (repeated.ContainsKey(letter)) repeated[letter] += 1; // we UPDATE SUMMING 1 the lasta value of the key
                else repeated.Add(letter, 1);
            }
            Fase3(repeated);
            //Fase4Array();
            Fase4List(myNameList);
        }
        static void Fase3(Dictionary<string, int> repeated)
        {
            Console.WriteLine("\nYour name has:");
            foreach(KeyValuePair<string, int> repeat in repeated)
            {
                Console.WriteLine(repeat.Value + " " + repeat.Key);
            }
        }
        static void Fase4Array()
        {
            Console.WriteLine("Now insert your last name:");
            string lastName = Console.ReadLine();
            lastNameArray = lastName.ToCharArray();
            isProper(lastNameArray);
            string [] fullName;
            fullName = new string[nameArray.Length + 1 + lastNameArray.Length];
            for(int j = 0; j < nameArray.Length; j++)
            {
                fullName[j] = nameArray[j].ToString();
            }
            fullName[nameArray.Length] = " ";
            for(int i = 0; i < lastNameArray.Length; i++)
            {
                fullName[nameArray.Length + i + 1] = lastNameArray[i].ToString();
            }
            foreach(string k in fullName)
            {
                Console.WriteLine(k);
            }
        }
        static void Fase4List(List<char> myNameList)
        {
            Console.WriteLine("Now insert your last name:");
            string lastName = Console.ReadLine();
            lastNameArray = lastName.ToCharArray();
            isProper(lastNameArray);
            List<char> lastNameList = new List<char>(lastNameArray);
            List<string> fullName = new List<string>();
            foreach(char i in myNameList)
            {
                string a = i.ToString();
                fullName.Add(a);
            }
            fullName.Add(" "); 
            foreach(char j in lastNameList)
            {
                string b = j.ToString();
                fullName.Add(b);
            }
            Console.WriteLine("Here is your full Name");
            foreach(string k in fullName)
            {
                Console.WriteLine(k);
            }
        }
    }
}
