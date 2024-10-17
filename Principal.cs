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
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //ClasseNormal Cn = new ClasseNormal();

            MessageBox.Show(ClasseEstatica.Nome);
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
