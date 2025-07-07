using System;
using System.Collections;
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
            
            C_Aluno c_Aluno = new C_Aluno();
            try
            {
                //executa o comando SQL e recebendo os dados
                SqlDataAdapter da = c_Aluno.selecionarTodos();
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
            //Preencher comboBox
            try
            {
                SqlDataReader reader = c_Aluno.selecionarNomes();

                while (reader.Read())
                {
                    string nomeAluno = reader["nome"].ToString();
                    cbbNomeAlunos.Items.Add(nomeAluno);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar alunos: " + ex.Message);
            }

        }

        private void dgvListaAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            
            String pesquisaNome = tbxPesquisarNome.Text;
           
            try
            {
                C_Aluno c_Aluno = new C_Aluno();
                //executa o comando SQL e recebendo os dados
                SqlDataAdapter da = c_Aluno.FiltrarNomes(pesquisaNome);
                //instância um DataTable - que servirá de intermediário
                DataTable dt = new DataTable();
                //Preencher o dt com os dados presente no da
                da.Fill(dt);
                //Preencher o dataGridView com os dados do dt
                dgvListaAlunos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Listar Alunos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            tbxNome.Text = dgvListaAlunos.CurrentRow.Cells[0].Value.ToString();
            tbxCPF.Text = dgvListaAlunos.CurrentRow.Cells[1].Value.ToString();
            dtpDataNascimento.Text = dgvListaAlunos.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=EUCLIDES\\SQLEXPRESS;" +
                "Initial Catalog=Senac;Integrated Security=true");
            String cpf = dgvListaAlunos.CurrentRow.Cells[1].Value.ToString();
            SqlCommand command = new SqlCommand("UPDATE T_Alunos SET nome = @nome, " +
                $"cpf = @cpf, DataNascimento = @data_de_nascimento WHERE cpf = '{cpf}'", conn);
            try
            {
                command.Parameters.Add(new SqlParameter("@nome", tbxNome.Text));
                command.Parameters.Add(new SqlParameter("@cpf", tbxCPF.Text));
                command.Parameters.Add(new SqlParameter("@data_de_nascimento", dtpDataNascimento.Text));
                

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Alteração realizada com sucesso!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=EUCLIDES\\SQLEXPRESS;" +
                "Initial Catalog=Senac;Integrated Security=true");
            
            SqlCommand command = new SqlCommand("DELETE FROM T_Alunos WHERE cpf=@cpf", conn);
            String cpf = dgvListaAlunos.CurrentRow.Cells[1].Value.ToString();
            try
            { 
                command.Parameters.Add(new SqlParameter("@cpf", cpf));
               
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registro deletado com sucesso!", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
