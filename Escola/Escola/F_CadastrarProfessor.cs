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
    public partial class F_CadastrarProfessor : Form
    {
        public F_CadastrarProfessor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Conexão com o banco de dados
            string strconn = ("Data Source=EUCLIDES\\SQLEXPRESS; " +
                    "Initial Catalog=Senac;Integrated Security=true");
            SqlConnection conn = new SqlConnection(strconn);
            //Comando SQL
            String sql = "INSERT INTO Professores" +
                "(nome, cpf, usuario, senha, dataAdmissao, segmento) " +
                "VALUES(@nome, @cpf, @usuario, @senha, @dataAdmissao, @segmento)";

            try
            {
                //Adicionar parâmetros
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@nome", tbxNome.Text));
                comando.Parameters.Add(new SqlParameter("@cpf", tbxCPF.Text));
                comando.Parameters.Add(new SqlParameter("@usuario", tbxUsuario.Text));
                comando.Parameters.Add(new SqlParameter("@senha", tbxSenha.Text));
                comando.Parameters.Add(new SqlParameter("@dataAdmissao", dtpDataAdmissao.Text));
                comando.Parameters.Add(new SqlParameter("@segmento", cbxSegmento.Text));

                //Abrir conexão
                conn.Open();
                //executar comando SQL
                comando.ExecuteNonQuery();
                
                MessageBox.Show("Professor Cadastrado com Sucesso!",
                     " cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Não foi possivel cadastrar"
                    , " Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Fechar conexão
                conn.Close();
            }
        }
    }
}
