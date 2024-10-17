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
        //globa estrutura
        struct EstruturaPessoa 
        {
            public string Nome;
            public string Sobre;
        }


        public Principal()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {   
            //atribuindo valor as propriedades
            EstruturaPessoa Ep = new EstruturaPessoa()
            {
                Nome = "Alex", Sobre="Rodrigues"
            };
            //atribuindo valor as propriedades
            //Ep.Nome = "Alex";
            //Ep.Sobre = "Rodrigues";

            MessageBox.Show("Sou " + Ep.Nome + " "  + Ep.Sobre);
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
