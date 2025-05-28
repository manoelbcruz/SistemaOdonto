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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaOdonto
{
    public partial class frmEditConsulta : Form
    {
        Consulta obj = new Consulta();
        consultaService service = new consultaService();
        pacienteService serviceP = new pacienteService();
        dentistaService serviceD = new dentistaService();
        public frmEditConsulta(Consulta c)
        {
            InitializeComponent();
            iniciar(c);
        }
        private void iniciar(Consulta obj)
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

            this.obj = obj;

            lblCodigo.Text = this.obj.IdConsulta.ToString();
            txtDescricao.Text = this.obj.Observacao;
            cbDentista.Text = serviceD.buscar(this.obj.IdDentista).Name;
            cbPaciente.Text = serviceP.buscar(this.obj.IdPaciente).Name;
            dtData.Text = this.obj.Data.ToString();
            dtHora.Text = this.obj.HoraMarcada.ToString();
            dtFim.Text = this.obj.HoraFim.ToString();
            dtInicio.Text = this.obj.HoraInicio.ToString();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            tsnenhuma.Text = "";
            tsm.Text = ValidarCad();
            if (tsm.Text == "Sucesso")
            {    

                this.obj.Data = dtData.Value;
                this.obj.HoraMarcada = dtHora.Value;
                this.obj.HoraInicio = dtInicio.Value;
                this.obj.HoraFim = dtFim.Value;
                this.obj.Observacao = txtDescricao.Text;
                this.obj.IdDentista = Convert.ToInt32(cbDentista.SelectedValue);
                this.obj.IdPaciente = Convert.ToInt32(cbPaciente.SelectedValue);
                

                service.editar(this.obj);

                this.Close();
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
            else if (dtInicio.Text == string.Empty)
            {
                return "Selecione uma hora inicial da consulta";
            }
            else if (dtFim.Text == string.Empty)
            {
                return "Selecione uma hora final da consulta";
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

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            tsnenhuma.Text = "";
            if (validarExclusao())
            {
                service.excluir(this.obj.IdConsulta);

                MessageBox.Show("Excluido com sucesso");


                tsm.Text = "Sucesso";

                this.Close();
            }
        }
        public Boolean validarExclusao()
        {
            DialogResult con = MessageBox.Show("Deseja ecluir esse registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (con == DialogResult.Yes) return true;
            else return false;
        }
    }
}
