using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRPG_Single
{
    public class AllHeros : Motor
    {
        public AllHeros()
        {
            id = 0;
            arma1 = 0;
            arma2 = 0;
            ///HEROS
            personaje[0] = "Elf";
            personaje[1] = "Wizard";
            personaje[2] = "Warrior";

            ///ELF WEAPONS
            armasElf[0] = "Bow and arrows";
            armasElf[1] = "Daggers";
            armasElf[2] = "Autmatic Crossbow";
            armasElf[3] = "Necromantyc";

            ///WIZARD WEAPONS
            armasWiz[0] = "Wand";
            armasWiz[1] = "Spell";
            armasWiz[2] = "Magic Spear";
            armasWiz[3] = "Lighting Sword";

            ///WARRIOR WEAPONS
            armasWar[0] = "Sword";
            armasWar[1] = "Maze";
            armasWar[2] = "War Hammer";
            armasWar[3] = "Heavy Axe";

            seleccion = false;

        }
        public int id { get; set; }

        public string[] personaje = new string[4];
        public bool seleccion { get; set; }
        public string[] armasElf = new string[4];
        public string[] armasWiz = new string[4];
        public string[] armasWar = new string[4];
        public static bool salir = false;
        int wpn1, wpn2;


        public int arma1
        {
            get { return wpn1; }
            set { wpn1 = value; }
        }
        public int arma2
        {
            get { return wpn2; }
            set { wpn2 = value; }
        }

        /// <summary>
        /// ELEGIR PERSONAJE!!
        /// </summary>
        /// <returns></returns>
        public string ElegirHeroe()
        {
            int opc = 0;
            string person;
            Console.WriteLine("Select your hero!!");
            Console.WriteLine();
            for (int i = 0; i < personaje.Length; i++)
            {
                int num = i + 1;
                Console.WriteLine(num + ".- " + personaje[i]);
            }
            Console.WriteLine();
            opc = Int32.Parse(Console.ReadLine());
            person = personaje[opc - 1];
            ElegirArma(person);
            return person;
        }
        /// <summary>
        /// ELEGIR ARMA
        /// </summary>
        public string ElegirArma(string per)
        {

            Console.WriteLine();
            Console.WriteLine("It's danger to go alone, take this: ");
            Console.WriteLine();
            Console.WriteLine("Your " + per + "'s weapons are: ");
            Console.WriteLine();

            string ar1 = "";
            string ar2 = "";

            switch (per)
            {
                case "Elf":
                    for (int i = 0; i < armasElf.Length; i++)
                    {
                        int num = i + 1;
                        Console.WriteLine(num + ".- " + armasElf[i]);
                    }
                    Console.WriteLine("Weapon 1: ");
                    arma1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Weapon 2: ");
                    arma2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine();
                    ar1 = armasElf[arma1 - 1];
                    ar2 = armasElf[arma2 - 1];
                    this.seleccion = true;
                    break;

                case "Wizard":
                    for (int i = 0; i < armasWiz.Length; i++)
                    {
                        int num = i + 1;
                        Console.WriteLine(num + ".- " + armasWiz[i]);
                    }
                    Console.WriteLine("Weapon 1: ");
                    arma1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Weapon 2: ");
                    arma2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine();
                    ar1 = armasWiz[arma1 - 1];
                    ar2 = armasWiz[arma2 - 1];
                    this.seleccion = true;
                    break;

                case "Warrior":
                    for (int i = 0; i < armasWar.Length; i++)
                    {
                        int num = i + 1;
                        Console.WriteLine(num + ".- " + armasWar[i]);
                    }
                    Console.WriteLine("Weapon 1: ");
                    arma1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Weapon 2: ");
                    arma2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine();
                    ar1 = armasWar[arma1 - 1];
                    ar2 = armasWar[arma2 - 1];
                    this.seleccion = true;
                    break;
                case "Exit":
                    ElegirHeroe();
                    break;
            }

            Atacar(ar1, ar2,per);

            return per;
        }
        public void Atacar(string arm1, string arm2,string pers)
        {
            Console.WriteLine("ATTACK!!");
            while (!salir)
            {
                Console.WriteLine("Choose your attack!:");
                Console.WriteLine("1.- Normal attack whit " + arm1);
                Console.WriteLine("2.- Special attack whit " + arm2 + "!!");
                Console.WriteLine("3.- Exit");
                Console.WriteLine();
                int opc = Int32.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("The " + pers + " has killed the enemy whit " + arm1);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("The " + pers + " has massacred the enemy using " + arm2);
                        Console.WriteLine();
                        break;
                    case 3:
                        ElegirHeroe();
                        break;
                }
            }
        }
    }
}
