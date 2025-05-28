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
    public partial class frmSuporte : Form
    {
        private relatorioService service = new relatorioService();
        public frmSuporte()
        {
            InitializeComponent();
        }
        private string ValidarCad()
        {
            tsn.ForeColor = Color.Red;
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                return "Preencha o campo nome";
            }
            else if (string.IsNullOrWhiteSpace(txtMensagem.Text))
            {
                return "Preencha o campo mensagem";
            }
            else if (txtEndereco.Text == string.Empty)
            {
                return "Preencha o campo endereco";
            }
            else if (string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                return "Preencha o campo telefone";
            }
            else
            {
                tsn.ForeColor = Color.Black;
                return "Sucesso";
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                tsnenhuma.Text = "";
                tsn.Text = ValidarCad();
                if (tsn.Text == "Sucesso")
                {
                    service.salvar(objGerado());
                    MessageBox.Show("Relatorio enviado com sucesso");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar " + ex.Message);
            }
        }

        private Relatorio objGerado()
        {
            Relatorio obj = new Relatorio();

            obj.Name = txtNome.Text;
            obj.Telefone = txtTelefone.Text != "" ? Convert.ToInt64(txtTelefone.Text) : 0;
            obj.Endereco = txtEndereco.Text;
            obj.Mensagem = txtMensagem.Text;

            return obj;
        }
    }
}
