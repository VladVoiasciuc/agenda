using LibrarieModele;
using Microsoft.VisualBasic;
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
    public partial class AdaugActiv : Form
    {
        public AdaugActiv()
        {
            InitializeComponent();
            cmbTipActiv.DataSource = Enum.GetValues(typeof(TipDeActivitate));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string an = txtAn.Text;
            string luna = cmbLuna.SelectedItem?.ToString();
            string zi = cmbZi.SelectedItem?.ToString();
            string ora = txtOra.Text;
            string min = txtMin.Text;
            string tipActiv = cmbTipActiv.SelectedItem?.ToString();
            string activ = Interaction.InputBox("Introduceți activitatea:", "Introducere activitate", "Nedeterminat");

            // validare introducere corecta a datelor
            if (string.IsNullOrWhiteSpace(an) || !int.TryParse(an, out int anInt) || anInt < DateTime.MinValue.Year || anInt > DateTime.MaxValue.Year)
            {
                ShowError(lblAn, "Anul introdus nu este valid. Introduceți un an valid.");
                return;
            }

            if (string.IsNullOrWhiteSpace(luna) || !int.TryParse(luna, out int lunaInt) || lunaInt < 1 || lunaInt > 12)
            {
                ShowError(lblLuna, "Luna introdusă nu este validă. Introduceți o lună validă (1-12).");
                return;
            }

            int maxZi = DateTime.DaysInMonth(anInt, lunaInt);
            if (string.IsNullOrWhiteSpace(zi) || !int.TryParse(zi, out int ziInt) || ziInt < 1 || ziInt > maxZi)
            {
                ShowError(lblZi, $"Ziua introdusă nu este validă pentru luna curentă. Introduceți o zi validă (1-{maxZi}).");
                return;
            }

            if (string.IsNullOrWhiteSpace(ora) || !int.TryParse(ora, out int oraInt) || oraInt < 0 || oraInt > 23)
            {
                ShowError(lblOra, "Ora introdusă nu este validă. Introduceți o oră validă (0-23).");
                return;
            }

            if (string.IsNullOrWhiteSpace(min) || !int.TryParse(min, out int minInt) || minInt < 0 || minInt > 59)
            {
                ShowError(lblMin, "Minutul introdus nu este valid. Introduceți un minut valid (0-59).");
                return;
            }

            if (cmbTipActiv.SelectedIndex == -1)
            {
                MessageBox.Show("Selectați un tip de activitate.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Adăugare activitate în fișier
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = Path.Combine(locatieFisierSolutie, numeFisier);

            AdministrareActiv_Fisier adminActivitati = new AdministrareActiv_Fisier(caleCompletaFisier);
            TipDeActivitate tipActivitate = (TipDeActivitate)cmbTipActiv.SelectedItem;
            Activitate activitate = new Activitate(anInt, lunaInt, ziInt, oraInt, minInt, (TipDeActivitate)cmbTipActiv.SelectedItem, activ); // Conversia corectă a tipului de activitate
            adminActivitati.AddActiv(activitate);

            MessageBox.Show("Activitatea a fost adăugată cu succes în fișier!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearErrors();
            Form1 w = new Form1();
            this.Visible = false;
            w.Show();
        }
        private void ClearErrors()
        {
            lblAn.ForeColor = System.Drawing.SystemColors.ControlText; // Resetare culoare text la implicit
            lblLuna.ForeColor = System.Drawing.SystemColors.ControlText;
            lblZi.ForeColor = System.Drawing.SystemColors.ControlText;
            lblOra.ForeColor = System.Drawing.SystemColors.ControlText;
            lblMin.ForeColor = System.Drawing.SystemColors.ControlText;
        }
        private void ShowError(Label label, string message)
        {
            label.ForeColor = System.Drawing.Color.Red; // Schimbare culoare text în roșu
            MessageBox.Show(message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
