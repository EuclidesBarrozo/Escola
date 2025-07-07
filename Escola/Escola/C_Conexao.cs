using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public class C_Conexao
    {

        //MÉTODOS
        public SqlConnection abrirConexao()
        {
            string strconn = ("Data Source=EUCLIDES\\SQLEXPRESS; " +
             "Initial Catalog=Senac;Integrated Security=true");
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            return conn;
        }
        public string modificarDados(SqlCommand c, SqlConnection conn)
        {
            try
            {
                //conn.Open();
                c.ExecuteNonQuery();
                conn.Close();
                return "ok";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "erro";
            }
            
            
        }
        public SqlDataAdapter selecionarDados(string c, SqlConnection conn)
        {
            SqlDataAdapter da = new SqlDataAdapter(c, conn);
            return da;
        }

        public SqlDataReader selecionarDadosReader(string c, SqlConnection conn)
        {
            //conn.Open();
            SqlCommand comando = new SqlCommand(c, conn);
            SqlDataReader reader = comando.ExecuteReader();
            return reader;
        }
    }
}
