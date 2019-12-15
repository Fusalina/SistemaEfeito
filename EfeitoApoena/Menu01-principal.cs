using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfeitoApoena
{
    public partial class Menu01 : Form
    {
        public Menu01()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Menu01_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e) {

            Menu02_cadastro FormCadastro = new Menu02_cadastro();
            FormCadastro.ShowDialog();
        }

        private void btnAcompanhamento_Click(object sender, EventArgs e)
        {
            Menu03_acompanhamento FormCadastro = new Menu03_acompanhamento();
            FormCadastro.ShowDialog();
        }

        private void btnFinan_click(object sender, EventArgs e) {
            Tela01_financeiro FormCadastro = new Tela01_financeiro();
            FormCadastro.ShowDialog();
        }


    }
}
