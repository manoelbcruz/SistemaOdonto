using Entidade;
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
using WcfService;

namespace SistemaOdonto
{
    public partial class principal : Form
    {
        consultaService service = new consultaService();
        pacienteService serviceP = new pacienteService();
        dentistaService serviceD = new dentistaService();
        public principal()
        {
            InitializeComponent();
            iniciar();
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void MenuDentista_Click(object sender, EventArgs e)
        {
            frmCadDentista frm = new frmCadDentista();
            frm.ShowDialog();
        }

        private void MenuAGDentistas_Click(object sender, EventArgs e)
        {
            frmConDentista frm = new frmConDentista();
            frm.ShowDialog();
        }

        private void MenuPaciente_Click(object sender, EventArgs e)
        {
            frmCadPaciente frm = new frmCadPaciente();
            frm.ShowDialog();
        }

        private void MenuAGPacientes_Click(object sender, EventArgs e)
        {
            frmConPaciente frm = new frmConPaciente();
            frm.ShowDialog();
        }

        private void MenuConsulta_Click(object sender, EventArgs e)
        {
            frmCadConsulta frm = new frmCadConsulta();
            frm.ShowDialog();
        }

        private void MenuAGConsultas_Click(object sender, EventArgs e)
        {
            frmConsultas frm = new frmConsultas();
            frm.ShowDialog();
        }
        private void MenuAjuda_Click(object sender, EventArgs e)
        {
            frmSuporte frm = new frmSuporte();
            frm.ShowDialog();
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void iniciar()
        {
            try
            {
                var lista = serviceD.listar();
                var listaD = new Dictionary<int, string>();
                listaD.Add(0, "Selecione um dentista");
                foreach (var item in lista)
                {
                    listaD.Add(item.Id, item.Name);
                }
                cbDentista.DataSource = new BindingSource(listaD, null); //Pega os valores da listaD
                cbDentista.DisplayMember = "value";
                cbDentista.ValueMember = "key";
                atualizarAgenda(Convert.ToInt32(cbDentista.SelectedValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void atualizarAgenda(int id)
        {
            Dentista d = new Dentista();
            d = serviceD.buscar(id);

            if(d != null)
            {
                dg.Rows.Clear();
                gerarConsulta(d);
            }
        }

        private void gerarConsulta(Dentista d)
        {
            var con = service.buscar(d, Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"))).OrderBy(x => x.HoraMarcada);
            
            if(con == null)
            {
                MessageBox.Show("Esse dentista nao tem consulta marcada para hoje");
            }
            else
            {
                foreach (var item in con)
                {
                    int linha = dg.Rows.Add();

                    dg.Rows[linha].Cells[0].Value = item.IdConsulta;
                    dg.Rows[linha].Cells[1].Value = item.HoraMarcada.Value.ToString("HH:mm");
                    dg.Rows[linha].Cells[2].Value = serviceP.buscar(item.IdPaciente).Name;
                    dg.Rows[linha].Cells[3].Value = imagemStatus(item.Status);
                    dg.Rows[linha].Cells[4].Value = item.IdPaciente;

                }
            }
        }

        private Bitmap imagemStatus(string s)
        {
            Bitmap image;

            switch (s)
            {
                case "Confirmado":
                    image = ByteArrayToBitmap(Properties.Resources.Circle_Green);
                    break;
                case "Desmarcado":
                    image = ByteArrayToBitmap(Properties.Resources.Circle_Red);
                    break;
                case "Nao confirmado":
                    image = ByteArrayToBitmap(Properties.Resources.Circle_Grey);
                    break;
                case "Ja chegou":
                    image = ByteArrayToBitmap(Properties.Resources.Circle_Orange);
                    break;
                case "Em atendimento":
                    image = ByteArrayToBitmap(Properties.Resources.Circle_Blue);
                    break;
                default:
                    image = ByteArrayToBitmap(Properties.Resources.address171);
                    break;
            }

            return image; ;
        }

        private Bitmap ByteArrayToBitmap(byte[] imageBytes)
        {
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return new Bitmap(ms);
            }
        }

        private void cbDentista_SelectionChangeCommitted(object sender, EventArgs e)
        {
            atualizarAgenda(Convert.ToInt32(cbDentista.SelectedValue));
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                DataGridView dg = sender as DataGridView;
                int id = Convert.ToInt32(dg.Rows[e.RowIndex].Cells[4].Value);
                Paciente p = serviceP.buscar(id);
                frmEditPaciente frm = new frmEditPaciente(p);
                frm.Show();
            }
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                DataGridView dg = sender as DataGridView;
                int id = Convert.ToInt32(dg.Rows[e.RowIndex].Cells[0].Value);
                Consulta c = service.buscar(id);
                string status = c.Status;
                switch (status)
                {
                    case "Confirmado":
                        c.Status = "Desmarcado";
                        break;
                    case "Desmarcado":
                        c.Status = "Ja chegou";
                        break;
                    case "Ja chegou":
                        c.Status = "Em atendimento";
                        break;
                    case "Em atendimento":
                        c.Status = "Nao confirmado";
                        break;
                    case "Nao confirmado":
                        c.Status = "Confirmado";
                        break;
                    default:
                        c.Status = "Nao confirmado";
                        break;
                }
                service.editar(c);
                atualizarAgenda(Convert.ToInt32(cbDentista.SelectedValue));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAnotacoes frm = new frmAnotacoes();
            frm.ShowDialog();

            RichTextBox post = new RichTextBox();//Gera posts

            post.ReadOnly = true;
            post.BorderStyle = BorderStyle.None;
            post.Font = new Font(FontFamily.GenericSansSerif, 15F);
            post.ForeColor = Color.FromArgb(64,64,64);
            post.Width = 200;
            post.Height = 200;
            post.BackColor = frm.cor;
            post.Text = frm.texto;

            anot.Controls.Add(post);
        }
    }
}
