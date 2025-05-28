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
    public partial class frmCadDentista : Form
    {
        dentistaService service = new dentistaService();
        public frmCadDentista()
        {
            InitializeComponent();
        }
        private string ValidarCad()
        {
            tsm.ForeColor = Color.Red;
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {   
                return "Preencha o campo nome";
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                return "Preencha o campo email";
            }
            else if (txtCelular.Text == string.Empty)
            {
                return "Preencha o campo celular";
            }
            else if (string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                return "Preencha o campo telefone";
            }
            else if (string.IsNullOrWhiteSpace(txtCRO.Text))
            {
                return "Preencha o campo CRO";
            } 
            else
            {
                tsm.ForeColor = Color.Black;
                return "Sucesso";
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {  
            try
            {
                tsnenhuma.Text = "";
                tsm.Text = ValidarCad();
                if(tsm.Text == "Sucesso")
                {
                    service.cadastrar(objGerado());
                    MessageBox.Show("Cadastro efetuado com sucesso");
                    this.Close();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Erro ao salvar " + ex.Message);
            }
        }

        public Dentista objGerado()
        {
            Dentista obj = new Dentista();

            obj.Name = txtNome.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = txtTelefone.Text != "" ? Convert.ToInt64(txtTelefone.Text) : 0;
            obj.Celular = txtCelular.Text != "" ? Convert.ToInt64(txtCelular.Text) : 0;
            obj.CRO = txtCRO.Text;

            return obj;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        public void limpar()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtCRO.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtCelular.Text = string.Empty;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmConDentista frm = new frmConDentista();
            frm.ShowDialog();
        }
    }
}
