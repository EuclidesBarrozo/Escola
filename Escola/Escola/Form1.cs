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
            if(perfil == "Professor")
            {
                F_Professor janelaProfessor = new F_Professor(this);
                janelaProfessor.ShowDialog();
                this.Close();
            }
            if(perfil == "Aluno")
            {
                 string strconn = ("Data Source=EUCLIDES\\SQLEXPRESS; " +
                     "Initial Catalog=Senac;Integrated Security=true");
                 SqlConnection conn = new SqlConnection(strconn);
                 try
                 {
                    //
                     conn.Open();
                     String sql = "SELECT senha, salt FROM T_Alunos " +
                         "WHERE usuario = @usuario";
                     SqlCommand cmd = new SqlCommand(sql, conn);

                     cmd.Parameters.AddWithValue("@usuario", usuario);

                    //cmd.ExecuteReader - comando para realizar a leitura no banco de dados
                     using (SqlDataReader reader = cmd.ExecuteReader())
                     {
                        //verifica se retornou algum valor do banco de dados
                         if (reader.Read())
                         {
                            //reader.GetString(0) - retorna a string da coluna zero
                            //retornada do banco de dados
                            string senhaHashBanco = reader.GetString(0);
                            string saltBanco = reader.GetString(1);
                            //remove espaços em branco
                            saltBanco = saltBanco.Replace(" ", "");
                            
                            string senhaHashDigitada = PasswordHelper.HashPassword(senha, saltBanco);

                             //
                            senhaHashBanco = senhaHashBanco.Replace(" ", "");
                            senhaHashDigitada = senhaHashDigitada.Replace(" ", "");
                            if (senhaHashDigitada == senhaHashBanco)
                             {
                                 F_Aluno janelaAluno = new F_Aluno(this);
                                 janelaAluno.ShowDialog();
                                 this.Close();
                             }
                             else
                             {
                                 MessageBox.Show("Usuário ou senha inválidos"
                     , " Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             }
                         }
                     }
                 }catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message
                     , " Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                
            }
        }
    }
}
