using LibrarieModele;
using System;

namespace NivelStocareDate
{
    internal class AdministrareActiv_Memorie
    {
        private const int NR_MAX_ACTIV = 50;

        private Activitate[] activ;
        private int nrActiv;

        public AdministrareActiv_Memorie()
        {
            activ = new Activitate[NR_MAX_ACTIV];
            nrActiv = 0;
        }

        public void AddActivitati(Activitate activ)
        {
            this.activ[nrActiv] = activ;
            nrActiv++;
        }

        public Activitate[] GetActiv(out int nractiv)
        {
            nractiv = this.nrActiv;
            return activ;
        }

        public Activitate GetActiv(int ora)
        {
            for (int i = 0; i < nrActiv; i++)
            {
                if (activ[i].Ora == ora)
                    return activ[i];
            }
            return null;
        }
    }
}
