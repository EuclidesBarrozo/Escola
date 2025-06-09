using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class F_GerenciarAlunos : Form
    {
        public F_GerenciarAlunos()
        {
            InitializeComponent();
        }

        private void F_GerenciarAlunos_Load(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=EUCLIDES\\SQLEXPRESS;" +
                "Initial Catalog=Senac;Integrated Security=true");
            
            string command = "select nome, cpf, dataNascimento from dbo.T_Alunos";
            try
            {
                //executa o comando SQL e recebendo os dados
                SqlDataAdapter da = new SqlDataAdapter(command, sql);
                //instância um DataTable - que servirá de intermediário
                DataTable dt = new DataTable();
                //Preencher o dt com os dados presente no da
                da.Fill(dt);
                //Preencher o dataGridView com os dados do dt
                dgvListaAlunos.DataSource = dt;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Listar Alunos", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvListaAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
