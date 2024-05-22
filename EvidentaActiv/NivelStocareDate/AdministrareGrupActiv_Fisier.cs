using LibrarieModele;
using System.IO;

namespace NivelStocareDate
{
    public class AdministrareGrupActiv_Fisier
    {
        private const int NR_MAX_GRACTIV = 50;
        private GrupActiv[] GrActiv;
        private int nrGrActiv;
        private string numeFisierGrup;

        public AdministrareGrupActiv_Fisier(string numeFisier)
        {
            this.numeFisierGrup = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddGrupActivitati(GrupActiv activ)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisierGrup, true))
            {
                streamWriterFisierText.WriteLine(activ.ConversieLaSir_PentruFisier());
            }
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
