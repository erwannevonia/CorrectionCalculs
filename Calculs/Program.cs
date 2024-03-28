/**
 * Application "Calculs" v01 (b5 a218)
 * author : Emds
 * date : 24/05/2020
 * modified by : Erwann
 * date of modification : 28/03/2024
 */
using System;

namespace Calculs
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse; // saisie de la réponse de l'utilisateur
            int choix; // saisie du choix de l'utilsiateur
            bool correct; // pour le try-catch (correction)

            // boucle sur le menu
            choix = 1;
            while (choix != 0)
            {
                // affiche le menu et saisi le choix
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                correct = false;
                while(!correct)
                {
                    Console.Write("Choix :                          ");
                    // try/catch pour savoir en cas de lettre (Correction)
                    try
                    {
                        choix = int.Parse(Console.ReadLine());
                        if (choix <= 2)
                        {
                            // traitement des choix
                            if (choix != 0)
                            {
                                if (choix == 1)
                                {
                                    // choix de l'addition
                                    val1 = rand.Next(1, 10);
                                    val2 = rand.Next(1, 10);
                                    while (!correct)
                                    {

                                        // saisie de la réponse
                                        Console.Write(val1 + " + " + val2 + " = ");
                                        // try/catch pour savoir en cas de lettre (correction)
                                        try
                                        {
                                            reponse = int.Parse(Console.ReadLine());
                                            // comparaison avec la bonne réponse
                                            solution = val1 + val2;
                                            if (reponse == solution)
                                            {
                                                Console.WriteLine("Bravo !");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                                            }
                                            // pour sortir du while(!correct) en cas d'écriture d'un 1 (correction)
                                            correct = true;
                                        }
                                        catch
                                        {
                                            Console.WriteLine("Veuillez écrire un chiffre !");
                                        }
                                    }

                                }
                                else
                                {
                                    // choix de la multiplication
                                    val1 = rand.Next(1, 10);
                                    val2 = rand.Next(1, 10);
                                    while (!correct)
                                    {
                                        // saisie de la réponse
                                        Console.Write(val1 + " x " + val2 + " = ");
                                        // try/catch pour savoir en cas de lettre (correction)
                                        try
                                        {
                                            reponse = int.Parse(Console.ReadLine());
                                            // comparaison avec la bonne réponse
                                            solution = val1 * val2;
                                            if (reponse == solution)
                                            {
                                                Console.WriteLine("Bravo !");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                                            }
                                            // pour sortir du while(!correct) en cas d'écriture d'un 2 (correction)
                                            correct = true;
                                        }
                                        catch
                                        {
                                            Console.WriteLine("Veuillez écrire un chiffre !");
                                        }
                                        
                                    }
                                }
                            }
                            // pour sortir du while(!correct) en cas d'écriture d'un 0 (correction)
                            correct = true;
                        }
                        else
                        {
                            Console.WriteLine("Veuillez ne pas écrire un nombre supérieur à 2.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Veuillez choisir un nombre !");
                    }
                }
            }
        }
    }
}
