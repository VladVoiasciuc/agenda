using LibrarieModele;
using System;
using System.IO;

namespace NivelStocareDate
{
    public class AdministrareActiv_Fisier
    {
        private const int NR_MAX_ACTIV = 50;
        private Activitate[] activ;
        private int nrActiv;
        private string numeFisier;

        public AdministrareActiv_Fisier(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddActiv(Activitate activ)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(activ.ConversieLaSir_PentruFisier());
            }
        }

        public Activitate[] GetActiv(out int nractiv)
        {
            activ = new Activitate[NR_MAX_ACTIV];

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nractiv = 0;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    activ[nractiv++] = new Activitate(linieFisier);
                }
            }
            nrActiv = nractiv;
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
