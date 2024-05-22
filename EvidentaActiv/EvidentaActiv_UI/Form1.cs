using LibrarieModele;
using NivelStocareDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidentaActiv_UI
{
    public partial class Form1 : Form
    {
       DateTime date = DateTime.Now.Date;
       public int nrActiv = 0;
        public Form1()
        {
            InitializeComponent();
            DataCurenta.Text = date.ToString("dd/MM/yyyy");
            AfisareGrupActivitati();
            AfisareActivitati();

        }

        private void AfisareGrupActivitati()
        {
            string numeFisierGrup = ConfigurationManager.AppSettings["NumeFisierGrup"];
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = Path.Combine(locatieFisierSolutie, numeFisierGrup);

            try
            {
                AdministrareGrupActiv_Fisier adminActivitati = new AdministrareGrupActiv_Fisier(caleCompletaFisier);
                int nrActivitati = 0;
                GrupActiv[] activitati = adminActivitati.GetGrupActiv(out nrActivitati);

                listBoxGrActiv.Items.Clear();

                for (int i = 0; i < nrActivitati; i++)
                {
                    listBoxGrActiv.Items.Add($"{i + 1}: {activitati[i].Info()}");
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citirea fișierului: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AfisareActivitati()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = Path.Combine(locatieFisierSolutie, numeFisier);
            
            try
            {
                AdministrareActiv_Fisier adminActivitati = new AdministrareActiv_Fisier(caleCompletaFisier);
                int nrActivitati = 0;
                Activitate[] activitati = adminActivitati.GetActiv(out nrActivitati);

                dataGridActiv.DataSource = activitati;
                dataGridActiv.Columns["nrActiv"].Visible = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citirea fișierului: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AdaugActiv w = new AdaugActiv();
            this.Hide();
            w.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AfisareActivitati();
            AfisareGrupActivitati();
        }

        /*private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridActiv.SelectedRows.Count > 0)
            {
                // Obțineți indexul rândului selectat
                int selectedIndex = dataGridActiv.SelectedRows[0].Index;

                // Obțineți ID-ul activității din celulă
                string activitateId = dataGridActiv.Rows[selectedIndex].Cells["IdActivitate"].Value.ToString();

                // Ștergeți activitatea din fișier folosind ID-ul
                StergeActivitateDinFisier(activitateId);

                // Reîncărcați datele în DataGridView pentru a reflecta modificările
                AfisareActivitati();
            }
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridActiv.SelectedRows.Count > 0)
            {
                // Afișați numele tuturor coloanelor în consolă pentru a verifica denumirile
                foreach (DataGridViewColumn column in dataGridActiv.Columns)
                {
                    Console.WriteLine(column.Name);
                }

                // Obțineți indexul rândului selectat
                int selectedIndex = dataGridActiv.SelectedRows[0].Index;

                // Verificați numele coloanei care conține ID-ul activității
                string activitateId = dataGridActiv.Rows[selectedIndex].Cells["nrActiv"].Value.ToString();

                // Ștergeți activitatea din fișier folosind ID-ul
                StergeActivitateDinFisier(activitateId);

                // Reîncărcați datele în DataGridView pentru a reflecta modificările
                AfisareActivitati();
            }
        }

        private void StergeActivitateDinFisier(string activitateId)
        {
            try
            {
                // Obțineți calea către fișierul în care sunt stocate activitățile
                string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
                string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                string caleCompletaFisier = Path.Combine(locatieFisierSolutie, numeFisier);

                // Citirea tuturor liniilor din fișier
                string[] linii = File.ReadAllLines(caleCompletaFisier);

                // Crearea unei liste de linii care nu conțin activitatea de șters
                List<string> liniiActualizate = new List<string>();
                foreach (string linie in linii)
                {
                    // Verificăm dacă linia conține ID-ul activității de șters
                    if (!linie.Contains(activitateId))
                    {
                        // Dacă nu conține ID-ul, adăugăm linia în lista actualizată
                        liniiActualizate.Add(linie);
                    }
                }

                // Suprascriem fișierul cu linii actualizate
                File.WriteAllLines(caleCompletaFisier, liniiActualizate);
            }
            catch (Exception ex)
            {
                // În caz de eroare, afișăm un mesaj utilizatorului sau logăm eroarea
                MessageBox.Show($"A apărut o eroare la ștergerea activității: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdaugGrActiv w = new AdaugGrActiv(this);
            this.Hide();
            w.Show();
        }
    }
}
