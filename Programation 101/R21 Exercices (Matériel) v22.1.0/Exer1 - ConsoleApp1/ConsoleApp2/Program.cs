using System;
using Librairie1N6;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO 01A : Instancier un objet de la classe Personne
            Personne X = new Personne("Kurusu", "Ken", "21212130");

            // TODO 01B : Afficher le nom de la personne dans la console
            Console.WriteLine(X.Nom);

            // TODO 01C : Afficher le prénom de la personne dans la console
            Console.WriteLine(X.Prénom);

            // TODO 01D : Afficher le numéro d'assurance sociale de la personne dans la console
            Console.WriteLine(X.Nas);



            // TODO 02A : Instancier un objet de la classe Thermostat à la température 25
            Thermostat Y = new Thermostat(25);

            // TODO 02B : Augmenter la température du Thermostat d'un degré
            Y.AugmenterTemperature();

            // TODO 02C : Afficher la température courante du Thermostat dans la console
            Console.WriteLine(Y.Température);



            // TODO 03A : Instancier un objet de la classe Montre à 12:15:59
            Montre Z = new Montre(12,15,59);

            // TODO 03B : Avancer le temps courant d'une seconde en utilisant la méthode appropriée
            Z.AvancerUneSeconde();

            // TODO 03C : Afficher le temps courant de la montre dans la console
            Console.WriteLine(Z.TempsCourant);


            // TODO 03D : Synchroniser la montre avec l'heure du système en utilisant la méthode AjusterAutomatiquement
            Z.AjusterAutomatiquement();

            // TODO 03E : Afficher le temps courant de la montre dans la console
            Console.WriteLine(Z.TempsCourant);

            while (true) ; // NE PAS MODIFIER
        }
    }
}
