using System;

namespace LibrarieModele
{
    
    public class Activitate
    { 
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = '/';
        private const int NUMAR = 0;
        private const int AN = 1;
        private const int LUNA = 2;
        private const int ZI = 3;
        private const int ORA = 4;
        private const int MIN = 5;
        private const int TIPACTIV = 6;
        private const int ACTIV = 7;
        
        
        public int An { get; set; }
        public int Luna { get; set; }
        public int Zi { get; set; }
        public int Ora { get; set; }
        public int Min { get; set; }
        public TipDeActivitate TipActiv { get; set; }
        public string Activ { get; set; }

        public int nrActiv { get; set; }

        public Activitate(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            this.An = Int32.Parse(dateFisier[AN]);
            this.Luna = Int32.Parse(dateFisier[LUNA]);
            this.Zi = Int32.Parse(dateFisier[ZI]);
            this.Ora = Int32.Parse(dateFisier[ORA]);
            this.Min = Int32.Parse(dateFisier[MIN]);
            this.TipActiv = (TipDeActivitate)Enum.Parse(typeof(TipDeActivitate), dateFisier[TIPACTIV]);
            this.Activ = dateFisier[ACTIV];
        }
        public Activitate(int an, int luna, int zi, int ora, int min, TipDeActivitate tipactivitate, string activ)
        {
            An = an;
            Luna = luna;
            Zi = zi;
            Ora = ora;
            Min = min;
            TipActiv = tipactivitate;
            Activ = activ;
        }
        public Activitate(int an, int luna, int zi, int ora, int min)
        {
            this.An = an;
            this.Luna = luna;
            this.Zi = zi;
            this.Ora = ora;
            this.Min = min;
            this.TipActiv = TipDeActivitate.SPORTIVA; // Setare implicită pentru TipActiv
        }


        public Activitate()
        {
            An = 0;
            Luna = 0;
            Zi = 0;
            Ora = 0;
            Min = 0;
            TipActiv = TipDeActivitate.SPORTIVA; // Valoarea implicită poate fi setată aici
            Activ = null;
        }

        public bool EstePrezent()
        {
            if(DateTime.Now.Year == An && DateTime.Now.Month == Luna && DateTime.Now.Day == Zi)
                return true;
            else 
                return false;
        }

        public override string ToString()
        {
            return $"AN: {An}, Luna: {Luna}, ZI: {Zi}, Ora: {Ora}, Minutul: {Min}, Tip de activitate: {TipActiv}, Activitate: {Activ}";
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectActivitatePentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                nrActiv.ToString(),
                (An.ToString() ?? " NECUNOSCUT "),
                (Luna.ToString() ?? " NECUNOSCUT "),
                (Zi.ToString() ?? " NECUNOSCUT "),
                (Ora.ToString() ?? " NECUNOSCUT "),
                (Min.ToString() ?? " NECUNOSCUT "),
                (TipActiv.ToString() ?? " NECUNOSCUT "),
                (Activ ?? " NECUNOSCUT "),
                (""));

            return obiectActivitatePentruFisier;
        }
    }
}
