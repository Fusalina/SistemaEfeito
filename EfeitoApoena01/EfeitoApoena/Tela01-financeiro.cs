﻿using System;
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
    public partial class Tela01_financeiro : Form
    {
        public Tela01_financeiro()
        {
            InitializeComponent();
        }

        private void pictureBox2_click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
