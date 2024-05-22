using System;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using LibrarieModele;
using NivelStocareDate;
using EvidentaActiv_UI;
using Microsoft.VisualBasic;
using System.Linq;

namespace EvidentaStudenti_UI_WindowsForms
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

   /* public partial class FormularActiv : Form
    { 
        private Label lblAn;
        private TextBox txtAn;
        private Label lblLuna;
        private ComboBox cmbLuna;
        private Label lblZi;
        private ComboBox cmbZi;
        private Label lblOra;
        private TextBox txtOra;
        private Label lblMin;
        private TextBox txtMin;
        private Label lblTipActiv;
        private ComboBox cmbTipActiv;
        private Button btnAdauga;
        private Label lblPerimetru;
        private ListBox listBoxActivitati;
        private Button btnRefresh;
        private DataGridView dataGridViewActivitati;

        public FormularActiv()
        {
            InitializeComponent();
            AfisareActivitati();
        }

        private void InitializeComponent()
        {
            // Initializarea componentelor UI
            this.Size = new System.Drawing.Size(1000, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Adăugare Activitate";
            this.BackColor = System.Drawing.Color.DarkGoldenrod;

            lblAn = new Label();
            lblAn.Text = "An:";
            lblAn.Location = new System.Drawing.Point(10, 10);
            this.Controls.Add(lblAn);

            txtAn = new TextBox();
            txtAn.Location = new System.Drawing.Point(120, 10);
            txtAn.Width = 150;
            this.Controls.Add(txtAn);

            lblLuna = new Label();
            lblLuna.Text = "Luna:";
            lblLuna.Location = new System.Drawing.Point(10, 40);
            this.Controls.Add(lblLuna);

            cmbLuna = new ComboBox();
            cmbLuna.Location = new System.Drawing.Point(120, 40);
            cmbLuna.Width = 150;
            cmbLuna.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLuna.Items.AddRange(Enumerable.Range(1, 12).Select(i => i.ToString()).ToArray()); // Adăugăm valorile lunilor de la 1 la 12
            this.Controls.Add(cmbLuna);

            lblZi = new Label();
            lblZi.Text = "Zi:";
            lblZi.Location = new System.Drawing.Point(10, 70);
            this.Controls.Add(lblZi);

            cmbZi = new ComboBox();
            cmbZi.Location = new System.Drawing.Point(120, 70);
            cmbZi.Width = 150;
            cmbZi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbZi.Items.AddRange(Enumerable.Range(1, 31).Select(i => i.ToString()).ToArray()); // Adăugăm valorile zilelor de la 1 la 31
            this.Controls.Add(cmbZi);

            lblOra = new Label();
            lblOra.Text = "Ora:";
            lblOra.Location = new System.Drawing.Point(10, 100);
            this.Controls.Add(lblOra);

            txtOra = new TextBox();
            txtOra.Location = new System.Drawing.Point(120, 100);
            txtOra.Width = 150;
            this.Controls.Add(txtOra);

            lblMin = new Label();
            lblMin.Text = "Min:";
            lblMin.Location = new System.Drawing.Point(10, 130);
            this.Controls.Add(lblMin);

            txtMin = new TextBox();
            txtMin.Location = new System.Drawing.Point(120, 130);
            txtMin.Width = 150;
            this.Controls.Add(txtMin);

            lblTipActiv = new Label();
            lblTipActiv.Text = "Tip activitate:";
            lblTipActiv.Location = new System.Drawing.Point(10, 160);
            this.Controls.Add(lblTipActiv);

            cmbTipActiv = new ComboBox();
            cmbTipActiv.Location = new System.Drawing.Point(120, 160);
            cmbTipActiv.Width = 150;
            cmbTipActiv.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipActiv.DataSource = Enum.GetValues(typeof(TipDeActivitate));
            this.Controls.Add(cmbTipActiv);

            btnAdauga = new Button();
            btnAdauga.Text = "Adaugă activitate";
            btnAdauga.Location = new System.Drawing.Point(10, 190);
            btnAdauga.Click += BtnAdauga_Click;
            this.Controls.Add(btnAdauga);

            lblPerimetru = new Label();
            lblPerimetru.Text = "";
            lblPerimetru.Location = new System.Drawing.Point(10, 220);
            lblPerimetru.AutoSize = true;
            this.Controls.Add(lblPerimetru);

            listBoxActivitati = new ListBox();
            listBoxActivitati.Width = 600;
            listBoxActivitati.Height = 200;
            listBoxActivitati.Location = new System.Drawing.Point(300, 10);
            this.Controls.Add(listBoxActivitati);

            btnRefresh = new Button();
            btnRefresh.Text = "Reîmprospătare";
            btnRefresh.Location = new System.Drawing.Point(250, 220);
            btnRefresh.Click += BtnRefresh_Click;
            this.Controls.Add(btnRefresh);

            dataGridViewActivitati = new DataGridView();
            dataGridViewActivitati.Width = 600;
            dataGridViewActivitati.Height = 200;
            dataGridViewActivitati.Location = new System.Drawing.Point(10, 250);
            dataGridViewActivitati.AutoGenerateColumns = true; // Va genera automat coloanele din datele furnizate
            this.Controls.Add(dataGridViewActivitati);

            btnAdauga.BackColor = System.Drawing.Color.LightGray; // Schimbarea culorii butonului "Adaugă activitate"
            btnRefresh.BackColor = System.Drawing.Color.LightGray;
            txtAn.BackColor = System.Drawing.Color.LightYellow; // Schimbarea culorii fundalului casetei de text "An"
            txtOra.BackColor = System.Drawing.Color.LightYellow;
            txtMin.BackColor = System.Drawing.Color.LightYellow;
            listBoxActivitati.BackColor = System.Drawing.Color.LightYellow;
            cmbLuna.BackColor = System.Drawing.Color.LightYellow;
            cmbZi.BackColor = System.Drawing.Color.LightYellow;
            cmbTipActiv.BackColor = System.Drawing.Color.Yellow;
        }

        private void AfisareActivitati()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = Path.Combine(locatieFisierSolutie, numeFisier);

            try
            {
                AdministrareActiv_Fisier adminActivitati = new AdministrareActiv_Fisier(caleCompletaFisier);
                int nrActivitati = 0;
                Activitate[] activitati = adminActivitati.GetActiv(out nrActivitati);

                listBoxActivitati.Items.Clear();

                for (int i = 0; i < nrActivitati; i++)
                {
                    listBoxActivitati.Items.Add($"{i + 1}: {activitati[i].ToString()}");
                }

                dataGridViewActivitati.DataSource = activitati; // Setăm sursa de date pentru DataGridView

                // Opțional, putem specifica anumite coloane pentru afișare
                dataGridViewActivitati.Columns["nrActiv"].Visible = false; // Excludem coloana "nrActiv"
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citirea fișierului: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdauga_Click(object sender, EventArgs e)
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
            Activitate activitate = new Activitate(anInt, lunaInt, ziInt, oraInt, minInt, (TipDeActivitate)cmbTipActiv.SelectedItem, activ); // Conversia corectă a tipului de activitate
            adminActivitati.AddActiv(activitate);

            MessageBox.Show("Activitatea a fost adăugată cu succes în fișier!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearErrors();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            AfisareActivitati();
        }

        private void ShowError(Label label, string message)
        {
            label.ForeColor = System.Drawing.Color.Red; // Schimbare culoare text în roșu
            MessageBox.Show(message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ClearErrors()
        {
            lblAn.ForeColor = System.Drawing.SystemColors.ControlText; // Resetare culoare text la implicit
            lblLuna.ForeColor = System.Drawing.SystemColors.ControlText;
            lblZi.ForeColor = System.Drawing.SystemColors.ControlText;
            lblOra.ForeColor = System.Drawing.SystemColors.ControlText;
            lblMin.ForeColor = System.Drawing.SystemColors.ControlText;
        }
    }*/
}
