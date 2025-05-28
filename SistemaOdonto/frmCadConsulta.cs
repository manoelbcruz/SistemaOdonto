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
    public partial class frmCadConsulta : Form
    {
        consultaService service = new consultaService();
        pacienteService serviceP = new pacienteService();
        dentistaService serviceD = new dentistaService();
        public frmCadConsulta()
        {
            InitializeComponent();
            
            iniciar();
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
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            try
            {
                var lista = serviceP.listar();
                var listaP = new Dictionary<int, string>();
                listaP.Add(0, "Selecione um paciente");
                foreach (var item in lista)
                {
                    listaP.Add(item.Id, item.Name);
                }
                cbPaciente.DataSource = new BindingSource(listaP, null); //Pega os valores da listaP
                cbPaciente.DisplayMember = "value";
                cbPaciente.ValueMember = "key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                tsnenhuma.Text = "";
                tsm.Text = ValidarCad();
                if (tsm.Text == "Sucesso")
                {
                    service.cadastrar(objGerado());
                    MessageBox.Show("Cadastro efetuado com sucesso");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
            }
        }
        private string ValidarCad()
        {
            tsm.ForeColor = Color.Red;
            if (Convert.ToInt32(cbDentista.SelectedValue) == 0)
            {
                return "Selecione um dentista";
            }
            else if (Convert.ToInt32(cbPaciente.SelectedValue) == 0)
            {
                return "Selecione um paciente";
            }
            else if (dtData.Text == string.Empty)
            {
                return "Selecione uma data";
            }
            else if (dtHora.Text == string.Empty)
            {
                return "Selecione um horário";
            }
            else
            {
                tsm.ForeColor = Color.Black;
                return "Sucesso";
            }
        }
        public Consulta objGerado()
        {
            Consulta obj = new Consulta();

            obj.IdDentista = Convert.ToInt32(cbDentista.SelectedValue);
            obj.IdPaciente = Convert.ToInt32(cbPaciente.SelectedValue);
            obj.Data = Convert.ToDateTime(dtData.Value.ToString("dd/MM/yyyy"));
            obj.HoraMarcada = dtHora.Value;
            obj.HoraInicio = Convert.ToDateTime("00:00");
            obj.HoraFim = Convert.ToDateTime("00:00");
            obj.Observacao = txtDescricao.Text;
            obj.Status = "Nao confirmado";

            return obj;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmConsultas frm = new frmConsultas();
            frm.ShowDialog();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        public void limpar()
        {
            txtDescricao.Text = "";
            cbDentista.Text = "Selecione um dentista";
            cbPaciente.Text = "Selecione um paciente";
            dtData.Text = "";
            dtHora.Text = "";
        }
    }
}
