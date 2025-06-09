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
    public partial class F_CadastrarAluno : Form
    {
        public F_CadastrarAluno()
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
            String sql = "INSERT INTO T_Alunos" +
                "(nome, cpf, usuario, senha, salt, dataNascimento) " +
                "VALUES(@nome, @cpf, @usuario, @senha, @salt, @dataNascimento)";

            try
            {
                string salt = PasswordHelper.GenerateSalt();
                string senhaHash = PasswordHelper.HashPassword(tbxSenha.Text, salt);
                //Adicionar parâmetros
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@nome", tbxNome.Text));
                comando.Parameters.Add(new SqlParameter("@cpf", tbxCPF.Text));
                comando.Parameters.Add(new SqlParameter("@usuario", tbxUsuario.Text));
                comando.Parameters.Add(new SqlParameter("@senha", senhaHash));
                comando.Parameters.Add(new SqlParameter("@salt", salt));
                comando.Parameters.Add(new SqlParameter("@dataNascimento", dtpDataNascimento.Text));
                
                //Abrir conexão
                conn.Open();
                //executar comando SQL
                comando.ExecuteNonQuery();

                MessageBox.Show($"{senhaHash} \n {salt}"
                    , " Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                MessageBox.Show("Aluno(a) Cadastrado(a) com Sucesso!",
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
