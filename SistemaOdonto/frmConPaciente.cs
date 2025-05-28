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
    public partial class frmConPaciente : Form
    {
        pacienteService service = new pacienteService();
        public frmConPaciente()
        {
            InitializeComponent();
            iniciar();
        }
        public void iniciar()
        {
            var lista = service.listar();
            if (lista == null)
            {
                MessageBox.Show("Nao possui pacientes cadastrados");
            }
            else
            {
                char caracter = '#';
                int numTabela = -1;
                DataGridView data = new DataGridView();

                foreach (var dado in lista)
                {
                    char primeiraLetra = dado.Name.Trim()[0];

                    if (primeiraLetra.ToString().ToUpper() == caracter.ToString().ToUpper()) gerarLinha(data, dado);
                    else
                    {
                        numTabela++;
                        tc.TabPages.Add(primeiraLetra.ToString().ToUpper());
                        DataGridView dg = new DataGridView();
                        data = dg;
                        tc.TabPages[numTabela].Controls.Add(dg);
                        gerarTabela(dg);
                        gerarLinha(dg, dado);

                        caracter = primeiraLetra;
                    }
                }
            }
        }
        private void gerarTabela(DataGridView dg)
        {
            dg.ReadOnly = true; //So ler
            dg.AllowUserToAddRows = false; //N deixar automatizado o add linhas
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //automatizar o tamanho da coluna
            dg.AllowUserToResizeColumns = false; //n permite redimensionar as colunas
            dg.AllowUserToResizeRows = false; //n permite redimensionar as linhas
            dg.Dock = DockStyle.Fill; //preenchimento de estilo
            dg.RowHeadersVisible = false; //Sem linha do cabeçalho
            dg.BackgroundColor = Color.White; //Muda cor de fundo da grid
            dg.RowsDefaultCellStyle.BackColor = Color.Bisque; //Muda cor de fundo da celula
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige; //Deixa a linha zebrado
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selecionar a linha toda
            dg.DefaultCellStyle.SelectionBackColor = Color.DarkGray; //Muda cor da celula selecionada
            dg.DefaultCellStyle.ForeColor = Color.Black; //Muda cor da linha da celula
            dg.CellBorderStyle = DataGridViewCellBorderStyle.None; //Muda o estilo da borda

            dg.Columns.Add("Codigo", "Código");
            dg.Columns[0].Visible = false;

            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            link.HeaderText = "Nome";

            link.Name = "Nome";
            dg.Columns.Add(link);

            dg.Columns.Add("Telefone", "Telefone");
            dg.Columns.Add("Celular", "Celular");

            dg.CellContentClick += new DataGridViewCellEventHandler(this.tbClick);
        }
        private void tbClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = sender as DataGridView;
            try
            {
                if (e.ColumnIndex == 1 && e.RowIndex != -1)
                {
                    var id = dg.Rows[e.RowIndex].Cells[0].Value;
                    Paciente obj = service.buscar(Convert.ToInt32(id));

                    var form = new frmEditPaciente(obj);

                    form.ShowDialog();

                    if (form.status == "apagado")
                    {
                        this.Close();
                        frmConPaciente frm = new frmConPaciente();
                        frm.ShowDialog();
                    }
                    if (form.status == "editado")
                    {
                        dg.Rows.RemoveAt(e.RowIndex);
                        gerarLinha(dg, obj);
                    }



                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }
        private void gerarLinha(DataGridView data, Paciente dado)
        {
            int novaLinha = data.Rows.Add();
            data.Rows[novaLinha].Cells[0].Value = dado.Id;
            data.Rows[novaLinha].Cells[1].Value = dado.Name;
            data.Rows[novaLinha].Cells[2].Value = dado.Telefone.ToString("(00) 0000-0000");
            data.Rows[novaLinha].Cells[3].Value = dado.Celular.ToString("(00) 00000-0000");
        }
    }
}
