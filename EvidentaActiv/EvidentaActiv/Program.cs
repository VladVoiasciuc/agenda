using System;
using System.IO;
using LibrarieModele;
using NivelStocareDate;
using System.Configuration;

namespace EvidentaActiv
{
    internal class Program
    {
        static void Main()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = Path.Combine(locatieFisierSolutie, numeFisier);
            AdministrareActiv_Fisier adminActivitati = new AdministrareActiv_Fisier("Activitati.txt");
            AdministrareGrupActiv_Memorie admin = new AdministrareGrupActiv_Memorie();
            Activitate activNoua = new Activitate();
            GrupActiv gractivNoua = new GrupActiv();
            int nrActiv = 0;
            int nrGrActiv = 0;
            adminActivitati.GetActiv(out nrActiv);
            string optiune;
            do
            {
                PrintOptions();

                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();

                switch (optiune.ToUpper())
                {
                    case "C":
                        activNoua = AdaugaActiv();
                        break;
                    case "I":
                        AfisareActiv(activNoua);
                        break;
                    case "A":
                        Activitate[] Activ = adminActivitati.GetActiv(out nrActiv);
                        AfisareActiv(Activ, nrActiv);
                        break;
                    case "S":
                        int S = ++nrActiv;
                        activNoua.nrActiv = S;
                        adminActivitati.AddActiv(activNoua);
                        break;
                    case "G":
                        int S1 = ++nrGrActiv;
                        gractivNoua.nrActiv = S1;
                        admin.AddGrupActivitati(gractivNoua);

                        GrupActiv[] gr = admin.GetGrupActiv(out nrGrActiv);
                        AfisareGrActiv(gr, nrGrActiv);
                        break;
                    case "CA":
                        Console.WriteLine("Introduceti ora:");
                        int ora;
                        while (!int.TryParse(Console.ReadLine(), out ora) || ora < 0 || ora > 23)
                        {
                            Console.WriteLine("Introduceti o ora valida (0-23):");
                        }
                        var activitateCautata = adminActivitati.GetActiv(ora);
                        if (activitateCautata != null)
                            Console.WriteLine(activitateCautata.ToString());
                        else
                            Console.WriteLine("NU EXISTA");
                        break;
                    case "CIG":
                        gractivNoua = AdaugaGrActiv();
                        break;
                    case "O":
                        Activitate[] ac = adminActivitati.GetActiv(out nrActiv);
                        SortareSiAfisareTipActivitate(ac, nrActiv);
                        break;
                    case "CC":
                        string culoare;
                        do
                        {
                            Console.WriteLine("Introduceti culoare (rosu, albastru, verde, galben):");
                            culoare = Console.ReadLine().ToLower();
                        } while (culoare != "rosu" && culoare != "albastru" && culoare != "verde" && culoare != "galben");
                        var grupActivCautat = admin.GetGrupActiv(culoare);
                        if (grupActivCautat != null)
                            Console.WriteLine(grupActivCautat.Info());
                        else
                            Console.WriteLine("NU EXISTA");
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }

        static void PrintOptions()
        {
            Console.WriteLine('\n');
            Console.WriteLine("Alegeti operatiunea dorita:");
            Console.WriteLine("C. Citire activitate ");
            Console.WriteLine("I. Afiseaza informatiei ultimei activitati introduse");
            Console.WriteLine("A. Afisare activitati din fisier");
            Console.WriteLine("CA. Cauta activitate");
            Console.WriteLine("S. Salvare in fisier");
            Console.WriteLine("CIG. Citire activitate de grup");
            Console.WriteLine("G. Afisare activitati de grup");
            Console.WriteLine("CC. Cauta activitatea de grup dupa culoare");
            Console.WriteLine("X. Iesire");
            Console.WriteLine('\n');
        }

        public static Activitate AdaugaActiv()
        {
            Console.WriteLine("Introduceti Anul:");
            int an;
            while (!int.TryParse(Console.ReadLine(), out an) || an < DateTime.MinValue.Year || an > DateTime.MaxValue.Year)
            {
                Console.WriteLine("Anul introdus nu este valid. Introduceti un an valid:");
            }

            Console.WriteLine("Introduceti Luna:");
            int luna;
            while (!int.TryParse(Console.ReadLine(), out luna) || luna < 1 || luna > 12)
            {
                Console.WriteLine("Luna introdusa nu este valida. Introduceti o luna valida (1-12):");
            }

            int maxZi = DateTime.DaysInMonth(an, luna);
            Console.WriteLine("Introduceti Ziua:");
            int zi;
            while (!int.TryParse(Console.ReadLine(), out zi) || zi < 1 || zi > maxZi)
            {
                Console.WriteLine($"Ziua introdusa nu este valida pentru luna curenta. Introduceti o zi valida (1-{maxZi}):");
            }

            Console.WriteLine("Introduceti Ora:");
            int ora;
            while (!int.TryParse(Console.ReadLine(), out ora) || ora < 0 || ora > 23)
            {
                Console.WriteLine("Ora introdusa nu este valida. Introduceti o ora valida (0-23):");
            }

            Console.WriteLine("Introduceti Minutul:");
            int min;
            while (!int.TryParse(Console.ReadLine(), out min) || min < 0 || min > 59)
            {
                Console.WriteLine("Minutul introdus nu este valid. Introduceti un minut valid (0-59):");
            }

            Console.WriteLine("Introduceti tipul de activitate (1 - SPORTIVA, 2 - PROFESIONALA, 3 - CULTURALA):");
            TipDeActivitate tipActiv;
            while (!Enum.TryParse(Console.ReadLine(), out tipActiv))
            {
                Console.WriteLine("Tipul introdus nu este valid. Introduceti un tip valid (1 - SPORTIVA, 2 - PROFESIONALA, 3 - CULTURALA):");
            }

            Console.WriteLine("Introduceti Activitatea: ");
            string act = Console.ReadLine();

            return new Activitate(an, luna, zi, ora, min, tipActiv, act);
        }


        public static GrupActiv AdaugaGrActiv()
        {
            Console.WriteLine("Introduceti locatie:");
            string locatie = Console.ReadLine();

            Console.WriteLine("Introduceti numarul de persoane:");
            int nrPersoane;
            while (!int.TryParse(Console.ReadLine(), out nrPersoane) || nrPersoane < 0)
            {
                Console.WriteLine("Numarul de persoane introdus nu este valid. Introduceti un numar valid:");
            }

            Console.WriteLine("Introduceti culoare:");
            string culoare = Console.ReadLine();

            Console.WriteLine("Introduceti tipul de activitate (1 - SPORTIVA, 2 - PROFESIONALA, 3 - CULTURALA):");
            TipDeActivitate tipActiv;
            while (!Enum.TryParse(Console.ReadLine(), out tipActiv))
            {
                Console.WriteLine("Tipul introdus nu este valid. Introduceti un tip valid (1 - SPORTIVA, 2 - PROFESIONALA, 3 - CULTURALA):");
            }

            return new GrupActiv(locatie, nrPersoane, culoare, tipActiv);
        }

        public static void AfisareActiv(Activitate activ)
        {
            if (activ != null)
            {
                Console.WriteLine(activ.ToString());
            }
            else
            {
                Console.WriteLine("Nu exista activitate introdusa!");
            }
        }

        public static void AfisareActiv(Activitate[] activitati, int nrActiv)
        {
            if (nrActiv > 0)
            {
                for (int i = 0; i < nrActiv; i++)
                {
                    Console.WriteLine(activitati[i]);
                }
            }
            else
            {
                Console.WriteLine("Nu exista activitati salvate in fisier!");
            }
        }

        public static void AfisareGrActiv(GrupActiv[] gractiv, int nrGrActiv)
        {
            if (nrGrActiv > 0)
            {
                for (int i = 0; i < nrGrActiv; i++)
                {
                    Console.WriteLine(gractiv[i].Info());
                }
            }
            else
            {
                Console.WriteLine("Nu exista activitati de grup salvate!");
            }
        }

        public static void SortareSiAfisareTipActivitate(Activitate[] activitati, int nrActiv)
        {
            if (nrActiv > 0)
            {
                Array.Sort(activitati, (a1, a2) => a1.TipActiv.CompareTo(a2.TipActiv));
                AfisareActiv(activitati, nrActiv);
            }
            else
            {
                Console.WriteLine("Nu exista activitati salvate in fisier!");
            }
        }
    }
}
