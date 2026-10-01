using System.ComponentModel.Design;
using System.Diagnostics;

namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("Je m'appelle Emerick et mon jeu préféré est Minecraft");
        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        Console.WriteLine("Quel est ton prénom ?");
        string prénom = Console.ReadLine() ?? "";
        Console.WriteLine("Quel âge as-tu?");
        int age = Convert.ToInt32(Console.ReadLine());
        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        if (age >= 18)
        {
            Console.WriteLine("Tu es majeur.");
        }
        else
        {
            Console.WriteLine("Tu es mineur.");
        }

        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a
        Console.WriteLine("Combien d'argent as-tu?");
        int argent = Convert.ToInt32(Console.ReadLine());
        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
        string arme1 = ("Couteau");
        string arme2 = ("Épée");
        string arme3 = ("Fusil");
        string arme4 = ("Missile");
        int prix1 = (50);
        int prix2 = (100);
        int prix3 = (150);
        int prix4 = (10000000);
        Console.WriteLine("Voici 4 armes choisis laquelle tu veux acheter.\n" +
            arme1 + " " + prix1 + "\n" +
            arme2 + " " + prix2 + "\n" +
            arme3 + " " + prix3 + "\n" +
            arme4 + " " + prix4 + "\n");
        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
        Console.WriteLine("Choisis en utilisant un chiffre entre 1 et 4");
        int choix = Convert.ToInt32(Console.ReadLine());
        if (choix == 1)
        {
            Console.WriteLine("Tu as choisis le couteau.");
        }
        else if (choix == 2) 

            {
                Console.WriteLine("Tu as choisis l'épée.");
            }
        else  if (choix == 3)
            {
                Console.WriteLine("Tu as choisis le fusil.");
            }
        
        else if (choix == 4)
            {
                Console.WriteLine("tu as choisis le missile.");
            }

        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4
        if (age < 18)
        {
            Console.WriteLine("Tu es trop jeune pour acheter un arme.");
        }
        else if (choix == 1)
            if (argent < prix1)
            {
                Console.WriteLine("Tu n'as pas assez d'argent.");
            }
            else if (argent >= prix1)
            {
                Console.WriteLine("Tu as acheté le couteau.");
                Console.WriteLine("Solde restant :");
                Console.WriteLine(argent - prix1);
            }
        if (choix == 2)
        if (argent < prix2)
            {
                Console.WriteLine("Tu n'as pas assez d'argent.");
            }
        else if (argent >= prix2)
            {
                Console.WriteLine("Tu as acheté l'épée.");
                Console.WriteLine("Solde restant :");
                Console.WriteLine(argent - prix2);
            }
        if (choix == 3)
        if (argent < prix3)
            {
                Console.WriteLine("Tu n'as pas assez d'argent.");
            }
        else if (argent >= prix3)
            {
                Console.WriteLine("Tu as acheté le fusil.");
                Console.WriteLine("Solde restant :");
                Console.WriteLine(argent - prix3);
            }
        if (choix == 4)
        if (argent < prix4)
            {
                Console.WriteLine("Tu n'as pas assez d'argent.");
            }
        else if (argent >= prix4)
            {
                Console.WriteLine("Tu as acheté le missile.");
                Console.WriteLine("Solde restant :");
                Console.WriteLine(argent - prix4);
            }
        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }      
}
  