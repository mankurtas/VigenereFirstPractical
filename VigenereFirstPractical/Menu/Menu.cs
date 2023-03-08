using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VigenereFirstPractical.Entities;

namespace VigenereFirstPractical.Menu
{
    public class Menu
    {
        public Menu()
        {

        }
        public void initiateMenu()
        {
            bool isActive = true;
            while (isActive)
            {
                Console.WriteLine("-----------------------\n");
                Console.WriteLine("1. Encript Text");
                Console.WriteLine("2. Decript Text");
                Console.WriteLine("0. Exit");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Enter text: ");
                        string plainText = Console.ReadLine();
                        Console.WriteLine("Enter Key: ");
                        string key = Console.ReadLine();

                        Encript enc = new Encript(plainText, key);

                        Console.WriteLine("Ecripted text: \n");

                        Console.WriteLine(enc.Encription());
                        break;
                    case "2":
                        Console.WriteLine("Enter Encripted Text: ");
                        string encriptedText = Console.ReadLine();
                        Console.WriteLine("Enter Key: ");
                        string Key = Console.ReadLine();

                        Decript dec = new Decript(encriptedText, Key);

                        Console.WriteLine("Decoded text: \n");

                        Console.WriteLine(dec.DeEncription());

                        break;
                    case "0":
                        isActive = false;
                        break;
                    default:
                        Console.WriteLine("Incorret input");
                        break;
                }
            }
        }
    }
}



