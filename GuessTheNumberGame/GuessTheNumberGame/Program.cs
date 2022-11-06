using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace GuessTheNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int numToGuess = 0;
            Console.WriteLine("you're Welcome to guess my year of Birth Game:");
            Console.WriteLine("Must be a Number");
            int.TryParse(Console.ReadLine(), out numToGuess);

            switch (numToGuess)
            {
                case 1999:
                    Console.WriteLine("You're a gwnuis my padawan freind");
                    break;
                case 3:
                    Console.WriteLine("nop handsome/beautiful  thats my day tho pal");
                    break;
                case 6:
                    Console.WriteLine("thats my birth month you brb!");
                    break;
                
                default:
                    Console.WriteLine("you got my birth year wrong dummy");
                    break;
            }
            string[] car = new string[] {
                "Audi",
                "BMW",
                "Mazda",
                "Lexus",
                "Toyota",
                "Range Rover"
            };
            foreach (var item in car)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            var folders = Directory.GetDirectories(@"C:\Users\El_Musty\Downloads");
            foreach (var folder in folders)
            {
                Console.WriteLine(folder);
            }
            Console.ReadLine();*/
            string path = @"C:\Users\El_Musty\Desktop\oregon.txt";
            StreamReader sr = new StreamReader(path);

            string line = sr.ReadToEnd();
            while (line !+ null)

            {
                Console.WriteLine(line);
                break;
            }
            Console.ReadLine();
        }
    }
}
