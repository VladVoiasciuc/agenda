using System;

namespace LibrarieModele
{
    public class GrupActiv
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = '/';
        public string locatie { get; set; }
        public int nrpersoane { get; set; }
        public string culoare { get; set; }
        public TipDeActivitate TipActiv { get; set; } // Actualizare pentru a folosi enumerarea
        public int nrActiv { get; set; }
        public GrupActiv()
        {
            locatie = null;
            nrpersoane = 0;
            culoare = null;
        }

        public GrupActiv(string locatie, int persoane, string culoare, TipDeActivitate tipActiv) // Actualizare pentru a folosi enumerarea
        {
            this.locatie = locatie;
            this.nrpersoane = persoane;
            this.culoare = culoare;
            this.TipActiv = tipActiv; // Actualizare pentru a folosi enumerarea
        }

        public string Info()
        {
            string info = $"Locatie:{locatie} \t Numar de persoane:{nrpersoane} \t Culoare:{culoare} \t Tip de activitate:{TipActiv}"; // Actualizare pentru a folosi enumerarea

            return info;
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectGrupActivPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                nrActiv.ToString(),
                (locatie ?? " NECUNOSCUT "),
                (nrpersoane.ToString() ?? " NECUNOSCUT "),
                (culoare ?? " NECUNOSCUT "),
                (TipActiv.ToString() ?? " NECUNOSCUT ")); // Actualizare pentru a folosi enumerarea

            return obiectGrupActivPentruFisier;
        }
    }
}
