using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parti1_tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String utaille;
            String upoids;
            float taille;
            float poids;
            float IMC;

            Console.WriteLine("Quel est votre taille");
            utaille = Console.ReadLine();
            taille = float.Parse(utaille);
            Console.WriteLine("Quel est votre poids");
            upoids = Console.ReadLine();
            poids = float.Parse(upoids);
            IMC = poids / (taille*taille);
            if (IMC < 16.5)
                Console.WriteLine("Dénutrition");
            else if (IMC >= 16.5 && IMC < 18.5)
                Console.WriteLine("Maigreur");
            else if (IMC >= 18.5 && IMC < 25)
                Console.WriteLine("Corpulence normale");
            else if (IMC >= 25 && IMC < 30)
                Console.WriteLine("Surpoids");
            else if (IMC >= 30 && IMC < 35)
                Console.WriteLine("Obésité modérée");
            else if (IMC >= 35 && IMC < 40)
                Console.WriteLine("Obésité sévère");
            else
                Console.WriteLine("Obésité morbide ou massive");

        }
    }
}
