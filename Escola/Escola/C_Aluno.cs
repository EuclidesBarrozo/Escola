using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    
    public class C_Aluno
    {
        //ATRIBUTOS
        private int id;
        private string nome;
        private string cpf;
        private string usuario;
        private string senha;
        private string salt;
        private DateTimePicker dataNascimento;
        private C_Conexao c_conexao = new C_Conexao();

        //MÉTODOS
        public void cadastrarAluno(string n, string c, string u, string se, DateTimePicker dn)
        {
            
            SqlConnection conn = c_conexao.abrirConexao();
            //Comando SQL
            String sql = "INSERT INTO T_Alunos" +
                "(nome, cpf, usuario, senha, salt, dataNascimento) " +
                "VALUES(@nome, @cpf, @usuario, @senha, @salt, @dataNascimento)";

            try
            {
                string salt = PasswordHelper.GenerateSalt();
                string senhaHash = PasswordHelper.HashPassword(se, salt);
                //Adicionar parâmetros
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@nome", n));
                comando.Parameters.Add(new SqlParameter("@cpf", c));
                comando.Parameters.Add(new SqlParameter("@usuario", u));
                comando.Parameters.Add(new SqlParameter("@senha", senhaHash));
                comando.Parameters.Add(new SqlParameter("@salt", salt));
                comando.Parameters.Add(new SqlParameter("@dataNascimento", dn.Text));

                String verificacao = c_conexao.modificarDados(comando, conn);

                if(verificacao == "ok") 
                {
                    MessageBox.Show("Aluno(a) Cadastrado(a) com Sucesso!",
                      " cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possivel cadastrar"
                    , " Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
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

        public SqlDataAdapter selecionarTodos()
        {
            SqlConnection conn = c_conexao.abrirConexao();
            string command = "select nome, cpf, dataNascimento " +
                "as 'Data Nascimento' from dbo.T_Alunos";
            SqlDataAdapter da = c_conexao.selecionarDados(command, conn);
            conn.Close();
            return da; 
        }
        public SqlDataReader selecionarNomes()
        {
            SqlConnection conn = c_conexao.abrirConexao();
            string command = "SELECT (RTRIM(nome)) as nome from dbo.T_Alunos";
            SqlDataReader reader = c_conexao.selecionarDadosReader(command, conn);
            return reader;
            
        }

        public SqlDataAdapter FiltrarNomes(string pesquisaNome)
        {
            string command = $"select nome, cpf, dataNascimento " +
                $"from dbo.T_Alunos WHERE nome LIKE '%{pesquisaNome}%'";
            SqlConnection conn = c_conexao.abrirConexao();
            SqlDataAdapter da  = c_conexao.selecionarDados(command, conn);
            conn.Close();
            return da;
        }


    }
}
