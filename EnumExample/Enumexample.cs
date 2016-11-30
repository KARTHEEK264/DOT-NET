using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enumexample
{
    class Program
	{
	public enum Animals
        {
            Lion = 1,
            Tiger = 2,
            Peacock = 3,
            Leopard = 4,
            Elephant = 5,
            EmuBird = 6
        }

        static void Main(string[] args)
        {

            Animals animalNames = (Animals)5;

            Console.WriteLine(animalNames);
            Console.WriteLine((int)animalNames);

            if (animalNames == Animals.Tiger)
            {
                Console.WriteLine("Tiger");
            }

            if (animalNames == Animals.Leopard)
            {
                Console.WriteLine("Leopard");
            }


           
        }
    }
}