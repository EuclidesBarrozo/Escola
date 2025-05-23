using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String usuario = tbxUsuario.Text;
            String senha   = tbxSenha.Text;
            String perfil  = cbxPerfil.Text;

            if(perfil == "Diretor")
            {
                F_Diretor janelaDiretor = new F_Diretor(this);
                janelaDiretor.ShowDialog();
                this.Close();
            }
        }
    }
}
