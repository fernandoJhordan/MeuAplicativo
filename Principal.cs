using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuAplicativo
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            this.Text = ClasseEstatica.TituloSistema;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ClasseNormal Cn = new ClasseNormal();
            Cn.Nome = "Fernando";
            Cn.MostrarNome();

            ClasseNormal Cn2 = new ClasseNormal();
            Cn2.Nome = "Alex";
            Cn2.MostrarNome();

            //////////////////
            ///
            //ClasseEstatica. = "Brandão";
            //ClasseEstatica.ExibirNome();

        }
    }
}
