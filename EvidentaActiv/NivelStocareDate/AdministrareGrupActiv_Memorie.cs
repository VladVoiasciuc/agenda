using LibrarieModele;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelStocareDate
{
    public class AdministrareGrupActiv_Memorie
    {
        private const int NR_MAX_GRACTIV = 50;

        private GrupActiv[] GrActiv;
        private int nrGrActiv;

        public AdministrareGrupActiv_Memorie()
        {
            GrActiv = new GrupActiv[NR_MAX_GRACTIV];
            nrGrActiv = 0;
        }

        public void AddGrupActivitati(GrupActiv gractiv)
        {
            this.GrActiv[nrGrActiv] = gractiv;
            nrGrActiv++;
        }

        public GrupActiv[] GetGrupActiv(out int nrgractiv)
        {
            nrgractiv = this.nrGrActiv;
            return GrActiv;
        }

        public GrupActiv GetGrupActiv(string culoare)
        {
            for (int i = 0; i < nrGrActiv; i++)
            {
                if (GrActiv[i].culoare == culoare)
                    return GrActiv[i];
            }
            return null;
        }
    }
}
