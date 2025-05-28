using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOdonto
{
    public partial class frmAnotacoes : Form
    {
        public string texto { get; set; }
        public Color cor { get; set; }
        public frmAnotacoes()
        {
            InitializeComponent();
        }

        private void btnAmarelo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            this.cor = Color.Yellow;
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.YellowGreen;
            this.cor = Color.YellowGreen;
        }

        private void btnLaranja_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 128, 0);
            this.cor = Color.FromArgb(255, 128, 0);
        }

        private void btnRoxo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(128, 128, 255);
            this.cor = Color.FromArgb(128, 128, 255);
        }

        private void btnRosa_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 128, 255);
            this.cor = Color.FromArgb(255, 128, 255);
        }

        private void btnAdicionarLembrete_Click(object sender, EventArgs e)
        {
            this.texto = richTextBox1.Text;
            this.Close();
        }
    }
}
