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
    public partial class Menu03_acompanhamento : Form
    {
        public Menu03_acompanhamento()
        {
            InitializeComponent();
        }

        private void txtbNomeBusca_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
