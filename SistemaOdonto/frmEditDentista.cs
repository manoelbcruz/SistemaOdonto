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
    public partial class frmEditDentista : Form
    {
        public string status;
        Dentista obj = new Dentista();
        dentistaService service = new dentistaService(); 
        public frmEditDentista(Dentista obj)
        {
            InitializeComponent();
            iniciar(obj);
        }

        private void iniciar(Dentista obj)
        {
            this.obj = obj;
            lblCodigo.Text = this.obj.Id.ToString();
            txtNome.Text = this.obj.Name;
            txtCelular.Text = this.obj.Celular.ToString();
            txtTelefone.Text = this.obj.Telefone.ToString();
            txtEmail.Text = this.obj.Email;
            txtCRO.Text = this.obj.CRO;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            tsnenhuma.Text = "";
            tsn.Text = ValidarCad();
            if (tsn.Text == "Sucesso")
            {
                if(lblCodigo.Text != this.obj.Id.ToString())
                {
                    status = "apagado";
                    MessageBox.Show("Esse registro acabou de ser excluido por outro usuario");
                }
                else
                {
                    status = "editado";
                    this.obj.Name = txtNome.Text;
                    this.obj.Email = txtEmail.Text;
                    this.obj.Telefone = txtTelefone.Text != "" ? Convert.ToInt64(txtTelefone.Text) : 0;
                    this.obj.Celular = txtCelular.Text != "" ? Convert.ToInt64(txtCelular.Text) : 0;
                    this.obj.CRO = txtCRO.Text;

                    service.editar(this.obj);

                    this.Close();
                }
            }

        }
        private string ValidarCad()
        {
            tsn.ForeColor = Color.Red;
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
                tsn.ForeColor = Color.Black;
                return "Sucesso";
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            tsnenhuma.Text = "";
            if (validarExclusao()) 
            {
                service.excluir(this.obj.Id);

                MessageBox.Show("Excluido com sucesso");

                status = "apagado";

                tsn.Text = "Sucesso";

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
