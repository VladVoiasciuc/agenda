using LibrarieModele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidentaActiv_UI
{
    public partial class AdaugGrActiv : Form
    {
        public AdaugGrActiv()
        {
            InitializeComponent();
        }

        public AdaugGrActiv(Form1 f)
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 w = new Form1();
            this.Visible = false;
            w.Show();
        }
    }
} 