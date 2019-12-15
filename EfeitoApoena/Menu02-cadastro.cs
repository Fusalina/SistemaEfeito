using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace EfeitoApoena
{
    public partial class Menu02_cadastro : Form
    {
        Aluno AlunoClass = new Aluno();
        Endereco EnderecoClass = new Endereco();
        public Menu02_cadastro()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu02_cadastro_Load(object sender, EventArgs e)
        {

        }

        //Limpar ao clicar
        private void txtbNome_Clear(object sender, EventArgs e) {
            txtbNome.Text = String.Empty;
        }
        
        private void txtbDataNasc_clear(object sender, EventArgs e) {
            txtbDataNasc.Text = String.Empty;
        }

        private void txtbCpf_clear(object sender, EventArgs e) {
            txtbCpf.Text = String.Empty;
        }

        private void txtbEmail_clear(object sender, EventArgs e) {
            txtbEmail.Text = String.Empty;
        }

        private void txtbTel_clear(object sender, EventArgs e) {
            txtbTel.Text = String.Empty;
        }

        private void txtbCel_clear(object sender, EventArgs e) {
            txtbCel.Text = String.Empty;
        }

        private void txtbRua_clear(object sender, EventArgs e) {
            txtbRua.Text = String.Empty;
        }

        private void txtbNRua_clear(object sender, EventArgs e) {
            txtbNRua.Text = String.Empty;
        }

        private void txtbBairro_clear(object sender, EventArgs e) {
            txtbBairro.Text = String.Empty;
        }

        private void txtbCidade_clear(object sender, EventArgs e) {
            txtbCidade.Text = String.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AlunoClass.Nome = txtbNome.Text;
            AlunoClass.DataNasc = DateTime.Parse(txtbDataNasc.Text);
            AlunoClass.Cpf = double.Parse(txtbCpf.Text);
            AlunoClass.Email = txtbEmail.Text;
            AlunoClass.Telefone = double.Parse(txtbTel.Text);
            AlunoClass.Celular = double.Parse(txtbCel.Text);

            if (rbtnHomem.Checked) { AlunoClass.Sexo = 'M'; }
            if (rbtnMulher.Checked) { AlunoClass.Sexo = 'F'; }
            if (rbtnTipoA.Checked) { AlunoClass.TpSang = "A"; }
            if (rbtnTipoAB.Checked) { AlunoClass.TpSang = "AB"; }
            if (rbtnTipoB.Checked) { AlunoClass.TpSang = "B"; }
            if (rbtnTipoO.Checked) { AlunoClass.TpSang = "O"; }
            if (rbtnPositivo.Checked) { AlunoClass.FatorRH = 'P'; }
            if (rbtnNegativo.Checked) { AlunoClass.FatorRH = 'N'; }

            EnderecoClass.Rua = txtbRua.Text;
            EnderecoClass.NumCasa = int.Parse(txtbNRua.Text);
            EnderecoClass.Bairro = txtbBairro.Text;
            EnderecoClass.Cidade = txtbCidade.Text;

        }
    }
}
