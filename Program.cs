using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            string login, password;
            login = "cb121502";
            password = "sazer1993";

            Console.WriteLine("Veillez renseigner votre identifiant :");
            string inputtedlogin = Console.ReadLine();
            Console.WriteLine("Veillez renseigner votre mot de passe :");
            string inputtedpassword = Console.ReadLine();
            if ((login == inputtedlogin) && (password == inputtedpassword))
                Console.WriteLine("Bienvenue à la Manu le Havre.");
            else
                Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
        }
    }
}
