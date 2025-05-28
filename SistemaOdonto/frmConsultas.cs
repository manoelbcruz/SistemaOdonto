using Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;

namespace SistemaOdonto
{
    public partial class frmConsultas : Form
    {
        consultaService service = new consultaService();
        pacienteService serviceP = new pacienteService();
        dentistaService serviceD = new dentistaService();

        private Dictionary<int, DataGridView> DataGridViews = new Dictionary<int, DataGridView>();
        public frmConsultas()
        {
            InitializeComponent();
            iniciar();
        }
        private void iniciar()
        {
            var listaD = serviceD.listar();
            foreach (var dentista in listaD)
            {
                tabControl1.TabPages.Add(dentista.Id.ToString(), dentista.Name);
                DataGridView dg = new DataGridView();
                DataGridViews.Add(dentista.Id, dg);
                gerarTabela(dg);
                tabControl1.TabPages[dentista.Id.ToString()].Controls.Add(dg);
            }
        }

        private void gerarTabela(DataGridView dgv)
        {
            dgv.ReadOnly = true; //So ler
            dgv.AllowUserToAddRows = false; //N deixar automatizado o add linhas
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //automatizar o tamanho da coluna
            dgv.AllowUserToResizeColumns = false; //n permite redimensionar as colunas
            dgv.AllowUserToResizeRows = false; //n permite redimensionar as linhas
            dgv.Dock = DockStyle.Fill; //preenchimento de estilo
            dgv.RowHeadersVisible = false; //Sem linha do cabeçalho
            dgv.BackgroundColor = Color.White; //Muda cor de fundo da grid
            dgv.RowsDefaultCellStyle.BackColor = Color.Bisque; //Muda cor de fundo da celula
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige; //Deixa a linha zebrado
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selecionar a linha toda
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkGray; //Muda cor da celula selecionada
            dgv.DefaultCellStyle.ForeColor = Color.Black; //Muda cor da linha da celula
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None; //Muda o estilo da borda

            dgv.Columns.Add("ColunaCodigoConsulta", "CodigoConsulta");
            dgv.Columns[0].Visible = false;
            dgv.Columns.Add("ColunaHora", "");
            DataGridViewLinkColumn colPaciente = new DataGridViewLinkColumn();
            colPaciente.HeaderText = "Paciente";
            colPaciente.Name = "ColunaNomePaciente";
            dgv.Columns.Add(colPaciente);
            dgv.Columns.Add("ColunaStatus", "Status");
            DataGridViewLinkColumn colConsulta = new DataGridViewLinkColumn();
            colConsulta.HeaderText = "";
            colConsulta.Name = "ColunaVerConsulta";
            dgv.Columns.Add(colConsulta);
            dgv.CellContentClick += new DataGridViewCellEventHandler(this.Tabela_Clicada);
        }

        private void Tabela_Clicada(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            var idConsulta = dgv.Rows[e.RowIndex].Cells[0].Value;
            Consulta c = service.buscar(Convert.ToInt32(idConsulta));

            try
            {
                if (e.ColumnIndex == 2 && e.RowIndex != -1)
                {
                    Paciente p = serviceP.buscar(c.IdPaciente);
                    frmEditPaciente frm = new frmEditPaciente(p);
                    frm.ShowDialog();
                    atualizarLinhas();
                }
                if (e.ColumnIndex == 4 && e.RowIndex != -1)
                {
                    var Form = new frmEditConsulta(c);
                    Form.ShowDialog();
                    atualizarLinhas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro, favor entrar em contato com o adminstrador do sistema" + ex.Message);
            }
        }

        public void gerarLinha(DataGridView dg, int dentistaId)
        {
            var dentista = serviceD.buscar(dentistaId);
            List<Consulta> consultas = service.buscar(dentista, Convert.ToDateTime(dtDataBuscar.Value.ToString("dd/MM/yyyy"))).OrderBy(x => x.HoraMarcada).ToList();

            foreach (var item in consultas)
            {
                int linhaAtual = dg.Rows.Add();
                dg.Rows[linhaAtual].Cells[0].Value = item.IdConsulta;
                dg.Rows[linhaAtual].Cells[1].Value = item.HoraMarcada.Value.ToString("HH:mm");
                dg.Rows[linhaAtual].Cells[2].Value = serviceP.buscar(Convert.ToInt32(item.IdPaciente)).Name;
                dg.Rows[linhaAtual].Cells[3].Value = item.Status;
                dg.Rows[linhaAtual].Cells[4].Value = "Ver consulta";

            }   
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            atualizarLinhas();
        }

        private void atualizarLinhas()
        {
            if(tabControl1.SelectedTab.Name != "HomeAgenda")
            {
                var indiceTab = Convert.ToInt32(tabControl1.SelectedTab.Name);
                DataGridViews[indiceTab].Rows.Clear();
                gerarLinha(DataGridViews[indiceTab], indiceTab);
            }
        }

        private void btnBuscarData_Click(object sender, EventArgs e)
        {
            atualizarLinhas();
        }

        private void btnEsquerdo_Click(object sender, EventArgs e)
        {
            dtDataBuscar.Value = dtDataBuscar.Value.AddDays(-1);
            atualizarLinhas();
        }

        private void BtnDireito_Click(object sender, EventArgs e)
        {
            dtDataBuscar.Value = dtDataBuscar.Value.AddDays(1);
            atualizarLinhas();
        }
    }
}
