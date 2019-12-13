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

        Conexao con = new Conexao();

        public Menu02_cadastro()
        {
            InitializeComponent();
        }

        private void txtbNome_TextChanged(object sender, EventArgs e)
        {
            /*(txtbNome.Enabled = false;
                if (txtbNome.Enabled == false)
                {
                this.txtbNome.BackColor = Color.LightGray;
                }else
                {
                this.txtbNome.BackColor = Color.DarkGray;
                }
            */
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu02_cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
